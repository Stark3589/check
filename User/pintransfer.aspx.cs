using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class User_pintransfer1 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(CheckBox1.Checked)
        {
            //int x=Convert.ToInt32(TextBox1.Text)*30;
            //ob.Execute("INSERT INTO [dbo].[ACCOUNT] (USERNAME,CREDIT,DEBIT,DATE,TOTAL,VALU) VALUES('" + TextBox2.Text + "','" + x.ToString() + "','0','" + System.DateTime.Now.ToString("yyyy-MM-dd") + "','" + x.ToString() + "','FRANCHISE INCOME')");
        }
        int pin = 0;
        pin = Convert.ToInt32(TextBox1.Text);
       
        try
        {
            DataTable dt = ob.dttt("select count(a.pin) from pingen a,pinmanage b where a.owner2='Admin' and a.pin=b.pin and a.amt='"+DropDownList2.SelectedItem.Text+"' and b.reguser is null");
            int co = Convert.ToInt32(dt.Rows[0][0]);
            if (co >= pin)
            {
                DataTable dt1 = ob.dttt("select a.pin from pingen a,pinmanage b where a.owner2='Admin' and a.pin=b.pin and a.amt='" + DropDownList2.SelectedItem.Text + "' and b.reguser is null ");
                for (int i = 0; i < pin; i++)
                {
                    ob.Execute("update pinmanage set holder='" + TextBox2.Text + "' where pin='" + dt1.Rows[i][0].ToString() + "'");
                    ob.Execute("update pingen set owner2='" + TextBox2.Text + "' where pin='" + dt1.Rows[i][0].ToString() + "'");
                }

                Response.Write("<script>alert('Pin Transfered successfully ')</script>");
            }
            else
            {
                Response.Write("<script>alert('Pin not available, please generate first and then tranfer. ')</script>");
            }

            //ob.Execute("insert into products values('" + TextBox2.Text + "','" + DropDownList3.SelectedItem.Text + "','Pending','" + TextBox1.Text + "')");
           

        }
        catch (Exception) { };

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = ob.dttt("select name from register where username='" + TextBox2.Text + "'");
            Label2.Text = dt.Rows[0][0].ToString();
        }catch(Exception jh){};
    }
}
