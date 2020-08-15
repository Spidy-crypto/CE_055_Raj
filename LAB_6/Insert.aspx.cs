using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Configuration;

namespace Lab6_task1
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = null; 
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
                using (con)
                {
                    string command = "INSERT INTO Student(uid,name,sem,mobile_no,email_id)VALUES(@uid,@name,@sem,@mobile_no,@email_id)";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@uid", uid.Text);
                    cmd.Parameters.AddWithValue("@sem", int.Parse(sem.Text));
                    cmd.Parameters.AddWithValue("@mobile_no", mobileno.Text);
                    cmd.Parameters.AddWithValue("@email_id", emailid.Text);
                    int res = cmd.ExecuteNonQuery();
                    if(res == 1)
                    {
                        Response.Redirect("ask.aspx?msg=Your data added Successfully");
                    }
                    else
                    {
                        Label1.Text = "Error Occure while inserting data";
                    }
                }
            }
            catch(Exception err)
            {
                Response.Write(err.Message);
            }
            finally
            {
                if(con != null)
                {
                    con.Dispose();
                }
                if(cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }
    }
}