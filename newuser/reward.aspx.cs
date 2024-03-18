using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class newuser_reward : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            try
            {
                DataTable dt2 = ob.dttt("select * from REWARD_LIST1");
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
                    double d1 = 0, d2 = 0, d3 = 0;
                    try
                    {
                        DataTable drcr2 = ob.dttt("select count(downlineid) from sponserdownline where username='" + Session["newuser"].ToString() + "' and lvl='" + e.Row.Cells[1].Text + "'");
                        e.Row.Cells[3].Text = (drcr2.Rows[0][0]).ToString();
                       


                    }
                    catch (Exception jh)
                    {
                        d1 = 0;
                        d2 = 0;
                        d3 = 0;
                    };
                   
                    try
                    {
                        DataTable drcr2 = ob.dttt("select status from reward_record where username='" + Session["newuser"].ToString() + "' and rwd_rank='" + e.Row.Cells[1].Text + "'");
                        if (drcr2.Rows[0][0].ToString() == "SUCCESS")
                        {
                            e.Row.Cells[6].Text = "SUCCESS";
                            e.Row.BackColor = System.Drawing.Color.Green;
                            e.Row.ForeColor = System.Drawing.Color.White;
                          
                        }
                        else
                        {
                            e.Row.Cells[6].Text = "PENDING";
                            e.Row.BackColor = System.Drawing.Color.Red;
                            e.Row.ForeColor = System.Drawing.Color.White;
                          
                        }
                    }
                    catch (Exception ex)
                    {
                       
                       
                    }
                }
                catch (Exception ex)
                {
                }





            }
        }
        catch (Exception EX) { }
    }
   
}