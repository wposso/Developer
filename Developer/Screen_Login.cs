using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Developer
{

    public partial class Screen_Login : Form
    {

        //DB connection
        SqlConnection connection = new SqlConnection("server=192.168.1.184; database=MYDB; integrated security=true");

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse

        );

        // References
        Screen_Calculator Screen_Calculator = new Screen_Calculator();
        Screen_Login_load screen_Login_Load = new Screen_Login_load();
        Screen_Register screenRegister = new Screen_Register();

        public static object screen_LoginS { get; internal set; }

        public Screen_Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));


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


        private void Screen_Login_Load(object sender, EventArgs e)
        {

        }



        private void btnresize_Click(object sender, EventArgs e)
        {

        }

        private void Screen_Login_Load_1(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand script = new SqlCommand("select username, password from Register where username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'", connection);
                SqlDataReader reader = script.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    MessageBox.Show("welcome to your system");
                    txtpassword.Clear();
                    txtusername.Clear();

                }
                else
                {
                    MessageBox.Show("Incorret credentials");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has ocurred an error");
                txtusername.Clear();
                txtpassword.Clear();
            }
        }

        private void AbrirLoginS(object screen_LoginS)
        {
            //pnlload.Controls.Clear();
            if (pnlload.Controls.Count > 0)
                pnlload.Controls.Clear();
            Form B = screen_Login_Load as Form;
=======
        private void btnminisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenRegister(object Screen_Register)
        {
            if (this.pnlload.Controls.Count > 0)
                this.pnlload.Controls.RemoveAt(0);
            Form A = Screen_Register as Form;
            A.TopLevel = false;
            A.Dock = DockStyle.Fill;
            this.pnlload.Controls.Add(A);
            this.pnlload.Tag = A;
            A.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //OpenRegister(new Screen_Register());
            pnlmove.Location = new Point(993, 232);
        }

        private void OpenLogin(object Screen_Login)
        {
            if (this.pnlload.Controls.Count > 0)
                this.pnlload.Controls.RemoveAt(0);
            Form B = Screen_Login as Form;
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            B.TopLevel = false;
            B.Dock = DockStyle.Fill;
            this.pnlload.Controls.Add(B);
            this.pnlload.Tag = B;
            B.Show();

        }

<<<<<<< HEAD
        private void AbrirpnlloadR(object screen_Register)
        {
            //this.pnlload.Controls.Clear();
            if (pnlload.Controls.Count > 0)
                pnlload.Controls.Clear();
            Form A = screenRegister as Form;
            A.TopLevel = false;
            A.Dock = DockStyle.Fill;
            this.pnlload.Controls.Add(A);
            this.pnlload.Tag = A;
            A.Show();

        }
        private void pnlload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            AbrirpnlloadR(new Screen_Register());

            //Don't have Account .visible
            if (label7.Visible && lblaccount.Visible == true)
            {
                label7.Visible = false;
                lblaccount.Visible = false;
                label9.Visible = true;
                lblloginhere.Visible = true;
            }
            else
            {
                label7.Visible = true;
                lblaccount.Visible = true;
                label9.Visible = false;
                lblloginhere.Visible = false;
            }

            //if (label7.Visible && lblaccount.Visible == false)
            //{
            //    label7.Location = new Point(1009, 791);
            //    lblaccount.Location = new Point(1104, 791);
            //}
            //else
            //{
            //    label7.Visible = true;
            //    lblaccount.Visible = true;
            //}
        }


        private void lblloginhere1_Click(object sender, EventArgs e)
        {
            AbrirLoginS(new Screen_Login());

            //Already a member Login here .visible
            if (label9.Visible && lblloginhere.Visible == true)
            {
                label9.Visible = false;
                lblloginhere.Visible = false;
                label7.Visible = true;
                lblaccount.Visible = true;

            }
            else
            {
                label7.Visible = false;
                lblaccount.Visible = false;
                label9.Visible = true;
                lblloginhere.Visible = true;
            }

            //if (label9.Visible && lblloginhere.Visible == false)
            //{
            //    label9.Location = new Point(1104, 63);
            //    lblloginhere.Location = new Point(1205, 63);
            //}
            //else
            //{
            //    label9.Visible = true;
            //    lblloginhere.Visible = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
=======
        private void label6_Click(object sender, EventArgs e)
        {
            //OpenRegister(new Screen_Login());
            pnlmove.Location = new Point(813, 232);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
        }
    }
}
