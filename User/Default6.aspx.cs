using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class User_Default6 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         string reffid = "NSI100133";
        int x = 0;

        //Daily purchse count
        while (x == 0)
        {
            try
            {
                SqlDataReader dr = ob.drrr("select reff from binary where l='" + reffid + "' ");
                if (dr.Read())
                {
                    ob.CloseConn();
                    DataTable dt12 = ob.dttt("select reff from binary where l = '" + reffid + "'");
                    string sss = dt12.Rows[0][0].ToString();


                    DataTable dt34 = ob.dttt("select leftcount from daily_binarycount where username='" + sss + "' ");
                    double s2 = Convert.ToDouble(dt34.Rows[0][0].ToString());
                    s2 = s2 + 7800;

                    ob.Execute("update daily_binarycount set leftcount ='" + s2.ToString() + "' where username='" + sss + "'");
                    reffid = sss;

                }
                else
                {
                    ob.CloseConn();
                    DataTable dt12 = ob.dttt("select reff from binary where r = '" + reffid + "'");
                    string sss = dt12.Rows[0][0].ToString();


                    DataTable dt34 = ob.dttt("select rightcount from daily_binarycount where username='" + sss + "' ");
                    double s2 = Convert.ToDouble(dt34.Rows[0][0].ToString());
                    s2 = s2 + 7800;
                    ob.Execute("update daily_binarycount set rightcount ='" + s2.ToString() + "' where username='" + sss + "'");
                    reffid = sss;
                }
            }
            catch (Exception)
            {
                x = 1;
            };
        }
    }
}