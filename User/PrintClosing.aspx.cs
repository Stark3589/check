using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_PrintClosing : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select name,fname,address,city,state,pin,mobile from register where username='" + Session["cluser"].ToString() + "'");
        Label12.Text = Session["cluser"].ToString();
        Label1.Text = dt.Rows[0][0].ToString();
        Label18.Text = dt.Rows[0][0].ToString();
        Label19.Text = dt.Rows[0][0].ToString();
        Label2.Text = dt.Rows[0][1].ToString();
        Label3.Text = dt.Rows[0][2].ToString();
        Label4.Text = dt.Rows[0][3].ToString();
        Label5.Text = dt.Rows[0][4].ToString();
        Label6.Text = dt.Rows[0][5].ToString();
        Label15.Text = dt.Rows[0][6].ToString();
        DataTable dt2 = ob.dttt("select purchase,sponser,nextclub,tds,payable,date1,date2,turnover,reward,fix,adm,cheque,cdate,bank,weekno,monthly from tdstable where id='" + Session["clid"].ToString() + "'");
        //GridView1.DataSource = dt2;
        //GridView1.DataBind();
        Label7.Text = dt2.Rows[0][5].ToString().Substring(0, 10);
        Label8.Text = dt2.Rows[0][6].ToString().Substring(0, 10);
        double a = Convert.ToDouble(dt2.Rows[0][3].ToString());
        double b = Convert.ToDouble(dt2.Rows[0][4].ToString());
        double c = Convert.ToDouble(dt2.Rows[0][10].ToString());
        a = a + b + c;
        Label9.Text = a.ToString();
        Label10.Text = dt2.Rows[0][3].ToString();
        Label11.Text = dt2.Rows[0][4].ToString();
        Label13.Text = c.ToString();
        Label14.Text = dt2.Rows[0][11].ToString();
        DateTime date1 = DateTime.Parse(dt2.Rows[0][12].ToString());
        Label16.Text = date1.ToString("dd-MM-yyyy");
        Label17.Text = dt2.Rows[0][13].ToString();
        if (dt2.Rows[0][14].ToString() == "" || dt2.Rows[0][14].ToString() == null)
        {
            LabelMW.Text = "Month " + dt2.Rows[0][15].ToString();
        }
        if (dt2.Rows[0][15].ToString() == "" || dt2.Rows[0][15].ToString() == null)
        {
            LabelMW.Text = "Week " + dt2.Rows[0][14].ToString();
        }
    }
}