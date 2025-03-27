namespace Supermarket_Management_System
{
    partial class Register_Page
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
            comboBox1 = new ComboBox();
            Reglogbtn = new Button();
            label7 = new Label();
            Regregbtn = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Female", "Male" });
            comboBox1.Location = new Point(496, 415);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 29;
            // 
            // Reglogbtn
            // 
            Reglogbtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reglogbtn.Location = new Point(365, 599);
            Reglogbtn.Name = "Reglogbtn";
            Reglogbtn.Size = new Size(94, 48);
            Reglogbtn.TabIndex = 28;
            Reglogbtn.Text = "Login";
            Reglogbtn.UseVisualStyleBackColor = true;
            Reglogbtn.Click += Reglogbtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(299, 561);
            label7.Name = "label7";
            label7.Size = new Size(230, 25);
            label7.TabIndex = 27;
            label7.Text = "Orlady have an account?";
            // 
            // Regregbtn
            // 
            Regregbtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Regregbtn.Location = new Point(347, 493);
            Regregbtn.Name = "Regregbtn";
            Regregbtn.Size = new Size(138, 44);
            Regregbtn.TabIndex = 26;
            Regregbtn.Text = "REGISTER";
            Regregbtn.UseVisualStyleBackColor = true;
            Regregbtn.Click += Regregbtn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(505, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(505, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(505, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 418);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 21;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 359);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 20;
            label5.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 288);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 19;
            label4.Text = "Mobile No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 205);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 130);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 21);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 16;
            label1.Text = "Registration";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Admin", "User" });
            comboBox2.Location = new Point(496, 359);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 30;
            // 
            // Register_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 683);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(Reglogbtn);
            Controls.Add(label7);
            Controls.Add(Regregbtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register_Page";
            Text = "Register_Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button Reglogbtn;
        private Label label7;
        private Button Regregbtn;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
    }
}