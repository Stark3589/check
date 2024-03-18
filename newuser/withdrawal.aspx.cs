using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Data;
using System.Configuration;


public partial class Admin_withdrawal : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

        show();
       
        
    }
    public void show()
    {
        try
        {
            // DataTable drcr = ob.dttt("select sum(cast(debit as real)) from account where username='" + Session["newuser"].ToString() + "' ");
            DataTable drcr1 = ob.dttt("select (sum(cast(credit as real))-sum(cast(debit as real))) from account where username='" + Session["newuser"].ToString() + "'");
            double d1 = 0, d2 = 0, d3 = 0;
            try
            {
                DataTable drcr2 = ob.dttt("select sum(cast(total_amt as real)) from withdrawal where username='" + Session["newuser"].ToString() + "' ");
                d1 = Convert.ToDouble(drcr2.Rows[0][0]);


            }
            catch (Exception jh)
            {
                d1 = 0;
                d2 = 0;
                d3 = 0;
            };
            double total = Convert.ToDouble(drcr1.Rows[0][0]) - d1 - d2 - d3;


            Label1.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
            if (Label1.Text == "")
            {
                Label1.Text = "0";
            }
            // TextBox1.Text = "200";
            // Label2.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
        }
        catch (Exception) { Label1.Text = "0"; };
    }
    public static string EncodePasswordToBase64(string password)
    {
        try
        {
            byte[] encData_byte = new byte[password.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
            string encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;
        }
        catch (Exception ex)
        {
            throw new Exception("Error in base64Encode" + ex.Message);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button2.Enabled = false;
      
       
               if (DropDownList1.SelectedItem.Text == "Transfer in Wallet Address")
               {
                   //if (System.DateTime.Now.DayOfWeek.ToString() == "Saturday" || System.DateTime.Now.DayOfWeek.ToString() == "Monday")
                   //{
                    DataTable mobileno = ob.dttt("select * from register where username='" + Session["newuser"].ToString() + "' and mobile!=''");
                       if (mobileno.Rows.Count > 0)
                       {
                       DataTable countsponser = ob.dttt("select * from bankdetail where username='" + Session["newuser"].ToString() + "' and accno!=''");
                       if (countsponser.Rows.Count > 0)
                       {
                           //DataTable dtd = ob.dttt("select max(cast(amount as int)) from tblactiveamount where username='" + Session["newuser"].ToString() + "'");
                           int maxamt = 0;


                           if ((Convert.ToDouble(Label1.Text) >= Convert.ToDouble(TextBox1.Text)) && (Convert.ToDouble(TextBox1.Text) >= 5 && (Convert.ToDouble(TextBox1.Text)%5==0)))
                           {
                               double a, b, c = 0;
                               a = Convert.ToDouble(Label1.Text);
                               b = Convert.ToDouble(TextBox1.Text);

                               string ddd = Convert.ToDateTime(ob.utc()).ToString("yyyy-MM-dd");


                               double d11 = Convert.ToDouble(TextBox1.Text);
                               double d21 = 0.0;
                               double d22 = 0.0;

                               d21 = ((d11 * 0) / 100);

                               d22 = ((d11 * 10) / 100);
                               double total1 = d11 - d22 - d21;
                               DataTable dt = ob.dttt("select * from withdrawal where USERNAME='" + Session["newuser"].ToString() + "' and dates='" + ddd + "' and  amount='" + total1 + "'");
                               if (dt.Rows.Count > 0)
                               {
                                   ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Already Requested');window.location='withdrawal.aspx';", true);

                               }
                               else
                               {


                                   //string status = transfer(Session["newuser"].ToString());
                                   //if (status == "SUCCESS")
                                   //{

                                   ob.Execute("insert into withdrawal values('" + Session["newuser"].ToString() + "','" + TextBox5.Text + "','" + ddd + "','Pending','" + ddd + "','" + d21 + "','','" + d22 + "','" + TextBox1.Text + "','0','')");
                                  


                                   try
                                   {
                                       DataTable drcr = ob.dttt("select sum(cast(debit as real)) from account where username='" + Session["newuser"].ToString() + "' ");
                                       DataTable drcr1 = ob.dttt("select (sum(cast(credit as real))-sum(cast(debit as real))) from account where username='" + Session["newuser"].ToString() + "' and valu!='GIFT WALLET' ");
                                       double d1 = 0, d2 = 0, d3 = 0;
                                       try
                                       {
                                           DataTable drcr2 = ob.dttt("select sum(cast(total_amt as real)) from withdrawal where username='" + Session["newuser"].ToString() + "'");
                                           d1 = Convert.ToDouble(drcr2.Rows[0][0]);


                                       }
                                       catch (Exception jh)
                                       {
                                           d1 = 0;
                                           d2 = 0;
                                           d3 = 0;
                                       };
                                       double total = Convert.ToDouble(drcr1.Rows[0][0]) - d1 - d2 - d3;



                                       Label1.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
                                       // TextBox1.Text = "200";
                                       // Label2.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
                                   }
                                   catch (Exception) { };
                                   ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Amount Transfer Successfully');window.location='homefrn.aspx';", true);

                                   //  }




                               }
                           }
                           else
                           {
                               Response.Write("<script>alert(' !! Insufficient Balance !!')</script>");
                           }

                       }
                       else
                       {
                           Response.Write("<script>alert(' !! Please Update your wallet details first then try withdrawal !!')</script>");
                       }
                       }
                       else
                       {
                           Response.Write("<script>alert(' !! Please Update your mobile no first then try withdrawal !!')</script>");
                       }
                   //}
                   //else
                   //{
                   //    Response.Write("<script>alert(' !! Saturday and monday withdrawal !!')</script>");
                   //}
               }
                   
               if (DropDownList1.SelectedItem.Text == "Transfer in Fund Wallet")
               {
                   if ((Convert.ToDouble(Label1.Text) >= Convert.ToDouble(TextBox1.Text)) && (Convert.ToDouble(TextBox1.Text) >= 5))
                   {

                       double a, b, c = 0;
                       a = Convert.ToDouble(Label1.Text);
                       b = Convert.ToDouble(TextBox1.Text);

                       string ddd = Convert.ToDateTime(ob.utc()).ToString("yyyy-MM-dd");


                       double d11 = Convert.ToDouble(TextBox1.Text);
                       double d21 = 0.0;
                       double d22 = 0.0;

                       d21 = ((d11 * 0) / 100);

                       d22 = ((d11 * 5) / 100);
                       double total1 = d11 - d22 - d21;
                       string yy = Convert.ToDateTime(ob.utc()).ToString("yyyy-MM-dd");

                       ob.Execute("insert into fundaccount (username,credit,debit,date,status) values('" + Session["newuser"].ToString() + "','" + total1.ToString() + "','0','" + yy + "','TRANSFER FROM WALLET')");
                       ob.Execute("insert into account (username,credit,debit,date,valu) values('" + Session["newuser"].ToString() + "','0','" + total1.ToString() + "','" + yy + "','TRANSFER TO FUND WALLET')");
                       try
                       {
                           DataTable drcr = ob.dttt("select sum(cast(debit as real)) from account where username='" + Session["newuser"].ToString() + "' ");
                           DataTable drcr1 = ob.dttt("select (sum(cast(credit as real))-sum(cast(debit as real))) from account where username='" + Session["newuser"].ToString() + "' and valu!='GIFT WALLET' ");
                           double d1 = 0, d2 = 0, d3 = 0;
                           try
                           {
                               DataTable drcr2 = ob.dttt("select sum(cast(total_amt as real)) from withdrawal where username='" + Session["newuser"].ToString() + "'");
                               d1 = Convert.ToDouble(drcr2.Rows[0][0]);


                           }
                           catch (Exception jh)
                           {
                               d1 = 0;
                               d2 = 0;
                               d3 = 0;
                           };
                           double total = Convert.ToDouble(drcr1.Rows[0][0]) - d1 - d2 - d3;



                           Label1.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
                           // TextBox1.Text = "200";
                           // Label2.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
                           Response.Write("<script>alert(' !! Fund Transfer Successfully !!')</script>");
                       }
                       catch (Exception) { };
                   }
                   else
                   {
                       Response.Write("<script>alert(' !! Insufficient Balance !!')</script>");
                   }
               }
               
              
          
               
    }
   
    protected void Button1_Click(object sender, EventArgs e)              //request
    {
        string mm = System.DateTime.UtcNow.DayOfWeek.ToString();

       

    }
   
    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Transfer in Fund Wallet")
        {
            try
            {

                double d11 = Convert.ToDouble(TextBox1.Text);
                double d24 = Convert.ToDouble(Label1.Text);
                if (d11 <= d24 && d11 % 5 == 0)
                {
                    double d21 = 0.0;
                    double d22 = 0.0;
                    double d23 = 0.0;

                    d21 = ((d11 * 0) / 100); ;
                    TextBox2.Text = d21.ToString();
                    d22 = ((d11 * 5) / 100);
                    TextBox2.Text = d22.ToString();

                    TextBox5.Text = (d11 - d21 - d22).ToString();
                }
                else
                {
                    Response.Write("<script>alert(' !! Insufficient Balance !!')</script>");
                    Button2.Enabled = false;

                    Button2.BackColor = System.Drawing.Color.Red;
                    TextBox1.Text = "";
                }
            }
            catch (Exception hg) { };

           
        }
        else
        {
            try
            {

                double d11 = Convert.ToDouble(TextBox1.Text);
                double d24 = Convert.ToDouble(Label1.Text);
                if (d11 <= d24 && d11 % 5 == 0)
                {
                    double d21 = 0.0;
                    double d22 = 0.0;
                    double d23 = 0.0;

                    d21 = ((d11 * 0) / 100); ;
                    TextBox2.Text = d21.ToString();
                    d22 = ((d11 *10) / 100);
                    TextBox2.Text = d22.ToString();

                    TextBox5.Text = (d11 - d21 - d22).ToString();
                }
                else
                {
                    Response.Write("<script>alert(' !! Insufficient Balance !!')</script>");
                    Button2.Enabled = false;
                   
                    Button2.BackColor = System.Drawing.Color.Red;
                    TextBox1.Text = "";
                }
            }
            catch (Exception hg) { };
        }

    }
    //public string transfer(string username)
    //{
    //    DataTable dt = ob.dttt("select holdername,accno,ifsc from bankdetail where username='" + username + "'");
    //    string name = dt.Rows[0][0].ToString();
    //    string account = dt.Rows[0][1].ToString();
    //    string ifsc = dt.Rows[0][2].ToString();
    //    //string name = "Ajeet Kumar Sharma";
    //    //string account = "3647001500013871";
    //    //string ifsc = "PUNB0364700";
    //    var chars = "1234567890";
    //    var stringChars1 = new char[6];
    //    var random = new Random();

    //    for (int ik = 0; ik < stringChars1.Length; ik++)
    //    {
    //        stringChars1[ik] = chars[random.Next(chars.Length)];
    //    }

    //    var finalString1 = new String(stringChars1);
    //    string capta1 = username + Convert.ToString(finalString1);
    //    Label2.Text = capta1;
    //    WebClient client = new WebClient();
    //    ServicePointManager.Expect100Continue = true;
    //    ServicePointManager.DefaultConnectionLimit = 9999;
    //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;

    //    string baseurl = "http://mobilerechargenow.com/api/v2/dmt/quicktransfer.php?username=G211431995&apikey=1149972748&beneficiaryname=" + name + "&beneficiaryacc=" + account + "&ifsccode=" + ifsc + "&amount=" + Convert.ToDouble(TextBox5.Text) + "&txnid=" + capta1 + "";

    //    var strem = client.OpenRead(baseurl);

    //    StreamReader sr = new StreamReader(strem);
    //    // Console.WriteLine();
    //    // Label2.Text = sr.ReadToEnd().ToString();

    //    // Close the stream. 



    //    //  XElement xmlroot = System.Xml.Linq.XElement.Parse(strem);
    //    // string firstNodeContent = ((System.Xml.Linq.XElement)(xmlroot.FirstNode)).Value;

    //    dynamic stuff = JsonConvert.DeserializeObject(sr.ReadToEnd().ToString());
    //    string Message = stuff.status;
    //    // string trid = stuff.rocket_trans_id;
    //    //string datetime = stuff.datetime;
    //    //string opname = stuff.operator_name;
    //    //string optrid = stuff.opr_transid;
    //    //string roctrid = stuff.rocket_trans_id;
    //    //string amt = stuff.trans_amount;





    //    strem.Close();
    //    return Message;
    //}

  
}