namespace Developer
{
    public partial class Screen_Login : Form
    {
        // References
        Screen_Calculator Screen_Calculator = new Screen_Calculator();

        public Screen_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void chshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chshowpassword.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btncalculator_Click(object sender, EventArgs e)
        {
            Screen_Calculator.Show();
        }
    }
}
