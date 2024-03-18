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
        if (!IsPostBack)
        {
            ob.Execute("delete from inactivereport");
            //DataTable dt = ob.dttt("select a.name,a.dateofjoin,a.rtime,a.mobile,a.username,b.l,b.r,c.username as direct,d.reff from register a,binary b,direct c,refferal d where a.username=d.refferal and a.username=c.direct and a.username=b.binary and (b.l='0' or b.r='0')");

            DataTable dt = ob.dttt("select a.name,a.dateofjoin,a.rtime,a.mobile,a.username,b.l,b.r,c.username as direct,d.sponser from register a,sponsercount b,direct c,refferal d where a.username=d.refferal and a.username=c.direct and a.username=b.sponser and (b.l='0' or b.r='0')");
            DataTable dtc = ob.dttt("select count(*) from register a,binary b where a.username=b.reff and (b.l='0' or b.r='0')");
            int c = Convert.ToInt32(dtc.Rows[0][0].ToString());
            for (int i = 0; i < c; i++)
            {
                DataTable dtu = ob.dttt("select name,mobile,username from register where username='" + dt.Rows[i][7].ToString() + "'");

                DataTable dts = ob.dttt("select name,mobile,username from register where username='" + dt.Rows[i][8].ToString() + "'");
                ob.Execute("insert into inactivereport(jdate,time,name,userid,l,r,mob,uname,uuser,umob,sname,suser,smob) values('"+dt.Rows[i][1].ToString().Substring(0,10)+"','"+dt.Rows[i][2].ToString()+"','"+dt.Rows[i][0].ToString()+"','"+dt.Rows[i][4].ToString()+"','"+dt.Rows[i][5].ToString()+"','"+dt.Rows[i][6].ToString()+"','"+dt.Rows[i][3].ToString()+"','"+dtu.Rows[0][0].ToString()+"','"+dtu.Rows[0][2].ToString()+"','"+dtu.Rows[0][1].ToString()+"','"+dts.Rows[0][0].ToString()+"','"+dts.Rows[0][2].ToString()+"','"+dts.Rows[0][1].ToString()+"')");
            }
            DataTable dtt = ob.dttt("select * from inactivereport");
            GridView1.DataSource = dtt;
            GridView1.DataBind();
        }
    }
}