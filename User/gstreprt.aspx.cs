using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class User_gstreprt : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            loaddetail();
        }
    }
    private void loaddetail()
     {
        try
        
        {
            string query = "select a.username,a.name,a.address,a.dateofjoin,a.invoice_no from register a where  a.status='Active' order by id asc";
            DataTable dt = ob.dttt(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;


            foreach (GridViewRow r in GridView1.Rows)
            {
                try
                {


                    sum1 += Convert.ToDouble(r.Cells[6].Text);
                    sum2 += Convert.ToDouble(r.Cells[7].Text);
                    sum3 += Convert.ToDouble(r.Cells[8].Text);
                    sum4 += Convert.ToDouble(r.Cells[10].Text);
                }
                catch { }
            }
            GridView1.FooterRow.Cells[5].Text = "TOTAL";
            GridView1.FooterRow.Cells[6].Text = Math.Round(sum1, 0).ToString("N2");
            GridView1.FooterRow.Cells[7].Text = Math.Round(sum2, 0).ToString("N2");
            GridView1.FooterRow.Cells[8].Text = Math.Round(sum3, 0).ToString("N2");
            GridView1.FooterRow.Cells[10].Text = Math.Round(sum4, 0).ToString("N2");
        }
        catch (Exception ex)
        {
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {

            string sql = "select a.username,a.name,a.address,a.dateofjoin,a.invoice_no from register a where a.dateofjoin between '" + txtfrom.Text + "' and '" + txtto.Text + "' and a.status='Active'";
            DataTable dt = ob.dttt(sql);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;


            foreach (GridViewRow r in GridView1.Rows)
            {
                try
                {


                    sum1 += Convert.ToDouble(r.Cells[6].Text);
                    sum2 += Convert.ToDouble(r.Cells[7].Text);
                    sum3 += Convert.ToDouble(r.Cells[8].Text);
                    sum4 += Convert.ToDouble(r.Cells[10].Text);
                }
                catch { }
            }
            GridView1.FooterRow.Cells[5].Text = "TOTAL";
            GridView1.FooterRow.Cells[6].Text = Math.Round(sum1, 0).ToString("N2");
            GridView1.FooterRow.Cells[7].Text = Math.Round(sum2, 0).ToString("N2");
            GridView1.FooterRow.Cells[8].Text = Math.Round(sum3, 0).ToString("N2");
            GridView1.FooterRow.Cells[10].Text = Math.Round(sum4, 0).ToString("N2");
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
                e.Row.Cells[6].Text = "1100";
                e.Row.Cells[10].Text = "118";
                e.Row.Cells[7].Text = "59";
                e.Row.Cells[8].Text = "59";
                e.Row.Cells[9].Text = "0";
            }
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnprnt_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Write("<script>");
            Response.Write("window.open('gstprint.aspx?date1=" + txtfrom.Text + " &date2=" + txtto.Text + "','_blank')");
            Response.Write("</script>");
        }
        catch (Exception ex)
        {
        }
    }
}