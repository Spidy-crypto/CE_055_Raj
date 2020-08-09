using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB5_task4
{
    public partial class _4_WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page prev = Page.PreviousPage;
            if(PreviousPage != null)
            {
                TextBox tb = new TextBox();
                tb = (TextBox)(PreviousPage.FindControl("uname"));
                Label1.Text = tb.Text;
                tb = (TextBox)(PreviousPage.FindControl("city"));
                Label2.Text = tb.Text;
            }
        }
    }
}