using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
public partial class newUser_uplineid : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
       {
        try
        {
           
            try
            {

               


                DataSet ds = ob.dsss("select * from levelset where username='"+Session["newuser"].ToString()+"' order by id asc");
                GridView1.DataSource = ds;
                GridView1.DataBind();
                GridView1.UseAccessibleHeader = true;
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;

            }
            catch { }
       
           
        }catch(Exception jh){};
    }

    }
  


    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        
        int total = 0;
        int totalreentry =0;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

           
            try
            {
                if(Convert.ToInt32(e.Row.Cells[1].Text)==4 && Convert.ToInt32(e.Row.Cells[2].Text)==1)
                {
                   
                        e.Row.BackColor = System.Drawing.Color.Green;
                        e.Row.ForeColor = System.Drawing.Color.White;
                        e.Row.Cells[4].Text = "Boosting Complete";
                   
                }
                else
                {
                    e.Row.Cells[4].Text = "Boosting Pending";
                }

            }catch(Exception jh){};
          
           
        }
    }

  
}