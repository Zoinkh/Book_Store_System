using book_store_system_gui.UI;
using System.Threading.Tasks;
using System.Threading;
using book_store_system_gui.Library;

namespace book_store_system_gui
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SingUpInfo singup = new SingUpInfo();
            singup.ShowDialog();

        }

        private void bnt_LogIn_Click(object sender, EventArgs e)
        {
            UserHome dashboard = new UserHome();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdimMenu admin = new AdimMenu();
            admin.FormClosed += (s, args) => this.Close();
            admin.Show();
            this.Hide();
        }
    }
}
