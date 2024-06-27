namespace Enrollment_System
{
    partial class Student
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentsListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coursesListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btMainMenu = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.picBoxStudentImage = new System.Windows.Forms.PictureBox();
			this.btnGetPhoto = new System.Windows.Forms.Button();
			this.btnModify = new System.Windows.Forms.Button();
			this.cbStudentStatus = new System.Windows.Forms.ComboBox();
			this.cbCourseCode = new System.Windows.Forms.ComboBox();
			this.btClear = new System.Windows.Forms.Button();
			this.btAddStudent = new System.Windows.Forms.Button();
			this.btsaveStudent = new System.Windows.Forms.Button();
			this.tbEmailAddress = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.tbContactNumber = new System.Windows.Forms.TextBox();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.cbGender = new System.Windows.Forms.ComboBox();
			this.cbYearLevel = new System.Windows.Forms.ComboBox();
			this.tbMiddleName = new System.Windows.Forms.TextBox();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbStudentID = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btDeleteByIDNumber = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxStudentImage)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem});
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
			this.loginToolStripMenuItem.Text = "Login";
			// 
			// registerToolStripMenuItem
			// 
			this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
			this.registerToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
			this.registerToolStripMenuItem.Text = "Register";
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
			this.logoutToolStripMenuItem.Text = "Logout";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsListsToolStripMenuItem,
            this.coursesListsToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// studentsListsToolStripMenuItem
			// 
			this.studentsListsToolStripMenuItem.Name = "studentsListsToolStripMenuItem";
			this.studentsListsToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
			this.studentsListsToolStripMenuItem.Text = "Students Lists";
			this.studentsListsToolStripMenuItem.Click += new System.EventHandler(this.studentsListsToolStripMenuItem_Click);
			// 
			// coursesListsToolStripMenuItem
			// 
			this.coursesListsToolStripMenuItem.Name = "coursesListsToolStripMenuItem";
			this.coursesListsToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
			this.coursesListsToolStripMenuItem.Text = "Courses Lists";
			// 
			// maintenanceToolStripMenuItem
			// 
			this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
			this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
			this.maintenanceToolStripMenuItem.Text = "Maintenance";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.maintenanceToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1232, 31);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btMainMenu
			// 
			this.btMainMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.btMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMainMenu.Location = new System.Drawing.Point(0, 31);
			this.btMainMenu.Name = "btMainMenu";
			this.btMainMenu.Size = new System.Drawing.Size(1232, 57);
			this.btMainMenu.TabIndex = 40;
			this.btMainMenu.Text = "Main Menu";
			this.btMainMenu.UseVisualStyleBackColor = false;
			this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 88);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1232, 695);
			this.tabControl1.TabIndex = 41;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1224, 666);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "STUDENT";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.picBoxStudentImage);
			this.panel2.Controls.Add(this.btnGetPhoto);
			this.panel2.Controls.Add(this.btnModify);
			this.panel2.Controls.Add(this.cbStudentStatus);
			this.panel2.Controls.Add(this.cbCourseCode);
			this.panel2.Controls.Add(this.btClear);
			this.panel2.Controls.Add(this.btAddStudent);
			this.panel2.Controls.Add(this.btsaveStudent);
			this.panel2.Controls.Add(this.tbEmailAddress);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.tbContactNumber);
			this.panel2.Controls.Add(this.tbAddress);
			this.panel2.Controls.Add(this.dtpBirthDate);
			this.panel2.Controls.Add(this.cbGender);
			this.panel2.Controls.Add(this.cbYearLevel);
			this.panel2.Controls.Add(this.tbMiddleName);
			this.panel2.Controls.Add(this.tbLastName);
			this.panel2.Controls.Add(this.tbFirstName);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.tbStudentID);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(20);
			this.panel2.Size = new System.Drawing.Size(1218, 660);
			this.panel2.TabIndex = 3;
			// 
			// picBoxStudentImage
			// 
			this.picBoxStudentImage.BackColor = System.Drawing.Color.Gainsboro;
			this.picBoxStudentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picBoxStudentImage.Location = new System.Drawing.Point(750, 352);
			this.picBoxStudentImage.Name = "picBoxStudentImage";
			this.picBoxStudentImage.Size = new System.Drawing.Size(169, 161);
			this.picBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBoxStudentImage.TabIndex = 42;
			this.picBoxStudentImage.TabStop = false;
			// 
			// btnGetPhoto
			// 
			this.btnGetPhoto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnGetPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGetPhoto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGetPhoto.Location = new System.Drawing.Point(993, 456);
			this.btnGetPhoto.Name = "btnGetPhoto";
			this.btnGetPhoto.Size = new System.Drawing.Size(168, 57);
			this.btnGetPhoto.TabIndex = 41;
			this.btnGetPhoto.Text = "+ Image";
			this.btnGetPhoto.UseVisualStyleBackColor = false;
			this.btnGetPhoto.Click += new System.EventHandler(this.btnGetPhoto_Click);
			// 
			// btnModify
			// 
			this.btnModify.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModify.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModify.ForeColor = System.Drawing.Color.Black;
			this.btnModify.Location = new System.Drawing.Point(596, 548);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(146, 50);
			this.btnModify.TabIndex = 30;
			this.btnModify.Text = "Modify";
			this.btnModify.UseVisualStyleBackColor = false;
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// cbStudentStatus
			// 
			this.cbStudentStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbStudentStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbStudentStatus.FormattingEnabled = true;
			this.cbStudentStatus.Items.AddRange(new object[] {
            "Enrolled",
            "Un Enrolled"});
			this.cbStudentStatus.Location = new System.Drawing.Point(742, 102);
			this.cbStudentStatus.Name = "cbStudentStatus";
			this.cbStudentStatus.Size = new System.Drawing.Size(289, 29);
			this.cbStudentStatus.TabIndex = 29;
			// 
			// cbCourseCode
			// 
			this.cbCourseCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbCourseCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCourseCode.FormattingEnabled = true;
			this.cbCourseCode.Location = new System.Drawing.Point(107, 456);
			this.cbCourseCode.Name = "cbCourseCode";
			this.cbCourseCode.Size = new System.Drawing.Size(232, 29);
			this.cbCourseCode.TabIndex = 28;
			// 
			// btClear
			// 
			this.btClear.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btClear.ForeColor = System.Drawing.Color.Black;
			this.btClear.Location = new System.Drawing.Point(795, 548);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(146, 50);
			this.btClear.TabIndex = 27;
			this.btClear.Text = "Clear Fields :";
			this.btClear.UseVisualStyleBackColor = false;
			this.btClear.Click += new System.EventHandler(this.btClear_Click_1);
			// 
			// btAddStudent
			// 
			this.btAddStudent.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btAddStudent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAddStudent.ForeColor = System.Drawing.Color.White;
			this.btAddStudent.Location = new System.Drawing.Point(193, 548);
			this.btAddStudent.Name = "btAddStudent";
			this.btAddStudent.Size = new System.Drawing.Size(146, 50);
			this.btAddStudent.TabIndex = 26;
			this.btAddStudent.Text = "+ Student";
			this.btAddStudent.UseVisualStyleBackColor = false;
			this.btAddStudent.Click += new System.EventHandler(this.btAddStudent_Click);
			// 
			// btsaveStudent
			// 
			this.btsaveStudent.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btsaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btsaveStudent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btsaveStudent.ForeColor = System.Drawing.Color.White;
			this.btsaveStudent.Location = new System.Drawing.Point(401, 548);
			this.btsaveStudent.Name = "btsaveStudent";
			this.btsaveStudent.Size = new System.Drawing.Size(146, 50);
			this.btsaveStudent.TabIndex = 25;
			this.btsaveStudent.Text = "Save";
			this.btsaveStudent.UseVisualStyleBackColor = false;
			this.btsaveStudent.Click += new System.EventHandler(this.btsaveStudent_Click);
			// 
			// tbEmailAddress
			// 
			this.tbEmailAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEmailAddress.Location = new System.Drawing.Point(428, 278);
			this.tbEmailAddress.Name = "tbEmailAddress";
			this.tbEmailAddress.Size = new System.Drawing.Size(262, 30);
			this.tbEmailAddress.TabIndex = 23;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(431, 252);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(135, 19);
			this.label14.TabIndex = 22;
			this.label14.Text = "Email Address :";
			// 
			// tbContactNumber
			// 
			this.tbContactNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbContactNumber.Location = new System.Drawing.Point(742, 278);
			this.tbContactNumber.Name = "tbContactNumber";
			this.tbContactNumber.Size = new System.Drawing.Size(289, 30);
			this.tbContactNumber.TabIndex = 21;
			this.tbContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContactNumber_KeyPress);
			// 
			// tbAddress
			// 
			this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAddress.Location = new System.Drawing.Point(428, 359);
			this.tbAddress.Multiline = true;
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(262, 110);
			this.tbAddress.TabIndex = 20;
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpBirthDate.Location = new System.Drawing.Point(742, 182);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(289, 28);
			this.dtpBirthDate.TabIndex = 19;
			// 
			// cbGender
			// 
			this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbGender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbGender.FormattingEnabled = true;
			this.cbGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
			this.cbGender.Location = new System.Drawing.Point(428, 188);
			this.cbGender.Name = "cbGender";
			this.cbGender.Size = new System.Drawing.Size(262, 29);
			this.cbGender.TabIndex = 18;
			// 
			// cbYearLevel
			// 
			this.cbYearLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbYearLevel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbYearLevel.FormattingEnabled = true;
			this.cbYearLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.cbYearLevel.Location = new System.Drawing.Point(428, 96);
			this.cbYearLevel.Name = "cbYearLevel";
			this.cbYearLevel.Size = new System.Drawing.Size(262, 29);
			this.cbYearLevel.TabIndex = 16;
			this.cbYearLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbYearLevel_KeyPress);
			// 
			// tbMiddleName
			// 
			this.tbMiddleName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMiddleName.Location = new System.Drawing.Point(107, 359);
			this.tbMiddleName.Name = "tbMiddleName";
			this.tbMiddleName.Size = new System.Drawing.Size(232, 30);
			this.tbMiddleName.TabIndex = 14;
			// 
			// tbLastName
			// 
			this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLastName.Location = new System.Drawing.Point(107, 278);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(232, 30);
			this.tbLastName.TabIndex = 13;
			// 
			// tbFirstName
			// 
			this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFirstName.Location = new System.Drawing.Point(107, 182);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(232, 30);
			this.tbFirstName.TabIndex = 12;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(746, 252);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(154, 19);
			this.label13.TabIndex = 11;
			this.label13.Text = "Contact Number :";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(431, 337);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(86, 19);
			this.label12.TabIndex = 10;
			this.label12.Text = "Address :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(746, 160);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(90, 19);
			this.label11.TabIndex = 9;
			this.label11.Text = "BirthDate :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(110, 337);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 19);
			this.label5.TabIndex = 3;
			this.label5.Text = "Middle Name :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(110, 434);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(141, 19);
			this.label6.TabIndex = 4;
			this.label6.Text = "Student Course :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(431, 162);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 19);
			this.label10.TabIndex = 8;
			this.label10.Text = "Gender :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(110, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Last Name :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(431, 73);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 19);
			this.label7.TabIndex = 5;
			this.label7.Text = "Year Level :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(746, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 19);
			this.label8.TabIndex = 6;
			this.label8.Text = "Student Status :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(110, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "First Name :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(110, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Student ID :";
			// 
			// tbStudentID
			// 
			this.tbStudentID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbStudentID.Location = new System.Drawing.Point(107, 94);
			this.tbStudentID.Name = "tbStudentID";
			this.tbStudentID.Size = new System.Drawing.Size(232, 30);
			this.tbStudentID.TabIndex = 0;
			this.tbStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStudentID_KeyPress);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.gridControl1);
			this.tabPage2.Controls.Add(this.btDeleteByIDNumber);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1224, 666);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "LIST";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(42, 89);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1155, 569);
			this.gridControl1.TabIndex = 62;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.GroupCount = 2;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ColumnAutoWidth = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Student ID";
			this.gridColumn1.FieldName = "StudentID";
			this.gridColumn1.MinWidth = 25;
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 165;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Last Name";
			this.gridColumn2.FieldName = "LastName";
			this.gridColumn2.MinWidth = 25;
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 168;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "First Name";
			this.gridColumn3.FieldName = "FirstName";
			this.gridColumn3.MinWidth = 25;
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			this.gridColumn3.Width = 199;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Middle Name";
			this.gridColumn4.FieldName = "MiddleName";
			this.gridColumn4.MinWidth = 25;
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			this.gridColumn4.Width = 197;
			// 
			// gridColumn5
			// 
			this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn5.Caption = "Student Course";
			this.gridColumn5.FieldName = "StudentCourse";
			this.gridColumn5.MinWidth = 25;
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 4;
			this.gridColumn5.Width = 144;
			// 
			// gridColumn6
			// 
			this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn6.Caption = "Year Level";
			this.gridColumn6.FieldName = "YearLevel";
			this.gridColumn6.MinWidth = 25;
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 7;
			this.gridColumn6.Width = 94;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "Student Status";
			this.gridColumn7.FieldName = "StudentStatus";
			this.gridColumn7.MinWidth = 25;
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 4;
			this.gridColumn7.Width = 183;
			// 
			// gridColumn8
			// 
			this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn8.Caption = "Gender";
			this.gridColumn8.FieldName = "Gender";
			this.gridColumn8.MinWidth = 25;
			this.gridColumn8.Name = "gridColumn8";
			this.gridColumn8.Visible = true;
			this.gridColumn8.VisibleIndex = 5;
			this.gridColumn8.Width = 94;
			// 
			// gridColumn9
			// 
			this.gridColumn9.Caption = "Birth Date";
			this.gridColumn9.FieldName = "BirthDate";
			this.gridColumn9.MinWidth = 25;
			this.gridColumn9.Name = "gridColumn9";
			this.gridColumn9.Visible = true;
			this.gridColumn9.VisibleIndex = 6;
			this.gridColumn9.Width = 103;
			// 
			// gridColumn10
			// 
			this.gridColumn10.Caption = "Student Picture";
			this.gridColumn10.FieldName = "StudentPicture";
			this.gridColumn10.MinWidth = 25;
			this.gridColumn10.Name = "gridColumn10";
			this.gridColumn10.Visible = true;
			this.gridColumn10.VisibleIndex = 7;
			this.gridColumn10.Width = 94;
			// 
			// btDeleteByIDNumber
			// 
			this.btDeleteByIDNumber.BackColor = System.Drawing.Color.Red;
			this.btDeleteByIDNumber.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btDeleteByIDNumber.Location = new System.Drawing.Point(1057, 31);
			this.btDeleteByIDNumber.Name = "btDeleteByIDNumber";
			this.btDeleteByIDNumber.Size = new System.Drawing.Size(140, 52);
			this.btDeleteByIDNumber.TabIndex = 48;
			this.btDeleteByIDNumber.Text = "DELETE";
			this.btDeleteByIDNumber.UseVisualStyleBackColor = false;
			this.btDeleteByIDNumber.Click += new System.EventHandler(this.btDeleteByIDNumber_Click_1);
			// 
			// Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1232, 783);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btMainMenu);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Student";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student";
			this.Load += new System.EventHandler(this.Student_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxStudentImage)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ComboBox cbStudentStatus;
        private System.Windows.Forms.ComboBox cbCourseCode;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btAddStudent;
        private System.Windows.Forms.Button btsaveStudent;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbYearLevel;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btDeleteByIDNumber;
        private System.Windows.Forms.PictureBox picBoxStudentImage;
        private System.Windows.Forms.Button btnGetPhoto;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
	}
}