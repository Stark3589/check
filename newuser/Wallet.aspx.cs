using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;

public partial class wallet : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
    //protected void Page_Load(object sender, EventArgs e)
    //{


    //    DateTime utcTime = DateTime.UtcNow;
    //    TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");


    //    DateTime indiantime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);

    //    String tttt = indiantime.AddDays(-1).ToString("yyyy-MM-dd");
    //    string dd = "";
       

    //    try
    //    {
    //        DataTable dtamt = ob.dttt("select round((sum(cast(credit as real))-sum(cast(debit as real))),2) as total from fundaccount where username='" + Session["newuser"].ToString() + "'");
    //        Label1.Text = dtamt.Rows[0][0].ToString();
            

    //    }
    //    catch (Exception ex)
    //    { }
        
    //}
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DataTable drcr = ob.dttt("select sum(cast(debit as real)) from fundaccount where username='" + Session["newuser"].ToString() + "' ");
                DataTable drcr1 = ob.dttt("select sum(cast(credit as real)) from fundaccount where username='" + Session["newuser"].ToString() + "' ");
                double d1 = 0, d2 = 0, d3 = 0;
               
                double total = Convert.ToDouble(drcr1.Rows[0][0]) - Convert.ToDouble(drcr.Rows[0][0]) - d1 - d2 - d3;


                Label1.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
                if(Label1.Text=="")
                {
                    Label1.Text = "0";
                }
                // TextBox1.Text = "200";
                // Label2.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
            }
            catch (Exception) { Label1.Text = "0"; };
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        string txnpass = EncodePasswordToBase64(TextBox2.Text);
        DataTable gettxnrecord = ob.dttt("select * from register where username='"+Session["newuser"].ToString()+"' and onside='"+txnpass+"'");
        if (gettxnrecord.Rows.Count > 0)
        {
            if (Convert.ToDouble(Label1.Text) >= Convert.ToDouble(TextBox5.Text) && Convert.ToDouble(TextBox5.Text)>0)
            {
                SqlDataReader drr = ob.drrr("select * from register where username='" + TextBox1.Text + "'");
                if (drr.Read())
                {
                    ob.CloseConn();

                    string dd = System.DateTime.Now.Day.ToString();
                    string mm = System.DateTime.Now.Month.ToString();
                    string yy = System.DateTime.Now.Year.ToString();
                    string y = yy + "-" + mm + "-" + dd;
                    string sss = "AMOUNT RECEIVE FROM " + Session["newuser"].ToString();
                    string sss1 = "AMOUNT TRANSFER TO " + TextBox1.Text;
                    ob.Execute("insert into fundaccount (username,credit,debit,date,status) values('" + TextBox1.Text + "','" + TextBox5.Text + "','0','" + y + "','" + sss + "')");
                    ob.Execute("insert into fundaccount (username,credit,debit,date,status) values('" + Session["newuser"].ToString() + "','0','" + TextBox5.Text + "','" + y + "','" + sss1 + "')");
                    Response.Write("<script>alert('Fund Transfer Successfully')</script>");
                    TextBox1.Text = "";
                    TextBox3.Text = "";
                    TextBox5.Text = "";
                    try
                    {
                        DataTable drcr = ob.dttt("select sum(cast(debit as real)) from fundaccount where username='" + Session["newuser"].ToString() + "' ");
                        DataTable drcr1 = ob.dttt("select sum(cast(credit as real)) from fundaccount where username='" + Session["newuser"].ToString() + "' ");
                        double d1 = 0, d2 = 0, d3 = 0;

                        double total = Convert.ToDouble(drcr1.Rows[0][0]) - Convert.ToDouble(drcr.Rows[0][0]) - d1 - d2 - d3;


                        Label1.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
                        // TextBox1.Text = "200";
                        // Label2.Text = Math.Round(Convert.ToDouble(total), 2).ToString();
                    }
                    catch (Exception) { };

                }
                else
                {
                    ob.CloseConn();
                    Response.Write("<script>alert('User ID is incorrect')</script>");
                }
            }
        }
        else
        {
            Response.Write("<script>alert('Incorrect Txn Password')</script>");
        }

    }

    protected void Button1_Click(object sender, EventArgs e)              //request
    {
        if (TextBox1.Text == "10000000")
        {
            Response.Write("<script>alert('Please enter another user id')</script>");
        }
        else
        {
            string mm = System.DateTime.UtcNow.DayOfWeek.ToString();

            try
            {

                DataTable name = ob.dttt("select name from register where username='" + TextBox1.Text + "'");
                TextBox3.Text = name.Rows[0][0].ToString();
                if (TextBox3.Text == "" || TextBox3.Text == null)
                {
                    TextBox3.Text = "invalid user id";
                    TextBox3.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception jh) { };
        }

    }


    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {
        try
        {

            double d11 = Convert.ToDouble(TextBox5.Text);





            if (Convert.ToDouble(Label1.Text) >= Convert.ToDouble(TextBox5.Text))
            {
                TextBox5.Text = (d11).ToString();
            }
            else
            {
                Response.Write("<script>alert('insufficient amount')</script>");
            }
            
               
            
        }
        catch (Exception hg) { };
    }
}
