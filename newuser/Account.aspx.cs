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
    clsList objlist = new clsList();
    clsConnection objcon = new clsConnection();
    clsAccount objacc = new clsAccount();
    public List<clsaccount> objacclist = new List<clsaccount>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                string str = Session["newuser"].ToString();
                if (Session["newuser"].ToString() != null)
                {

                    loadaccount(Session["newuser"].ToString());
                }
                else
                { Response.Redirect("home.aspx"); }
            }
            catch { };
        }
        
    }
    //for account
    public void loadaccount(string username)
    {
        try
        {
            string sql = "select username,credit,debit,date,valu,(select name from register where username=a.username) name from dbo.account a where username='" + username + "'";       
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
                      
                        clsaccount objacc = new clsaccount();
                      
                        cre = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                        objacc.debit = cre.ToString();
                        deb = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                        objacc.credit = deb.ToString();
                        objacc.date = Convert.ToDateTime(dt.Rows[i]["date"].ToString()).ToString("dd/MM/yyyy");
                        objacc.remark = dt.Rows[i]["valu"].ToString();
                        objacclist.Add(objacc);
                        debit = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                        credit = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                        tdebit += debit;
                        tcredit += credit;
                    }
                    catch (Exception ex) { }
                }
                Label1.Text = (tcredit - tdebit).ToString();
                lbcredit.Text = tcredit.ToString();
                lbdebit.Text = tdebit.ToString();

            }
            else
            {
               
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
        if (DropDownList1.SelectedItem.Text == "ALL")
        {
            try
            {

                string sql = "select username,credit,debit,date,valu,(select name from register where username=a.username) name from dbo.account where username='" + Session["newuser"].ToString() + "' and date between '" + TextBox1.Text + "' and '" + TextBox2.Text + "' ";
                DataTable dt = objcon.ReturnDataTableSql(sql);
                if (dt.Rows.Count > 0)
                {
                    double debit = 0, credit = 0, tdebit = 0, tcredit = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                      
                        clsaccount objacc = new clsaccount();
                       
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
            if (DropDownList1.SelectedItem.Text == "BOOSTER LEVEL BONUS")
           {
               try
               {

                   string sql = "select username,credit,debit,date,valu,(select name from register where username=a.username) name from dbo.account where username='" + Session["newuser"].ToString() + "' and valu like 'BOOSTER LEVEL BONUS %' and date between '" + TextBox1.Text + "' and '" + TextBox2.Text + "'";
                   DataTable dt = objcon.ReturnDataTableSql(sql);
                   if (dt.Rows.Count > 0)
                   {
                       double debit = 0, credit = 0, tdebit = 0, tcredit = 0;
                       for (int i = 0; i < dt.Rows.Count; i++)
                       {

                           clsaccount objacc = new clsaccount();

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

                   string sql = "select username,credit,debit,date,valu,(select name from register where username=a.username) name from dbo.account where username='" + Session["newuser"].ToString() + "' and valu='" + DropDownList1.SelectedItem.Text + "' and date between '" + TextBox1.Text + "' and '" + TextBox2.Text + "'";
                   DataTable dt = objcon.ReturnDataTableSql(sql);
                   if (dt.Rows.Count > 0)
                   {
                       double debit = 0, credit = 0, tdebit = 0, tcredit = 0;
                       for (int i = 0; i < dt.Rows.Count; i++)
                       {

                           clsaccount objacc = new clsaccount();

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
}

public class clsaccount
{
  
    public string date { get; set; }
    public string debit { get; set; }
    public string credit { get; set; }
    public int tdebit { get; set; }
    public int tcredit { get; set; }
    public string remark { get; set; }
}