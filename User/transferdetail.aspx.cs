using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_transferdetail : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string query = "select distinct a.username,a.date,a.valu,(select name from register where username=a.username) as name,sum(cast(a.debit as real)) as total from account a where a.date between '" + TextBox1.Text + "' and '" + TextBox2.Text + "' and valu='TRANSFER IN ACCOUNT' group by a.username,a.date,a.valu";
            DataTable dt = ob.dttt(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            double sum1=0;
       
       

            foreach (GridViewRow r in GridView1.Rows)
            {
                try
                {


                    sum1 += Convert.ToDouble(r.Cells[3].Text);
                 
                   }
                catch { }
            }
            GridView1.FooterRow.Cells[2].Text = "TOTAL";
            GridView1.FooterRow.Cells[3].Text = Math.Round(sum1, 0).ToString("N2");
           
    
        }
        catch (Exception ex)
        {
        }

      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Write("<script>");

            Response.Write("window.open('printtransferdetail.aspx?date1=" + TextBox1.Text + " &date2=" + TextBox2.Text + "','_blank')");
            Response.Write("</script>");
        }
        catch (Exception ex)
        {
        }
    }
}