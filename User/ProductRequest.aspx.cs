using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ProductRequest : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        BINDATA();
    }


    public void BINDATA()
    {
        try
        {
            string query = "select distinct invoice_no, fran_id,date,(select name from franchisereg where productrequest.fran_id=username) as name from productrequest where date between '" + Convert.ToDateTime(txtdate1.Text).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(txtdate2.Text).ToString("yyyy-MM-dd") + "' and status='Pending'";
            DataTable dt=ob.dttt(query);
            GridView2.DataSource=dt;
            GridView2.DataBind();
        }
        catch (Exception EX)
        {
        }
    }
    public void bind()
    {
        try
        {
            string str = "select fran_id,id,(select name from franchisereg where productrequest.fran_id=username) as name,(cast(quantity as nvarchar(50))) as qty,total_amt,status,date,P_code,(select productname from tblpricemaster where p_code=productrequest.P_code) as P_name from productrequest where invoice_no='"+ lbidd.Text+"' and status='Pending'";
            DataTable dt = ob.dttt(str);
            if (dt.Rows.Count > 0)
            {
                btn_cancel.Visible = true;
                btn_approve.Visible = true;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                btn_cancel.Visible = false;
                btn_approve.Visible = false;
                Response.Write("<script>alert('No Record Found')</script>");
       
            }
       
        }
        catch(Exception ex ){}
    }


    protected void btn_approve_Click(object sender, EventArgs e)
    {
     //   int aa;
        for (int i = 0; i <= GridView1.Rows.Count-1 ; i++)
        {

            GridViewRow row = GridView1.Rows[i];
            CheckBox chkdel = (CheckBox)row.FindControl("Checkbox1");
            Label lbid1 = (Label)row.FindControl("lbid");
            
            if (chkdel.Checked == true)
            {

           
                int id = Convert.ToInt32(lbid1.Text);


                string date1 = Convert.ToDateTime(row.Cells[8].Text).ToString("yyyy-MM-dd");
                string str = "update productrequest set status='Approved' where  id='" + id + "' and fran_id='" + row.Cells[2].Text + "' and p_code='" + row.Cells[4].Text + "' and date='" + date1 + "'";
                    ob.Execute(str);

                    string qury = "select fran_id, p_code, quantity,unit from productrequest where id='" + id + "'";

                DataTable dy = ob.dttt(qury);
                if (dy.Rows.Count > 0)
                {
                    string custid = dy.Rows[0]["fran_id"].ToString();
                    string code = dy.Rows[0]["p_code"].ToString();
                    string qty = dy.Rows[0]["quantity"].ToString();
                    string unit = dy.Rows[0]["unit"].ToString();
                    string query = "insert into tblavail_pro_adm(p_code,qty_credit,qty_debit,unit,date,username) values('" + code + "','0','" + qty + "','" + unit + "','" + ob.utc().ToString("yyyy-MM-dd") + "','" + custid + "')";
                    ob.Execute(query);
                    string queryy = "insert into tblavail_pro_franchise(p_code,qty_credit,qty_debit,unit,date,username) values('" + code + "','" + qty + "','0','" + unit + "','" + ob.utc().ToString("yyyy-MM-dd") + "','" + custid + "')";
                    ob.Execute(queryy);

                }
                bind();
                Response.Write("<script>alert('SUCCESSFULLY APPROVED')</script>");
           }
        }
     
       
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {

            GridViewRow row = GridView1.Rows[i];
            CheckBox chkdel = (CheckBox)row.FindControl("Checkbox1");
            Label lbid1 = (Label)row.FindControl("lbid");

            if (chkdel.Checked == true)
            {


                int id = Convert.ToInt32(lbid1.Text);
               
               // string date1 = Convert.ToDateTime(row.Cells[7].Text).ToString("yyyy-MM-dd");
                string str = "update productrequest set status='Cancel' where id='" + id + "' and fran_id='" + row.Cells[2].Text + "' and p_code='" + row.Cells[4].Text + "' and date='" + row.Cells[8].Text + "'";
                ob.Execute(str);

            }
        }
        bind();
        Response.Write("<script>alert('SUCCESSFULLY CANCELED')</script>");
       
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "view")
        {
            string id = e.CommandArgument.ToString();

            string sql = "select fran_id,invoice_no from productrequest where invoice_no='" + id + "'";
            DataTable dty = ob.dttt(sql);
            if (dty.Rows.Count > 0)
            {

                Response.Write("<script>");
                Response.Write("window.open('invoiceadm.aspx?id=" + dty.Rows[0]["fran_id"].ToString() + " &invoice=" + dty.Rows[0]["invoice_no"].ToString() + "','_blank')");
                Response.Write("</script>");
            }
        }

        if (e.CommandName == "select")
        {
            string id = e.CommandArgument.ToString();
               string str = "update productrequest set status='Approved' where invoice_no='" + id + "'";
                    ob.Execute(str);

                    string qury = "select fran_id, p_code, quantity,unit from productrequest where invoice_no='" + id + "'";

                DataTable dy = ob.dttt(qury);
                if (dy.Rows.Count > 0)
                {
                    string custid = dy.Rows[0]["fran_id"].ToString();
                    string code = dy.Rows[0]["p_code"].ToString();
                    string qty = dy.Rows[0]["quantity"].ToString();
                    string unit = dy.Rows[0]["unit"].ToString();
                    string query = "insert into tblavail_pro_adm(p_code,qty_credit,qty_debit,unit,date,username) values('" + code + "','0','" + qty + "','" + unit + "','" + ob.utc().ToString("yyyy-MM-dd") + "','" + custid + "')";
                    ob.Execute(query);
                    string queryy = "insert into tblavail_pro_franchise(p_code,qty_credit,qty_debit,unit,date,username) values('" + code + "','" + qty + "','0','" + unit + "','" + ob.utc().ToString("yyyy-MM-dd") + "','" + custid + "')";
                    ob.Execute(queryy);

                }
                BINDATA();

                Response.Write("<script>alert('SUCCESSFULLY APPROVED')</script>");

           }
       
        if (e.CommandName == "add")
        {
            string id = e.CommandArgument.ToString();
            lbidd.Text=id;
            bind();
           // GridView2.Visible = false;
        }
        }
    
    }
