using Enrollment_System.Modules;
using Microsoft.SqlServer.Server;
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
    public partial class Login : Form
    {
        private static string UserType;
        private static string UserDetail;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LogIn(tbUserName.Text, tbPassword.Text))
            {

                if (UserType == "Administrator")
                {
                    MainForm mainForm = new MainForm();
                    mainForm.userRole = UserType;
                    mainForm.Show();
                    MessageBox.Show("Log In Successfully! User Type: Admin");
                }

                else if (UserType == "Registrar Personnel")
                {
                    Registrar registrar = new Registrar();

                    registrar.Show();
                    MessageBox.Show("Log In Successfully! User Type: Registrar Personnel");

                }
                else if (UserType == "Accounting Personnel")
                {
                    Accounting accounting = new Accounting();

                    accounting.Show();
                    MessageBox.Show("Log In Successfully! User Type: Accounting Personnel");
                }

                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

            //Login();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        static bool LogIn(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalSetting.ConnectionString))
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("SELECT PasswordHash, Salt, UserType, Name ");
                    stringBuilder.Append("FROM [IT3232Javellana].[stud].[UserAccount] ");
                    stringBuilder.Append("WHERE Username = @Username ");

                    SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection);
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string storedPasswordHash = reader["PasswordHash"].ToString();
                        string salt = reader["Salt"].ToString();

                        //hash the entered password with the retrieved sakt
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
                        UserType = reader["UserType"].ToString();
                        //USerDetail = reader["Name"].ToString();
                        //Compare the hashed passwords
                        if (hashedPassword == storedPasswordHash)
                        {
                            return true; //Login successful
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:" + ex.Message);
            }

            return false; //Login Failed

        }
    }
}
