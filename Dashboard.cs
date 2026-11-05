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
            this.BicycleRental1 = new System.Windows.Forms.Button();
            this.Mushroom = new System.Windows.Forms.Button();
            this.Logout1 = new System.Windows.Forms.Button();
            this.Dashboard1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BicycleRental1
            // 
            this.BicycleRental1.Location = new System.Drawing.Point(202, 94);
            this.BicycleRental1.Name = "BicycleRental1";
            this.BicycleRental1.Size = new System.Drawing.Size(90, 23);
            this.BicycleRental1.TabIndex = 0;
            this.BicycleRental1.Text = "BicycleRental";
            this.BicycleRental1.UseVisualStyleBackColor = true;
            this.BicycleRental1.Click += new System.EventHandler(this.BicycleRental_Click);
            // 
            // Mushroom
            // 
            this.Mushroom.Location = new System.Drawing.Point(393, 94);
            this.Mushroom.Name = "Mushroom";
            this.Mushroom.Size = new System.Drawing.Size(75, 23);
            this.Mushroom.TabIndex = 1;
            this.Mushroom.Text = "Mushroom";
            this.Mushroom.UseVisualStyleBackColor = true;
            this.Mushroom.Click += new System.EventHandler(this.Mushroom_Click);
            // 
            // Logout1
            // 
            this.Logout1.Location = new System.Drawing.Point(312, 159);
            this.Logout1.Name = "Logout1";
            this.Logout1.Size = new System.Drawing.Size(75, 23);
            this.Logout1.TabIndex = 2;
            this.Logout1.Text = "Logout";
            this.Logout1.UseVisualStyleBackColor = true;
            this.Logout1.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Dashboard1
            // 
            this.Dashboard1.AutoSize = true;
            this.Dashboard1.Location = new System.Drawing.Point(309, 43);
            this.Dashboard1.Name = "Dashboard1";
            this.Dashboard1.Size = new System.Drawing.Size(75, 13);
            this.Dashboard1.TabIndex = 3;
            this.Dashboard1.Text = "DASHBOARD";
            // 
            // DashboaedFoam
            // 
            this.ClientSize = new System.Drawing.Size(775, 376);
            this.Controls.Add(this.Dashboard1);
            this.Controls.Add(this.Logout1);
            this.Controls.Add(this.Mushroom);
            this.Controls.Add(this.BicycleRental1);
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