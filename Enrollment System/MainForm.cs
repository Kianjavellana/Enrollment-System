using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class MainForm : Form
    {
        public string userRole {  get; set; }
        public string userDetail { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void CenterPanel()
        {
            // Calculate the position to center the panel within the form
            int x = (ClientSize.Width - panel1.Width) / 2;
            int y = (ClientSize.Height - panel1.Height) / 2;

            // Set the panel's location
            panel1.Location = new System.Drawing.Point(x, y);


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void pbCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.ShowDialog();
        }

        private void lbCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.ShowDialog();
        }

        private void pbStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.ShowDialog();
        }

        private void lbStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.ShowDialog();
        }

        private void pbSubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.ShowDialog();
        }

        private void lbSubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.ShowDialog();
        }

        private void pbFee_Click(object sender, EventArgs e)
        {
            Fee fee = new Fee();
            fee.ShowDialog();
        }

        private void lbFee_Click(object sender, EventArgs e)
        {
            Fee fee = new Fee();
            fee.ShowDialog();
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void pbPayment_Click(object sender, EventArgs e)
        {
            StudentPayment studentPayment = new StudentPayment();
            studentPayment.userDetail = userDetail;
            studentPayment.ShowDialog();
        }

        private void lbPayment_Click(object sender, EventArgs e)
        {
            StudentPayment studentPayment = new StudentPayment();
            studentPayment.userDetail = userDetail;
            studentPayment.ShowDialog();
        }

        private void pbUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.ShowDialog();
        }

        private void lbUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement usersManagement = new UserManagement();
            usersManagement.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement usersManagement = new UserManagement();
            usersManagement.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.ShowDialog();
        }

        private void pbSection_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            section.ShowDialog();
        }

        private void lbSection_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            section.ShowDialog();
        }
    }
}
