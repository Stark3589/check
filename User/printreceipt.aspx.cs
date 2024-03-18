using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_printreceipt : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable dm = ob.dttt("select amount from pinmgt where reguser='" + Session["receipt"].ToString() + "'");
            int a = Convert.ToInt32(dm.Rows[0][0].ToString());
            int b = a - 200;
            Label11.Text = b + ".00";
            Label12.Text = a + ".00";


            DataTable dt = ob.dttt("select name,fname,address,mobile,city,pin,state,dateofjoin,rtime from register where username='" + Session["receipt"].ToString() + "'");
            Label1.Text = Session["rec"].ToString();
            Label2.Text = dt.Rows[0][0].ToString();
            Label3.Text = dt.Rows[0][1].ToString();
            Label4.Text = dt.Rows[0][2].ToString();
            Label5.Text = dt.Rows[0][3].ToString();
            Label7.Text = dt.Rows[0][4].ToString();
            Label8.Text = dt.Rows[0][5].ToString();
            Label9.Text = "("+dt.Rows[0][6].ToString()+") India";
            if (Label9.Text == "(Uttar Pradesh) India")
            {
                Label9.Text = "(U.P) India";
            }
            Label6.Text = Session["receipt"].ToString();
            Label10.Text = dt.Rows[0][7].ToString().Substring(0, 10) + ", " + dt.Rows[0][8].ToString();
        }
        catch (Exception) { }
    }
}