using Bunifu.Framework.UI;
using RocketFreight.Data;
using RocketFreight.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketFreight.UserControls.Accounts
{
    public partial class ucPatientForm : UserControl
    {
        private List<Question> qs;
        private List<Answer> answers;
        //ucQuestions UcQuestions;
        frmDialogue frm;
        AppInterface appInterface;
        int patientId;
        Patient patient;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string saveDirectory = @"\Patient-Images";



        public ucPatientForm(int patientId = 0)
        {
            InitializeComponent();
            this.patientId = patientId;
            lblDay.Text = DateTime.Now.ToString("MM");
            lblMonth.Text = DateTime.Now.ToString("dd");
            lblYear.Text = DateTime.Now.ToString("yyyy");
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff|All Files|*.*";
            try
            {
                GetRecords();

                if (patientId > 0)
                    GetPatientRecords();
                else
                    ClearRecords();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                frm.Hide();
            }
        }

        private async void GetRecords()
        {
            appInterface = new AppInterface();
            qs = await appInterface.GetQuestions();
        }

        private void ClearRecords()
        {
            patient = new Patient();

            openFileDialog.FileName = "";
            tcName.Texts = "";
            tcAddress.Texts = "";
            tcCity.Texts = "";
            bDOB.Value = DateTime.Now;
            tcPassport.Texts = "";
            bddGender.selectedIndex = -1;
            tcMobile.Texts = "";
            tcEmail.Texts = "";
            bckWhatsapp.Checked = true;
            bckSubscribe.Checked = false;
            rtxtNotes.Text = "";
            picProfile.Image = Properties.Resources.i_camera;
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;

            answers = new List<Answer>();
            foreach (var item in qs)
            {
                answers.Add(new Answer()
                {
                    Active = true,
                    PatiantId = patientId,
                    QuestionId = item.Id,
                    Selected = false,
                    Text = ""
                });
            }

            if(frm != null)
            {
                frm.FormClosing -= Frm_FormClosing;
                frm.Close();
                //UcQuestions.Dispose();
                frm.Dispose();
                //UcQuestions = null;
                frm = null;
            }
            //UcQuestions = new ucQuestions(qs, answers);
            //frm = new frmDialogue() { UserControl = UcQuestions };
            //frm.FormClosing += Frm_FormClosing;

            tcName.Focus();
        }
        
        private async void GetPatientRecords()
        {
            patient = await appInterface.GetPatient(patientId);
            if (patient == null)
                throw new Exception("Patient not found!");
            tcName.Texts = patient.Name;
            tcAddress.Texts = patient.Address;
            tcCity.Texts = patient.City;
            bDOB.Value = patient.DOB;
            tcPassport.Texts = patient.Passport_Id_No;
            bddGender.selectedIndex = bddGender.Items.ToList().IndexOf(patient.Gender);
            tcMobile.Texts = patient.Mobile;
            tcEmail.Texts = patient.Email;
            bckWhatsapp.Checked = patient.IsWhatsapp;
            bckSubscribe.Checked = patient.Subscribed;
            rtxtNotes.Text = patient.Notes;

            if (!string.IsNullOrEmpty(patient.Image))
                picProfile.ImageLocation = patient.Image;

            answers = await appInterface.GetAnswers(patientId);

            //UcQuestions = new ucQuestions(qs, answers, patientId);
            //frm = new frmDialogue() { UserControl = UcQuestions };
            //frm.FormClosing += Frm_FormClosing;

            SetPatientAnswerRecords(patientId);
        }

        private void SetQuestions(int patientId)
        {
            List<Panel> ctrls = new List<Panel> {
                pnAnswerSec1, pnAnswerSec2, 
                pnAnswerSec3, pnAnswerSec4, 
                pnAnswerSec5
            };
            foreach (var p in ctrls)
            {
                foreach (var ctr in p.Controls)
                {
                    if (typeof(ucQuestion) == ctr.GetType())
                    {
                        var control = (ucQuestion)ctr;
                        var q = qs.FirstOrDefault(x => x.Id == Convert.ToInt32(control.Tag));
                        if (q != null)
                        {
                            var a = answers.FirstOrDefault(x => x.QuestionId == q.Id);
                            if (a != null)
                            {
                                control.Value = a.Selected;
                                control.Answer = a.Text;
                            }
                        }
                    }
                    else if (typeof(ucQuestion2) == ctr.GetType())
                    {
                        var control = (ucQuestion2)ctr;
                        var q = qs.FirstOrDefault(x => x.Id == Convert.ToInt32(control.Tag));
                        if (q != null)
                        {
                            var a = answers.FirstOrDefault(x => x.QuestionId == q.Id);
                            if (a != null) control.Value = a.Selected;
                        }
                    }
                    else if (typeof(ucCheckboxSingle) == ctr.GetType())
                    {
                        var control = (ucCheckboxSingle)ctr;
                        var q = qs.FirstOrDefault(x => x.Id == Convert.ToInt32(control.Tag));
                        if (q != null)
                        {
                            var a = answers.FirstOrDefault(x => x.QuestionId == q.Id);
                            if (a != null) control.Value = a.Selected;
                        }
                    }
                }
            }
        }
        private void SetPatientAnswerRecords(int patientId)
        {
            List<Panel> ctrls = new List<Panel> {
                pnAnswerSec1, pnAnswerSec2, 
                pnAnswerSec3, pnAnswerSec4, 
                pnAnswerSec5
            };
            foreach (var p in ctrls)
            {
                foreach (var ctr in p.Controls)
                {
                    if (typeof(ucQuestion) == ctr.GetType())
                    {
                        var control = (ucQuestion)ctr;
                        var q = qs.FirstOrDefault(x => x.Id == Convert.ToInt32(control.Tag));
                        if (q != null)
                        {
                            var a = answers.FirstOrDefault(x => x.QuestionId == q.Id);
                            if (a != null)
                            {
                                control.Value = a.Selected;
                                control.Answer = a.Text;
                            }
                        }
                    }
                    else if (typeof(ucQuestion2) == ctr.GetType())
                    {
                        var control = (ucQuestion2)ctr;
                        var q = qs.FirstOrDefault(x => x.Id == Convert.ToInt32(control.Tag));
                        if (q != null)
                        {
                            var a = answers.FirstOrDefault(x => x.QuestionId == q.Id);
                            if (a != null) control.Value = a.Selected;
                        }
                    }
                    else if (typeof(ucCheckboxSingle) == ctr.GetType())
                    {
                        var control = (ucCheckboxSingle)ctr;
                        var q = qs.FirstOrDefault(x => x.Id == Convert.ToInt32(control.Tag));
                        if (q != null)
                        {
                            var a = answers.FirstOrDefault(x => x.QuestionId == q.Id);
                            if (a != null) control.Value = a.Selected;
                        }
                    }
                }
            }
        }

        public List<Answer> GetPatientAnswerRecords()
        {
            List<Panel> ctrls = new List<Panel> {
                pnAnswerSec1, pnAnswerSec2,
                pnAnswerSec3, pnAnswerSec4,
                pnAnswerSec5
            };
            foreach (var p in ctrls)
            {
                foreach (var ctr in p.Controls)
                {
                    if (typeof(ucQuestion) == ctr.GetType())
                    {
                        var control = (ucQuestion)ctr;
                        var q = qs.FirstOrDefault(x => x.Id == Convert.ToInt32(control.Tag));
                        if (q != null)
                        {
                            var a = answers.FirstOrDefault(x => x.QuestionId == q.Id);
                            if (a != null)
                            {
                                a.Selected = control.Value;
                                a.Text = control.Answer;
                            }
                        }
                    }
                    else if (typeof(ucQuestion2) == ctr.GetType())
                    {
                        var control = (ucQuestion2)ctr;
                        var q = qs.FirstOrDefault(x => x.Id == Convert.ToInt32(control.Tag));
                        if (q != null)
                        {
                            var a = answers.FirstOrDefault(x => x.QuestionId == q.Id);
                            if (a != null) a.Selected = control.Value;
                        }
                    }
                    else if (typeof(ucCheckboxSingle) == ctr.GetType())
                    {
                        var control = (ucCheckboxSingle)ctr;
                        var q = qs.FirstOrDefault(x => x.Id == Convert.ToInt32(control.Tag));
                        if (q != null)
                        {
                            var a = answers.FirstOrDefault(x => x.QuestionId == q.Id);
                            if (a != null) a.Selected = control.Value;
                        }
                    }
                }
            }
            return answers;
        }
        private void bDOB_onValueChanged(object sender, EventArgs e)
        {
            if (patient != null)
            {
                patient.DOB = bDOB.Value;
                tcAge.Texts = patient.Age.ToString();
            }
        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picProfile.ImageLocation = openFileDialog.FileName;
                    picProfile.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tcName.Texts))
                    throw new Exception("Patient name is required!");
                if (bddGender.selectedIndex < 0)
                    throw new Exception("Patient gender is required!");

                if (patient == null) patient = new Patient();
                patient.Name = tcName.Texts;
                patient.Address = tcAddress.Texts;
                patient.City = tcCity.Texts;
                if (bDOB.Value == DateTime.Now && !string.IsNullOrEmpty(tcAge.Texts))
                {
                    int age = 0;
                    int.TryParse(tcAge.Texts, out age);
                    bDOB.Value = DateTime.Now.AddYears(-age);
                }
                patient.DOB = bDOB.Value;
                patient.Passport_Id_No = tcPassport.Texts;
                patient.Gender = bddGender.selectedValue;
                patient.Mobile = tcMobile.Texts;
                patient.Email = tcEmail.Texts;
                patient.IsWhatsapp = bckWhatsapp.Checked;
                patient.Subscribed = bckSubscribe.Checked;
                patient.Notes = rtxtNotes.Text;

                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Generate a timestamp for the filename
                    string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                    string fileExtension = Path.GetExtension(selectedFilePath);
                    string newFileName = $"{timestamp}{fileExtension}";
                    string savePath = Path.Combine(saveDirectory, newFileName);

                    if (!Directory.Exists(saveDirectory))
                        Directory.CreateDirectory(saveDirectory);

                    File.Copy(selectedFilePath, savePath);
                    patient.Image = selectedFilePath;
                }

                //answers = UcQuestions.GetPatientRecords();
                answers = GetPatientAnswerRecords();
                if (patientId == 0)
                {
                    patient = await appInterface.SavePatient(patient);
                    await appInterface.SaveAnswers(answers, patient);

                    ClearRecords();
                }
                else
                {
                    await appInterface.UpdatePatient(patient, patientId);
                    await appInterface.UpdateAnswers(answers, patientId);
                }

                MessageBox.Show("Patient record saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewQuestions_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
