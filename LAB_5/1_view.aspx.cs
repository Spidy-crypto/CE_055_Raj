using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5_task1
{
    public partial class _1_view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            HttpCookie cookie = Request.Cookies["mycookie"];
            if(cookie == null)
            {
                Label1.Text = "No cookie available";
            }
            else
            {
                Label1.Text = "Name is "+cookie["username"];
                Label2.Text = "State is "+cookie["state"];
                Label3.Text = "City is "+cookie["city"];
                Label4.Text = "mobile number is "+cookie["mobile"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["mycookie"].Expires = DateTime.Now.AddYears(-1);
            Response.Redirect("1_home.aspx");
        }
    }
}