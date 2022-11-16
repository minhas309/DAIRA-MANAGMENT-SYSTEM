using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Formx : Form
    {
        public Formx()
        {
            InitializeComponent();
        }

        OracleConnection con = new OracleConnection(@"DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\SOFTAGE\\Oracle\\network\\admin;USER ID=SYSTEM;Password=system;DATA SOURCE=Hamza");


        private void Formx_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            con.Open();
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("minhas1412981@gmail.com", "Sdasdda"),
                EnableSsl = true,
            };
          
            OracleDataAdapter oqa = new OracleDataAdapter("Select COUNT(*) From daira.Admin where username ='" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            oqa.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                String email = dt.Rows[0].ToString();
                smtpClient.Send("email", email, dt.Columns[1].ToString(), dt.Columns[2].ToString());
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");
            }
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Start f = new Start();
            this.Hide();
            f.ShowDialog();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
