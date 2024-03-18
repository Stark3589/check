using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
public partial class User_showlevel : System.Web.UI.Page
{

    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataTable dt = ob.dttt("select c.username,c.name,a.lvl,a.amount from levelset a, register c where c.username=a.username  order by id asc");
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            catch (Exception kj) { };
        }
    }

  


    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        try
        {
            DataTable dt = ob.dttt("select c.username,c.name,a.lvl,a.amount from levelset a, register c where c.username=a.username order by id asc");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        catch (Exception kj) { };
    }
}