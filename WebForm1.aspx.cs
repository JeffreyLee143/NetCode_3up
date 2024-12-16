using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int cnt;
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            if (Application["count"] != null)
            {
                cnt = (int)Application["count"];
            }
            else
            {
                cnt = 0;
            }
            cnt = cnt + 1;
            Application["count"] = cnt;
            Application.UnLock();
            Label1.Text = cnt.ToString();
        }
    }
}