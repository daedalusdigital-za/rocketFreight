using RocketFreight.Classes;
using RocketFreight.Interface;
using RocketFreight.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketFreight
{
    public partial class frmSplashScreen : Form
    {
        //Fields
        private int borderSize = 2;
        bool hasError = false; bool isActivating = false;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        public bool isClosing = false;

        public UserControl UserControl;

        public frmSplashScreen()
        {
            InitializeComponent();

            this.Padding = new Padding(borderSize);//Border size
            //this.BackColor = Color.FromArgb(98, 102, 244);//Border color


            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            backgroundWorker1.WorkerSupportsCancellation = true;

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Step = 10;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            isClosing = true;
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        public bool CanRefresh { get; internal set; }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "v" + ProductVersion;
            //Statics.Notify("Welecome, should you encounter any issue, do let us know!", 3000);
            timer1.Enabled = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hasError) {
                btnRetry.Visible = true;
                timer1.Enabled = false;
            }
            else
                progressBar1.Increment(10);
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                hasError = false;
                Thread.Sleep(1000);
                AppInterface appInterface = new AppInterface();
                var u = await appInterface.GetUsers();
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                hasError = true;
                if (!CanRefresh && !isActivating)
                {
                    MessageBox.Show(Statics.GetException(ex));
                    //MessageBox.Show("This app will not work if you proceed. Ensure that the connection string is correct.");
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!hasError && !isActivating)
            {
                timer1.Enabled = false;
                progressBar1.Value = progressBar1.Maximum;
                this.Refresh();
                System.Threading.Thread.Sleep(2000);

                Close();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            hasError = true;
            backgroundWorker1.CancelAsync();
            frmDialogue frmDailogue = new frmDialogue();
            frmDailogue.UserControl = new ucSettings(this);
            frmDailogue.Text = "Connection Settings";
            frmDailogue.ShowDialog();
            if (CanRefresh)
            {
                btnRetry.PerformClick();
            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                label1.Text = "Retrying...";
                backgroundWorker1.RunWorkerAsync();
                timer1.Enabled = true;
                progressBar1.Value = progressBar1.Minimum;
            }
            else
            {
                MessageBox.Show("Wait a few seconds and retry \n\r Or Restart app!");
            }
        }

        private void frmSplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
