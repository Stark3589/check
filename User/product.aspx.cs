using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Admin_product : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //try
            //{
               

            //    DataTable ds = ob.dttt("select type from producttype");
            //    DropDownList1.DataSource = ds;
            //    DropDownList1.DataTextField = "type";
            //    DropDownList1.DataValueField = "type";
            //    DropDownList1.DataBind();
            //    DropDownList1.Items.Insert(0, new ListItem("--Select Product Type--", "0"));
            //}
            //catch (Exception) { };
        }
    }
    //public void autogen()
    //{
    //    var chars = "0123456789";
    //    var stringChars = new char[5];
    //    var random = new Random();

    //    for (int ik = 0; ik < stringChars.Length; ik++)
    //    {
    //        stringChars[ik] = chars[random.Next(chars.Length)];
    //    }

    //    var finalString = new String(stringChars);
    //    string capta = Convert.ToString(finalString);
    //    for (int x = 1; x <= 100; x++)
    //    {
    //        SqlDataReader dr = ob.drrr("select * from product where product_id='" + TextBox1.Text + "'");
    //        if (dr.Read())
    //        {
    //            ob.CloseConn();
    //            var chars1 = "0123456789";
    //            var stringChars1 = new char[5];
    //            var random1 = new Random();

    //            for (int ik = 0; ik < stringChars1.Length; ik++)
    //            {
    //                stringChars1[ik] = chars1[random1.Next(chars1.Length)];
    //            }

    //            var finalString1 = new String(stringChars1);
    //            capta = Convert.ToString(finalString1);
    //        }
    //        else
    //        {
    //            ob.CloseConn();
    //            x = 120;
    //        }
    //    }
    //    TextBox1.Text = capta;
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s1 = "", s2 = "", s3 = "";
        if (FileUpload1.HasFile)
        {
            s1 = "~/product/" + FileUpload1.FileName;
            FileUpload1.SaveAs(Server.MapPath("../product/" + FileUpload1.FileName));
        }
       
        if(s2=="")
        {
            s2 = s1;
        }
        if (s3 == "")
        {
            s3 = s1;
        }
        ob.Execute("insert into product(productname,productcode,qty,mrp,imgurl,detail,discount) values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + TextBox4.Text + "','" + TextBox8.Text + "','" + s1 + "','" + TextBox3.Text + "','" + TextBox5.Text + "')");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
      
   
        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Product Detail save sucessfully');window.location ='product.aspx';", true);

    }
}