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


    public partial class Form201 : Form
    {
        public Form201()
        {
            InitializeComponent();
        }

        OracleConnection con = new OracleConnection(@"DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\SOFTAGE\\Oracle\\network\\admin;USER ID=SYSTEM;Password=system;DATA SOURCE=Hamza");


        private void Form201_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form202 f = new Form202();
            f.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form20 f = new Form20();
            f.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form201 f = new Form201();
            f.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form203 f = new Form203();
            f.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form204 f = new Form204();
            f.ShowDialog();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form205 f = new Form205();
            f.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Start f = new Start();
            this.Hide();
            f.ShowDialog();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("insert into daira.admin(email,username,password,confirm_password,registration_no,contact_number) values ('" + txtEmail.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtConfirmPassword.Text + "','" + txtRegNo.Text + "','" + txtContactNumber.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Entered Successfully");
            con.Close();
        }
    }
  
}
