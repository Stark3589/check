using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_availablestock : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {

                DataTable dt2 = ob.dttt("select * from adamount order by id desc");
                GridView1.DataSource = dt2;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }catch(Exception kj){};
          
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        if (Convert.ToDouble(TextBox1.Text) !=0)
        {
            string dd = System.DateTime.Now.Day.ToString();
            string mm = System.DateTime.Now.Month.ToString();
            string yy = System.DateTime.Now.Year.ToString();
            string y = yy + "-" + mm + "-" + dd;
            DateTime scheule = Convert.ToDateTime(TextBox3.Text);

            ob.Execute("insert into adamount values('" + scheule.ToString("yyyy-MM-dd") + "','" + System.DateTime.Now.ToString("yyyy-MM-dd") + "','" + TextBox1.Text + "')");

            DataTable dt2 = ob.dttt("select * from adamount order by id desc");
            GridView1.DataSource = dt2;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Amount Add Successfully added');window.location='availablestock.aspx';", true);
            //  Response.Write("<script>alert('Id Successfully Activated')</script>");

        }
        else
        {
            Response.Write("<script>alert('Please enter valid amount')</script>");
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Cancel")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;

            //lblusername.Text = Convert.ToString(lnkView.CommandArgument);
            int id = Convert.ToInt32(lnkView.CommandArgument);
            DataTable dt = ob.dttt("select imgurl from ad where id=" + id + "");
            string path = Server.MapPath(dt.Rows[0][0].ToString());


            ob.Execute("delete from adamount where id=" + id + "");
            Response.Write("<script>alert('Ad remove Successfully.')</script>");

            DataTable dt2 = ob.dttt("select * from adamount order by id desc");
            GridView1.DataSource = dt2;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {


       
    }





    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        DateTime scheule = Convert.ToDateTime(TextBox3.Text);
        try
        {

            DataTable getamt = ob.dttt("select sum(cast(amount as real)) from adamount where dates='" + scheule.ToString("yyyy-MM-dd") + "'");
            TextBox1.Text = getamt.Rows[0][0].ToString();
            if (TextBox1.Text == "")
            {
                TextBox1.Text = "0";
            }
        }
        catch (Exception jh) { TextBox1.Text = "0"; };

        DataTable dt2 = ob.dttt("select * from adamount where dates='" + scheule.ToString("yyyy-MM-dd") + "'");
        GridView1.DataSource = dt2;
        GridView1.DataBind();
    }
}