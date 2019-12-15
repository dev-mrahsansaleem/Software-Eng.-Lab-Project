using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalYearGroupManager
{
    public partial class Group_Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get data from pre form and show it on labl
            Label10.Text = Request.QueryString["studName"].ToString();
            Label11.Text = Request.QueryString["rollNo"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}