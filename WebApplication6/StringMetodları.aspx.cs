using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<table border=\"1\"><tr><td></td></tr></table>");  // kaçış karakteri kullanıp response.write komutu içine html tablosu gömdük.
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string metin;

            metin = TextBox1.Text;
            Label1.Text = metin.Length.ToString();              //Textbox'a girilen değerleri birleştirir
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text=TextBox1.Text.ToUpper();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text.ToLower();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = string.Concat(TextBox1.Text, TextBox2.Text);  //iki textbox'taki metinleri birleştirir.
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string yazi = TextBox1.Text;
            string yazi1 = TextBox2.Text;
            string adsoyad = $"Ad Soyad {yazi} {yazi1}";   // f string(Python) işlevi görür.
            Label1.Text = adsoyad;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string yazi = TextBox1.Text;
            Label1.Text = yazi[4].ToString();  //textbox1'deki i. harfi yazdırır.
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            int index;
            string yazi = TextBox1.Text;
            index = yazi.IndexOf('a');      // Girilen metinde a'nın kaçıncı indexte olduğunu verir.
            Label1.Text = index.ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string veri;
            veri = Label2.Text.Substring(7,5);      //7. indisten itibaren 5 karakter alır.
            Label1.Text = veri;
        }

        // \ kaçış karakteri olarak kullanılır.
    }
}