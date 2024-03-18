using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_addquantity : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindata();
        }

    }
    protected void bntsubmit_Click(object sender, EventArgs e)
    {

        if (bntsubmit.Text == "Save")
        {
            string queryy = "select * from productquantity where quantity='" + txtcategory.Text + "'";
            DataTable dtu = ob.dttt(queryy);
            if (dtu.Rows.Count > 0)
            {
                Response.Write("<script>alert('THIS QUANTITY IS ALREADY INSERTED')</script>");
            }
            else
            {
                string query = "insert into productquantity(quantity)values('" + txtcategory.Text + "')";
                ob.Execute(query);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('INSERTED SUCCESSFULLY');window.location='addquantity.aspx';", true);
                bindata();
            }
        }

        if (bntsubmit.Text == "Update")
        {
            string sql = "update productquantity set quantity='" + txtcategory.Text + "' where quantity='" + lbl.Text + "'";
            ob.Execute(sql);
            Response.Write("<script>alert('UPDATED SUCCESSFULLY')</script>");
            bindata();
        }
       

    }
    private void bindata()
    {
        try
        {
            string query = "select * from productquantity ";
            DataTable dty = ob.dttt(query);
            Repeater1.DataSource = dty;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        { }

    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Update")
        {
            string idd = e.CommandArgument.ToString();


            string query = "select quantity from productquantity where quantity='" + idd + "'";
            DataTable dt = ob.dttt(query);
            if (dt.Rows.Count > 0)
            {
                string aaa = dt.Rows[0]["quantity"].ToString();
                txtcategory.Text = aaa;
                bntsubmit.Text = "Update";
            }
            lbl.Text = txtcategory.Text;

        }
        if (e.CommandName == "DEL")
        {
            string idd = e.CommandArgument.ToString();

            string query = "delete from productquantity where quantity='" + idd + "'";
            ob.Execute(query);
            Response.Write("<script>alert('DELETED SUCCESSFULLY')</script>");
            bindata();
        }
    }
    }
