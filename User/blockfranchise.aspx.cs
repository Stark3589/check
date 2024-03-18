using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_blockfranchise : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }
    private void bind()
    {
        try
        {
            string query="select * from franchisereg";
            DataTable dty=ob.dttt(query);
            GridView2.DataSource=dty;
            GridView2.DataBind();
        }
        catch(Exception ex)
        {
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string query = "select * from franchisereg where username='" + TextBox1.Text + "'";
            DataTable dt = ob.dttt(query);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
     if (e.CommandName == "Select")
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = GridView2.Rows[rowIndex];
            string username = row.Cells[2].Text;
            string str = "select status from franchisereg where username='" + username + "'";
            DataTable dg = ob.dttt(str);
            if (dg.Rows.Count > 0)
            {
                string stats = dg.Rows[0]["status"].ToString();
                if (stats == "Block")
                {
                    Response.Write("<script>alert('THIS MEMBER IS ALREADY BLOCKED')</script>");
                }
                else
                {
                   
                    ob.Execute("update franchisereg set status='Block' where username='" + username + "'");
                    Response.Write("<script>alert('User Blocked Successfully')</script>");
                bind();
                }
            }
        }
    

        if (e.CommandName == "view")
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = GridView2.Rows[rowIndex];
            string username = row.Cells[2].Text;
            string query = "select status from franchisereg where username='" + username + "'";
            DataTable dty = ob.dttt(query);
            if (dty.Rows.Count > 0)
            {
                string sts = dty.Rows[0]["status"].ToString();
                if (sts == "Block")
                {
                    ob.Execute("update franchisereg set status='Open' where username='" + username + "'");
                    Response.Write("<script>alert('User UnBlocked Successfully')</script>");
                }
            }
           bind();
        
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "All")
        {
            try
            {
                DataTable dt = ob.dttt("select * from franchisereg ");
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
            catch (Exception jh) { };
        }
        if (DropDownList1.SelectedItem.Text == "Block")
        {
            try
            {
                DataTable dt = ob.dttt("select  * from franchisereg where status='Block' ");
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
            catch (Exception jh) { };
        }
        if (DropDownList1.SelectedItem.Text == "Un Block")
        {
            try
            {
                DataTable dt = ob.dttt("select  * from franchisereg where status!='Block' ");
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
            catch (Exception jh) { };
        }
    }

    }
