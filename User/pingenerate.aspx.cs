using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_pin : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = ob.dttt("select * from pinmgt where status!='Used'");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string capta = "";
            int no = Convert.ToInt32(TextBox1.Text);
            for (int n = 1; n <= no; n++)
            {
                for (int i = 1; i <= 100; i++)
                {
                    var chars = "0123456789";
                    var stringChars = new char[10];
                    var random = new Random();

                    for (int ik = 0; ik < stringChars.Length; ik++)
                    {
                        stringChars[ik] = chars[random.Next(chars.Length)];
                    }

                    var finalString = new String(stringChars);
                    capta = Convert.ToString(finalString);
                    SqlDataReader dr = ob.drrr("select * from pingen where pin='" + capta + "'");
                    if (dr.Read())
                    {
                        ob.CloseConn();

                    }
                    else
                    {
                        ob.CloseConn();
                        i = 120;
                       
                    }

                }
                string date = System.DateTime.Now.ToShortDateString();

                ob.Execute("insert into pingen(owner1,owner2,pin,amt,createdate,userr) values('Admin','Admin','" + capta + "','" + DropDownList1.SelectedItem.Text + "','"+System.DateTime.Now.ToString("yyyy-MM-dd")+"','0')");
                ob.Execute("insert into pinmanage (pin,holder) values('"+capta+"','Admin')");
            }
            Response.Write("<script>alert('Pin generated successfully ')</script>");
            DataTable dt = ob.dttt("select * from pinmgt where status!='Used'");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch
        {

            DataTable dt = ob.dttt("select * from pinmgt where status!='Used'");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Response.Write("<script>alert('Something is Wrong')</script>");
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}