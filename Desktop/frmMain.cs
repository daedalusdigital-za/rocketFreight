using RocketFreight.Classes;
using RocketFreight.Data;
using RocketFreight.Interface;
using RocketFreight.Models;
using RocketFreight.UserControls;
using RocketFreight.UserControls.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketFreight
{
    public partial class frmMain : Form
    {
        //Fields
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        bool isClosing = false;
        private Form loginForm;
        private bool IsSearching;
        public AppInterface appInterface { get; set; }
        //List<Patient> results = new List<Patient>();
        private string filterBy = "";

        public frmMain(Form loginForm)
        {
            InitializeComponent();
            isClosing = false;
            this.loginForm = loginForm;
            this.Text = Statics.AppTitle;

            notifyIcon1.BalloonTipClosed += Statics.CloseNotifier;
        }

        private void LoadPageData()
        {
            tcSearch._TextChanged += TcSearch__TextChanged;

            dgvSearch.Columns.Clear();
            dgvSearch.Columns.Add("Col1", "Id");
            dgvSearch.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.i_user,
                HeaderText = ""
            });
            dgvSearch.Columns.Add("Col3", "Patient");
            dgvSearch.Columns.Add("Col4", "Mobile");
            dgvSearch.Columns.Add("Col5", "Gender");

            dgvSearch.Columns[0].Visible = false;
            //int i = dataGridView1.Columns.Add("Col8", "Edit");
            //dgvSearch.Columns.Add(new DataGridViewImageColumn()
            //{
            //    Image = Properties.Resources.edit,
            //    HeaderText = "Edit"
            //});
            //dataGridView1.Columns.Add("Col9", "Delete");
            dgvSearch.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.i_clear,
                HeaderText = "Delete"
            });
            dgvSearch.CellDoubleClick += DataGridView1_CellDoubleClick;
            dgvSearch.CellClick += DataGridView1_CellClick;
            dgvSearch.AllowUserToDeleteRows = true;
            dgvSearch.UserDeletingRow += DataGridView1_UserDeletingRow;

            tcSearch.txt.KeyPress += TcSearch_KeyPress;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                //DGVClicked(ActionType.Treatment);
            }else  if (e.RowIndex >= 0)
            {
                DGVClicked(ActionType.View);
            }
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            DGVClicked(ActionType.Delete);
        }

        private void TcSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                SearchItems();
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DGVClicked(ActionType.Edit);
            }
        }

        private async void DGVClicked(ActionType action)
        {
            var row = dgvSearch.CurrentRow;
            //if (row == null) return;
            //var item = await appInterface.GetPatient(
            //    Convert.ToInt32(row.Cells[0].Value));
            //if (item == null)
            //{
            //    MessageBox.Show("Item no longer exist in the database!");
            //    return;
            //}
            if (action == ActionType.Delete)
            {
                if (MessageBox.Show("Are you sure to delete this item?",
                    "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                //if (await appInterface.RemovePatient(item.Id))
                //{
                //    await appInterface.RemoveAnswers(item.Id);
                //    //await appInterface.RemoveTreatements(item.Id);
                //    MessageBox.Show("Item deleted!");
                //    dgvSearch.Rows.Remove(row);
                //    backgroundWorker1.RunWorkerAsync();
                //}
            }
            else if (action == ActionType.Edit)
            {
                frmDialogue frm = new frmDialogue();
                frm = new frmDialogue() { 
                    //UserControl = new ucPatientForm(item.Id), 
                    //Text = "Edit Patient Form - " + item.Name 
                };
                frm.WindowState = FormWindowState.Maximized;
                frm.AutoScroll = true;
                frm.ShowDialog();
            }
            else if (action == ActionType.View)
            {
                Form frm = new Form(){ 
                    //Text = "Patient Record - " + item.Name 
                };
                frm.WindowState = FormWindowState.Normal;
                //var uc = new ucPatientCard(item.Id); 
                //frm.Controls.Add(uc);
                frm.AutoScroll = true;
                frm.ShowDialog();
            }
            //else if (action == ActionType.Treatment)
            //{
            //    frmDialogue frm = new frmDialogue();
            //    frm = new frmDialogue()
            //    {
            //        UserControl = new ucTreatment(item.Id),
            //        Text = "Patient Treatment Form - " + item.Name
            //    };
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.AutoScroll = true;
            //    frm.ShowDialog();
            //}

        }

        private void TcSearch__TextChanged(object sender, EventArgs e)
        {
            SearchItems();
        }

        private void SearchItems()
        {
            //try
            //{
            //    var searchStringOld = tcSearch.GetText().ToLower();
            //    if (IsSearching) return;
            //    dgvSearch.Columns.Clear();
            //    int i = 0; IsSearching = true;
            //    string searchString = tcSearch.GetText().ToLower();
            //
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add().ColumnName = "Id";
            //    //dt.Columns.Add().ColumnName = "";
            //    dt.Columns.Add(new DataColumn("", typeof(Image)));
            //    dt.Columns.Add().ColumnName = "Patient";
            //    dt.Columns.Add().ColumnName = "Mobile";
            //    dt.Columns.Add().ColumnName = "Gender";
            //    dt.Columns.Add(new DataColumn("", typeof(Image)));
            //    var results = [];
            //    foreach (var item in results)
            //    {
            //        if (!string.IsNullOrEmpty(filterBy) && item.Gender != filterBy) continue;
            //
            //        if ((item.Name.ToLower().Contains(searchString) ||
            //            //(item.Gender != null ? item.Gender.ToLower().Contains(searchString) : false) ||
            //            (item.Mobile != null ? item.Mobile.ToLower().Contains(searchString) : false) ||
            //            (item.Address != null ? item.Address.ToLower().Contains(searchString) : false)
            //            ) || string.IsNullOrEmpty(searchString))
            //        {
            //            dt.Rows.Add();
            //            dt.Rows[i][0] = item.Id;
            //            if(string.IsNullOrEmpty(item.Image))
            //                dt.Rows[i][1] =
            //                    Properties.Resources.i_user.
            //                    GetThumbnailImage(32, 32, () => false, IntPtr.Zero);
            //            else
            //                dt.Rows[i][1] =
            //                    Image.FromFile(item.Image).
            //                    GetThumbnailImage(32, 32, () => false, IntPtr.Zero);
            //            dt.Rows[i][2] = item.Name;
            //            dt.Rows[i][3] = item.Mobile;
            //            dt.Rows[i][4] = item.Gender;
            //            dt.Rows[i][5] = Properties.Resources.i_pen.
            //                    GetThumbnailImage(100, 24, () => false, IntPtr.Zero);
            //            if (searchString != searchStringOld) break;
            //            i++;
            //        }
            //    }
            //    IsSearching = false;
            //    if (searchString != searchStringOld)
            //    {
            //        SearchItems(); return;
            //    }
            //    dgvSearch.DataSource = dt;
            //    dgvSearch.Columns[0].Visible = false;
            //    dgvSearch.Columns[1].FillWeight = 10;
            //    dgvSearch.Columns[1].HeaderText = "";
            //    dgvSearch.Columns[2].FillWeight = 40;
            //    dgvSearch.Columns[3].FillWeight = 20;
            //    dgvSearch.Columns[4].FillWeight = 15;
            //    dgvSearch.Columns[5].FillWeight = 15;
            //    dgvSearch.Columns[5].HeaderText = "";
            //    dgvSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //    dgvSearch.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //    dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Patients");
            dt.Columns.Add("S/N");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            dt.Columns.Add("Balance");
            dt.Columns.Add("CreditAllowanceDays");
            foreach (DataGridViewRow r in dgvSearch.Rows)
            {
                dt.Rows.Add(r.Cells[1].Value, r.Cells[2].Value,
                    r.Cells[3].Value, r.Cells[4].Value,
                    r.Cells[5].Value,
                    r.Cells[7].Value
                );
            }
            if (dt.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx|XML Files (*.xml)|*.xml"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (sfd.FileName.EndsWith(".xml"))
                            dt.WriteXml(sfd.FileName, XmlWriteMode.WriteSchema);
                        else
                            new ExcelHandler().ExportTable(dt, sfd.FileName);
                        MessageBox.Show("List Exported!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Patients");
            dt.Columns.Add("S/N");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            dt.Columns.Add("Balance");
            dt.Columns.Add("CreditAllowanceDays");
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx|XML Files (*.xml)|*.xml"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (ofd.FileName.EndsWith(".xml"))
                        dt.ReadXml(ofd.FileName);
                    else
                        new ExcelHandler().ImportTable(dt, ofd.FileName);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            //Patient patient = new Patient()
                            //{
                            //    Name = r[1].ToString(),
                            //    Mobile = r[2].ToString(),
                            //    Email = r[3].ToString(),
                            //    Address = r[4].ToString(),
                            //};
                            //await appInterface.SavePatient(patient);
                        }
                        MessageBox.Show("List Imported!");
                        SearchItems();
                    }
                    else
                    {
                        MessageBox.Show("No List To Import!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            appInterface = new AppInterface();
            //results = await appInterface.GetPatients();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SearchItems();
        }

        private void picFilters_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            filterBy = pic.Tag.ToString();
            SearchItems();
        }

        private void picNewPatient_Click(object sender, EventArgs e)
        {
            try
            {
                frmDialogue frm = new frmDialogue();
                frm = new frmDialogue() { 
                    //UserControl = new ucPatientForm(), 
                    //Text = "New Patient Form"
                };
                frm.WindowState = FormWindowState.Maximized;
                frm.AutoScroll = true;
                frm.ShowDialog();
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bfbtnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            SearchItems();
        }

        T showForm<T>(string msgTiltle, T uc)
        {
            try
            {
                frmDialogue frmDialogue;
                if (uc != null)
                {
                    if ((uc as UserControl).ParentForm != null)
                    {
                        frmDialogue = (frmDialogue)((uc as UserControl).Parent);
                        frmDialogue.Activate();
                        return uc;
                    }
                }
                frmDialogue = new frmDialogue()
                {
                    //MdiParent = this,
                    //WindowState = FormWindowState.Maximized
                };
                frmDialogue.UserControl =
                    ((T)Activator.CreateInstance(typeof(T))) as UserControl;
                frmDialogue.UserControl.Dock = DockStyle.Fill;
                frmDialogue.Text = msgTiltle;
                frmDialogue.Show();
                frmDialogue.WindowState = FormWindowState.Maximized;
                //frmDialogue.Focus();
                //frmDialogue.UserControl.Focus();
                uc = (T)Convert.ChangeType(frmDialogue.UserControl, typeof(T));
                return uc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return uc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Statics.isMainFormClosing = false;
            LoadPageData();
            backgroundWorker1.RunWorkerAsync();
            dgvSearch.Focus();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosing)
            {
                Statics.isMainFormClosing = true;
                if (MessageBox.Show("Quit this application?",
                       "Closing Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    isClosing = true;
                    Application.Exit();
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            Statics.user = null;
            isClosing = true;
            panel2.Controls.Clear();
            loginForm.Show();
            Close();
        }

        public void ConfirmClose()
        {
            if(Statics.user != null)
            if (MessageBox.Show("Quit this application?",
                   "Closing Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                isClosing = true;
                Application.Exit();
            }
        }


        private void userAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm("Users", new ucUser());
        }


        private void patientReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
