using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class newuser_WBonus : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable ds = ob.dttt("select withdrawal.id,withdrawal.username,withdrawal.admin, register.name, withdrawal.amount,withdrawal.tds,withdrawal.remarks, withdrawal.dates,withdrawal.status,withdrawal.sdate,withdrawal.remarks,withdrawal.txnamt,withdrawal.txnid from withdrawal inner join register on withdrawal.username=register.username where withdrawal.username='" + Session["newuser"].ToString() + "'");
            if (ds.Rows.Count > 0)
            {
                gvDetails.DataSource = ds;
                gvDetails.DataBind();
                gvDetails.Visible = true;
                gvDetails.UseAccessibleHeader = true;
                gvDetails.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                Response.Write("<script>alert('NO RECORD FOUND')</script>");
            }
        }catch(Exception jkh){};
    }
}