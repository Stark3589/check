using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using TripleITConnection;
using System.Net;

public partial class edit : System.Web.UI.Page
{
    clsConnection objcon = new clsConnection();
    BussinessLayer ob = new BussinessLayer();
    PINCODE pin = new PINCODE();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {

                txtsearchuname.Text = Session["newuser"].ToString();
                //DataTable dt = pin.dttt("select distinct statename from pincode order by statename asc");
                //Drpstate.DataSource = dt;
                //Drpstate.DataTextField = "statename";
                //Drpstate.DataBind();
                //DataTable dt1 = pin.dttt("select distinct districtname from pincode where statename='" + Drpstate.SelectedItem.Text + "' ");
                //Drpcity.DataSource = dt1;
                //Drpcity.DataTextField = "districtname";
                //Drpcity.DataBind();
                //Drpcity.Items.Insert(0, "Select City");
                //SearchDetail();
                SearchDetail();
            }
        }
        catch (Exception ex)
        { }
        //if (!IsPostBack)
        //{
        //    if (Request.QueryString["usr"] != null)
        //    {
        //        txtusersearch.Text = Request.QueryString["usr"].ToString();
        //        SearchDetail();
        //    }
        //}
    }
    void SearchDetail()
    {
        DataTable dt = ob.dttt("select * from register where username='" + txtsearchuname.Text.Trim() + "'");
        if (dt.Rows.Count > 0)
        {

            try
            {
                txtuid.Text = dt.Rows[0]["username"].ToString();
            }
            catch { }
           
            //try
            //{
            //    tez.Text = dt.Rows[0]["tez"].ToString();
            //}
            //catch { }
            try
            {
                txtname.Text = dt.Rows[0]["name"].ToString();
            }
            catch { }

        }
        DataTable dt1 = ob.dttt("select * from bankdetail where username='" + txtsearchuname.Text.Trim() + "'");
        if (dt1.Rows.Count > 0)
        {
            try
            {
                txtbank.Text = dt1.Rows[0]["accno"].ToString();
            }
            catch { }
          
        }
        
    }



    protected void bntpersonal_Click(object sender, EventArgs e)
    {
        try
        {
            //string sql12 = "select * from tblbankupdate where username='" + txtuid.Text + "' and total='1'";
            //DataTable dt12 = ob.dttt(sql12);
            //if (dt12.Rows.Count == 0)
            //{
                string sql1 = "select * from bankdetail where username='" + txtuid.Text + "'";
                DataTable ddd = ob.dttt(sql1);
                if (ddd.Rows.Count == 0)
                {
                    //string sql10 = "update register set  tez='" + tez.Text + "', paytm='" + paytm.Text + "' where username='" + txtuid.Text + "'";
                    //int a = objcon.ExecuteSqlQuery(sql10);
                    //if (a > 0)
                    //{
                        //string sql11 = "update bankdetail set accno='" + txtaccount.Text + "',bankname='" + txtbank.Text + "', ifsc=,branchname=,acctype='" + drptype.SelectedItem.Text + "',holdername= where username='" + txtuid.Text + "'";
                        //int b = objcon.ExecuteSqlQuery(sql11);
                        //if (b > 0)
                       // {
                    string sql112 = "insert into bankdetail (username,accno) values ('" + txtuid.Text + "','" + txtbank.Text + "')";
                            objcon.ExecuteSqlQuery(sql112);
                            Response.Write("<script>alert('Inserted Successfully')</script>");
                           // TXTXOTP.Text = "";
                        }
                        else
                        {


                            string sql112 = "update bankdetail set accno='" + txtbank.Text + "' where username='"+txtuid.Text+"'";
                            objcon.ExecuteSqlQuery(sql112);
                            Response.Write("<script>alert('Record Updated Successfully')</script>");
                }
                    //}
                    //else
                    //{
                    //    Response.Write("<script>alert('Something Wrong In Transfer Detail')</script>");
                    //}
                    //try
                    //{
                    //    var chars11 = "9876543210";
                    //    var stringChars11 = new char[4];
                    //    var random11 = new Random();

                    //    for (int ik = 0; ik < stringChars11.Length; ik++)
                    //    {
                    //        stringChars11[ik] = chars11[random11.Next(chars11.Length)];
                    //    }

                    //    var finalString11 = new String(stringChars11);
                    //    string otp = Convert.ToString(finalString11);
                    //    txtbankotp.Text = otp;
                    //    DataTable dt = ob.dttt("select name,mobile from register where username='" + txtuid.Text + "'");
                    //    try
                    //    {
                    //        string sname = ob.sname();
                    //        string url = ob.url();
                    //        WebClient client = new WebClient();
                    //        string to, msg;
                    //        to = dt.Rows[0][1].ToString();
                    //        string a1 = "Dear ";
                    //        string re = dt.Rows[0][0].ToString();
                    //        string rp = ", Your ";
                    //        string a2 = "Banka Account Update  otp is: ";
                    //        string a3 = otp;
                    //        string a4 = "";
                    //        string a5 = "";
                    //        string aaa = "";
                    //        string a6 = url;
                    //        msg = a1 + re + rp + a2 + a3 + a4 + a5 + aaa + a6;
                    //        double messto = Convert.ToDouble(to);
                    //        ob.SENDSMS(to, msg);
                    //        ////string baseurl = "http://trans.dynamicitsolution.com/api/sendmsg.php?user=bhomis&pass=123456&sender=BREILT&phone=" + messto + "&text=" + msg + "&priority=ndnd&stype=normal";
                    //        //string baseurl = "http://sms.dynamicitsolution.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=d9d9f88772b5adecd067f84a62db83ed&message=" + msg + "&senderId=REALPB&routeId=1&mobileNos=" + messto + "&smsContentType=english";
                    //        //client.OpenRead(baseurl);

                    //    }
                    //    catch (Exception) { }


                    //}
                    //catch (Exception ex) { }
                    //TXTXOTP.Visible = true;
                    ////txtbankotp.Text = true;
                    //btnopt.Visible = true;
                    //bntpersonal.Visible = false;
                }
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('You Already Updated Profile 1 Time')</script>");
        //    }
        //}
        catch (Exception ex)
        { }
    }
      

    //protected void Drpstate_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    DataTable dt1 = pin.dttt("select distinct districtname from pincode where statename='" + Drpstate.SelectedItem.Text + "' ");
    //    Drpcity.DataSource = dt1;
    //    Drpcity.DataTextField = "districtname";
    //    Drpcity.DataBind();
    //    Drpcity.Items.Insert(0, "Select City");
    //}
    //protected void btnopt_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        if (TXTXOTP.Text == txtbankotp.Text)
    //        {
    //            string sql112 = "select * from tblbankupdate where username='" + txtuid.Text + "' and total='1'";
    //            DataTable dt12 = ob.dttt(sql112);
    //            if (dt12.Rows.Count == 0)
    //            {
    //                //string sql10 = "update register set  tez='" + tez.Text + "', paytm='" + paytm.Text + "' where username='" + txtuid.Text + "'";
    //                //int a = objcon.ExecuteSqlQuery(sql10);
    //                //if (a > 0)
    //                //{
    //                    string sql11 = "update bankdetail set accno='" + txtaccount.Text + "',bankname='" + txtbank.Text + "', ifsc='" + txtifsc.Text + "',branchname='" + txtbranch.Text + "',acctype='" + drptype.SelectedItem.Text + "',holdername='" + txtaccountholder.Text + "' where username='" + txtuid.Text + "'";
    //                    int b = objcon.ExecuteSqlQuery(sql11);
    //                    if (b > 0)
    //                    {
    //                        string sql12 = "insert into tblbankupdate (username,total,ptotal) values ('" + txtuid.Text + "','1','0')";
    //                        int c = objcon.ExecuteSqlQuery(sql12);
    //                        Response.Write("<script>alert('Updated Successfully')</script>");
    //                        TXTXOTP.Text = "";
    //                    }
    //                    else
    //                    {
    //                        Response.Write("<script>alert('Something Wrong In Bank Detail')</script>");
    //                    }
    //                //}
    //                //else
    //                //{
    //                //    Response.Write("<script>alert('Something Wrong In Transfer Detail')</script>");
    //                //}

    //            }
    //            else
    //            {
    //                Response.Write("<script>alert('You Already Updated Profile 1 Time')</script>");
    //            }
    //        }
    //        else
    //        {
    //            Response.Write("<script>alert('You OTP IS NOT MACTH')</script>");
    //        }

    //    }
    //    catch (Exception)
    //    {
    //        Response.Write("<script>alert('Something Is Wrong !!!!!!')</script>");
    //    }

    //}
}
