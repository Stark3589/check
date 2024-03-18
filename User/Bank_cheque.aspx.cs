using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class Bank_cheque : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        string idd = Request.QueryString["user"].ToString();
        string amount = Request.QueryString["amount"].ToString();
        //string id = Request.QueryString["id"].ToString();

     


        string query = "select name from register where username ='" + idd + "'";
        DataTable dt = ob.dttt(query);
        if (dt.Rows.Count > 0)
        {
            try
            {
                lbl_date.Text = Request.QueryString["date"].ToString();
            }
            catch (Exception ex) { }
            try
            {
                lbl_name.Text = dt.Rows[0]["name"].ToString();
            }
            catch (Exception ex) { }
            try
            {
                lbl_amountwords.Text = ConvertNumbertoWords(Convert.ToInt32(amount))+" RUPEES ONLY.";
            }
            catch (Exception ex) { }
            try
            {
                lbl_amount.Text = amount+"/.";
            }
            catch (Exception ex) { }
            
        }


    }

   
    public static string ConvertNumbertoWords(int number)
    {
        if (number == 0)
            return "ZERO";
        if (number < 0)
            return "minus " + ConvertNumbertoWords(Math.Abs(number));
        string words = "";
        if ((number / 1000000) > 0)
        {
            words += ConvertNumbertoWords(number / 1000000) + " MILLION ";
            number %= 1000000;
        }
        if ((number / 1000) > 0)
        {
            words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
            number %= 1000;
        }
        if ((number / 100) > 0)
        {
            words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
            number %= 100;
        }
        if (number > 0)
        {
            if (words != "")
                words += "AND ";
            var unitsMap = new[] { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
            var tensMap = new[] { "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += " " + unitsMap[number % 10];
            }
        }
        return words;
    }
}
