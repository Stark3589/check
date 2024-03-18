using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class User_withdrawww : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Request.QueryString["date"];  
        if (!IsPostBack)
        {
            bind();
        }
       
    }
    
    private void bind()
    {
        try
        {
            string query = "select a.username,a.name,a.mobile,sum(cast(b.credit as real)) as total from register a,account b where a.username=b.username and date='" + Label1.Text + "' group by a.username,a.name,a.mobile";
           // string query = "select distinct a.username,(select name from register where username=a.username) as name from account a where  total!='0' group by a.username";
            DataTable dt = ob.dttt(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
   
    //protected void Chkall_CheckedChanged(object sender, EventArgs e)
    //{
    //    CheckBox chckheader = (CheckBox)GridView1.HeaderRow.FindControl("Chkall");
    //    foreach (GridViewRow row in GridView1.Rows)
    //    {

    //        CheckBox cb = (CheckBox)row.FindControl("chkSelect");
    //        // CheckBox Chkall = (CheckBox)row.FindControl("Chkall");
    //        if (cb != null)
    //        {
    //            if (chckheader.Checked == true)
    //            {
    //                cb.Checked = true;
    //            }
    //            else
    //            {
    //                cb.Checked = false;
    //            }
    //        }
    //    }
    //}
      protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
       {
        if (e.CommandName == "hello")
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument)-1;
 
    
    GridViewRow row = GridView1.Rows[rowIndex];
 
   
  
           string holder = GridView1.Rows[rowIndex].Cells[0].Text;
           DateTime dt1 = Convert.ToDateTime(Label1.Text);
           DateTime dt2 = dt1.AddDays(-14);
           string date = dt2.ToString("yyyy-MM-dd");

            LinkButton lnkView = (LinkButton)e.CommandSource;
            string st = Convert.ToString(lnkView.CommandArgument);
           DataTable dt = ob.dttt("select a.incomeby, b.name, a.directincome, a.lvlincome, a.date from  dailyrecordsmartjyoti a, register b where b.username=a.incomeby and a.username='"+holder+"' and a.date between '"+date+"' and '"+Label1.Text+"'");
           GridView2.DataSource = dt;
           GridView2.DataBind();
           TextBox1.Text = GridView1.Rows[rowIndex].Cells[3].Text;
           TextBox5.Text = GridView1.Rows[rowIndex].Cells[0].Text;
            this.mp1.Show();
          
           

        }
      }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

            string holder = e.Row.Cells[0].Text;

             

              string query = "select * from payoutrecord where username='" + holder + "' and date='"+Label1.Text+"'";
                DataTable dt = ob.dttt(query);
                if (dt.Rows.Count > 0)
                {
                    e.Row.BackColor = System.Drawing.Color.Green;
                    e.Row.ForeColor = System.Drawing.Color.White;
                  
                }

            }
        }
        catch (Exception ex)
        {
        }
    }


   
    protected void btnPrint_Click1(object sender, EventArgs e)
    {
        try
        {
            ob.Execute("insert into payoutrecord values('" + TextBox5.Text + "','" + Label1.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','"+TextBox6.Text+"','TRANSFER','"+TextBox4.Text+"','"+DropDownList1.SelectedItem.Text+"')");
            //Response.Write("<script>alert('Record inserted successfully')</script>");
            Label10.Text = "Record inserted successfully";
            bind();
            this.mp1.Show();
        }catch(Exception jh){};
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {

        Response.Redirect("Bank_cheque.aspx?user=" + TextBox5.Text + "&amount=" + TextBox1.Text + "&date=" + TextBox6.Text); 
    }
}

