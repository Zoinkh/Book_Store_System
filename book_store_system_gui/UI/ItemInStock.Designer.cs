namespace book_store_system_gui.UI
{
    partial class ItemInStock
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
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 215);
            listView1.Name = "listView1";
            listView1.Size = new Size(976, 372);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
            label1.Location = new Point(612, 106);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 1;
            label1.Text = "Current Order :";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
            label2.Location = new Point(93, 54);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 2;
            label2.Text = "Total Item :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(234, 32);
            label3.TabIndex = 3;
            label3.Text = "Total Stock Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(600, 158);
            label4.Name = "label4";
            label4.Size = new Size(214, 32);
            label4.TabIndex = 4;
            label4.Text = "Number of Sale :\r\n";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
            label5.Location = new Point(45, 160);
            label5.Name = "label5";
            label5.Size = new Size(201, 32);
            label5.TabIndex = 5;
            label5.Text = "Total Revenue :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(423, 11);
            label6.Name = "label6";
            label6.Size = new Size(111, 43);
            label6.TabIndex = 6;
            label6.Text = "Stock";
            // 
            // ItemInStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1000, 599);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "ItemInStock";
            Text = "ItemInStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}