using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_printtransferdetail : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        string date = Request.QueryString["date1"].ToString();
        string dateee = (Request.QueryString["date2"].ToString());
        string query = "select distinct a.username,a.date,a.valu,(select name from register where username=a.username) as name,sum(cast(a.debit as real)) as total from account a where a.date between '" + date + "' and '" + dateee + "' and valu='TRANSFER IN ACCOUNT' group by a.username,a.date,a.valu";
        DataTable dt = ob.dttt(query);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}