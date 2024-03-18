using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_ActiveReport : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DataTable dt = ob.dttt("select a.name,a.dateofjoin,a.rtime,a.mobile,a.username from register a,poolachv c where a.username=c.username and c.membercount>=10 ");
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
    }
  
   
}