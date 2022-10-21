using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Open.Nat;

namespace NatPortOpener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
#if DEBUG
            NatDiscoverer.TraceSource.Switch.Level = SourceLevels.Verbose;
#else
            NatDiscoverer.TraceSource.Switch.Level = SourceLevels.Information;
#endif
            NatDiscoverer.TraceSource.Listeners.Add(new EventLogListener(AddNewEventToLog));

            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            NatDiscoverer.ReleaseAll();
        }

        class EventLogListener : TraceListener
        {
            readonly Action<string> writeCallback;

            public EventLogListener(Action<string> callback)
            {
                writeCallback = callback;
            }

            public override void Write(string? message)
            {
                if (message == null) return;
                writeCallback(message);
            }

            public override void WriteLine(string? message)
            {
                if (message == null) return;
                writeCallback(message);
            }
        }

        private void AddNewEventToLog(string EventMessage)
        {
            if (EventMessage.Length < 1) return;

            if (EventHistory.InvokeRequired)
            {
                EventHistory.Invoke(delegate { AddNewEventToLog(EventMessage); });
            }
            else
            {
                string[] lines = SplitToLines(EventMessage, 100).ToArray();

                foreach (var line in lines)
                {
                    EventHistory.Items.Add(line);
                }
            }
        }

        IEnumerable<string> SplitToLines(string stringToSplit, int maximumLineLength)
        {
            var words = stringToSplit.Split(' ').Concat(new[] { "" });
            return
                words
                    .Skip(1)
                    .Aggregate(
                        words.Take(1).ToList(),
                        (a, w) =>
                        {
                            var last = a.Last();
                            while (last.Length > maximumLineLength)
                            {
                                a[a.Count() - 1] = last.Substring(0, maximumLineLength);
                                last = last.Substring(maximumLineLength);
                                a.Add(last);
                            }
                            var test = last + " " + w;
                            if (test.Length > maximumLineLength)
                            {
                                a.Add(w);
                            }
                            else
                            {
                                a[a.Count() - 1] = test;
                            }
                            return a;
                        });
        }

        private void OpenPort_Click(object sender, EventArgs e)
        {
            var pubPort = (int)PublicPortSelector.Value;
            var privPort = (int)PrivatePortSelector.Value;
            var mappingName = MappingNameInput.Text;

            if (mappingName.Length > 0)
            {
                AddNewEventToLog($"Attempting to open ports {pubPort} -> {privPort} with mapping name \"{mappingName}\"");

                OpenPortMapping(pubPort, privPort, mappingName);
            }
            else
            {
                AddNewEventToLog("Unable to create a mapping without a name.");
                AddNewEventToLog("This is to ensure the person responsible for managing the router can know what the port mapping is for.");
            }
        }

        private void OpenPortMapping(int PublicPort, int PrivatePort, string MappingName)
        {
            try
            {
                bool isTcp = TcpSelected.Checked;

                Task.Run(async () =>
                {
                    var nat = new NatDiscoverer();

                    var cts = new CancellationTokenSource(5000);
                    var device = await nat.DiscoverDeviceAsync(PortMapper.Upnp, cts);
                    Mapping mapping;

                    if (isTcp)
                    {
                        mapping = new Mapping(Protocol.Tcp, PrivatePort, PublicPort, int.MaxValue, MappingName);
                    }
                    else
                    {
                        mapping = new Mapping(Protocol.Udp, PrivatePort, PublicPort, int.MaxValue, MappingName);
                    }

                    if (mapping != null)
                    {
                        await device.CreatePortMapAsync(mapping);
                    }

                    AddNewEventToLog("Opening port successful! Make sure to have external computers connect via the external router ip with the public port.");

                    MessageBox.Show("Make sure to not close this application, as doing so will automatically close the port again.");
                });
            }
            catch (NatDeviceNotFoundException)
            {
                AddNewEventToLog("Open.Nat did not find a device with UPnP capabilities.");
            }
            catch (MappingException e)
            {
                switch (e.ErrorCode)
                {
                    case 718:
                        AddNewEventToLog("The external port is already in use");
                        break;

                    case 728:
                        AddNewEventToLog("The routers mapping table is full");
                        break;
                }
            }
        }
    }
}