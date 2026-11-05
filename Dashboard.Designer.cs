using System;
using System.Windows.Forms;

namespace FOAM1
{
    public partial class DashboaedFoam : Form
    {
        public DashboaedFoam()
        {
            InitializeComponent();
        }

        private void DashboaedFoam_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginFoam login = new LoginFoam();
            login.Show();
            this.Hide();
        }

        private void BicycleRental_Click(object sender, EventArgs e)
        {
            BicycleRental bike = new BicycleRental();
            bike.Show();
            this.Hide();
        }

        private void Mushroom_Click(object sender, EventArgs e)
        {
            Mushroom mushroom = new Mushroom();
            mushroom.Show();
            this.Hide();
        }

        private Button BicycleRental;
        private Button Mushroom1;
        private Button Logout;
        private Label Dashboard;
    }
}