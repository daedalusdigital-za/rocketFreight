using DocumentFormat.OpenXml.Bibliography;
using Microsoft.Win32;
using RocketFreight.Data;
using RocketFreight.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketFreight.UserControls.Accounts
{
    public partial class ucPatientCard : UserControl
    {
        AppInterface appInterface;
        int patientId;
        Patient patient;
        private bool isDragging = false;
        private int offsetX, offsetY;


        public ucPatientCard(int patientId = 0)
        {
            InitializeComponent();
            Load += UcPatientCard_Load;
            this.patientId = patientId;
            try
            {
                if (patientId > 0)
                    GetPatientRecords();
                else
                    MessageBox.Show("Invalid Patient ID");;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcPatientCard_Load(object sender, EventArgs e)
        {
            ParentForm.Size = new Size(Width + 25, Height + 25);
            ParentForm.Dock = DockStyle.Fill;
            ParentForm.FormBorderStyle = FormBorderStyle.None;
        }

        private async void GetPatientRecords()
        {
            appInterface = new AppInterface();
            patient = await appInterface.GetPatient(patientId);
            if (patient == null)
                throw new Exception("Patient not found!");
            lblName.Text = patient.Name;
            lblAddress.Text = patient.Address;
            lblMobile.Text = patient.Mobile;
            lblEmail.Text = patient.Email;
            lblDate.Text = patient.DOB.ToShortDateString();
            lblAge.Text = patient.Age.ToString() + " years";
            lblGender.Text = patient.Gender;
            if (!string.IsNullOrEmpty(patient.Image))
            {
                picProfile.ImageLocation = patient.Image;
                picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                picProfile.Image = Properties.Resources.i_user;
                picProfile.SizeMode = PictureBoxSizeMode.CenterImage;
            }

        }

        private void bbtnEdit_Click(object sender, EventArgs e)
        {
            frmDialogue frm = new frmDialogue();
            frm = new frmDialogue()
            {
                UserControl = new ucPatientForm(patient.Id),
                Text = "Edit Patient Form - " + patient.Name
            };
            frm.WindowState = FormWindowState.Maximized;
            frm.AutoScroll = true;
            frm.ShowDialog();
        }

        private void bbtnAddTreatment_Click(object sender, EventArgs e)
        {
            frmDialogue frm = new frmDialogue();
            frm = new frmDialogue()
            {
                UserControl = new ucTreatment(patient.Id),
                Text = "Patient Treatment Form - " + patient.Name
            };
            frm.WindowState = FormWindowState.Maximized;
            frm.AutoScroll = true;
            frm.ShowDialog();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.ParentForm.Left = e.X + this.ParentForm.Left - offsetX;
                this.ParentForm.Top = e.Y + this.ParentForm.Top - offsetY;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
