namespace Enrollment_System
{
    partial class Room
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
			this.btMainMenu = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnFind = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
			this.btClear = new System.Windows.Forms.Button();
			this.cbCapacity = new System.Windows.Forms.ComboBox();
			this.btUpdateCourse = new System.Windows.Forms.Button();
			this.tbSave = new System.Windows.Forms.Button();
			this.AddRoom = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbDetails = new System.Windows.Forms.TextBox();
			this.tbRoomName = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coursesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
			this.menuStrip1.SuspendLayout();
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
			this.btMainMenu.Size = new System.Drawing.Size(1003, 57);
			this.btMainMenu.TabIndex = 43;
			this.btMainMenu.Text = "Main Menu";
			this.btMainMenu.UseVisualStyleBackColor = false;
			this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 86);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(20);
			this.panel1.Size = new System.Drawing.Size(1003, 580);
			this.panel1.TabIndex = 41;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(20, 20);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(961, 538);
			this.tabControl1.TabIndex = 40;
			// 
			// tabPage1
			// 
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.tabPage1.Controls.Add(this.btnFind);
			this.tabPage1.Controls.Add(this.tbSearch);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.dataGridViewRoom);
			this.tabPage1.Controls.Add(this.btClear);
			this.tabPage1.Controls.Add(this.cbCapacity);
			this.tabPage1.Controls.Add(this.btUpdateCourse);
			this.tabPage1.Controls.Add(this.tbSave);
			this.tabPage1.Controls.Add(this.AddRoom);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.tbDetails);
			this.tabPage1.Controls.Add(this.tbRoomName);
			this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage1.Location = new System.Drawing.Point(4, 32);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(953, 502);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Room :";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.Azure;
			this.btnFind.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Location = new System.Drawing.Point(825, 18);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(110, 49);
			this.btnFind.TabIndex = 59;
			this.btnFind.Text = "FIND";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// tbSearch
			// 
			this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.Location = new System.Drawing.Point(337, 39);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(482, 28);
			this.tbSearch.TabIndex = 58;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Red;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(825, 368);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(110, 49);
			this.button3.TabIndex = 56;
			this.button3.Text = "DELETE";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataGridViewRoom
			// 
			this.dataGridViewRoom.AllowUserToAddRows = false;
			this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomName,
            this.Capacity,
            this.Details});
			this.dataGridViewRoom.Location = new System.Drawing.Point(337, 73);
			this.dataGridViewRoom.Name = "dataGridViewRoom";
			this.dataGridViewRoom.RowHeadersWidth = 51;
			this.dataGridViewRoom.RowTemplate.Height = 24;
			this.dataGridViewRoom.Size = new System.Drawing.Size(598, 283);
			this.dataGridViewRoom.TabIndex = 49;
			this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
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
			// cbCapacity
			// 
			this.cbCapacity.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbCapacity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCapacity.FormattingEnabled = true;
			this.cbCapacity.Items.AddRange(new object[] {
            "30",
            "40",
            "20"});
			this.cbCapacity.Location = new System.Drawing.Point(37, 226);
			this.cbCapacity.Name = "cbCapacity";
			this.cbCapacity.Size = new System.Drawing.Size(284, 29);
			this.cbCapacity.TabIndex = 48;
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
			this.btUpdateCourse.Text = "Update ";
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
			// AddRoom
			// 
			this.AddRoom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.AddRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddRoom.ForeColor = System.Drawing.Color.Blue;
			this.AddRoom.Location = new System.Drawing.Point(106, 365);
			this.AddRoom.Name = "AddRoom";
			this.AddRoom.Size = new System.Drawing.Size(138, 50);
			this.AddRoom.TabIndex = 45;
			this.AddRoom.Text = "+ Room";
			this.AddRoom.UseVisualStyleBackColor = false;
			this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(43, 195);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 19);
			this.label7.TabIndex = 44;
			this.label7.Text = "Capacity :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(43, 288);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 19);
			this.label6.TabIndex = 43;
			this.label6.Text = "Details :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(43, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 19);
			this.label5.TabIndex = 42;
			this.label5.Text = "Room Name :";
			// 
			// tbDetails
			// 
			this.tbDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDetails.Location = new System.Drawing.Point(37, 319);
			this.tbDetails.Name = "tbDetails";
			this.tbDetails.Size = new System.Drawing.Size(284, 30);
			this.tbDetails.TabIndex = 41;
			// 
			// tbRoomName
			// 
			this.tbRoomName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRoomName.Location = new System.Drawing.Point(37, 125);
			this.tbRoomName.Name = "tbRoomName";
			this.tbRoomName.Size = new System.Drawing.Size(284, 30);
			this.tbRoomName.TabIndex = 40;
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
			this.menuStrip1.Size = new System.Drawing.Size(1003, 31);
			this.menuStrip1.TabIndex = 42;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
			// 
			// maintenanceToolStripMenuItem
			// 
			this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
			this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
			this.maintenanceToolStripMenuItem.Text = "Maintenance";
			// 
			// RoomName
			// 
			this.RoomName.DataPropertyName = "RoomName";
			this.RoomName.HeaderText = "Room Name";
			this.RoomName.MinimumWidth = 6;
			this.RoomName.Name = "RoomName";
			this.RoomName.Width = 175;
			// 
			// Capacity
			// 
			this.Capacity.DataPropertyName = "Capacity";
			this.Capacity.HeaderText = "Capacity";
			this.Capacity.MinimumWidth = 6;
			this.Capacity.Name = "Capacity";
			this.Capacity.Width = 175;
			// 
			// Details
			// 
			this.Details.DataPropertyName = "Details";
			this.Details.HeaderText = "Details";
			this.Details.MinimumWidth = 6;
			this.Details.Name = "Details";
			this.Details.Width = 175;
			// 
			// Room
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1003, 666);
			this.Controls.Add(this.btMainMenu);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Room";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Room";
			this.Load += new System.EventHandler(this.Room_Load);
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox cbCapacity;
        private System.Windows.Forms.Button btUpdateCourse;
        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.TextBox tbRoomName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Details;
	}
}