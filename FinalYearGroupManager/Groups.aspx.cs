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
    public partial class Groups : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-79L809E;Initial Catalog=SeProject;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string com = "Select * FROM [groups]";
                SqlCommand cmdd = new SqlCommand(com, con);
                SqlDataReader dr = cmdd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
            catch
            {
                lblStatus.Text = "unable to read data";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into [groups] ([groupName]) values('" + TextBox1.Text + "')", con);
                //SqlCommand cmd = new SqlCommand("Insert INTO [QuizDB].[dbo].[inputDataTable] ([name]) VALUES ('"+name+"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                if (con.State == ConnectionState.Open)
                    con.Close();
                try
                {
                    con.Open();
                    string com = "Select * FROM [groups]";
                    SqlCommand cmdd = new SqlCommand(com, con);
                    SqlDataReader dr = cmdd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
                catch
                {
                    lblStatus.Text = "unable to read data";
                }
            }
            catch
            {
                lblStatus.Text = "unable to insert project";
            }
        }
    }
}