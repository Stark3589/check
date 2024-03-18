using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_usedpins : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select a.pin,a.reguser,b.name,b.mobile,b.dateofjoin,b.rtime,(select amt from pingen where a.pin=pin)amt from pinmanage a,register b where a.reguser=b.username and (a.dates !=null or a.dates!='')");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}