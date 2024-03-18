using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class newuser_DailySearch : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = ob.dttt("select * from tblreqfund where username='" + Session["newuser"].ToString() + "'");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        catch { };
    }

 
}