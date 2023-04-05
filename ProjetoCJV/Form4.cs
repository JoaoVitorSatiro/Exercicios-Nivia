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
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int num, x, i;

            num = Convert.ToInt32(txtnumero.Text);

            for (i = 0; i <= 10; i++)
            {
                x = num * i;
                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", x.ToString());
            }
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtresultado.Clear();

            txtnumero.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
