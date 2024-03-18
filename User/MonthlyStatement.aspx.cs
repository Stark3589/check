using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class newuser_Default2 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        int month = Convert.ToInt32(System.DateTime.UtcNow.Month.ToString());
        DataTable dt = ob.dttt("select * from register a,payoutrecord b where a.username=b.username");
        GridView1.DataSource = dt;
        GridView1.DataBind();
        GridView1.UseAccessibleHeader = true;
        GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
    }
}