using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5_task1
{
    public partial class _1_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void vc_Click(object sender, EventArgs e)
        {
            Response.Redirect("1_view.aspx");
        }

        protected void cc_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("mycookie");
            cookie["username"] = uname.Text;
            cookie["state"] = state.Text;
            cookie["city"] = city.Text;
            cookie["mobile"] = mno.Text;
            Response.Cookies["mycookie"].Expires = DateTime.Now.AddYears(2);
            Response.Cookies.Add(cookie);
         }
    }
}