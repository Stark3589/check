using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class User_memberedit : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = ob.dttt("select username from register");
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "username";
            DropDownList1.DataValueField = "username";
            DropDownList1.DataBind();

            DataTable dt1 = ob.dttt("select state from state");
            DropDownList2.DataSource = dt1;
            DropDownList2.DataTextField = "state";
            DropDownList2.DataValueField = "state";
            DropDownList2.DataBind();

            DataTable dt2 = ob.dttt("select city from city where state='" + DropDownList2.SelectedItem.Text + "'");
            DropDownList3.DataSource = dt2;
            DropDownList3.DataTextField = "city";
            DropDownList3.DataValueField = "city";
            DropDownList3.DataBind();

        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt1 = ob.dttt("select city from city where state='"+DropDownList2.SelectedItem.Text+"'");
        DropDownList3.DataSource = dt1;
        DropDownList3.DataTextField = "city";
        DropDownList3.DataValueField = "city";
        DropDownList3.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ob.Execute("update register set state='" + DropDownList2.SelectedItem.Text + "',city='" + DropDownList3.SelectedItem.Text + "',pin='" + TextBox1.Text + "',address='" + TextBox2.Text + "' where username='" + DropDownList1.SelectedItem.Text + "'");
        TextBox1.Text = "";
        TextBox2.Text = "";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ob.Execute("update register set mobile='" + TextBox3.Text + "' where username='" + DropDownList1.SelectedItem.Text + "'");

    }
}