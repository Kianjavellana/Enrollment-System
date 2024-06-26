using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Student());
            //string connectionString = "Data Source=(localdb)\\Local; Initial Catalog=IT3232Javellana; User ID=IT3119; Password=Javellana24";
             
            //{
            //    connection.Open();
            //    string query = "SELECT * FROM [IT3232Javellana].[dbo].[StudentbasicInfo]";
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        SqlDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            string columnName = reader["StudentName"].ToString();
            //            //Console.WriteLine(columnNane);
            //            MessageBox.Show(columnName);
            //        }
            //        reader.Close();
            //    }
            //    connection.Close(); 
            //}
        }
    }
}
