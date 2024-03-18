using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class User_rewards : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s1 = "", s2 = "", s3 = "";
        if (FileUpload1.HasFile)
        {
            s1 = "~/rewards/" + FileUpload1.FileName;
            FileUpload1.SaveAs(Server.MapPath("../rewards/" + FileUpload1.FileName));
        }

        if (s2 == "")
        {
            s2 = s1;
        }
        if (s3 == "")
        {
            s3 = s1;
        }
        ob.Execute("insert into rewards(imgurl,detail) values('" + s1 + "','" + TextBox3.Text + "')");
      
        TextBox3.Text = "";


        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Rewards Detail save sucessfully');window.location ='rewards.aspx';", true);

    }
}