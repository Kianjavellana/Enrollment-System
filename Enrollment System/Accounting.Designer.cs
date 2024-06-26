namespace Enrollment_System
{
    partial class Accounting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offeredSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolYearTermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPayment = new System.Windows.Forms.Label();
            this.pbPayment = new System.Windows.Forms.PictureBox();
            this.lbFee = new System.Windows.Forms.Label();
            this.pbFee = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFee)).BeginInit();
            this.SuspendLayout();
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.exitToolStripMenuItem.Text = "Logout";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(148, 28);
            this.exitToolStripMenuItem1.Text = "Exit";
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
            this.menuStrip1.Size = new System.Drawing.Size(1038, 31);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.coursesToolStripMenuItem1,
            this.offeredSubjectsToolStripMenuItem,
            this.toolStripMenuItem2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(219, 28);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // coursesToolStripMenuItem1
            // 
            this.coursesToolStripMenuItem1.Name = "coursesToolStripMenuItem1";
            this.coursesToolStripMenuItem1.Size = new System.Drawing.Size(219, 28);
            this.coursesToolStripMenuItem1.Text = "Courses";
            // 
            // offeredSubjectsToolStripMenuItem
            // 
            this.offeredSubjectsToolStripMenuItem.Name = "offeredSubjectsToolStripMenuItem";
            this.offeredSubjectsToolStripMenuItem.Size = new System.Drawing.Size(219, 28);
            this.offeredSubjectsToolStripMenuItem.Text = "Offered Subjects";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(219, 28);
            this.toolStripMenuItem2.Text = "....";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDefaultToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.sectionsToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.systemUserToolStripMenuItem,
            this.studentManagementToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // setDefaultToolStripMenuItem
            // 
            this.setDefaultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolYearTermToolStripMenuItem});
            this.setDefaultToolStripMenuItem.Name = "setDefaultToolStripMenuItem";
            this.setDefaultToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.setDefaultToolStripMenuItem.Text = "Set Default";
            // 
            // schoolYearTermToolStripMenuItem
            // 
            this.schoolYearTermToolStripMenuItem.Name = "schoolYearTermToolStripMenuItem";
            this.schoolYearTermToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.schoolYearTermToolStripMenuItem.Text = "School Year Term";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.subjectToolStripMenuItem.Text = "Subject";
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // sectionsToolStripMenuItem
            // 
            this.sectionsToolStripMenuItem.Name = "sectionsToolStripMenuItem";
            this.sectionsToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.sectionsToolStripMenuItem.Text = "Sections";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.teachersToolStripMenuItem.Text = "Teachers";
            // 
            // systemUserToolStripMenuItem
            // 
            this.systemUserToolStripMenuItem.Name = "systemUserToolStripMenuItem";
            this.systemUserToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.systemUserToolStripMenuItem.Text = "System User";
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.defaultToolStripMenuItem.Text = "DefaultSchoolYearTerm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main Menu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPayment);
            this.panel1.Controls.Add(this.pbPayment);
            this.panel1.Controls.Add(this.lbFee);
            this.panel1.Controls.Add(this.pbFee);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(148, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 363);
            this.panel1.TabIndex = 13;
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.Location = new System.Drawing.Point(417, 265);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(99, 23);
            this.lbPayment.TabIndex = 16;
            this.lbPayment.Text = "PAYMENT";
            this.lbPayment.Click += new System.EventHandler(this.lbPayment_Click);
            // 
            // pbPayment
            // 
            this.pbPayment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbPayment.BackgroundImage = global::Enrollment_System.Properties.Resources.credit_card_677120;
            this.pbPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPayment.Location = new System.Drawing.Point(406, 137);
            this.pbPayment.Name = "pbPayment";
            this.pbPayment.Size = new System.Drawing.Size(125, 125);
            this.pbPayment.TabIndex = 15;
            this.pbPayment.TabStop = false;
            this.pbPayment.Click += new System.EventHandler(this.pbPayment_Click);
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFee.Location = new System.Drawing.Point(262, 265);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(40, 23);
            this.lbFee.TabIndex = 14;
            this.lbFee.Text = "FEE";
            this.lbFee.Click += new System.EventHandler(this.lbFee_Click);
            // 
            // pbFee
            // 
            this.pbFee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbFee.BackgroundImage = global::Enrollment_System.Properties.Resources.receipt_10953082;
            this.pbFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFee.Location = new System.Drawing.Point(223, 137);
            this.pbFee.Name = "pbFee";
            this.pbFee.Size = new System.Drawing.Size(125, 125);
            this.pbFee.TabIndex = 13;
            this.pbFee.TabStop = false;
            this.pbFee.Click += new System.EventHandler(this.pbFee_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1038, 537);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accounting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Accounting_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem offeredSubjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolYearTermToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.PictureBox pbPayment;
        private System.Windows.Forms.Label lbFee;
        private System.Windows.Forms.PictureBox pbFee;
    }
}