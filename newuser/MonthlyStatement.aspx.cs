using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class newuser_Default2 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string type = Request.QueryString["type"];
            if (type == "ROI_INCOME")
            {
                Label2.Text = "HAULAGE RENTAL INCOME";
                DataTable dt = ob.dttt("select * from account where username='" + Session["newuser"].ToString() + "' and valu='HAULAGE RENTAL INCOME'");
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            if (type == "LEVEL_INCOME")
            {
                Label2.Text = "HAULAGE LEVEL INCOME";
                DataTable dt = ob.dttt("select * from account where username='" + Session["newuser"].ToString() + "' and valu='HAULAGE LEVEL INCOME'");
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            //if (type == "DAILY_LEVEL")
            //{
            //    Label2.Text = "LEVEL INCOME";
            //    DataTable dt = ob.dttt("select * from account where username='" + Session["newuser"].ToString() + "' and valu ='LEVEL INCOME'");
            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();
            //    GridView1.UseAccessibleHeader = true;
            //    GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            //}
            //if (type == "ADD_VIEW_INCOME")
            //{
            //    Label2.Text = "DAILY ADD VIEW INCOME";
            //    DataTable dt = ob.dttt("select * from account where username='" + Session["newuser"].ToString() + "' and valu= 'DAILY TEAM ADD VIEW INCOME'");
            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();
            //    GridView1.UseAccessibleHeader = true;
            //    GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            //}
        }catch(Exception jh){};
    }
}