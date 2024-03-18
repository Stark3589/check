using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_PSearch : System.Web.UI.Page
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
            DataTable dtg2 = ob.dttt("select a.*,b.name,b.mobile from tdstable a,register b where a.username='" + TextBox1.Text + "' and a.username=b.username and a.cheque IS NOT NULL");
            GridView3.DataSource = dtg2;
            GridView3.DataBind();
            GridView3.Visible = true;
        }
        else
        {
            dr.Close();
            Response.Write("<script>alert('Distributor ID Not Found')</script>");
        }
    }
}