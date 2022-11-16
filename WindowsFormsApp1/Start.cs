using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            SUPERLOGIN f = new SUPERLOGIN();
            this.Hide();
            f.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Formx f = new Formx();
            this.Hide();
            f.ShowDialog();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
