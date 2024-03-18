using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using TripleITConnection;
using System.Data.SqlClient;
using TripleITTransaction;
/// <summary>
/// Summary description for clsfunction
/// </summary>
public class clsfunction
{ clsConnection objcon = new clsConnection();
    clsTimeZone objtime = new clsTimeZone();
    clsAMD objamd = new clsAMD();
    public clsfunction()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    //FIND TOTAL CREDIT
    public string totalcredit(string username)
    {
        string amount = "";
        try
        {
            string query = "select sum(cast(credit as real)) as credit from passbook1 where username='" + username + "'";
            DataTable dt = objcon.ReturnDataTableSql(query);
            if (dt.Rows.Count > 0)
            {

                string credit = dt.Rows[0]["credit"].ToString();
                if (credit != "")
                {

                    double creditno = Convert.ToDouble(credit);
                    amount = creditno.ToString();

                }

                else
                { amount = "0"; }
            }
            else
            { amount = "0"; }
        }
        catch (Exception ex)
        {

        }
        return amount;

    }
    //FIND TOTAL INCOME INCOMETYPEWISE
    public string totalincometype(string username, string type)
    {
        string amount = "";
        try
        {
            string query = "select sum(cast(credit as real)) as credit from dbo.account where username='" + username + "' and valu='" + type + "'";
            DataTable dt = objcon.ReturnDataTableSql(query);
            if (dt.Rows.Count > 0)
            {

                string credit = dt.Rows[0]["credit"].ToString();
                if (credit != "")
                {

                    double creditno = Convert.ToDouble(credit);
                    amount = creditno.ToString();

                }

                else
                { amount = "0"; }
            }
            else
            { amount = "0"; }
        }
        catch (Exception ex)
        {

        }
        return amount;

    }
    //FIND TOTAL DEBIT
    public string totaldebit(string username)
    {
        string amount = "0";
        try
        {
            string query = "select sum(cast(debit as real)) as debit  from passbook1 where username='" + username + "'";
            DataTable dt = objcon.ReturnDataTableSql(query);
            if (dt.Rows.Count > 0)
            {
                string debit = dt.Rows[0]["debit"].ToString();

                if (debit != "")
                {
                    double debitno = Convert.ToDouble(debit);

                    amount = debitno.ToString();

                }

                else
                { amount = "0"; }
            }
            else
            { amount = "0"; }
        }
        catch (Exception ex)
        {

        }
        return amount;

    }
    //user wallet
    public string ewallet(string username)
    {
        string amount = "";
        try {
            string query = "select sum(cast(debit as real)) as debit ,sum(cast(credit as real)) as credit from dbo.account where username='" + username + "'";
            DataTable dt = objcon.ReturnDataTableSql(query);
            if (dt.Rows.Count > 0)
            {
                string debit = dt.Rows[0]["debit"].ToString();
                string credit = dt.Rows[0]["credit"].ToString();
                if (debit != "" && credit != "")
                {
                    double debitno = Convert.ToDouble(debit);
                    double creditno = Convert.ToDouble(credit);
                    amount = (creditno - debitno).ToString();

                }
                else if (debit == "" && credit != "")
                {
                    double debitno = 0;
                    double creditno = Convert.ToDouble(credit);
                    amount = (creditno - debitno).ToString();

                }
                else if (debit != "" && credit == "")
                {
                    double debitno = Convert.ToDouble(debit);
                    double creditno =0;
                    amount = (creditno - debitno).ToString();
                }
                else 
                
                { amount = "0"; }
                //if (Convert.ToDouble(amount) < 0)
                    
                //{
                //    amount = "0";
                //}
            }
            else
            { amount = "0"; }
        }
        catch (Exception ex)
        {

        }
        return amount;

    }
    public string epassbookwallet(string username)
    {
        string amount = "";
        try
        {
            string query = "select sum(cast(debit as real)) as debit ,sum(cast(credit as real)) as credit from tblcarry where username='" + username + "'";
            DataTable dt = objcon.ReturnDataTableSql(query);
            if (dt.Rows.Count > 0)
            {
                string debit = dt.Rows[0]["debit"].ToString();
                string credit = dt.Rows[0]["credit"].ToString();
                if (debit != "" && credit != "")
                {
                    double debitno = Convert.ToDouble(debit);
                    double creditno = Convert.ToDouble(credit);
                    amount = (creditno - debitno).ToString();

                }
                else if (debit == "" && credit != "")
                {
                    double debitno = 0;
                    double creditno = Convert.ToDouble(credit);
                    amount = (creditno - debitno).ToString();

                }
                else if (debit != "" && credit == "")
                {
                    double debitno = Convert.ToDouble(debit);
                    double creditno = 0;
                    amount = (creditno - debitno).ToString();
                }
                else
                { amount = "0"; }
            }
            else
            { amount = "0"; }
        }
        catch (Exception ex)
        {

        }
        return amount;

    }
    public string epassbookwallet12(string username, string fdate, string tdate)
    {
        string amount = "";
        try
        {
            string query = "select sum(cast(debit as real)) as debit ,sum(cast(credit as real)) as credit from account where username='" + username + "' and  date between '" + fdate + "' and '" + tdate + "'";
            DataTable dt = objcon.ReturnDataTableSql(query);
            if (dt.Rows.Count > 0)
            {
                string debit = dt.Rows[0]["debit"].ToString();
                string credit = dt.Rows[0]["credit"].ToString();
                if (debit != "" && credit != "")
                {
                    double debitno = Convert.ToDouble(debit);
                    double creditno = Convert.ToDouble(credit);
                    amount = (creditno - debitno).ToString();

                }
                else if (debit == "" && credit != "")
                {
                    double debitno = 0;
                    double creditno = Convert.ToDouble(credit);
                    amount = (creditno - debitno).ToString();

                }
                else if (debit != "" && credit == "")
                {
                    double debitno = Convert.ToDouble(debit);
                    double creditno = 0;
                    amount = (creditno - debitno).ToString();
                }
                else
                { amount = "0"; }
            }
            else
            { amount = "0"; }
        }
        catch (Exception ex)
        {

        }
        return amount;

    }
    //for name
    public string name(string username)
    {
        string amount = "";
        try
        {
            string query = "select name from register where username='" + username + "'";
            DataTable dt = objcon.ReturnDataTableSql(query);
            if (dt.Rows.Count > 0)
            {
                amount = dt.Rows[0]["name"].ToString();
                
            }
            else
            {
                amount = "XXXXXX"; 
            }
        }
        catch (Exception ex)
        {

        }
        return amount;

    }
    public string status(string username)
    {
        string amount = "";
        try
        {
            string query = "select status from register where username='" + username + "'";
            DataTable dt = objcon.ReturnDataTableSql(query);
            if (dt.Rows.Count > 0)
            {
                amount = dt.Rows[0]["status"].ToString();

            }
            else
            {
                amount = "InActive";
            }
        }
        catch (Exception ex)
        {

        }
        return amount;

    }
    public string downlineid(string username)
    {
        string amount = "";
        try
        {
            if (username == "0")
            {
                amount = "0";
            }
            else
            {
                string query = "select count(a.username) as total from register a,downline b where a.username=b.downlineid and a.status='Active' and b.username='" + username + "'";
                DataTable dt = objcon.ReturnDataTableSql(query);
                if (dt.Rows.Count > 0)
                {
                    string total = dt.Rows[0]["total"].ToString();
                    if (total == "0" && total == null)
                    {
                        amount = "1";
                    }
                    else
                    {
                        string sql = "select status from register where username='" + username + "'";
                        DataTable dty = objcon.ReturnDataTableSql(sql);
                        if (dty.Rows.Count > 0)
                        {
                            string statuss = dty.Rows[0]["status"].ToString();
                            if (statuss == "Active")
                            {

                                double amount1 = Convert.ToDouble(total) + 1;
                                amount = amount1.ToString();
                            }
                            else
                            {
                                double amount1 = Convert.ToDouble(total);
                                amount = amount1.ToString();
                            }

                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {

        }
        return amount;

    }
    //FOR FINAL  COMPANY BUSNISS  AFTER USER JOIN
    public int clubeincome(string username)
    {
        int clubeamount =0;
        try
        {
            int clubeincome = 0;
            int totaluser = 0;
            //string query = "select max(leftcount) as countuser  FROM total_binarycount ";//where username='" + username + "'";
            string query ="select count(username) from register where reffid='"+username+"'";
            //string query = "select sum(cast(leftcount as real)) as countuser  FROM total_binarycount ";//where username='" + username + "'";
            DataTable dt = objcon.ReturnDataTableSql(query);
            if (dt.Rows.Count > 0)
            {
                string countuser = dt.Rows[0]["countuser"].ToString();
                if (countuser != "")
                {
                    totaluser = Convert.ToInt32(countuser);
                    int limit = loaduserobver(username);
                    clubeincome = (totaluser - limit);
                    clubeamount = (clubeincome * 2000);
                }

            }
            else
            {
                int limit = loaduserobver(username);
                clubeincome = (limit);
                clubeamount = (clubeincome * 2000);
            }
          
            }
        catch (Exception ex)
        {

        }
        return clubeamount;

    }
    //FOR COMPANY BUSNISS BEFORE USER JOIN
    public int loaduserobver(string username)
    {
        int limit = 0,income;
        try
        {
            string query1 = "SELECT companylimit FROM total_binarycount  where username='" + username+"'";
            DataTable dtd = objcon.ReturnDataTableSql(query1);
            int id = Convert.ToInt32(dtd.Rows[0]["companylimit"].ToString());
          //  string query2 = "select count(username) from register where status='Active' and id>"+id+"";
           string query2 = "SELECT count(username) as total FROM total_binarycount where leftcount!='0'";// where username='" + username + "'";
            DataTable dt = objcon.ReturnDataTableSql(query2);
            if (dt.Rows.Count > 0)
            {
                string countuser = dt.Rows[0]["total"].ToString();
                if (countuser != "")
                {
                    limit = Convert.ToInt32(countuser)-id;

                }


            }
        }
        catch (Exception ex)
        {


        }
        income = limit * 2000;
        return income;
    }
    public int checkDirect(string username)
    {

        int totalspn = 0;
        try
        {


            string query1 = "select count(username) as total from sponser where sponser='" + username + "'";
            DataTable dt = objcon.ReturnDataTableSql(query1);
            if (dt.Rows.Count > 0)
            {
                string countuser = dt.Rows[0]["total"].ToString();
                if (countuser != "")
                {
                    totalspn = Convert.ToInt32(countuser);

                }


            }

        }
        catch (Exception ex)
        {


        }
        return totalspn;
    }
    // check clube income
    public int selfincome(string username)
    {
        int income = 0, limit = 0;
        try
        {

            int a = objcon.ExecuteSqlQuery("delete from new");
            int a1 = objcon.ExecuteSqlQuery("insert into new(username) values('" + username + "')");
            for (int i = 0; i > -1; i++)
            {
                    DataTable dt212 = objcon.ReturnDataTableSql("select username from new");
                
                    try
                    {
                   
                    string sponser = dt212.Rows[i]["username"].ToString();
                    //maintaining team income  
                    string sql = "insert into new(username,doj) select username,dateofjoining from register where status='Active' and reffid='" + sponser+ "'";
                    objcon.ExecuteSqlQuery(sql);
                }
                    catch (Exception) { i = -2; };
                  
                   
             }
               
          
            
            int a3 = objcon.ExecuteSqlQuery("delete from new where username='" + username + "'");
       
        //find limit
          DataTable dt = objcon.ReturnDataTableSql("select count(username) as total from new  ");
            if (dt.Rows.Count > 0)
            {
                string countuser = dt.Rows[0]["total"].ToString();
                if (countuser != "")
                {
                    limit = Convert.ToInt32(countuser);

                }


            }
        }
        catch (Exception ex)
        {


        }
        income = limit * 2000;
        return income;

    }
   //direct income

}