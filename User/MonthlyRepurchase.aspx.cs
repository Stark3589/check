using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_MonthlyRepurchase : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataReader dr = ob.drrr("select * from register where username='" + TextBox1.Text + "'");
        if (dr.Read())
        {
            dr.Close();
            int month = Convert.ToInt32(System.DateTime.UtcNow.Month.ToString());
            DataTable dt = ob.dttt("select username,date,repurchase from dailyrecord where username='" + TextBox1.Text + "' and Month(date)='" + month + "'");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}