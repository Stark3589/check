using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_WeeklyStatement : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable dt2 = ob.dttt("select max(weekno) from weekno");
            int wn = Convert.ToInt32(dt2.Rows[0][0].ToString());
            DataTable dt3 = ob.dttt("select dateto from closingdate where weekno='" + wn + "'");
            DateTime date1 = DateTime.Parse(dt3.Rows[0][0].ToString());
            string date = date1.ToString("yyyy-MM-dd");
            DataTable dt = ob.dttt("select purchase,nextclub,username,sponser,date,repurchase,reward,fix from dailyrecord where date>'" + date + "' and date!='" + System.DateTime.UtcNow.ToString("yyyy-MM-dd") + "'");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception) { }
    }
}