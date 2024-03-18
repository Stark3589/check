using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using TripleITConnection;
/// <summary>
/// Summary description for clsstock
/// </summary>
public class clsstock
{
    clsConnection objcon = new clsConnection();
    public clsstock()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string checkstock(string id)
    {
        string stock="";
        try {

            string sql = "select sum(cast(Credit  as real))-sum(cast(Debit as real)) as stock from tblsellstock where Productid='" + id + "'";
            DataTable dt = objcon.ReturnDataTableSql(sql);
            if (dt.Rows.Count > 0)
            {
               
                stock = dt.Rows[0]["stock"].ToString();
                if (stock == "")
                {
                    stock = "0";

                }
            }
            else
            {
                stock ="0";
            }
        }
        catch (Exception ex)
        {


        }
        return stock;
    }
    public string checkMSCstock(string id,string MSC)
    {
        string stock = "";
        try
        {

            string sql = "select sum(cast(Credit  as real))-sum(cast(Debit as real)) as stock from TblMSCStock where Productid='" + id + "' and MSC='"+ MSC + "'";

            DataTable dt = objcon.ReturnDataTableSql(sql);
            if (dt.Rows.Count > 0)
            {

                stock = dt.Rows[0]["stock"].ToString();
                if (stock == "")
                {
                    stock = "0";

                }
            }
            else
            {
                stock = "0";
            }
        }
        catch (Exception ex)
        {


        }
        return stock;
    }


    public string ratechart(string id,string type)
    {
        string price = "";
        try
        {

            string sql = "select  sellprice,govprice from tblsetprice where sr='" + id + "'";
            DataTable dt = objcon.ReturnDataTableSql(sql);
            if (dt.Rows.Count > 0)
            {

             string sellprice = dt.Rows[0]["sellprice"].ToString();
             string govprice = dt.Rows[0]["govprice"].ToString();
                if (type == "gov")
                {
                    price = govprice;

                }
                else
                {
                    price = sellprice;
                }
            }
            
        }
        catch (Exception ex)
        {


        }
        return price;
    }

    public Tuple<double, double, double,double> CenterWiseQty(string pid, string center)
    {
        
        double unit=0,final=0,balance=0,qty=0,rate=0;
       
        try
        {
            string[] ss = pid.Split('-');
            string id = ss[1].ToString();

            string sql = "select  qty,sellprice,govprice from tblsetprice where sr='" + id + "'";
            DataTable dt = objcon.ReturnDataTableSql(sql);
            if (dt.Rows.Count > 0)
            {
                 unit = Convert.ToDouble(dt.Rows[0]["qty"].ToString());
                rate = Convert.ToDouble(dt.Rows[0]["govprice"].ToString());
                qty = sellcenter(center, pid);
                balance = (rate/unit);
                final = (qty * balance);  
                  

               
            }

        }
        catch (Exception ex)
        {


        }
        return new Tuple<double, double, double, double>(unit, rate, balance, final);
    }

    public double sellcenter(string center,string product)
    {
        double wqty = 0, cqty = 0, wwqty = 0, wcqty = 0, sqty = 0;
        try
        {

           
            string str = "select women,child from tblgoverment where center=N'" + center + "'";
            DataTable dt = objcon.ReturnDataTableSql(str);
            if (dt.Rows.Count > 0)
            {
                wqty = Convert.ToDouble(dt.Rows[0]["women"].ToString());
                cqty = Convert.ToDouble(dt.Rows[0]["child"].ToString());

                string sql = "select women,men from menu where productid='" + product + "'";
                DataTable dt1 = objcon.ReturnDataTableSql(sql);
                if (dt1.Rows.Count > 0)
                {
                    wwqty = (Convert.ToDouble(dt1.Rows[0]["women"].ToString()) * wqty);
                    wcqty = (Convert.ToDouble(dt1.Rows[0]["men"].ToString()) * cqty);
                    sqty = wwqty + wcqty;
                }
            }

        }
        catch (Exception ex)
        { }
        return sqty;

    }
    public bool checkproductid(string id)
    {
        bool check1= false;
        try
        {

            string sql = "select * from tblproduct where Pid='" + id + "'";
            DataTable dt = objcon.ReturnDataTableSql(sql);
            if (dt.Rows.Count > 0)
            {

                check1 = true;
            }
            else
            {
                check1 = false;
            }
        }
        catch (Exception ex)
        {


        }
        return check1;
    }

    public bool checkMSCproductid(string id,string msc)
    {
        bool check1 = false;
        try
        {

            string sql = "select * from TblMSCStock where Productid='" + id + "' and MSC='"+msc+"'";
            DataTable dt = objcon.ReturnDataTableSql(sql);
            if (dt.Rows.Count > 0)
            {

                check1 = true;
            }
            else
            {
                check1 = false;
            }
        }
        catch (Exception ex)
        {


        }
        return check1;
    }

    public string checkrowstock(string brand,string cat,string product,string weight,string unit)
    {
        string stock = "";
        try
        {

            string sql = "select  sum(cast(Credit  as real))-sum(cast(Debit as real)) as stock from  [dbo].[tblpurchasetransaction] where brand=N'"+brand+"' and category=N'"+cat+"' and product=N'"+product+"' and weight='"+weight+"' and unit='"+unit+"'";
            DataTable dt = objcon.ReturnDataTableSql(sql);
            if (dt.Rows.Count > 0)
            {

                stock = dt.Rows[0]["stock"].ToString();
                if (stock == "")
                {
                    stock = "0";

                }
            }
            else
            {
                stock = "0";
            }
        }
        catch (Exception ex)
        {


        }
        return stock;
    }


}