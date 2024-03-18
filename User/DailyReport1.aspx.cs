using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public partial class newuser_DailyReport1 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();

    double act = 0, inc=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try{
                DataTable dt2 = ob.dttt("SELECT register.name,register.dateofjoin,register.rtime,register.mobile,register.username,register.status FROM register JOIN Downline ON register.username = Downline.downlineid where   Downline.username='MB0000001'");
                GridView2.DataSource = dt2;
                GridView2.DataBind();
               
            }
            catch { }
        }


    }



    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            //string term = "", policydate = "";
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //If Salary is less than 10000 than set the row Background Color to Cyan  
                if (e.Row.Cells[5].Text == "Active")
                {
                    e.Row.BackColor = Color.Green;
                    e.Row.ForeColor = Color.White;

                    if (e.Row.Cells[5].Text == "Not Active")
                    {
                        e.Row.BackColor = Color.Red;
                        e.Row.ForeColor = Color.White;
                    }

                }
            }
        }
        catch { }
    }
  
}