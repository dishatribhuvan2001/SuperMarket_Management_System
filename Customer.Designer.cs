namespace Supermarket_Management_System
{
    partial class Customer
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
            label1 = new Label();
            panel2 = new Panel();
            Cusresbtn = new Button();
            Cusdelbtn = new Button();
            Cusupdbtn = new Button();
            Proincbtn = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Cusshwbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 53);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(428, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(Cusshwbtn);
            panel2.Controls.Add(Cusresbtn);
            panel2.Controls.Add(Cusdelbtn);
            panel2.Controls.Add(Cusupdbtn);
            panel2.Controls.Add(Proincbtn);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 266);
            panel2.TabIndex = 4;
            // 
            // Cusresbtn
            // 
            Cusresbtn.BackColor = Color.Silver;
            Cusresbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cusresbtn.Location = new Point(812, 208);
            Cusresbtn.Name = "Cusresbtn";
            Cusresbtn.Size = new Size(94, 44);
            Cusresbtn.TabIndex = 13;
            Cusresbtn.Text = "Reset";
            Cusresbtn.UseVisualStyleBackColor = false;
            Cusresbtn.Click += Cusresbtn_Click;
            // 
            // Cusdelbtn
            // 
            Cusdelbtn.BackColor = Color.Silver;
            Cusdelbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cusdelbtn.Location = new Point(633, 208);
            Cusdelbtn.Name = "Cusdelbtn";
            Cusdelbtn.Size = new Size(112, 44);
            Cusdelbtn.TabIndex = 12;
            Cusdelbtn.Text = "Delete";
            Cusdelbtn.UseVisualStyleBackColor = false;
            Cusdelbtn.Click += Cusdelbtn_Click;
            // 
            // Cusupdbtn
            // 
            Cusupdbtn.BackColor = Color.Silver;
            Cusupdbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cusupdbtn.Location = new Point(451, 208);
            Cusupdbtn.Name = "Cusupdbtn";
            Cusupdbtn.Size = new Size(109, 44);
            Cusupdbtn.TabIndex = 11;
            Cusupdbtn.Text = "Update";
            Cusupdbtn.UseVisualStyleBackColor = false;
            Cusupdbtn.Click += Cusupdbtn_Click;
            // 
            // Proincbtn
            // 
            Proincbtn.BackColor = Color.Silver;
            Proincbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Proincbtn.Location = new Point(263, 208);
            Proincbtn.Name = "Proincbtn";
            Proincbtn.Size = new Size(100, 44);
            Proincbtn.TabIndex = 3;
            Proincbtn.Text = "Insert";
            Proincbtn.UseVisualStyleBackColor = false;
            Proincbtn.Click += Proincbtn_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(481, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(481, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(481, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(481, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(170, 158);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 6;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 109);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 5;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 63);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 4;
            label3.Text = "CustomerName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 14);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 3;
            label2.Text = "CustomerID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(952, 201);
            dataGridView1.TabIndex = 5;
            // 
            // Cusshwbtn
            // 
            Cusshwbtn.BackColor = Color.Silver;
            Cusshwbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cusshwbtn.Location = new Point(56, 208);
            Cusshwbtn.Name = "Cusshwbtn";
            Cusshwbtn.Size = new Size(150, 44);
            Cusshwbtn.TabIndex = 17;
            Cusshwbtn.Text = "Show Data";
            Cusshwbtn.UseVisualStyleBackColor = false;
            Cusshwbtn.Click += Cusshwbtn_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(976, 556);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button Cusresbtn;
        private Button Cusdelbtn;
        private Button Cusupdbtn;
        private Button Proincbtn;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button Cusshwbtn;
    }
}