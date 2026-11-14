using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14.user
{
    public partial class frmUserLIst : Form
    {
        public frmUserLIst()
        {
            InitializeComponent();
        }

        private void frmUserLIst_Load(object sender, EventArgs e)
        {
            var con = new MySqlConnection("Server=sql12.freesqldatabase.com;Database=sql12840087;User ID=sql12840087;Password=uebaM9hCwP;");
            var sql = "SELECT * FROM tbuser";
            var com = new MySqlCommand(sql, con);
            var da = new MySqlDataAdapter(com);
            var dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;

        }
    }
}
