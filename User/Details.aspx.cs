using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_Details : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["username"] != null)
            {
                try
                {
                    DataTable dt = ob.dttt("select status,name,address,mobile,sex,email,reffid,dateofjoin from register where username='" + Session["username"].ToString() + "'");
                    Label2.Text = dt.Rows[0][0].ToString().ToUpper();
                    Label3.Text = Session["username"].ToString();
                    Label4.Text = dt.Rows[0][1].ToString();
                    Label5.Text = dt.Rows[0][5].ToString();
                    Label6.Text = dt.Rows[0][3].ToString();
                    Label7.Text = dt.Rows[0][4].ToString();
                    Label8.Text = dt.Rows[0][2].ToString();
                    Label9.Text = dt.Rows[0][6].ToString();
                    Label19.Text = dt.Rows[0][7].ToString();
                    try
                    {
                        DataTable dt2 = ob.dttt("select name from register where username='" + Label9.Text + "'");
                        Label10.Text = dt2.Rows[0][0].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        DataTable dt3 = ob.dttt("select sponser from refferal where refferal='" + Session["username"].ToString() + "'");
                        Label11.Text = dt3.Rows[0][0].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        DataTable dt4 = ob.dttt("select email from register where username='" + Label11.Text + "'");
                        Label12.Text = dt4.Rows[0][0].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        DataTable dt5 = ob.dttt("select accno,bankname,ifsc,branchname,holdername from bankdetail where username='" + Session["username"].ToString() + "'");
                        Label13.Text = dt5.Rows[0][4].ToString();
                        Label14.Text = dt5.Rows[0][1].ToString();
                        Label15.Text = dt5.Rows[0][3].ToString();
                        Label17.Text = dt5.Rows[0][0].ToString();
                        Label16.Text = dt5.Rows[0][2].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        DataTable dt6 = ob.dttt("select card,coupon from approval where username='" + Session["username"].ToString() + "'");
                        Label21.Text = dt6.Rows[0][0].ToString();
                        Label22.Text = dt6.Rows[0][1].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        DataTable dt7 = ob.dttt("select image from images where username='" + Session["username"].ToString() + "'");
                        Image1.ImageUrl = dt7.Rows[0][0].ToString();
                    }
                    catch (Exception) { }
                }
                catch (Exception) { }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

       
        Session["verify"] = Label3.Text;
        Response.Write("<script>");
        Response.Write("window.open('Welcome.aspx','_blank')");
        Response.Write("</script>");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Visible = true;
        TextBox2.Visible = true;
       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            ob.Execute("update approval set card='" + TextBox1.Text + "',coupon='" + TextBox2.Text + "' where username='" + Label3.Text + "'");
            Response.Redirect("Details.aspx");
        }catch(Exception){}
    }
}