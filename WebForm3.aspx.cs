using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random rr = new Random();
            int a;
            a = rr.Next(1,7);
            switch (a)
            {
                case 1:
                    Image1.ImageUrl = "image/OIP.jpg";
                    break;
                case 2:
                    Image1.ImageUrl = "image/OIP1.jpg";
                    break;
                case 3:
                    Image1.ImageUrl = "image/OIP2.jpg";
                    break;
                case 4:
                    Image1.ImageUrl = "image/OIP3.jpg";
                    break;
                case 5:
                    Image1.ImageUrl = "image/OIP4.jpg";
                    break;
                    
            }
        }
    }
}