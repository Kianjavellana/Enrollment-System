using Enrollment_System.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        int RoomID { get;set; }

        private void Room_Load(object sender, EventArgs e)
        {
            LoadData();

            tbRoomName.ReadOnly = true;
            cbCapacity.Enabled = false;
            tbDetails.ReadOnly = true;

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

        }

        private void LoadData()
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("SELECT [RoomID]");
            stringBuilder.AppendLine("      ,[RoomName]");
            stringBuilder.AppendLine("      ,[Capacity]");
            stringBuilder.AppendLine("      ,[Details]");
            stringBuilder.AppendLine("  FROM [IT3232Javellana].[dbo].[Room]");

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(stringBuilder.ToString(), connection);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridViewRoom.DataSource = dataTable;
                dataGridViewRoom.Columns["RoomID"].Visible = false;

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

        private void ClearFields()
        {
            tbRoomName.Text = "";
            cbCapacity.Text = "";
            tbDetails.Text = "";
        }

        private void SaveRoom()
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("INSERT INTO [dbo].[Room]");
            stringBuilder.AppendLine("           (");
            stringBuilder.AppendLine("           [RoomName]");
            stringBuilder.AppendLine("           ,[Capacity]");
            stringBuilder.AppendLine("           ,[Details]");
            stringBuilder.AppendLine("           )");
            stringBuilder.AppendLine("     VALUES");
            stringBuilder.AppendLine("           (");
            stringBuilder.AppendLine("           @RoomName");
            stringBuilder.AppendLine("           ,@Capacity");
            stringBuilder.AppendLine("           ,@Details");
            stringBuilder.AppendLine("           )");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@RoomName", tbRoomName.Text);
                    command.Parameters.AddWithValue("@Capacity", cbCapacity.Text);
                    command.Parameters.AddWithValue("@Details", tbDetails.Text);



                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            ClearFields();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            tbRoomName.ReadOnly = false;
            cbCapacity.Enabled = true;
            tbDetails.ReadOnly = false;
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            SaveRoom();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UpdateRoom()
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("UPDATE [dbo].[Room] SET ");
            stringBuilder.AppendLine("           [RoomName] = @RoomName");
            stringBuilder.AppendLine("           ,[Capacity] = @Capacity");
            stringBuilder.AppendLine("           ,[Details] = @Details");
            stringBuilder.AppendLine("WHERE RoomID = @RoomID");

            SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@RoomName", tbRoomName.Text);
                    command.Parameters.AddWithValue("@Capacity", cbCapacity.Text);
                    command.Parameters.AddWithValue("@Details", tbDetails.Text);
                    command.Parameters.AddWithValue("@RoomID", RoomID);


                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            ClearFields();
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridViewRoom.Rows[e.RowIndex];

                RoomID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                tbRoomName.Text = selectedRow.Cells[1].Value.ToString();
                cbCapacity.Text = selectedRow.Cells[2].Value.ToString();
                tbDetails.Text = selectedRow.Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btUpdateCourse_Click(object sender, EventArgs e)
        {
            UpdateRoom();
        }
        private void DeleteRecord()
        {
            if (dataGridViewRoom.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewRoom.SelectedRows[0].Index;

                string ID = dataGridViewRoom.Rows[selectedIndex].Cells["RoomID"].Value.ToString();


                DialogResult result = MessageBox.Show($"Do you want to delete?\n\n{ID}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {

                    DeleteSectionByIDNumber(ID);
                    MessageBox.Show("Record Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            ClearFields();
        }

        private void DeleteSectionByIDNumber(string paramSectionID)
        {
            string connectionString = GlobalSetting.ConnectionString;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("DELETE FROM [dbo].[Room]  ");
            stringBuilder.AppendLine("WHERE RoomID = @RoomID");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@RoomID", paramSectionID);
                    command.ExecuteNonQuery();
                }
            }



            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }
        private void SearchRoom()
        {
            string searchKeyword = tbSearch.Text;

            using (SqlConnection connection = new SqlConnection(GlobalSetting.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Get column names
                    DataTable schemaTable = connection.GetSchema("Columns", new[] { null, null, "Room", null });

                    // Check if there are any columns
                    if (schemaTable.Rows.Count == 0)
                    {
                        // Handle scenario where no columns are found
                        MessageBox.Show("No columns found in the table.");
                        return;
                    }

                    // Constructing the dynamic SQL query
                    command.CommandText = "SELECT * FROM [dbo].[Room] WHERE ";

                    foreach (DataRow row in schemaTable.Rows)
                    {
                        string columnName = (string)row["COLUMN_NAME"];

                        // Append each column to the WHERE clause
                        command.CommandText += $"[{columnName}] LIKE @{columnName} OR ";

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
                    dataGridViewRoom.DataSource = searchResults;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SearchRoom();
        }
    }
}
