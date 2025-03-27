namespace Supermarket_Management_System
{
    partial class Market
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Market));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            Marordbtn = new Button();
            Marcusbtn = new Button();
            Marprobtn = new Button();
            Mardasbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(549, 39);
            label1.TabIndex = 0;
            label1.Text = "Super Market Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 128);
            panel2.Controls.Add(Mardasbtn);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(Marordbtn);
            panel2.Controls.Add(Marcusbtn);
            panel2.Controls.Add(Marprobtn);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 485);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(33, 214);
            button4.Name = "button4";
            button4.Size = new Size(172, 45);
            button4.TabIndex = 5;
            button4.Text = "Inventory";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Marordbtn
            // 
            Marordbtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Marordbtn.Location = new Point(33, 152);
            Marordbtn.Name = "Marordbtn";
            Marordbtn.Size = new Size(172, 45);
            Marordbtn.TabIndex = 4;
            Marordbtn.Text = "Order";
            Marordbtn.UseVisualStyleBackColor = true;
            Marordbtn.Click += Marordbtn_Click;
            // 
            // Marcusbtn
            // 
            Marcusbtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Marcusbtn.Location = new Point(33, 91);
            Marcusbtn.Name = "Marcusbtn";
            Marcusbtn.Size = new Size(172, 45);
            Marcusbtn.TabIndex = 3;
            Marcusbtn.Text = "Customer";
            Marcusbtn.UseVisualStyleBackColor = true;
            Marcusbtn.Click += Marcusbtn_Click;
            // 
            // Marprobtn
            // 
            Marprobtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Marprobtn.Location = new Point(33, 31);
            Marprobtn.Name = "Marprobtn";
            Marprobtn.Size = new Size(172, 45);
            Marprobtn.TabIndex = 2;
            Marprobtn.Text = "Product";
            Marprobtn.UseVisualStyleBackColor = true;
            Marprobtn.Click += Marprobtn_Click;
            // 
            // Mardasbtn
            // 
            Mardasbtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mardasbtn.Location = new Point(33, 277);
            Mardasbtn.Name = "Mardasbtn";
            Mardasbtn.Size = new Size(172, 45);
            Mardasbtn.TabIndex = 6;
            Mardasbtn.Text = "Dashboard";
            Mardasbtn.UseVisualStyleBackColor = true;
            Mardasbtn.Click += Mardasbtn_Click;
            // 
            // Market
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(976, 556);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Market";
            Text = "Market";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button Marordbtn;
        private Button Marcusbtn;
        private Button Marprobtn;
        private Button Mardasbtn;
    }
}