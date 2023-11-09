namespace RocketFreight.UserControls
{
    partial class ucUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcSearch = new RocketFreight.InputControls.TextBoxControl();
            this.tcUsername = new RocketFreight.InputControls.TextBoxControl();
            this.tcEmail = new RocketFreight.InputControls.TextBoxControl();
            this.tcAddress = new RocketFreight.InputControls.TextBoxControl();
            this.tcPhone = new RocketFreight.InputControls.TextBoxControl();
            this.tcFirstName = new RocketFreight.InputControls.TextBoxControl();
            this.tcLastName = new RocketFreight.InputControls.TextBoxControl();
            this.label7 = new System.Windows.Forms.Label();
            this.drpcType = new RocketFreight.InputControls.DropDownControl();
            this.label8 = new System.Windows.Forms.Label();
            this.tcPassword = new RocketFreight.InputControls.TextBoxControl();
            this.label9 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(7, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(7, 253);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search:";
            // 
            // tcSearch
            // 
            this.tcSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tcSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcSearch.BorderRadius = 5;
            this.tcSearch.BorderSize = 2;
            this.tcSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcSearch.Location = new System.Drawing.Point(75, 21);
            this.tcSearch.Margin = new System.Windows.Forms.Padding(1);
            this.tcSearch.Multiline = false;
            this.tcSearch.Name = "tcSearch";
            this.tcSearch.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tcSearch.PasswordChar = false;
            this.tcSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcSearch.PlaceholderText = "";
            this.tcSearch.Size = new System.Drawing.Size(177, 29);
            this.tcSearch.TabIndex = 11;
            this.tcSearch.Texts = "";
            this.tcSearch.UnderlinedStyle = false;
            // 
            // tcUsername
            // 
            this.tcUsername.BackColor = System.Drawing.SystemColors.Window;
            this.tcUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcUsername.BorderRadius = 5;
            this.tcUsername.BorderSize = 2;
            this.tcUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcUsername.Location = new System.Drawing.Point(9, 270);
            this.tcUsername.Margin = new System.Windows.Forms.Padding(1);
            this.tcUsername.Multiline = false;
            this.tcUsername.Name = "tcUsername";
            this.tcUsername.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tcUsername.PasswordChar = false;
            this.tcUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcUsername.PlaceholderText = "";
            this.tcUsername.Size = new System.Drawing.Size(117, 29);
            this.tcUsername.TabIndex = 6;
            this.tcUsername.Texts = "";
            this.tcUsername.UnderlinedStyle = false;
            // 
            // tcEmail
            // 
            this.tcEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tcEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcEmail.BorderRadius = 5;
            this.tcEmail.BorderSize = 2;
            this.tcEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcEmail.Location = new System.Drawing.Point(9, 222);
            this.tcEmail.Margin = new System.Windows.Forms.Padding(1);
            this.tcEmail.Multiline = false;
            this.tcEmail.Name = "tcEmail";
            this.tcEmail.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tcEmail.PasswordChar = false;
            this.tcEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcEmail.PlaceholderText = "";
            this.tcEmail.Size = new System.Drawing.Size(240, 29);
            this.tcEmail.TabIndex = 5;
            this.tcEmail.Texts = "";
            this.tcEmail.UnderlinedStyle = false;
            // 
            // tcAddress
            // 
            this.tcAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tcAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcAddress.BorderRadius = 5;
            this.tcAddress.BorderSize = 2;
            this.tcAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcAddress.Location = new System.Drawing.Point(9, 170);
            this.tcAddress.Margin = new System.Windows.Forms.Padding(1);
            this.tcAddress.Multiline = false;
            this.tcAddress.Name = "tcAddress";
            this.tcAddress.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tcAddress.PasswordChar = false;
            this.tcAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcAddress.PlaceholderText = "";
            this.tcAddress.Size = new System.Drawing.Size(240, 29);
            this.tcAddress.TabIndex = 4;
            this.tcAddress.Texts = "";
            this.tcAddress.UnderlinedStyle = false;
            // 
            // tcPhone
            // 
            this.tcPhone.BackColor = System.Drawing.SystemColors.Window;
            this.tcPhone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcPhone.BorderRadius = 5;
            this.tcPhone.BorderSize = 2;
            this.tcPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcPhone.Location = new System.Drawing.Point(10, 120);
            this.tcPhone.Margin = new System.Windows.Forms.Padding(1);
            this.tcPhone.Multiline = false;
            this.tcPhone.Name = "tcPhone";
            this.tcPhone.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tcPhone.PasswordChar = false;
            this.tcPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcPhone.PlaceholderText = "";
            this.tcPhone.Size = new System.Drawing.Size(239, 29);
            this.tcPhone.TabIndex = 3;
            this.tcPhone.Texts = "";
            this.tcPhone.UnderlinedStyle = false;
            // 
            // tcFirstName
            // 
            this.tcFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.tcFirstName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcFirstName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcFirstName.BorderRadius = 5;
            this.tcFirstName.BorderSize = 2;
            this.tcFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcFirstName.Location = new System.Drawing.Point(9, 24);
            this.tcFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.tcFirstName.Multiline = false;
            this.tcFirstName.Name = "tcFirstName";
            this.tcFirstName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tcFirstName.PasswordChar = false;
            this.tcFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcFirstName.PlaceholderText = "";
            this.tcFirstName.Size = new System.Drawing.Size(117, 29);
            this.tcFirstName.TabIndex = 0;
            this.tcFirstName.Texts = "";
            this.tcFirstName.UnderlinedStyle = false;
            // 
            // tcLastName
            // 
            this.tcLastName.BackColor = System.Drawing.SystemColors.Window;
            this.tcLastName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcLastName.BorderRadius = 5;
            this.tcLastName.BorderSize = 2;
            this.tcLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcLastName.Location = new System.Drawing.Point(132, 24);
            this.tcLastName.Margin = new System.Windows.Forms.Padding(1);
            this.tcLastName.Multiline = false;
            this.tcLastName.Name = "tcLastName";
            this.tcLastName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tcLastName.PasswordChar = false;
            this.tcLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcLastName.PlaceholderText = "";
            this.tcLastName.Size = new System.Drawing.Size(117, 29);
            this.tcLastName.TabIndex = 1;
            this.tcLastName.Texts = "";
            this.tcLastName.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(130, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Last Name:";
            // 
            // drpcType
            // 
            this.drpcType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drpcType.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.drpcType.BorderSize = 1;
            this.drpcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.drpcType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.drpcType.ForeColor = System.Drawing.Color.DimGray;
            this.drpcType.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.drpcType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.drpcType.ListTextColor = System.Drawing.Color.DimGray;
            this.drpcType.Location = new System.Drawing.Point(9, 76);
            this.drpcType.Margin = new System.Windows.Forms.Padding(1);
            this.drpcType.MinimumSize = new System.Drawing.Size(150, 24);
            this.drpcType.Name = "drpcType";
            this.drpcType.Padding = new System.Windows.Forms.Padding(1);
            this.drpcType.Size = new System.Drawing.Size(240, 24);
            this.drpcType.TabIndex = 2;
            this.drpcType.Texts = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(7, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Type:";
            // 
            // tcPassword
            // 
            this.tcPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tcPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcPassword.BorderRadius = 5;
            this.tcPassword.BorderSize = 2;
            this.tcPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcPassword.Location = new System.Drawing.Point(132, 270);
            this.tcPassword.Margin = new System.Windows.Forms.Padding(1);
            this.tcPassword.Multiline = false;
            this.tcPassword.Name = "tcPassword";
            this.tcPassword.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tcPassword.PasswordChar = false;
            this.tcPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcPassword.PlaceholderText = "";
            this.tcPassword.Size = new System.Drawing.Size(117, 29);
            this.tcPassword.TabIndex = 7;
            this.tcPassword.Texts = "";
            this.tcPassword.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(131, 252);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Password:";
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Image = global::RocketFreight.Properties.Resources.i_user;
            this.picImage.Location = new System.Drawing.Point(9, 304);
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(117, 80);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 13;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::RocketFreight.Properties.Resources.export_24px;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(269, 17);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 31);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "&Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImport.BackgroundImage")));
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Image = global::RocketFreight.Properties.Resources.attach_24px;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(392, 17);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(119, 31);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "&Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::RocketFreight.Properties.Resources.i_close;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(480, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::RocketFreight.Properties.Resources.i_clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(130, 387);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 31);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = global::RocketFreight.Properties.Resources.attach_24px;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(130, 353);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(119, 31);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(9, 388);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 31);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Save";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.dgvSearch.Location = new System.Drawing.Point(24, 52);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(575, 319);
            this.dgvSearch.TabIndex = 16;
            this.toolTip1.SetToolTip(this.dgvSearch, "Double-click to View Report");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picImage);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.drpcType);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tcPassword);
            this.panel1.Controls.Add(this.tcUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tcEmail);
            this.panel1.Controls.Add(this.tcAddress);
            this.panel1.Controls.Add(this.tcPhone);
            this.panel1.Controls.Add(this.tcLastName);
            this.panel1.Controls.Add(this.tcFirstName);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 432);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::RocketFreight.Properties.Resources.dashboard_rec;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.dgvSearch);
            this.panel2.Controls.Add(this.tcSearch);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(285, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 428);
            this.panel2.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.ForeColor = System.Drawing.Color.Lime;
            this.btnEdit.Image = global::RocketFreight.Properties.Resources.i_pen;
            this.btnEdit.Location = new System.Drawing.Point(529, 19);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 31);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnEdit, "Click to edit the selected record");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.Lime;
            this.btnDelete.Image = global::RocketFreight.Properties.Resources.i_clear;
            this.btnDelete.Location = new System.Drawing.Point(567, 19);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 31);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnDelete, "Click to delete the selected record");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(896, 436);
            this.Load += new System.EventHandler(this.ucUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private InputControls.TextBoxControl tcFirstName;
        private InputControls.TextBoxControl tcPhone;
        private InputControls.TextBoxControl tcAddress;
        private InputControls.TextBoxControl tcEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private InputControls.TextBoxControl tcUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private InputControls.TextBoxControl tcSearch;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private InputControls.TextBoxControl tcLastName;
        private System.Windows.Forms.Label label7;
        private InputControls.DropDownControl drpcType;
        private System.Windows.Forms.Label label8;
        private InputControls.TextBoxControl tcPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
