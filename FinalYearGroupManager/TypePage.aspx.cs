using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalYearGroupManager
{
    public partial class AddUserForm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-79L809E;Initial Catalog=SeProject;Integrated Security=True");
        
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbType.Text.Trim()!="")
            {
                //insert
                if (con.State == ConnectionState.Closed)
                    con.Close();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert INTO userType ([type]) VALUES ('"+ tbType.Text +"')", con);
                    //SqlCommand cmd = new SqlCommand("Insert INTO [QuizDB].[dbo].[inputDataTable] ([name]) VALUES ('"+name+"')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch
                {
                    lblStatus.Text = "Type is unable to insert an error ouccered";
                }
            }
            else
            {
                lblStatus.Text = "enter type name";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Server.Transfer("DataEntryPage.aspx");
        }
    }
}