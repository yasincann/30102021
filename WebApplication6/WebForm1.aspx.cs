using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = TextBox1.Text;
            soyad = TextBox2.Text;
            int yas;
            yas = Convert.ToInt16(TextBox3.Text);
            Response.Write("Adınız: " + ad+"<br>Soyadınız: "+soyad+"<br>Yaşınız: "+yas);
        }
    }
}