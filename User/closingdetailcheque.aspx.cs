using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class User_closingdetailcheque : System.Web.UI.Page
{
    
        BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ob.dttt("select * from closingdate where weekno IS NULL");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "VIEW")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;
            string st = Convert.ToString(lnkView.CommandArgument);

            DataTable dt = ob.dttt("select datefrom,dateto from closingdate where id='" + st + "'");
           
            string date1 = dt.Rows[0][0].ToString().Substring(0,10);
            string date2 = dt.Rows[0][1].ToString().Substring(0,10);
            string[] arrDate3 = date1.Split('/');
            //now use array to get specific date object
            string dd = arrDate3[0].ToString();
            string mm = arrDate3[1].ToString();
            string yy = arrDate3[2].ToString();
           
            try
            {
                if (Convert.ToInt32(mm) == 1)
                {
                    mm = "January";
                }
                if (Convert.ToInt32(mm) == 2)
                {
                    mm = "February";
                }
                if (Convert.ToInt32(mm) == 3)
                {
                    mm = "March";
                }
                if (Convert.ToInt32(mm) == 4)
                {
                    mm = "April";
                }
                if (Convert.ToInt32(mm) == 5)
                {
                    mm = "May";
                }
                if (Convert.ToInt32(mm) == 6)
                {
                    mm = "June";
                }
                if (Convert.ToInt32(mm) == 7)
                {
                    mm = "July";
                }
                if (Convert.ToInt32(mm) == 8)
                {
                    mm = "August";
                }
                if (Convert.ToInt32(mm) == 9)
                {
                    mm = "September";
                }
                if (Convert.ToInt32(mm) == 10)
                {
                    mm = "October";
                }
                if (Convert.ToInt32(mm) == 11)
                {
                    mm = "November";
                }
                if (Convert.ToInt32(mm) == 12)
                {
                    mm = "December";
                }
            }
            catch (Exception jh) { };
            string final1 = dd + ", " + mm + "," + yy;

            string[] arrDate2 = date2.Split('/');
            //now use array to get specific date object
            string dd1 = arrDate2[0].ToString();
            string mm1 = arrDate2[1].ToString();
            string yy1 = arrDate2[2].ToString();

            try
            {
                if (Convert.ToInt32(mm1) == 1)
                {
                    mm1 = "January";
                }
                if (Convert.ToInt32(mm1) == 2)
                {
                    mm1 = "February";
                }
                if (Convert.ToInt32(mm1) == 3)
                {
                    mm1 = "March";
                }
                if (Convert.ToInt32(mm1) == 4)
                {
                    mm1 = "April";
                }
                if (Convert.ToInt32(mm1) == 5)
                {
                    mm1 = "May";
                }
                if (Convert.ToInt32(mm1) == 6)
                {
                    mm1 = "June";
                }
                if (Convert.ToInt32(mm1) == 7)
                {
                    mm1 = "July";
                }
                if (Convert.ToInt32(mm1) == 8)
                {
                    mm1 = "August";
                }
                if (Convert.ToInt32(mm1) == 9)
                {
                    mm1 = "September";
                }
                if (Convert.ToInt32(mm1) == 10)
                {
                    mm1 = "October";
                }
                if (Convert.ToInt32(mm1) == 11)
                {
                    mm1 = "November";
                }
                if (Convert.ToInt32(mm1) == 12)
                {
                    mm1 = "December";
                }
            }
            catch (Exception jh) { };
            string final2 = dd1 + ", " + mm1 + "," + yy1;
            
            DateTime date11 = DateTime.Parse(dt.Rows[0][0].ToString());
            DateTime date22 = DateTime.Parse(dt.Rows[0][1].ToString());
            Session["cheque3"] = date11.ToString("yyyy-MM-dd");
            Session["cheque4"] = date22.ToString("yyyy-MM-dd");
            string strDate = date1; //Format – dd/MM/yyyy

            //split string date by separator, here I'm using '/'
            string[] arrDate = strDate.Split('/');
            //now use array to get specific date object
            string d1 = arrDate[0].ToString();
            string d2 = arrDate[1].ToString();
            string d3 = arrDate[2].ToString();
            string dateno = d3 + "-" + d2 + "-" + d1;

            string strDate1 = date2; //Format – dd/MM/yyyy

            //split string date by separator, here I'm using '/'
            string[] arrDate1 = strDate1.Split('/');
            //now use array to get specific date object
            string d11 = arrDate1[0].ToString();
            string d12 = arrDate1[1].ToString();
            string d13 = arrDate1[2].ToString();
            string datenow = d13 + "-" + d12 + "-" + d11;
           //DataTable dtg = ob.dttt("select a.id,a.username,a.sponser,a.nextclub,a.purchase,a.tds,a.payable,a.adm,b.name,b.mobile from tdstable a,register b where a.date1='" + date1.ToString("yyyy-MM-dd") + "' and a.date2='" + date2.ToString("yyyy-MM-dd") + "' and a.username=b.username and a.cheque IS NULL order by a.payable desc");
           //DataTable dtg = ob.dttt("SELECT a.username,a.purchase,a.nextclub,a.sponser,b.turnover,b.reward,b.fix,b.adm,b.payable,b.tds FROM dailyrecord a,tdstable b WHERE a.id=b.id and b.cheque IS NULL group by a.username,a.purchase,a.nextclub,a.sponser,b.turnover,b.reward,b.fix,b.adm,b.payable,b.tds order by b.payable desc ");
            //SELECT a.id,a.username,a.purchase,a.nextclub,a.sponser,b.turnover,b.reward,b.fix,b.adm,b.payable,b.tds FROM dailyrecord a,tdstable b WHERE a.username=b.username  and b.date1='2017-01-01' and b.date2='2017-01-31' and b.cheque IS NULL order by b.payable desc
            try
            {
                ob.Execute("drop view closing");
            }catch(Exception){};
            DataTable dtg = ob.dttt(" SELECT b.id,a.username,c.name,sum(cast(a.purchase as REAL)) as purchase,sum(cast(a.nextclub as real)) as nextclub,sum(cast(a.sponser as REAL)) as sponser,sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real)) as total_Amount,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(5 as REAL)))/100 as Admincharge,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(10 as REAL)))/100 as tds,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))-(((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(10 as REAL)))/100)-(((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(5 as REAL)))/100))) as payble_amount FROM dailyrecord a INNER JOIN tdstable b on a.username=b.username INNER JOIN register c on  b.username=c.username where b.payable!='0' group by a.username,b.id,c.name order by b.id asc");
            //DataTable dtg = ob.dttt(" SELECT b.id,a.username,sum(cast(a.purchase as REAL)) as purchase,sum(cast(a.nextclub as real)) as nextclub,sum(cast(a.sponser as REAL)) as sponser,sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real)) as total_Amount,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(5 as REAL)))/100 as Admincharge,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(10 as REAL)))/100 as tds,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))-(((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(10 as REAL)))/100)-(((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(5 as REAL)))/100))) as payble_amount FROM dailyrecord a INNER JOIN tdstable b on a.username=b.username and b.date1='"+date1+"' and b.date2='"+date2+"' group by a.username,b.id order by b.id asc");
            ob.Execute("create view closing as SELECT b.id,a.username,sum(cast(a.purchase as REAL)) as purchase,sum(cast(a.nextclub as real)) as nextclub,sum(cast(a.sponser as REAL)) as sponser,sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real)) as total_Amount,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(5 as REAL)))/100 as Admincharge,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(10 as REAL)))/100 as tds,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))-(((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(10 as REAL)))/100)-(((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(5 as REAL)))/100))) as payble_amount FROM dailyrecord a INNER JOIN tdstable b on a.username=b.username group by a.username,b.id");
            GridView2.DataSource = dtg;
            GridView2.DataBind();
            GridView2.Visible = false;
            GridView1.Visible = false;

           
            DataTable dtg2 = ob.dttt("select a.*,b.name,b.mobile from tdstable a,register b where a.date1='" + date11.ToString("yyyy-MM-dd") + "' and a.date2='" + date22.ToString("yyyy-MM-dd") + "' and a.username=b.username and a.cheque IS NOT NULL");

            //string sss = "SELECT b.cdate,b.id,a.username,sum(cast(a.purchase as REAL)) as purchase,sum(cast(a.nextclub as real)) as nextclub,sum(cast(a.sponser as REAL)) as sponser,sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real)) as total_Amount,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(5 as REAL)))/100 as Admincharge,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(10 as REAL)))/100 as tds,((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))-(((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(10 as REAL)))/100)-(((sum(cast(a.purchase as REAL)+cast(a.sponser as REAL)+cast(a.nextclub as real))*cast(5 as REAL)))/100))) as payble_amount FROM dailyrecord a INNER JOIN tdstable b on a.username=b.username and b.date1='" + dateno + "' and b.date2='" + datenow + "' group by a.username,b.id,b.cdate order by b.id asc";
            //DataTable dtg2 = ob.dttt(sss);
           
               
            GridView3.DataSource = dtg2;
            GridView3.DataBind();
            GridView3.Visible = true;
            Label3.Text = final1;
            Label4.Text = final2;
            
        }
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName=="VIEW")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;
            string st = Convert.ToString(lnkView.CommandArgument);
            DataTable dt = ob.dttt("select payble_amount from closing where username='" + st + "'");
            int p = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (p >= 500)
            {
                Session["payment"] = st;
                Response.Redirect("Cheque.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Amount for Cheque')</script>");
            }
        }
    }
   
    protected void GridView2_RowDataBound1(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.Cells[6].Text == "0")
            e.Row.Visible = false;
    }


   
    protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName=="VIEW")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;
            string st = Convert.ToString(lnkView.CommandArgument);
            Session["cheque2"] = st;
            
        
         Page.ClientScript.RegisterStartupScript(GetType(), "", "window.open('cheque2.aspx','','width=500,height=500');", true);
    }
    }
}