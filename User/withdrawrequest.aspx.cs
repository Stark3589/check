using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using TripleITConnection;
using TripleITTransaction;
using System.Drawing;

public partial class User_withdrawrequest : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataTable dt = ob.dttt("select a.*,b.name,c.accno,c.ifsc,c.bankname,c.branchname from withdrawal a,register b,bankdetail c where b.username=a.username and c.username=a.username and a.status='Pending' and b.status='Active' ");
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            catch (Exception kj) { };
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Button b1 = (Button)e.Row.FindControl("Button3");
            //If Salary is less than 10000 than set the row Background Color to Cyan  
            //if (b1.Text == "Active")
            //{
            //    b1.Text = "Active";
            //    b1.BackColor = Color.Green;
            //    b1.ForeColor = Color.White;

            //}
            //if (b1.Text == "Not Active")
            //{

            //    b1.Text = "Inactive";
            //    b1.BackColor = Color.Red;
            //    b1.ForeColor = Color.White;
            //}
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }
   
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        try
        {
            DataTable dt = ob.dttt("select a.*,b.name,c.accno,c.ifsc,c.bankname,c.branchname from withdrawal a,register b,bankdetail c where b.username=a.username and c.username=a.username and a.status='Pending' and b.status='Active' ");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        catch (Exception kj) { };
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "manual")
        {
            //Determine the RowIndex of the Row whose LinkButton was clicked.
            Button lnkView = (Button)e.CommandSource;

            //lblusername.Text = Convert.ToString(lnkView.CommandArgument);
            string st = Convert.ToString(lnkView.CommandArgument);
            Session["username"] = st;
            ob.Execute("update withdrawal set status='Transfer',sdate='" + System.DateTime.UtcNow.ToString("yyyy-MM-dd") + "',remarks='Transfer' where id='" + st + "'");
            DataTable total = ob.dttt("select total_amt,username from withdrawal  where id='" + st + "'");
            string ddd = "insert into account (username,credit,debit,date,valu) values('" + total.Rows[0][1].ToString() + "','0','" + total.Rows[0][0].ToString() + "','" + System.DateTime.UtcNow.ToString("yyyy-MM-dd") + "','WITHDRAWAL AMOUNT')";
          //  ob.Execute("insert into account (username,credit,debit,total,date,valu) values('" + total.Rows[0][1].ToString() + "','0','" + total.Rows[0][0].ToString() + "','" + total.Rows[0][0].ToString() + "','" + System.DateTime.UtcNow.ToString("yyyy-MM-dd") + "','WITHDRAWAL AMOUNT')");
            //Fetch value of Name.
            Response.Write("<script>alert('Manual Transfer Request Approve Successfully')</script>");
            try
            {
                DataTable dt = ob.dttt("select a.*,b.name,c.accno,c.ifsc,c.bankname,c.branchname from withdrawal a,register b,bankdetail c where b.username=a.username and c.username=a.username and a.status='Pending' and b.status='Active' ");
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            catch (Exception kj) { };
        }
        if (e.CommandName == "reject")
        {
            //Determine the RowIndex of the Row whose LinkButton was clicked.
            Button lnkView = (Button)e.CommandSource;

            //lblusername.Text = Convert.ToString(lnkView.CommandArgument);
            string st = Convert.ToString(lnkView.CommandArgument);
            Session["username"] = st;
            ob.Execute("update withdrawal set status='REJECTED' where id='" + st + "'");

            //Fetch value of Name.
            Response.Write("<script>alert('Request Rejected Successfully')</script>");
            try
            {
                DataTable dt = ob.dttt("select a.*,b.name,c.accno,c.ifsc,c.bankname,c.branchname from withdrawal a,register b,bankdetail c where b.username=a.username and c.username=a.username and a.status='Pending' and b.status='Active' ");
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            catch (Exception kj) { };
        }

    }
}