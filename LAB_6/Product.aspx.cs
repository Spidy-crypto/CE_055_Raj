using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Configuration;

namespace LAB6_task2
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
                using (con)
                {
                    int res;
                    con.Open();
                    foreach (string s in Session.Keys)
                    {
                        if (s != "username")
                        {
                            string command = "INSERT INTO [Order] (userid,pid) VALUES (@uid1,@pid1)";
                            cmd = new SqlCommand(command, con);
                            cmd.Parameters.AddWithValue("@uid1", Session["username"].ToString());
                            cmd.Parameters.AddWithValue("@pid1", Session[s].ToString());
                            res = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
           Response.Redirect("Order.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    Session[li.Text] = li.Value;
                }
            }
        }
    }
}