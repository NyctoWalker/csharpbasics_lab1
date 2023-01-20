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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if ((t_fname.TextLength > 1 && t_fname.TextLength < 21) &&
                (t_sname.TextLength > 1 && t_sname.TextLength < 21) &&
                (t_tname.TextLength > 1 && t_tname.TextLength < 21) &&
                (t_adress.TextLength > 4 && t_adress.TextLength < 31))
            {
                Form1.fobj.lobj.Items.Insert(1, new Consumer(t_fname.Text, t_sname.Text, t_tname.Text, t_adress.Text));
                this.Close();
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Пожалуйста, проверьте соответствие введённых данных условиям.", "Добавление покупателя");
            }
        }
    }
}
