namespace book_store_system_gui
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
            if (rbtn_KeepMeIn.Checked)
            {
                //check previour login account in db, and past to txb
            }
            else
            {
                txb_Account.Clear();
                txb_Password.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormClosed = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
