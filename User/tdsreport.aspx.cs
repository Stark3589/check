using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_tdsreport : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            loaddetail();
        }
    }
    private void loaddetail()
   
    {
        try
        {
            string sql = "select a.*,b.name,b.pan from account a,register b where a.username=b.username and a.valu!='TRANSFER IN ACCOUNT'";
            DataTable dt = ob.dttt(sql);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            string sql = "select a.*,b.name,b.pan from account a,register b where a.username=b.username and a.date between '" + txtfrom.Text + "' and '" + txtto.Text + "' and a.valu!='TRANSFER IN ACCOUNT'";
            DataTable dt = ob.dttt(sql);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        try
        {
            string sql = "select a.*,b.name,b.pan from account a,register b where a.username=b.username and a.username='" + txtusername.Text + "' and a.valu!='TRANSFER IN ACCOUNT'";
            DataTable dt = ob.dttt(sql);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
}