using System;
using System.Windows.Forms;

namespace FOAM1
{
    public partial class Mushroom : Form
    {
        public Mushroom()
        {
            InitializeComponent();
        }

        private void Mushroom_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Convex_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Identify_Click(object sender, EventArgs e)
        {
            string gills = comboBox1.Text;
            string forest = comboBox2.Text;
            string ring = comboBox3.Text;
            string convex = comboBox4.Text;

            if (gills == "" || forest == "" || ring == "" || convex == "")
            {
                MessageBox.Show("Please select Yes or No for all fields.");
                return;
            }

            if (gills == "No")
            {
                textBox1.Text = "Cepe de Bordeaux";
            }
            else if (forest == "No" && ring == "Yes" && convex == "Yes")
            {
                textBox1.Text = "Agaric Jaunissant";
            }
            else if (forest == "No" && ring == "Yes" && convex == "No")
            {
                textBox1.Text = "Coprin Chevelu";
            }
            else if (forest == "Yes" && ring == "Yes" && convex == "Yes")
            {
                textBox1.Text = "Amanite Tue-Mouche";
            }
            else if (forest == "Yes" && ring == "No" && convex == "Yes")
            {
                textBox1.Text = "Pied Bleu";
            }
            else if (forest == "Yes" && ring == "No" && convex == "No")
            {
                textBox1.Text = "Girolle";
            }
            else
            {
                textBox1.Text = "Unknown Mushroom";
            }
        }
    }
}
