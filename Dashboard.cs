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

        private void InitializeComponent()
        {
            this.BicycleRental = new System.Windows.Forms.Button();
            this.Mushroom1 = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BicycleRental
            // 
            this.BicycleRental.Location = new System.Drawing.Point(259, 92);
            this.BicycleRental.Name = "BicycleRental";
            this.BicycleRental.Size = new System.Drawing.Size(75, 23);
            this.BicycleRental.TabIndex = 0;
            this.BicycleRental.Text = "BiycleRental";
            this.BicycleRental.UseVisualStyleBackColor = true;
            // 
            // Mushroom1
            // 
            this.Mushroom1.Location = new System.Drawing.Point(502, 92);
            this.Mushroom1.Name = "Mushroom1";
            this.Mushroom1.Size = new System.Drawing.Size(75, 23);
            this.Mushroom1.TabIndex = 1;
            this.Mushroom1.Text = "Mushroom";
            this.Mushroom1.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(397, 174);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Location = new System.Drawing.Point(394, 36);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(75, 13);
            this.Dashboard.TabIndex = 3;
            this.Dashboard.Text = "DASHBOARD";
            // 
            // DashboaedFoam
            // 
            this.ClientSize = new System.Drawing.Size(823, 411);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Mushroom1);
            this.Controls.Add(this.BicycleRental);
            this.Name = "DashboaedFoam";
            this.Load += new System.EventHandler(this.DashboaedFoam_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DashboaedFoam_Load_1(object sender, EventArgs e)
        {

        }
    }
}