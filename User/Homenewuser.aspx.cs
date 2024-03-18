using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_homenewuser : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Label1.Text = "0";
        //try
        //{
        //    DataTable dt = ob.dttt("select count(username) from register where dateofjoin='" + System.DateTime.Today.ToString("yyyy-MM-dd") + "'");
        //    Label1.Text = dt.Rows[0][0].ToString();
        //}
        //catch { }
    }
   
}