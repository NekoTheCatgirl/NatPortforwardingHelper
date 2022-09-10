namespace NatPortOpener
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UdpSelected = new System.Windows.Forms.RadioButton();
            this.TcpSelected = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenPort = new System.Windows.Forms.Button();
            this.MappingNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrivatePortSelector = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PublicPortSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EventHistory = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrivatePortSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicPortSelector)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UdpSelected);
            this.groupBox1.Controls.Add(this.TcpSelected);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OpenPort);
            this.groupBox1.Controls.Add(this.MappingNameInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PrivatePortSelector);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PublicPortSelector);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ports";
            // 
            // UdpSelected
            // 
            this.UdpSelected.AutoSize = true;
            this.UdpSelected.Dock = System.Windows.Forms.DockStyle.Top;
            this.UdpSelected.Location = new System.Drawing.Point(3, 167);
            this.UdpSelected.Name = "UdpSelected";
            this.UdpSelected.Size = new System.Drawing.Size(194, 19);
            this.UdpSelected.TabIndex = 9;
            this.UdpSelected.Text = "Udp Protocol";
            this.UdpSelected.UseVisualStyleBackColor = true;
            // 
            // TcpSelected
            // 
            this.TcpSelected.AutoSize = true;
            this.TcpSelected.Checked = true;
            this.TcpSelected.Dock = System.Windows.Forms.DockStyle.Top;
            this.TcpSelected.Location = new System.Drawing.Point(3, 148);
            this.TcpSelected.Name = "TcpSelected";
            this.TcpSelected.Size = new System.Drawing.Size(194, 19);
            this.TcpSelected.TabIndex = 8;
            this.TcpSelected.TabStop = true;
            this.TcpSelected.Text = "Tcp Protocol";
            this.TcpSelected.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mapping Type";
            // 
            // OpenPort
            // 
            this.OpenPort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpenPort.Location = new System.Drawing.Point(3, 424);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(194, 23);
            this.OpenPort.TabIndex = 6;
            this.OpenPort.Text = "Attempt to open port";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // MappingNameInput
            // 
            this.MappingNameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.MappingNameInput.Location = new System.Drawing.Point(3, 110);
            this.MappingNameInput.MaxLength = 32;
            this.MappingNameInput.Name = "MappingNameInput";
            this.MappingNameInput.Size = new System.Drawing.Size(194, 23);
            this.MappingNameInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mapping Name";
            // 
            // PrivatePortSelector
            // 
            this.PrivatePortSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrivatePortSelector.Location = new System.Drawing.Point(3, 72);
            this.PrivatePortSelector.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PrivatePortSelector.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PrivatePortSelector.Name = "PrivatePortSelector";
            this.PrivatePortSelector.Size = new System.Drawing.Size(194, 23);
            this.PrivatePortSelector.TabIndex = 3;
            this.PrivatePortSelector.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Private port";
            // 
            // PublicPortSelector
            // 
            this.PublicPortSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.PublicPortSelector.Location = new System.Drawing.Point(3, 34);
            this.PublicPortSelector.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PublicPortSelector.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PublicPortSelector.Name = "PublicPortSelector";
            this.PublicPortSelector.Size = new System.Drawing.Size(194, 23);
            this.PublicPortSelector.TabIndex = 1;
            this.PublicPortSelector.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EventHistory);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(200, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event History";
            // 
            // EventHistory
            // 
            this.EventHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventHistory.FormattingEnabled = true;
            this.EventHistory.IntegralHeight = false;
            this.EventHistory.ItemHeight = 15;
            this.EventHistory.Location = new System.Drawing.Point(3, 19);
            this.EventHistory.Name = "EventHistory";
            this.EventHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.EventHistory.Size = new System.Drawing.Size(594, 428);
            this.EventHistory.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Nat Port Opener";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrivatePortSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicPortSelector)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox MappingNameInput;
        private Label label3;
        private NumericUpDown PrivatePortSelector;
        private Label label2;
        private NumericUpDown PublicPortSelector;
        private Label label1;
        private GroupBox groupBox2;
        private Button OpenPort;
        private RadioButton UdpSelected;
        private RadioButton TcpSelected;
        private Label label4;
        private ListBox EventHistory;
    }
}