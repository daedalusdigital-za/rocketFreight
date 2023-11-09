using RocketFreight.Classes;
using RocketFreight.Data;
using RocketFreight.Interface;
using RocketFreight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketFreight.UserControls
{
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
            tcPassword.txt.KeyPress += Txt_KeyPress;
            tcUsername.txt.KeyPress += Txt_KeyPress;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += btnMouseEnter;
            btnCancel.MouseLeave += btnMouseLeave;
            btnLogin.MouseEnter += btnMouseEnter;
            btnLogin.MouseLeave += btnMouseLeave;
            notifyIcon1.BalloonTipClosed +=
                Statics.CloseNotifier;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            tcUsername.Focus();
            tcPassword.txt.KeyPress += Txt_KeyPress;
            tcUsername.txt.KeyPress += Txt_KeyPress;

            ParentForm.FormClosing += frmDialogue_FormClosing;
        }

        private void frmDialogue_FormClosing(object sender, EventArgs e)
        {
            if (notifyIcon1 != null)
            {
                notifyIcon1.Visible = false;
                if (notifyIcon1.Icon != null)
                    notifyIcon1.Icon.Dispose();
                notifyIcon1.Icon = null;
                notifyIcon1.Dispose();
                notifyIcon1 = null;
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightGray;
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tcUsername.GetText()) || string.IsNullOrEmpty(tcPassword.GetText()))
            {
                (new frmDialog("Username and Password are Required")).ShowDialog();
                //MessageBox.Show("Username and Password are Required"); 
                return;
            }
            try
            {
                AppInterface appInterface = new AppInterface();
                var user = (await appInterface.GetUsers()).FirstOrDefault(x=>x.Username == tcUsername.GetText() && 
                    x.Password == tcPassword.GetText());
                if (user == null)
                {
                    (new frmDialog("Invalid Username or Password")).ShowDialog();
                    return;
                    //MessageBox.Show("Invalid Username or Password"); return;
                }
                Statics.user = new User()
                {
                    Username = tcUsername.GetText(),
                    Address = user.Address,
                    Email = user.Email,
                    Type = user.Type,
                    ProfileImage = user.ProfileImage,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Phone = user.Phone,
                    Id = user.Id
                };

                frmMain frmMain = new frmMain(this.ParentForm);
                Statics.MainForm = frmMain;
                frmMain.Show();
                this.ParentForm.Hide();
                tcPassword.Clear();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                (new frmDialog(ex.Message)).ShowDialog();
            }
        }
    }
}
