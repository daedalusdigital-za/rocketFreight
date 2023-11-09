using RocketFreight.Classes;
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
    public partial class ucSettings : UserControl
    {
        private frmSplashScreen frmSplashScreen;

        public ucSettings(frmSplashScreen frmSplashScreen)
        {
            this.frmSplashScreen = frmSplashScreen;
            InitializeComponent();
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            tcConString.Focus();
            tcConString.SetText(Properties.Settings.Default.ConStringSQLServer);
            if (string.IsNullOrEmpty(tcConString.GetText()))
            {
                tcConString.SetText(Properties.Settings.Default.ConStringSQLServer);
            }
            dropDownControl1.SelectedItem = Properties.Settings.Default.DBType;

            tcConString.txt.KeyPress += Txt_KeyPress;
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
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
            frmSplashScreen.CanRefresh = false;
            this.ParentForm.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tcConString.GetText()))
            {
                MessageBox.Show("Connection String is Required"); return;
            }
            try
            {
                if (dropDownControl1.SelectedItem.ToString() == "MySQL")
                {
                    Properties.Settings.Default.ConStringMySql = tcConString.GetText();
                }
                else
                {
                    Properties.Settings.Default.ConStringSQLServer = tcConString.GetText();
                }
                Properties.Settings.Default.DBType = dropDownControl1.SelectedItem.ToString();
                Properties.Settings.Default.Save();
                frmSplashScreen.CanRefresh = true;
                ParentForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dropDownControl1.SelectedItem.ToString() == "MySQL")
            {
                tcConString.SetText("server=127.0.0.1;user id=root;database=RocketFreight");
            }
            else
            {
                tcConString.SetText("data source=(LocalDB)\\MSSQLLocalDB;attachdbfilename=\"|DataDirectory|\\Data\\AppDatabase.mdf\";integrated security=True;connect timeout=10;MultipleActiveResultSets=True;App=EntityFramework;");
            }
        }

        private void dropDownControl1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDownControl1.SelectedItem.ToString() == "MySQL")
            {
                tcConString.SetText(Properties.Settings.Default.ConStringMySql);
            }
            else
            {
                tcConString.SetText(Properties.Settings.Default.ConStringSQLServer);
            }
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            try
            {
                frmDialogue frm = new frmDialogue()
                {
                    UserControl = new ucLogin()
                };
                frm.Text = "Login To Backup - " + Statics.AppTitle;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
