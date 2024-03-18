using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;

public partial class User_printreg : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = ob.dttt("select reffid, name, username, fname, onside, dateofjoin, address, city, State, country, email, mobile, status, nomineename, relation, pan, nage, ndob, sex, pin, dob from register where username='" + Session["userid"].ToString() + "'");
            Label42.Text = dt.Rows[0][5].ToString().Substring(0, 10);
            Label43.Text = dt.Rows[0][1].ToString();
            Label44.Text = dt.Rows[0][3].ToString();
            Label45.Text = dt.Rows[0][6].ToString();
            Label46.Text = dt.Rows[0][18].ToString();
            Label47.Text = dt.Rows[0][20].ToString();
            Label48.Text = dt.Rows[0][8].ToString();
            Label49.Text = dt.Rows[0][19].ToString();
            Label50.Text = dt.Rows[0][7].ToString();
            Label51.Text = dt.Rows[0][11].ToString();
            Label52.Text = dt.Rows[0][15].ToString();
            Label53.Text = dt.Rows[0][10].ToString();
            Label54.Text = dt.Rows[0][0].ToString();
            Label55.Text = dt.Rows[0][2].ToString();
            //Label56.Text=dt.Rows[0][].ToString();
            Label57.Text = dt.Rows[0][4].ToString();
            Label58.Text = dt.Rows[0][13].ToString();
            Label59.Text = dt.Rows[0][14].ToString();
            Label60.Text = dt.Rows[0][16].ToString();
            Label61.Text = dt.Rows[0][17].ToString().Substring(0, 10);
            //Label62.Text=dt.Rows[0][].ToString();
            try
            {

                DataTable dt2 = ob.dttt("select username from direct where direct = '" + Session["userid"].ToString() + "'");
                Label56.Text = dt2.Rows[0][0].ToString();
            }
            catch (Exception) { Label56.Text = ""; };


            DataTable dt3 = ob.dttt("select accno,bankname,ifsc,branchname,holdername from bankdetail where username='" + Session["userid"].ToString() + "'");
            Label62.Text = dt3.Rows[0][1].ToString();
            Label63.Text = dt3.Rows[0][0].ToString();
            Label64.Text = dt3.Rows[0][2].ToString();
            Label65.Text = dt3.Rows[0][4].ToString();
            Label66.Text = dt3.Rows[0][3].ToString();


            DataTable dt4 = ob.dttt("select image from images where username='" + Session["userid"].ToString() + "'");
            Image1.ImageUrl = dt4.Rows[0][0].ToString();

        }
        catch(Exception)
        {

        }
    }
}