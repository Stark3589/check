using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class User_Directlist : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("SELECT a.dateofjoin, a.rtime, b.username, a.name, a.mobile, b.sponser,a.status FROM register a,sponser b where a.username=b.username ");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string getValue = e.Row.Cells[6].Text;
            //Check your condition here
            if (getValue == "active")
            {



                //  setColorClass = "successMerit"; // setting green color class 
                e.Row.BackColor = System.Drawing.Color.GreenYellow;
            }

            else
            {

                e.Row.BackColor = System.Drawing.Color.Red;
                e.Row.ForeColor = System.Drawing.Color.White;
            }
        }
    }
}