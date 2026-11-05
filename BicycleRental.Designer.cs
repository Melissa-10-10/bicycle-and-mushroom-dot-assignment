namespace FOAM1
{
    partial class BicycleRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BicycleRentalfoam = new System.Windows.Forms.Label();
            this.Stathour = new System.Windows.Forms.Label();
            this.Endhour = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Totalcost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BicycleRentalfoam
            // 
            this.BicycleRentalfoam.AutoSize = true;
            this.BicycleRentalfoam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BicycleRentalfoam.Location = new System.Drawing.Point(277, 40);
            this.BicycleRentalfoam.Name = "BicycleRentalfoam";
            this.BicycleRentalfoam.Size = new System.Drawing.Size(97, 18);
            this.BicycleRentalfoam.TabIndex = 0;
            this.BicycleRentalfoam.Text = "BicycleRental";
            // 
            // Stathour
            // 
            this.Stathour.AutoSize = true;
            this.Stathour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Stathour.Location = new System.Drawing.Point(160, 84);
            this.Stathour.Name = "Stathour";
            this.Stathour.Size = new System.Drawing.Size(73, 17);
            this.Stathour.TabIndex = 1;
            this.Stathour.Text = "Start Hour";
            // 
            // Endhour
            // 
            this.Endhour.AutoSize = true;
            this.Endhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Endhour.Location = new System.Drawing.Point(160, 136);
            this.Endhour.Name = "Endhour";
            this.Endhour.Size = new System.Drawing.Size(68, 17);
            this.Endhour.TabIndex = 2;
            this.Endhour.Text = "End Hour";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(301, 204);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(301, 316);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(289, 269);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Totalcost
            // 
            this.Totalcost.AutoSize = true;
            this.Totalcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Totalcost.Location = new System.Drawing.Point(191, 272);
            this.Totalcost.Name = "Totalcost";
            this.Totalcost.Size = new System.Drawing.Size(72, 17);
            this.Totalcost.TabIndex = 9;
            this.Totalcost.Text = "Total Cost";
            this.Totalcost.Click += new System.EventHandler(this.Totalcost_Click);
            // 
            // BicycleRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Totalcost);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Endhour);
            this.Controls.Add(this.Stathour);
            this.Controls.Add(this.BicycleRentalfoam);
            this.Name = "BicycleRental";
            this.Text = "BicycleRental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BicycleRentalfoam;
        private System.Windows.Forms.Label Stathour;
        private System.Windows.Forms.Label Endhour;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Totalcost;
    }
}