using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

public partial class Admin_homefrn : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
    protected void Page_Load(object sender, EventArgs e)
    {
       
       

        try
        {
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
            string query = "select (sum(cast(amount as real))) from tblactiveamount  ";
            DataTable dt = ob.dttt(query);
            Label4.Text =dt.Rows[0][0].ToString();
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
            //  DataTable getlvl = ob.dttt("select sum(cast(directincome as real)) as direct from dailyrecordsmartjyoti where USERNAME='" + Session["newuser"].ToString() + "'");
            DataTable getlvl = ob.dttt("select sum(cast(total_amt as real)) from withdrawal ");
            Label11.Text = getlvl.Rows[0][0].ToString();
            if(Label11.Text=="")
            {
                Label11.Text = "0";
            }
        }
        catch { }
        //try
        //{
        //    SqlDataReader drr = ob.drrr("select * from register where username='"+Session["newuser"].ToString()+"' and status='Active'");
        //    if(drr.Read())
        //    {
        //        ob.CloseConn();
        //        lbl_daily.Text = "500 Rs";

        //    }
        //    else
        //    {
        //        ob.CloseConn();
        //        lbl_daily.Text = "0 Rs";
        //    }
        //}catch(Exception jh){};
     

        try
        {
           
            DataTable getlvl = ob.dttt("select count(username) from register where dateofjoin='"+System.DateTime.Now.ToString("yyyy-MM-dd")+"'");
            lbl_team.Text = getlvl.Rows[0][0].ToString();
            if (lbl_team.Text == "")
            {
                lbl_team.Text = "0";
            }
        }
        catch { }
        try
        {

            DataTable getlvl = ob.dttt("select sum(cast(amount as real))  from tblactiveamount where date='" + System.DateTime.Now.ToString("yyyy-MM-dd") + "'");
            Label12.Text = getlvl.Rows[0][0].ToString();
            if (Label12.Text == "")
            {
                Label12.Text = "0";
            }
        }
        catch { }
        try
        {

            DataTable getlvl = ob.dttt("select count(username) from levelset");
            Label13.Text =( Convert.ToInt32( getlvl.Rows[0][0])*25).ToString();
            if (Label13.Text == "")
            {
                Label13.Text = "0";
            }
        }
        catch { }

        try
        {

            DataTable getlvl = ob.dttt("select sum(cast(total_amt as real)) from withdrawal where status='Transfer' ");
            Label3.Text = getlvl.Rows[0][0].ToString();
            if (Label3.Text == "")
            {
                Label3.Text = "0";
            }
        }
        catch { }
        try
        {

            DataTable getlvl = ob.dttt("select count(username) from register ");
            Label5.Text = getlvl.Rows[0][0].ToString();
            if (Label5.Text == "")
            {
                Label5.Text = "0";
            }
        }
        catch { }
        try
        {

            DataTable getlvl = ob.dttt("select count(username) from register where status='Not Active'");
            Label2.Text = getlvl.Rows[0][0].ToString();
            if (Label2.Text == "")
            {
                Label2.Text = "0";
            }
        }
        catch { }
      

           
        
        //try
        //{
        //  //  DataTable getlvl = ob.dttt("select sum(cast(directincome as real)) as direct from dailyrecordsmartjyoti where USERNAME='" + Session["newuser"].ToString() + "'");
        //    DataTable getlvl = ob.dttt("select sum(cast(credit as real)) as direct from account where USERNAME='" + Session["newuser"].ToString() + "' and valu like 'LEVEL INCOME FROM %'");
        //    Label3.Text = getlvl.Rows[0][0].ToString();
        //}
        //catch { }
       
      
      
        try
        {
            DataTable getlvl = ob.dttt("select (sum(cast(credit as real))-sum(cast(debit as real))) from fundaccount");
            Label8.Text = getlvl.Rows[0][0].ToString();
            if (Label8.Text == "")
            {
                Label8.Text = "0";
            }

        }
        catch { }
        try
        {

            // DataTable getlvl = ob.dttt("select sum(cast(lvlincome as real)) as lvl from dailyrecordsmartjyoti where USERNAME='" + Session["newuser"].ToString() + "'");
            DataTable getlvl = ob.dttt("select sum(cast(credit as real)) from account");
            join_date.Text = getlvl.Rows[0][0].ToString();
            if (join_date.Text == "")
            {
                join_date.Text = "0";
            }
        }
        catch { }
        try
        {
            //DataTable getlvl = ob.dttt("select id from register where username='" + Session["newuser"].ToString() + "'");
            //DataTable coun = ob.dttt("select count(username) from register where id<="+getlvl.Rows[0][0].ToString()+"");
            //Label7.Text = coun.Rows[0][0].ToString();
        }
        catch { }
       

       
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        
    }
  
   


  
}