namespace Supermarket_Management_System
{
    partial class Inventory
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
            dataGridView1 = new DataGridView();
            Invshowbtn = new Button();
            Invresbtn = new Button();
            Invdelbtn = new Button();
            Invupdbtn = new Button();
            Invinsbtn = new Button();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 383);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(952, 169);
            dataGridView1.TabIndex = 11;
            // 
            // Invshowbtn
            // 
            Invshowbtn.BackColor = Color.Silver;
            Invshowbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Invshowbtn.Location = new Point(112, 243);
            Invshowbtn.Name = "Invshowbtn";
            Invshowbtn.Size = new Size(150, 44);
            Invshowbtn.TabIndex = 16;
            Invshowbtn.Text = "Show Data";
            Invshowbtn.UseVisualStyleBackColor = false;
            Invshowbtn.Click += Invshowbtn_Click;
            // 
            // Invresbtn
            // 
            Invresbtn.BackColor = Color.Silver;
            Invresbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Invresbtn.Location = new Point(761, 239);
            Invresbtn.Name = "Invresbtn";
            Invresbtn.Size = new Size(112, 44);
            Invresbtn.TabIndex = 13;
            Invresbtn.Text = "Reset";
            Invresbtn.UseVisualStyleBackColor = false;
            Invresbtn.Click += Invresbtn_Click;
            // 
            // Invdelbtn
            // 
            Invdelbtn.BackColor = Color.Silver;
            Invdelbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Invdelbtn.Location = new Point(598, 239);
            Invdelbtn.Name = "Invdelbtn";
            Invdelbtn.Size = new Size(112, 44);
            Invdelbtn.TabIndex = 12;
            Invdelbtn.Text = "Delete";
            Invdelbtn.UseVisualStyleBackColor = false;
            Invdelbtn.Click += Invdelbtn_Click;
            // 
            // Invupdbtn
            // 
            Invupdbtn.BackColor = Color.Silver;
            Invupdbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Invupdbtn.Location = new Point(443, 239);
            Invupdbtn.Name = "Invupdbtn";
            Invupdbtn.Size = new Size(112, 44);
            Invupdbtn.TabIndex = 11;
            Invupdbtn.Text = "Update";
            Invupdbtn.UseVisualStyleBackColor = false;
            Invupdbtn.Click += Invupdbtn_Click;
            // 
            // Invinsbtn
            // 
            Invinsbtn.BackColor = Color.Silver;
            Invinsbtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Invinsbtn.Location = new Point(303, 243);
            Invinsbtn.Name = "Invinsbtn";
            Invinsbtn.Size = new Size(112, 44);
            Invinsbtn.TabIndex = 3;
            Invinsbtn.Text = "Insert";
            Invinsbtn.UseVisualStyleBackColor = false;
            Invinsbtn.Click += Invinsbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(428, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
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
            label5.Location = new Point(164, 147);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 6;
            label5.Text = "StockRemoved";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(164, 109);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 5;
            label4.Text = "StockAdded";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 62);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 4;
            label3.Text = "ProductID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 16);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 3;
            label2.Text = "IID";
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 49);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(Invshowbtn);
            panel2.Controls.Add(Invresbtn);
            panel2.Controls.Add(Invdelbtn);
            panel2.Controls.Add(Invupdbtn);
            panel2.Controls.Add(Invinsbtn);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(23, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 304);
            panel2.TabIndex = 10;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 587);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Inventory";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Invshowbtn;
        private Button Invresbtn;
        private Button Invdelbtn;
        private Button Invupdbtn;
        private Button Invinsbtn;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
    }
}