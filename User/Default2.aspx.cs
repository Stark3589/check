using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class User_Default2 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string date="2017-10-27";
        DataTable reg = ob.dttt("select username,reffid from register where username!='STC0000001' order by id asc");
        for(int regi=0;regi<Convert.ToInt32(reg.Rows.Count);regi++)
        {

            DataTable register_table = ob.dttt("select usermname from regtest");



        int x = 0;
        while (x < Convert.ToInt32(register_table.Rows.Count))
        {
            try
            {
                DataTable dt33 = ob.dttt("select leftcount from total_binarycount where username='" + register_table.Rows[x][0].ToString() + "' ");
                int s1 = Convert.ToInt32(dt33.Rows[0][0].ToString());
                s1 = s1 + 1;
                ob.Execute("update total_binarycount set leftcount ='" + s1.ToString() + "' where username='" + register_table.Rows[x][0].ToString() + "'");
                x = x + 1;
            }
            catch (Exception)
            {
                x = 1;
            };
        }
        ob.Execute("insert into regtest values('" + reg.Rows[regi][0].ToString() + "')");
        // use table levelset for set level of user
        DataTable getreguser = ob.dttt("select usermname from regtest");
        for (int sf = 0; sf < Convert.ToInt32(getreguser.Rows.Count); sf++)
        {
            DataTable spnsr = ob.dttt("select leftcount from total_binarycount where username='" + getreguser.Rows[sf][0].ToString() + "'");
            int spons = Convert.ToInt32(spnsr.Rows[0][0]);
            if (spons == 50)
            {
                ob.Execute("insert into levelset values('" + getreguser.Rows[sf][0].ToString() + "','1',0)");
            }
            if (spons == 250)
            {
                ob.Execute("update levelset set lvl='2',amount='0' where username='" + getreguser.Rows[sf][0].ToString() + "')");
            }
            if (spons == 750)
            {
                ob.Execute("update levelset set lvl='3',amount='0' where username='" + getreguser.Rows[sf][0].ToString() + "')");
            }
            if (spons == 1750)
            {
                ob.Execute("update levelset set lvl='4',amount='0' where username='" + getreguser.Rows[sf][0].ToString() + "')");
            }
            if (spons == 3750)
            {
                ob.Execute("update levelset set lvl='5',amount='0' where username='" + getreguser.Rows[sf][0].ToString() + "')");
            }
            if (spons == 8750)
            {
                ob.Execute("update levelset set lvl='6',amount='0' where username='" + getreguser.Rows[sf][0].ToString() + "')");
            }
            if (spons == 18750)
            {
                ob.Execute("update levelset set lvl='7',amount='0' where username='" + getreguser.Rows[sf][0].ToString() + "')");
            }
            if (spons == 38750)
            {
                ob.Execute("update levelset set lvl='8',amount='0' where username='" + getreguser.Rows[sf][0].ToString() + "')");
            }
            if (spons == 88750)
            {
                ob.Execute("update levelset set lvl='9',amount='0' where username='" + getreguser.Rows[sf][0].ToString() + "')");
            }
            if (spons == 238750)
            {
                ob.Execute("update levelset set lvl='10',amount='0' where username='" + getreguser.Rows[sf][0].ToString() + "')");
            }
        }

        //selt sposer in [daily_sponsercountincome]

        try
        {
            // DataTable getlvl = ob.dttt("select * from daily_sponsercountincome where username='" + sponser.Rows[x][0].ToString() + "'");
            DataTable spon = ob.dttt("select sponser from sponser where username='" + reg.Rows[regi][0].ToString() + "'");
           
            SqlDataReader getlvldr = ob.drrr("select * from daily_sponsercountincome where username='" + spon.Rows[0][0].ToString() + "'");
            if (getlvldr.Read())
            {
                ob.CloseConn();
                DataTable getlvl = ob.dttt("select max(lvl) from daily_sponsercountincome where username='" + spon.Rows[0][0].ToString() + "'");
                int c = Convert.ToInt32(getlvl.Rows[0][0]) + 1;
                ob.Execute("insert into daily_sponsercountincome values('" + spon.Rows[0][0].ToString() + "'," + c + ")");
            }
            else
            {
                ob.CloseConn();
                ob.Execute("insert into daily_sponsercountincome values('" + spon.Rows[0][0].ToString() + "',1)");
            }

        }
        catch (Exception jh) { };


       

        //level amount set karne ke liye



        //distribute level income use table levelpercent
        try
        {
            DataTable maxlvl = ob.dttt("select max(lvl) from levelset");
            if (Convert.ToInt32(maxlvl.Rows[0][0]) > 0)
            {
                for (int lvli = 1; lvli <= Convert.ToInt32(maxlvl.Rows[0][0]); lvli++)
                {
                    DataTable getpercent = ob.dttt("select percentage,amount from levelpercent where lvl='" + lvli.ToString() + "'");
                    double d1 = ((750 * Convert.ToDouble(getpercent.Rows[0][0])) / 100);
                    DataTable lvlusercount = ob.dttt("select count(a.username) from daily_sponsercountincome a,levelset b where a.lvl='" + lvli.ToString() + "' and b.lvl='" + lvli.ToString() + "' and a.username=b.username");
                    d1 = d1 / Convert.ToDouble(lvlusercount.Rows[0][0]);
                    DataTable lvlusertotal = ob.dttt("select a.username from daily_sponsercountincome a,levelset b where a.lvl='" + lvli.ToString() + "' and b.lvl='" + lvli.ToString() + "' and a.username=b.username");

                    for (int lvluseri = 0; lvluseri < Convert.ToInt32(lvlusercount.Rows[0][0]); lvluseri++)
                    {
                        
                            DataTable getamt = ob.dttt("select amount from levelset where username='" + lvlusertotal.Rows[lvluseri][0].ToString() + "' and lvl='" + lvli.ToString() + "'");
                            double amtd = Convert.ToDouble(getamt.Rows[0][0]) + d1;
                            if (Convert.ToDouble(getpercent.Rows[0][1]) >= amtd)
                            {
                                ob.Execute("insert into money values('" + lvlusertotal.Rows[lvluseri][0].ToString() + "','" + d1.ToString() + "','" + date + "','Growth Income')");
                                ob.Execute("update levelset set amount='" + amtd.ToString() + "' where username='" + lvlusertotal.Rows[lvluseri][0].ToString() + "' and lvl='" + lvli.ToString() + "'");
                            }
                       
                    }

                }
            }
        }
        catch { }

    }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DataTable sponser = ob.dttt("select sponser from sponser");
        for (int x = 0; x < Convert.ToInt32(sponser.Rows.Count); x++)
        {
            try
            {
               // DataTable getlvl = ob.dttt("select * from daily_sponsercountincome where username='" + sponser.Rows[x][0].ToString() + "'");
                SqlDataReader getlvldr = ob.drrr("select * from daily_sponsercountincome where username='" + sponser.Rows[x][0].ToString() + "'");
                if (getlvldr.Read())
                {
                    ob.CloseConn();
                    DataTable getlvl = ob.dttt("select max(lvl) from daily_sponsercountincome where username='" + sponser.Rows[x][0].ToString() + "'");
                    int c = Convert.ToInt32(getlvl.Rows[0][0])+1;
                    ob.Execute("insert into daily_sponsercountincome values('" + sponser.Rows[x][0].ToString() + "',"+c+")");
                }
                else
                {
                    ob.CloseConn();
                    ob.Execute("insert into daily_sponsercountincome values('" + sponser.Rows[x][0].ToString() + "',1)");
                }

            }
            catch (Exception jh) { };
        }
    }
}