using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_MonthlyIncome : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        int month = Convert.ToInt32(System.DateTime.UtcNow.Month.ToString());

        DataTable dt = ob.dttt("select a.repurchase,a.reward,a.fix,a.date,a.total,a.username,b.name,b.mobile from dailyrecord a,register b where a.username=b.username and Month(date)='" + month + "' and date!='" + System.DateTime.UtcNow.ToString("yyyy-MM-dd") + "' and a.total !='0'");
        GridView1.DataSource = dt;
        GridView1.DataBind();

        DataTable dt2 = ob.dttt("select a.repurchase,a.reward,a.fix,a.date,a.total,a.username,b.name,b.mobile from dailyrecord a,register b where a.username=b.username and Month(date)='" + month + "' and date!='" + System.DateTime.UtcNow.ToString("yyyy-MM-dd") + "' ");
        GridView2.DataSource = dt2;
        GridView2.DataBind();
    }
}