namespace Enrollment_System
{
    partial class StudentPayment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStudentID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.cbSchoolYear = new System.Windows.Forms.ComboBox();
            this.cbModeofPayment = new System.Windows.Forms.ComboBox();
            this.cbPaidTo = new System.Windows.Forms.ComboBox();
            this.btClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btUpdateFee = new System.Windows.Forms.Button();
            this.tbSave = new System.Windows.Forms.Button();
            this.AddFee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btDeleteByIDNumber = new System.Windows.Forms.Button();
            this.dataGridViewStudentPaymentList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentPaymentList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 31);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsListToolStripMenuItem,
            this.coursesListToolStripMenuItem,
            this.subjectListToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // studentsListToolStripMenuItem
            // 
            this.studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            this.studentsListToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.studentsListToolStripMenuItem.Text = "Students List";
            // 
            // coursesListToolStripMenuItem
            // 
            this.coursesListToolStripMenuItem.Name = "coursesListToolStripMenuItem";
            this.coursesListToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.coursesListToolStripMenuItem.Text = "Courses List";
            // 
            // subjectListToolStripMenuItem
            // 
            this.subjectListToolStripMenuItem.Name = "subjectListToolStripMenuItem";
            this.subjectListToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.subjectListToolStripMenuItem.Text = "Subject List";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Location = new System.Drawing.Point(0, 31);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(1234, 57);
            this.btMainMenu.TabIndex = 43;
            this.btMainMenu.Text = "Main Menu";
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1234, 564);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "StudentPayment :";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStudentID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtpPaymentDate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbDetails);
            this.panel1.Controls.Add(this.cbPaymentType);
            this.panel1.Controls.Add(this.cbTerm);
            this.panel1.Controls.Add(this.cbSchoolYear);
            this.panel1.Controls.Add(this.cbModeofPayment);
            this.panel1.Controls.Add(this.cbPaidTo);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btUpdateFee);
            this.panel1.Controls.Add(this.tbSave);
            this.panel1.Controls.Add(this.AddFee);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1220, 526);
            this.panel1.TabIndex = 44;
            // 
            // cbStudentID
            // 
            this.cbStudentID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStudentID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudentID.FormattingEnabled = true;
            this.cbStudentID.Location = new System.Drawing.Point(67, 69);
            this.cbStudentID.Name = "cbStudentID";
            this.cbStudentID.Size = new System.Drawing.Size(284, 29);
            this.cbStudentID.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(844, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 59;
            this.label11.Text = "Payment Date :";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Location = new System.Drawing.Point(841, 150);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(284, 28);
            this.dtpPaymentDate.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(845, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 57;
            this.label10.Text = "Amount :";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(841, 69);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(284, 28);
            this.tbAmount.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(451, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "Details :";
            // 
            // tbDetails
            // 
            this.tbDetails.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetails.Location = new System.Drawing.Point(446, 323);
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(284, 28);
            this.tbDetails.TabIndex = 54;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPaymentType.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "Tuition",
            "Book",
            "Sundries",
            "Others"});
            this.cbPaymentType.Location = new System.Drawing.Point(67, 236);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(284, 29);
            this.cbPaymentType.TabIndex = 53;
            // 
            // cbTerm
            // 
            this.cbTerm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTerm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbTerm.Location = new System.Drawing.Point(446, 236);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(284, 29);
            this.cbTerm.TabIndex = 52;
            // 
            // cbSchoolYear
            // 
            this.cbSchoolYear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSchoolYear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSchoolYear.FormattingEnabled = true;
            this.cbSchoolYear.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbSchoolYear.Location = new System.Drawing.Point(446, 150);
            this.cbSchoolYear.Name = "cbSchoolYear";
            this.cbSchoolYear.Size = new System.Drawing.Size(284, 29);
            this.cbSchoolYear.TabIndex = 51;
            // 
            // cbModeofPayment
            // 
            this.cbModeofPayment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbModeofPayment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModeofPayment.FormattingEnabled = true;
            this.cbModeofPayment.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Online"});
            this.cbModeofPayment.Location = new System.Drawing.Point(67, 322);
            this.cbModeofPayment.Name = "cbModeofPayment";
            this.cbModeofPayment.Size = new System.Drawing.Size(284, 29);
            this.cbModeofPayment.TabIndex = 50;
            // 
            // cbPaidTo
            // 
            this.cbPaidTo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPaidTo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaidTo.FormattingEnabled = true;
            this.cbPaidTo.Items.AddRange(new object[] {
            "LEC",
            "LAB"});
            this.cbPaidTo.Location = new System.Drawing.Point(446, 70);
            this.cbPaidTo.Name = "cbPaidTo";
            this.cbPaidTo.Size = new System.Drawing.Size(284, 29);
            this.cbPaidTo.TabIndex = 49;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.Black;
            this.btClear.Location = new System.Drawing.Point(820, 408);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(146, 50);
            this.btClear.TabIndex = 47;
            this.btClear.Text = "Clear Fields :";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Mode of Payment :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "School Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Term:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Paid To :";
            // 
            // btUpdateFee
            // 
            this.btUpdateFee.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btUpdateFee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btUpdateFee.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateFee.ForeColor = System.Drawing.Color.Black;
            this.btUpdateFee.Location = new System.Drawing.Point(634, 408);
            this.btUpdateFee.Name = "btUpdateFee";
            this.btUpdateFee.Size = new System.Drawing.Size(141, 50);
            this.btUpdateFee.TabIndex = 38;
            this.btUpdateFee.Text = "Update ";
            this.btUpdateFee.UseVisualStyleBackColor = false;
            this.btUpdateFee.Click += new System.EventHandler(this.btUpdateFee_Click);
            // 
            // tbSave
            // 
            this.tbSave.BackColor = System.Drawing.Color.CadetBlue;
            this.tbSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tbSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSave.Location = new System.Drawing.Point(446, 408);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(143, 50);
            this.tbSave.TabIndex = 37;
            this.tbSave.Text = "Save";
            this.tbSave.UseVisualStyleBackColor = false;
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // AddFee
            // 
            this.AddFee.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddFee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddFee.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFee.Location = new System.Drawing.Point(253, 408);
            this.AddFee.Name = "AddFee";
            this.AddFee.Size = new System.Drawing.Size(138, 50);
            this.AddFee.TabIndex = 35;
            this.AddFee.Text = "+ Payment";
            this.AddFee.UseVisualStyleBackColor = false;
            this.AddFee.Click += new System.EventHandler(this.AddFee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Payment Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Student ID:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(67, 150);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(284, 28);
            this.tbDescription.TabIndex = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "StudentPaymentList :";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btDeleteByIDNumber);
            this.panel3.Controls.Add(this.dataGridViewStudentPaymentList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(25);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(1220, 526);
            this.panel3.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(547, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 50);
            this.button2.TabIndex = 55;
            this.button2.Text = "Update ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(119, 31);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(422, 28);
            this.tbSearch.TabIndex = 54;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 53;
            this.label12.Text = "Search";
            // 
            // btDeleteByIDNumber
            // 
            this.btDeleteByIDNumber.BackColor = System.Drawing.Color.Red;
            this.btDeleteByIDNumber.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteByIDNumber.Location = new System.Drawing.Point(710, 10);
            this.btDeleteByIDNumber.Name = "btDeleteByIDNumber";
            this.btDeleteByIDNumber.Size = new System.Drawing.Size(146, 52);
            this.btDeleteByIDNumber.TabIndex = 52;
            this.btDeleteByIDNumber.Text = "DELETE";
            this.btDeleteByIDNumber.UseVisualStyleBackColor = false;
            this.btDeleteByIDNumber.Click += new System.EventHandler(this.btDeleteByIDNumber_Click);
            // 
            // dataGridViewStudentPaymentList
            // 
            this.dataGridViewStudentPaymentList.AllowUserToAddRows = false;
            this.dataGridViewStudentPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentPaymentList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewStudentPaymentList.Location = new System.Drawing.Point(20, 68);
            this.dataGridViewStudentPaymentList.Name = "dataGridViewStudentPaymentList";
            this.dataGridViewStudentPaymentList.RowHeadersWidth = 51;
            this.dataGridViewStudentPaymentList.RowTemplate.Height = 24;
            this.dataGridViewStudentPaymentList.Size = new System.Drawing.Size(1180, 438);
            this.dataGridViewStudentPaymentList.TabIndex = 1;
            this.dataGridViewStudentPaymentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentPaymentList_CellClick);
            // 
            // StudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1234, 652);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPayment";
            this.Load += new System.EventHandler(this.StudentPayment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentPaymentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.ComboBox cbSchoolYear;
        private System.Windows.Forms.ComboBox cbModeofPayment;
        private System.Windows.Forms.ComboBox cbPaidTo;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btUpdateFee;
        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.Button AddFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btDeleteByIDNumber;
        private System.Windows.Forms.DataGridView dataGridViewStudentPaymentList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStudentID;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
    }
}