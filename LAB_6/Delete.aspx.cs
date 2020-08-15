using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Configuration;

namespace Lab6_task1
{
    public partial class Delete : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
            }
            catch (Exception err)
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
                    string command = "DELETE from Student where uid='" + sid.Text + "' ";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        Response.Redirect("ask.aspx?msg=Your data Deleted Successfully");
                    }
                    else
                    {
                        Label1.Text = "Id not availabele";
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
        }
    }
}