using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Net;

public partial class registeration1 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    business obb = new business();
    PINCODE pin = new PINCODE();
    int number;

    private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

    protected void Page_Load(object sender, EventArgs e)
    {

        
        if (!IsPostBack)
        {
            //try
            //{
            //    DataTable dts = ob.dttt("select * from pinmgt where username='Admin' and status!='Used'");
            //    string ppp = dts.Rows[0]["pin"].ToString();
           

            //TextBox23.Text = ppp;

            //}
            //catch { }

            //try
            //{
            //    DataTable dt = ob.dttt("select * from pinmanage where holder='" + Session["newuser"].ToString() + "' and reguser is null");
            //    txt_pin.Text = dt.Rows[0][0].ToString();
            //}
            //catch (Exception jjh) { txt_pin.Text = ""; };


            var chars = "abcdefg123456789";
            var stringChars = new char[6];
            var random = new Random();

            for (int ik = 0; ik < stringChars.Length; ik++)
            {
                stringChars[ik] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            string capta = Convert.ToString(finalString);
            password.Text = capta;
            TextBox21.Text = EncodePasswordToBase64(capta);
            var chars1 = "0123456";
            var stringChars1 = new char[6];
            var random1 = new Random();

            for (int jk = 0; jk < stringChars1.Length; jk++)
            {
                stringChars1[jk] = chars1[random1.Next(chars1.Length)];
            }

            var finalString1 = new String(stringChars1);
            string capta1 = Convert.ToString(finalString1);
            txnpassword.Text = capta1;
            txt_pin.Text = EncodePasswordToBase64(capta1);
        }

        
        if (!IsPostBack)
        {
            setuser();
            loadstate();
           
        }
        if (!IsPostBack)
        {

            string day1 = System.DateTime.UtcNow.Day.ToString();
            string month1 = System.DateTime.UtcNow.Month.ToString();
            string year1 = System.DateTime.UtcNow.Year.ToString();
            TextBox22.Text = day1 + "/" + month1 + "/" + year1;
        
        }


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
    protected void Button5_Click(object sender, EventArgs e)
    {
        //string strcon = "Data Source=HP-PC;Initial Catalog=successlife;Integrated Security=True; Connection Timeout=1000";
     
            if (TextBox2.Text != "" && txtsponser.Text!="" )
            {
                SqlDataReader da = ob.drrr("select * from register where username='" + TextBox2.Text + "'");
                if (da.Read())
                {
                    da.Close();
                    Response.Write("<script>alert('Id Already Exists...')</script>");
                }

                else
                {
                   da.Close();
                   SqlDataReader dr = ob.drrr("select * from register where username='" + txtsponser.Text + "' and status='Active'");
                    if (dr.Read())
                    {
                       
                        ob.CloseConn();

                        try
                        {
                            //SqlDataReader dab = ob.drrr("select * from pinmgt where  pin='"+TextBox23.Text+"' and status!='Used'");
                            //if (dab.Read())
                            //{
                            //    dab.Close();
                            try
                            {
                                number = Convert.ToInt32(Session["count"].ToString());
                                int jj = number;
                                int fi = jj + 1;
                                ob.Execute("update code set code='" + fi + "'");
                            }
                            catch { }
                            string strDate = TextBox22.Text; //Format – dd/MM/yyyy
                            //split string date by separator, here I'm using '/'
                            DateTime dte = DateTime.Parse(strDate);
                            string date = dte.ToString("yyyy-MM-dd");
                            //string date = TextBox22.Text;


                            DateTime utcTime = DateTime.UtcNow;
                            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                            DateTime timenow = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                            string tme = timenow.ToString("hh:mm tt");

                            DateTime indiantime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);

                            String tttt = indiantime.ToString("dd/MM/yyyy hh:mm tt");
                            //get username from register to count for level income
                            DataTable register_table = ob.dttt("select username from register");

                            string invoice = "";

                            //    string str = "select code from tle_cd_dy ";
                            //    DataTable dt1 = ob.dttt(str);
                            //    if (dt1.Rows.Count > 0)
                            //    {
                            //        string code1 = dt1.Rows[0]["code"].ToString();

                            //        int aco = Convert.ToInt32(code1.Length.ToString());
                            //        if (aco == 1)
                            //        {
                            //            invoice = "MB" + "000000" + code1;
                            //        }
                            //        if (aco == 2)
                            //        {
                            //            invoice = "MB" + "00000" + code1;
                            //        }
                            //        if (aco == 3)
                            //        {
                            //            invoice = "MB"+ "0000" + code1;
                            //        }
                            //        if (aco == 4)
                            //        {
                            //            invoice = "MB" + "000" + code1;
                            //        }

                            //string invoice = "MB/0000" + codee;




                            ob.Execute("insert into register(reffid,reffname,name,username,password,dateofjoin,city,state,country,mobile,status,rtime,Dateofjoining,payment_mode,invoice_no,onside) values('" + txtsponser.Text + "','" + lbsponser.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "','" + TextBox21.Text + "','" + date + "','','','','" + TextBox8.Text + "','Not Active','" + tme + "','" + tttt + "','','','"+txt_pin.Text+"')");

                            ob.Execute("insert into account (username,credit,debit,total) values('" + TextBox2.Text + "','0','0','0')");
                            //  ob.Execute("insert into account (username,credit,debit,date,total,valu) values('" + txtsponser.Text + "','200','0','" + date + "','200','Sponser Income')");
                            ob.Execute("insert into total_binarycount (username,leftcount) values('" + TextBox2.Text + "','0')");
                            //ob.Execute("update binary set l='" + TextBox2.Text + "' where reff='" + DropDownList5.SelectedItem.Text + "'");
                           // ob.Execute("insert into binary(reff,l,r,m,lm,lr,count) values('" + TextBox2.Text + "','0','0','0','0','0','0')");
                            //ob.Execute("update pinmgt set reguser='" + TextBox2.Text + "',status='Used' where pin='" + TextBox23.Text + "'");
                            ob.Execute("insert into sponser values('" + TextBox2.Text + "','" + txtsponser.Text + "','0')");



                            // biney(TextBox2.Text);



                            string reffid = TextBox2.Text;
                            int x = 0;

                            //Daily purchse count
                            while (x == 0)
                            {
                                try
                                {

                                    ob.CloseConn();
                                    DataTable dt12 = ob.dttt("select reff from binary where l='" + reffid + "' or m='" + reffid + "' or r='" + reffid + "' or lr='" + reffid + "' or lm='" + reffid + "'");
                                    string sss = dt12.Rows[0][0].ToString();

                                    DataTable dt33 = ob.dttt("select leftcount from total_binarycount where username='" + sss + "' ");
                                    int s1 = Convert.ToInt32(dt33.Rows[0][0].ToString());
                                    s1 = s1 + 1;
                                    ob.Execute("update total_binarycount set leftcount ='" + s1.ToString() + "' where username='" + sss + "'");

                                    reffid = sss;



                                }
                                catch (Exception)
                                {
                                    x = 1;
                                };
                            }

                            //downline count
                            //stored Procedure
                            //try
                            //{
                            //    SqlConnection con = new SqlConnection(strcon);
                            //    con.Open();
                            //    SqlCommand cmd = new SqlCommand("[dbo].[regi]", con);
                            //    cmd.CommandType = CommandType.StoredProcedure;
                            //    cmd.Parameters.AddWithValue("@USERNAME", TextBox2.Text);

                            //    cmd.ExecuteNonQuery();

                            //    con.Close();
                            //}catch(Exception jh){}
                            //try
                            //{
                            //    SqlConnection con = new SqlConnection(strcon);
                            //    con.Open();
                            //    SqlCommand cmd = new SqlCommand("[dbo].[regis]", con);
                            //    cmd.CommandType = CommandType.StoredProcedure;
                            //    cmd.Parameters.AddWithValue("@USERNAME1", TextBox2.Text);

                            //    cmd.ExecuteNonQuery();

                            //    con.Close();
                            //}
                            //catch (Exception jh) { }
                           // ob.Execute("update pinmanage set reguser='" + TextBox2.Text + "',dates='" + date + "' where pin='" + txt_pin.Text + "' ");

                            try
                            {
                                 SqlConnection con = new SqlConnection(ob.ConnectString);
                                con.Open();
                                SqlCommand cmd = new SqlCommand("[dbo].[sponserdown]", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@USERNAME1", TextBox2.Text);

                                cmd.ExecuteNonQuery();

                                con.Close();
                            }
                            catch (Exception jh) { }
                           

                            //// Direct income

                            //try
                            //{
                            //    WebClient client = new WebClient();
                            //    string to, msg;
                            //    to = TextBox8.Text;
                            //    string a1 = "Dear ";
                            //    string re = TextBox3.Text;
                            //    string rp = ", Welcome to Ailes Digital Marketing. Your ";
                            //    string a2 = "User Id :-";
                            //    string a3 = TextBox2.Text + " And";
                            //    string a4 = " Password - ";
                            //    string a5 = TextBox21.Text;
                            //    string aaa = "";
                            //    string a6 = " .";
                            //    string a7 = " Visit on www.myailes.com";
                            //    string a8 = " Thanks.";
                            //    msg = a1 + re + rp + a2 + a3 + a4 + a5 + aaa + a6 + a7 + a8;
                            //    double messto = Convert.ToDouble(to);

                            //    string baseurl = "http://msg.kiriinfotech.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=fb6c31db313998f70aaf5634e3b8898&message=" + msg + "&senderId=SIGNUP&routeId=1&mobileNos=" + messto + "&smsContentType=english";


                            //    client.OpenRead(baseurl);

                            //}
                            //catch (Exception) { }
                            ob.CloseConn();




                            Response.Redirect("ShowDetail.aspx?username=" + TextBox2.Text + "&password=" + password.Text + "&Name=" + TextBox3.Text + "&txnpassword=" + txnpassword.Text);  //Response.Write("<script>alert('Id Successfully Registered')</script>");
                            //Response.Write("<script>");
                            //Response.Write("window.open('invoice.aspx?id=" + TextBox2.Text + "','_blank')");
                            //Response.Write("</script>");
                            try
                            {
                                setuser();
                                TextBox3.Text = "";
                                TextBox8.Text = "";
                            }
                            catch (Exception jk) { }

                            //int codee = Convert.ToInt32(dt1.Rows[0]["code"])+1;
                            //ob.Execute("update tle_cd_dy set code='" + codee.ToString() + "'");
                        }



                        catch (Exception jk)
                        {
                            Response.Write("<script>alert('Somthing Is Wrong')</script>");
                        }
                    }
                    else
                    {
                        ob.CloseConn();
                        Response.Write("<script>alert('Only Active Sponsor can register free id.')</script>");
                     
                    }

                }

            }
            else
            {
                txtsponser.Focus();
                Response.Write("<script>alert('Please Check Sponser ID')</script>");
            }
        
    }
    
   
   
    

   


    

    public void setuser()
    {

        var chars = "0123456789";
        var stringChars = new char[8];
        var random = new Random();

        for (int ik = 0; ik < stringChars.Length; ik++)
        {
            stringChars[ik] = chars[random.Next(chars.Length)];
        }

        var finalString = new String(stringChars);
        string capta = Convert.ToString(finalString);
        
        SqlDataReader dr = ob.drrr("select * from register where username='" + capta + "'");
        if (dr.Read())
        {
            ob.CloseConn();
            setuser();

        }
        else
        {
            ob.CloseConn();
            TextBox2.Text = capta;
        }



    }
    public void biney(string username)
    {
        DataTable spon = ob.dttt("select sponser from sponser where username='" + username + "'");
        string sponser = spon.Rows[0][0].ToString();
        DataTable co = ob.dttt("select count from binary where reff='" + sponser + "'");

        if (Convert.ToInt32(co.Rows[0][0]) < 4)
        {
            DataTable dt = ob.dttt("select count,id from binary where reff='" + sponser + "'");

            if (dt.Rows[0][0].ToString() == "0")
            {
                string kk = "update binary set l='" + username + "',count='1' where id='" + dt.Rows[0][1].ToString() + "'";
                ob.Execute(kk);

            }
            if (dt.Rows[0][0].ToString() == "1")
            {
                ob.Execute("update binary set m='" + username + "',count='2' where id='" + dt.Rows[0][1].ToString() + "'");

            }
            if (dt.Rows[0][0].ToString() == "2")
            {
                ob.Execute("update binary set r='" + username + "',count='3' where id='" + dt.Rows[0][1].ToString() + "'");

            }
            if (dt.Rows[0][0].ToString() == "3")
            {
                ob.Execute("update binary set lm='" + username + "',count='4' where id='" + dt.Rows[0][1].ToString() + "'");

            }


        }
        else
        {
            //   DataTable down = ob.dttt("select downlineid from downline where username=(select distinct sponser  from sponser  where username='" + sponser + "')");

            DataTable down = ob.dttt("select downlineid from downline where username ='" + sponser + "'");
            for (int k = 0; k < down.Rows.Count; k++)
            {
                DataTable dt = ob.dttt("select count,id from binary where reff='" + down.Rows[k][0].ToString() + "'");

                if (dt.Rows[0][0].ToString() == "0")
                {
                    string kk = "update binary set l='" + username + "',count='1' where id='" + dt.Rows[0][1].ToString() + "'";
                    ob.Execute(kk);
                    break;
                }
                if (dt.Rows[0][0].ToString() == "1")
                {
                    ob.Execute("update binary set m='" + username + "',count='2' where id='" + dt.Rows[0][1].ToString() + "'");
                    break;
                }
                if (dt.Rows[0][0].ToString() == "2")
                {
                    ob.Execute("update binary set r='" + username + "',count='3' where id='" + dt.Rows[0][1].ToString() + "'");
                    break;
                }
                if (dt.Rows[0][0].ToString() == "3")
                {
                    ob.Execute("update binary set lm='" + username + "',count='4' where id='" + dt.Rows[0][1].ToString() + "'");
                    break;
                }


            }

        }
    }

    protected void txtsponser_TextChanged(object sender, EventArgs e)
    {
        try {

            DataTable dt = ob.dttt("select name from register  where username='" + txtsponser.Text + "' ");
            if (dt.Rows.Count > 0)
            {
                lbsponser.Text = dt.Rows[0]["name"].ToString();

            }
            else
            { lbsponser.Text = "ERROR : Wrong sponser id"; }
        }
        catch (Exception ex)
        { }
    }

    private void loadstate()
    {
        //try
        //{

        //    DataTable dt = ob.dttt("select distinct statename from pincode order by statename asc");
        //    Drpstate.DataSource = dt;
        //    Drpstate.DataTextField = "statename";
        //    Drpstate.DataBind();

        //}
        //catch (Exception ex) { }
    }
    protected void Drpstate_SelectedIndexChanged1(object sender, EventArgs e)
    {
        //try
        //{

        //    DataTable dt = ob.dttt("select distinct districtname from pincode where statename='" + Drpstate.SelectedItem.Text + "' order by districtname asc");
        //    DropDownList1.DataSource = dt;
        //    DropDownList1.DataTextField = "districtname";
        //    DropDownList1.DataBind();

        //}
        //catch (Exception ex) { }
    }
}