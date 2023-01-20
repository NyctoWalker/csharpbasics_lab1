using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using consumer;

namespace csharpbasics_lab1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            double ddiscount = -1;
            try
            {
                ddiscount = -1;
                ddiscount = Convert.ToDouble((t_discount.Text));
            }
            catch(Exception exp)
            {
                MessageBox.Show("errror" +exp.ToString());
            }
            finally
            {
                if (ddiscount >= 0 && ddiscount <= 100)
                {
                    ((Form1.fobj.lobj.SelectedItem) as Consumer).discount = ddiscount;
                    this.Close();
                }
                else
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("Введите значение от 0 до 100", "Изменение скидки");
                }
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            t_discount.Text = (((Form1.fobj.lobj.SelectedItem) as Consumer).discount).ToString();
        }
    }
}
