using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class User_billprint : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer ();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Label1.Text=Label10.Text =Session["a"].ToString();
        //Label8.Text = Session["b"].ToString();
       // Label5.Text = Session["c"].ToString();
        Label7.Text = System.DateTime.UtcNow.ToString("yyyy-MM-dd");
       
        
        try 
        {
       
           DataTable dt = ob.dttt("select name,fname,address,pin,state,mobile,password,dateofjoin,rtime,city from register where username='" + Session["asa"].ToString() + "'");
           Label1.Text = Label10.Text= dt.Rows[0][0].ToString();
          // Labelname.Text = dt.Rows[0][0].ToString();
           Label2.Text = dt.Rows[0][1].ToString();
           Label3.Text = dt.Rows[0][2].ToString();
           Label4.Text = "(" + dt.Rows[0][4].ToString() + ") India";
           if (Label4.Text == "(Uttar Pradesh) India")
           {
               Label4.Text = "(U.P) India";
           }
           Label5.Text = dt.Rows[0][3].ToString();
           Label13.Text = dt.Rows[0][5].ToString();
           Label12.Text = dt.Rows[0][9].ToString();
           //Label7.Text = dt.Rows[0][7].ToString().Substring(0, 10) + ", " + dt.Rows[0][8].ToString();
           //Label7.Text = System.DateTime.UtcNow.DayOfWeek.ToString() + ", " + System.DateTime.UtcNow.Day.ToString() + "-" + System.DateTime.UtcNow.Month.ToString() + "-" + System.DateTime.UtcNow.Year.ToString();
          // Label8.Text = Session["verify"].ToString();
          // Label9.Text = dt.Rows[0][6].ToString();
       }
       catch (Exception) { }



        var chars11 = "0123456789";
        var stringChars11 = new char[4];
        var random11 = new Random();

        for (int ik = 0; ik < stringChars11.Length; ik++)
        {
            stringChars11[ik] = chars11[random11.Next(chars11.Length)];
        }

        var finalString11 = new String(stringChars11);
        Label6.Text = Convert.ToString(finalString11);
        
       //try
       //{
       //    DataTable dt2 = ob.dttt("select card,coupon from approval where username='" + Session["verify"].ToString() + "'");
       //    Label10.Text = dt2.Rows[0][0].ToString();
       //    Label11.Text = dt2.Rows[0][1].ToString();
       //}
       //catch (Exception) { }
       //try
       //{
       //    DataTable dt8 = ob.dttt("select code from coupon where username='" + Session["verify"].ToString() + "'");
       //    Label13.Text = dt8.Rows[0][0].ToString();
       //    // Label11.Text = dt8.Rows[0][1].ToString();
       //}
       //catch (Exception) { }

    }
}