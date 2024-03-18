using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class User_bill : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        SqlDataReader dt = ob.drrr("select name,address,mobile from register where username='" + TextBox1.Text + "'");

        Session["asa"] = TextBox1.Text;
           
          //  DataTable dt = ob.dttt("select name,address,mobile,username from register where username='" + TextBox1.Text + "'");
           
            if (dt.Read())
            {
                //Label1.Text = dt.GetSqlString(0).ToString();
                //Label8.Text = dt.GetSqlString(1).ToString();
                //Label5.Text = dt.GetSqlString(2).ToString();
                //Label7.Text = System.DateTime.UtcNow.ToString("yyyy-MM-dd");



               Session["a"] = dt.GetSqlString(0).ToString();
               Session["b"] = dt.GetSqlString(1).ToString();
               Session["c"] = dt.GetSqlString(2).ToString();
               Session["d"] = System.DateTime.UtcNow.ToString("yyyy-MM-dd");
               Response.Redirect("~/User/billprint.aspx");


                dt.Close();
           
        }
        else
            {
                dt.Close();
                TextBox1.Text ="";
                Response.Write("<script>alert ('No User Found')</script>");
                
            }
    }
}