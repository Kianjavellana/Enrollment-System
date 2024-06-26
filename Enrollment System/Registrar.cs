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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
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

        private void pbStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
        }

        private void lbStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this. Close();
            Login login = new Login();
            login.ShowDialog(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

		private void lbOfferedSubject_Click(object sender, EventArgs e)
		{
			OfferedSubject offeredSubject = new OfferedSubject();
			offeredSubject.ShowDialog();
		}

		private void pbOfferedSubject_Click(object sender, EventArgs e)
		{
			OfferedSubject offeredSubject = new OfferedSubject();
			offeredSubject.ShowDialog();
		}
	}
}
