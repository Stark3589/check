using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class deathfinalcertificate : System.Web.UI.Page
{

    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        

        try
        {
            DataTable dt = ob.dttt("select * from death where srno='" + Session["dsrno"].ToString() + "'");
            Label15.Text = Convert.ToString(dt.Rows[0][3].ToString());
            Label16.Text = Convert.ToString(dt.Rows[0][5].ToString());
            Label17.Text = Convert.ToString(dt.Rows[0][4].ToString());
            Label18.Text = Convert.ToString(dt.Rows[0][10].ToString());
            Label19.Text = Convert.ToString(dt.Rows[0][6].ToString());
            Label20.Text = Convert.ToString(dt.Rows[0][13].ToString());
            Label21.Text = Convert.ToString(dt.Rows[0][14].ToString());
            Label22.Text = Convert.ToString(dt.Rows[0][1].ToString());
            Label23.Text = Convert.ToString(dt.Rows[0][2].ToString());
        }
        catch (IndexOutOfRangeException hn) { };
        string dd = System.DateTime.UtcNow.Day.ToString();
        string mm = System.DateTime.UtcNow.Month.ToString();
        string yy = System.DateTime.UtcNow.Year.ToString();
        string ddd = dd + "-" + mm + "-" + yy;
        Label24.Text = ddd;
        Label25.Text = "Pahasu";
    }
}