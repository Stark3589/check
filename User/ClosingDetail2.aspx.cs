using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class User_CD2 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select datefrom from closingdate order by datefrom desc");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "VIEW")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;
            //string st = Convert.ToString(lnkView.CommandArgument);

          //  DataTable dt = ob.dttt("select date from dailyrecordsmartjyoti where id='" + st + "'");
            DateTime dte = DateTime.Parse(Convert.ToString(lnkView.CommandArgument));
            string date1 = dte.ToString("yyyy-MM-dd");
           // string date1 =Convert.ToDateTime(dt.Rows[0][0].ToString()).ToString("yyyy-MM-dd");

            Response.Redirect("withdrawww.aspx?date=" + date1);
         
        }
      
        
    }
   
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
    }
 
   
}