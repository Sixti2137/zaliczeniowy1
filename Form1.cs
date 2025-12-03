using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void refresh()
        {
            giftsLIST.Items.Clear();
            int allprice = 0;
            foreach (var g in gifts)
            {
                giftsLIST.Items.Add(g.toString());
            }

            allprice = gifts.Sum(g => g.Price);

            allpriceLB.Text = "laczna kwota: " + allprice;
            giftsCountLB.Text = "ilosc prezentow:" + gifts.Count;

        }
        public Form1()
        {
         

            InitializeComponent();
        }

       

        private void createBT_Click(object sender, EventArgs e)
        {
            Gift gift = new Gift(nameTB.Text,giftTB.Text,Int32.Parse(priceTB.Text));
            gifts.Add(gift);
            Clear();
            refresh();
        

        }

        

        private void editBT_Click(object sender, EventArgs e)
        {
            nameTB.Text = gifts[giftsLIST.SelectedIndex].Name;
            giftTB.Text = gifts[giftsLIST.SelectedIndex].Item;
            priceTB.Text = gifts[giftsLIST.SelectedIndex].Price.ToString();


        }

        private void delete_Click(object sender, EventArgs e)
        {
            gifts.RemoveAt(giftsLIST.SelectedIndex);
            giftsLIST.Items.Remove(giftsLIST.SelectedIndex);
            refresh();
        }

        private void save_Click(object sender, EventArgs e)
        {
            gifts[giftsLIST.SelectedIndex].Name = nameTB.Text;
            gifts[giftsLIST.SelectedIndex].Item = giftTB.Text;
            gifts[giftsLIST.SelectedIndex].Price = int.Parse(priceTB.Text);
            refresh();
            Clear();
        }
    }
}
