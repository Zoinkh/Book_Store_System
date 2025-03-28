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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            await Task.Delay(3000);
            SigninForm singin = new SigninForm();
            singin.FormClosed += (s, args) => this.Close();
            singin.Show();
            this.Hide();
                   
        }
    }
}
