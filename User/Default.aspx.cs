using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
public partial class User_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        string lstrIpAddress;
        if (Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null || Request.ServerVariables["HTTP_CLIENT_IP"] != null)
            lstrIpAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        else
            lstrIpAddress = Request.ServerVariables["REMOTE_ADDR"];

        Label1.Text = lstrIpAddress;
    }
   

    //Method 1 to get IP Address visitor
   

    //Method 2 to get IP Address of visitor
   
}