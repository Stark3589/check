using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;
using System.IO;
using TripleITConnection;
using System.Globalization;
//Lalit Kumar Verma 16-02-09

namespace TripleITTransaction
{
    public class clsAMD
    {
        clsConnection ObjConnection = new clsConnection();
        clsValidation ObjValid = new clsValidation();

        public int AMDSql(string Sql)
        {
            try
            {
                int status;
                status = ObjConnection.ExecuteSqlQuery(Sql);
                return status;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetRecord(string Sql)
        {
            return ObjConnection.ReturnDataTableSql(Sql);
        }

        public void AMD(string Sql)
        {
            try
            {
                ObjConnection.ExecuteSqlQuery(Sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public int AMDPageContent(int PageCode, string PageData, string Images, string SeoTitle,
                                   string seoKeyword, string SeoDescription)
        {
            try
            {
                int status;
                SqlParameter prmPageCode = new SqlParameter("@PageCode", PageCode);
                SqlParameter prmPageData = new SqlParameter("@PageData", PageData);
                SqlParameter prmImage = new SqlParameter("@Image", Images);
                SqlParameter prmSeoTitle = new SqlParameter("@SeoTitle", SeoTitle);
                SqlParameter prmSeoKeyword = new SqlParameter("@SeoKeyword", seoKeyword);
                SqlParameter prmSeoDescription = new SqlParameter("@SeoDescription", SeoDescription);
                status = ObjConnection.ExecuteProcedure("PageContent", prmPageCode, prmPageData, prmImage, prmSeoTitle, prmSeoKeyword, prmSeoDescription);
                return status;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // SART FUNCTION FOR ADD NEW MEMBER ,[Name]
        public int signup(int id,string username, string password, string name,
            string mobile, string email, string status, DateTime date, string Transaction)
        {

            SqlParameter ptrid = new SqlParameter("id", id);
            SqlParameter ptrusername = new SqlParameter("username", username);
            SqlParameter ptrpassword = new SqlParameter("password", password);
            SqlParameter ptrname = new SqlParameter("name", name);
            SqlParameter ptrmobile = new SqlParameter("mobile", mobile);
            SqlParameter ptremail = new SqlParameter("email", email);
            SqlParameter ptrstatus = new SqlParameter("Status", status);
            SqlParameter ptrdate = new SqlParameter("date", date);
            SqlParameter ptrTransaction = new SqlParameter("Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("signup", ptrid, ptrusername,ptrpassword, ptrname,ptrmobile , ptremail, ptrdate, ptrstatus, ptrTransaction);

            return a;

        }

        // SART FUNCTION FOR ADD NEW IMAGE 
        public int imgupload(int mid, string UserName, string imagename, string url, string Status,
            DateTime DOU,string Transaction)
        {

            SqlParameter ptrmid = new SqlParameter("mid", mid);
            SqlParameter ptrusername = new SqlParameter("userName", UserName);
            SqlParameter ptrimagename = new SqlParameter("imagename", imagename);
            SqlParameter ptrurl = new SqlParameter("url", url);
            SqlParameter ptrStatus = new SqlParameter("status", Status);
            SqlParameter ptrDOU = new SqlParameter("DOU", DOU);
            SqlParameter ptrTransaction = new SqlParameter("Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("image", ptrmid, ptrusername, ptrimagename, ptrurl, ptrStatus, ptrDOU, ptrTransaction);

            return a;

        }
        public int Downine(string username)
        {

            SqlParameter ptrusername = new SqlParameter("@USERNAME1", username);

            int a = ObjConnection.ExecuteProcedure("regis", ptrusername);

            return a;


        }
        public int royalty(string username, string amount, string date)
        {

            SqlParameter ptrusername = new SqlParameter("@USERNAME", username);
            SqlParameter ptramount = new SqlParameter("@ATMROI", amount);
            SqlParameter ptrdate = new SqlParameter("@DATE", date);
            int a = ObjConnection.ExecuteProcedure("TBLROI", ptrusername, ptramount, ptrdate);
            return a;


        }
        public int regi1(string username)
        {

            SqlParameter ptrusername = new SqlParameter("@USERNAME", username);

            int a = ObjConnection.ExecuteProcedure("regi", ptrusername);

            return a;


        }
        public int closing(DateTime date1,DateTime date2,string type)
        {

            SqlParameter ptrdate1 = new SqlParameter("@DATEFROM", date1);
            SqlParameter ptrdate2 = new SqlParameter("@DATETO", date2);
            SqlParameter ptrtype = new SqlParameter("@DTIME", type);

            int a = ObjConnection.ExecuteProcedure("closing", ptrdate1, ptrdate2, ptrtype);

            return a;


        }
        public int closing7000(DateTime date1, DateTime date2, string type)
        {

            SqlParameter ptrdate1 = new SqlParameter("@DATEFROM", date1);
            SqlParameter ptrdate2 = new SqlParameter("@DATETO", date2);
            SqlParameter ptrtype = new SqlParameter("@DTIME", type);

            int a = ObjConnection.ExecuteProcedure("closing7000", ptrdate1, ptrdate2, ptrtype);

            return a;


        }
        public int uppercount1(string username, string amount)
        {

            SqlParameter ptrusername = new SqlParameter("@USERNAME", username);
            SqlParameter ptramount = new SqlParameter("@AMT", amount);

            int a = ObjConnection.ExecuteProcedure("uppercount", ptrusername, ptramount);

            return a;


        }
        public int increasedailybinarycount1(string username, string amount)
        {

            SqlParameter ptrusername = new SqlParameter("@USERNAME", username);
            SqlParameter ptramount = new SqlParameter("@AMOUNTT", amount);

            int a = ObjConnection.ExecuteProcedure("increasedailybinarycount", ptrusername, ptramount);

            return a;


        }
        public int increasedailypv1(string username, string amount)
        {

            SqlParameter ptrusername = new SqlParameter("@USERNAME", username);
            SqlParameter ptramount = new SqlParameter("@AMOUNTT", amount);

            int a = ObjConnection.ExecuteProcedure("increasedailypv", ptrusername, ptramount);

            return a;


        }
        public int roi(string username, string amount, string type)
        {

            SqlParameter ptrusername = new SqlParameter("@USERNAME", username);
            SqlParameter ptramount = new SqlParameter("@ATMROI", amount);
            SqlParameter ptrtype = new SqlParameter("@ROITYPE", type);

            int a = ObjConnection.ExecuteProcedure("TBLROI", ptrusername, ptramount, ptrtype);

            return a;


        }
        public int Brand(int Bid, string BrandName, DateTime Date, string Transaction)
        {

            SqlParameter ptmBid = new SqlParameter("@Bid", Bid);
            SqlParameter ptmBrandName = new SqlParameter("@BrandName", BrandName);
            SqlParameter ptmDate = new SqlParameter("@Date", Date);

            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("Brand", ptmBid, ptmBrandName, ptmDate, ptmTransaction);

            return a;

        }
        public int Unit(int Uid, string Unit, DateTime Date, string Transaction)
        {

            SqlParameter ptmUid = new SqlParameter("@Uid", Uid);
            SqlParameter ptmUnit = new SqlParameter("@Unit", Unit);
            SqlParameter ptmDate = new SqlParameter("@Date", Date);

            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("Unit", ptmUid, ptmUnit, ptmDate, ptmTransaction);

            return a;

        }

        public int Category(int Cid, string Category, DateTime Date, string Transaction)
        {

            SqlParameter ptmCid = new SqlParameter("@Cid", Cid);
            SqlParameter ptmCategory = new SqlParameter("@Category", Category);
            SqlParameter ptmDate = new SqlParameter("@Date", Date);

            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("Category", ptmCid, ptmCategory, ptmDate, ptmTransaction);

            return a;

        }
        public int SubCategory(int id, string Category, string SubCategory, DateTime Date, string Transaction)
        {

            SqlParameter ptmid = new SqlParameter("@id", id);
            SqlParameter ptmSubCategory = new SqlParameter("@SubCategory", SubCategory);
            SqlParameter ptmCategory = new SqlParameter("@Category", Category);
            SqlParameter ptmDate = new SqlParameter("@Date", Date);

            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("subcategory", ptmid, ptmSubCategory, ptmCategory, ptmDate, ptmTransaction);

            return a;

        }
        public int Product(int Pid, string Pname, DateTime Pdate, string Brand, string Category, string MRP, string saleprice, string qty, string color, string size, string Subcategory, string ptype, string rating, string description, string Transaction)
        {

            SqlParameter ptmPid = new SqlParameter("@Pid", Pid);
            SqlParameter ptmPname = new SqlParameter("@Pname", Pname);
            SqlParameter ptmPdate = new SqlParameter("@Pdate", Pdate);
            SqlParameter ptmBrand = new SqlParameter("@Brand", Brand);
            SqlParameter ptmCategory = new SqlParameter("@Category", Category);
            SqlParameter ptmMRP = new SqlParameter("@MRP", MRP);
            SqlParameter ptmsaleprice = new SqlParameter("@saleprice", saleprice);
            SqlParameter ptmqty = new SqlParameter("@qty", qty);
            SqlParameter ptmcolor = new SqlParameter("@color", color);
            SqlParameter ptmsize = new SqlParameter("@size", size);
            SqlParameter ptmSubcategory = new SqlParameter("@Subcategory", Subcategory);
            SqlParameter ptmptype = new SqlParameter("@ptype", ptype);
            SqlParameter ptmrating = new SqlParameter("@rating", rating);
            SqlParameter ptmdescription = new SqlParameter("@description", description);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("Product", ptmPid, ptmPname, ptmPdate, ptmBrand, ptmCategory,ptmMRP,ptmsaleprice,ptmqty,ptmcolor,ptmsize, ptmSubcategory, ptmptype, ptmrating, ptmdescription, ptmTransaction);

            return a;

        }
        public int slider(int id, string imagename, string URL, string type, string status, DateTime date, string section, string Transaction)
        {

            SqlParameter ptmid = new SqlParameter("@id", id);
            SqlParameter ptmimagename = new SqlParameter("@imagename", imagename);
            SqlParameter ptmURL = new SqlParameter("@URL", URL);
            SqlParameter ptmtype = new SqlParameter("@type", type);
            SqlParameter ptmstatus = new SqlParameter("@status", status);
            SqlParameter ptmdate = new SqlParameter("@date", date);
            SqlParameter ptmsection = new SqlParameter("@section", section);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("slider", ptmid, ptmimagename, ptmURL, ptmtype, ptmstatus, ptmdate, ptmsection, ptmTransaction);

            return a;

        }

        public int Tax(int Tid, string Taxname,string amount, DateTime date, string Transaction)
        {

            SqlParameter ptmPid = new SqlParameter("@Tid", Tid);
            SqlParameter ptmPname = new SqlParameter("@Taxname", Taxname);
            SqlParameter ptmamount = new SqlParameter("@amount", amount);
            SqlParameter ptmPdate = new SqlParameter("@date", date);
          
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("Tax", ptmPid, ptmPname,ptmamount, ptmPdate, ptmTransaction);

            return a;

        }
        public int supplier(int id,string Sid ,string Sname, string address, string mobile, string firmname, DateTime date, string Transaction)
        {
            SqlParameter prmid = new SqlParameter("@id", id);
            SqlParameter ptmsid = new SqlParameter("@Sid", Sid);
            SqlParameter ptmPname = new SqlParameter("@Sname", Sname);
            SqlParameter ptmaddress = new SqlParameter("@address", address);
            SqlParameter ptmmobile = new SqlParameter("@mobile", mobile);
            SqlParameter ptmfname = new SqlParameter("@firmname", firmname);
            SqlParameter ptmdate = new SqlParameter("@date", date);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("supplier",prmid, ptmsid, ptmPname, ptmaddress,ptmmobile,ptmfname,ptmdate,ptmTransaction);

            return a;

        }

        public int purchaseaccount(int sr, string supplierid, string debit, string credit, string date, string invoiceno,string remark, string Transaction)
        {

            SqlParameter ptmsid = new SqlParameter("@Sr", sr);
            SqlParameter ptmsuppid = new SqlParameter("@Supplierid", supplierid);
            SqlParameter ptmadebit = new SqlParameter("@debit", debit);
            SqlParameter ptmcredit = new SqlParameter("@credit", credit);
           
            SqlParameter ptmdate = new SqlParameter("@date", date);
            SqlParameter ptminvoice= new SqlParameter("@invoiceno", invoiceno);
            SqlParameter ptmremark = new SqlParameter("@remark", remark);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("Purchaseaccount", ptmsid, ptmsuppid, ptmadebit, ptmcredit, ptmdate, ptminvoice, ptmremark, ptmTransaction);

            return a;
        }
        public int purchasetrans(int pid, string Supplierid,string invoiceno, string brand, string category, string unit, string product,string purchasetax,string purchaseprice,string qty,string final , string date ,string  Transaction)
        {
            SqlParameter ptmPid = new SqlParameter("@Pid", pid);
            SqlParameter ptmSid = new SqlParameter("@Supplierid", Supplierid);
         //   SqlParameter ptmSid = new SqlParameter("@supplierid", supplierid);
            SqlParameter ptminvoiceno = new SqlParameter("@invoiceno", invoiceno);
            SqlParameter ptmbrand = new SqlParameter("Brand", brand);
             SqlParameter ptmcategory = new SqlParameter("category", category);
             SqlParameter ptmunit = new SqlParameter("unit",unit );
             SqlParameter ptmproduct = new SqlParameter("product", product);
             SqlParameter ptmpurchasetax = new SqlParameter("purchasetax",purchasetax );
             SqlParameter ptmpurchaseprice = new SqlParameter("purchaseprice",purchaseprice );
             SqlParameter ptmqty = new SqlParameter("qty",qty );
             SqlParameter ptmfinal = new SqlParameter("final",final );
            SqlParameter ptmdate = new SqlParameter("@date", date);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("purchasetransaction", ptmPid, ptmSid, ptminvoiceno, ptmbrand, ptmcategory, ptmunit, ptmproduct, ptmpurchasetax, ptmpurchaseprice, ptmqty, ptmfinal, ptmdate, ptmTransaction);

            return a;
        }
        public int purchasestocks(int rid, string brand, string category, string unit, string product, string qty, string final, DateTime date, string Transaction)
        {
            SqlParameter ptmPid = new SqlParameter("@rid", rid);
            SqlParameter ptmbrand = new SqlParameter("@Brand", brand);
            SqlParameter ptmcategory = new SqlParameter("@category", category);
            SqlParameter ptmunit = new SqlParameter("@unit", unit);
            SqlParameter ptmproduct = new SqlParameter("@product", product);
            SqlParameter ptmqty = new SqlParameter("@qty", qty);
            SqlParameter ptmfinal = new SqlParameter("@final", final);
            SqlParameter ptmdate = new SqlParameter("@date", date);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("purchasestock", ptmPid, ptmbrand, ptmcategory, ptmunit, ptmproduct,  ptmqty, ptmfinal, ptmdate, ptmTransaction);

            return a;
        }

        public int msc(int id, string Name, string address, string phoneno, string Username, string Password,  DateTime date, string Transaction)
        {
            SqlParameter ptmPid = new SqlParameter("@id", id);
            SqlParameter ptmname = new SqlParameter("@Name", Name);
            SqlParameter ptmaddress = new SqlParameter("@address", address);
            SqlParameter ptmphoneno = new SqlParameter("@phoneno", phoneno);
            SqlParameter ptmusername = new SqlParameter("@Username", Username);
            SqlParameter ptmpass = new SqlParameter("@Password", Password);
            SqlParameter ptmdate = new SqlParameter("@date", date);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("msc", ptmPid, ptmname, ptmaddress, ptmphoneno, ptmusername, ptmpass, ptmdate, ptmdate, ptmTransaction);

            return a;
        }
        // SART FUNCTION FOR ADD NEW IMAGE ,[Name]
        public int DOCupload(int mid, string UserName, string imagename, string url, string Status, string Remark,
           DateTime DOU, string Transaction)
        {

            SqlParameter ptrmid = new SqlParameter("Kid", mid);
            SqlParameter ptrusername = new SqlParameter("UserName", UserName);
            SqlParameter ptrimagename = new SqlParameter("DocName", imagename);
            SqlParameter ptrurl = new SqlParameter("DocLink", url);
            SqlParameter ptrStatus = new SqlParameter("DocStatus", Status);
            SqlParameter ptrRemark = new SqlParameter("Remark", Remark);
            SqlParameter ptrDOU = new SqlParameter("DOU", DOU);
            SqlParameter ptrTransaction = new SqlParameter("Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("KYC", ptrmid, ptrusername, ptrimagename, ptrurl, ptrStatus, ptrRemark, ptrDOU, ptrTransaction);

            return a;

        }
        public int SellStock(int Sid, string BillNo, string Billtype, string BDate, string Debit, string credit,
              string Total, string ToUser, string FromUser, string BillStatus, string Brand, string Category,
              string Product, string Unit, string Weight, string Productid, string Price, string Amount, string Transaction)
        {
            SqlParameter ptmsid = new SqlParameter("@Sid", Sid);
            SqlParameter ptmbillno = new SqlParameter("@BillNo", BillNo);
            SqlParameter ptmbilltype = new SqlParameter("@Billtype", Billtype);
            SqlParameter ptmdate = new SqlParameter("@BDate", BDate);
            SqlParameter ptmdebit = new SqlParameter("@Debit", Debit);
            SqlParameter ptmcredit = new SqlParameter("@credit", credit);
            SqlParameter ptmtotal = new SqlParameter("@Total", Total);
            SqlParameter ptmtouser = new SqlParameter("@ToUser", ToUser);
            SqlParameter ptmfromuser = new SqlParameter("@FromUser", FromUser);
            SqlParameter ptmBillStatus = new SqlParameter("@BillStatus", BillStatus);
            SqlParameter ptmBrand = new SqlParameter("@Brand", Brand);
            SqlParameter ptmcategory = new SqlParameter("@category", Category);
            SqlParameter ptmproduct = new SqlParameter("@product", Product);
            SqlParameter ptmUnit = new SqlParameter("@Unit", Unit);
            SqlParameter ptmWeight = new SqlParameter("@Weight", Weight);
            SqlParameter ptmProductid = new SqlParameter("@Productid", Productid);
            SqlParameter ptmPrice = new SqlParameter("@Price", Price);
            SqlParameter ptmAmount = new SqlParameter("@Amount", Amount);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("SellStock", ptmsid, ptmbillno, ptmbilltype, ptmdate, ptmdebit, ptmcredit,
                ptmtotal, ptmtouser, ptmfromuser, ptmBillStatus, ptmBrand, ptmcategory, ptmproduct, ptmUnit,
                ptmWeight, ptmProductid, ptmPrice, ptmAmount, ptmTransaction);

            return a;
        }
        public int Bill(int sr, string Bid, string supplierid, string Companyname, string billtype, string billno,
             string totalamt, string discount, string netamt, string Remark, string paymentmode, string Otherexpence, string date, string btype, string Transaction)
        {
            SqlParameter ptmsr = new SqlParameter("@Sr", sr);
            SqlParameter ptmBid = new SqlParameter("@Bid", Bid);
            SqlParameter ptmsupplierid = new SqlParameter("@supplierid", supplierid);
            SqlParameter ptmCompanyname = new SqlParameter("@Companyname", Companyname);
            SqlParameter ptmbilltype = new SqlParameter("@billtype", billtype);
            SqlParameter ptmbillno = new SqlParameter("@billno", billno);
            SqlParameter ptmtotalamt = new SqlParameter("@totalamt", totalamt);
            SqlParameter ptmdiscount = new SqlParameter("@discount", discount);

            SqlParameter ptmnetamt = new SqlParameter("@netamt", netamt);
            SqlParameter ptmRemark = new SqlParameter("@Remark", Remark);
            SqlParameter ptmpaymentmode = new SqlParameter("@paymentmode", paymentmode);
            SqlParameter ptmdate = new SqlParameter("@date", date);
            SqlParameter ptmOtherexpence = new SqlParameter("@Otherexpence", Otherexpence);
            SqlParameter ptmbtype = new SqlParameter("@Type", btype);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("BILL", ptmsr, ptmBid, ptmsupplierid, ptmCompanyname, ptmbilltype, ptmbillno,
                ptmtotalamt, ptmdiscount, ptmnetamt, ptmRemark, ptmpaymentmode, ptmdate, ptmOtherexpence, ptmbtype, ptmTransaction);

            return a;
        }
        public int PartyAccount(int sr, string supplierid, string debit, string credit, string date, string invoiceno, string remark, string paymentmode, string billtype, string touser, string Transaction)
        {

            SqlParameter ptmsid = new SqlParameter("@Sr", sr);
            SqlParameter ptmsuppid = new SqlParameter("@Supplierid", supplierid);
            SqlParameter ptmadebit = new SqlParameter("@debit", debit);
            SqlParameter ptmcredit = new SqlParameter("@credit", credit);
            SqlParameter ptmdate = new SqlParameter("@date", date);
            SqlParameter ptminvoice = new SqlParameter("@invoiceno", invoiceno);
            SqlParameter ptmremark = new SqlParameter("@remark", remark);
            SqlParameter ptmpaymentmode = new SqlParameter("@paymentmode", paymentmode);
            SqlParameter ptminvoicetype = new SqlParameter("@invoicetype", billtype);
            SqlParameter ptmtouser = new SqlParameter("@touser", touser);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("Purchaseaccount", ptmsid, ptmsuppid, ptmadebit, ptmcredit, ptmdate, ptminvoice, ptmremark, ptminvoicetype, ptmpaymentmode, ptmtouser, ptmTransaction);

            return a;
        }
        public int Account(int Aid, string BillNo, string BillType, string BDate, string debit, string credit, string total, string Touser, string FromUser, string BillStatus, string remark, string Transaction)
        {



            SqlParameter ptmAid = new SqlParameter("@Aid", Aid);
            SqlParameter ptmBillNo = new SqlParameter("@BillNo", BillNo);
            SqlParameter ptmBillType = new SqlParameter("@BillType", BillType);
            SqlParameter ptmBDate = new SqlParameter("@BDate", BDate);
            SqlParameter ptmdebit = new SqlParameter("@Debit", debit);
            SqlParameter ptmcredit = new SqlParameter("@Credit", credit);
            SqlParameter ptmtotal = new SqlParameter("@Total", total);
            SqlParameter ptmTouser = new SqlParameter("@ToUser", Touser);
            SqlParameter ptmFromUser = new SqlParameter("@FromUser", FromUser);
            SqlParameter ptmBillStatus = new SqlParameter("@BillStatus", BillStatus);
            SqlParameter ptmremark = new SqlParameter("@Remark", remark);
            SqlParameter ptmTransaction = new SqlParameter("@Transaction", Transaction);
            int a = ObjConnection.ExecuteProcedure("account", ptmAid, ptmBillNo, ptmBillType, ptmBDate, ptmdebit, ptmcredit, ptmtotal, ptmTouser, ptmFromUser, ptmBillStatus, ptmremark, ptmTransaction);

            return a;
        }
    }
}
    
  
