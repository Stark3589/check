using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

public partial class newuser_homefrn_new : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
           
            try
            {
                if (Request.QueryString["SID"] != null)
                {
                    Session["newuser"] = Request.QueryString["SID"].ToString();
                    

                }

            }
            catch (Exception jh) { };
            try
            {
                DataTable dt = ob.dttt("select * from levelset where username='" + Session["newuser"].ToString() + "' and lvl='3' and status='N'");
                if (dt.Rows.Count > 0)
                {
                    Label6.Text = "Boost your id";
                    Label6.Visible = true;
                    Button1.Visible = true; 
                }
            }catch(Exception jh){};

            try
            {
                //ModalPopupExtender1.Show();
                string sql = "select status,dateofjoin from register where username='" + Session["newuser"].ToString() + "'; select amount,date from tblactiveamount where username='" + Session["newuser"].ToString() + "';select sum(cast(total_amt as real)) from withdrawal where username='" + Session["newuser"].ToString() + "';select (sum(cast(credit as real)))-(sum(cast(DEBIT as real))) from account where username='" + Session["newuser"].ToString() + "' AND VALU!='GIFT WALLET';select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='DAILY PROFIT'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='LEVEL INCOME'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='TEAM LEVEL INCOME');  select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='REWARD INCOME'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='MAGIC CLUB BONUS'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='LEADERSHIP BONUS'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='GOLD CLUB'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='ROYALTY BONUS'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='UPDATE INCOME'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu ='BOOSTER BONUS'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' and (valu like 'BOOSTER LEVEL BONUS %'); select sum(cast(credit as real)) from account where username='" + Session["newuser"].ToString() + "' ; select (sum(cast(credit as real))-sum(cast(debit as real))) from fundaccount where username='" + Session["newuser"].ToString() + "'; select count(username)  from sponser  where sponser='" + Session["newuser"].ToString() + "';select count(username)  from sponserdownline  where  username='" + Session["newuser"].ToString() + "'; select * from news where status='Active';";
                DataSet ds = ob.dsss(sql);
                try
                {
                    DataTable dt = ds.Tables[0];

                    if (dt.Rows[0][0].ToString() == "Active")
                    {
                        Label1.ForeColor = Color.Green;
                        Label1.Text = "Active";
                        Label1.Font.Bold = true;

                    }
                    if (dt.Rows[0][0].ToString() == "Not Active")
                    {
                        Label1.BackColor = Color.Red;
                        Label1.Text = "Not Active";
                        Label1.Font.Bold = true;

                    }

                }
                catch (Exception hg) { };

                try
                {
                    double d1 = 0, d2 = 0, d3 = 0;
                    try
                    {
                        DataTable drcr2 = ds.Tables[2];
                        d1 = Convert.ToDouble(drcr2.Rows[0][0]);


                    }
                    catch (Exception jh)
                    {
                        d1 = 0;
                        d2 = 0;
                        d3 = 0;
                    };

                    DataTable dt = ds.Tables[3];
                    Label4.Text = Math.Round((Convert.ToDouble(dt.Rows[0][0]) - d1), 2).ToString();
                    if (Label4.Text == "")
                    {
                        Label4.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                }


                try
                {

                    DataTable getlvl = ds.Tables[4];
                    lbl_team.Text = Math.Round(Convert.ToDouble(getlvl.Rows[0][0].ToString()), 2).ToString(); 
                    if (lbl_team.Text == "")
                    {
                        lbl_team.Text = "0";
                    }
                }
                catch { }
                try
                {

                    DataTable getlvl = ds.Tables[2];
                    Label3.Text = getlvl.Rows[0][0].ToString();
                    if (Label3.Text == "")
                    {
                        Label3.Text = "0";
                    }
                }
                catch { }
                try
                {

                    DataTable getlvl = ds.Tables[5];
                    lbl_levelbonus.Text = getlvl.Rows[0][0].ToString();
                    if (lbl_levelbonus.Text == "")
                    {
                        lbl_levelbonus.Text = "0";
                    }
                }
                catch { }
               
                try
                {

                    DataTable getlvl = ob.dttt("select top(1) status from levelset where username='"+Session["newuser"].ToString()+"' order by id desc") ;
                    lbl_starincome.Text = getlvl.Rows[0][0].ToString();
                    if (lbl_starincome.Text == "")
                    {
                        lbl_starincome.Text = "Club Un-qualified";
                    }
                }
                catch { }
                try
                {

                    DataTable getlvl = ob.dttt("select sum(cast(amount as real)) from tblactiveamount where username='" + Session["newuser"].ToString() + "'");
                    Label7.Text = getlvl.Rows[0][0].ToString();
                    if (Label7.Text == "")
                    {
                        Label7.Text = "No Package";
                    }
                }
                catch { }
               

                try
                {

                    DataTable getlvl = ds.Tables[15];
                    lbl_totalincome.Text = Math.Round(Convert.ToDouble(getlvl.Rows[0][0].ToString()), 2).ToString(); 
                    if (lbl_totalincome.Text == "")
                    {
                        lbl_totalincome.Text = "0";
                    }
                }
                catch { }

                try
                {

                    DataTable getlvl = ds.Tables[16];
                    lbl_availablefund.Text = getlvl.Rows[0][0].ToString();
                    if (lbl_availablefund.Text == "")
                    {
                        lbl_availablefund.Text = "0";
                    }
                }
                catch { }
                try
                {

                    DataTable getlvl = ds.Tables[16];
                    lbl_availablefund.Text = getlvl.Rows[0][0].ToString();
                    if (lbl_availablefund.Text == "")
                    {
                        lbl_availablefund.Text = "0";
                    }
                }
                catch { }

                try
                {

                    DataTable getlvl = ds.Tables[18];
                    lbl_myteam.Text = getlvl.Rows[0][0].ToString();
                    if (lbl_myteam.Text == "")
                    {
                        lbl_myteam.Text = "0";
                    }
                }
                catch { }


                try
                {

                    DataTable getlvl = ds.Tables[17];
                    lbl_mydirect.Text = getlvl.Rows[0][0].ToString();
                    if (lbl_mydirect.Text == "")
                    {
                        lbl_mydirect.Text = "0";
                    }
                }
                catch { }




                try
                {

                    // DataTable getlvl = ob.dttt("select sum(cast(lvlincome as real)) as lvl from dailyrecordsmartjyoti where USERNAME='" + Session["newuser"].ToString() + "'");
                    DataTable getlvl = ds.Tables[0];
                    join_date.Text = getlvl.Rows[0][1].ToString();
                    if (join_date.Text == "")
                    {
                        join_date.Text = System.DateTime.Now.ToString("dd-MM-yyyy");
                    }
                }
                catch { }
                try
                {

                   
                    DataTable getlvl = ds.Tables[1];
                    Label5.Text = Convert.ToDateTime( getlvl.Rows[0][1]).ToString("dd-MMM-yyyy");
                    if (Label5.Text == "")
                    {
                        Label5.Text = System.DateTime.Now.ToString("dd-MM-yyyy");
                    }
                }
                catch { }
             


                if (!IsPostBack)
                {
                    try
                    {
                        DataTable dt = ob.dttt("select news from news where status='Active' ");
                      
                        news.Text = dt.Rows[0][0].ToString();
                    }
                    catch { }


                    //this.ModalPopupExtender1.Show();
                }
            }
            catch (Exception jh) { };
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select status from register where username='" + Session["newuser"].ToString() + "'");

        if (dt.Rows[0][0].ToString() == "Not Active")
        {
            Session["username"] = Session["newuser"].ToString();
            Response.Redirect("topup.aspx");
        }
    
    }


    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        Response.Redirect("dailydpi.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("boosterid.aspx");
    }
}