using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

public partial class newuser_rsideticket : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {

                DataTable dt2 = ob.dttt("select name from  register where username='" + Session["newuser"].ToString() + "'");
                TextBox2.Text = dt2.Rows[0][0].ToString();
            }
            catch (Exception hg) { };
            var chars = "1234567890";
            var stringChars1 = new char[6];
            var random = new Random();

            for (int ik = 0; ik < stringChars1.Length; ik++)
            {
                stringChars1[ik] = chars[random.Next(chars.Length)];
            }

            var finalString1 = new String(stringChars1);
            string capta1 = Convert.ToString(finalString1);

            txtunameid.Text = capta1;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        RepeaterItem item = (sender as Button).NamingContainer as RepeaterItem;

        //Reference the Label and TextBox.
        string id = (item.FindControl("Label3") as Label).Text;
        Response.Redirect("ticketstatus.aspx?ticketid="+ id );  
        
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {

        if (FileUpload1.HasFile)
        {
            string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../ticket/") + fileName);
            string imgurl = "../ticket/" + fileName;
            ob.Execute("insert into ticket values('" + Session["newuser"].ToString() + "','" + txtunameid.Text + "',N'" + msg.Text + "','" + imgurl + "','user','','OPEN','" + txtname.Text + "','" + System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.mmm") + "')");
            Response.Write("<script>alert('Ticket Raised Successfully.')</script>");
        }
        else
        {
            ob.Execute("insert into ticket values('" + Session["newuser"].ToString() + "','" + txtunameid.Text + "',N'" + msg.Text + "','','user','','OPEN','" + txtname.Text + "','" + System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.mmm") + "')");
            Response.Write("<script>alert('Ticket Raised Successfully.')</script>");

        }
        msg.Text = "";
        //try
        //{

        //    DataTable dt2 = ob.dttt("select * from  ticket where username='" + Session["newuser"].ToString() + "'  and sub!='' order by id desc");
        //    Repeater1.DataSource = dt2;
        //    Repeater1.DataBind();
        //}
        //catch (Exception hg) { };
    }
}