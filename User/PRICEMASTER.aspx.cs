
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_PRICEMASTER : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                bindata();

            
            }
            catch (Exception ex)
            { }
        }

    }
    protected void bntsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            DateTime utcTime = DateTime.UtcNow;
            //current Time
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime timenow = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
            //string doj=timenow.
            DateTime datenow1 = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
            string datenow = datenow1.ToString("yyyy/MM/dd");




            if (bntsubmit.Text == "Save")
            {

                string query = "insert into tblpricemaster(p_code,productname,quantity,mrp,GST,CGST,total)values('" + txtcode.Text + "','" + txtp_name.Text + "','" + drpquantity.SelectedItem.Text + "','" + txtmrp.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + txttotal.Text + "')";
                ob.Execute(query);
                Response.Write("<script>alert('INSERTED SUCCESSFULLY')</script>");
                bindata();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('INSERTED SUCCESSFULLY');window.location='PRICEMASTER.aspx';", true);

                
            }
            if (bntsubmit.Text == "Update")
            {
                string sql = "update tblpricemaster set p_code='" + txtcode.Text + "',mrp='" + txtmrp.Text + "',quantity='" + drpquantity.SelectedItem.Text + "',GST='" + TextBox1.Text + "',CGST='" + TextBox2.Text + "',IGST='" + TextBox3.Text + "' productname='" + txtp_name.Text + "',total='" + txttotal.Text + "' where id='" + lbl.Text + "'";

                ob.Execute(sql);
                Response.Write("<script>alert('UPDATED SUCCESSFULLY')</script>");
                bindata();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('UPDATED SUCCESSFULLY');window.location='PRICEMASTER.aspx';", true);

            }
        }


        catch (Exception ex)
        {
        }
    }

    private void bindata()
    {
        try
        {
            string query = "select * from tblpricemaster ";
            DataTable dty = ob.dttt(query);
            Repeater1.DataSource = dty;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        { }

    }
    
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            string ab = e.CommandArgument.ToString();
            string query = "delete from tblpricemaster where id='" + ab + "'";
            ob.Execute(query);



            // record sucess
            lbinfo.Text = "Record Deleted successfully";
            info.Visible = true;
            bindata();


        }

        if (e.CommandName == "Update")
        {
            string ab = e.CommandArgument.ToString();
            string query = "select * from tblpricemaster where id='" + ab + "'";
            DataTable dt = ob.dttt(query);

            if (dt.Rows.Count > 0)
            {
                string aaa = dt.Rows[0]["p_code"].ToString();
                string name = dt.Rows[0]["productname"].ToString();
                string quantity = dt.Rows[0]["quantity"].ToString();
                
                string mrp = dt.Rows[0]["mrp"].ToString();
              
                string cgst = dt.Rows[0]["CGST"].ToString();
                string gst = dt.Rows[0]["GST"].ToString();
                string igst = dt.Rows[0]["IGST"].ToString();
                string total = dt.Rows[0]["total"].ToString();

              //  drpcode.SelectedItem.Text = aaa;
                drpquantity.SelectedItem.Text = quantity;
             
                txtmrp.Text = mrp;
               
                TextBox1.Text = cgst;
                TextBox2.Text = gst;
                txttotal.Text = total;
                txtp_name.Text = name;
               
                bntsubmit.Text = "Update";
            }
            lbl.Text = ab;
           

        }
    }

    //protected void txtbp_TextChanged(object sender, EventArgs e)
    //{
    //    try
    //    {

    //        double bp = Convert.ToDouble(txtbp.Text);
    //        double rp = bp / 60;
    //        txtrp.Text = rp.ToString();
    //    }
    //    catch (Exception EX)
    //    {
    //    }
    //}
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double gst = Convert.ToDouble(TextBox1.Text);
            double cgst = Convert.ToDouble(TextBox2.Text);
            double totl = gst + cgst;
            double totall = Convert.ToDouble(txtmrp.Text) * totl / 100;
            double rem = Convert.ToDouble(txtmrp.Text) - totall;
            txttotal.Text = rem.ToString();


        }
        catch (Exception ex)
        {
        }
    }
}