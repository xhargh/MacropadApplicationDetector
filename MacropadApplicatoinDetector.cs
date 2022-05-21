using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;


namespace Mad
{


    public partial class MacropadApplicationDetector : Form
    {
        private string currentApplication;

        public MacropadApplicationDetector()
        {
            InitializeComponent();

            cbComPorts.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                cbComPorts.Items.Add(s);
            }

            cbComPorts.SelectedIndex = cbComPorts.FindStringExact(Properties.Settings.Default.portName);

            if (cbComPorts.SelectedIndex >= 0)
            {
                openPort();
            }
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        string GetActiveProcessFileName()
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            try
            {
                if (p != null)
                {
                    return Path.GetFileNameWithoutExtension(p.MainModule.FileName);
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                // TODO: Find out what to do on exception
                return "exception";
            }
        }

        private void tmr1Hz_Tick(object sender, EventArgs e)
        {
            string name = GetActiveProcessFileName();
            if (name != currentApplication)
            {
                lblMacropadApplicationDetector.Text = name;
                currentApplication = name;

                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(name);
                }
            }
        }


        private void MacropadApplicationDetector_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }



        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        void openPort()
        {
            tbOutput.Clear();

            serialPort1.BaudRate = 38400;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            // serialPort1.StopBits = StopBits.None;
            serialPort1.Handshake = Handshake.None;
            serialPort1.PortName = (string)cbComPorts.SelectedItem;
            serialPort1.Open();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

            openPort();

            if (serialPort1.IsOpen)
            {
                Properties.Settings.Default.portName = (string)cbComPorts.SelectedItem;
                Properties.Settings.Default.Save();
            }
        }

        delegate void SetTextCallback(string text);

        private void AppendText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (tbOutput.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AppendText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Keep the last 100 when output gets longer than 5000
                if (tbOutput.Lines.Length > 5000)
                {
                    List<string> lastLines;
                    lastLines = tbOutput.Lines.Reverse().Take(100).Reverse().ToList();

                    tbOutput.Clear();
                    tbOutput.Lines = lastLines.ToArray();
                }
                tbOutput.AppendText(text);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            AppendText(indata);
        }

        private void MacropadApplicationDetector_Load(object sender, EventArgs e)
        {

        }
    }
}
