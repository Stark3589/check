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

public partial class User_Confirm : System.Web.UI.Page
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
            }
            catch (Exception ex)
            {
            }



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

                        SqlDataReader dr = ob.drrr("select * from register where username='" + txtunameid.Text + "' and status='Active'");
                        if (dr.Read())
                        {
                            ob.CloseConn();
                            Response.Write("<script>alert('Id Already Activated')</script>");
                        }
                        else
                        {
                            ob.CloseConn();


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
                                    ob.Execute("update register set status='Active' where username='" + txtunameid.Text + "'");
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

                            { }





                            try
                            {

                                // double investamt = Convert.ToDouble(investamt.Text) * 2;


                                SqlConnection con = new SqlConnection( ConfigurationManager.ConnectionStrings["ccmbConnectionString"].ConnectionString);
                                con.Open();
                                SqlCommand cmd = new SqlCommand("[dbo].[level_daily_income]", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@USERNAME", txtunameid.Text);


                                cmd.ExecuteNonQuery();

                                con.Close();
                            }
                            catch (Exception jh)
                            { }
                            try
                            {

                                // double investamt = Convert.ToDouble(investamt.Text) * 2;


                                SqlConnection con = new SqlConnection( ConfigurationManager.ConnectionStrings["ccmbConnectionString"].ConnectionString);
                                con.Open();
                                SqlCommand cmd = new SqlCommand("[dbo].[regi]", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@USERNAME", txtunameid.Text);


                                cmd.ExecuteNonQuery();

                                con.Close();
                            }
                            catch (Exception jh)
                            { }



                            try
                            {

                                //double amt=Convert.ToDouble(TextBox1.Text)-Convert.ToDouble(investamt.Text);
                                //string rem=amt.ToString();
                                //                                      username,credit,debit,date,status,U_id

                                string sql111 = "insert into fundaccount(username,credit,debit,date,status,U_id)values('" + Session["newuser"].ToString() + "','0','" + DropDownList1.SelectedItem.Text + "','" + ob.utc().ToString("yyyy-MM-dd") + "','Invested On','" + txtunameid.Text + "')";
                                ob.Execute(sql111);


                            }
                            catch (Exception ex)
                            {
                            }



                        }
                        //Response.Redirect("inactivemember.aspx");
                        Response.Write("<script>alert('Token Invested Successfully. ')</script>");
                        txtunameid.Text = "";
                        txtname.Text = "";
                        try
                        {
                            string query = "select (sum(cast(credit as real))-sum(cast(debit as real))) from fundaccount where username='" + Session["newuser"].ToString() + "'";
                            DataTable dt = ob.dttt(query);

                            TextBox1.Text = dt.Rows[0][0].ToString();
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
}