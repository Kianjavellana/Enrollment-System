namespace Enrollment_System
{
    partial class Section
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section));
			this.btMainMenu = new System.Windows.Forms.Button();
			this.coursesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btClear = new System.Windows.Forms.Button();
			this.cbCourseCode = new System.Windows.Forms.ComboBox();
			this.btUpdateCourse = new System.Windows.Forms.Button();
			this.tbSave = new System.Windows.Forms.Button();
			this.AddSection = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbSectionName = new System.Windows.Forms.TextBox();
			this.studentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridViewSection = new System.Windows.Forms.DataGridView();
			this.SectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSection)).BeginInit();
			this.SuspendLayout();
			// 
			// btMainMenu
			// 
			this.btMainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.btMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMainMenu.Location = new System.Drawing.Point(0, 31);
			this.btMainMenu.Name = "btMainMenu";
			this.btMainMenu.Size = new System.Drawing.Size(955, 57);
			this.btMainMenu.TabIndex = 43;
			this.btMainMenu.Text = "Main Menu";
			this.btMainMenu.UseVisualStyleBackColor = false;
			this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
			// 
			// coursesListToolStripMenuItem
			// 
			this.coursesListToolStripMenuItem.Name = "coursesListToolStripMenuItem";
			this.coursesListToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
			this.coursesListToolStripMenuItem.Text = "Courses List";
			// 
			// tabPage1
			// 
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.tabPage1.Controls.Add(this.dataGridViewSection);
			this.tabPage1.Controls.Add(this.btnDelete);
			this.tabPage1.Controls.Add(this.btnFind);
			this.tabPage1.Controls.Add(this.tbSearch);
			this.tabPage1.Controls.Add(this.btClear);
			this.tabPage1.Controls.Add(this.cbCourseCode);
			this.tabPage1.Controls.Add(this.btUpdateCourse);
			this.tabPage1.Controls.Add(this.tbSave);
			this.tabPage1.Controls.Add(this.AddSection);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.tbSectionName);
			this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage1.Location = new System.Drawing.Point(4, 32);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage1.Size = new System.Drawing.Size(905, 517);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Section :";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Red;
			this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(780, 380);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(110, 49);
			this.btnDelete.TabIndex = 63;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.Azure;
			this.btnFind.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Location = new System.Drawing.Point(780, 15);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(110, 49);
			this.btnFind.TabIndex = 62;
			this.btnFind.Text = "FIND";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// tbSearch
			// 
			this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.Location = new System.Drawing.Point(292, 36);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(482, 28);
			this.tbSearch.TabIndex = 61;
			// 
			// btClear
			// 
			this.btClear.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btClear.ForeColor = System.Drawing.Color.Black;
			this.btClear.Location = new System.Drawing.Point(619, 379);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(146, 50);
			this.btClear.TabIndex = 41;
			this.btClear.Text = "Clear Fields :";
			this.btClear.UseVisualStyleBackColor = false;
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// cbCourseCode
			// 
			this.cbCourseCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbCourseCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCourseCode.FormattingEnabled = true;
			this.cbCourseCode.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
			this.cbCourseCode.Location = new System.Drawing.Point(19, 136);
			this.cbCourseCode.Name = "cbCourseCode";
			this.cbCourseCode.Size = new System.Drawing.Size(267, 29);
			this.cbCourseCode.TabIndex = 48;
			// 
			// btUpdateCourse
			// 
			this.btUpdateCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btUpdateCourse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btUpdateCourse.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btUpdateCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btUpdateCourse.Location = new System.Drawing.Point(444, 379);
			this.btUpdateCourse.Name = "btUpdateCourse";
			this.btUpdateCourse.Size = new System.Drawing.Size(141, 50);
			this.btUpdateCourse.TabIndex = 47;
			this.btUpdateCourse.Text = "Update";
			this.btUpdateCourse.UseVisualStyleBackColor = false;
			this.btUpdateCourse.Click += new System.EventHandler(this.btUpdateCourse_Click);
			// 
			// tbSave
			// 
			this.tbSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.tbSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.tbSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSave.ForeColor = System.Drawing.Color.Green;
			this.tbSave.Location = new System.Drawing.Point(255, 377);
			this.tbSave.Name = "tbSave";
			this.tbSave.Size = new System.Drawing.Size(143, 50);
			this.tbSave.TabIndex = 46;
			this.tbSave.Text = "Save";
			this.tbSave.UseVisualStyleBackColor = false;
			this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
			// 
			// AddSection
			// 
			this.AddSection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddSection.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.AddSection.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddSection.ForeColor = System.Drawing.Color.Blue;
			this.AddSection.Location = new System.Drawing.Point(72, 377);
			this.AddSection.Name = "AddSection";
			this.AddSection.Size = new System.Drawing.Size(138, 50);
			this.AddSection.TabIndex = 45;
			this.AddSection.Text = "+ Section";
			this.AddSection.UseVisualStyleBackColor = false;
			this.AddSection.Click += new System.EventHandler(this.AddSection_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(25, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 19);
			this.label7.TabIndex = 44;
			this.label7.Text = "Course Code:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 19);
			this.label6.TabIndex = 43;
			this.label6.Text = "Section Name :";
			// 
			// tbSectionName
			// 
			this.tbSectionName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSectionName.Location = new System.Drawing.Point(19, 216);
			this.tbSectionName.Name = "tbSectionName";
			this.tbSectionName.Size = new System.Drawing.Size(267, 30);
			this.tbSectionName.TabIndex = 41;
			// 
			// studentsListToolStripMenuItem
			// 
			this.studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
			this.studentsListToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
			this.studentsListToolStripMenuItem.Text = "Students List";
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
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
			this.fileToolStripMenuItem.Text = "File";
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
			this.menuStrip1.Size = new System.Drawing.Size(955, 31);
			this.menuStrip1.TabIndex = 42;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// maintenanceToolStripMenuItem
			// 
			this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
			this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
			this.maintenanceToolStripMenuItem.Text = "Maintenance";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(20, 20);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(913, 553);
			this.tabControl1.TabIndex = 40;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 87);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
			this.panel1.Size = new System.Drawing.Size(955, 595);
			this.panel1.TabIndex = 41;
			// 
			// dataGridViewSection
			// 
			this.dataGridViewSection.AllowUserToAddRows = false;
			this.dataGridViewSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectionName,
            this.CourseCode});
			this.dataGridViewSection.Location = new System.Drawing.Point(309, 76);
			this.dataGridViewSection.Margin = new System.Windows.Forms.Padding(20);
			this.dataGridViewSection.Name = "dataGridViewSection";
			this.dataGridViewSection.RowHeadersWidth = 51;
			this.dataGridViewSection.RowTemplate.Height = 24;
			this.dataGridViewSection.Size = new System.Drawing.Size(576, 287);
			this.dataGridViewSection.TabIndex = 64;
			// 
			// SectionName
			// 
			this.SectionName.DataPropertyName = "SectionName";
			this.SectionName.HeaderText = "Section Name";
			this.SectionName.MinimumWidth = 6;
			this.SectionName.Name = "SectionName";
			this.SectionName.Width = 170;
			// 
			// CourseCode
			// 
			this.CourseCode.DataPropertyName = "CourseCode";
			this.CourseCode.HeaderText = "CourseCode";
			this.CourseCode.MinimumWidth = 6;
			this.CourseCode.Name = "CourseCode";
			this.CourseCode.Width = 170;
			// 
			// Section
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 682);
			this.Controls.Add(this.btMainMenu);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Section";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Section";
			this.Load += new System.EventHandler(this.Section_Load);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSection)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.ToolStripMenuItem coursesListToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox cbCourseCode;
        private System.Windows.Forms.Button btUpdateCourse;
        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.Button AddSection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSectionName;
        private System.Windows.Forms.ToolStripMenuItem studentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnDelete;
		public System.Windows.Forms.DataGridView dataGridViewSection;
		private System.Windows.Forms.DataGridViewTextBoxColumn SectionName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CourseCode;
	}
}