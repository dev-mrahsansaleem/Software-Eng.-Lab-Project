﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalYearGroupManager
{
    public partial class Projects : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-79L809E;Initial Catalog=SeProject;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string com = "Select * FROM [Projects]";
                SqlCommand cmdd = new SqlCommand(com, con);
                SqlDataReader dr = cmdd.ExecuteReader();
                Project_List.DataSource = dr;
                Project_List.DataBind();
            }
            catch
            {
                lblStatus.Text = "unable to read datacon load";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)// add new project to data base
        {
            lblStatus.ForeColor = System.Drawing.Color.Red;
            if (con.State == ConnectionState.Open)
                con.Close();
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into [Projects] ([projectName],[ProjectDes]) values('" +TextBox1.Text + "','" + TextBox2.Text + "')", con);
                //SqlCommand cmd = new SqlCommand("Insert INTO [QuizDB].[dbo].[inputDataTable] ([name]) VALUES ('"+name+"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                if (con.State == ConnectionState.Open)
                    con.Close();
                try
                {
                    con.Open();
                    string com = "Select * FROM [Projects]";
                    SqlCommand cmdd = new SqlCommand(com, con);
                    SqlDataReader dr = cmdd.ExecuteReader();
                    Project_List.DataSource = dr;
                    Project_List.DataBind();
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

        protected void Project_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Project_List.SelectedRow.Cells[0];  //delete cell index
            //Project_List.SelectedRow.Cells[1];  //edit cell index
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("DataEntryPage.aspx");
        }
    }
}