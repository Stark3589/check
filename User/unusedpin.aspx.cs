using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_unusedpin : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select b.holder,a.amt,b.pin,a.createdate from pingen a,pinmanage b where b.holder='Admin' and b.pin=a.pin and b.reguser is null");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}