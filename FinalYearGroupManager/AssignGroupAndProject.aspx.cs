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
    public partial class AssignGroupAndProject : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-79L809E;Initial Catalog=SeProject;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            //load data in to dropdown student list
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                string com = "SELECT TOP (1000) [id],[name] FROM [user] where id=1";//only students
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
            
            
            
            //load data in borh dropdown group list
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                string com = "SELECT TOP (1000) [groupName] ,[id] FROM [groups]";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList3.DataSource = dt;
                DropDownList3.DataBind();
                DropDownList3.DataTextField = "groupName";
                DropDownList3.DataValueField = "id";
                DropDownList3.DataBind();
                DropDownList2.DataSource = dt;
                DropDownList2.DataBind();
                DropDownList2.DataTextField = "groupName";
                DropDownList2.DataValueField = "id";
                DropDownList2.DataBind();
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
            
            
            
            //load data in to dropdown Project list
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                string com = "SELECT TOP (1000) [projectName],[id] FROM[Projects]";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList4.DataSource = dt;
                DropDownList4.DataBind();
                DropDownList4.DataTextField = "projectName";
                DropDownList4.DataValueField = "id";
                DropDownList4.DataBind();
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}