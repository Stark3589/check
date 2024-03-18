using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class User_Closing2 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //// Account add
        DateTime dt11 = Convert.ToDateTime(TextBox2.Text);
        string dd = dt11.Day.ToString();
        string mm = dt11.Month.ToString();
        string yy = dt11.Year.ToString();
        string y = yy + "-" + mm + "-" + dd;
        DateTime dt111 = Convert.ToDateTime(TextBox1.Text);
        string dd1 = dt111.Day.ToString();
        string mm1 = dt111.Month.ToString();
        string yy1 = dt111.Year.ToString();
        string y1 = yy1 + "-" + mm1 + "-" + dd1;
        SqlDataReader drclose = ob.drrr("select * from closingdate where dateto between '" + y1 + "' and '" + y + "' and monthly='Weekly Income'");
        if (drclose.Read())
        {
            ob.CloseConn();
            Response.Write("<script>alert('Closing Process Already Completed. Please Try Another Date ')</script>");
        }
        else
        {
            ob.CloseConn();
            directclosing();
            SponserClosing();

            ob.Execute("insert into closingdate (datefrom,dateto,monthly) values('" + y1 + "','" + y + "','Weekly Income')");
            Response.Write("<script>alert('Closing Generated Successfully ')</script>");
        }
    }

    public void directclosing()
    {
        try
        {
            // Direct Income
            DateTime dt11 = Convert.ToDateTime(TextBox1.Text);
            string dd = dt11.Day.ToString();
            string mm = dt11.Month.ToString();
            string yy = dt11.Year.ToString();
            string y = yy + "-" + mm + "-" + dd;
            DateTime dt111 = Convert.ToDateTime(TextBox2.Text);
            string dd1 = dt111.Day.ToString();
            string mm1 = dt111.Month.ToString();
            string yy1 = dt111.Year.ToString();
            string y1 = yy1 + "-" + mm1 + "-" + dd1;
            DataTable fdd = ob.dttt("select distinct username from money where date between '" + y + "' and '" + y1 + "' and status='Weekly Income'");
            for (int i = 0; i < Convert.ToInt32(fdd.Rows.Count); i++)
            {
                try
                {
                    SqlDataReader dr = ob.drrr("select * from dailyrecordsmartjyoti where username='" + fdd.Rows[i][0].ToString() + "' and date='" + y + "' and date1='" + y1 + "'");
                    if (dr.Read())
                    {
                        ob.CloseConn();
                    }
                    else
                    {
                        ob.CloseConn();
                        ob.Execute("insert into dailyrecordsmartjyoti(username,directincome,lvlincome,poolincome,frnincome,total,date,date1) values('" + fdd.Rows[i][0].ToString() + "','0','0','0','0','0','" + y + "','" + y1 + "')");

                        // ob.Execute("insert into dailyrecord values('" + fdd.Rows[i][0].ToString() + "','0','0','0','" + y + "','0','0','0','0','0','0')");
                    }

                    DataTable yg = ob.dttt(" select sum(cast(money as real)) from money where date between '" + y + "' and '" + y1 + "' and username='" + fdd.Rows[i][0].ToString() + "' and status='Weekly Income' ");
                    double fds = Convert.ToDouble(yg.Rows[0][0]);
                    DataTable ddt = ob.dttt("select directincome,total from dailyrecordsmartjyoti where username='" + fdd.Rows[i][0].ToString() + "' and date='" + y + "' and date1='" + y1 + "'");
                    double sd1 = Math.Round((Convert.ToDouble(ddt.Rows[0][0]) + fds), 2);
                    double sd2 = Math.Round((Convert.ToDouble(ddt.Rows[0][1]) + fds), 2);
                    ob.Execute("update dailyrecordsmartjyoti set directincome='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + fdd.Rows[i][0].ToString() + "' and date='" + y + "' and date1='" + y1 + "'");
                    SqlDataReader dr1 = ob.drrr("select * from account where username='" + fdd.Rows[i][0].ToString() + "'");
                    if (dr1.Read())
                    {
                        ob.CloseConn();
                    }
                    else
                    {
                        ob.CloseConn();
                        ob.Execute("insert into account (username,credit,debit,total) values('" + fdd.Rows[i][0].ToString() + "','0','0','0')");

                        // ob.Execute("insert into dailyrecord values('" + fdd.Rows[i][0].ToString() + "','0','0','0','" + y + "','0','0','0','0','0','0')");
                    }
                    DataTable drcr = ob.dttt("select sum(cast(credit as real)),sum(cast(debit as real)) from account where username='" + fdd.Rows[i][0].ToString() + "'");
                    double total = Convert.ToDouble(drcr.Rows[0][0]) - Convert.ToDouble(drcr.Rows[0][1]);
                    total = total + fds;
                    total = Math.Round(total, 2);
                    ob.Execute("insert into account (username,credit,debit,total,date,valu) values('" + fdd.Rows[i][0].ToString() + "','" + Math.Round(fds, 2).ToString() + "','0','" + total.ToString() + "','" + y + "','Weekly Income')");
                }
                catch { }
            }
        }
        catch { }

    }


    public void SponserClosing()
    {
        try
        {
            // Direct Income
            DateTime dt11 = Convert.ToDateTime(TextBox1.Text);
            string dd = dt11.Day.ToString();
            string mm = dt11.Month.ToString();
            string yy = dt11.Year.ToString();
            string y = yy + "-" + mm + "-" + dd;
            DateTime dt111 = Convert.ToDateTime(TextBox2.Text);
            string dd1 = dt111.Day.ToString();
            string mm1 = dt111.Month.ToString();
            string yy1 = dt111.Year.ToString();
            string y1 = yy1 + "-" + mm1 + "-" + dd1;
            DataTable fdd = ob.dttt("select distinct username from money where date between '" + y + "' and '" + y1 + "' and status='Sponser Income'");
            for (int i = 0; i < Convert.ToInt32(fdd.Rows.Count); i++)
            {
                try
                {
                    SqlDataReader dr = ob.drrr("select * from dailyrecordsmartjyoti where username='" + fdd.Rows[i][0].ToString() + "' and date='" + y + "' and date1='" + y1 + "'");
                    if (dr.Read())
                    {
                        ob.CloseConn();
                    }
                    else
                    {
                        ob.CloseConn();
                        ob.Execute("insert into dailyrecordsmartjyoti(username,directincome,lvlincome,poolincome,frnincome,total,date,date1) values('" + fdd.Rows[i][0].ToString() + "','0','0','0','0','0','" + y + "','" + y1 + "')");

                        // ob.Execute("insert into dailyrecord values('" + fdd.Rows[i][0].ToString() + "','0','0','0','" + y + "','0','0','0','0','0','0')");
                    }

                    DataTable yg = ob.dttt(" select sum(cast(money as real)) from money where date between '" + y + "' and '" + y1 + "' and username='" + fdd.Rows[i][0].ToString() + "' and status='Sponser Income' ");
                    double fds = Convert.ToDouble(yg.Rows[0][0]);
                    DataTable ddt = ob.dttt("select lvlincome,total from dailyrecordsmartjyoti where username='" + fdd.Rows[i][0].ToString() + "' and date='" + y + "' and date1='" + y1 + "'");
                    double sd1 = Math.Round((Convert.ToDouble(ddt.Rows[0][0]) + fds), 2);
                    double sd2 = Math.Round((Convert.ToDouble(ddt.Rows[0][1]) + fds), 2);
                    ob.Execute("update dailyrecordsmartjyoti set lvlincome='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + fdd.Rows[i][0].ToString() + "' and date='" + y + "' and date1='" + y1 + "'");
                    SqlDataReader dr1 = ob.drrr("select * from account where username='" + fdd.Rows[i][0].ToString() + "'");
                    if (dr1.Read())
                    {
                        ob.CloseConn();
                    }
                    else
                    {
                        ob.CloseConn();
                        ob.Execute("insert into account (username,credit,debit,total) values('" + fdd.Rows[i][0].ToString() + "','0','0','0')");

                        // ob.Execute("insert into dailyrecord values('" + fdd.Rows[i][0].ToString() + "','0','0','0','" + y + "','0','0','0','0','0','0')");
                    }
                    DataTable drcr = ob.dttt("select sum(cast(credit as real)),sum(cast(debit as real)) from account where username='" + fdd.Rows[i][0].ToString() + "'");
                    double total = Convert.ToDouble(drcr.Rows[0][0]) - Convert.ToDouble(drcr.Rows[0][1]);
                    total = total + fds;
                    total = Math.Round(total, 2);
                    ob.Execute("insert into account (username,credit,debit,total,date,valu) values('" + fdd.Rows[i][0].ToString() + "','" + Math.Round(fds, 2).ToString() + "','0','" + total.ToString() + "','" + y + "','Sponser Income')");
                }
                catch { }
            }
        }
        catch { }

    }



    


}