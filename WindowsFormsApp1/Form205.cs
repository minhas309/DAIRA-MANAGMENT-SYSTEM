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


    public partial class Form205 : Form
    {
        public Form205()
        {
            InitializeComponent();
        }

        OracleConnection con = new OracleConnection(@"DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\\Users\\SOFTAGE\\Oracle\\network\\admin;USER ID=SYSTEM;Password = system; DATA SOURCE=Hamza");
        void display()
        {
            con.Open();
            string myquery = "select * from daira.stock";
            OracleDataAdapter da = new OracleDataAdapter(myquery, con);
            OracleCommandBuilder builder = new OracleCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            grid.DataSource = ds.Tables[0];
            con.Close();

        }

        private void Form205_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            display();

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

        private void pictureBox3_Click_1(object sender, EventArgs e)
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

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
  
}
