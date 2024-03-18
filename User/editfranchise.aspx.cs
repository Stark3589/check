using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_editfranchise : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string username = Session["newuser"].ToString();

            TextBox1.Text = username;
        }

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            string query = "update franchisereg set name='"+txtname.Text+"',password='"+txtpass.Text+"',branch='"+txtbranch.Text+"',mobile='"+txtmob.Text+"',adharno='"+txtadhr.Text+"' where username='" + TextBox1.Text + "'";
            ob.Execute(query);
            Response.Write("<script>alert('UPDATED SUCCESSFULLY')</script>");


        }
        catch (Exception ex)
        {
        }
    }
    protected void btn_Click1(object sender, EventArgs e)
    {
        try
        {
            pnl1.Visible = true;
            string query = "select * from franchisereg where username='" + TextBox1.Text + "'";
            DataTable dty = ob.dttt(query);
            if (dty.Rows.Count > 0)
            {
                txtfran.Text = dty.Rows[0]["package"].ToString();
                txtname.Text = dty.Rows[0]["name"].ToString();
                txtusername.Text = dty.Rows[0]["username"].ToString();
                txtpass.Text = dty.Rows[0]["password"].ToString();
                txtmob.Text = dty.Rows[0]["mobile"].ToString();
                txtadhr.Text = dty.Rows[0]["adharno"].ToString();
                txtbranch.Text = dty.Rows[0]["branch"].ToString();
            }
            else
            {
                Response.Write("<script>alert('OOPS! NO RECORD FOUND')</script>");
            }
        }
        catch (Exception ex)
        {
        }
    }
   
  
}