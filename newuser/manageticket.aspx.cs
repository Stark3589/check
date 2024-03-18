using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class newuser_incc_ledger : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {

                DataTable dt2 = ob.dttt("select * from  ticket a,register b  where a.username=b.username and b.username='"+Session["newuser"].ToString()+"' and a.sub!='' order by a.id desc");
                GridView1.DataSource = dt2;
                GridView1.DataBind();
            }
            catch (Exception hg) { };

        }
    }
   
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Button b1 = (Button)e.Row.FindControl("Button3");
            LinkButton l1 = (LinkButton)e.Row.FindControl("LinkButton1");
            SqlDataReader status = ob.drrr("select * from ticket where ticketid='"+l1.Text+"' and status='CLOSE'");
            if(status.Read())
            {
                ob.CloseConn();
                b1.Text = "CLOSE";

            }
            else
            {
                ob.CloseConn();
                b1.Text = "OPEN";
            }
            //If Salary is less than 10000 than set the row Background Color to Cyan  

            if (b1.Text == "OPEN")
            {

                b1.BackColor = Color.Green;
                b1.ForeColor = Color.White;

            }
            if (b1.Text == "CLOSE")
            {


                b1.BackColor = Color.Red;
                b1.ForeColor = Color.White;
            }
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            //Determine the RowIndex of the Row whose LinkButton was clicked.
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            //Reference the GridView Row.
            GridViewRow row = GridView1.Rows[rowIndex];

            //Fetch value of Name.
            string name = (row.FindControl("LinkButton1") as LinkButton).Text;

            //Fetch value of Country

            Response.Redirect("ticketstatus.aspx?ticketid=" + name);
        }
    }
}