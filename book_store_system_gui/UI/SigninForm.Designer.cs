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
            txb_Account = new TextBox();
            txb_Password = new TextBox();
            bnt_LogIn = new Button();
            btn_Exit = new Button();
            rbtn_KeepMeIn = new RadioButton();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
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
            // txb_Account
            // 
            txb_Account.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            txb_Account.Location = new Point(193, 133);
            txb_Account.Name = "txb_Account";
            txb_Account.Size = new Size(231, 32);
            txb_Account.TabIndex = 4;
            txb_Account.TextChanged += textBox1_TextChanged;
            // 
            // txb_Password
            // 
            txb_Password.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            txb_Password.Location = new Point(193, 182);
            txb_Password.Name = "txb_Password";
            txb_Password.Size = new Size(231, 32);
            txb_Password.TabIndex = 5;
            // 
            // bnt_LogIn
            // 
            bnt_LogIn.BackColor = Color.Lime;
            bnt_LogIn.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            bnt_LogIn.Location = new Point(207, 263);
            bnt_LogIn.Name = "bnt_LogIn";
            bnt_LogIn.Size = new Size(217, 40);
            bnt_LogIn.TabIndex = 6;
            bnt_LogIn.Text = "Log In";
            bnt_LogIn.UseVisualStyleBackColor = false;
            bnt_LogIn.Click += bnt_LogIn_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.LightCoral;
            btn_Exit.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            btn_Exit.Location = new Point(109, 263);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(78, 40);
            btn_Exit.TabIndex = 7;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // rbtn_KeepMeIn
            // 
            rbtn_KeepMeIn.AutoSize = true;
            rbtn_KeepMeIn.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_KeepMeIn.Location = new Point(196, 220);
            rbtn_KeepMeIn.Name = "rbtn_KeepMeIn";
            rbtn_KeepMeIn.Size = new Size(138, 29);
            rbtn_KeepMeIn.TabIndex = 8;
            rbtn_KeepMeIn.TabStop = true;
            rbtn_KeepMeIn.Text = "Keep Me In";
            rbtn_KeepMeIn.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(363, 217);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sing Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(437, 258);
            button1.Name = "button1";
            button1.Size = new Size(63, 45);
            button1.TabIndex = 10;
            button1.Text = "Admin Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(512, 331);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(rbtn_KeepMeIn);
            Controls.Add(btn_Exit);
            Controls.Add(bnt_LogIn);
            Controls.Add(txb_Password);
            Controls.Add(txb_Account);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
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
        private TextBox txb_Account;
        private TextBox txb_Password;
        private Button bnt_LogIn;
        private Button btn_Exit;
        private RadioButton rbtn_KeepMeIn;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}
