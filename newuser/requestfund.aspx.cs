using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class newuser_requestfund : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                txtid.Text = Session["newuser"].ToString();
                txtdate.Text = ob.utc().ToString("yyyy-MM-dd");
                DataTable dt = ob.dttt("select * from walletaddress");
                myInput.Text = dt.Rows[0][6].ToString();
                Image1.ImageUrl = dt.Rows[0][1].ToString();
                Image1.Visible = true;
              
            }catch(Exception jh){};
        }
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            if (FileUpload1.HasFile)
            {
               // DateTime indiantime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);

               // String tttt = indiantime.ToString("yyyy-MM-dd hh:mm:ss");
                FileUpload1.SaveAs(Server.MapPath("../images/" + FileUpload1.FileName));
                string str = "../images/" + FileUpload1.FileName;
                string query = "insert into tblreqfund (username,amount,trans_id,date,status,SLIP)values('" + txtid.Text + "','" + reqfund.Text + "','" + txttranid.Text + "','" + txtdate.Text + "','Pending','"+str+"')";
                ob.Execute(query);
                //   Response.Write("<script>alert('')</script>");

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('REQUEST SUCCESSFULLY SEND');window.location='requestfund.aspx';", true);
            }
        }
        catch (Exception ex)
        {
        }
    }
}