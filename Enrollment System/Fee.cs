using Enrollment_System.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class Fee : Form
    {
        private readonly ErrorProvider errorProvider = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };
        public Fee()
        {
            InitializeComponent();
        }

        int FeeID { get; set; }   
        private void Fee_Load(object sender, EventArgs e)
        {
            CenterPanel();
            LoadData();
            getCourses();
            getSchoolYear();

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

            tbDescription.ReadOnly = true;
            tbAmount.ReadOnly = true;
            cbFeeType.Enabled = false;
            cbYearLevel.Enabled = false;
            cbCourseCode.Enabled = false;
            cbSchoolYear.Enabled = false;
            cbTerm.Enabled = false;
            cbSchoolYear.DropDownHeight = 150;
        }

        private void LoadData()
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("SELECT [FeeID]");
            stringBuilder.AppendLine("      ,[Description]");
            stringBuilder.AppendLine("      ,[Amount]");
            stringBuilder.AppendLine("      ,[FeeType]");
            stringBuilder.AppendLine("      ,[CourseCode]");
            stringBuilder.AppendLine("      ,[YearLevel]");
            stringBuilder.AppendLine("      ,[SchoolYear]");
            stringBuilder.AppendLine("      ,CASE WHEN [Term] = 1 THEN '1st Semester'");
            stringBuilder.AppendLine("			WHEN [Term] = 2 THEN '2nd Semester'");
            stringBuilder.AppendLine("			ELSE 'Summer'");
            stringBuilder.AppendLine("			END AS Term ");
            stringBuilder.AppendLine("  FROM [IT3232Javellana].[dbo].[Fee]");

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(stringBuilder.ToString(), connection);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridViewFeesList.DataSource = dataTable;
                dataGridViewFeesList.Columns["FeeID"].Visible = false;

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

        private void getCourses()
        {

            string connectionString = GlobalSetting.ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace "YourTableName" and "YourColumnName" with your actual table and column names
                string query = "SELECT CourseCode FROM [dbo].[Course]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items in the ComboBox
                        cbCourseCode.Items.Clear();

                        while (reader.Read())
                        {
                            // Add each item to the ComboBox
                            cbCourseCode.Items.Add(reader["CourseCode"].ToString());
                        }
                    }
                }
            }
        }

        private void getSchoolYear()
        {

            string connectionString = GlobalSetting.ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace "YourTableName" and "YourColumnName" with your actual table and column names
                string query = "SELECT SchoolYear FROM [dbo].[SchoolYear] ORDER BY SchoolYear DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items in the ComboBox
                        cbSchoolYear.Items.Clear();

                        while (reader.Read())
                        {
                            // Add each item to the ComboBox
                            cbSchoolYear.Items.Add(reader["SchoolYear"].ToString());
                        }
                    }
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

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            // Close the login form and open Form1
          this.Dispose();
        }

        private void ClearFields()
        {
            tbDescription.Text = "";
            tbDescription.Text = "";
            cbFeeType.Text = "";
            cbCourseCode.Text = "";
            cbSchoolYear.Text = "";
            cbTerm.Text = "";
            tbAmount.Text = "";
            cbYearLevel.Text = "";

        }

        private void DeleteFeeByFeeID(string paramSubjectID)
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("DELETE FROM [dbo].[Fee]  ");
            stringBuilder.AppendLine("WHERE FeeID = @FeeID");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@FeeID", paramSubjectID);
                    command.ExecuteNonQuery();
                }
            }



            LoadData();
        }



        private void DeleteRecord()
        {
            if (dataGridViewFeesList.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewFeesList.SelectedRows[0].Index;

                string ID = dataGridViewFeesList.Rows[selectedIndex].Cells["FeeID"].Value.ToString();

                DialogResult result = MessageBox.Show($"Do you want to delete?\n\n{ID}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    DeleteFeeByFeeID(ID);
                    MessageBox.Show("Record Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


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

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot character
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void cbYearLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot character
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the position to center the panel within the form
            int x = (ClientSize.Width - panel3.Width) / 2;
            int y = (ClientSize.Height - panel3.Height) / 2;

            // Set the panel's location
            panel3.Location = new System.Drawing.Point(x, y);
        }

        private void AddFee_Click_1(object sender, EventArgs e)
        {
            {
                tbDescription.ReadOnly = false;
                tbAmount.ReadOnly = false;
                cbFeeType.Enabled = true;
                cbYearLevel.Enabled = true;
                cbCourseCode.Enabled = true;
                cbSchoolYear.Enabled = true;
                cbTerm.Enabled = true;
            }
        }

        private void tbSave_Click_1(object sender, EventArgs e)
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("INSERT INTO [dbo].[Fee]");
            stringBuilder.AppendLine("           (");
            stringBuilder.AppendLine("           [Description]");
            stringBuilder.AppendLine("           ,[Amount]");
            stringBuilder.AppendLine("           ,[FeeType]");
            stringBuilder.AppendLine("           ,[CourseCode]");
            stringBuilder.AppendLine("           ,[YearLevel]");
            stringBuilder.AppendLine("           ,[SchoolYear]");
            stringBuilder.AppendLine("           ,[Term]");
            stringBuilder.AppendLine("           )");
            stringBuilder.AppendLine("     VALUES");
            stringBuilder.AppendLine("           (");
            stringBuilder.AppendLine("           @Description");
            stringBuilder.AppendLine("           ,@Amount");
            stringBuilder.AppendLine("           ,@FeeType");
            stringBuilder.AppendLine("           ,@CourseCode");
            stringBuilder.AppendLine("           ,@YearLevel");
            stringBuilder.AppendLine("           ,@SchoolYear");
            stringBuilder.AppendLine("           ,@Term");
            stringBuilder.AppendLine("           )");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Description", tbDescription.Text);
                    command.Parameters.AddWithValue("@Amount", tbAmount.Text);
                    command.Parameters.AddWithValue("@FeeType", cbFeeType.Text);
                    command.Parameters.AddWithValue("@CourseCode", cbCourseCode.Text);
                    command.Parameters.AddWithValue("@YearLevel", cbYearLevel.Text);
                    command.Parameters.AddWithValue("@SchoolYear", cbSchoolYear.Text);
                    command.Parameters.AddWithValue("@Term", cbTerm.Text);



                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btUpdateFee_Click_1(object sender, EventArgs e)
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("UPDATE [dbo].[Fee] SET ");
            stringBuilder.AppendLine("           [Description] = @Description");
            stringBuilder.AppendLine("           ,[Amount] = @Amount");
            stringBuilder.AppendLine("           ,[FeeType] = @FeeType");
            stringBuilder.AppendLine("           ,[CourseCode] = @CourseCode");
            stringBuilder.AppendLine("           ,[YearLevel] = @YearLevel");
            stringBuilder.AppendLine("           ,[SchoolYear] = @SchoolYear");
            stringBuilder.AppendLine("           ,[Term] = @Term");
            stringBuilder.AppendLine("WHERE FeeID = @FeeID");

            SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();


                    command.Parameters.AddWithValue("@Description", tbDescription.Text);
                    command.Parameters.AddWithValue("@Amount", tbAmount.Text);
                    command.Parameters.AddWithValue("@FeeType", cbFeeType.Text);
                    command.Parameters.AddWithValue("@CourseCode", cbCourseCode.Text);
                    command.Parameters.AddWithValue("@YearLevel", cbYearLevel.Text);
                    command.Parameters.AddWithValue("@SchoolYear", cbSchoolYear.Text);
                    if (cbTerm.Text == "1st Semester")
                    {
                        command.Parameters.AddWithValue("@Term", 1);
                    }
                    else if (cbTerm.Text == "2nd Semester")
                    {
                        command.Parameters.AddWithValue("@Term", 2);
                    }
                    else if (cbTerm.Text == "Summer")
                    {
                        command.Parameters.AddWithValue("@Term", 3);
                    }
                    command.Parameters.AddWithValue("@FeeID", FeeID);


                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();

            ClearFields();
        }

        private void dataGridViewFeesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridViewFeesList.Rows[e.RowIndex];
                FeeID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

                tbDescription.Text = selectedRow.Cells[1].Value.ToString();
                tbAmount.Text = selectedRow.Cells[2].Value.ToString();
                cbFeeType.Text = selectedRow.Cells[3].Value.ToString();
                cbCourseCode.Text = selectedRow.Cells[4].Value.ToString();
                cbYearLevel.Text = selectedRow.Cells[5].Value.ToString();
                cbSchoolYear.Text = selectedRow.Cells[6].Value.ToString();
                cbTerm.Text = selectedRow.Cells[7].Value.ToString();
            }
            catch
            {

            }
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
                    DataTable schemaTable = connection.GetSchema("Columns", new[] { null, null, "Fee", null });

                    // Constructing the dynamic SQL query
                    command.CommandText = $"SELECT * FROM [dbo].[Fee] WHERE ";

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
                    dataGridViewFeesList.DataSource = searchResults;
                }


            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            LoadData();
        }
    }
}
