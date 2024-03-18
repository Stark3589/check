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
using System.Configuration;

public partial class User_Reg : System.Web.UI.Page
{
    public static string signlink = "", profilelink = "", thumblink = "";
    BussinessLayer ob = new BussinessLayer();
 
    clsConnection objcon = new clsConnection();
    clsTimeZone objtime = new clsTimeZone();
    clsAMD objamd = new clsAMD();
    public static List<clsBinary> objbinarylist = new List<clsBinary>();
    public List<clsTotalBinary> objtotalbinarylist = new List<clsTotalBinary>();
    public List<clsnewTotalBinary> objnewbinarylist = new List<clsnewTotalBinary>();

    int number;
    public static string pass;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //try
            //{
            //    Drpsopnser.Text = Session["newuser"].ToString();
            //}catch(Exception jh){};

            loaduserid();
            loadbinarylist();
            loaduplinelist();
            loadstate();
            // loadupline();
            //loadsponser();
            genratepassword();
            //loaduserid();


        }

    }

    private void genratepassword()
    {
        try
        {


            var chars = "0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int ik = 0; ik < stringChars.Length; ik++)
            {
                stringChars[ik] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            string capta = Convert.ToString(finalString);
            pass = capta;
            password.Text = pass;
            txn.Text = pass;
        }
        catch (Exception ex) { }
    }


    private void loaduserid()
    {
        try
        {
            var chars11 = "0123456789";
            var stringChars11 = new char[11];
            var random11 = new Random();

            for (int ik = 0; ik < stringChars11.Length; ik++)
            {
                stringChars11[ik] = chars11[random11.Next(chars11.Length)];
            }

            var finalString11 = new String(stringChars11);
            string otp = Convert.ToString(finalString11);

            txtuid.Text =  otp;


        }
        catch (Exception ex) { }
    }



    private void loadbinarylist()
    {
        try
        {
            DataTable dt = ob.dttt("select username ,leftcount,rightcount from total_binarycount");

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    clsTotalBinary objtbinary = new clsTotalBinary();
                    objtbinary.username = dt.Rows[i]["username"].ToString();
                    objtbinary.leftcount = dt.Rows[i]["leftcount"].ToString();
                    objtbinary.rightcount = dt.Rows[i]["rightcount"].ToString();
                    objtotalbinarylist.Add(objtbinary);
                }

            }

        }
        catch (Exception ex)
        {
        }
    }
    private void loaduplinelist()
    {
        try
        {

            DataTable dt = ob.dttt("select reff,l,r,count from binary");

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    clsBinary objbinary = new clsBinary();
                    objbinary.username = dt.Rows[i]["reff"].ToString();
                    objbinary.left = dt.Rows[i]["l"].ToString();
                    objbinary.right = dt.Rows[i]["r"].ToString();
                    objbinary.count = dt.Rows[i]["count"].ToString();
                    objbinarylist.Add(objbinary);
                }

            }

        }
        catch (Exception ex)
        { }
    }

    private void loadupline()
    {
        try
        {
            if (!IsPostBack)
            {
                //DrpUpLine.DataSource = objbinarylist;
                //DrpUpLine.DataBind();
                //checkedside();
            }

        }
        catch (Exception ex) { }
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

    protected void Drpstate_SelectedIndexChanged(object sender, EventArgs e)
    {


    }

    protected void txtuname_TextChanged(object sender, EventArgs e)
    {
        try
        {
            SqlDataReader da = ob.drrr("select * from register where username='" + txtuname.Text + "'");
            if (da.Read())
            {
                da.Close();
                txtuname.Text = "";
                txtuname.Focus();
                Response.Write("<script>alert('Id Already Exists...')</script>");
            }


        }
        catch (Exception ex) { }

    }

    protected void DrpUpLine_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    public void getupline()
    {
        string username = Drpsopnser.Text;
        string user = "";
        string st = "";
        if (rbntleft.Checked == true)
        {
            do
            {

                DataTable dt = ob.dttt("select l from binary where reff='" + username + "'");
                user = username;
                try
                {
                    username = dt.Rows[0][0].ToString();
                    st = dt.Rows[0][0].ToString();
                }
                catch (Exception EX)
                {
                    st = "0";
                }

            } while (st != "0");

            txtupline.Text = user;
        }

        if (rdbntright.Checked == true)
        {
            do
            {

                DataTable dt = ob.dttt("select r from binary where reff='" + username + "'");
                user = username;
                try
                {
                    username = dt.Rows[0][0].ToString();
                    st = dt.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    st = "0";
                }

            } while (st != "0");

            txtupline.Text = user;
        }

    }
    protected void bntpersonal_Click(object sender, EventArgs e)
    {
        try
        {
            if (CheckBox1.Checked)
            {
                if (rbntleft.Checked == false && rdbntright.Checked == false)
                {
                    Response.Write("<script>alert('Select Side')</script>");
                    //}
                }
                else
                {

                    if (Drpsopnser.Text.Length > 5)
                    {

                        string sql = "select * from register where username='" + txtuid.Text + "'";
                        DataTable dt = objcon.ReturnDataTableSql(sql);
                        if (dt.Rows.Count > 0)
                        {
                            Response.Write("<script>alert('Member Already exists')</script>");

                            rbntleft.Visible = false;
                            rdbntright.Visible = false;
                            loadbinarylist();
                            loaduplinelist();
                            loadstate();

                            genratepassword();


                        }
                        else
                        {

                           if(rbntleft.Checked==true)
                           {
                               DataTable getleft = ob.dttt("select l from binary where reff='"+txtupline.Text+"'");
                               if(getleft.Rows[0][0].ToString()=="0")
                               {
                                   register();

                               }
                               else
                               {
                                   Response.Write("<script>alert('Upline Left Side Already Filled')</script>");
                               }
                           }
                           if (rdbntright.Checked == true)
                           {
                               DataTable getright = ob.dttt("select r from binary where reff='" + txtupline.Text + "'");
                               if (getright.Rows[0][0].ToString() == "0")
                               {
                                   register();

                               }
                               else
                               {
                                   Response.Write("<script>alert('Upline Right Side Already Filled')</script>");
                               }
                           }
                        }

                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Sponser ID')</script>");
                    }

                }
            }
            else
            {
                Response.Write("<script>alert('Terms & Condition Not Check')</script>");
            }
        }
        catch (Exception ex)
        { }


    }


    public void register()
    {
        ////getupline();
        int xx = insertallpersonallist();
        if (xx == 1)
        {
            if (rbntleft.Checked == true)
            {
                string query1 = "update binary set l='" + txtuid.Text + "' where reff='" + txtupline.Text + "'";

                int status1 = objcon.ExecuteSqlQuery(query1);
                if (status1 > 0)
                {
                    try
                    {
                        objamd.Downine(txtuid.Text);
                    }
                    catch (Exception ex)
                    { }
                    sendsms();
                    Label1.Text = txtuid.Text;
                    Label2.Text = password.Text;
                     Label4.Text = txn.Text;
                    this.mp1.Show();
                }




            }
            else if (rdbntright.Checked == true)
            {

                string query1 = "update binary set r='" + txtuid.Text + "' where reff='" + txtupline.Text + "'";
                int status1 = objcon.ExecuteSqlQuery(query1);
                if (status1 > 0)
                {

                    try
                    {
                        objamd.Downine(txtuid.Text);
                    }
                    catch (Exception ex)
                    { }
                    sendsms();
                    Label1.Text = txtuid.Text;
                    Label2.Text = password.Text;
                     Label4.Text = txn.Text;
                    this.mp1.Show();

                }
                else
                {
                    Response.Write("<script>alert('There is some issue to update binary table')</script>");
                }

            }
        }
        else
        {
            Response.Write("<script>alert('There is some issue to insert table table')</script>");
        }
    }
    private int insertallpersonallist()
    {
        int status = 0;

        try
        {
            string dob = "1990-02-02";


            DateTime utcTime = DateTime.UtcNow;
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime timenow = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
            //string doj=timenow.
            DateTime datenow1 = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
            string datenow = datenow1.ToString("yyyy/MM/dd");
            //  2018 - 01 - 27 10:43:00 AM
            string doj = datenow1.ToString("yyyy-MM-dd hh:mm tt");
            string tme = DateTime.Now.AddHours(12.30).ToShortTimeString();//objtime.returnDateTimeServerMachTime();
            string outsite = "";
            if (rbntleft.Checked == true)
            { outsite = "Left Side"; }
            else if (rdbntright.Checked == true)
            { outsite = "Right Side"; }
         //   int nomage = DateTime.Now.AddYears(-Convert.ToDateTime(nage.Text).Year).Year;
          //  int age = DateTime.Now.AddYears(-Convert.ToDateTime(uage.Text).Year).Year;
            //insert record

           // TextBox2.Text = DropDownList2.SelectedItem.Text + "-" + TextBox2.Text;
            //string fulladdress = address.Text + " " + TextBox1.Text;
            string sql1 = "insert into register(reffid, reffname, state, name, username, password, onside, dateofjoin,mobile, status, rtime,Dateofjoining,address,sex,age,nomineename,nage,dob,ndob,village,ps,city,fname,pan,nrelation,txn)  ";
            sql1 += "values('" + txtupline.Text + "', '" + txtupline.Text + "','','" + txtuname.Text + "','" + txtuid.Text + "', '" + password.Text + "', '" + outsite + "', '" + datenow + "', '" + txtmobile.Text + "','Not Active','" + tme + "','" + doj + "','','','','','','','','','','','','" + panno.Text + "','','"+txn.Text+"')";
            status = objcon.ExecuteSqlQuery(sql1);
            if (status > 0)
            {
                string s = string.Empty;
                //insert binary table
                //string querycode = "update code set code='" + Session["count"].ToString() + "'";
                //int statuscode = objcon.ExecuteSqlQuery(querycode);              
                //insert binarycount table

                //insert sponser id
                string sql4 = "insert into sponser values('" + txtuid.Text + "','" + Drpsopnser.Text + "','0')";
                //int a2 = objcon.ExecuteSqlQuery(sql4);
                s = s + "" + sql4;
                //insert into level


                //update level


                string sql6 = "insert into bankdetail(username) values('" + txtuid.Text + "')";
                //int a4 = objcon.ExecuteSqlQuery(sql6);
                s = s + "" + sql6;
                ////insert document detail

                string sql12 = "insert into binary(reff,l,r,count) values('" + txtuid.Text + "','0','0','0')";
                //int a12 = objcon.ExecuteSqlQuery(sql12);
                s = s + "" + sql12;
                ////insert binary
                //string sql14 = "insert into direct(username,direct) values('" + txtuid.Text + "','0')";
                //int a14 = objcon.ExecuteSqlQuery(sql14);
                string sql16 = "insert into tblupdatecount(username,count) values('" + txtuid.Text + "','0')";
                //int a16 = objcon.ExecuteSqlQuery(sql16);
                s = s + "" + sql16;
                string sql112 = "insert into total_binarycount1(username,leftcount,rightcount,leftcount1,rightcount1) values('" + txtuid.Text + "','0','0','0','0')";
                //int a112 = objcon.ExecuteSqlQuery(sql112);
                s = s + "" + sql112;
                //daiy binarycount
                string sql786 = "insert into daily_binarycount(username,leftcount,rightcount,leftcount1,rightcount1) values('" + txtuid.Text + "','0','0','0','0')";
                s = s + "" + sql786;
                string sql12786 = "insert into total_binarycount(username,leftcount,rightcount) values('" + txtuid.Text + "','0','0')";
                s = s + "" + sql12786;
                int a786 = objcon.ExecuteSqlQuery(s);
                try
                {
                    //   SqlConnection con = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=gwos;Integrated Security=True");
                     SqlConnection con = new SqlConnection(ob.ConnectString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("[dbo].[sponserdown]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@USERNAME1", txtuid.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception jh) { }

            }
            else
            {


            }
        }
        catch (Exception ex)
        { }
        return status;
    }
    private void sendsms()
    {
       
    }

    private void updatebinarylist(string reffid)
    {
        try
        {

            string newreffid = txtupline.Text;

            int i = 0;
            while (objbinarylist.Count > i)
            {
                //only sponser
                if (i == 0)
                {
                    var count1 = objtotalbinarylist.Find(a => a.username == newreffid);
                    if (Convert.ToInt32(count1.leftcount) >= 0)
                    {
                        if (rbntleft.Checked == true)
                        {
                            clsnewTotalBinary objnewtbinary = new clsnewTotalBinary();
                            int lcount = (Convert.ToInt32(count1.leftcount) + 1);
                            objnewtbinary.leftcount = lcount.ToString();
                            objnewtbinary.rightcount = count1.rightcount;
                            objnewtbinary.username = count1.username;
                            objnewbinarylist.Add(objnewtbinary);
                        }
                        else
                        {
                            clsnewTotalBinary objnewtbinary = new clsnewTotalBinary();
                            int rcount = (Convert.ToInt32(count1.rightcount) + 1);
                            objnewtbinary.leftcount = count1.leftcount;
                            objnewtbinary.rightcount = rcount.ToString();
                            objnewtbinary.username = count1.username;
                            objnewbinarylist.Add(objnewtbinary);

                        }

                    }
                    i++;

                }

                var record = objbinarylist.Find(o => o.left == newreffid || o.right == newreffid);
                if (record.left == newreffid)
                {
                    // var c = objtotalbinarylist.Count;
                    var count1 = objtotalbinarylist.Find(a => a.username == record.username);
                    if (Convert.ToInt32(count1.leftcount) >= 0)
                    {
                        clsnewTotalBinary objnewtbinary = new clsnewTotalBinary();
                        int lcount = (Convert.ToInt32(count1.leftcount) + 1);
                        objnewtbinary.leftcount = lcount.ToString();
                        objnewtbinary.rightcount = count1.rightcount;
                        objnewtbinary.username = count1.username;
                        objnewbinarylist.Add(objnewtbinary);


                    }
                    newreffid = record.username;
                }
                else if (record.right == newreffid)
                {
                    // newreffid = record.username;
                    var count1 = objtotalbinarylist.Find(a => a.username == record.username);
                    if (Convert.ToInt32(count1.leftcount) >= 0)
                    {
                        clsnewTotalBinary objnewtbinary = new clsnewTotalBinary();
                        int rcount = (Convert.ToInt32(count1.rightcount) + 1);
                        objnewtbinary.leftcount = count1.leftcount;
                        objnewtbinary.rightcount = rcount.ToString();
                        objnewtbinary.username = count1.username;
                        objnewbinarylist.Add(objnewtbinary);


                    }
                    newreffid = record.username;
                }
                else
                {
                    break;
                }


                i++;
            }



        }
        catch (Exception ex)
        {

        }
    }

    protected void Drpsopnser_TextChanged(object sender, EventArgs e)
    {
        try
        {
            lbsponsername.Text = "";
            if (Drpsopnser.Text.Length > 0)
            {
                DataTable dt2 = ob.dttt("select name,username from register  where username='" + Drpsopnser.Text + "'");
                if (dt2.Rows.Count > 0)
                {
                    lbsponsername.Text = dt2.Rows[0]["name"].ToString();
                }
                else
                {
                    Drpsopnser.Text = "";
                    lbsponsername.Text = "You Entered Wrong Sponser ID";


                }
            }
            else
            {
                // Drpsopnser.Text = "";
                // lbsponsername.Text = "You Entered Wrong Sponser ID";


            }

        }
        catch (Exception ex)
        {
            // Drpsopnser.Text = "";
            //  lbsponsername.Text = "You Entered Wrong Sponser ID";
        }
    }

    protected void txtuname_TextChanged1(object sender, EventArgs e)
    {
        try
        {
            //loaduserid();
        }
        catch (Exception ex)
        { }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("reg.aspx");
    }

    protected void txtmobile_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        //     string query = "select mobile from register";
        //    DataTable dt = ob.dttt(query);
        //    if (dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            string mobile = dt.Rows[i]["mobile"].ToString();

        //            if (txtmobile.Text == mobile)
        //            {

        //                Response.Write("<script>alert('This mobile no is already registered please enter the new one')</script>");
        //            }
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //}
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
    protected void Search_Click(object sender, EventArgs e)
    {
        getupline();
        bntpersonal.Visible = true;
        Search.Visible = false;
        Label5.Text = "";
    }
    protected void txtupline_TextChanged(object sender, EventArgs e)
    {
        try
        {
            Label5.Text = "";
            if (txtupline.Text.Length > 0)
            {
                DataTable dt2 = ob.dttt("select name,username from register  where username='" + txtupline.Text + "'");
                if (dt2.Rows.Count > 0)
                {
                    Label5.Text = dt2.Rows[0]["name"].ToString();
                }
                else
                {
                    txtupline.Text = "";
                    Label5.Text = "You Entered Wrong Upline ID";


                }
            }
            else
            {
                // Drpsopnser.Text = "";
                // lbsponsername.Text = "You Entered Wrong Sponser ID";


            }

        }
        catch (Exception ex)
        {
            // Drpsopnser.Text = "";
            //  lbsponsername.Text = "You Entered Wrong Sponser ID";
        }
    }
}

 
            