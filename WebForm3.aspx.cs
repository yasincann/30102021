using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        double s1, s2, son;

        protected void Button3_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(TextBox1.Text);
            sonuc.Text =Math.Round(s1).ToString();
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(TextBox1.Text);
            son = Math.Abs(s1);
            sonuc.Text = son.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(TextBox1.Text);
            sonuc.Text = Math.Round(s1).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            s1 = Convert.ToInt32(TextBox1.Text);
            s2 = Convert.ToInt32(TextBox2.Text);
            son = Math.Max(s1, s2);
            sonuc.Text = son.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(TextBox1.Text);
            s2 = Convert.ToInt32(TextBox2.Text);
            son = Math.Min(s1, s2);
            sonuc.Text = son.ToString();
        }

    }
}