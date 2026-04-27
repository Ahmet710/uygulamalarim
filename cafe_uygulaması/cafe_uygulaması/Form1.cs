using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_uygulaması
{
    public partial class DEMIR_CAFE : Form
    {
        /* money */

        int money = 1000;

        /* foods */

        int cheese = 120;
        int cupcake = 50;
        int hamburger = 100;
        int hotdog = 80;
        int pancake = 50;
        int pizza = 100;

        /*total price*/

        int harcananpara = 0;

        public DEMIR_CAFE()
        {
            InitializeComponent();
        }

        private void DEMIR_CAFE_Load(object sender, EventArgs e)
        {
            lblmoney.Text = money.ToString() + "₺";
        }


        private void pboxcheese_Click(object sender, EventArgs e)
        {
            harcananpara += cheese;
            sepetlistbox.Items.Add("Cheese");

        }

        private void pboxcupcake_Click(object sender, EventArgs e)
        {
            harcananpara += cupcake;
            sepetlistbox.Items.Add("Cupcake");
        }

        private void pboxhamburger_Click(object sender, EventArgs e)
        {
            harcananpara += hamburger;
            sepetlistbox.Items.Add("Hamburger");
        }

        private void pboxhotdog_Click(object sender, EventArgs e)
        {
            harcananpara += hotdog;
            sepetlistbox.Items.Add("Hotdog");
        }

        private void pboxpancake_Click(object sender, EventArgs e)
        {
            harcananpara += pancake;
            sepetlistbox.Items.Add("Pancake");
        }

        private void pboxpizza_Click(object sender, EventArgs e)
        {
            harcananpara += pizza;
            sepetlistbox.Items.Add("Pizza");
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            if (money <= money & money > 0)
            {
                money = money - harcananpara;

                lblmoney.Text = money.ToString() + "₺";

                MessageBox.Show("Alışveriş yaptığınız için teşekkür ederiz!","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Paranız yetersiz...","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn200para_Click(object sender, EventArgs e)
        {
            money += 200;
            lblmoney.Text = money.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money += 2000;
            lblmoney.Text = money.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sepetlistbox.Items.Clear();
            harcananpara = 0;
        }

        private void btn500para_Click(object sender, EventArgs e)
        {
            money += 500;
            lblmoney.Text = money.ToString();
        }

        private void btn1000para_Click(object sender, EventArgs e)
        {
            money += 1000;
            lblmoney.Text = money.ToString();
        }
    }
}
