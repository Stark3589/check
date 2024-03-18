using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["SID"] != null)
        {
            Session["newuser"] = Request.QueryString["SID"].ToString();
            Label1.Text = Request.QueryString["SID"];


        }
       
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("../newuser/homefrn.aspx");
    }
   
}