using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace book_store_system_gui.UI
{
    public partial class AccountList : Form
    {
        public AccountList()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AccountList_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Age", 50);
            listView1.Columns.Add("City", 100);
            listView1.Items.Add(new ListViewItem(new string[] { "John Doe", "30", "New York" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Jane Smith", "25", "London" }));
            this.Controls.Add(listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
