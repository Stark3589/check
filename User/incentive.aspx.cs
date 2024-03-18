using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_incentive : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        //calculate();
        calculatebonus();
        string dd = System.DateTime.UtcNow.Day.ToString();
        string mm = System.DateTime.UtcNow.Month.ToString();
        string yy = System.DateTime.UtcNow.Year.ToString();
        string y = yy + "-" + mm + "-" + dd;
        //sponsercalculate();
        SqlDataReader drclose = ob.drrr("select * from closingdate where datefrom='"+y+"' and weekno='Daily'");
        if (drclose.Read())
        {
            ob.CloseConn();
            Response.Write("<script>alert('Closing Process Already Completed. Please Try Another Date ')</script>");
        }
        else
        {
            ob.CloseConn();
            // Account add


            ob.Execute("insert into closingdate (datefrom,weekno) values('"+y+"','Daily')");
            Response.Write("<script>alert('Incentive Generated Successfully ')</script>");
        }
    }



    public void calculatebonus()
    {
        try
        {
            //direct bonus purchase
            
            DataTable dcount = ob.dttt("select count(username) from daily_counttable");
            DataTable dcount1 = ob.dttt("select * from daily_counttable");
            string dd = System.DateTime.UtcNow.Day.ToString();
            string mm = System.DateTime.UtcNow.Month.ToString();
            string yy = System.DateTime.UtcNow.Year.ToString();
            string y = yy + "-" + mm + "-" + dd;
            for (int i = 0; i < Convert.ToInt32(dcount.Rows[0][0]); i++)
            {
                DataTable dstatus = ob.dttt("select status from register where username='" + dcount1.Rows[i][0].ToString() + "'");
                //SqlDataReader dbothside = ob.drrr("select * from binary where username='" + dcount1.Rows[i][0].ToString() + "' and l!='0' and y!='0'");
                if (dstatus.Rows[0][0].ToString() == "Active")
                {
                    ob.CloseConn();
                    try
                    {
                        DataTable dst = ob.dttt("select amount from pinmgt where reguser='" + dcount1.Rows[i][0].ToString() + "'");
                        if (Convert.ToInt32(dst.Rows[0][0]) >= 5500)
                        {
                            SqlDataReader dr = ob.drrr("select * from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                            if (dr.Read())
                            {
                                ob.CloseConn();
                            }
                            else
                            {
                                ob.CloseConn();
                                ob.Execute("insert into dailyrecord values('" + dcount1.Rows[i][0].ToString() + "','0','0','0','" + y + "','0','0','0','0','0','0')");
                            }

                            DataTable d1 = ob.dttt("select * from daily_counttable where username='" + dcount1.Rows[i][0].ToString() + "'");
                            int a = Convert.ToInt32(d1.Rows[0][1]);
                            int b = Convert.ToInt32(d1.Rows[0][2]);
                            if (a == b && a <= 4)
                            {
                                int a1 = 0;
                                ob.Execute("update daily_counttable set leftcount='0',rightcount='0' where username='" + dcount1.Rows[i][0].ToString() + "'");
                                for (int x = 1; x <= a; x++)
                                {
                                    ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
                                    a1 = a1 + 200;

                                }
                                DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                                int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
                                int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
                                ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");

                            }
                            if (a == b && a > 4)
                            {
                                int a1 = 0;
                                ob.Execute("update daily_counttable set leftcount='0',rightcount='0' where username='" + dcount1.Rows[i][0].ToString() + "'");
                                for (int x = 1; x <= 4; x++)
                                {

                                    ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
                                    a1 = a1 + 200;

                                }
                                DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                                int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
                                int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
                                ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                            }
                            if (a < b && a <= 4)
                            {
                                int a1 = 0;
                                int d = b - a;
                                ob.Execute("update daily_counttable set leftcount='0',rightcount='" + d.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "'");
                                for (int x = 1; x <= a; x++)
                                {

                                    ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
                                    a1 = a1 + 200;

                                }
                                DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                                int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
                                int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
                                ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                            }
                            if (b < a && b <= 4)
                            {
                                int a1 = 0;
                                int d = a - b;
                                ob.Execute("update daily_counttable set leftcount='" + d.ToString() + "',rightcount='0' where username='" + dcount1.Rows[i][0].ToString() + "'");
                                for (int x = 1; x <= b; x++)
                                {

                                    ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
                                    a1 = a1 + 200;

                                }
                                DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                                int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
                                int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
                                ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                            }
                            if (a < b && a > 4)
                            {
                                int a1 = 0;
                                int d = b - a;
                                ob.Execute("update daily_counttable set leftcount='0',rightcount='" + d.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "'");
                                for (int x = 1; x <= 4; x++)
                                {

                                    ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
                                    a1 = a1 + 200;

                                }
                                DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                                int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
                                int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
                                ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                            }
                            if (b < a && b > 4)
                            {
                                int a1 = 0;
                                int d = a - b;
                                ob.Execute("update daily_counttable set leftcount='" + d.ToString() + "',rightcount='0' where username='" + dcount1.Rows[i][0].ToString() + "'");
                                for (int x = 1; x <= 4; x++)
                                {

                                    ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
                                    a1 = a1 + 200;

                                }
                                DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                                int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
                                int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
                                ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
                            }

                        }
                    }catch(Exception jh){};
                }
            }
        }
        catch (Exception) { };
    }

    //public void calculatebonus()
    //{
    //    try
    //    {
    //        //direct bonus purchase
    //        DataTable dcount = ob.dttt("select count(username) from daily_counttable");
    //        DataTable dcount1 = ob.dttt("select * from daily_counttable");
    //        string dd = System.DateTime.UtcNow.Day.ToString();
    //        string mm = System.DateTime.UtcNow.Month.ToString();
    //        string yy = System.DateTime.UtcNow.Year.ToString();
    //        string y = yy + "-" + mm + "-" + dd;
    //        for (int i = 0; i < Convert.ToInt32(dcount.Rows[0][0]); i++)
    //        {
    //            DataTable dstatus = ob.dttt("select status from register where username='" + dcount1.Rows[i][0].ToString() + "'");
    //            //SqlDataReader dbothside = ob.drrr("select * from binary where username='" + dcount1.Rows[i][0].ToString() + "' and l!='0' and y!='0'");
    //            if (dstatus.Rows[0][0].ToString() == "Active")
    //            {
    //                ob.CloseConn();
    //                SqlDataReader dr = ob.drrr("select * from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                if (dr.Read())
    //                {
    //                    ob.CloseConn();
    //                }
    //                else
    //                {
    //                    ob.CloseConn();
    //                    ob.Execute("insert into dailyrecord values('" + dcount1.Rows[i][0].ToString() + "','0','0','0','" + y + "','0','0','0','0','0','0')");
    //                }

    //                DataTable d1 = ob.dttt("select * from daily_counttable where username='" + dcount1.Rows[i][0].ToString() + "'");
    //                int a = Convert.ToInt32(d1.Rows[0][1]);
    //                int b = Convert.ToInt32(d1.Rows[0][2]);
    //                if (a == b && a <= 4)
    //                {
    //                    int a1 = 0;
    //                    ob.Execute("update daily_counttable set leftcount='0',rightcount='0' where username='" + dcount1.Rows[i][0].ToString() + "'");
    //                    for (int x = 1; x <= a; x++)
    //                    {
    //                        ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
    //                        a1 = a1 + 200;

    //                    }
    //                    DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                    int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
    //                    int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
    //                    ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");

    //                }
    //                if (a == b && a > 4)
    //                {
    //                    int a1 = 0;
    //                    ob.Execute("update daily_counttable set leftcount='0',rightcount='0' where username='" + dcount1.Rows[i][0].ToString() + "'");
    //                    for (int x = 1; x <= 4; x++)
    //                    {

    //                        ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
    //                        a1 = a1 + 200;

    //                    }
    //                    DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                    int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
    //                    int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
    //                    ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                }
    //                if (a < b && a <= 4)
    //                {
    //                    int a1 = 0;
    //                    int d = b - a;
    //                    ob.Execute("update daily_counttable set leftcount='0',rightcount='" + d.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "'");
    //                    for (int x = 1; x <= a; x++)
    //                    {

    //                        ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
    //                        a1 = a1 + 200;

    //                    }
    //                    DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                    int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
    //                    int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
    //                    ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                }
    //                if (b < a && b <= 4)
    //                {
    //                    int a1 = 0;
    //                    int d = a - b;
    //                    ob.Execute("update daily_counttable set leftcount='" + d.ToString() + "',rightcount='0' where username='" + dcount1.Rows[i][0].ToString() + "'");
    //                    for (int x = 1; x <= b; x++)
    //                    {

    //                        ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
    //                        a1 = a1 + 200;

    //                    }
    //                    DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                    int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
    //                    int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
    //                    ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                }
    //                if (a < b && a > 4)
    //                {
    //                    int a1 = 0;
    //                    int d = b - a;
    //                    ob.Execute("update daily_counttable set leftcount='0',rightcount='" + d.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "'");
    //                    for (int x = 1; x <= 4; x++)
    //                    {

    //                        ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
    //                        a1 = a1 + 200;

    //                    }
    //                    DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                    int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
    //                    int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
    //                    ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                }
    //                if (b < a && b > 4)
    //                {
    //                    int a1 = 0;
    //                    int d = a - b;
    //                    ob.Execute("update daily_counttable set leftcount='" + d.ToString() + "',rightcount='0' where username='" + dcount1.Rows[i][0].ToString() + "'");
    //                    for (int x = 1; x <= 4; x++)
    //                    {

    //                        ob.Execute("insert into money values('" + dcount1.Rows[i][0].ToString() + "','200','" + y + "')");
    //                        a1 = a1 + 200;

    //                    }
    //                    DataTable ddt = ob.dttt("select nextclub,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                    int sd1 = Convert.ToInt32(ddt.Rows[0][0]) + a1;
    //                    int sd2 = Convert.ToInt32(ddt.Rows[0][1]) + a1;
    //                    ob.Execute("update dailyrecord set nextclub='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                }



    //            }
    //        }
    //    }
    //    catch (Exception) { };
    //}
    //public void sponsercalculate()
    //{
    //    DataTable dcount = ob.dttt("select count(username) from direct_income");
    //    DataTable dcount1 = ob.dttt("select * from direct_income");
    //    string dd = System.DateTime.UtcNow.Day.ToString();
    //    string mm = System.DateTime.UtcNow.Month.ToString();
    //    string yy = System.DateTime.UtcNow.Year.ToString();
    //    string y = yy + "-" + mm + "-" + dd;
    //    for (int i = 0; i < Convert.ToInt32(dcount.Rows[0][0]); i++)
    //    {

    //        DataTable dstatus = ob.dttt("select status from register where username='" + dcount1.Rows[i][0].ToString() + "'");
    //        SqlDataReader dbothside = ob.drrr("select * from binary where username='" + dcount1.Rows[i][0].ToString() + "' and l!='0' and y!='0'");
    //        if (dbothside.Read() && dstatus.Rows[0][0].ToString() == "Active")
    //        {
    //            ob.CloseConn();
    //            SqlDataReader dr = ob.drrr("select * from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //            if (dr.Read())
    //            {
    //                ob.CloseConn();
    //            }
    //            else
    //            {
    //                ob.CloseConn();
    //                ob.Execute("insert into dailyrecord values('" + dcount1.Rows[i][0].ToString() + "','0','0','0','" + y + "','0','0','0','0','0')");
    //            }

    //            try
    //            {
    //                int a1 = 0;
    //                DataTable d1 = ob.dttt("select amount from direct_income where username='" + dcount1.Rows[i][0].ToString() + "'");
                    
    //                DataTable ddt = ob.dttt("select sponser,total from dailyrecord where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                double sd1 = Convert.ToDouble(ddt.Rows[0][0]) + (Convert.ToDouble(d1.Rows[0][0])*(10/100));
    //                double sd2 = Convert.ToDouble(ddt.Rows[0][1]) + (Convert.ToDouble(d1.Rows[0][0]) * (10 / 100));
    //                ob.Execute("update dailyrecord set sponser='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + dcount1.Rows[i][0].ToString() + "' and date='" + y + "'");
    //                ob.Execute("update direct_income set amount='0' where username='" + dcount1.Rows[i][0].ToString() + "'");
    //            }
    //            catch (Exception) { };
    //        }
    //    }
    //}
    

}