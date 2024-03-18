using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_UnBlock_Member : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
        }
    }
    protected void search_Click(object sender, EventArgs e)
    {
        bind();

    }


    public void bind()
    {
        try
        {
            string str = "select * from register where username='" + txtuname.Text + "'";
            DataTable dt = ob.dttt(str);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
        catch(Exception ex){}
    }

    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "view")
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = GridView2.Rows[rowIndex];
            string username = row.Cells[2].Text;

            try
            {
                ob.Execute("update register set status='Active' where username='" + username + "'");
                Response.Write("<script>alert('User UnBlocked Successfully')</script>");
            }
            catch (Exception ex) { }

                bind();
        }
    }
}