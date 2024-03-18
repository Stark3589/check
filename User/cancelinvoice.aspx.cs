using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_cancelinvoice : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    protected void BTN_Click(object sender, EventArgs e)
    {
        try
        {
            string query = "select *,(select productname from tblpricemaster where p_code=tblproductpurchase.p_code) as productname,(select name from register where username=tblproductpurchase.cust_id) as name  from tblproductpurchase where fran_id='" + txtfid.Text + "' and date between '" + date1.Text + "' and '" + date2.Text + "' and status!='Cancel'";
            DataTable dt = ob.dttt(query);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            string id = e.CommandArgument.ToString();

            string query = "update tblproductpurchase set status='Cancel' where invoice_no='" + id + "'";
            ob.Execute(query);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CANCEL SUCCESSFULLY');window.location='cancelinvoice.aspx';", true);
        }
    }
}