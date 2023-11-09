using RocketFreight.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketFreight
{
    public partial class frmDialog : Form
    {
        private int timeToSpend;
        private bool showCountdown;

        public frmDialog(
            string msg, 
            bool showOk = false, 
            bool showCountdown = false, 
            string title = "Alert", 
            int timeToSpend = 5000)
        {
            InitializeComponent();
            this.timeToSpend = timeToSpend;
            this.showCountdown = showCountdown;
            progressBar1.Maximum = timeToSpend;
            progressBar1.Value = timeToSpend;
            progressBar1.Step = timeToSpend;
            lblTitle.Text = title;
            lblMessage.Text = msg;
            btnConfirm.Visible = showOk;
            progressBar1.Visible = showCountdown;
            timer1.Enabled = showCountdown;
            if (!showOk)
            {
                btnCancel.BackgroundImage = btnConfirm.BackgroundImage;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
            else if (keyData == Keys.Enter && btnConfirm.Visible)
            {
                btnConfirm.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeToSpend <= 0)
            {
                btnCancel.PerformClick();
                return;
            }
            timeToSpend -= timer1.Interval;
            progressBar1.Step = timer1.Interval;
            progressBar1.Value -= timer1.Interval;
        }

        private void btnConfirm_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void btnConfirm_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void frmDialog_MouseEnter(object sender, EventArgs e)
        {
            if(showCountdown)
                timer1.Enabled = false;
        }

        private void frmDialog_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = showCountdown;
        }
    }
}
