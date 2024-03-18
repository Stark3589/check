using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TripleITConnection;
using TripleITTransaction;
public partial class User_autopool : System.Web.UI.Page
{
    clsConnection objcon = new clsConnection();
    clsfunction objfun = new clsfunction();
    clsAMD objamd = new clsAMD();
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                if (Request.QueryString["userid"] != null && Request.QueryString["userid"] != string.Empty)
                    txtunameid.Text = Request.QueryString["userid"];
            }
            catch (Exception ex)
            { }
            try
            {
                string query = "select (sum(cast(credit as real))-sum(cast(debit as real))) from fundaccount where username='" + Session["newuser"].ToString() + "'";
                DataTable dt = ob.dttt(query);

                TextBox1.Text = dt.Rows[0][0].ToString();
                if (TextBox1.Text == "" || TextBox1.Text == null)
                {
                    TextBox1.Text = "0";
                }
            }
            catch (Exception ex)
            {
            }
            //try
            //{
            //    DataTable dt = ob.dttt("select * from account where valu='GIFT WALLET' and username='" + Session["newuser"].ToString() + "'");
            //    if (dt.Rows.Count >= 0 && dt.Rows.Count < 10)
            //    {
            //        Label2.Text = "50 Rs";
            //    }
            //    else
            //    {
            //        Label2.Text = "0 Rs";
            //    }
            //}
            //catch (Exception ex)
            //{

            //}



        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            if (TextBox1.Text != "" || TextBox1.Text != "0")
            {

                if (Convert.ToDouble(DropDownList1.SelectedItem.Text) <= Convert.ToDouble(TextBox1.Text))
                {
                    //SqlDataReader pincheck = ob.drrr("select * from pinmanage where pin='" + TextBox2.Text + "' and reguser is null");
                    //if (pincheck.Read())
                    {

                        //SqlDataReader dr = ob.drrr("select * from register where username='" + txtunameid.Text + "' and status='Active'");
                        //if (dr.Read())
                        //{
                        //    ob.CloseConn();
                        //    Response.Write("<script>alert('Id Already Activated')</script>");
                        //}
                        //else
                        //{
                        //    ob.CloseConn();


                        string dd = System.DateTime.Now.Day.ToString();
                        string mm = System.DateTime.Now.Month.ToString();
                        string yy = System.DateTime.Now.Year.ToString();
                        string y = yy + "-" + mm + "-" + dd;


                        //   ob.Execute("update pinmanage set reguser='" + txtunameid.Text + "',dates='" + y + "' where pin='" + TextBox2.Text + "'");



                        // Get activate id which is sponser by this sponser

                        try
                        {
                            string aaa = "select sponser from sponser where username='" + txtunameid.Text + "'";
                            DataTable dt = ob.dttt(aaa);
                            if (dt.Rows.Count > 0)
                            {
                                string sponse = dt.Rows[0]["sponser"].ToString();





                                DateTime utcTime = DateTime.UtcNow;
                                //current Time
                                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                                DateTime timenow = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                                //string doj=timenow.
                                DateTime datenow1 = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                                string datenow = datenow1.ToString("yyyy/MM/dd");
                                string s = string.Empty;

                                string sql128 = "INSERT INTO tblactiveamount(username,amount,date,sponser,activeby) VALUES('" + txtunameid.Text + "','" + DropDownList1.SelectedItem.Text + "','" + datenow + "','" + sponse + "','" + Session["newuser"].ToString() + "')";

                                ob.Execute(sql128);

                            }

                        }
                        catch (Exception ee)
                        { }

                        try
                        {


                        }
                        catch (Exception jh)
                        { }




                        //count record in tbludatecount for closing
                        ob.Execute("insert into binary values('" + txtunameid.Text + "','0','0','0','0','0','0','1')");
                        biney(txtunameid.Text);

                        try
                        {
                            //  SqlConnection con = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=mahi;Integrated Security=True; Connection Timeout=1000");

                            SqlConnection con = new SqlConnection( ConfigurationManager.ConnectionStrings["ccmbConnectionString"].ConnectionString);
                            con.Open();
                            SqlCommand cmd = new SqlCommand("[dbo].[regis]", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@USERNAME1", txtunameid.Text);
                            cmd.Parameters.AddWithValue("@SECTION", '1');
                            cmd.ExecuteNonQuery();

                            con.Close();
                        }
                        catch (Exception jh) { }



                      

                      

                        //string a = "select * from register where username='" + txtunameid.Text + "' and status='Active'";
                        //       DataTable dt1 = ob.dttt(a);
                        //       if (dt1.Rows.Count > 0)
                        //       {
                        try
                        {

                            // double investamt = Convert.ToDouble(investamt.Text) * 2;


                            SqlConnection con = new SqlConnection( ConfigurationManager.ConnectionStrings["ccmbConnectionString"].ConnectionString);
                            con.Open();
                            SqlCommand cmd = new SqlCommand("[dbo].[AUTOPOOL_REGI]", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@USERNAME", txtunameid.Text);
                            cmd.Parameters.AddWithValue("@SECTION", DropDownList1.SelectedItem.Value);


                            cmd.ExecuteNonQuery();

                            con.Close();
                        }
                        catch (Exception jh)
                        { }
                        // }


                        try
                        {

                            //double amt=Convert.ToDouble(TextBox1.Text)-Convert.ToDouble(investamt.Text);
                            //string rem=amt.ToString();
                            //                                      username,credit,debit,date,status,U_id
                           
                                string sql111 = "insert into fundaccount(username,credit,debit,date,status,U_id)values('" + Session["newuser"].ToString() + "','0','500','" + ob.utc().ToString("yyyy-MM-dd") + "','Invested On','" + txtunameid.Text + "')";
                                ob.Execute(sql111);
                           
                        }
                        catch (Exception ex)
                        {
                        }


                       // ob.Execute("update register set status='Active' where username='" + txtunameid.Text + "'");

                        //Response.Redirect("inactivemember.aspx");
                        Response.Write("<script>alert('Congratulations! Dear " + txtname.Text + " and id " + txtunameid.Text + " have Completed this process. Thank You ')</script>");
                        txtunameid.Text = "";
                        txtname.Text = "";
                      //  Label1.Text = "0";
                        try
                        {
                            string query = "select (sum(cast(credit as real))-sum(cast(debit as real))) from fundaccount where username='" + Session["newuser"].ToString() + "'";
                            DataTable dt = ob.dttt(query);

                            TextBox1.Text = dt.Rows[0][0].ToString();
                            if (TextBox1.Text == "" || TextBox1.Text == null)
                            {
                                TextBox1.Text = "0";
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                       
                        // TextBox2.Text = "";
                    }

                }
                else
                {
                    Response.Write("<script>alert('Enter Valid Amount')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Insufficient Amount')</script>");
            }


        }
        catch (Exception ex)
        { }
    }



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["verify"] = txtunameid.Text;

        Response.Write("<script>");
        Response.Write("window.open('Welcome.aspx','_blank')");
        Response.Write("</script>");
    }


    protected void txtamount_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtunameid_TextChanged(object sender, EventArgs e)
    {

    }

    protected void investamt_TextChanged(object sender, EventArgs e)
    {


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            string sql = "select name from register where username='" + txtunameid.Text + "'";
            DataTable dt = ob.dttt(sql);
            if (dt.Rows.Count > 0)
            {
                //txtunameid.Text = txtunameid.Text;
                txtname.Text = dt.Rows[0]["name"].ToString();
            }
            else
            {
                //txtunameid.Text = "";
                txtunameid.Text = "";
                txtname.Text = "Invalid Username";

            }

        }
        catch (Exception ex)
        { }
    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (Convert.ToDouble(TextBox1.Text) >= 450)
        {
           
        }
    }
    public void biney(string username)
    {
        DataTable spon = ob.dttt("select sponser from sponser where username='" + username + "'");
        string sponser = spon.Rows[0][0].ToString();
        DataTable co = ob.dttt("select count from binary where reff='" + sponser + "' and section='1'");

        if (Convert.ToInt32(co.Rows[0][0]) < 2)
        {
            DataTable dt = ob.dttt("select count,id from binary where reff='" + sponser + "' and section='1'");

            if (dt.Rows[0][0].ToString() == "0")
            {
                string kk = "update binary set l='" + username + "',count='1' where id='" + dt.Rows[0][1].ToString() + "' and section='1'";
                ob.Execute(kk);

            }
            if (dt.Rows[0][0].ToString() == "1")
            {
                ob.Execute("update binary set r='" + username + "',count='2' where id='" + dt.Rows[0][1].ToString() + "' and section='1'");

            }

        }
        else
        {
            //   DataTable down = ob.dttt("select downlineid from downline where username=(select distinct sponser  from sponser  where username='" + sponser + "')");

            DataTable down = ob.dttt("select top(1) reff from binary a,sponserdownline b where a.reff=b.downlineid and b.username='" + sponser + "' and count<2 order by a.id asc");

            DataTable dt = ob.dttt("select count,id from binary where reff='" + down.Rows[0][0].ToString() + "' and section='1'");

            if (dt.Rows[0][0].ToString() == "0")
            {
                string kk = "update binary set l='" + username + "',count='1' where id='" + dt.Rows[0][1].ToString() + "' and section='1'";
                ob.Execute(kk);

            }
            if (dt.Rows[0][0].ToString() == "1")
            {
                ob.Execute("update binary set r='" + username + "',count='2' where id='" + dt.Rows[0][1].ToString() + "' and section='1'");

            }




        }
    }

}