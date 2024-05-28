using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Developer
{
    public partial class Screen_Login_load : Form
    {

        //DB connection
        SqlConnection connection = new SqlConnection("server=192.168.1.184; database=MYDB; integrated security=true");


        public Screen_Login_load()
        {
            InitializeComponent();
        }

        private void pnlload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                SqlCommand script = new SqlCommand("select username, password from Login where username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'", connection);
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
    }
}
