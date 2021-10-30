using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class Operatorler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, son;
            sayi1 = Convert.ToInt32(TextBox1.Text);
            sayi2 = Convert.ToInt32(TextBox2.Text);
            son = sayi1 + sayi2;
            sonuc.Text = Convert.ToString(son);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, son;
            sayi1 = Convert.ToInt32(TextBox1.Text);
            sayi2 = Convert.ToInt32(TextBox2.Text);
            son = sayi1 - sayi2;
            sonuc.Text = Convert.ToString(son);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, son;
            sayi1 = Convert.ToInt32(TextBox1.Text);
            sayi2 = Convert.ToInt32(TextBox2.Text);
            son = sayi1 * sayi2;
            sonuc.Text = Convert.ToString(son);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, son;
            sayi1 = Convert.ToInt32(TextBox1.Text);  //textboxlara girilen değer ondalıklı olacaksa, float veya double olarak tanımlanmalıdır.
            sayi2 = Convert.ToInt32(TextBox2.Text);
            son = sayi1 / sayi2;
            sonuc.Text = Convert.ToString(son);
        }
    }
}