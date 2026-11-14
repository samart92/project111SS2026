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

namespace WindowsFormsApp14
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server=sql12.freesqldatabase.com;Database=sql12840087;User ID=sql12840087;Password=uebaM9hCwP;");
            string sql = $"SELECT * FROM tbuser WHERE fullName='{txtName.Text}' and Password='{txtpassword.Text}'";
            MySqlCommand cm = new MySqlCommand(sql, cn);
            cn.Open();
            MySqlDataReader dr = cm.ExecuteReader();

            if (dr.HasRows)
            {
                var fm =new frmMain();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            cn.Close();

        }
    }
}
