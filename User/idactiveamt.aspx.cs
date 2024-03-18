using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class User_idactiveamt : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = ob.dttt("select a.name,a.dateofjoin,a.username,c.amount from register a,pinmgt c where a.username=c.reguser ");
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
    }
}