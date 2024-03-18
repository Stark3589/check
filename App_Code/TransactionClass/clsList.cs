using System;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Diagnostics;
using TripleITConnection;
using System.Configuration;

namespace TripleITTransaction
{
    public class clsList
    {
        clsConnection ObjConnection = new clsConnection();
        string Sql = "";

        public string ConnectionString()
        {
            try
            {
                return ObjConnection.ConnectString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable RetrunSqlDataList(string Sql)
        {
            return ObjConnection.ReturnDataTableSql(Sql);
        }



        public string AutoCode(string TableName, string FieldName)
        {
            string gCode = "1";
            Sql = "Select Max(" + FieldName + ") as GetCode From " + TableName + " Group By " + FieldName + " Order By " + FieldName + " Desc";
            DataTable RsCode = RetrunSqlDataList(Sql);
            if (RsCode.Rows.Count == 0)
            {
                gCode = "1";
            }
            else
            {
                gCode = (Convert.ToInt32(RsCode.Rows[0]["GetCode"]) + 1).ToString();
            }
            return gCode;
        }

        //for brand
        public DataTable ListBrand(Int32 Bid, string Search, string Transaction)
        {
            SqlParameter prmsid = new SqlParameter("@Bid", Bid);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);
            
            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("BrandList", prmsid, prmKeywords,  prmTransaction);
        
        
        }


        //for unit
        public DataTable ListUnit(Int32 Bid, string Search, string Transaction)
        {
            SqlParameter prmsid = new SqlParameter("@Uid", Bid);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);

            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("UnitList", prmsid, prmKeywords, prmTransaction);
       }

        //for Category
        public DataTable ListCategory(Int32 Cid, string Search, string Transaction)
        {
            SqlParameter prmsid = new SqlParameter("@Cid", Cid);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);

            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("CategoryList", prmsid, prmKeywords, prmTransaction);
       }
        //for SubCategory
        public DataTable ListSubCategory(Int32 id, string Search, string Transaction)
        {
            SqlParameter prmsid = new SqlParameter("@id", id);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);

            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("SubCategoryList", prmsid, prmKeywords, prmTransaction);
        }

        //for sider
        public DataTable Listslider(Int32 id, string Search, string Transaction)
        {
            SqlParameter prmsid = new SqlParameter("@id", id);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);

            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("sliderList", prmsid, prmKeywords, prmTransaction);
        }


        //for product
        public DataTable ListProduct(Int32 id, string Search, string Transaction)
        {
            SqlParameter prmsid = new SqlParameter("@id", id);
            //SqlParameter prmpname = new SqlParameter("@pname", pname);
            //SqlParameter prmdate = new SqlParameter("@date", date);
            //SqlParameter prmbrand = new SqlParameter("@brand", brand);
            //SqlParameter prmcategory = new SqlParameter("@category", category);
         
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);

            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("ProductList", prmsid, prmKeywords, prmTransaction);
        }
        public DataTable Listpurchasetrans(Int32 Pid, string Search, string Transaction)
        {
            SqlParameter prmsid = new SqlParameter("@Pid", Pid);
            //SqlParameter prmpname = new SqlParameter("@pname", pname);
            //SqlParameter prmdate = new SqlParameter("@date", date);
            //SqlParameter prmbrand = new SqlParameter("@brand", brand);
            //SqlParameter prmcategory = new SqlParameter("@category", category);

            SqlParameter prmKeywords = new SqlParameter("@Search", Search);

            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("producttransactionList", prmsid, prmKeywords, prmTransaction);
        }


        //for Tax
        public DataTable ListTax(Int32 Tid, string Search, string Transaction)
        {
            SqlParameter prmsid = new SqlParameter("@Tid", Tid);
          

            SqlParameter prmKeywords = new SqlParameter("@Search", Search);

            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("TaxList", prmsid, prmKeywords, prmTransaction);
        }
        // User
        public DataTable ListUser(Int32 Sid, string Search, DateTime fdate, DateTime todate, string Transaction)
        {

            SqlParameter prmsid = new SqlParameter("@Sid", Sid);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);
            SqlParameter prmfdate = new SqlParameter("@fromdate", fdate);
            SqlParameter prmtodate = new SqlParameter("@todate", todate);
            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("SignupList", prmsid, prmKeywords, prmfdate, prmtodate, prmTransaction);
        }
       
        
        // supplier
        public DataTable ListSupplier(Int32 id,string sid, string Search, string Transaction)
           
        {
            SqlParameter prmid = new SqlParameter("@id", id);
            SqlParameter prmsid = new SqlParameter("@Sid", sid);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);
       //     SqlParameter prmfdate = new SqlParameter("@date", date);
            //SqlParameter prmtodate = new SqlParameter("@todate", todate);
            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("ListSupplier", prmid, prmsid, prmKeywords,  prmTransaction);
        }

        // msc
        public DataTable LISTMSC(Int32 id, string mscid, string Search, string Transaction)
        {
            SqlParameter prmid = new SqlParameter("@id", id);
            SqlParameter prmsid = new SqlParameter("@MSCid", mscid);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);
            //     SqlParameter prmfdate = new SqlParameter("@date", date);
            //SqlParameter prmtodate = new SqlParameter("@todate", todate);
            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("LISTMSC", prmid, prmsid, prmKeywords, prmTransaction);
        }

        //Image LIst
        // User
        public DataTable ListImages(Int32 Mid, string Search, DateTime fdate, DateTime todate, string Transaction)
        {

            SqlParameter prmsid = new SqlParameter("@Mid", Mid);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);
            SqlParameter prmfdate = new SqlParameter("@fromdate", fdate);
            SqlParameter prmtodate = new SqlParameter("@todate", todate);
            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("imagesList", prmsid, prmKeywords, prmfdate, prmtodate, prmTransaction);
        }
        //Image LIst
        // User
        public DataTable ListDOC(Int32 Mid, string Search, DateTime fdate, DateTime todate, string Transaction)
        {

            SqlParameter prmsid = new SqlParameter("@Kid", Mid);
            SqlParameter prmKeywords = new SqlParameter("@Search", Search);
            SqlParameter prmfdate = new SqlParameter("@fromdate", fdate);
            SqlParameter prmtodate = new SqlParameter("@todate", todate);
            SqlParameter prmTransaction = new SqlParameter("@Transaction", Transaction);
            return ObjConnection.ReturnDataTable("KYCList", prmsid, prmKeywords, prmfdate, prmtodate, prmTransaction);
        }
    }
    }
