using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Data;



public partial class Admin_withdrawal : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
              string status = Request.QueryString["status"];
              if (status == "Reject")
              {
                  DataTable dt = ob.dttt("select a.id,a.username,a.amount,a.dates,a.status,a.sdate,a.tds,a.remarks,a.admin,a.total_amt,b.name,c.accno,c.bankname,c.ifsc,c.branchname,C.GOOGLEPAY,C.PHONEPAY  from   withdrawal a,register b,bankdetail c where b.username=a.username and c.username=a.username and a.status='Reject'");
                  if (dt.Rows.Count > 0)
                  {
                      gvDetails.DataSource = dt;
                      gvDetails.DataBind();
                      gvDetails.Visible = true;
                      gvDetails.UseAccessibleHeader = true;
                      gvDetails.HeaderRow.TableSection = TableRowSection.TableHeader;
                  }
              }
              if (status == "Transfer")
              {
                  DataTable dt = ob.dttt("select a.id,a.username,a.amount,a.dates,a.status,a.sdate,a.tds,a.remarks,a.admin,a.total_amt,b.name,c.accno,c.bankname,c.ifsc,c.branchname,C.GOOGLEPAY,C.PHONEPAY  from   withdrawal a,register b,bankdetail c where b.username=a.username and c.username=a.username and a.status='Transfer'");
                  if (dt.Rows.Count > 0)
                  {
                      //  DataSet ds = ob.dsss("select products.id,products.username,products.qty, register.name,products.status,products.product,register.address from products inner join register on products.username=register.username where products.status='Delivered'");
                      gvDetails.DataSource = dt;
                      gvDetails.DataBind();
                      gvDetails.Visible = true;
                      gvDetails.UseAccessibleHeader = true;
                      gvDetails.HeaderRow.TableSection = TableRowSection.TableHeader;
                    
                  }
              }
        }
    }
  
 
}