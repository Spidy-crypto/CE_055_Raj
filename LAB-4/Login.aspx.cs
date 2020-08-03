using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4_task2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ulogin_Click(object sender, EventArgs e)
        {
            string username = uname.Text;
            string password = upass.Text;
            if(username.Equals("admin") && password.Equals("admin"))
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                IC.Text = "Invalid credential";
            }
        }
    }
}