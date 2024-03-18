using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_admstockrpt : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string query = "select productname from tblpricemaster";
            DataTable dt = ob.dttt(query);
            drpname.DataSource = dt;
            drpname.DataTextField = "productname";
            drpname.DataBind();
            drpname.Items.Insert(0, "SELECT");

            bind();
        }
    }
    protected void drpname_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string sql = "select p_code from tblpricemaster where productname='" + drpname.SelectedItem.Text + "'";
            DataTable dty = ob.dttt(sql);
            txtcode.Text = dty.Rows[0]["p_code"].ToString();
        }
        catch (Exception ex)
        {
        }
    }
    private void bind()
    {
        try
        {
            string query = "select * from tblpricemaster";
            DataTable dt = ob.dttt(query);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            string query = "select * from tblpricemaster where productname='"+drpname.SelectedItem.Text+"'";
            DataTable dt = ob.dttt(query);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
}