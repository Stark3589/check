using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
       string date=System.DateTime.UtcNow.Year.ToString()+"-"+System.DateTime.UtcNow.Month.ToString()+"-"+System.DateTime.UtcNow.Day.ToString();
                SqlDataReader dr2 = ob.drrr("select * from dailydate where date='" + date + "'");
                if (dr2.Read())
                {
                    dr2.Close();
                }
                else
                {
                    dr2.Close();
                    ob.Execute("insert into dailydate(date) values('" + date + "')");
                    DataTable dt = ob.dttt("select count(username) from register");
                    DataTable dt2 = ob.dttt("select username from register");
                    int c = Convert.ToInt32(dt.Rows[0][0].ToString());
                    for (int i = 0; i < c; i++)
                    {
                        string name = dt2.Rows[i][0].ToString();
                        ob.Execute("insert into dailyrecord(username,purchase,nextclub,sponser,date) values('" + name + "','0','0','0','" + date + "')");
                       
                    }
                }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "trade@account" && TextBox2.Text == "tradenex@0786")
        {
            Session["ADMIN"] = TextBox1.Text;
            Response.Redirect("Geneology.aspx");
        }
            else
            {
                
                Response.Write("<script>alert('Invalid Username or Password')</script>");
            }
        
    }
}