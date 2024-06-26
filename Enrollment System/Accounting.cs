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
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void Accounting_Load(object sender, EventArgs e)
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

        private void pbPayment_Click(object sender, EventArgs e)
        {
            StudentPayment studentPayment = new StudentPayment();
            studentPayment.ShowDialog();
        }

        private void lbPayment_Click(object sender, EventArgs e)
        {
            StudentPayment studentPayment = new StudentPayment();
            studentPayment.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
