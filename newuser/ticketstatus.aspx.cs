using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class newuser_ticketstatus : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                string ticketid = Request.QueryString["ticketid"];
                Label3.Text = ticketid;
                DataTable dt2 = ob.dttt("select * from  ticket where username='" + Session["newuser"].ToString() + "' and ticketid='" + ticketid + "' ");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            catch (Exception hg) { };

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ob.Execute("insert into ticket values('" + Session["newuser"].ToString() + "','" + Label3.Text + "','" + TextBox1.Text + "','','user','','OPEN','','" + System.DateTime.Now.ToString("yyyy-MM-dd") + "')");
        Response.Write("<script>alert('Done.')</script>");
        DataTable dt2 = ob.dttt("select * from  ticket where username='" + Session["newuser"].ToString() + "' and ticketid='" + Label3.Text + "' ");
        Repeater1.DataSource = dt2;
        Repeater1.DataBind();
    }
}