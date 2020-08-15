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
    public partial class Order : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
                using (con)
                {
                    string str = "";
                    int total = 0;
                    string command = "Select [Order].oid,[Product].pid,[Product].pname,[Product].cost from [Order] inner join [Product] on [Order].pid = [Product].pid where [Order].userid = '"+ Session["username"] + "'";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        str += "Order id is :-"+ rdr["oid"] + "<br>Product Id is :- " + rdr["pid"] + "<br>Product name is :- " + rdr["pname"] + "<br> Cost :- "+ rdr["cost"] + "<br><br>";
                        total += int.Parse(rdr["cost"].ToString());
                    }
                    Label1.Text = "Your Order Details";
                    Label2.Text = str + "Total Cost is :- " + total.ToString();
                    rdr.Close();
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
        }
    }
}