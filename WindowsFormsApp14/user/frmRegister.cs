using MySql.Data.MySqlClient;
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

namespace WindowsFormsApp14.user
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //var con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Encrypt=False");
            var con = new MySqlConnection("Server=sql12.freesqldatabase.com;Database=sql12840087;User ID=sql12840087;Password=uebaM9hCwP;");

            var str = $"INSERT INTO tbuser (fullName,UserName,Email,Password) VALUES('{txtfullName.Text}','{txtUserName.Text}','{txtEmail.Text}','{txtPassword.Text}')";
            var cmd = new MySqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            
            //MessageBox.Show("Register successfully");
            var fm = new frmUserLIst();
            fm.Show();
        }

       
    }
}
