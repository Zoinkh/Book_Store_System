namespace book_store_system_gui
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            Checkout = new PictureBox();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Checkout).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 22);
            label1.Name = "label1";
            label1.Size = new Size(204, 43);
            label1.TabIndex = 1;
            label1.Text = "Book Store";
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            button1.Location = new Point(882, 39);
            button1.Name = "button1";
            button1.Size = new Size(71, 32);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            textBox1.Location = new Point(684, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 26);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Checkout
            // 
            Checkout.Image = Properties.Resources._default;
            Checkout.Location = new Point(972, 22);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(57, 58);
            Checkout.SizeMode = PictureBoxSizeMode.CenterImage;
            Checkout.TabIndex = 6;
            Checkout.TabStop = false;
            Checkout.Click += Checkout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 39);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 7;
            label2.Text = "Hello, Name.";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(14, 98);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(1015, 508);
            checkedListBox1.TabIndex = 8;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1059, 618);
            Controls.Add(checkedListBox1);
            Controls.Add(label2);
            Controls.Add(Checkout);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "UserHome";
            Text = "UserForm";
            Load += UserHome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Checkout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox Checkout;
        private Label label2;
        private CheckedListBox checkedListBox1;
    }
}