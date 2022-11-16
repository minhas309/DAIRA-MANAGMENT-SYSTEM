using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class SUPERLOGIN : Form
    {
        public SUPERLOGIN()
        {
            InitializeComponent();
        }

        OracleConnection con = new OracleConnection(@"DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\SOFTAGE\\Oracle\\network\\admin;USER ID=SYSTEM;Password=system;DATA SOURCE=Hamza");

        private void SUPERLOGIN_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleDataAdapter oqa = new OracleDataAdapter("Select COUNT(*) From daira.Super_Admin where username ='" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            oqa.Fill(dt);
            if (dt.Rows[0][0].ToString() == "admin" && dt.Rows[0][1].ToString() == "admin")
            {

                this.Hide();
                Form20 f = new Form20();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");
            }
            con.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Start f = new Start();
            this.Hide();
            f.ShowDialog();
        }
    }
}
