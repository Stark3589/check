using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_finalamtrprt : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            string query = "select username,sum(cast(credit as real)) as total,(select name from register where username=account.username) name from account where date between '" + date1.Text + "' and '" + date2.Text + "' group by username";
            DataTable dt=ob.dttt(query);
            GridView1.DataSource=dt;
            GridView1.DataBind();
            
        }
        catch (Exception ex)
        {
        }
       
    }
}