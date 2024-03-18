using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class User_invoicereprintt : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            string query = "select * from register where dateofjoin between '" + date1.Text + "' and '" + date2.Text + "' ";
            DataTable dt = ob.dttt(query);
           
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "view")
        {
            string id = e.CommandArgument.ToString();

            string querryy = "select * from register where username='" + id + "'";
            DataTable dty = ob.dttt(querryy);
            lblinvoice.Text =dty.Rows[0]["invoice_no"].ToString();
            Response.Write("<script>");
            Response.Write("window.open('invoice.aspx?invoice=" + lblinvoice.Text + " ','_blank')");
            Response.Write("</script>");
            
        }

    }
}