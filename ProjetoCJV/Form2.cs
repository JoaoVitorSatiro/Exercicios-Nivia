using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCJV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int i, num, x;

            num = Convert.ToInt32(txtcal.Text);
            i = Convert.ToInt32(txtcal.Text);

            i = 1;

            while(i < 10)
            {
                x = num * i;
                txtres.Text = String.Concat(txtres.Text, "\r\n", x.ToString());
                i++;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcal.Clear();
            txtres.Clear();

            txtcal.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
