using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_pinpasschane : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox2.Text==TextBox3.Text)
        {
            string sql = "select password from pinpass";
            DataTable dt = ob.dttt(sql);
            string oldpass = dt.Rows[0][0].ToString();
            if(oldpass==TextBox1.Text)
            {
                ob.Execute("update pinpass set password='" + TextBox3.Text + "' ");
                Response.Write("<script>alert('Password Updated')</script>");
            }
            else
            {
                Response.Write("<script>alert('Wrong Entry Of Old Password')</script>");
            }
        }
    }
}