using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_amountdetasil : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select * from money where money='600'");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select * from money where money='200'");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select * from money where money='400'");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}