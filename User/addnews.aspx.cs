using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TripleITConnection;
using System.Data;

public partial class Admin_addnews : System.Web.UI.Page
{
    clsConnection objcon = new clsConnection();
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select * from news order by id asc");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
     
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "api")
        {
            //Determine the RowIndex of the Row whose LinkButton was clicked.

            LinkButton lnkView = (LinkButton)e.CommandSource;
            string st = Convert.ToString(lnkView.CommandArgument);
            DataTable dt = ob.dttt("select * from news where id='" + st + "' and status='Active'");
            //Reference the GridView Row.

            if (dt.Rows.Count > 0)
            {
                ob.Execute("update news set status='Deactive' where id='" + st + "'");
                DataTable dt1 = ob.dttt("select * from news order by id asc");
                GridView1.DataSource = dt1;
                GridView1.DataBind();
            }
            else
            {
                ob.Execute("update news set status='Active' where id='" + st + "'");
                DataTable dt1 = ob.dttt("select * from news order by id asc");
                GridView1.DataSource = dt1;
                GridView1.DataBind();
            }
            //Fetch value of Name.

        }
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        FileUpload1.SaveAs(Server.MapPath("../images/" + FileUpload1.FileName));
        string str = "../images/" + FileUpload1.FileName;
        ob.Execute("insert into news (news,status,news2) values('" + TextBox1.Text + "','Active','" + str + "')");
        Response.Write("<script>alert('News added successfully')</script>");
        DataTable dt = ob.dttt("select * from news order by id asc");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}