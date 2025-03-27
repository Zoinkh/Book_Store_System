namespace book_store_system_gui.UI
{
    partial class SingUp
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
            btn_Exit = new Button();
            bnt_LogIn = new Button();
            txb_Password = new TextBox();
            txb_Account = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.LightCoral;
            btn_Exit.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            btn_Exit.Location = new Point(160, 296);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(78, 40);
            btn_Exit.TabIndex = 16;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            // 
            // bnt_LogIn
            // 
            bnt_LogIn.BackColor = Color.Lime;
            bnt_LogIn.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            bnt_LogIn.Location = new Point(258, 296);
            bnt_LogIn.Name = "bnt_LogIn";
            bnt_LogIn.Size = new Size(217, 40);
            bnt_LogIn.TabIndex = 15;
            bnt_LogIn.Text = "Sing Up";
            bnt_LogIn.UseVisualStyleBackColor = false;
            // 
            // txb_Password
            // 
            txb_Password.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            txb_Password.Location = new Point(244, 204);
            txb_Password.Name = "txb_Password";
            txb_Password.Size = new Size(231, 32);
            txb_Password.TabIndex = 14;
            // 
            // txb_Account
            // 
            txb_Account.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            txb_Account.Location = new Point(244, 155);
            txb_Account.Name = "txb_Account";
            txb_Account.Size = new Size(231, 32);
            txb_Account.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label4.Location = new Point(121, 209);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 12;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 158);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 11;
            label3.Text = "Account :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(244, 108);
            label2.Name = "label2";
            label2.Size = new Size(97, 32);
            label2.TabIndex = 10;
            label2.Text = "Sign In";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 31);
            label1.Name = "label1";
            label1.Size = new Size(477, 59);
            label1.TabIndex = 9;
            label1.Text = "Book Store System V.1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            textBox1.Location = new Point(244, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 32);
            textBox1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label5.Location = new Point(35, 256);
            label5.Name = "label5";
            label5.Size = new Size(202, 25);
            label5.TabIndex = 17;
            label5.Text = "Confirm Password :";
            // 
            // SingUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(575, 379);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(btn_Exit);
            Controls.Add(bnt_LogIn);
            Controls.Add(txb_Password);
            Controls.Add(txb_Account);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SingUp";
            Text = "SingUp";
            Load += SingUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Exit;
        private Button bnt_LogIn;
        private TextBox txb_Password;
        private TextBox txb_Account;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
    }
}