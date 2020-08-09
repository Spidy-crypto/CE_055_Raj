using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB5_task2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            String username = uname.Text;
            String password = passwd.Text;
            if(username == "admin" && password == "admin")
            {
                Session["user"] = username;
                Response.Redirect("2_home.aspx");
            }
        }
    }
}