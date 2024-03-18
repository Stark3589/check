using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_Receipt : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select username,name,mobile from register");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "print")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;

            //lblusername.Text = Convert.ToString(lnkView.CommandArgument);
            string st = Convert.ToString(lnkView.CommandArgument);
            Session["receipt"] = st;
            Label2.Visible = true;
            TextBox1.Visible = true;
            Button1.Visible = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataReader dr = ob.drrr("select * from receipt where username='" + Session["receipt"].ToString() + "'");
        if (dr.Read())
        {
            dr.Close();
            ob.Execute("update receipt set receiptno='" + TextBox1.Text + "' where username='" + Session["receipt"].ToString() + "'");
        }
        else
        {
            dr.Close();
            ob.Execute("insert into receipt(username,receiptno) values('" + Session["receipt"].ToString() + "','" + TextBox1.Text + "')");
        }
        Session["rec"] = TextBox1.Text;
        Response.Write("<script>");
        Response.Write("window.open('printreceipt.aspx','_blank')");
        Response.Write("</script>");
    }
}