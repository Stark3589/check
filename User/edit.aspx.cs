using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class edit : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            ob.Execute("update register set name='" + TextBox2.Text + "',fname='" + TextBox3.Text + "', address='" + TextBox6.Text + "',mobile='" + TextBox7.Text + "',pan='" + TextBox9.Text + "',city='"+TextBox10.Text+"',state='"+DropDownList2.SelectedItem.Text+"',nomineename='"+TextBox11.Text+"',relation='"+TextBox12.Text+"' where username='" + TextBox1.Text + "'");
            ob.Execute("update bankdetail set accno='" + TextBox8.Text + "',bankname='" + TextBox4.Text + "', ifsc='" + TextBox5.Text + "' where username='" + TextBox1.Text + "'");
        }
        catch (Exception) { Response.Write("<script>alert('Something Is Wrong !!!!!!')</script>"); }
        }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = ob.dttt("select name,fname,address,mobile,pan,city,state,nomineename,relation from register where username='" + TextBox1.Text + "'");
            TextBox2.Text = dt.Rows[0][0].ToString();
            TextBox3.Text = dt.Rows[0][1].ToString();
            TextBox6.Text = dt.Rows[0][2].ToString();
            TextBox7.Text = dt.Rows[0][3].ToString();
            TextBox9.Text = dt.Rows[0][4].ToString();
           // dropdownlist.Items.FindByValue(value).Selected = true;
            TextBox10.Text = dt.Rows[0][5].ToString();
            DropDownList2.SelectedItem.Text = dt.Rows[0][6].ToString();
            TextBox11.Text = dt.Rows[0][7].ToString();
            TextBox12.Text = dt.Rows[0][8].ToString();
            


            DataTable dt1 = ob.dttt("select accno,bankname,ifsc from bankdetail where username='" + TextBox1.Text + "'");
            TextBox8.Text = dt1.Rows[0][0].ToString();
            TextBox4.Text = dt1.Rows[0][1].ToString();
            TextBox5.Text = dt1.Rows[0][2].ToString();
        }
        catch (Exception) {  }
    }
}