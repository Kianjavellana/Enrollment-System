namespace Enrollment_System
{
    partial class Course
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btClear = new System.Windows.Forms.Button();
            this.cbCourseStatus = new System.Windows.Forms.ComboBox();
            this.btUpdateCourse = new System.Windows.Forms.Button();
            this.tbSave = new System.Windows.Forms.Button();
            this.AddCourse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCourseDescription = new System.Windows.Forms.TextBox();
            this.tbCourseCode = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDeleteByIDNumber = new System.Windows.Forms.Button();
            this.dataGridViewCoursesList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoursesList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(946, 580);
            this.panel1.TabIndex = 28;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 538);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.btClear);
            this.tabPage1.Controls.Add(this.cbCourseStatus);
            this.tabPage1.Controls.Add(this.btUpdateCourse);
            this.tabPage1.Controls.Add(this.tbSave);
            this.tabPage1.Controls.Add(this.AddCourse);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbCourseDescription);
            this.tabPage1.Controls.Add(this.tbCourseCode);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Course :";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.Black;
            this.btClear.Location = new System.Drawing.Point(653, 367);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(146, 50);
            this.btClear.TabIndex = 41;
            this.btClear.Text = "Clear Fields :";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // cbCourseStatus
            // 
            this.cbCourseStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCourseStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourseStatus.FormattingEnabled = true;
            this.cbCourseStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbCourseStatus.Location = new System.Drawing.Point(319, 195);
            this.cbCourseStatus.Name = "cbCourseStatus";
            this.cbCourseStatus.Size = new System.Drawing.Size(284, 29);
            this.cbCourseStatus.TabIndex = 48;
            // 
            // btUpdateCourse
            // 
            this.btUpdateCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btUpdateCourse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btUpdateCourse.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btUpdateCourse.Location = new System.Drawing.Point(478, 367);
            this.btUpdateCourse.Name = "btUpdateCourse";
            this.btUpdateCourse.Size = new System.Drawing.Size(141, 50);
            this.btUpdateCourse.TabIndex = 47;
            this.btUpdateCourse.Text = "Update Course";
            this.btUpdateCourse.UseVisualStyleBackColor = false;
            this.btUpdateCourse.Click += new System.EventHandler(this.btUpdateCourse_Click);
            // 
            // tbSave
            // 
            this.tbSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tbSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSave.ForeColor = System.Drawing.Color.Green;
            this.tbSave.Location = new System.Drawing.Point(289, 365);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(143, 50);
            this.tbSave.TabIndex = 46;
            this.tbSave.Text = "Save";
            this.tbSave.UseVisualStyleBackColor = false;
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCourse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourse.ForeColor = System.Drawing.Color.Blue;
            this.AddCourse.Location = new System.Drawing.Point(106, 365);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(138, 50);
            this.AddCourse.TabIndex = 45;
            this.AddCourse.Text = "+ Course";
            this.AddCourse.UseVisualStyleBackColor = false;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Course Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Course Descripton:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Course Code:";
            // 
            // tbCourseDescription
            // 
            this.tbCourseDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourseDescription.Location = new System.Drawing.Point(319, 288);
            this.tbCourseDescription.Name = "tbCourseDescription";
            this.tbCourseDescription.Size = new System.Drawing.Size(284, 30);
            this.tbCourseDescription.TabIndex = 41;
            // 
            // tbCourseCode
            // 
            this.tbCourseCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourseCode.Location = new System.Drawing.Point(319, 94);
            this.tbCourseCode.Name = "tbCourseCode";
            this.tbCourseCode.Size = new System.Drawing.Size(284, 30);
            this.tbCourseCode.TabIndex = 40;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CourseLIst :";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btDeleteByIDNumber);
            this.panel2.Controls.Add(this.dataGridViewCoursesList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(25);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(890, 487);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(525, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 55;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(95, 35);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(422, 28);
            this.tbSearch.TabIndex = 54;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Search";
            // 
            // btDeleteByIDNumber
            // 
            this.btDeleteByIDNumber.BackColor = System.Drawing.Color.Red;
            this.btDeleteByIDNumber.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteByIDNumber.Location = new System.Drawing.Point(690, 11);
            this.btDeleteByIDNumber.Name = "btDeleteByIDNumber";
            this.btDeleteByIDNumber.Size = new System.Drawing.Size(146, 52);
            this.btDeleteByIDNumber.TabIndex = 52;
            this.btDeleteByIDNumber.Text = "DELETE";
            this.btDeleteByIDNumber.UseVisualStyleBackColor = false;
            this.btDeleteByIDNumber.Click += new System.EventHandler(this.btDeleteByIDNumber_Click);
            // 
            // dataGridViewCoursesList
            // 
            this.dataGridViewCoursesList.AllowUserToAddRows = false;
            this.dataGridViewCoursesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoursesList.Location = new System.Drawing.Point(13, 72);
            this.dataGridViewCoursesList.Name = "dataGridViewCoursesList";
            this.dataGridViewCoursesList.RowHeadersWidth = 51;
            this.dataGridViewCoursesList.RowTemplate.Height = 24;
            this.dataGridViewCoursesList.Size = new System.Drawing.Size(862, 409);
            this.dataGridViewCoursesList.TabIndex = 1;
            this.dataGridViewCoursesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoursesList_CellClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(946, 31);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsListToolStripMenuItem,
            this.coursesListToolStripMenuItem});
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
            this.coursesListToolStripMenuItem.Click += new System.EventHandler(this.coursesListToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Location = new System.Drawing.Point(0, 31);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(946, 57);
            this.btMainMenu.TabIndex = 40;
            this.btMainMenu.Text = "Main Menu";
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 667);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Course_FormClosing);
            this.Load += new System.EventHandler(this.Course_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoursesList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbCourseStatus;
        private System.Windows.Forms.Button btUpdateCourse;
        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCourseDescription;
        private System.Windows.Forms.TextBox tbCourseCode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDeleteByIDNumber;
        private System.Windows.Forms.DataGridView dataGridViewCoursesList;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btMainMenu;
    }
}