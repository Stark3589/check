using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_rogh : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!SM1.IsInAsyncPostBack)

        //    Session["timeout"] = DateTime.Now.AddMinutes(30).ToString();

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < 50; i++)
        {
            ob.Execute("insert into level(lavel)values('1')");
        }
        for (int i = 0; i < 200; i++)
        {
            ob.Execute("insert into level(lavel)values('2')");
        }
        for (int i = 0; i < 800; i++)
        {
            ob.Execute("insert into level(lavel)values('3')");
        }
        for (int i = 0; i < 3200; i++)
        {
            ob.Execute("insert into level(lavel)values('4')");
        }
        for (int i = 0; i < 12800; i++)
        {
            ob.Execute("insert into level(lavel)values('5')");
        }
        for (int i = 0; i < 51200; i++)
        {
            ob.Execute("insert into level(lavel)values('6')");
        }
        for (int i = 0; i < 204800; i++)
        {
            ob.Execute("insert into level(lavel)values('7')");
        }

        Response.Write("<script>alert('Kaam Ho Gya')</script>");
    }
}