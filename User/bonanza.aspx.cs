using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class User_bonanza : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ob.Execute("delete from bonanza");
        ob.Execute("insert into bonanza values('"+TextBox1.Text+"')");
        Response.Write("<script>alert('Bonanza Added Successfully')</script>");
    }
}