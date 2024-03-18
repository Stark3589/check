using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_adminfund : System.Web.UI.Page
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
            string query = "select name,username,dateofjoin from register where dateofjoin between '" + txt.Text + "' and '" + txt2.Text + "' and status='Active'";
            DataTable dt = ob.dttt(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            double sum1=0;
         double   sum2 = 0;
         double sum3 = 0;
       

            foreach (GridViewRow r in GridView1.Rows)
            {
                try
                {


                    sum1 += Convert.ToDouble(r.Cells[4].Text);
                     sum2 += Convert.ToDouble(r.Cells[5].Text);
                     sum3 += Convert.ToDouble(r.Cells[6].Text);
                   }
                catch { }
            }
            GridView1.FooterRow.Cells[3].Text = "TOTAL";
            GridView1.FooterRow.Cells[4].Text = Math.Round(sum1, 0).ToString("N2");
            GridView1.FooterRow.Cells[5].Text = Math.Round(sum2, 0).ToString("N2");
            GridView1.FooterRow.Cells[6].Text = Math.Round(sum3, 0).ToString("N2");
    
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
                e.Row.Cells[4].Text = "19.66";
                e.Row.Cells[5].Text = "29.49";
                e.Row.Cells[6].Text = "933.85";
            }
        }
        catch (Exception ex)
        {
        }
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Write("<script>");
            Response.Write("window.open('fundprint.aspx?date1=" + txt.Text + " &date2="+txt2.Text+"','_blank')");
            Response.Write("</script>");
        }
        catch (Exception ex)
        {
        }
    }
}