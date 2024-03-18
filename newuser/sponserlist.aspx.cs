using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
public partial class newuser_sponserlist : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();

    double act = 0, inc = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataTable dt2 = ob.dttt("SELECT distinct register.name,register.dateofjoin,register.rtime,register.mobile,(select sponser from sponser where username=register.username) as sponser ,register.username,register.status FROM register JOIN sponserDownline ON register.username = sponserDownline.downlineid where   sponserDownline.username='" + Session["newuser"].ToString() + "'");
                GridView2.DataSource = dt2;
                GridView2.DataBind();
                GridView2.UseAccessibleHeader = true;
                GridView2.HeaderRow.TableSection = TableRowSection.TableHeader;

            }
            catch { }
            try
            {
                DataTable dt = ob.dttt("select distinct lvl from sponserdownline");
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.DataTextField = "lvl";
                DropDownList1.DataValueField = "lvl";
                DropDownList1.DataBind(); 
            }catch(Exception g){};
            DropDownList1.Items.Insert(0, new ListItem("LEVEL", "0"));

        }

    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string sql = "select name from register where username='" + e.Row.Cells[5].Text + "'";
                DataTable dt = ob.dttt(sql);
                if (dt.Rows.Count > 0)
                {
                    e.Row.Cells[6].Text = dt.Rows[0]["name"].ToString();
                }
            }
        }
        catch (Exception EX)
        {
        }
        try
        {
            //string term = "", policydate = "";
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //If Salary is less than 10000 than set the row Background Color to Cyan  
                Button b1 = (Button)e.Row.FindControl("Button3");
                //If Salary is less than 10000 than set the row Background Color to Cyan  
                if (b1.Text == "Active")
                {
                    b1.Text = "Active";
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;

                }
                if (b1.Text == "Not Active")
                {

                    b1.Text = "Inactive";
                    b1.BackColor = Color.Red;
                    b1.ForeColor = Color.White;
                }

            }
        }
        catch { }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable dt2 = ob.dttt("SELECT distinct register.name,register.dateofjoin,register.rtime,register.mobile,(select sponser from sponser where username=register.username) as sponser ,register.username,register.status FROM register JOIN sponserDownline ON register.username = sponserDownline.downlineid where   sponserDownline.username='" + Session["newuser"].ToString() + "' and sponserDownline.lvl='"+DropDownList1.SelectedItem.Text+"'");
            GridView2.DataSource = dt2;
            GridView2.DataBind();
            GridView2.UseAccessibleHeader = true;
            GridView2.HeaderRow.TableSection = TableRowSection.TableHeader;

        }
        catch { }

    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        try
        {
            DataTable dt2 = ob.dttt("SELECT distinct register.name,register.dateofjoin,register.rtime,register.mobile,(select sponser from sponser where username=register.username) as sponser ,register.username,register.status FROM register JOIN sponserDownline ON register.username = sponserDownline.downlineid where   sponserDownline.username='" + Session["newuser"].ToString() + "'");
            GridView2.DataSource = dt2;
            GridView2.DataBind();
            GridView2.UseAccessibleHeader = true;
            GridView2.HeaderRow.TableSection = TableRowSection.TableHeader;

        }
        catch { }
    }
}