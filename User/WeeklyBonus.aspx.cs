using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_WBI : System.Web.UI.Page
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
            DataTable dt2 = ob.dttt("select max(weekno) from weekno");
            int wn = Convert.ToInt32(dt2.Rows[0][0].ToString());
            DataTable dt3 = ob.dttt("select dateto from closingdate where weekno='" + wn + "'");
            DateTime date1 = DateTime.Parse(dt3.Rows[0][0].ToString());
            string date = date1.ToString("yyyy-MM-dd");
            DataTable dt = ob.dttt("select nextclub,date,username from DailyRecord where date!='" + System.DateTime.UtcNow.ToString("yyyy-MM-dd") + "' and username='" + TextBox1.Text + "' and date>'" + date + "'");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else
        {
            dr.Close();
            Response.Write("<script>alert('Invalid ID')</script>");
        }
    }
    
}