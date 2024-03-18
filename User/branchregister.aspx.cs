using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_branchregister : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            
            DataTable gh = ob.dttt("select name,fname,mobile from register where username='"+TextBox1.Text+"'");
            string kk = gh.Rows[0][0].ToString();
            string ll = gh.Rows[0][1].ToString();
            string mm = gh.Rows[0][2].ToString();
            Label2.Visible = true;
            Label2.Text = kk + " S/O " + ll + "</br>" + "Mob: " + mm;
        }
        catch 
        {
            Label2.Visible = false;
            TextBox1.Text = "";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
        {
            try
            {
                SqlDataReader ddr = ob.drrr("select * from franchise where username='" + TextBox1.Text + "' and franchise='" + TextBox2.Text + "'");
                if (ddr.Read())
                {
                    ddr.Close();
                    Response.Write("<script>alert('Franchise Already Registered On This User Name')</script>");
                }
                else
                {
                    ddr.Close();
                    ob.Execute("insert into franchise values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + System.DateTime.UtcNow.ToString("yyyy-MM-dd") + "')");

                    Response.Write("<script>alert('Franchise Registeration Successfull')</script>");
                   
                }
            }
            catch { Response.Write("<script>alert('Something Went Wrong')</script>"); }
        }
        else
        {
           
            Response.Write("<script>alert('Fill All Field Correctly')</script>");
        }
    }
}