using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_task4
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbcontext = new DataClasses1DataContext())
            {
                Student stu = dbcontext.Students.SingleOrDefault(x => x.sid == int.Parse(TextBox6.Text));
                dbcontext.Students.DeleteOnSubmit(stu);
                dbcontext.SubmitChanges();
            }
        }
    }
}