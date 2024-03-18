using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TripleITConnection;
using TripleITTransaction;

public partial class newuser_FundReport : System.Web.UI.Page
{
    clsList objlist = new clsList();
    clsConnection objcon = new clsConnection();
    clsAccount objacc = new clsAccount();
    public List<clsaccount12> objacclist = new List<clsaccount12>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {


                txtsearch.Text = Session["newuser"].ToString();
                show();
            }catch(Exception hg){};
        }
    }

    void show()
    {
        try
        {

            string sql = "select *,(select name from register where username=fundaccount.username )name from dbo.fundaccount where username='" + txtsearch.Text + "' ";
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

                        clsaccount12 objacc = new clsaccount12();
                        objacc.username = dt.Rows[i]["username"].ToString();
                        objacc.name = dt.Rows[i]["name"].ToString();
                        cre = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                        objacc.debit = Math.Round(cre, 2).ToString();
                        deb = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                        objacc.credit = Math.Round(deb, 2).ToString();
                        objacc.date = Convert.ToDateTime(dt.Rows[i]["date"].ToString()).ToString("dd/MM/yyyy");
                        objacc.remark = dt.Rows[i]["status"].ToString();
                        objacc.U_id = dt.Rows[i]["U_id"].ToString();
                        objacclist.Add(objacc);
                        debit = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                        credit = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                        tdebit += Math.Round(debit, 2);
                        tcredit += Math.Round(credit, 2);
                    }
                    catch (Exception ex)
                    { }
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
        if (DropDownList1.SelectedItem.Text == "ALL")
        {
            try
            {

                string sql = "select *,(select name from register where username=fundaccount.username )name from dbo.fundaccount where username='" + txtsearch.Text + "' and date between '" + TextBox1.Text + "' and '" + TextBox2.Text + "' ";
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

                            clsaccount12 objacc = new clsaccount12();
                            objacc.username = dt.Rows[i]["username"].ToString();
                            objacc.name = dt.Rows[i]["name"].ToString();
                            cre = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                            objacc.debit = Math.Round(cre, 2).ToString();
                            deb = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                            objacc.credit = Math.Round(deb, 2).ToString();
                            objacc.date = Convert.ToDateTime(dt.Rows[i]["date"].ToString()).ToString("dd/MM/yyyy");
                            objacc.remark = dt.Rows[i]["status"].ToString();
                            objacc.U_id = dt.Rows[i]["U_id"].ToString();
                            objacclist.Add(objacc);
                            debit = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                            credit = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                            tdebit += Math.Round(debit, 2);
                            tcredit += Math.Round(credit, 2);
                        }
                        catch (Exception ex)
                        { }
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

                string sql = "select *,(select name from register where username=fundaccount.username )name from dbo.fundaccount where username='" + txtsearch.Text + "' and date between '" + TextBox1.Text + "' and '" + TextBox2.Text + "' and status like '"+DropDownList1.SelectedItem.Value+" %'";
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
                          
                            clsaccount12 objacc = new clsaccount12();
                            objacc.username = dt.Rows[i]["username"].ToString();
                            objacc.name = dt.Rows[i]["name"].ToString();
                            cre = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                            objacc.debit = Math.Round(cre, 2).ToString();
                            deb = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                            objacc.credit = Math.Round(deb, 2).ToString();
                            objacc.date = Convert.ToDateTime(dt.Rows[i]["date"].ToString()).ToString("dd/MM/yyyy");
                            objacc.remark = dt.Rows[i]["status"].ToString();
                            objacc.U_id = dt.Rows[i]["U_id"].ToString();
                            objacclist.Add(objacc);
                            debit = Convert.ToDouble(dt.Rows[i]["debit"].ToString());
                            credit = Convert.ToDouble(dt.Rows[i]["credit"].ToString());
                            tdebit += Math.Round(debit, 2);
                            tcredit += Math.Round(credit, 2);
                        }
                        catch (Exception ex)
                        { }
                    }
                    Label1.Text = (tcredit - tdebit).ToString();
                    lbcredit.Text = tcredit.ToString();
                    lbdebit.Text = tdebit.ToString();

                }
                else
                {
                   
                    Label1.Text = "";
                    lbcredit.Text = "";
                    lbdebit.Text = "";
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


public class clsaccount12
{
    public string username { get; set; }
    public string name { get; set; }
    public string date { get; set; }
    public string debit { get; set; }
    public string credit { get; set; }
    public int tdebit { get; set; }
    public int tcredit { get; set; }
    public string remark { get; set; }
    public string U_id { get; set; }
}