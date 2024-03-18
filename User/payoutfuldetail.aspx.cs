using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_payoutfuldetail : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    private void bind()
    {
        try
        {
            string query = "select distinct a.username,(select name from register where username=a.username) as name,Amount,Rid  from TblRWithdraw a";
            // string query = "select distinct a.username,(select name from register where username=a.username) as name from account a where  total!='0' group by a.username";
            DataTable dt = ob.dttt(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }

    protected void Chkall_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chckheader = (CheckBox)GridView1.HeaderRow.FindControl("Chkall");
        foreach (GridViewRow row in GridView1.Rows)
        {

            CheckBox cb = (CheckBox)row.FindControl("chkSelect");
            // CheckBox Chkall = (CheckBox)row.FindControl("Chkall");
            if (cb != null)
            {
                if (chckheader.Checked == true)
                {
                    cb.Checked = true;
                }
                else
                {
                    cb.Checked = false;
                }
            }
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "hello")
        {
            // string holder = e.Row.Cells[1].Text;

            LinkButton lnkView = (LinkButton)e.CommandSource;
            string st = Convert.ToString(lnkView.CommandArgument);


            string sqll = "select * from tblrwithdraw where Rid='" + st + "'";
            DataTable dt = ob.dttt(sqll);
            if (dt.Rows.Count > 0)
            {
                string debit = dt.Rows[0]["amount"].ToString();
                string uname = dt.Rows[0]["username"].ToString();

                string y = Convert.ToDateTime(DateTime.UtcNow.Date.ToString()).ToString("yyyy-MM-dd");
                string sql = "insert into account(username,credit,debit,date,total,valu,payable)values('" + uname + "','0','" + debit + "','" + y + "','" + debit + "','TRANSFER IN ACCOUNT','TRANSFER IN ACCOUNT')";
                ob.Execute(sql);
                ob.Execute("update tblrwithdraw set status='Transfer' where  Rid='" + st + "'");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Amount Transfer Successfully');window.location='withdrawww.aspx';", true);

            }

        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
            //    string holder = e.Row.Cells[1].Text;



            //    string query = "select sum(cast(credit as real)) as credit,sum(cast(debit as real)) as debit from account where username='" + holder + "'";
            //    DataTable dt = ob.dttt(query);
            //    if (dt.Rows.Count > 0)
            //    {
            //        string crdt = dt.Rows[0]["credit"].ToString();

            //        string dbt = dt.Rows[0]["debit"].ToString();



            //       double totl = Convert.ToDouble(crdt) - Convert.ToDouble(dbt);
            //        if (totl <= 0)
            //        {
            //            e.Row.Cells[3].Text = "0";
            //            e.Row.Visible = false;
            //        }
            //        else
            //        {
            //            e.Row.Cells[3].Text = totl.ToString();
            //        }

            //    }
            //   // bind();
            //}
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnProcess_Click(object sender, EventArgs e)
    {
        try
        {

            foreach (GridViewRow gvrow in GridView1.Rows)
            {
                CheckBox chk = (CheckBox)gvrow.FindControl("chkSelect");
                if (chk != null & chk.Checked)
                {

                    //    string query = "select sum(cast(total as real)) as total from account where username='" + gvrow.Cells[1].Text + "'";
                    //DataTable dt = ob.dttt(query);
                    //if (dt.Rows.Count > 0)
                    //{
                    //string total=dt.Rows[0]["total"].ToString();
                    string sqll = "select * from tblrwithdraw where username='" + gvrow.Cells[1].Text + "' and status='Pending' order by rid desc";
                    DataTable dt = ob.dttt(sqll);
                    if (dt.Rows.Count > 0)
                    {
                        string debit = dt.Rows[0]["amount"].ToString();
                        string st = dt.Rows[0]["Rid"].ToString();
                        string y = Convert.ToDateTime(DateTime.UtcNow.Date.ToString()).ToString("yyyy-MM-dd");
                        string sql = "insert into account(username,credit,debit,date,total,valu,payable)values('" + gvrow.Cells[1].Text + "','0','" + debit + "','" + y + "','" + debit + "','TRANSFER IN ACCOUNT','TRANSFER IN ACCOUNT')";
                        ob.Execute(sql);

                        ob.Execute("update tblrwithdraw set status='Transfer' where  Rid='" + st + "'");

                    }
                }

            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Amount Transfer Successfully');window.location='withdrawww.aspx';", true);

        }
        catch (Exception ex)
        {
        }

    }

}

