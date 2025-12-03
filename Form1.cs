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
        public class Gift
        {
            public string Name { get; set; }
            public string Item { get; set; }
            public int Price { get; set; }

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


    }
}
