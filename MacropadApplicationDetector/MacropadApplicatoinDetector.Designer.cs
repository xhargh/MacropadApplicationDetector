namespace Mad
{
    partial class MacropadApplicationDetector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacropadApplicationDetector));
            this.tmr1Hz = new System.Windows.Forms.Timer(this.components);
            this.lblMacropadApplicationDetector = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbComPorts = new System.Windows.Forms.ComboBox();
            this.lbl_Connected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmr1Hz
            // 
            this.tmr1Hz.Enabled = true;
            this.tmr1Hz.Interval = 1000;
            this.tmr1Hz.Tick += new System.EventHandler(this.tmr1Hz_Tick);
            // 
            // lblMacropadApplicationDetector
            // 
            this.lblMacropadApplicationDetector.AutoSize = true;
            this.lblMacropadApplicationDetector.Location = new System.Drawing.Point(12, 9);
            this.lblMacropadApplicationDetector.Name = "lblMacropadApplicationDetector";
            this.lblMacropadApplicationDetector.Size = new System.Drawing.Size(62, 20);
            this.lblMacropadApplicationDetector.TabIndex = 0;
            this.lblMacropadApplicationDetector.Text = "-empty-";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(14, 88);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(775, 352);
            this.tbOutput.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.Location = new System.Drawing.Point(183, 37);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 38);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbComPorts
            // 
            this.cbComPorts.FormattingEnabled = true;
            this.cbComPorts.Location = new System.Drawing.Point(56, 42);
            this.cbComPorts.Name = "cbComPorts";
            this.cbComPorts.Size = new System.Drawing.Size(121, 28);
            this.cbComPorts.TabIndex = 5;
            // 
            // lbl_Connected
            // 
            this.lbl_Connected.AutoSize = true;
            this.lbl_Connected.Location = new System.Drawing.Point(287, 46);
            this.lbl_Connected.Name = "lbl_Connected";
            this.lbl_Connected.Size = new System.Drawing.Size(0, 20);
            this.lbl_Connected.TabIndex = 6;
            // 
            // MacropadApplicationDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.lbl_Connected);
            this.Controls.Add(this.cbComPorts);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMacropadApplicationDetector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MacropadApplicationDetector";
            this.Text = "Macropad Application Detector";
            this.Load += new System.EventHandler(this.MacropadApplicationDetector_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.MacropadApplicationDetector_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr1Hz;
        private System.Windows.Forms.Label lblMacropadApplicationDetector;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbComPorts;
        private System.Windows.Forms.Label lbl_Connected;
    }
}

