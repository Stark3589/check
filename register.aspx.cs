using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Net;
using System.Data.SqlClient;
using TripleITConnection;
using TripleITTransaction;
using System.Net.Mail;
using System.Configuration;
public partial class register : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    //business obb = new business();
    PINCODE pin = new PINCODE();
    clsConnection constr = new clsConnection();
    int number;

    private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

    protected void Page_Load(object sender, EventArgs e)
    {
       

            if (!IsPostBack)
            {
                try
                {
                    if (Request.QueryString["SID"] != null)
                    {
                        txtsponser.Text = Request.QueryString["SID"].ToString();
                        txtsponser.ReadOnly = true;
                        try
                        {
                            DataTable dt = ob.dttt("select name from register where username='" + txtsponser.Text + "'");
                            Label1.Text = "Name : " + dt.Rows[0][0].ToString();
                        }
                        catch (Exception jjh) { Label1.Text = "Invalid Username"; };
                    }

                }
                catch (Exception jh) { txtsponser.Text = ""; };

                //DataTable dt = ob.dttt("select distinct statename from pincode order by statename asc");
                //DropDownList4.DataSource = dt;
                //DropDownList4.DataTextField = "statename";
                //DropDownList4.DataBind();
                //// City Bind
                //DataTable dt1 = ob.dttt("select distinct districtname from pincode where statename='" + DropDownList4.SelectedItem.Text + "' ");
                //DropDownList2.DataSource = dt1;
                //DropDownList2.DataTextField = "districtname";
                //DropDownList2.DataBind();
                //DropDownList2.Items.Insert(0, "Select City");




                var chars = "1234567890";
                var stringChars = new char[6];
                var random = new Random();

                for (int ik = 0; ik < stringChars.Length; ik++)
                {
                    stringChars[ik] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                string capta = Convert.ToString(finalString);
               // password.Text = capta;
              
                //TextBox21.Text = EncodePasswordToBase64(capta);

               
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
               
                TextBox1.Text = EncodePasswordToBase64(capta1);
            }


            if (!IsPostBack)
            {
    
                setuser();
                loadstate();
                //string stc = "select distinct State from City where CountryCode='IN' order by State asc";
                //DataTable stat = pin.dttt(stc);
                //if (stat.Rows.Count > 0)
                //{
                //    DropDownList4.DataSource = stat;
                //    DropDownList4.DataTextField = "State";
                //    DropDownList4.DataValueField = "State";
                //    DropDownList4.DataBind();
                //    DropDownList4.Items.Insert(0, "Select State");
                //}
                //string cty = "select distinct City from City where CountryCode='IN' order by City asc";
                //DataTable city = pin.dttt(cty);
                //if (city.Rows.Count > 0)
                //{
                //    DropDownList2.DataSource = city;
                //    DropDownList2.DataTextField = "City";
                //    DropDownList2.DataValueField = "City";
                //    DropDownList2.DataBind();
                //    DropDownList2.Items.Insert(0, "Select City");
                //}
       

            }
            //if (!IsPostBack)
            //{

            //    TextBox7.Text = day1 + "/" + month1 + "/" + year1;
            //    TextBox15.Text = day1 + "/" + month1 + "/" + year1;



            //}
           

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
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            //DataTable dt = obb.dttt("select distinct districtname  from pincode where statename='" + DropDownList4.SelectedItem.Text + "' order by districtname ASC");
            //DropDownList2.DataSource = dt;
            //DropDownList2.DataTextField = "districtname";
            //DropDownList2.DataBind();
            //string cty = "select distinct City from City where CountryCode='IN' and  state='" + DropDownList4.SelectedItem.Text + "' order by City asc";
            //DataTable city = pin.dttt(cty);
            //if (city.Rows.Count > 0)
            //{
            //    DropDownList2.DataSource = city;
            //    DropDownList2.DataTextField = "City";
            //    DropDownList2.DataValueField = "City";
            //    DropDownList2.DataBind();
            //    DropDownList2.Items.Insert(0, "Select City");
            //}
        }
        catch { }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        password.Text = EncodePasswordToBase64(TextBox21.Text);
        DataTable getmobile = ob.dttt("select * from register where mobile='" + TextBox8.Text + "' ");
        if (getmobile.Rows.Count < 10000000)
        {
            if (TextBox2.Text != "" && txtsponser.Text != "")
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

                    if (TextBox4.Text == TextBox21.Text)
                    {
                        //SqlDataReader dr = ob.drrr("select * from register where username='" + txtsponser.Text + "' and status='Active'");
                        //if (dr.Read())
                        //{
                        //    ob.CloseConn();
                        try
                        {

                            string day1 = System.DateTime.UtcNow.Day.ToString();
                            string month1 = System.DateTime.UtcNow.Month.ToString();
                            string year1 = System.DateTime.UtcNow.Year.ToString();
                            string dddate = day1 + "/" + month1 + "/" + year1;
                            string strDate = day1 + "/" + month1 + "/" + year1; //Format – dd/MM/yyyy
                            //split string date by separator, here I'm using '/'
                            DateTime dte = DateTime.Parse(strDate);
                            string date = dte.ToString("yyyy-MM-dd");
                            //string date = TextBox22.Text;


                            dte = DateTime.Parse(date);
                            string ndob = dte.ToString("yyyy-MM-dd");
                            DateTime utcTime = DateTime.UtcNow;
                            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                            DateTime timenow = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                            string tme = timenow.ToString("hh:mm tt");

                            DateTime indiantime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);

                            String tttt = indiantime.ToString("dd/MM/yyyy hh:mm tt");
                            //get username from register to count for level income
                            // DataTable register_table = ob.dttt("select username from register");





                            ob.Execute("insert into register(reffid,reffname,name,username,password,dateofjoin,email,mobile,status,rtime,Dateofjoining,state,city,onside,bub) values('" + txtsponser.Text + "','','" + TextBox3.Text + "','" + TextBox2.Text + "','" + password.Text + "','" + date + "','" + TextBox5.Text + "','" + TextBox8.Text + "','Not Active','" + tme + "','" + tttt + "','','','" + TextBox1.Text + "','UB')");

                       


                            ob.Execute("insert into sponser values('" + TextBox2.Text + "','" + txtsponser.Text + "','0')");





                            //Daily purchse count

                            string reffid = TextBox2.Text;
                            int x = 0;

                          

                            try
                            {
                                SqlConnection con = new SqlConnection(ob.ConnectString);

                               //  SqlConnection con = new SqlConnection(ob.ConnectString);
                                con.Open();
                                SqlCommand cmd = new SqlCommand("[dbo].[sponserdown]", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@USERNAME1", TextBox2.Text);

                                cmd.ExecuteNonQuery();

                                con.Close();
                            }
                            catch (Exception jh) { }
                          
                          

                            ob.CloseConn();




                            Response.Redirect("ShowDetail.aspx?username=" + TextBox2.Text + "&password=" + TextBox21.Text + "&Name=" + TextBox3.Text + "&txnpassword=" + txnpassword.Text);
                            try
                            {
                                setuser();
                                TextBox3.Text = "";
                                TextBox8.Text = "";
                                txtsponser.Text = "";
                            }
                            catch (Exception jk) { }



                        }

                        catch (Exception jk)
                        {
                            Response.Write("<script>alert('Somthing Is Wrong')</script>");
                        }
                        //}
                        //else
                        //{
                        //    Response.Write("<script>alert('Only Active Sponsor can register free id.')</script>");

                        //}
                    }
                    else
                    {
                        Response.Write("<script>alert('confirm password not match')</script>");

                    }
                }

            }
            else
            {
                txtsponser.Focus();
            }

        }

        else
        {
           
            Response.Write("<script>alert('You can't register more than 3 id's from same mobile no. try from another mobile no.')</script>");
        }

    }









    public void setuser()
    {
       

        //var chars = "0123456789";
        //var stringChars = new char[6];
        //var random = new Random();

        //for (int ik = 0; ik < stringChars.Length; ik++)
        //{
        //    stringChars[ik] = chars[random.Next(chars.Length)];
        //}

        //var finalString = new String(stringChars);
        //string capta = Convert.ToString(finalString);

        //SqlDataReader dr = ob.drrr("select * from register where username='" + capta + "'");
        //if (dr.Read())
        //{
        //    ob.CloseConn();
        //    setuser();

        //}
        //else
        //{
        //    ob.CloseConn();
        //    TextBox2.Text =  capta;
        //}



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
                ob.Execute("update binary set r='" + username + "',count='2' where id='" + dt.Rows[0][1].ToString() + "'");

            }
            if (dt.Rows[0][0].ToString() == "2")
            {
                ob.Execute("update binary set lm='" + username + "',count='3' where id='" + dt.Rows[0][1].ToString() + "'");

            }
            if (dt.Rows[0][0].ToString() == "3")
            {
                ob.Execute("update binary set lr='" + username + "',count='4' where id='" + dt.Rows[0][1].ToString() + "'");

            }
        }
        else
        {
            //   DataTable down = ob.dttt("select downlineid from downline where username=(select distinct sponser  from sponser  where username='" + sponser + "')");

            DataTable down = ob.dttt("select top(1) reff from binary a,downline b where a.reff=b.downlineid and b.username='" + sponser + "' and count<4 order by a.id asc");

            DataTable dt = ob.dttt("select count,id from binary where reff='" + down.Rows[0][0].ToString() + "'");

            if (dt.Rows[0][0].ToString() == "0")
            {
                string kk = "update binary set l='" + username + "',count='1' where id='" + dt.Rows[0][1].ToString() + "'";
                ob.Execute(kk);

            }
            if (dt.Rows[0][0].ToString() == "1")
            {
                ob.Execute("update binary set r='" + username + "',count='2' where id='" + dt.Rows[0][1].ToString() + "'");

            }
            if (dt.Rows[0][0].ToString() == "2")
            {
                ob.Execute("update binary set lm='" + username + "',count='3' where id='" + dt.Rows[0][1].ToString() + "'");

            }
            if (dt.Rows[0][0].ToString() == "3")
            {
                ob.Execute("update binary set lr='" + username + "',count='4' where id='" + dt.Rows[0][1].ToString() + "'");

            }



        }
    }


    protected void txtsponser_TextChanged(object sender, EventArgs e)
    {
         try
        {
            DataTable dt = ob.dttt("select name from register where username='" + txtsponser.Text + "'");
            Label1.Text ="Name : "+ dt.Rows[0][0].ToString();
        }
        catch (Exception jjh) { Label1.Text = "Invalid Username"; };
    }

    //protected void txt_pin_TextChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        DataTable dt = ob.dttt("select * from pinmanage where pin='" + txt_pin.Text + "' and reguser is null");
    //        txt_pin.Text =  dt.Rows[0][0].ToString();
    //    }
    //    catch (Exception jjh) { txt_pin.Text = ""; };

    //}
    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("login.aspx");
    //}
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
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}