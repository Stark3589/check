using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class User_Default5 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        //DataTable dt = ob.dttt("select a.username,a.dateofjoin,a.rtime,a.name,a.reffid,a.onside,a.status,b.username as sponser from register a,direct b where a.username=b.direct and a.status='active' order by a.username ASC");
        //GridView2.DataSource = dt;
        //GridView2.DataBind();

        DataTable dt2 = ob.dttt("select a.username,a.dateofjoin,a.rtime,a.name,a.reffid,a.onside,a.status,b.sponser from register a,sponser b where a.status='active' and a.username=b.username order by id asc");
        GridView2.DataSource = dt2;
        GridView2.DataBind();

        string date = System.DateTime.UtcNow.Year.ToString() + "-" + System.DateTime.UtcNow.Month.ToString() + "-" + System.DateTime.UtcNow.Day.ToString();

        DataTable tot = ob.dttt("select count(username) from register where dateofjoin!='" + date + "'");
        Label1.Text = tot.Rows[0][0].ToString();

        DataTable tot1 = ob.dttt("select count(username) from register where dateofjoin='" + date + "'");
        Label4.Text = tot1.Rows[0][0].ToString();

        DataTable tot2 = ob.dttt("select count(status) from register where status ='active'");
        Label21.Text = tot2.Rows[0][0].ToString();
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Cancel")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;

            //lblusername.Text = Convert.ToString(lnkView.CommandArgument);
            string st = Convert.ToString(lnkView.CommandArgument);
            Session["username"] = st;
            Response.Redirect("Details.aspx");
        }
    }
}