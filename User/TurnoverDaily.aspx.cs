using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_TurnoverDaily : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        string date = System.DateTime.UtcNow.Year.ToString() + "-" + System.DateTime.UtcNow.Month.ToString() + "-" + System.DateTime.UtcNow.Day.ToString();

        DataTable tot = ob.dttt("select count(username) from register");
        Label2.Text = tot.Rows[0][0].ToString();

        DataTable tot1 = ob.dttt("select count(username) from register where dateofjoin='" + date + "'");
        Label3.Text = tot1.Rows[0][0].ToString();
        int total = Convert.ToInt32(Label3.Text);
        int totincome = 4600 * total;
        Label4.Text = Convert.ToString(totincome);

        int totlaford = 2200 * total;

        Label8.Text = Convert.ToString(totlaford);

        //double sercharge = (490 * total * 14.5) / 100;
        double sercharge = total * 29;
        Label7.Text = Convert.ToString(sercharge);

        int courier = total * 50;

        Label6.Text = Convert.ToString(courier);

        double dis = 121 * total;
        Label5.Text = Convert.ToString(dis);

        double totcompro = 2200 * total;
        Label9.Text = Convert.ToString(totcompro);

        try
        {
            DataTable dtt = ob.dttt("select sum(cast(tds as real)),sum(cast(adm as real)),sum(cast(payable as real)) from tdstable where date2='"+date+"'");
            Label10.Text = dtt.Rows[0][0].ToString();
            if (Label10.Text == "")
            {
                Label10.Text = "0";
            }
            Label11.Text = dtt.Rows[0][1].ToString();
            if (Label11.Text == "")
            {
                Label11.Text = "0";
            }
            Label12.Text = dtt.Rows[0][2].ToString();
            if (Label12.Text == "")
            {
                Label12.Text = "0";
            }
        }
        catch (Exception) { Label10.Text = "0"; Label11.Text = "0"; Label12.Text = "0"; }
        Label13.Text = (Convert.ToInt32(Label9.Text) - Convert.ToInt32(Label12.Text)).ToString();
        DataTable dtl = ob.dttt("select l,r from sponsercount where sponser='NSI2016170509'");

    }
}