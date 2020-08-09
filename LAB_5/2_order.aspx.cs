using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace LAB5_task2
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "";
            int total = 0;
            foreach(string s in Session.Keys)
            {
                if(s != "user"){
                    str += s + " " + Session[s] + "<br>";
                    total += int.Parse(Session[s].ToString());
                }
            }
            str += "Total " + total;
            temp.Text = str;
        }
    }
}