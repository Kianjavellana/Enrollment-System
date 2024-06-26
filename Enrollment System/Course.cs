﻿using Enrollment_System.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class Course : Form
    {
        private readonly ErrorProvider errorProvider = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };
        public Course()
        {
            InitializeComponent();
        }
        int RecNumber { get; set; }
        private void Course_Load(object sender, EventArgs e)
        {
            CenterPanel();

            LoadData();

            // Get the size of the screen
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Get the size of the form
            int formWidth = this.Width;
            int formHeight = this.Height;

            // Calculate the position of the form
            int formX = (screenWidth - formWidth) / 2;
            int formY = (screenHeight - formHeight) / 2;

            // Set the position of the form
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(formX, formY);

            // Read-Only Code
            tbCourseCode.ReadOnly = true;
            cbCourseStatus.Enabled = false;
            tbCourseDescription.ReadOnly = true;
        }
        private void LoadData()
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("SELECT [RecordNumber]");
            stringBuilder.AppendLine("      ,[CourseCode]");
            stringBuilder.AppendLine("      ,[CourseDescription]");
            stringBuilder.AppendLine("      ,CASE WHEN [CourseStatus] = 1 THEN 'Active'");
            stringBuilder.AppendLine("			WHEN [CourseStatus] = 0 THEN 'Inactive'");
            stringBuilder.AppendLine("			END AS CourseStatus");
            stringBuilder.AppendLine("  FROM [IT3232Javellana].[dbo].[Course]");

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(stringBuilder.ToString(), connection);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridViewCoursesList.DataSource = dataTable;
                dataGridViewCoursesList.Columns["RecordNumber"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void CenterPanel()
        {
            // Calculate the position to center the panel within the form
            int x = (ClientSize.Width - panel1.Width) / 2;
            int y = (ClientSize.Height - panel1.Height) / 2;

            // Set the panel's location
            panel1.Location = new System.Drawing.Point(x, y);
        }

        private void coursesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the login form and open Form1
            this.Hide();
            Course course = new Course();
            course.Show();
        }

        private void ClearFields()
        {
            tbCourseCode.Text = "";
            cbCourseStatus.Text = "";
            tbCourseDescription.Text = "";
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("INSERT INTO [dbo].[Course]");
            stringBuilder.AppendLine("           (");
            stringBuilder.AppendLine("           [CourseCode]");
            stringBuilder.AppendLine("           ,[CourseDescription]");
            stringBuilder.AppendLine("           ,[CourseStatus]");
            stringBuilder.AppendLine("           )");
            stringBuilder.AppendLine("     VALUES");
            stringBuilder.AppendLine("           (");
            stringBuilder.AppendLine("           @CourseCode");
            stringBuilder.AppendLine("           ,@CourseDescription");
            stringBuilder.AppendLine("           ,@CourseStatus");
            stringBuilder.AppendLine("           )");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@CourseCode", tbCourseCode.Text);
                    command.Parameters.AddWithValue("@CourseDescription", tbCourseDescription.Text);
                   

                    if (cbCourseStatus.Text == "Active")
                    {
                        command.Parameters.AddWithValue("@CourseStatus", 1);
                    }
                    else if (cbCourseStatus.Text == "Inactive")
                    {
                        command.Parameters.AddWithValue("@CourseStatus", 0);
                    }

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            LoadData();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            {
                tbCourseCode.ReadOnly = false;
                cbCourseStatus.Enabled = true;
                tbCourseDescription.ReadOnly = false;
            }
        }

        private void DeleteRecord()
        {
            if (dataGridViewCoursesList.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewCoursesList.SelectedRows[0].Index;

                string ID = dataGridViewCoursesList.Rows[selectedIndex].Cells["CourseCode"].Value.ToString();


                DialogResult result = MessageBox.Show($"Do you want to delete?\n\n{ID}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {

                    DeleteCourseByCourseCode(ID);
                    MessageBox.Show("Record Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void DeleteCourseByCourseCode(string paramCourseCode)
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("DELETE FROM [Course]"); // Replace [your_course_table_name] with the actual name of your course table
            stringBuilder.AppendLine("WHERE RecordNumber = @ReocordNumber");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@CourseCode", paramCourseCode);
                    command.ExecuteNonQuery();
                }
            }
            LoadData();
        }
        private void btUpdateCourse_Click(object sender, EventArgs e)
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("UPDATE [dbo].[Course] SET ");
            stringBuilder.AppendLine("           [CourseCode] = @CourseCode");
            stringBuilder.AppendLine("           ,[CourseDescription] = @CourseDescription");
            stringBuilder.AppendLine("           ,[CourseStatus] = @CourseStatus");
            stringBuilder.AppendLine("WHERE RecordNumber = @RecordNumber");

            SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@CourseCode", tbCourseCode.Text);
                    command.Parameters.AddWithValue("@CourseDescription", tbCourseDescription.Text);
                    if (cbCourseStatus.Text == "Active")
                    {
                        command.Parameters.AddWithValue("@CourseStatus", 1);
                    }
                    else if (cbCourseStatus.Text == "Inactive")
                    {
                        command.Parameters.AddWithValue("@CourseStatus", 0);
                    }
                    command.Parameters.AddWithValue("@RecordNumber", RecNumber);

                    command.ExecuteNonQuery();
                }


            }

            MessageBox.Show("Record Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();

            ClearFields();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = tbSearch.Text;

            using (SqlConnection connection = new SqlConnection(GlobalSetting.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Get column names
                    DataTable schemaTable = connection.GetSchema("Columns", new[] { null, null, "Student", null });

                    // Constructing the dynamic SQL query
                    command.CommandText = $"SELECT * FROM [stud].[Student] WHERE ";

                    foreach (DataRow row in schemaTable.Rows)
                    {
                        string columnName = (string)row["COLUMN_NAME"];

                        // Append each column to the WHERE clause
                        command.CommandText += $"{columnName} LIKE @{columnName} OR ";

                        // Add parameter for the current column
                        command.Parameters.AddWithValue($"@{columnName}", $"%{searchKeyword}%");
                    }

                    // Remove the last 'OR' from the WHERE clause
                    command.CommandText = command.CommandText.TrimEnd(' ', 'O', 'R');

                    // Create a DataTable to store the search results
                    DataTable searchResults = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Fill the DataTable with the search results
                        adapter.Fill(searchResults);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridViewCoursesList.DataSource = searchResults;
                }


            }
        }

        private void dataGridViewCoursesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridViewCoursesList.Rows[e.RowIndex];

                RecNumber = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                tbCourseCode.Text = selectedRow.Cells[1].Value.ToString();
                tbCourseDescription.Text = selectedRow.Cells[2].Value.ToString();
                cbCourseStatus.Text = selectedRow.Cells[3].Value.ToString();

            }
            catch
            {

            }
        }

        private void Course_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btDeleteByIDNumber_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            LoadData();
        }
        private bool ValidateAllControls(Control container)
        {
            return container.Controls.OfType<TextBox>().All(control => ValidateControl(control)) &&
                   container.Controls.OfType<ComboBox>().All(control => ValidateControl(control));
        }

        private bool ValidateControl(Control control)
        {
            if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                DisplayValidationError(textBox, "Field is required.");
                return false;
            }

            if (control is ComboBox comboBox && comboBox.SelectedItem == null)
            {
                DisplayValidationError(comboBox, "Please select an option.");
                return false;
            }

            return true;
        }

        private void DisplayValidationError(Control control, string errorMessage)
        {
            errorProvider.SetError(control, errorMessage);
        }

    }
}
