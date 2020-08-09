using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5_task3
{
    public partial class _3_count : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["count"] = 0;
                Label1.Text = "Click on me";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["count"] = int.Parse(ViewState["count"].ToString()) + 1;
            Label1.Text = "Count is " + ViewState["count"]; 
        }
    }
}