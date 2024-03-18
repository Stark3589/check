using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TripleITTransaction;
using TripleITConnection;
public partial class User_account : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    clsList objlist = new clsList();
    clsConnection objcon = new clsConnection();
    clsAccount objacc = new clsAccount();
    public List<clsaccount> objacclist = new List<clsaccount>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            //Session["newuser"] = "MDI0000001";
            //loadaccount(Session["newuser"].ToString());
           
        }
        
    }
    //for account
    public void loadaccount(string username)
    {
        try
        {
             string   sql = "select username,total,tds,admin,credit,debit,date,valu from dbo.account where username='" + username + "'";       
            DataTable dt = objcon.ReturnDataTableSql(sql);
            if (dt.Rows.Count > 0)
            {
                double debit = 0, credit = 0, tdebit = 0, tcredit = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        double cre = 0;
                        double deb = 0;
                        danger.Visible = false;
                        clsaccount objacc = new clsaccount();
                        objacc.username = dt.Rows[i]["username"].ToString();
                        objacc.total = dt.Rows[i]["total"].ToString();
                        objacc.tds = dt.Rows[i]["tds"].ToString();
                        objacc.admin = dt.Rows[i]["admin"].ToString();
                        cre = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                        objacc.debit = Math.Round(cre, 2).ToString();
                        deb = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                        objacc.credit = Math.Round(deb, 2).ToString();
                        objacc.date = Convert.ToDateTime(dt.Rows[i]["date"].ToString()).ToString("dd/MM/yyyy");
                        objacc.remark = dt.Rows[i]["valu"].ToString();
                        objacclist.Add(objacc);
                        debit = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                        credit = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                        tdebit += Math.Round(debit, 2);
                        tcredit += Math.Round(credit, 2);
                    }
                    catch (Exception ex) { }
                }
                Label1.Text = (tcredit - tdebit).ToString();
                lbcredit.Text = tcredit.ToString();
                lbdebit.Text = tdebit.ToString();

            }
            else
            {
                lbdanger.Text = "Opps! NO Data Found";
                danger.Visible = true;
            }
            Repeater1.DataSource = objacclist;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {

        }



    }



    protected void btnsearch_Click(object sender, EventArgs e)
    {
       
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        if (drptype.SelectedItem.Text == "ALL")
        {
            try
            {

                string sql = "select username,total,credit,debit,tds,admin,date,valu from dbo.account where username='" + Session["newuser"].ToString() + "' and date between '" + TextBox1.Text + "' and '" + TextBox2.Text + "' ";
                DataTable dt = objcon.ReturnDataTableSql(sql);
                if (dt.Rows.Count > 0)
                {
                    double debit = 0, credit = 0, tdebit = 0, tcredit = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        danger.Visible = false;
                        clsaccount objacc = new clsaccount();
                        objacc.username = dt.Rows[i]["username"].ToString();
                        objacc.total = dt.Rows[i]["total"].ToString();
                        objacc.tds = dt.Rows[i]["tds"].ToString();
                        objacc.admin = dt.Rows[i]["admin"].ToString();
                        objacc.credit = dt.Rows[i]["debit"].ToString();
                        objacc.debit = dt.Rows[i]["credit"].ToString();
                        objacc.date = Convert.ToDateTime(dt.Rows[i]["date"].ToString()).ToString("dd/MM/yyyy");
                        objacc.remark = dt.Rows[i]["valu"].ToString();
                        objacclist.Add(objacc);
                        debit = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                        credit = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                        tdebit += debit;
                        tcredit += credit;
                    }
                    Label1.Text = (tcredit - tdebit).ToString();
                    lbcredit.Text = tcredit.ToString();
                    lbdebit.Text = tdebit.ToString();

                }
                else
                {
                    lbdanger.Text = "Opps! NO Data Found";
                    danger.Visible = true;
                }
                Repeater1.DataSource = objacclist;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {

            }
        }
        else
        {
            try
            {

                string sql = "select username,total,credit,debit,date,tds,admin,valu from dbo.account where username='" + Session["newuser"].ToString() + "' and valu LIKE '" + drptype.SelectedItem.Text + " %' and date between '" + TextBox1.Text + "' and '" + TextBox2.Text + "'";
                DataTable dt = objcon.ReturnDataTableSql(sql);
                if (dt.Rows.Count > 0)
                {
                    double debit = 0, credit = 0, tdebit = 0, tcredit = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        danger.Visible = false;
                        clsaccount objacc = new clsaccount();
                        objacc.username = dt.Rows[i]["username"].ToString();
                        objacc.total = dt.Rows[i]["total"].ToString();
                        objacc.tds = dt.Rows[i]["tds"].ToString();
                        objacc.admin = dt.Rows[i]["admin"].ToString();
                        objacc.credit = dt.Rows[i]["debit"].ToString();
                        objacc.debit = dt.Rows[i]["credit"].ToString();
                        objacc.date = Convert.ToDateTime(dt.Rows[i]["date"].ToString()).ToString("dd/MM/yyyy");
                        objacc.remark = dt.Rows[i]["valu"].ToString();
                        objacclist.Add(objacc);
                        debit = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                        credit = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                        tdebit += debit;
                        tcredit += credit;
                    }
                    Label1.Text = (tcredit - tdebit).ToString();
                    lbcredit.Text = tcredit.ToString();
                    lbdebit.Text = tdebit.ToString();

                }
                else
                {
                    lbdanger.Text = "Opps! NO Data Found";
                    danger.Visible = true;
                }
                Repeater1.DataSource = objacclist;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {

            }
        }
    }
}