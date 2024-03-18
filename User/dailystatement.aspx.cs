using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class User_dailystatement : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = ob.dsss("select username from register");
        GridView2.DataSource = ds;
        GridView2.DataBind();
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Cancel")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;

            //lblusername.Text = Convert.ToString(lnkView.CommandArgument);
            string st = Convert.ToString(lnkView.CommandArgument);
            Session["username"] = st;
           
            DataSet ds = ob.dsss("select * from dailyrecord where username='" + st + "' and total>0");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}