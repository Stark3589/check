using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_ClosingDetail : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select * from tdstable");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        foreach (GridViewRow gvrow in GridView1.Rows)
        {
            ob.Execute("create table ajeet (username nvarchar(max),matching nvarchar(max),direct nvarchar(max),bonus nvarchar(max),tds nvarchar(max),adm nvarchar(max),total nvarchar(max))");
            CheckBox cb = gvrow.FindControl("CheckBox1") as CheckBox;
            if (cb.Checked)
            {
                DateTime d1 = Convert.ToDateTime(gvrow.Cells[2]);
                string d = d1.Day.ToString() ;
                string m = d1.Month.ToString();
                string y = d1.Year.ToString();
                string date1=y+"-"+m+"-"+d;
                DateTime d2 = Convert.ToDateTime(gvrow.Cells[2]);
                string dd1 = d2.Day.ToString();
                string m1 = d2.Month.ToString();
                string y1 = d2.Year.ToString();
                string date2 = y1 + "-" + m1 + "-" + dd1;
                ob.Execute("insert into ajeet select username,purchase,sponser,nextclub,tds,adm,total from tdstable where date1='"+date1+"' and date2='"+date2+"'");
                
            }
        }
        DataSet ds = ob.dsss("select * from ajeet");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        ob.Execute("drop table ajeet");

    }
}