using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace zaliczeniowy1
{
    public partial class Form1 : Form
    {

        List<Gift> gifts = new List<Gift>();
        public class Gift
        {
            public string Name { get; set; }
            public string Item { get; set; }
            public int Price { get; set; }

            public Gift(string name, string item, int price)
            {
                Name = name;
                Item = item;
                Price = price;

            }



            public string toString()
            {
                return "Imie: " + Name + " Przedmiot: " + Item + " Cena: " + Price;
            }

        }

        public void Clear()
        {
            nameTB.Clear();
            giftTB.Clear();
            priceTB.Clear();

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void giftTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void createBT_Click(object sender, EventArgs e)
        {
            Gift gift = new Gift(nameTB.Text,giftTB.Text,Int32.Parse(priceTB.Text));
            gifts.Add(gift);
            Clear();

        }

        private void button1_Click(object sender, EventArgs e) //show
        {
            giftsLIST.Items.Clear();
            int allprice=0;
            foreach( var g in gifts)
            {
                giftsLIST.Items.Add(g.toString());
            }

            allprice = gifts.Sum(g => g.Price);

            allpriceLB.Text = "laczna kwota: "+allprice;
            giftsCountLB.Text = "ilosc prezentow:" + gifts.Count;

        }
    }
}
