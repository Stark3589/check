using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class User_blockmember : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataTable dt2 = ob.dttt("select a.username,a.rtime,a.name,a.reffid,a.status,c.sponser,a.dateofjoin from sponserdownline b,register a,sponser c where a.username=b.downlineid and c.username=b.downlineid and b.username='10000000'");
                GridView1.DataSource = dt2;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }catch(Exception jh){};
           

        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Cancel")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;
            GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
            DropDownList DropDownList1 = row.FindControl("DropDownList1") as DropDownList;
           //DropDownList DropDownList1 = (e.Row.FindControl("DropDownList1") as DropDownList);
            //DropDownList DropDownList1 = (DropDownList)GridView1.FindControl("DropDownList1");
            //lblusername.Text = Convert.ToString(lnkView.CommandArgument);
            string st = Convert.ToString(lnkView.CommandArgument);
            Session["username"] = st;
           // ob.Execute("delete from bonanza where text='" + st + "'");
           // ob.Execute("insert into bonanza values('" + st + "')");
            if (DropDownList1.SelectedItem.Text == "Help Receiver")
            {
                SqlDataReader drr = ob.drrr("select * from help_que where status='NF'");
                if (drr.Read())
                {
                    ob.CloseConn();
                    Response.Write("<script>alert('Allready in help Queue')</script>");
                }
                else
                {
                    ob.CloseConn();

                    ob.Execute("insert into help_que(username,status,dates,amount) values('" + st + "','NF','" + System.DateTime.Now.ToString("yyyy-MM-dd") + "','ALL')");
                    Response.Write("<script>alert('Add in help Queue')</script>");
                }
            }
            else
            {
                ob.Execute("update register set bub='" + DropDownList1.SelectedItem.Value + "' where username='" + st + "'");
            }
            DataTable dt2 = ob.dttt("select a.username,a.rtime,a.name,a.reffid,a.status,c.sponser,a.dateofjoin from sponserdownline b,register a,sponser c where a.username=b.downlineid and c.username=b.downlineid and b.username='10000000'");
            GridView1.DataSource = dt2;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex != (-1))
        {
            //string x = e.Row.Cells[4].Text;
            //e.Row.Cells[4].Text = x.Substring(0, 8);
        }
        
      //  DropDownList DropDownList1 = (e.Row.FindControl("DropDownList1") as DropDownList);
        //lblusername.Text = Convert.ToString(lnkView.CommandArgument);


      //  ob.Execute("update register set status='" + DropDownList1.SelectedItem.Text + "' where username='" + e.Row.Cells[3].Text + "'");

        //string y = e.Row.Cells[7].Text;
        //if (y == "Blocked")
        //{
        //    e.Row.Cells[7].Text = "Blocked";
        //}
    }
   
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}