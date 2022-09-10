using Open.Nat;

namespace NatPortOpener
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void AddNewEventToLog(string EventMessage)
        {
            EventHistory.Items.Add(EventMessage);
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
                bool isUdp = UdpSelected.Checked;

                Task.Run(async () =>
                {
                    var nat = new NatDiscoverer();

                    var cts = new CancellationTokenSource(5000);
                    var device = await nat.DiscoverDeviceAsync(PortMapper.Upnp, cts);

                    if (isTcp)
                    {
                        await device.CreatePortMapAsync(new Mapping(Protocol.Tcp, PrivatePort, PublicPort));
                    }
                    else if (isUdp)
                    {
                        await device.CreatePortMapAsync(new Mapping(Protocol.Udp, PrivatePort, PublicPort));
                    }
                });

                AddNewEventToLog("Opening port successful! Make sure to have external computers connect via the external router ip with the public port.");
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