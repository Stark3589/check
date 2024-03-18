using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.IO;
public partial class User_transferamount : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = ob.dttt("select * from closingdate ");
            gvrclo.DataSource = dt;
            gvrclo.DataBind();
        }
    }
   protected void Button2_Click(object sender, EventArgs e)
    {
        
        foreach (GridViewRow gvrow in GridView1.Rows)
        {
            CheckBox cb = gvrow.FindControl("CheckBox1") as CheckBox;
            if (cb.Checked)
            {
                SqlDataReader dr = ob.drrr("select * from tdstable where date2 between '" + ViewState["datefrom"].ToString() + "' and '" + ViewState["dateto"].ToString() + "' and username='" + gvrow.Cells[1].Text + "'");
                if (dr.Read())
                {
                    ob.CloseConn();
                    Response.Write("<script>alert('Amount Already Transferd')</script>");
                }
                else
                {
                    ob.CloseConn();
                    double per = 0;
                    string username = gvrow.Cells[1].Text;
                    double direct = Convert.ToDouble(gvrow.Cells[4].Text);
                    double sponser = Convert.ToDouble(gvrow.Cells[5].Text);
                    string mobile = gvrow.Cells[3].Text;
                    string name = gvrow.Cells[2].Text;
                    try
                    {
                        string reg = "select pan from register where username='" + username + "'";
                        DataTable pan = ob.dttt(reg);
                        if (pan.Rows.Count > 0)
                        {
                            per = 5;
                        }
                        else
                        {
                            per = 20;
                        }
                    }
                    catch (Exception k) { per = 20; };
                    double fg = Convert.ToDouble(gvrow.Cells[6].Text);
                    double tds = (fg * per) / 100;
                    double adm = (fg * 5) / 100;
                    double totalpay = fg - tds - adm;
                    ob.Execute("insert into tdstable (username,nextclub,sponser,tds,payable,date1,date2,adm,total,paid) values('" + username + "','" + direct + "','"+sponser+"','" + tds + "','" + totalpay + "','" + ViewState["datefrom"].ToString() + "','" + ViewState["dateto"].ToString() + "','" + adm + "','" + totalpay + "','" + totalpay + "')");
                    DataTable d1 = ob.dttt("select sum(cast(credit as real)),sum(cast(debit as real)) from account where username='" + username + "'");
                    double ds = (Convert.ToDouble(d1.Rows[0][0]) - Convert.ToDouble(d1.Rows[0][1])) - Convert.ToDouble(tds);
                    ob.Execute("insert into account(username,debit,total,date,valu) values('" + username + "','" + tds.ToString() + "','" + ds.ToString() + "','" + ViewState["dateto"].ToString() + "','TDS Charge')");

                    DataTable d2 = ob.dttt("select sum(cast(credit as real)),sum(cast(debit as real)) from account where username='" + username + "'");
                    double ds1 = (Convert.ToDouble(d2.Rows[0][0]) - Convert.ToDouble(d2.Rows[0][1])) - Convert.ToDouble(adm);
                    ob.Execute("insert into account(username,debit,total,date,valu) values('" + username + "','" + adm.ToString() + "','" + ds1.ToString() + "','" + ViewState["dateto"].ToString() + "','Admin Charge')");

                    DataTable d3 = ob.dttt("select sum(cast(credit as real)),sum(cast(debit as real)) from account where username='" + username + "'");
                    double ds2 = (Convert.ToDouble(d3.Rows[0][0]) - Convert.ToDouble(d3.Rows[0][1])) - Convert.ToDouble(totalpay);
                    ob.Execute("insert into account(username,debit,total,date,valu) values('" + username + "','" + totalpay.ToString() + "','" + ds2.ToString() + "','" + ViewState["dateto"].ToString() + "','Final Amount Transfered')");

                    try
                    {
                        WebClient client = new WebClient();
                        string to, msg;
                        to = mobile;
                        string a1 = "Dear ";
                        string re = name;
                        string rp = ", Welcome to the Business Opportunity of INDIA. Your Income Has Been Trannsfered ";
                        string a2 = "Your Total Income Amount :- ";
                        string a3 = fg + " And TDS Amount:- "+tds+" And Admin Charge Amount:- "+adm+" ";
                        string a4 = " Your Final Income Amount Is:- ";
                        string a5 = totalpay.ToString();
                        string aaa = "";
                        string a6 = "";
                        string a7 = " Or  Follow the Link :- www.mahibio.com";
                        string a8 = " Thanks.";
                        msg = a1 + re + rp + a2 + a3 + a4 + a5 + aaa + a6 + a7 + a8;
                        double messto = Convert.ToDouble(to);
                        //string baseurl = "http://sms.dynamicitsolution.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=30f892d839aa595a669e729f16cd9a4a&message='" + msg + "'&senderId=DYNMIC&routeId=1&mobileNos=" + messto + "&smsContentType=english";
                      //  string baseurl = "http://sms.dynamicitsolution.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=8c7835eacdccb73c5c83edef2c19f94&message=" + msg + "&senderId=MGCTHR&routeId=1&mobileNos=" + messto + "&smsContentType=english";
                        string baseurl = "http://sms.dynamicitsolution.com/rest/services/sendSMS/sendGroups?AUTH_KEY=bc2b1da9f5b34dbf4ecb38edc490514a&message=" + msg + "&senderId=MAHIBIO&routeId=1&mobileNos=" + messto + "&smsContentType=english";
                        client.OpenRead(baseurl);

                    }
                    catch (Exception) { }
                            
                }

            }
        }
        Response.Write("<script>alert('Amount Transferd')</script>");
    }
   
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
        if (e.CommandName == "hello")
        {
            LinkButton lnkView = (LinkButton)e.CommandSource;
            string st = Convert.ToString(lnkView.CommandArgument);

            DataTable dt = ob.dttt("select datefrom,dateto from closingdate where id='" + st + "'");
            //string date1 = dt.Rows[0][0].ToString();
            //string date2 = dt.Rows[0][1].ToString();
            DateTime date1 = DateTime.Parse(dt.Rows[0][0].ToString());
            DateTime date2 = DateTime.Parse(dt.Rows[0][1].ToString());

            ViewState["datefrom"] = date1.ToString("yyyy-MM-dd");
            ViewState["dateto"] = date2.ToString("yyyy-MM-dd");


            string str = "select a.username As Username,b.name As Name,b.mobile As Mobile_No,sum(cast(directincome as real)) as direct_income,sum(cast(lvlincome as real)) as Sponser_income,sum(cast(total as real)) As Total,c.accno as Account_No,c.bankname as Bank,c.ifsc as IFSC_Code,c.branchname as Branch_Name from dailyrecordsmartjyoti a,register b, bankdetail c where a.username=b.username and a.username=c.username and date = '" + date1.ToString("yyyy-MM-dd") + "' and  date1='" + date2.ToString("yyyy-MM-dd") + "' and  Total>=300 group by a.username,b.name,b.mobile,c.accno ,c.bankname ,c.ifsc ,c.branchname";
                DataTable dtg = ob.dttt(str);
                if (dtg.Rows.Count > 0)
                {
                    GridView1.DataSource = dtg;
                    GridView1.DataBind();
                    print.Visible = true;
                    Button2.Visible = true;
                }
                else
                {
                    print.Visible = false;
                    Button2.Visible = false;
                }

        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
    }
    public void printreport()
    {
        try
        {

            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=PayOutReport.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);

                //To Export all pages
                GridView1.AllowPaging = false;
                // this.BindGrid();

                GridView1.HeaderRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell cell in GridView1.HeaderRow.Cells)
                {
                    cell.BackColor = GridView1.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in GridView1.Rows)
                {
                    row.BackColor = System.Drawing.Color.White; ;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = GridView1.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = GridView1.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                GridView1.RenderControl(hw);

                //style to format numbers to string
                string style = @"<style> .textmode { } </style>";
                Response.Write(style);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }
        catch (Exception k) { Response.Write("<script>alert('NO RECORD FOUND TO PRINT')</script>"); };
    }
    protected void print_Click(object sender, EventArgs e)
    {
        printreport();
    }
}