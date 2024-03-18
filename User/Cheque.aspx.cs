using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;

public partial class User_Cheque : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ob.Execute("delete from daily_sponsercountincome where username='" + Label4.Text + "' and lvl=(select max(lvl) from daily_sponsercountincome where username='" + Label4.Text + "')");
        ob.Execute("update sponser set sponser='"+TextBox1.Text+"' where username='"+TextBox3.Text+"'");
        try
        {
            SqlDataReader getlvldr = ob.drrr("select * from daily_sponsercountincome where username='" + TextBox1.Text + "'");
            if (getlvldr.Read())
            {
                ob.CloseConn();
                DataTable getlvl = ob.dttt("select max(lvl) from daily_sponsercountincome where username='" + TextBox1.Text + "'");
                int c = Convert.ToInt32(getlvl.Rows[0][0]) + 1;
                ob.Execute("insert into daily_sponsercountincome values('" + TextBox1.Text + "'," + c + ")");
            }
            else
            {
                ob.CloseConn();
                ob.Execute("insert into daily_sponsercountincome values('" + TextBox1.Text + "',1)");
            }

        }
        catch (Exception jh) { };
        Response.Write("<script>alert('Sponser Updated Successfully')</script>");
        TextBox1.Text = "";
        TextBox3.Text = "";
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable getname = ob.dttt("select name from register where username='"+TextBox3.Text+"'");
            Label2.Text = getname.Rows[0][0].ToString();

        }
        catch { }
        try
        {
            DataTable getspon = ob.dttt("select sponser from sponser where username='" + TextBox3.Text + "'");
            Label4.Text = getspon.Rows[0][0].ToString();

        }
        catch { }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable getname = ob.dttt("select name from register where username='" + TextBox1.Text + "'");
            Label3.Text = getname.Rows[0][0].ToString();

        }
        catch { }
    }
}