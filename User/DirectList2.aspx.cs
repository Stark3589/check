using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class newuser_Direct2 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt2 = ob.dttt("select c.dateofjoin,c.rtime,b.username,c.name,a.sponser,c.mobile from sponser a, total_binarycount b,register c where a.username=b.username and c.username=a.username and( (b.leftcount=0 and b.rightcount>0) or (b.leftcount>0 and b.rightcount=0) or (b.leftcount=0 and b.rightcount=0))");
        GridView1.DataSource = dt2;
        GridView1.DataBind();
    }
}