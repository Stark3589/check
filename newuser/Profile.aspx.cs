using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class newuser_Profile : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["newuser"] != null)
            {
                DataTable dt = ob.dttt("select status,name,address,mobile,sex,email,reffid,dateofjoin from register where username='" + Session["newuser"].ToString() + "'");
                Label2.Text = dt.Rows[0][0].ToString().ToUpper();
                Label3.Text = Session["newuser"].ToString();
                Label4.Text = dt.Rows[0][1].ToString();
                TextBox1.Text = dt.Rows[0][5].ToString();
                TextBox2.Text = dt.Rows[0][3].ToString();
                Label7.Text = dt.Rows[0][4].ToString();
                TextBox3.Text = dt.Rows[0][2].ToString();
                Label9.Text = dt.Rows[0][6].ToString();
                Label19.Text = dt.Rows[0][7].ToString().Substring(0,10);
                DataTable dt2 = ob.dttt("select name from register where username='" + Label9.Text + "'");
                Label10.Text = dt2.Rows[0][0].ToString();
                DataTable dt3 = ob.dttt("select sponser from refferal where refferal='" + Session["newuser"].ToString() + "'");
                Label11.Text = dt3.Rows[0][0].ToString();
                DataTable dt4 = ob.dttt("select email from register where username='" + Label11.Text + "'");
                Label12.Text = dt4.Rows[0][0].ToString();
                DataTable dt5 = ob.dttt("select accno,bankname,ifsc,branchname,holdername from bankdetail where username='" + Session["newuser"].ToString() + "'");
                TextBox4.Text = dt5.Rows[0][4].ToString();
                TextBox5.Text = dt5.Rows[0][1].ToString();
                TextBox6.Text = dt5.Rows[0][3].ToString();
                TextBox8.Text = dt5.Rows[0][0].ToString();
                TextBox7.Text = dt5.Rows[0][2].ToString();
                try
                {
                    DataTable dt6 = ob.dttt("select card,coupon from approval where username='" + Session["newuser"].ToString() + "'");
                    Label21.Text = dt6.Rows[0][0].ToString();
                    Label22.Text = dt6.Rows[0][1].ToString();
                }
                catch (Exception) { Label21.Text = ""; Label22.Text = ""; }
                DataTable dt7 = ob.dttt("select image from images where username='" + Session["newuser"].ToString() + "'");
                Image1.ImageUrl = dt7.Rows[0][0].ToString();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ob.Execute("update register set address='" + TextBox3.Text + "',mobile='" + TextBox2.Text + "',email='" + TextBox1.Text + "' where username='" + Session["newuser"].ToString() + "' ");
        ob.Execute("update bankdetail set accno='" + TextBox8.Text + "',bankname='" + TextBox6.Text + "',ifsc='" + TextBox7.Text + "',branchname='" + TextBox6.Text + "',holdername='" + TextBox4.Text + "' where username='" + Session["newuser"].ToString() + "'");
        Response.Write("<script>alert('Detail Updated Successfully')</script>");
        Response.Redirect("profile.aspx");
    }
}