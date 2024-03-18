using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class inactivemember : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["newuser"] = "ADM0000001";
        if(!IsPostBack)
        {
            DataTable dt2 = ob.dttt("select a.username,a.rtime,a.name,a.reffid,b.lvl,c.sponser,a.dateofjoin from sponserdownline b,register a,sponser c where a.username=b.downlineid and c.username=b.downlineid and b.username='MDI0000001' and (a.status='Not Active' or a.status='Block')");
            GridView1.DataSource = dt2;
            GridView1.DataBind();

            
        }
       


      
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Cancel")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;
            
            //lblusername.Text = Convert.ToString(lnkView.CommandArgument);
            string st = Convert.ToString(lnkView.CommandArgument);
            Session["username"] = st;
            //Response.Redirect("Confirm.aspx?userid=" + st + "");
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
       

        string y = e.Row.Cells[5].Text;
        if (y == "Not active")
        { 
        e.Row.Cells[5].Text = "Inactive";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            string sql = "";
            if (txtuname.Text.Length > 5)
            {
                sql = "select a.username,a.rtime,a.name,a.reffid,b.lvl,c.sponser,a.dateofjoin from sponserdownline b,register a,sponser c where a.username=b.downlineid and c.username=b.downlineid and b.username='" + Session["newuser"].ToString() + "' and b.downlineid='" + txtuname.Text + "' and (a.status='Not Active' or a.status='Block')";

            }
            else
            {
                sql = "select a.username,a.rtime,a.name,a.reffid,b.lvl,c.sponser,a.dateofjoin from sponserdownline b,register a,sponser c where a.username=b.downlineid and c.username=b.downlineid and b.username='" + Session["newuser"].ToString() + "' and a.name='" + txtname.Text + "' and (a.status='Not Active' or a.status='Block')";

            }
            DataTable dt2 = ob.dttt(sql);
            GridView1.DataSource = dt2;
            GridView1.DataBind();
        }
        catch (Exception se) { };
        
    }
}