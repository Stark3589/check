using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_editfranlist : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string query = "select * from franchisereg ";
            DataTable dt = ob.dttt(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            int username = GridView1.EditIndex;
            foreach (GridViewRow row in GridView1.Rows)
            {
                string usernamee = row.Cells[username].Text;
                Session["newuser"] = usernamee;
                Response.Redirect("editfranchise.aspx");


            }



        }
        catch (Exception ex)
        {
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "view")
            {
                string user = e.CommandArgument.ToString();
                foreach (GridViewRow row in GridView1.Rows)
                {
                    //row.Cells[2].Text=
                    string usernamee = user;
                    Session["newuser"] = usernamee;
                    Response.Redirect("editfranchise.aspx");


                }
            }
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnn_Click(object sender, EventArgs e)
    {
        try
        {
            string query = "select * from franchisereg ";
            DataTable dt = ob.dttt(query);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
}