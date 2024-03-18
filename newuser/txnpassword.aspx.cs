using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class newuser_txnpassword : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text != "" && TextBox3.Text != "" && (TextBox2.Text == TextBox3.Text))
        {
            string passwprd = EncodePasswordToBase64(TextBox2.Text);
            ob.Execute("update register set onside='" + passwprd + "' where username='" + Session["newuser"].ToString() + "'");
            Label1.Text = "Txn. Password Updated Successfully";
            Label1.Visible = true;
        }
        else
        {
            Label1.Text = "Sorry. Password not updated";
            Label1.Visible = true;
        }
    }
    public static string EncodePasswordToBase64(string password)
    {
        try
        {
            byte[] encData_byte = new byte[password.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
            string encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;
        }
        catch (Exception ex)
        {
            throw new Exception("Error in base64Encode" + ex.Message);
        }
    }
}