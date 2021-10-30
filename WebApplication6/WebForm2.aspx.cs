using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = 15;
            s2 = 7;
            Response.Write("S1 değişkeni: "+s1 + "<br>");
            Response.Write("S2 değişkeni: " + s2 + "<br>");
            Response.Write("s1 değişkeninin mod 3 karşılığı: " + (s1 % 3) + "<br>");
            Response.Write("s2 değişkeninin mod 2 karşılığı:" + (s2 % 2) + "<br>");
            Response.Write("s1+s2 toplamının mod 4 karşılığı: " + (s1 + s2) % 4 + "<br>");

        }
    }
}