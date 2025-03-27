namespace Supermarket_Management_System
{
    partial class Orders
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            Cusresbtn = new Button();
            Orddelbtn = new Button();
            Ordincbtn = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
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
            panel1.Size = new Size(965, 53);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(428, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Cusresbtn);
            panel2.Controls.Add(Orddelbtn);
            panel2.Controls.Add(Ordincbtn);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 304);
            panel2.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(774, 159);
            button3.Name = "button3";
            button3.Size = new Size(146, 40);
            button3.TabIndex = 18;
            button3.Text = "Calculate price";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(774, 102);
            button2.Name = "button2";
            button2.Size = new Size(146, 37);
            button2.TabIndex = 17;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(112, 243);
            button1.Name = "button1";
            button1.Size = new Size(150, 44);
            button1.TabIndex = 16;
            button1.Text = "Show Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(481, 195);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(264, 27);
            textBox5.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(164, 195);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 14;
            label6.Text = "Amount";
            // 
            // Cusresbtn
            // 
            Cusresbtn.BackColor = Color.DimGray;
            Cusresbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cusresbtn.ForeColor = Color.White;
            Cusresbtn.Location = new Point(761, 239);
            Cusresbtn.Name = "Cusresbtn";
            Cusresbtn.Size = new Size(112, 44);
            Cusresbtn.TabIndex = 13;
            Cusresbtn.Text = "Reset";
            Cusresbtn.UseVisualStyleBackColor = false;
            Cusresbtn.Click += Cusresbtn_Click;
            // 
            // Orddelbtn
            // 
            Orddelbtn.BackColor = Color.DimGray;
            Orddelbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orddelbtn.ForeColor = Color.White;
            Orddelbtn.Location = new Point(514, 243);
            Orddelbtn.Name = "Orddelbtn";
            Orddelbtn.Size = new Size(202, 44);
            Orddelbtn.TabIndex = 12;
            Orddelbtn.Text = "Delete Order";
            Orddelbtn.UseVisualStyleBackColor = false;
            Orddelbtn.Click += Orddelbtn_Click;
            // 
            // Ordincbtn
            // 
            Ordincbtn.BackColor = Color.DimGray;
            Ordincbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ordincbtn.ForeColor = Color.White;
            Ordincbtn.Location = new Point(303, 243);
            Ordincbtn.Name = "Ordincbtn";
            Ordincbtn.Size = new Size(182, 44);
            Ordincbtn.TabIndex = 3;
            Ordincbtn.Text = "Order Place";
            Ordincbtn.UseVisualStyleBackColor = false;
            Ordincbtn.Click += Ordincbtn_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(481, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
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
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(164, 147);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(164, 109);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 5;
            label4.Text = "ProductID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 62);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 4;
            label3.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(164, 16);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 3;
            label2.Text = "OrderID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 366);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(952, 169);
            dataGridView1.TabIndex = 8;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(965, 551);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
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
        private Button Orddelbtn;
        private Button Ordincbtn;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}