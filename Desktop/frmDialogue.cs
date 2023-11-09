using RocketFreight.Classes;
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

namespace RocketFreight
{
    public partial class frmDialogue : Form
    {
        //Fields
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.

        public UserControl UserControl;
        internal bool isReporting = false;

        public frmDialogue()
        {
            InitializeComponent();
            this.Padding = new Padding(0,borderSize,0,borderSize);//Border size
                                                   //this.BackColor = Color.FromArgb(98, 102, 244);//Border color
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(this.Icon, this.Icon.Size);
            if (UserControl == null)
            {
                UserControl = new UserControls.ucLogin();
                Text = "Login - " + Statics.AppTitle;
            }
            UserControl.MinimumSize = UserControl.Size;
            this.MinimumSize = new Size(UserControl.MinimumSize.Width + 5, 
                UserControl.MinimumSize.Height + 15);
            
            if (Statics.MainForm != null && WindowState == FormWindowState.Maximized && !isReporting)
            {
                UserControl.Width = this.Width - 20;// - 60 - Statics.MainForm.GetSideBarSize().Width;
                UserControl.Height = this.Height - 50;
            }else if (Statics.MainForm != null && WindowState != FormWindowState.Maximized && !isReporting)
            {
                this.Width = UserControl.Width + 30;
                this.Height = UserControl.Height + 50;
            }
            else if(isReporting)
            {
                UserControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
                UserControl.Width = this.Width - 50;// - 60 - Statics.MainForm.GetSideBarSize().Width;
                UserControl.Height = this.Height - 150;
            }
            if (!isReporting)
            {
                UserControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            }
            this.Controls.Add(UserControl);
            this.AutoScroll = true;

            //Statics.ColorObjects(UserControl.Controls);
            UserControl.AutoScroll = true;

            this.Shown += FrmDialogue_Shown;
        }

        private void FrmDialogue_Shown(object sender, EventArgs e)
        {

                this.Focus();
                UserControl.Focus();
        }

        private void frmDailogue_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isReporting)
                Statics.ReportDailogue = null;
        }
    }
}
