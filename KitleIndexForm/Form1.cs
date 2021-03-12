using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitleIndexForm
{
    public partial class KitleIndexHesaplama : Form
    {
        public KitleIndexHesaplama()
        {
            InitializeComponent();
        }

       void VkiHesapla(double b,double k)
        {
            double vki = ((k / Math.Pow(b, 2)))*10000;
            lblVkiSonuc.Text = Math.Ceiling(vki).ToString();
          
            if (vki < 18)
            {
                lblDurum.Text = "Zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                lblDurum.Text = "İdeal";
            }

            else if (vki >= 25 && vki < 30)
            {
                lblDurum.Text = "Kilolu";
            }

            else
            {
                lblDurum.Text = "Obez";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo;
            boy = Convert.ToDouble(textBoy.Text);
            kilo = Convert.ToDouble(textKilo.Text);        
            VkiHesapla(boy, kilo);
           
        }
    }
}
