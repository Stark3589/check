using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class User_Confirm : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            try
            {
                TextBox3.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
                DataTable dt2 = ob.dttt("select * from ad where dates='" + System.DateTime.Now.ToString("yyyy-MM-dd") + "'");
                GridView1.DataSource = dt2;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
                DateTime sdldate = Convert.ToDateTime(TextBox3.Text);
                DataTable getdailyamt = ob.dttt("select amount from adamount where dates='" + sdldate.ToString("yyyy-MM-dd") + "'");

                try
                {

                    DataTable getamt = ob.dttt("select sum(cast(amount as real)) from ad where dates='" + sdldate.ToString("yyyy-MM-dd") + "'");
                    Label2.Text = (Convert.ToDouble(getdailyamt.Rows[0][0]) - Convert.ToDouble(getamt.Rows[0][0])).ToString();
                    if (Label2.Text == "")
                    {
                        Label2.Text = getdailyamt.Rows[0][0].ToString();
                    }
                }
                catch (Exception jh) { Label2.Text = getdailyamt.Rows[0][0].ToString(); };
            }
            catch (Exception jh) { };
           
            //Label2.Text = "NSI100207";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        if (Convert.ToDouble(Label2.Text) >= Convert.ToDouble(TextBox1.Text))
        {
            string dd = System.DateTime.Now.Day.ToString();
            string mm = System.DateTime.Now.Month.ToString();
            string yy = System.DateTime.Now.Year.ToString();
            string y = yy + "-" + mm + "-" + dd;
            DateTime scheule = Convert.ToDateTime(TextBox3.Text);
            //downline count
            //stored Procedure

            if (FileUpload1.HasFile)
            {
                string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/ads/") + fileName);
                string imgurl = "~/ads/" + fileName;
                ob.Execute("insert into ad values('" + scheule.ToString("yyyy-MM-dd") + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + imgurl + "','" + System.DateTime.Now.ToString("yyyy-MM-dd") + "')");
            }

            DataTable dt2 = ob.dttt("select * from ad where dates='" + System.DateTime.Now.ToString("yyyy-MM-dd") + "'");
            GridView1.DataSource = dt2;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            try
            {
                DateTime sdldate = Convert.ToDateTime(TextBox3.Text);
                DataTable getdailyamt = ob.dttt("select amount from adamount where dates='" + sdldate.ToString("yyyy-MM-dd") + "'");

                DataTable getamt = ob.dttt("select sum(cast(amount as real)) from ad where dates='" + sdldate.ToString("yyyy-MM-dd") + "'");
                Label2.Text = (Convert.ToDouble(getdailyamt.Rows[0][0]) - Convert.ToDouble(getamt.Rows[0][0])).ToString();
                if (Label2.Text == "")
                {
                    Label2.Text = "0";
                }
            }
            catch (Exception jh) { Label2.Text = "0"; };

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Ad Successfully added');window.location='confirm.aspx';", true);
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
            int  id = Convert.ToInt32(lnkView.CommandArgument);
            DataTable dt=ob.dttt("select imgurl from ad where id="+id+"");
            string path = Server.MapPath(dt.Rows[0][0].ToString());
          
            FileInfo file = new FileInfo(path);
            if (file.Exists)//check file exsit or not  
            {
                file.Delete();
               
            }
            ob.Execute("delete from ad where id="+id+"");
            Response.Write("<script>alert('Ad remove Successfully.')</script>");

            DataTable dt2 = ob.dttt("select * from ad where dates='" + System.DateTime.Now.ToString("yyyy-MM-dd") + "'");
            GridView1.DataSource = dt2;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            DateTime sdldate = Convert.ToDateTime(TextBox3.Text);
            DataTable getdailyamt = ob.dttt("select amount from adamount where dates='" + sdldate.ToString("yyyy-MM-dd") + "'");

            try
            {
               
                DataTable getamt = ob.dttt("select sum(cast(amount as real)) from ad where dates='" + sdldate.ToString("yyyy-MM-dd") + "'");
                Label2.Text = (Convert.ToDouble(getdailyamt.Rows[0][0]) - Convert.ToDouble(getamt.Rows[0][0])).ToString();
                if (Label2.Text == "")
                {
                    Label2.Text = getdailyamt.Rows[0][0].ToString();
                }
            }
            catch (Exception jh) { Label2.Text = getdailyamt.Rows[0][0].ToString(); };
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
        try
        {
            DateTime scheule = Convert.ToDateTime(TextBox3.Text);
            DateTime sdldate = Convert.ToDateTime(TextBox3.Text);
            DataTable getdailyamt = ob.dttt("select amount from adamount where dates='" + sdldate.ToString("yyyy-MM-dd") + "'");

            try
            {

                DataTable getamt = ob.dttt("select sum(cast(amount as real)) from ad where dates='" + sdldate.ToString("yyyy-MM-dd") + "'");
                Label2.Text = (Convert.ToDouble(getdailyamt.Rows[0][0]) - Convert.ToDouble(getamt.Rows[0][0])).ToString();
                if (Label2.Text == "")
                {
                    Label2.Text = getdailyamt.Rows[0][0].ToString();
                }
            }
            catch (Exception jh) { Label2.Text = getdailyamt.Rows[0][0].ToString(); }

       
        DataTable dt2 = ob.dttt("select * from ad where dates='" + scheule.ToString("yyyy-MM-dd") + "'");
        GridView1.DataSource = dt2;
        GridView1.DataBind();
        }
        catch (Exception jh) { Label2.Text = "0"; }
    }
}