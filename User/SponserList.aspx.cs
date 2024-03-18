using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
public partial class newuser_sponserlist : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataTable dt = ob.dttt("select c.dateofjoin,c.rtime,c.username,c.name,a.sponser,c.mobile,c.status from sponser a, register c where c.username=a.username and c.status='Not Active' ");
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            catch (Exception kj) { };
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //If Salary is less than 10000 than set the row Background Color to Cyan  
            if (e.Row.Cells[7].Text == "Active")
            {

                e.Row.ForeColor = Color.Blue;
            }
            if (e.Row.Cells[7].Text == "Not Active")
            {

               
            }
        }
    }


    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        try
        {
            DataTable dt = ob.dttt("select c.dateofjoin,c.rtime,c.username,c.name,a.sponser,c.mobile,c.status from sponser a, register c where c.username=a.username and c.status='Not Active' ");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        catch (Exception kj) { };
    }
}