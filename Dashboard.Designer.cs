namespace Supermarket_Management_System
{
    partial class Dashboard
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
            panel1 = new Panel();
            lblCount1 = new Label();
            panel2 = new Panel();
            lblCount2 = new Label();
            panel3 = new Panel();
            lblCount3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(lblCount1);
            panel1.Location = new Point(47, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 125);
            panel1.TabIndex = 0;
            // 
            // lblCount1
            // 
            lblCount1.AutoSize = true;
            lblCount1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount1.Location = new Point(44, 51);
            lblCount1.Name = "lblCount1";
            lblCount1.Size = new Size(27, 29);
            lblCount1.TabIndex = 0;
            lblCount1.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(lblCount2);
            panel2.Location = new Point(47, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 125);
            panel2.TabIndex = 1;
            // 
            // lblCount2
            // 
            lblCount2.AutoSize = true;
            lblCount2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount2.Location = new Point(44, 57);
            lblCount2.Name = "lblCount2";
            lblCount2.Size = new Size(27, 29);
            lblCount2.TabIndex = 1;
            lblCount2.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(lblCount3);
            panel3.Location = new Point(47, 353);
            panel3.Name = "panel3";
            panel3.Size = new Size(949, 125);
            panel3.TabIndex = 2;
            // 
            // lblCount3
            // 
            lblCount3.AutoSize = true;
            lblCount3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount3.Location = new Point(44, 48);
            lblCount3.Name = "lblCount3";
            lblCount3.Size = new Size(27, 29);
            lblCount3.TabIndex = 1;
            lblCount3.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1034, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCount1;
        private Panel panel2;
        private Panel panel3;
        private Label lblCount2;
        private Label lblCount3;
    }
}