using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCJV
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l, final;
            string tipo;

            l = Convert.ToDouble(txtqtd.Text);
            tipo = Convert.ToString(txttipo.Text);

            if (tipo.Equals("A"))
            {
                if (l > 20)
                {
                    final = l * (4.30 - (4.30 * 5 / 100));
                    txtfinal.Text = final.ToString();
                }

                else

                {
                    final = l * (4.30 - (4.30 * 3 / 100));
                    txtfinal.Text = final.ToString();
                }
            }
            else if (tipo.Equals("G"))
            {
                if (l > 20)
                {
                    final = l * (5.50 - (5.50 * 6 / 100));
                    txtfinal.Text = final.ToString();
                }

                else

                {
                    final = l * (5.30 - (5.30 * 4 / 100));
                    txtfinal.Text = final.ToString();
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtqtd.Clear();
            txttipo.Clear();
            txtfinal.Clear();

            txtqtd.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
