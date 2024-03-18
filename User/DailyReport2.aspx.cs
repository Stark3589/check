using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_DailyReport2 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {



            DataTable dt2 = ob.dttt("select b.id,a.username,a.name from register a,levelset b where a.username=b.username   ");
            gvDetails.DataSource = dt2;
            gvDetails.DataBind();
               
           
        }


    }


  
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = ob.dttt("select name from register where username='" + TextBox1.Text + "'");
            TextBox2.Text = dt.Rows[0][0].ToString();

        }
        catch (Exception jh) { TextBox2.Text = ""; };
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (TextBox2.Text != "")
            {
                ob.Execute("INSERT INTO LEVELSET VALUES('" + TextBox1.Text + "','','','F')");
                Response.Write("<script>alert('ID REGISTERED SUCCESSFULLY')</script>");
            }
        }catch(Exception jh){};
    }
    protected void btnProcess_Click(object sender, EventArgs e)
    {
        string str = string.Empty;
        string strname = string.Empty;
        string dd = System.DateTime.UtcNow.Day.ToString();
        string mm = System.DateTime.UtcNow.Month.ToString();
        string yy = System.DateTime.UtcNow.Year.ToString();
        string y = yy + "-" + mm + "-" + dd;
        foreach (GridViewRow gvrow in gvDetails.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("chkSelect");
            if (chk != null & chk.Checked)
            {



                ob.Execute("delete from levelset where username = '" + gvrow.Cells[2].Text + "' and id='" + gvrow.Cells[1].Text + "'");
                // ob.Execute("insert into fundaccount(username,credit,debit,date,status)values('" + gvrow.Cells[2].Text + "','" + gvrow.Cells[4].Text + "','0','" + ob.utc().ToString("yyyy-MM-dd") + "','Approved Fund')");
                Response.Write("<script>alert('ID DELETED SUCCESSFULLY')</script>");




            }
        }
        gvDetails.Visible = false;
        btnProcess.Visible = false;
       
    }
}