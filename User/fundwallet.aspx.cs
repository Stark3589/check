using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_fundwallet : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();

    double act = 0, inc = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataTable dt2 = ob.dttt("SELECT   distinct a.username,a.name,a.mobile  from register a where a.status='Active'");
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
                try
                {
                    string sql = "select ((sum(cast(credit as real))-sum(cast(debit as real)))) as account from account where username='" + e.Row.Cells[1].Text + "'";
                    DataTable dt = ob.dttt(sql);
                    if (dt.Rows.Count > 0)
                    {
                        e.Row.Cells[4].Text = Math.Round(Convert.ToDouble(dt.Rows[0]["account"].ToString()),2).ToString();
                    }
                }
                catch { };

                try
                {
                    try
                    {
                        double d1 = 0, d2 = 0, d3 = 0;
                        try
                        {
                            DataTable drcr2 = ob.dttt("select sum(cast(total_amt as real)) from withdrawal where username='" + e.Row.Cells[1].Text + "'");
                            d1 = Convert.ToDouble(drcr2.Rows[0][0]);
                            e.Row.Cells[6].Text =Math.Round(Convert.ToDouble( d1),2).ToString();


                        }
                        catch (Exception jh)
                        {
                            e.Row.Cells[6].Text = "0";
                            d1 = 0;
                            d2 = 0;
                            d3 = 0;
                        };

                        DataTable dt = ob.dttt("select ((sum(cast(credit as real))-sum(cast(debit as real)))) as account from account where username='" + e.Row.Cells[1].Text + "'");
                        if (dt.Rows.Count > 0)
                        {
                            e.Row.Cells[5].Text =Math.Round( (Convert.ToDouble( dt.Rows[0]["account"].ToString())-d1),2).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                    }

                   
                }
                catch { };

            }
        }
        catch (Exception EX) { }
    }
   
}