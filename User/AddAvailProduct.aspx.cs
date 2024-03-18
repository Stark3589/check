using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class User_AddAvailProduct : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    public void bind()
    {
        try
        {
            string query = "select distinct productname ,p_code from tblpricemaster ";
            DataTable dt = ob.dttt(query);
            drpproduct.DataSource = dt;
            drpproduct.DataTextField = "productname";
            drpproduct.DataValueField = "p_code";
            drpproduct.DataBind();
            drpproduct.Items.Insert(0, "SELECT");

            string queryy = "select distinct quantity from productquantity ";
            DataTable dty = ob.dttt(queryy);
            drpqty.DataSource = dty;
            drpqty.DataTextField = "quantity";
            drpqty.DataBind();
            drpqty.Items.Insert(0, "SELECT");

            //string queryyy = "select distinct unit from addunit ";
            //DataTable dtt = ob.dttt(queryyy);
            //drpunit.DataSource = dtt;
            //drpunit.DataTextField = "unit";
            //drpunit.DataBind();
            //drpunit.Items.Insert(0, "SELECT");
        }
        catch (Exception ex) { }
    }


    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        try
        {


            string str = "insert into tblavail_pro_adm(p_code,qty_credit,qty_debit,unit,date,username,productname) values('" + drpproduct.SelectedValue + "','" + drpqty.SelectedItem.Text + "','0','" + txtbox1.Text + "','" + ob.utc().ToString("yyyy-MM-dd") + "','" + Session["ADMIN"].ToString() + "','" + drpproduct.SelectedItem.Text + "')";
                ob.Execute(str);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('INSERTED SUCCESSFULLY');window.location='addavailproduct.aspx';", true);

            
        }
        catch (Exception ex)
        {
        }

       

    }
}