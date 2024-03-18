using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public partial class User_Directlist : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataTable dt = ob.dttt("select c.dateofjoin,c.rtime,c.username,c.name,a.sponser,c.mobile,c.status from sponser a, register c where c.username=a.username and a.sponser='" + Session["newuser"].ToString() + "' ");
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }catch(Exception kj){};
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Button b1 = (Button)e.Row.FindControl("Button3");
            //If Salary is less than 10000 than set the row Background Color to Cyan  
            if (b1.Text == "Active")
            {
                b1.Text = "Active";
                b1.BackColor = Color.Green;
                b1.ForeColor = Color.White;

            }
            if (b1.Text == "Not Active")
            {

                b1.Text = "Inactive";
                b1.BackColor = Color.Red;
                b1.ForeColor = Color.White;
            }
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        try
        {
            DataTable dt = ob.dttt("select c.dateofjoin,c.rtime,c.username,c.name,a.sponser,c.mobile,c.status from sponser a, register c where c.username=a.username and a.sponser='" + Session["newuser"].ToString() + "' ");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        catch (Exception kj) { };
    }
}