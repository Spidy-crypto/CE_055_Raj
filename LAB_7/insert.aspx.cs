﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_task4
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbcontext = new DataClasses1DataContext())
            {
                Student stu = new Student
                {
                    name = TextBox1.Text,
                    sem = TextBox2.Text,
                    cpi = TextBox3.Text,
                    contactno = TextBox4.Text,
                    emailid = TextBox5.Text
                };
                dbcontext.Students.InsertOnSubmit(stu);
                dbcontext.SubmitChanges();
            }
        }
    }
}