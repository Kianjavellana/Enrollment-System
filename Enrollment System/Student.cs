using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Enrollment_System.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class Student : Form
    {
        private readonly ErrorProvider errorProvider = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };

        string FormState = "";

        private byte[] imageData;
        private bool ValidateControl(Control control)
        {
            if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                DisplayValidationError(textBox, "Field is required.");
                return false;
            }

            if (control is System.Windows.Forms.ComboBox comboBox && comboBox.SelectedItem == null)
            {
                DisplayValidationError(comboBox, "Please select an option.");
                return false;
            }

            return true;
        }

        private bool ValidateAllControls(Control container)
        {
            return container.Controls.OfType<TextBox>().All(control => ValidateControl(control)) &&
                   container.Controls.OfType<System.Windows.Forms.ComboBox>().All(control => ValidateControl(control));
        }
        private void DisplayValidationError(Control control, string errorMessage)
        {
            errorProvider.SetError(control, errorMessage);
        }
        public Student()
        {
            InitializeComponent();
        }
        private void CenterPanel()
        {
            // Calculate the position to center the panel within the form
            int x = (ClientSize.Width - panel2.Width) / 2;
            int y = (ClientSize.Height - panel2.Height) / 2;

            // Set the panel's location
            panel2.Location = new System.Drawing.Point(x, y);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            DefaultReadOnlyFields();
            LoadData();
            CenterPanel();
            getCourses();
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
            tbStudentID.ReadOnly = true;
            tbLastName.ReadOnly = true;
            tbFirstName.ReadOnly = true;
            tbMiddleName.ReadOnly = true;
            cbCourseCode.Enabled = false; // Use Enabled property instead of ReadOnly
            cbYearLevel.Enabled = false;  // Use Enabled property instead of ReadOnly
            cbStudentStatus.Enabled = false;     // Use Enabled property instead of ReadOnly
            cbGender.Enabled = false;     // Use Enabled property instead of ReadOnly
            dtpBirthDate.Enabled = false; // DateTimePicker doesn't have ReadOnly property, use Enabled instead
            tbAddress.ReadOnly = true;
            tbContactNumber.ReadOnly = true;
            tbEmailAddress.ReadOnly = true;

        }

        private void DefaultReadOnlyFields()
        {
            btsaveStudent.Enabled = true;
            btnModify.Enabled = true;

            tbStudentID.ReadOnly = true;
            cbCourseCode.Enabled = false;
            cbYearLevel.Enabled = false;
            cbStudentStatus.Enabled = false;
            tbLastName.ReadOnly = true;
            tbFirstName.ReadOnly = true;
            tbMiddleName.ReadOnly = true;
            cbGender.Enabled = false;
            dtpBirthDate.Enabled = false;
            tbAddress.ReadOnly = true;
            tbContactNumber.ReadOnly = true;
            tbEmailAddress.ReadOnly = true;
        }
        private void LoadData()
        {
            string connectionString = GlobalSetting.ConnectionString;

			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("SELECT s.StudentID AS [StudentID]");
			stringBuilder.AppendLine("      ,s.LastName AS [LastName]");
			stringBuilder.AppendLine("      ,s.FirstName AS [FirstName]");
			stringBuilder.AppendLine("      ,s.MiddleName AS [MiddleName]");
			stringBuilder.AppendLine("      ,s.StudentCourse AS [StudentCourse]");
			stringBuilder.AppendLine("      ,s.YearLevel AS [YearLevel]");
			stringBuilder.AppendLine("      ,s.StudentStatus AS [StudentStatus]");
			stringBuilder.AppendLine("      ,s.Gender AS [Gender]");
			stringBuilder.AppendLine("      ,s.BirthDate AS [Birthdate]");
			stringBuilder.AppendLine("      ,s.Address AS [Address]");
			stringBuilder.AppendLine("      ,s.ContactNumber AS [ContactNumber]");
			stringBuilder.AppendLine("      ,s.EmailAddress AS [EmailAddress]");
			stringBuilder.AppendLine("      ,si.StudentPicture AS [StudentPicture]");
			stringBuilder.AppendLine("  FROM [IT3232Javellana].[stud].[Student] s");
			stringBuilder.AppendLine("  LEFT JOIN [IT3232Javellana].[dbo].[StudentImage] si ON s.StudentID = si.StudentID");

			SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(stringBuilder.ToString(), connection);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridViewStudentsList.DataSource = dataTable;
				gridControl1.DataSource = dataTable;
				gridControl1.ForceInitialize();
				gridView1.ExpandAllGroups();


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
        private void ClearFields()
        {
            tbStudentID.ReadOnly = false;

            tbStudentID.Text = "";
            tbLastName.Text = "";
            tbFirstName.Text = "";
            tbMiddleName.Text = "";
            cbCourseCode.Text = "";
            cbYearLevel.Text = "";
            cbStudentStatus.Text = "";
            cbGender.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            tbAddress.Text = "";
            tbContactNumber.Text = "";
            tbEmailAddress.Text = "";

        }

        private void studentsListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOfferedSub_Click(object sender, EventArgs e)
        {
            OfferedSubject offeredSubject = new OfferedSubject();
            offeredSubject.ShowDialog();
        }

        private void btClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            {
                tbStudentID.ReadOnly = false;
                tbLastName.ReadOnly = false;
                tbFirstName.ReadOnly = false;
                tbMiddleName.ReadOnly = false;
                cbCourseCode.Enabled = true; // Use Enabled property instead of ReadOnly
                cbYearLevel.Enabled = true;  // Use Enabled property instead of ReadOnly
                cbStudentStatus.Enabled = true;     // Use Enabled property instead of ReadOnly
                cbGender.Enabled = true;     // Use Enabled property instead of ReadOnly
                dtpBirthDate.Enabled = true; // DateTimePicker doesn't have ReadOnly property, use Enabled instead
                tbAddress.ReadOnly = false;
                tbContactNumber.ReadOnly = false;
                tbEmailAddress.ReadOnly = false;

                FormState = "Add";
            }
        }

   
        private void UpdateButton()
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("UPDATE [stud].[Student] SET ");
            stringBuilder.AppendLine("           [LastName] = @LastName");
            stringBuilder.AppendLine("           ,[FirstName] = @FirstName");
            stringBuilder.AppendLine("           ,[MiddleName] = @MiddleName");
            stringBuilder.AppendLine("           ,[StudentCourse] = @StudentCourse");
            stringBuilder.AppendLine("           ,[YearLevel] = @YearLevel");
            stringBuilder.AppendLine("           ,[StudentStatus] = @StudentStatus");
            stringBuilder.AppendLine("           ,[Gender] = @Gender");
            stringBuilder.AppendLine("           ,[Birthdate] = @Birthdate");
            stringBuilder.AppendLine("           ,[Address] = @Address");
            stringBuilder.AppendLine("           ,[ContactNumber] = @ContactNumber");
            stringBuilder.AppendLine("           ,[EmailAddress] = @EmailAddress");
            stringBuilder.AppendLine("WHERE StudentID = @StudentID");

            SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@LastName", tbLastName.Text);
                    command.Parameters.AddWithValue("@FirstName", tbFirstName.Text);
                    command.Parameters.AddWithValue("@MiddleName", tbMiddleName.Text);
                    command.Parameters.AddWithValue("@StudentCourse", cbCourseCode.Text);
                    command.Parameters.AddWithValue("@YearLevel", cbYearLevel.Text);
                    command.Parameters.AddWithValue("@StudentStatus", cbStudentStatus.Text);
                    command.Parameters.AddWithValue("@Gender", cbGender.Text);
                    command.Parameters.AddWithValue("@Birthdate", dtpBirthDate.Value);
                    command.Parameters.AddWithValue("@Address", tbAddress.Text);
                    command.Parameters.AddWithValue("@ContactNumber", tbContactNumber.Text);
                    command.Parameters.AddWithValue("@EmailAddress", tbEmailAddress.Text);
                    command.Parameters.AddWithValue("@StudentID", tbStudentID.Text);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void SaveStudent()
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("INSERT INTO [stud].[Student]");
            stringBuilder.AppendLine("           (");
            stringBuilder.AppendLine("           [StudentID]");
            stringBuilder.AppendLine("           ,[LastName]");
            stringBuilder.AppendLine("           ,[FirstName]");
            stringBuilder.AppendLine("           ,[MiddleName]");
            stringBuilder.AppendLine("           ,[StudentCourse]");
            stringBuilder.AppendLine("           ,[YearLevel]");
            stringBuilder.AppendLine("           ,[StudentStatus]");
            stringBuilder.AppendLine("           ,[Gender]");
            stringBuilder.AppendLine("           ,[Birthdate]");
            stringBuilder.AppendLine("           ,[Address]");
            stringBuilder.AppendLine("           ,[ContactNumber]");
            stringBuilder.AppendLine("           ,[EmailAddress]");
            stringBuilder.AppendLine("           )");
            stringBuilder.AppendLine("     VALUES");
            stringBuilder.AppendLine("           (");
            stringBuilder.AppendLine("           @StudentID");
            stringBuilder.AppendLine("           ,@LastName");
            stringBuilder.AppendLine("           ,@FirstName");
            stringBuilder.AppendLine("           ,@MiddleName");
            stringBuilder.AppendLine("           ,@StudentCourse");
            stringBuilder.AppendLine("           ,@YearLevel");
            stringBuilder.AppendLine("           ,@StudentStatus");
            stringBuilder.AppendLine("           ,@Gender");
            stringBuilder.AppendLine("           ,@Birthdate");
            stringBuilder.AppendLine("           ,@Address");
            stringBuilder.AppendLine("           ,@ContactNumber");
            stringBuilder.AppendLine("           ,@EmailAddress");
            stringBuilder.AppendLine("           )");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@StudentID", tbStudentID.Text);
                    command.Parameters.AddWithValue("@LastName", tbLastName.Text);
                    command.Parameters.AddWithValue("@FirstName", tbFirstName.Text);
                    command.Parameters.AddWithValue("@MiddleName", tbMiddleName.Text);
                    command.Parameters.AddWithValue("@StudentCourse", cbCourseCode.Text);
                    command.Parameters.AddWithValue("@YearLevel", cbYearLevel.Text);
                    command.Parameters.AddWithValue("@StudentStatus", cbStudentStatus.Text);
                    command.Parameters.AddWithValue("@Gender", cbGender.Text);
                    command.Parameters.AddWithValue("@Birthdate", dtpBirthDate.Value);
                    command.Parameters.AddWithValue("@Address", tbAddress.Text);
                    command.Parameters.AddWithValue("@ContactNumber", tbContactNumber.Text);
                    command.Parameters.AddWithValue("@EmailAddress", tbEmailAddress.Text);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void dataGridViewStudentsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridViewStudentsList.Rows[e.RowIndex];

                tbStudentID.Text = selectedRow.Cells[0].Value.ToString();
                tbLastName.Text = selectedRow.Cells[1].Value.ToString();
                tbFirstName.Text = selectedRow.Cells[2].Value.ToString();
                tbMiddleName.Text = selectedRow.Cells[3].Value.ToString();
                cbCourseCode.Text = selectedRow.Cells[4].Value.ToString();
                cbYearLevel.Text = selectedRow.Cells[5].Value.ToString();
                cbStudentStatus.Text = selectedRow.Cells[6].Value.ToString();
                cbGender.Text = selectedRow.Cells[7].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(selectedRow.Cells[8].Value);
                tbAddress.Text = selectedRow.Cells[9].Value.ToString();
                tbContactNumber.Text = selectedRow.Cells[10].Value.ToString();
                tbEmailAddress.Text = selectedRow.Cells[11].Value.ToString();

                tbStudentID.ReadOnly = true;

                if (tbStudentID.Text != "")
                {
                    btnModify.Enabled = true;
                }
                RetrieveImage(tbStudentID.Text);

            }
            catch
            {

            }
        }
        private void SearchStudent()
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
                    dataGridViewStudentsList.DataSource = searchResults;
                }


            }
        }
        private void DeleteStudentByIDNumber(string paramStudentID)
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("DELETE FROM [stud].[Student]  ");
            stringBuilder.AppendLine("WHERE StudentID = @StudentID");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@StudentID", paramStudentID);
                    command.ExecuteNonQuery();
                }
            }



            LoadData();
        }


        private void DeleteRecord()
        {
			// Assuming gridView1 is the main view of your GridControl
			GridView gridView = gridControl1.MainView as GridView;

			if (gridView != null && gridView.SelectedRowsCount > 0)
			{
				// Get the handle of the selected row
				int selectedRowHandle = gridView.GetSelectedRows()[0];

				// Get the value of the "StudentID" column
				string ID = gridView.GetRowCellValue(selectedRowHandle, "StudentID").ToString();

				DialogResult result = XtraMessageBox.Show($"Do you want to delete?\n\nID: {ID}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

				if (result == DialogResult.Yes)
				{
					// Assuming DeleteStudentByIDNumber is a method that deletes the record from the database
					DeleteStudentByIDNumber(ID);

					// Delete the row from the GridView
					gridView.DeleteRow(selectedRowHandle);

					XtraMessageBox.Show("Record Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				XtraMessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void btDeleteByIDNumber_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            LoadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SearchStudent();
        }

        private void tbContactNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Allow only one dot character
            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') > -1)
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

        private void btnGetPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (.jpg, *.jpeg, *.png)|.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picBoxStudentImage.Image = Image.FromFile(openFileDialog.FileName);
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picBoxStudentImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // You can use other image formats
                            imageData = ms.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void SaveStudentImage(string idnum)
        {
            if (imageData != null)
            {
                try
                {
                    StringBuilder queryBuilder = new StringBuilder();
                    queryBuilder.Append("DELETE FROM [dbo].[StudentImage] WHERE StudentID = @StudentID; ");
                    queryBuilder.Append("INSERT INTO [dbo].[StudentImage] (StudentID, StudentPicture) ");
                    queryBuilder.Append("VALUES (@StudentID, @StudentPicture)");

                    using (SqlConnection connection = new SqlConnection(GlobalSetting.ConnectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection);
                        command.Parameters.AddWithValue("@StudentID", idnum);
                        command.Parameters.AddWithValue("@StudentPicture", imageData);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Image saved successfully to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an image to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearFields();
        }

        private void RetrieveImage(string idNum)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalSetting.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT StudentPicture FROM [dbo].[StudentImage] WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", idNum);
                    byte[] imageData = (byte[])command.ExecuteScalar();

                    if (imageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            picBoxStudentImage.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picBoxStudentImage.Image = null;
                        MessageBox.Show("No image found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving image from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btsaveStudent_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (FormState == "Add")
            {
                if (!ValidateAllControls(panel2))
                {
                    MessageBox.Show("Validation failed. Please correct the errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SaveStudent();
                    //ADS

                    MessageBox.Show("Record Added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    SaveStudentImage(tbStudentID.Text);
                    ClearFields();
                    DefaultReadOnlyFields();
                   
                }
            }
            else if (FormState == "Update")
            {

                UpdateButton();



                LoadData();
                SaveStudentImage(tbStudentID.Text);
                ClearFields();
                DefaultReadOnlyFields();

                

            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormState = "Update";
        }

		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			if (e.RowHandle >= 0)
			{
				// Retrieve data from the selected row
				DataRow selectedRow = gridView1.GetDataRow(e.RowHandle);
				if (selectedRow != null)
				{

					tbStudentID.Text = selectedRow["StudentID"].ToString();
					tbLastName.Text = selectedRow["LastName"].ToString();
					tbFirstName.Text = selectedRow["FirstName"].ToString();
					tbMiddleName.Text = selectedRow["MiddleName"].ToString();
					cbCourseCode.Text = selectedRow["StudentCourse"].ToString();
					cbYearLevel.Text = selectedRow["YearLevel"].ToString();
					cbStudentStatus.Text = selectedRow["StudentStatus"].ToString();
					cbGender.Text = selectedRow["Gender"].ToString();
					dtpBirthDate.Value = Convert.ToDateTime(selectedRow["Birthdate"].ToString());
					tbAddress.Text = selectedRow["Address"].ToString();
					tbContactNumber.Text = selectedRow["ContactNumber"].ToString();
					tbEmailAddress.Text = selectedRow["EmailAddress"].ToString();

					tbStudentID.ReadOnly = true;

					if (tbStudentID.Text != "")
					{
						btnModify.Enabled = true;
					}
					RetrieveImage(tbStudentID.Text);

				}
			}
		}

		private void btDeleteByIDNumber_Click_1(object sender, EventArgs e)
		{
			DeleteRecord();
			LoadData();
		}
	}
}
