using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class User_Default7 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        try {

            string sql = "select * from dailyrecordsmartjyoti where username='" + txtuid.Text + "'";
            DataTable dt = ob.dttt(sql);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }
        catch (Exception ex)
        {


        }
    }
}