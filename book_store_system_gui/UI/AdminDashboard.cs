using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_store_system_gui
{
    public partial class AdimMenu : Form
    {
        public AdimMenu()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            listView1 = new ListView();
            label2 = new Label();
            textBox1 = new TextBox();
            button9 = new Button();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(810, 83);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 0;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            button2.Location = new Point(810, 129);
            button2.Name = "button2";
            button2.Size = new Size(132, 40);
            button2.TabIndex = 1;
            button2.Text = "Delete Item";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            button3.Location = new Point(810, 175);
            button3.Name = "button3";
            button3.Size = new Size(132, 40);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            button4.Location = new Point(810, 221);
            button4.Name = "button4";
            button4.Size = new Size(132, 40);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            button5.Location = new Point(810, 267);
            button5.Name = "button5";
            button5.Size = new Size(132, 40);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            button6.Location = new Point(810, 313);
            button6.Name = "button6";
            button6.Size = new Size(132, 40);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            button7.Location = new Point(810, 359);
            button7.Name = "button7";
            button7.Size = new Size(132, 40);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            button8.Location = new Point(810, 405);
            button8.Name = "button8";
            button8.Size = new Size(132, 40);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 27.75F, FontStyle.Bold);
            label1.Location = new Point(293, 24);
            label1.Name = "label1";
            label1.Size = new Size(326, 43);
            label1.TabIndex = 9;
            label1.Text = "Admin Dashboard";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 83);
            listView1.Name = "listView1";
            listView1.Size = new Size(778, 532);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 41);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 11;
            label2.Text = "Hello, Name.";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(690, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 26);
            textBox1.TabIndex = 12;
            // 
            // button9
            // 
            button9.Location = new Point(878, 35);
            button9.Name = "button9";
            button9.Size = new Size(64, 28);
            button9.TabIndex = 13;
            button9.Text = "Search";
            button9.UseVisualStyleBackColor = true;
            // 
            // AdimMenu
            // 
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(968, 610);
            Controls.Add(button9);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdimMenu";
            Text = "Admin Dashboard";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox1;
        private Label label1;
        private ListView listView1;
        private Label label2;
        private TextBox textBox1;
        private Button button9;
    }
}
