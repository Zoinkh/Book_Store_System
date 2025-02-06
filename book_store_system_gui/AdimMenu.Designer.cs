namespace book_store_system_gui
{
    partial class AdimMenu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(504, 57);
            label1.TabIndex = 0;
            label1.Text = "Book Store System V.1";
            // 
            // listView1
            // 
            listView1.Location = new Point(27, 84);
            listView1.Name = "listView1";
            listView1.Size = new Size(904, 481);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(956, 127);
            button1.Name = "button1";
            button1.Size = new Size(157, 52);
            button1.TabIndex = 2;
            button1.Text = "Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(956, 203);
            button2.Name = "button2";
            button2.Size = new Size(157, 52);
            button2.TabIndex = 3;
            button2.Text = "Stock";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(956, 283);
            button3.Name = "button3";
            button3.Size = new Size(157, 52);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(956, 364);
            button4.Name = "button4";
            button4.Size = new Size(157, 52);
            button4.TabIndex = 5;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(956, 439);
            button5.Name = "button5";
            button5.Size = new Size(157, 52);
            button5.TabIndex = 6;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(956, 513);
            button6.Name = "button6";
            button6.Size = new Size(157, 52);
            button6.TabIndex = 7;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            // 
            // AdimMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1140, 592);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "AdimMenu";
            Text = "Admin Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}