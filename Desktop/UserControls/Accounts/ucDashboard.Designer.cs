namespace RocketFreight.UserControls.Accounts
{
    partial class ucDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashboard));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tcSearch = new RocketFreight.InputControls.TextBoxControl();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bfbtnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picMales = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.picFemales = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel10 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel9 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.picNewPatient = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblMaleCount = new System.Windows.Forms.Label();
            this.lblFemaleCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel8 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel7 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemales)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Total Patients";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(17, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 40);
            this.panel1.TabIndex = 5;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(265, 99);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(445, 367);
            this.dgvSearch.TabIndex = 10;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.tcSearch);
            this.bunifuGradientPanel3.Controls.Add(this.picSearch);
            this.bunifuGradientPanel3.Controls.Add(this.textBox2);
            this.bunifuGradientPanel3.Controls.Add(this.label2);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(17, 16);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(693, 74);
            this.bunifuGradientPanel3.TabIndex = 7;
            // 
            // tcSearch
            // 
            this.tcSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tcSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcSearch.BorderRadius = 5;
            this.tcSearch.BorderSize = 1;
            this.tcSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tcSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcSearch.Location = new System.Drawing.Point(315, 26);
            this.tcSearch.Margin = new System.Windows.Forms.Padding(1);
            this.tcSearch.Multiline = false;
            this.tcSearch.Name = "tcSearch";
            this.tcSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tcSearch.PasswordChar = false;
            this.tcSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcSearch.PlaceholderText = "";
            this.tcSearch.Size = new System.Drawing.Size(250, 24);
            this.tcSearch.TabIndex = 6;
            this.tcSearch.Texts = "";
            this.tcSearch.UnderlinedStyle = false;
            // 
            // picSearch
            // 
            this.picSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearch.Image = global::RocketFreight.Properties.Resources.i_search;
            this.picSearch.Location = new System.Drawing.Point(571, 24);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(100, 27);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 5;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(18, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 37);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Please do not forget to keep backing up the data. Have a nice day!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome Dr. Muna!";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bfbtnLogout);
            this.bunifuGradientPanel2.Controls.Add(this.picMales);
            this.bunifuGradientPanel2.Controls.Add(this.pictureBox32);
            this.bunifuGradientPanel2.Controls.Add(this.picFemales);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuGradientPanel10);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuGradientPanel9);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(17, 322);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(243, 142);
            this.bunifuGradientPanel2.TabIndex = 6;
            // 
            // bfbtnLogout
            // 
            this.bfbtnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbtnLogout.BackgroundImage = global::RocketFreight.Properties.Resources.i_rectangle_gray_outline;
            this.bfbtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbtnLogout.BorderRadius = 5;
            this.bfbtnLogout.ButtonText = "LOGOUT";
            this.bfbtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbtnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.bfbtnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbtnLogout.Iconimage = global::RocketFreight.Properties.Resources.i_node_small;
            this.bfbtnLogout.Iconimage_right = null;
            this.bfbtnLogout.Iconimage_right_Selected = null;
            this.bfbtnLogout.Iconimage_Selected = null;
            this.bfbtnLogout.IconMarginLeft = 5;
            this.bfbtnLogout.IconMarginRight = 0;
            this.bfbtnLogout.IconRightVisible = true;
            this.bfbtnLogout.IconRightZoom = 0D;
            this.bfbtnLogout.IconVisible = true;
            this.bfbtnLogout.IconZoom = 100D;
            this.bfbtnLogout.IsTab = false;
            this.bfbtnLogout.Location = new System.Drawing.Point(61, 102);
            this.bfbtnLogout.Name = "bfbtnLogout";
            this.bfbtnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbtnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfbtnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbtnLogout.Padding = new System.Windows.Forms.Padding(2);
            this.bfbtnLogout.selected = false;
            this.bfbtnLogout.Size = new System.Drawing.Size(116, 26);
            this.bfbtnLogout.TabIndex = 11;
            this.bfbtnLogout.Text = "LOGOUT";
            this.bfbtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbtnLogout.Textcolor = System.Drawing.Color.Black;
            this.bfbtnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbtnLogout.Click += new System.EventHandler(this.bfbtnLogout_Click);
            // 
            // picMales
            // 
            this.picMales.BackColor = System.Drawing.Color.White;
            this.picMales.Image = global::RocketFreight.Properties.Resources.i_males_button;
            this.picMales.Location = new System.Drawing.Point(130, 31);
            this.picMales.Name = "picMales";
            this.picMales.Size = new System.Drawing.Size(97, 30);
            this.picMales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMales.TabIndex = 12;
            this.picMales.TabStop = false;
            this.picMales.Tag = "Male";
            this.picMales.Click += new System.EventHandler(this.picFemales_Click);
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.White;
            this.pictureBox32.Image = global::RocketFreight.Properties.Resources.i_Filter;
            this.pictureBox32.Location = new System.Drawing.Point(20, 3);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(64, 23);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox32.TabIndex = 12;
            this.pictureBox32.TabStop = false;
            // 
            // picFemales
            // 
            this.picFemales.BackColor = System.Drawing.Color.White;
            this.picFemales.Image = global::RocketFreight.Properties.Resources.i_female_button;
            this.picFemales.Location = new System.Drawing.Point(20, 32);
            this.picFemales.Name = "picFemales";
            this.picFemales.Size = new System.Drawing.Size(97, 30);
            this.picFemales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFemales.TabIndex = 12;
            this.picFemales.TabStop = false;
            this.picFemales.Tag = "Female";
            this.picFemales.Click += new System.EventHandler(this.picFemales_Click);
            // 
            // bunifuGradientPanel10
            // 
            this.bunifuGradientPanel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel10.BackgroundImage")));
            this.bunifuGradientPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel10.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel10.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel10.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel10.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel10.Location = new System.Drawing.Point(61, 70);
            this.bunifuGradientPanel10.Name = "bunifuGradientPanel10";
            this.bunifuGradientPanel10.Quality = 10;
            this.bunifuGradientPanel10.Size = new System.Drawing.Size(119, 2);
            this.bunifuGradientPanel10.TabIndex = 3;
            // 
            // bunifuGradientPanel9
            // 
            this.bunifuGradientPanel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel9.BackgroundImage")));
            this.bunifuGradientPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel9.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel9.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel9.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel9.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel9.Location = new System.Drawing.Point(123, 28);
            this.bunifuGradientPanel9.Name = "bunifuGradientPanel9";
            this.bunifuGradientPanel9.Quality = 10;
            this.bunifuGradientPanel9.Size = new System.Drawing.Size(2, 33);
            this.bunifuGradientPanel9.TabIndex = 1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.picNewPatient);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox4);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.lblMaleCount);
            this.bunifuGradientPanel1.Controls.Add(this.lblFemaleCount);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.lblTotalCount);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel8);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel6);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel5);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(17, 100);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(243, 206);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // picNewPatient
            // 
            this.picNewPatient.BackColor = System.Drawing.Color.White;
            this.picNewPatient.Image = global::RocketFreight.Properties.Resources.i_Add_new_Patient_Button;
            this.picNewPatient.Location = new System.Drawing.Point(65, 172);
            this.picNewPatient.Name = "picNewPatient";
            this.picNewPatient.Size = new System.Drawing.Size(139, 25);
            this.picNewPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewPatient.TabIndex = 13;
            this.picNewPatient.TabStop = false;
            this.picNewPatient.Click += new System.EventHandler(this.picNewPatient_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::RocketFreight.Properties.Resources.i_stat_icon;
            this.pictureBox4.Location = new System.Drawing.Point(81, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::RocketFreight.Properties.Resources.i_male_icon;
            this.pictureBox3.Location = new System.Drawing.Point(134, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::RocketFreight.Properties.Resources.i_female_icon;
            this.pictureBox2.Location = new System.Drawing.Point(80, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblMaleCount
            // 
            this.lblMaleCount.AutoSize = true;
            this.lblMaleCount.BackColor = System.Drawing.Color.White;
            this.lblMaleCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaleCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMaleCount.Location = new System.Drawing.Point(138, 52);
            this.lblMaleCount.Name = "lblMaleCount";
            this.lblMaleCount.Size = new System.Drawing.Size(28, 13);
            this.lblMaleCount.TabIndex = 9;
            this.lblMaleCount.Text = "277";
            // 
            // lblFemaleCount
            // 
            this.lblFemaleCount.AutoSize = true;
            this.lblFemaleCount.BackColor = System.Drawing.Color.White;
            this.lblFemaleCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFemaleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemaleCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFemaleCount.Location = new System.Drawing.Point(82, 52);
            this.lblFemaleCount.Name = "lblFemaleCount";
            this.lblFemaleCount.Size = new System.Drawing.Size(28, 13);
            this.lblFemaleCount.TabIndex = 8;
            this.lblFemaleCount.Text = "382";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(75, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Females";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(135, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Males";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.BackColor = System.Drawing.Color.White;
            this.lblTotalCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalCount.Location = new System.Drawing.Point(119, 123);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(28, 13);
            this.lblTotalCount.TabIndex = 5;
            this.lblTotalCount.Text = "659";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(116, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Patients";
            // 
            // bunifuGradientPanel8
            // 
            this.bunifuGradientPanel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel8.BackgroundImage")));
            this.bunifuGradientPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel8.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel8.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel8.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel8.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel8.Location = new System.Drawing.Point(72, 151);
            this.bunifuGradientPanel8.Name = "bunifuGradientPanel8";
            this.bunifuGradientPanel8.Quality = 10;
            this.bunifuGradientPanel8.Size = new System.Drawing.Size(119, 2);
            this.bunifuGradientPanel8.TabIndex = 2;
            // 
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.Controls.Add(this.bunifuGradientPanel7);
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(72, 85);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(119, 2);
            this.bunifuGradientPanel6.TabIndex = 1;
            // 
            // bunifuGradientPanel7
            // 
            this.bunifuGradientPanel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel7.BackgroundImage")));
            this.bunifuGradientPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel7.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel7.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel7.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel7.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel7.Location = new System.Drawing.Point(0, 51);
            this.bunifuGradientPanel7.Name = "bunifuGradientPanel7";
            this.bunifuGradientPanel7.Quality = 10;
            this.bunifuGradientPanel7.Size = new System.Drawing.Size(119, 2);
            this.bunifuGradientPanel7.TabIndex = 2;
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(123, 11);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(2, 50);
            this.bunifuGradientPanel5.TabIndex = 0;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(738, 479);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemales)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel8;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel7;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel10;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel9;
        private System.Windows.Forms.PictureBox picNewPatient;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMaleCount;
        private System.Windows.Forms.Label lblFemaleCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalCount;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private InputControls.TextBoxControl tcSearch;
        private System.Windows.Forms.PictureBox picMales;
        private System.Windows.Forms.PictureBox picFemales;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuFlatButton bfbtnLogout;
    }
}
