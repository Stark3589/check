using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class User_coupongen : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select username,name from register where username='"+TextBox1.Text+"'");
        Label2.Text=dt.Rows[0][1].ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var stringChars = new char[8];
        var random = new Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        var finalString = new String(stringChars);
        Label3.Text = finalString.ToString();

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(TextBox2.Text)*1000;
        int y = Convert.ToInt32(TextBox3.Text)*500;
        int z = Convert.ToInt32(TextBox4.Text)*100;
        int a = x + y + z;
        if (Label3.Text!="no-code" &&TextBox1.Text!=null && a==2600)
        {
            ob.Execute("insert into coupon (username,code,thous,fhund,ohund) values ('" + TextBox1.Text + "','" + Label3.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')");
            Session["username"] = TextBox1.Text;
            Response.Redirect("confirm.aspx");
        }
        else
        {
            Response.Write("<script>alert('Something Wrong')</script>"); 
        }

    }
}