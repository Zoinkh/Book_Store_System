﻿namespace book_store_system_gui.UI
{
    partial class ItemDetail
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
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 0;
            label1.Text = "title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label2.Location = new Point(32, 81);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(130, 439);
            button1.Name = "button1";
            button1.Size = new Size(188, 42);
            button1.TabIndex = 2;
            button1.Text = "Add to Cart";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label3.Location = new Point(32, 129);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label4.Location = new Point(32, 179);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label5.Location = new Point(32, 229);
            label5.Name = "label5";
            label5.Size = new Size(80, 28);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label6.Location = new Point(32, 277);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label7.Location = new Point(32, 329);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 7;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label8.Location = new Point(32, 379);
            label8.Name = "label8";
            label8.Size = new Size(80, 28);
            label8.TabIndex = 8;
            label8.Text = "label8";
            // 
            // ItemDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(440, 520);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ItemDetail";
            Text = "ItemDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}