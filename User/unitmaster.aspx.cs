using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_unitmaster : System.Web.UI.Page
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
            string sql = "select * from addunit";
            DataTable dt = ob.dttt(sql);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
    protected void bntsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (bntsubmit.Text == "Save")
            {
                string queryy = "select * from addunit where unit='" + txtunit.Text + "'";
                DataTable dtu = ob.dttt(queryy);
                if (dtu.Rows.Count > 0)
                {
                    Response.Write("<script>alert('THIS UNIT IS ALREADY INSERTED')</script>");
                }
                else
                {
                    string query = "insert into addunit(unit)values('" + txtunit.Text + "')";
                    ob.Execute(query);
                    Response.Write("<script>alert('INSERTED SUCCESSFULLY')</script>");
                    bind();
                }
            }
            if (bntsubmit.Text == "Update")
            {
                string sql = "update addunit set unit='" + txtunit.Text + "' where id='" + lbl.Text + "'";

                ob.Execute(sql);
                Response.Write("<script>alert('UPDATED SUCCESSFULLY')</script>");
                bind();
            }
        }
        catch (Exception ex)
        {
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            string ab = e.CommandArgument.ToString();
            string query = "delete from addunit where id='" + ab + "'";
            ob.Execute(query);



            // record sucess
            lbinfo.Text = "Record Deleted successfully";
            info.Visible = true;


        }

        if (e.CommandName == "Update")
        {
            string ab = e.CommandArgument.ToString();
            string query = "select * from addunit where id='" + ab + "'";
            DataTable dt = ob.dttt(query);

            if (dt.Rows.Count > 0)
            {
                string aaa = dt.Rows[0]["unit"].ToString();
              
                txtunit.Text = aaa;
                
                bntsubmit.Text = "Update";
            }
            lbl.Text = ab;
            

        }
    }
}