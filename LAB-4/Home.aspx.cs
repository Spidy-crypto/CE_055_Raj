using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4_task2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (!(String.IsNullOrEmpty(passwd.Text.Trim())))
                {
                    passwd.Attributes["value"] = passwd.Text;
                }
                if (!(String.IsNullOrEmpty(passwd2.Text.Trim())))
                {
                    passwd2.Attributes["value"] = passwd2.Text;
                }
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.Equals("-1"))
            {
                DropDownList2.Items.Clear();
            }
            if (DropDownList1.SelectedValue.Equals("gj"))
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add(new ListItem("Ahmedabad", "Ahmedabad"));
                DropDownList2.Items.Add(new ListItem("Vadodara", "Vadodara"));
            }
            if (DropDownList1.SelectedValue.Equals("mh"))
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add(new ListItem("Mumbai", "Mumbai"));
                DropDownList2.Items.Add(new ListItem("Pune", "Pune"));
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs e)
        {
            string regstr = "[AB]\\d{9}";
            Regex reg = new Regex(regstr);
            if (reg.IsMatch(pnumber.Text))
            {
                e.IsValid = true;
            }
            else
            {
                pnumber.Text = "";
                e.IsValid = false;
            }
        }

        protected void reg_Click(object sender, EventArgs e)
        {
            NameL.Text = fname.Text;
            int age_ = int.Parse(age.Text);
            if (18 <= age_ && age_ <= 50)
            {
                AgeL.Text = age.Text;
            }
            GenderL.Text = RadioButtonList1.SelectedValue;
            MobileL.Text = number.Text;
            HobbieL.Text = " ";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    HobbieL.Text += CheckBoxList1.Items[i].Text + "\n";
                }
            }
            StateL.Text = DropDownList1.SelectedValue;
            CityL.Text = DropDownList2.SelectedValue;
            PanL.Text = pnumber.Text;
        }

        protected void img_Click(object sender, EventArgs e)
        {
            Response.Redirect("Image.aspx");
        }
    }
}