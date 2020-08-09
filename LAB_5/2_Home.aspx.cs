using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB5_task2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ulabel.Text = "Welcome " + Session["user"];
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue.Equals("books"))
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add(new ListItem("The alchemist", "500"));
                ListBox1.Items.Add(new ListItem("shiva trilogy", "600"));
                ListBox1.Items.Add(new ListItem("Anna Karenina", "1350"));
                ListBox1.Items.Add(new ListItem("The Great Gatsby", "2350"));
                ListBox1.Items.Add(new ListItem("Invisible Man", "350"));

            }
            else if (RadioButtonList1.SelectedValue.Equals("Electronics"))
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add(new ListItem("Laptop", "50000"));
                ListBox1.Items.Add(new ListItem("Phone", "10000"));
                ListBox1.Items.Add(new ListItem("Pen drive", "550"));
                ListBox1.Items.Add(new ListItem("OTG", "20"));
                ListBox1.Items.Add(new ListItem("Charger", "200"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("2_order.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    Session[li.Text] = li.Value;
                }
            }
        }
    }
}