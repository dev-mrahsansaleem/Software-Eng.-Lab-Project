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
    public partial class DataEntryPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-79L809E;Initial Catalog=SeProject;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                string com = "Select * FROM [user]";
                SqlCommand cmdd = new SqlCommand(com, con);
                SqlDataReader dr = cmdd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
            catch
            {
                lblStatus.Text = "unable to read and view data";
            }



            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                con.Open();
                string com = "Select * FROM userType";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.DataTextField = "type";
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {
                string com = "insert into [user] ([name],[roll no],[Section],[typeId],[GroupId],[projectId]) values('" + tbName.Text + "','" + tbrollno.Text + "','" + tbSection.Text + "','" + DropDownList1.SelectedValue + "','-1','-1')";
                con.Open();
                SqlCommand cmd = new SqlCommand(com, con);
                //SqlCommand cmd = new SqlCommand("Insert INTO [QuizDB].[dbo].[inputDataTable] ([name]) VALUES ('"+name+"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                if (con.State == ConnectionState.Open)
                    con.Close();
                try
                {
                    con.Open();
                    com = "Select * FROM [user]";
                    SqlCommand cmdd = new SqlCommand(com, con);
                    SqlDataReader dr = cmdd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
                catch
                {
                    lblStatus.Text = "unable to read and view data";
                }

                
            }
            catch
            {
                lblStatus.Text = "unable to insert user";
            }
            
            /*
            con.Open();
            string com = "Select * FROM userType";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "type";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            //data grid view
            con.Open();
            string com = "Select * FROM userType";
            SqlCommand cmdd = new SqlCommand(com, con);
            SqlDataReader dr = cmdd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            */
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)//onclick event
        {
            //Server.Transfer("Group Info.aspx");
            /*
            lblStatus.Text = "wqeqwe";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            */
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Group Info.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Projects.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // transfer data form current to next page
            Response.Redirect("Group Info.aspx?studName=" + GridView1.SelectedRow.Cells[2].Text + "&rollNo=" + GridView1.SelectedRow.Cells[3].Text + "&groupid=" + GridView1.SelectedRow.Cells[6].Text + "&productid=" + GridView1.SelectedRow.Cells[7].Text);
        }
    }
}