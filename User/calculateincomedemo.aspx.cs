using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class User_calculateincomedemo : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable register_table = ob.dttt("select reff from binary where id>1");

        for (int si = 0; si < register_table.Rows.Count; si++)
        {
            string reffid = register_table.Rows[si][0].ToString();
            int x = 0;

            //Daily purchse count
            while (x == 0)
            {
                try
                {

                    ob.CloseConn();
                    DataTable dt12 = ob.dttt("select reff from binary where l='" + reffid + "' or m='" + reffid + "' or r='" + reffid + "' or lr='" + reffid + "' or lm='" + reffid + "'");
                    string sss = dt12.Rows[0][0].ToString();

                    DataTable dt33 = ob.dttt("select leftcount from total_binarycount where username='" + sss + "' ");
                    int s1 = Convert.ToInt32(dt33.Rows[0][0].ToString());
                    s1 = s1 + 1;
                    ob.Execute("update total_binarycount set leftcount ='" + s1.ToString() + "' where username='" + sss + "'");




                    reffid = sss;



                }
                catch (Exception)
                {
                    x = 1;
                };
            }
            try
            {
                SqlConnection con = new SqlConnection( ConfigurationManager.ConnectionStrings["ccmbConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[regi]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", register_table.Rows[si][0].ToString());

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception jh) { }

        }

    }
}