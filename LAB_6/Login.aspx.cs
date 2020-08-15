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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
            }
            catch(Exception err)
            {
                Response.Write(err.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    string command = "select * from [User] where userid = '" + uname.Text + "' ";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Response.Write(uname.Text);
                        if(pswd.Text == rdr["password"].ToString())
                        {
                            Session["username"] = uname.Text;
                            Response.Redirect("Product.aspx");
                        }
                    }
                    rdr.Close();
                    Label1.Text = "Invalid UserId or Password";
                }
            }
            catch(Exception err)
            {
                Response.Write(err.Message);
            }
        }
    }
}