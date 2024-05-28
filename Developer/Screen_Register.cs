using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer
{
<<<<<<< HEAD

    public partial class Screen_Register : Form
    {
        //DB connection
        SqlConnection connection = new SqlConnection("server=192.168.1.184; database=MYDB; integrated security=true");



        public Screen_Register()
        {
            InitializeComponent();

        }


        public void lblloginhere_Click(object sender, EventArgs e)
        {

        }

        private void pnlloadR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string script = ("insert into Register values('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtusernameR.Text + "','" + txtemail.Text + "','" + txtpasswordR.Text + "')");
                SqlCommand Send = new SqlCommand(script, connection);
                Send.ExecuteNonQuery();

                MessageBox.Show($"User {txtfirstname.Text}" + $" {txtlastname.Text} registered");
                txtlastname.Clear();
                txtfirstname.Clear();
                txtusernameR.Clear();
                txtemail.Clear();
                txtpasswordR.Clear();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Has ocurred an error");
            }
        }

        private void chshowpasswordR_CheckedChanged(object sender, EventArgs e)
        {
            if(chshowpasswordR.Checked) 
            {
                txtpasswordR.PasswordChar = '\0';
            }
            else 
            {
                txtpasswordR.PasswordChar = '•';
            }
=======
    public partial class Screen_Register : Form
    {
        public Screen_Register()
        {
            InitializeComponent();
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
        }
    }
}
