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
    public partial class Group_Info : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-79L809E;Initial Catalog=SeProject;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                string com = "SELECT [id],[name] FROM [SeProject].[dbo].[user]";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                /*
                //data grid view
                SqlCommand cmdd = new SqlCommand(com, con);
                SqlDataReader dr = cmdd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();*/
            }
            catch
            {
                lblStatus.Text = "unable to load data in dropdown";
            }
            //get data from pre form and show it on labl
            try
            {
                Label2.Text = Request.QueryString["groupid"].ToString();
                Label10.Text = Request.QueryString["studName"].ToString();
                Label11.Text = Request.QueryString["rollNo"].ToString();
            }
            catch
            {
                lblStatus.Text = "unable to Read Query String";
            }

        }

        protected void Button1_Click(object sender, EventArgs e) //add a student to a group
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                int tep = Convert.ToInt32(DropDownList1.SelectedValue);
                tep = tep + 1;
                con.Open();
                string com = "update [user] set groupId = '" + Label2.Text + "' where id = '" + tep.ToString() + "'";
                SqlCommand cmd = new SqlCommand(com, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                lblStatus.Text = "unable to update student's group id";
            }


            if (Label2.Text != "-1")//if there is some group id
            {
                //update selected (in dropdown list) student's group id to the selected student's group id;

            }
            else
            {
                lblStatus.Text = "there is no group exist for selected student add assign a gorup to selected student to add more members";
            }
        }
    }
}