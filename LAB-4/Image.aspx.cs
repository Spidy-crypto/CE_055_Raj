using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4_task2
{
    public partial class Image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view_Click(object sender, EventArgs e)
        {
            img1.Visible = !img1.Visible;
            if (img1.Visible)
            {
                view.Text = "Hide";
            }
            else
            {
                view.Text = "view";
            }
        }
    }
}