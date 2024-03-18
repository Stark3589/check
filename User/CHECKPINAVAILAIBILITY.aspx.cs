using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class User_CHECKPINAVAILAIBILITY : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
           
                string query = "select holder,count(a.pin) as total,b.amt from pinmanage a,pingen b where a.pin=b.pin and b.amt='" + DropDownList1.SelectedItem.Value + "' group by a.holder,b.amt order by holder asc";
                DataTable dt = ob.dttt(query);
                GridView1.DataSource = dt;
                GridView1.DataBind();
       
         
        }
        catch (Exception ex)
        {
        }
    }
    

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string holder = e.Row.Cells[0].Text;
                
                string query = "select holder,count(a.pin) as total from pinmanage a,pingen b where a.pin=b.pin and a.holder='" + holder + "' and a.reguser is not null and b.amt='" + DropDownList1.SelectedItem.Value + "' group by a.holder order by holder asc";
                    DataTable dt = ob.dttt(query);
                    if (dt.Rows.Count > 0)
                    {
                        string total = dt.Rows[0]["total"].ToString();
                        if (total == null || total == "")
                        {
                            e.Row.Cells[3].Text = "0";
                        }
                        else
                        {
                            e.Row.Cells[3].Text = dt.Rows[0]["total"].ToString();
                        }
                    }
                    else
                    {
                        e.Row.Cells[3].Text = "0";
                    }



                    string sql = "select holder,count(a.pin) as total from pinmanage a,pingen b where a.pin=b.pin and a.holder='" + holder + "' and a.reguser is null and b.amt='" + DropDownList1.SelectedItem.Value + "' group by a.holder order by holder asc";
                    DataTable dty = ob.dttt(sql);
                   // e.Row.Cells[2].Text = dty.Rows[0]["total"].ToString();
                    if (dty.Rows.Count > 0)
                    {
                        string total = dty.Rows[0]["total"].ToString();
                        if (total == null || total == "")
                        {
                            e.Row.Cells[2].Text = "0";
                        }
                        else
                        {
                            e.Row.Cells[2].Text = dty.Rows[0]["total"].ToString();
                        }
                    }
                    else
                    {
                        e.Row.Cells[2].Text = "0";
                    }

               // }
                //if (DropDownList1.SelectedItem.Text == "1500")
                //{
                //    string query = "select holder,count(a.pin) as total from pinmanage a,pingen b where a.pin=b.pin and a.holder='" + holder + "' and a.reguser is not null and b.amt='1500' group by a.holder order by holder asc";
                //    DataTable dt = ob.dttt(query);
                //  //  e.Row.Cells[3].Text = dt.Rows[0]["total"].ToString();
                //    if (dt.Rows.Count > 0)
                //    {
                //        string total = dt.Rows[0]["total"].ToString();
                //        if (total == null || total == "")
                //        {
                //            e.Row.Cells[3].Text = "0";
                //        }
                //        else
                //        {
                //            e.Row.Cells[3].Text = dt.Rows[0]["total"].ToString();
                //        }
                //    }
                //    else
                //    {
                //        e.Row.Cells[3].Text = "0";
                //    }

                //    string sql = "select holder,count(a.pin) as total from pinmanage a,pingen b where a.pin=b.pin and a.holder='" + holder + "' and a.reguser is null and b.amt='1500' group by a.holder order by holder asc";
                //    DataTable dty = ob.dttt(sql);
                //   // e.Row.Cells[2].Text = dty.Rows[0]["total"].ToString();
                //  //  e.Row.Cells[2].Text = dty.Rows[0]["total"].ToString();
                //    if (dt.Rows.Count > 0)
                //    {
                //        string total = dty.Rows[0]["total"].ToString();
                //        if (total == null || total == "")
                //        {
                //            e.Row.Cells[2].Text = "0";
                //        }
                //        else
                //        {
                //            e.Row.Cells[2].Text = dty.Rows[0]["total"].ToString();
                //        }
                //    }
                //    else
                //    {
                //        e.Row.Cells[2].Text = "0";
                //    }
                //}
            }
        }
        catch (Exception ex)
        {
        }
    }
}