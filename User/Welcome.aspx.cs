using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_Welcome : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["verify"] != null)
        {
            try
            {
                DataTable dt = ob.dttt("select name,fname,address,pin,state,mobile,password,dateofjoin,rtime,city from register where username='" + Session["verify"].ToString() + "'");
                Label1.Text = dt.Rows[0][0].ToString();
                Labelname.Text = dt.Rows[0][0].ToString();
                Label2.Text = dt.Rows[0][1].ToString();
                Label3.Text = dt.Rows[0][2].ToString();
                Label4.Text = "(" + dt.Rows[0][4].ToString() + ") India";
                if (Label4.Text == "(Uttar Pradesh) India")
                {
                    Label4.Text = "(U.P) India";
                }
                Label5.Text = dt.Rows[0][3].ToString();
                Label6.Text = dt.Rows[0][5].ToString();
                Label12.Text = dt.Rows[0][9].ToString();
                Label7.Text = dt.Rows[0][7].ToString().Substring(0, 10) + ", " + dt.Rows[0][8].ToString();
                //Label7.Text = System.DateTime.UtcNow.DayOfWeek.ToString() + ", " + System.DateTime.UtcNow.Day.ToString() + "-" + System.DateTime.UtcNow.Month.ToString() + "-" + System.DateTime.UtcNow.Year.ToString();
                Label8.Text = Session["verify"].ToString();
                Label9.Text = dt.Rows[0][6].ToString();
            }
            catch (Exception) { }
           
           
        }
    }
}