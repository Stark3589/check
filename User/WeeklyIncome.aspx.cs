using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_WeeklyIncome : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        string dd = System.DateTime.UtcNow.Day.ToString();
        string mm = System.DateTime.UtcNow.Month.ToString();
        string yy = System.DateTime.UtcNow.Year.ToString();
        string ddd = yy + "-" + mm + "-" + dd;
        DataSet ds = ob.dsss("select * from dailyrecord where date='"+ddd+"' and total>0");
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}