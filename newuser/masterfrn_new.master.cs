using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class newuser_new_master : System.Web.UI.MasterPage
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           // Label1.Text = "ID : " + Session["newuser"].ToString();
            //Label3.Text = Session["newuser"].ToString();
            DataTable dt = ob.dttt("select name,status from register where username='" + Session["newuser"].ToString() + "'");
            Label2.Text =  dt.Rows[0][0].ToString();
            
           // Label3.Text = "Status : " + dt.Rows[0][1].ToString();
        }
        catch (Exception) { Response.Redirect("../login.aspx"); }
    }
}
