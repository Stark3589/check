using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;

public partial class User_Closing : System.Web.UI.Page
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
        SqlDataReader drclose = ob.drrr("select * from closingdate where dateto between '" + y1 + "' and '" + y + "' and monthly='Pool Income'");
        if (drclose.Read())
        {
            ob.CloseConn();
            Response.Write("<script>alert('Closing Process Already Completed. Please Try Another Date ')</script>");
        }
        else
        {
            ob.CloseConn();
            singleleg();
          
            ob.Execute("insert into closingdate (datefrom,dateto,monthly) values('" + y1 + "','" + y + "','Pool Income')");
            Response.Write("<script>alert('Pool Income Generated Successfully ')</script>");
        }
    }

    public void singleleg()
    {
        DataTable tf = ob.dttt("select count(username) from register where dateofjoin between '"+TextBox1.Text+"' and '"+TextBox2.Text+"'");
        int sa = Convert.ToInt32(tf.Rows[0][0])*15;

        DataTable tf1 = ob.dttt("select count(username) from poolachv where membercount>=10");
        int saa = Convert.ToInt32(tf1.Rows[0][0]);
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
        double b1 = 0.0;
        if(sa!=0)
        {
             b1 = Convert.ToDouble(sa/saa);

             DataTable tf2 = ob.dttt("select username from poolachv where membercount>=10");
            for(int i=0;i<saa;i++)
            {
                SqlDataReader dr = ob.drrr("select * from dailyrecordsmartjyoti where username='" + tf2.Rows[i][0].ToString() + "' and date='" + y + "' and date1='" + y1 + "'");
                if (dr.Read())
                {
                    ob.CloseConn();
                }
                else
                {
                    ob.CloseConn();
                    ob.Execute("insert into dailyrecordsmartjyoti(username,directincome,lvlincome,poolincome,frnincome,total,date,date1) values('" + tf2.Rows[i][0].ToString() + "','0','0','0','0','0','" + y + "','" + y1 + "')");

                    // ob.Execute("insert into dailyrecord values('" + fdd.Rows[i][0].ToString() + "','0','0','0','" + y + "','0','0','0','0','0','0')");
                }

               
                DataTable ddt = ob.dttt("select poolincome,total from dailyrecordsmartjyoti where username='" + tf2.Rows[i][0].ToString() + "' and date='" + y + "' and date1='" + y1 + "'");
                double sd1 = Math.Round((Convert.ToDouble(ddt.Rows[0][0]) + b1), 0);
                double sd2 = Math.Round((Convert.ToDouble(ddt.Rows[0][1]) + b1), 0);
                ob.Execute("update dailyrecordsmartjyoti set poolincome='" + sd1.ToString() + "',total='" + sd2.ToString() + "' where username='" + tf2.Rows[i][0].ToString() + "' and date='" + y + "' and date1='" + y1 + "'");
               
               
            }
        }
    }
    


}