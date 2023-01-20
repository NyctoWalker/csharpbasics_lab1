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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string fname, sname, tname, adress;
            int lcard, consumerid;
            double discount;
            ((Form1.fobj.lobj.SelectedItem) as Consumer).GetParams(out fname, out sname, out tname, out adress, out lcard, out discount, out consumerid);

            t_fname.Text = fname;
            t_sname.Text = sname;
            t_tname.Text = tname;
            t_adress.Text = adress;
            t_ID.Text = consumerid.ToString();
            if (lcard == -1)
            {
                t_iscard.Text = "Нет";
                t_discount.Text = "-";
            }
            else
            {
                t_iscard.Text = "Да";
                t_discount.Text = discount.ToString();
            }
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
