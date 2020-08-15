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
    public partial class Edit : System.Web.UI.Page
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

        protected void fetch_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    string command = "select * from Student where uid = '" + sid.Text + "' ";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        name.Text = rdr["name"].ToString();
                        sem.Text = rdr["sem"].ToString();
                        mobileno.Text = rdr["mobile_no"].ToString();
                        emailid.Text = rdr["email_id"].ToString();
                    }
                    rdr.Close();
                }
            }
            catch(Exception err)
            {
                Response.Write(err.Message);
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    string command = "UPDATE Student set name = @name, sem = @sem, mobile_no = @mobile_no, email_id = @email_id where uid='" + sid.Text + "' " ;
                    cmd = new SqlCommand(command, con);
                    con.Open(); 
                    cmd.Parameters.Add("@name", name.Text);
                    cmd.Parameters.Add("@sem", int.Parse(sem.Text));
                    cmd.Parameters.Add("mobile_no", mobileno.Text);
                    cmd.Parameters.Add("@email_id", emailid.Text);
                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        Response.Redirect("ask.aspx?msg=Your data updated Successfully");
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