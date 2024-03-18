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
                DataTable dt2 = ob.dttt("select a.username,a.ticketid,a.msg,a.sub,a.docfile,a.sender,a.receiver,a.dates,b.name,a.status from  ticket a, register b where b.username=a.username and a.ticketid='" + ticketid + "' ");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            catch (Exception hg) { };

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select username from ticket where ticketid='" + Label3.Text + "'");
        ob.Execute("insert into ticket values('"+dt.Rows[0][0].ToString()+"','" + Label3.Text + "','" + TextBox1.Text + "','','Admin','','" + DropDownList1.SelectedItem.Text + "','','" + System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.mmm") + "')");
        Response.Write("<script>alert('Done.')</script>");
        DataTable dt2 = ob.dttt("select a.username,a.ticketid,a.msg,a.sub,a.docfile,a.sender,a.receiver,a.dates,b.name,a.status from  ticket a, register b where b.username=a.username and a.ticketid='" + Label3.Text + "' ");
        Repeater1.DataSource = dt2;
        Repeater1.DataBind();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
}