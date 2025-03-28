using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_store_system_gui.UI
{
    public partial class Ordered : Form
    {
        public Ordered()
        {
            InitializeComponent();
        }

        private void Ordered_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Age", 50);
            listView1.Columns.Add("City", 100);
            listView1.Items.Add(new ListViewItem(new string[] { "John Doe", "30", "New York" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Jane Smith", "25", "London" }));
            this.Controls.Add(listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
