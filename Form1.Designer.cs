namespace Project8_StartStopLogger
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lstLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            lstLog = new ListBox();
            SuspendLayout();

            btnStart.Location = new Point(60, 35);
            btnStart.Size = new Size(110, 40);
            btnStart.Text = "Start";
            btnStart.Click += btnStart_Click;

            btnStop.Location = new Point(190, 35);
            btnStop.Size = new Size(110, 40);
            btnStop.Text = "Stop";
            btnStop.Click += btnStop_Click;

            lstLog.Location = new Point(30, 100);
            lstLog.Size = new Size(600, 280);

            ClientSize = new Size(660, 420);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(lstLog);
            Text = "Start/Stop Logger Service";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }
    }
}
