using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TripleITTransaction;
using TripleITConnection;
using System.Data;

public partial class User_approvefund : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string status = Request.QueryString["status"];  
            if(status=="Pending")
            {
                DataTable dt = ob.dttt("  select *,(select name from register where username=tblreqfund.username) as name from   tblreqfund where status='Pending'       ");
                if (dt.Rows.Count > 0)
                {
                    gvDetails.DataSource = dt;
                    gvDetails.DataBind();
                    gvDetails.Visible = true;
                    gvDetails.UseAccessibleHeader = true;
                    gvDetails.HeaderRow.TableSection = TableRowSection.TableHeader;
                    btnProcess.Visible = true;
                    Button2.Visible = true;
                }
            }
            if(status=="Approved")
            {
                DataTable dt = ob.dttt("  select *,(select name from register where username=tblreqfund.username) as name from   tblreqfund where status='Approved'");
                if (dt.Rows.Count > 0)
                {
                    //  DataSet ds = ob.dsss("select products.id,products.username,products.qty, register.name,products.status,products.product,register.address from products inner join register on products.username=register.username where products.status='Delivered'");
                    gvDetails.DataSource = dt;
                    gvDetails.DataBind();
                    gvDetails.Visible = true;
                    gvDetails.UseAccessibleHeader = true;
                    gvDetails.HeaderRow.TableSection = TableRowSection.TableHeader;
                    btnProcess.Visible = false;
                    Button2.Visible = false;
                }
            }
        }
    }
    protected void btnProcess_Click(object sender, EventArgs e)
    {
        string str = string.Empty;
        string strname = string.Empty;
        string dd = System.DateTime.UtcNow.Day.ToString();
        string mm = System.DateTime.UtcNow.Month.ToString();
        string yy = System.DateTime.UtcNow.Year.ToString();
        string y = yy + "-" + mm + "-" + dd;
        foreach (GridViewRow gvrow in gvDetails.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("chkSelect");
            if (chk != null & chk.Checked)
            {



                ob.Execute("update tblreqfund set status = 'Approved' where username = '" + gvrow.Cells[2].Text + "' and id='" + gvrow.Cells[1].Text + "'");
                ob.Execute("insert into fundaccount(username,credit,debit,date,status)values('" + gvrow.Cells[2].Text + "','" + gvrow.Cells[4].Text + "','0','" + ob.utc().ToString("yyyy-MM-dd") + "','Approved Fund')");
                Response.Write("<script>alert('Request Approved')</script>");




            }
        }
        gvDetails.Visible = false;
        btnProcess.Visible = false;
        Button2.Visible = false;
    }

    //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    //{
      

        
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string str = string.Empty;
        string strname = string.Empty;
        string dd = System.DateTime.UtcNow.Day.ToString();
        string mm = System.DateTime.UtcNow.Month.ToString();
        string yy = System.DateTime.UtcNow.Year.ToString();
        string y = yy + "-" + mm + "-" + dd;
        foreach (GridViewRow gvrow in gvDetails.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("chkSelect");
            if (chk != null & chk.Checked)
            {



                ob.Execute("update tblreqfund set status = 'Rejected' where username = '" + gvrow.Cells[2].Text + "' and id='" + gvrow.Cells[1].Text + "'");
               // ob.Execute("insert into fundaccount(username,credit,debit,date,status)values('" + gvrow.Cells[2].Text + "','" + gvrow.Cells[4].Text + "','0','" + ob.utc().ToString("yyyy-MM-dd") + "','Approved Fund')");
                Response.Write("<script>alert('Request Rejected')</script>");




            }
        }
        gvDetails.Visible = false;
        btnProcess.Visible = false;
        Button2.Visible = false;
    }
}