using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

public partial class User_printrecept : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
        {
            if (Request.QueryString["username"] != null)
            {
                DateTime utcTime = DateTime.UtcNow;
                //current Time
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime timenow = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                //string doj=timenow.
                DateTime datenow1 = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                string datenow = datenow1.ToString("yyyy-MM-dd");
                string username = Request.QueryString["username"].ToString();
                detail(username);
                bindata(datenow);
                //string sname = lbsoftname12.Text = ob.sname();
              //  compn.Text = sname;
               // lbsoftaddress.Text = ob.saddress();
                string quy = "select mobile from tblsoftdetail";
                DataTable dtu = ob.dttt(quy);
               // Label7.Text = dtu.Rows[0]["mobile"].ToString();
            }

        }
        catch (Exception k) { };
            
        }
    }
    private void detail(string username)
    {
        string query = "select name,username,address,mobile,pan from register where username='" + username + "'";
                DataTable dy = ob.dttt(query);
                if (dy.Rows.Count > 0)
                {
                    lblm.Text = dy.Rows[0]["name"].ToString().ToUpper();
                    lblf.Text = dy.Rows[0]["address"].ToString().ToUpper();
                    lbladd.Text = dy.Rows[0]["pan"].ToString().ToUpper();
                    lblno.Text = dy.Rows[0]["mobile"].ToString().ToUpper();
                    Label6.Text = dy.Rows[0]["username"].ToString().ToUpper();

                    supply.Text = lblf.Text;
                    DateTime utcTime = DateTime.UtcNow;
                    //current Time
                    TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                    DateTime timenow = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                    //string doj=timenow.
                    DateTime datenow1 = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                    string datenow = datenow1.ToString("yyyy/MM/dd");
                    lbldate.Text = datenow;
                    lbln.Text = invoice().ToUpper();
                }   
    }
    private void bindata(string date)
    {
        double total = 0;
        string query = "select productname,amount,totalamt,productcode,quantity from userproductdetail where username='" + Label6.Text + "'  and date='" + date + "' ";
        DataTable dt = ob.dttt(query);
        gridview.DataSource = dt;
        gridview.DataBind();

        foreach (GridViewRow r in gridview.Rows)
        {
            total += Convert.ToDouble(r.Cells[5].Text);

        }
        gridview.FooterRow.Cells[4].Text = "Total";
        gridview.FooterRow.Cells[4].HorizontalAlign = HorizontalAlign.Right;
        gridview.FooterRow.Cells[5].HorizontalAlign = HorizontalAlign.Right;
        gridview.FooterRow.Cells[5].Text = total.ToString("N2");

        Label3.Text = total.ToString();
        Label3.Visible = true;



        string quury = "select sum(cast(gst as real)) as gst from userproductdetail where username='" + Label6.Text + "' and date='" + date + "'";
        DataTable dc = ob.dttt(quury);
        if (dc.Rows.Count > 0)
        {
            string addgst = dc.Rows[0]["gst"].ToString();
            Label4.Text = addgst;
            Label4.Visible = true;
        }
        string qury = "select sum(cast(cgst as real)) as cgst from userproductdetail where username='" + Label6.Text + "' and date='" + date + "'";
        DataTable d = ob.dttt(qury);
        if (d.Rows.Count > 0)
        {
            string cgstt = d.Rows[0]["cgst"].ToString();
            Label5.Text = cgstt;
            Label5.Visible = true;
        }

       int totall = Convert.ToInt32(Label4.Text) +  Convert.ToInt32(Label5.Text);
       Label3.Text = (totall + total).ToString();
       try
       {
           int amt = Convert.ToInt32(Label3.Text);
           words.Text = NumbersToWords(amt).ToString() + " Rupees ";
       }
       catch (Exception ex)
       { }
       
    }
    public static string NumbersToWords(int inputNumber)
    {
        int inputNo = inputNumber;

        if (inputNo == 0)
            return "Zero";

        int[] numbers = new int[4];
        int first = 0;
        int u, h, t;
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        if (inputNo < 0)
        {
            sb.Append("Minus");
            inputNo = -inputNo;
        }

        string[] words0 = {"" ,"One ", "Two ", "Three ", "Four ",
            "Five " ,"Six ", "Seven ", "Eight ", "Nine "};
        string[] words1 = {"Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ",
            "Fifteen ","Sixteen ","Seventeen ","Eighteen ", "Nineteen "};
        string[] words2 = {"Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ",
            "Seventy ","Eighty ", "Ninety "};
        string[] words3 = { "Thousand ", "Lakh ", "Crore " };

        numbers[0] = inputNo % 1000; // units
        numbers[1] = inputNo / 1000;
        numbers[2] = inputNo / 100000;
        numbers[1] = numbers[1] - 100 * numbers[2]; // thousands
        numbers[3] = inputNo / 10000000; // crores
        numbers[2] = numbers[2] - 100 * numbers[3]; // lakhs

        for (int i = 3; i > 0; i--)
        {
            if (numbers[i] != 0)
            {
                first = i;
                break;
            }
        }
        for (int i = first; i >= 0; i--)
        {
            if (numbers[i] == 0) continue;
            u = numbers[i] % 10; // ones
            t = numbers[i] / 10;
            h = numbers[i] / 100; // hundreds
            t = t - 10 * h; // tens
            if (h > 0) sb.Append(words0[h] + "Hundred ");
            if (u > 0 || t > 0)
            {
                if (h > 0 || i == 0) sb.Append("and ");
                if (t == 0)
                    sb.Append(words0[u]);
                else if (t == 1)
                    sb.Append(words1[u]);
                else
                    sb.Append(words2[t - 2] + words0[u]);
            }
            if (i != 0) sb.Append(words3[i - 1]);
        }
        return sb.ToString().TrimEnd();
    }
    public string invoice()
    {
        string str = "";
        try
        {
            var chars = "0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int ik = 0; ik < stringChars.Length; ik++)
            {
                stringChars[ik] = chars[random.Next(chars.Length)];
            }
            // for getting associate id series
            string seris = "SVR00";

            var finalString = new String(stringChars);
            string capta = Convert.ToString(finalString);
            str =seris+ capta;
           
        }
        catch (Exception ex) { };
        return str;
    }



}