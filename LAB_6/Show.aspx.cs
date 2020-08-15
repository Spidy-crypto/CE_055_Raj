using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Configuration;
using System.Data;

namespace Lab6_task1
{
    public partial class Show : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
                string command = "select * from Student";
                cmd = new SqlCommand(command,con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                using (con)
                {
                    con.Open();
                    da.Fill(ds, "Student");
                }
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
            }
            GridView1.DataSource = ds.Tables["Student"];
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ask.aspx");
        }
    }
}