using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_home : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = "0";
            try
            {
                DataTable dt = ob.dttt("select count(username) from register ");
                Label1.Text = dt.Rows[0][0].ToString();
            }
            catch { }
            try
            {
                DataTable dt = ob.dttt("select * from news ");
                Label2.InnerText = dt.Rows[0][0].ToString();
                Label6.Text = dt.Rows[0][1].ToString();
            }
            catch { }
          //  this.ModalPopupExtender2.Show();
            

        }
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        
    }
}