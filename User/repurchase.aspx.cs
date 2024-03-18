using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class User_repurchase : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
   // DataClassesDataContext ds = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //try
            //{
            //    DataTable dt2 = ob.dttt("select news,news2 from news");
            //    TextBox1.Text = dt2.Rows[0][0].ToString();
            //    TextBox2.Text = dt2.Rows[0][1].ToString();
            //}
            //catch (Exception jk) { }


        
            
           
        }
    }
   

    protected void Button2_Click(object sender, EventArgs e)
    {
        FileUpload1.SaveAs(Server.MapPath("../images/" + FileUpload1.FileName));
        string str = "../images/" + FileUpload1.FileName;
        ob.Execute("truncate table walletaddress");
        string llk = "";
           llk = "insert into walletaddress  values('"+str+"','','','','','" + TextBox7.Text + "')";
           
            ob.Execute(llk);
            Response.Write("<script>alert('Account Details Update Successfully')</script>");

    }
}