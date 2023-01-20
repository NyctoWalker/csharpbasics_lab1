using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumer
{
    public class Consumer
    {

        private string _sname;
        public string sname {
            get { return _sname; }
            set {
                //if (!String.IsNullOrWhiteSpace(value))
                    _sname = value; 
            }
        }
        public string fname, tname, adress; //ИО, адрес
        public int lcard, consumerid; //Номер карты лояльности, стоимость выбранных товаров, ID пользователя
        public double discount; //Скидка
        static public int consumercount=0; //

        public Consumer(string fname, string sname, string tname, string adress)
        {
            this.fname = fname;
            this.sname = sname;
            this.tname = tname;
            this.adress = adress;
            lcard = -1;
            discount = 0;
            consumerid = consumercount;

            consumercount++;
        }

        void GiveLcard()
        {
            if (this.lcard==-1)
                this.lcard = 1;
        }

        void ChangeDiscount(double discount)
        {
            if (this.lcard == 1)
            {
                this.discount = discount;
            }
        }

        public double CalculateSum(double sum)
        {
            return (sum * (1 - (discount / 100)));
        }

        public void GetParams(out string ffname, out string ssname, 
                        out string ttname, out string aadress,
                        out int llcard, out double ddiscount, out int cconsumerid)
        {
            ffname = fname;
            ssname = sname;
            ttname = tname;
            aadress = adress;
            llcard = lcard;
            ddiscount = discount;
            cconsumerid = consumerid;
        }
    }
}
