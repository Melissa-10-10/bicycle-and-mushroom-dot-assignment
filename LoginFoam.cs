using System;
using System.Windows.Forms;

namespace FOAM1
{
    public partial class LoginFoam : Form
    {
        public LoginFoam()
        {
            InitializeComponent();
        }

        private void LoginFoam_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Username cannot be empty!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }

            DashboaedFoam dashboard = new DashboaedFoam();
            dashboard.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
}