using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp14.user
{
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server=sql12.freesqldatabase.com;Database=sql12840087;User ID=sql12840087;Password=uebaM9hCwP;");
            string sql = $"SELECT * FROM tbuser WHERE fullName='{txtUserName.Text}' and Password='{txtPassword.Text}'";
            MySqlCommand cm = new MySqlCommand(sql, cn);
            cn.Open();
            MySqlDataReader dr = cm.ExecuteReader();

            if (dr.HasRows)
            {
                var fm = new frmMain();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            cn.Close();
        }
    }
}
