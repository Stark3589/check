using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ewallet : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();

  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataTable dt2 = ob.dttt("SELECT  a.username,a.name,a.mobile ,((sum(cast(b.credit as real))-sum(cast(b.debit as real)))) from register a,fundaccount b where a.username=b.username group by a.username,a.name,a.mobile");
                GridView2.DataSource = dt2;
                GridView2.DataBind();
                GridView2.UseAccessibleHeader = true;
                GridView2.HeaderRow.TableSection = TableRowSection.TableHeader;

            }
            catch { }


        }

    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string sql = "select ((sum(cast(credit as real))-sum(cast(debit as real)))) as account from fundaccount where username='" + e.Row.Cells[1].Text + "'";
                DataTable dt = ob.dttt(sql);
                if (dt.Rows.Count > 0)
                {
                    e.Row.Cells[4].Text = dt.Rows[0]["account"].ToString();
                }
            }
        }
        catch (Exception EX) { }
    }
   
}