namespace book_store_system_gui
{
    partial class SigninForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(477, 59);
            label1.TabIndex = 0;
            label1.Text = "Book Store System V.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 86);
            label2.Name = "label2";
            label2.Size = new Size(97, 32);
            label2.TabIndex = 1;
            label2.Text = "Sign In";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 136);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 2;
            label3.Text = "Account :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label4.Location = new Point(70, 187);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 3;
            label4.Text = "Password :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            textBox1.Location = new Point(193, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 32);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            textBox2.Location = new Point(193, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 32);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            button1.Location = new Point(207, 263);
            button1.Name = "button1";
            button1.Size = new Size(217, 40);
            button1.TabIndex = 6;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            button2.Location = new Point(109, 263);
            button2.Name = "button2";
            button2.Size = new Size(78, 40);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(196, 220);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(138, 29);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Keep Me In";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(512, 331);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SigninForm";
            Text = "Book Store System v.1";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
    }
}
