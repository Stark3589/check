using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using TripleITTransaction;

public partial class forgotpassword : System.Web.UI.Page
{
    
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtmobile.Text.Length == 10)
            {
                string query = "select password from register where username='" + txtusername.Text + "' and mobile='" + txtmobile.Text + "'";
                DataTable dt = ob.dttt(query);
                if (dt.Rows.Count > 0)
                {
                    string pass = dt.Rows[0]["password"].ToString();
                    //string mobile = dt.Rows[0]["mobile"].ToString();


                    try
                    {
                        WebClient client = new WebClient();
                        string to, msg;
                        to = txtmobile.Text;
                        string a1 = "Dear Sir/Mam";
                        string a2 = ", Welcome to My Dream India,";
                        string a3 = " Your Password is ,-";
                        string a4 = pass;
                        string a5 = " - ";
                        string a6 = "http://mydreamindia.in";
                        //string a4 = " Password - ";
                        //string a5 = txtpass.Text;
                        ////string a5 = ViewState["pass"].ToString();
                        //string aaa = "";
                        //string a8 = " Thanks for you choosing BitCoin.";
                        // msg = a1 + re + rp + a2 + a3 + a4 + a5 + aaa + a8;
                        msg = a1 + a2 + a3 + a4 + a5 + a6;
                        double messto = Convert.ToDouble(to);
                        string baseurl = "http://msg.kiriinfotech.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=fb6c31db313998f70aaf5634e3b8898&message=" + msg + "&senderId=SIGNUP&routeId=1&mobileNos=" + messto + "&smsContentType=english";
                     
                        client.OpenRead(baseurl);

                    }
                    catch (Exception) { }
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Message Send Successfully !');window.location='login.aspx';", true);
                }
                else
                {
                    Response.Write("<script>alert('Invalid UserName OR Mobile Number')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Mobile Number Length Not Equal To 10 Digits')</script>");
            }
        }


        catch (Exception) { }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}