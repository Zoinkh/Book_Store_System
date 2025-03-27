namespace book_store_system_gui.Library
{
    partial class Checkout
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
            label1 = new Label();
            listView1 = new ListView();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(177, 43);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 72);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 461);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(727, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "Checkout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(611, 33);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 3;
            label2.Text = "Total/Price";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            button1.Location = new Point(663, 550);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 4;
            button1.Text = "BUY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            button2.Location = new Point(521, 550);
            button2.Name = "button2";
            button2.Size = new Size(125, 38);
            button2.TabIndex = 5;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSpringGreen;
            button3.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            button3.Location = new Point(378, 550);
            button3.Name = "button3";
            button3.Size = new Size(125, 38);
            button3.TabIndex = 6;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            button4.Location = new Point(12, 550);
            button4.Name = "button4";
            button4.Size = new Size(125, 38);
            button4.TabIndex = 7;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 600);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}