namespace Supermarket_Management_System
{
    partial class Product
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
            Proresbtn = new Button();
            Prodelbtn = new Button();
            Proupdbtn = new Button();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(428, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(Proresbtn);
            panel2.Controls.Add(Prodelbtn);
            panel2.Controls.Add(Proupdbtn);
            panel2.Controls.Add(Proincbtn);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 266);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Proresbtn
            // 
            Proresbtn.BackColor = Color.Silver;
            Proresbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Proresbtn.Location = new Point(685, 208);
            Proresbtn.Name = "Proresbtn";
            Proresbtn.Size = new Size(94, 44);
            Proresbtn.TabIndex = 13;
            Proresbtn.Text = "Reset";
            Proresbtn.UseVisualStyleBackColor = false;
            Proresbtn.Click += Proresbtn_Click;
            // 
            // Prodelbtn
            // 
            Prodelbtn.BackColor = Color.Silver;
            Prodelbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Prodelbtn.Location = new Point(481, 208);
            Prodelbtn.Name = "Prodelbtn";
            Prodelbtn.Size = new Size(112, 44);
            Prodelbtn.TabIndex = 12;
            Prodelbtn.Text = "Delete";
            Prodelbtn.UseVisualStyleBackColor = false;
            Prodelbtn.Click += Prodelbtn_Click;
            // 
            // Proupdbtn
            // 
            Proupdbtn.BackColor = Color.Silver;
            Proupdbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Proupdbtn.Location = new Point(316, 208);
            Proupdbtn.Name = "Proupdbtn";
            Proupdbtn.Size = new Size(109, 44);
            Proupdbtn.TabIndex = 11;
            Proupdbtn.Text = "Update";
            Proupdbtn.UseVisualStyleBackColor = false;
            Proupdbtn.Click += Proupdbtn_Click;
            // 
            // Proincbtn
            // 
            Proincbtn.BackColor = Color.Silver;
            Proincbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Proincbtn.Location = new Point(132, 208);
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
            label5.Size = new Size(56, 25);
            label5.TabIndex = 6;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 109);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 5;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 63);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 4;
            label3.Text = "ProductName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 14);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 3;
            label2.Text = "ProductID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 343);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(952, 201);
            dataGridView1.TabIndex = 2;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(976, 556);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button Proincbtn;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button Proresbtn;
        private Button Prodelbtn;
        private Button Proupdbtn;
    }
}