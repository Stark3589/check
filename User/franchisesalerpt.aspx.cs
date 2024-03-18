using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_franchisesalerpt : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string query = "select distinct name,username from register where status='Active' order by name asc ";
            DataTable dt = ob.dttt(query);
            txtusernme.DataSource = dt;
            txtusernme.DataTextField = "name";
            txtusernme.DataValueField = "username";
            txtusernme.DataBind();
            txtusernme.Items.Insert(0, "SELECT");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt.Text == "" && txt2.Text=="" && txtusernme.Text!="SELECT"  )
            {
                string query = "select * from tblproductpurchase where  cust_id='" + txtusernme.SelectedValue + "'";
                DataTable dt = ob.dttt(query);
                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('NO RECORD FOUND')</script>");
                }

            }
            else if (txt.Text != "" && txt2.Text != "" && txtusernme.Text == "SELECT")
            {
                string query = "select * from tblproductpurchase where  date between '" + txt.Text + "' and '" + txt2.Text + "'";
                DataTable dt = ob.dttt(query);
                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('NO RECORD FOUND')</script>");
                }
               
            }
            else
            {
                string query = "select * from tblproductpurchase where date between '" + txt.Text + "' and '" + txt2.Text + "' and cust_id='" + txtusernme.SelectedValue + "' ";
                DataTable dt = ob.dttt(query);
                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {

                    Response.Write("<script>alert('NO RECORD FOUND')</script>");
                }
            }
        }
        catch (Exception ex)
        {
        }
    }
}