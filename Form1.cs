using System;
using System.IO;
using System.Windows.Forms;

namespace Project8_StartStopLogger
{
    public partial class Form1 : Form
    {
        private readonly string logFile = "start_stop_log.txt";

        public Form1()
        {
            InitializeComponent();
            LogMessage("Application Started");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LogMessage("Service Started");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            LogMessage("Service Stopped");
        }

        private void LogMessage(string message)
        {
            string log = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + message;
            lstLog.Items.Add(log);
            File.AppendAllText(logFile, log + Environment.NewLine);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogMessage("Application Stopped");
        }
    }
}
