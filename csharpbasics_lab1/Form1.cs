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
    public partial class Form1 : Form
    {
        public static Form1 fobj;
        public ListBox lobj;
        public Form1()
        {
            InitializeComponent();
            fobj = this;
            lobj = listBox1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lobj.Location = new Point(10, 35);
            lobj.Size = new Size(290, 320);
            lobj.DisplayMember = "sname";
            lobj.ValueMember = "consumerid";
            lobj.Items.Insert(0, new Consumer("Директор", "Директорович", "Директориченко", "Офис") { lcard = 1, discount = 99});
            lobj.Items.Insert(1, new Consumer("Геральт", "Ривский", "---", "Ривия, дом 5"));
            lobj.Items.Insert(1, new Consumer("Телефон", "Аппаратович", "Индустриальный", "Операторская на улице Пушкина") {lcard = 1, discount = 5 });
            lobj.Items.Insert(1, new Consumer("Жук", "Палочников", "Хитинович", "Ветка"));

            /*FlowLayoutPanel clist = flowLayoutPanel1;
            clist.Location = new Point(10, 35);
            clist.Size = new Size(290, 320);
            clist.AutoScroll = true;
            clist.WrapContents = true;
            clist.BorderStyle = BorderStyle.FixedSingle;
            clist.Controls.Add(new RadioButton() { Text = "Директор Директорович", Size = new Size(280, 20), Checked = true });
            clist.Controls.Add(new RadioButton() { Text = "RadioBadgadgadgagadgadgadgadgadgutton", Size = new Size(280, 20) });
            clist.Controls.Add(new RadioButton() { Text = "RadioButton", Size = new Size(280, 20) });
            //this.Controls.Add(clist);*/

            CheckedListBox plist = checkedListBox1;
            plist.Location = new Point(320, 35);
            plist.Size = new Size(250, 330);
            plist.CheckOnClick = true;
            plist.DisplayMember = "Text";
            plist.ValueMember = "Value";
            plist.Items.Insert(0, new Product { Text = "Арондит", Value = 9999 });
            plist.Items.Insert(1, new Product { Text = "Will 'o wisp", Value = 6900 });
            plist.Items.Insert(2, new Product { Text = "100 platinum", Value = 1000 });
            plist.Items.Insert(3, new Product { Text = "SILVER PLATE (fake)", Value = 150 });
            plist.Items.Insert(4, new Product { Text = "\"Хильки\" Stamina Royale", Value = 5000 });
            plist.Items.Insert(5, new Product { Text = "Укулеле", Value = 2000 });
            plist.Items.Insert(6, new Product { Text = "Металлическая шестерня марки \"Солид\"", Value = 400 });
            plist.Items.Insert(7, new Product { Text = "Жвачка по рублю", Value = 5 });
            plist.Items.Insert(8, new Product { Text = "ВАЗ \"Буханка\"", Value = 20000 });
            plist.Items.Insert(9, new Product { Text = "Напиток \"Слёзы стажёра\"", Value = 250 });
            //this.Controls.Add(plist);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(lobj.SelectedIndex > -1))
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Сначала выберите покупателя для удаления", "Удаление покупателя");
            }

            if (lobj.Items.Count > 1)
            {
                lobj.Items.Remove(Form1.fobj.lobj.SelectedItem);
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Вы не можете удалить всех покупателей из списка.", "Удаление покупателя");
            }
        }

        private void b_calculatesum_Click(object sender, EventArgs e)
        {
            if (lobj.SelectedIndex > -1)
            {
                double sum = 0;
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    sum += ((checkedListBox1.Items[i] as Product).Value);
                }
                l_sumval.Text = (sum).ToString();
                l_discval.Text = ((Form1.fobj.lobj.SelectedItem) as Consumer).CalculateSum(sum).ToString();
            }
        }

        private void b_addconsumer_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
            //this.Hide();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_checkinfo_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.ShowDialog();
        }

        private void b_loyaltycard_Click(object sender, EventArgs e)
        {
            if (lobj.SelectedIndex > -1)
            {
                bool havecard = (((lobj.SelectedItem) as Consumer).lcard == 1);
                if (havecard)
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("У этого покупателя уже есть карта.", "Выдача карты");
                }
                else
                {
                    ((lobj.SelectedItem) as Consumer).lcard = 1;
                    ((lobj.SelectedItem) as Consumer).discount = 0;
                    MessageBox.Show("Карта была выдана!", "Выдача карты");
                }
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Выберите покупателя", "Выдача карты");
            }
        }

        private void b_changediscount_Click(object sender, EventArgs e)
        {
            if (lobj.SelectedIndex > -1)
            {
                bool havecard = (((lobj.SelectedItem) as Consumer).lcard == 1);
                if (havecard)
                {
                    Form a = new Form4();
                    a.ShowDialog();
                }
                else
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("У данного покупателя нет карты лояльности!", "Изменение скидки");
                }
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Выберите покупателя", "Изменение скидки");
            }
        }
    }
}
