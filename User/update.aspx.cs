using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;


public partial class User_update : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    business obb = new business();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //TextBox15.Text = TextBox7.Text = System.DateTime.Today.ToString("dd/MM/yyyy");
            //state Bind
            DataTable dt = obb.dttt("select distinct statename from pincode order by statename asc");
            Dropstate.DataSource = dt;
            Dropstate.DataTextField = "statename";
            Dropstate.DataBind();
            Dropstate.Items.Insert(0, "Select State");
            // City Bind
            DataTable dt1 = obb.dttt("select distinct districtname from pincode ");
            Dropcity.DataSource = dt1;
            Dropcity.DataTextField = "districtname";
            Dropcity.DataBind();
            Dropcity.Items.Insert(0, "Select City");
        }
        if (!IsPostBack)
        {
            Session["image1"] = "";
            Session["image2"] = "";
            Session["image3"] = ""; 
                    
        }
    }
    protected void TextBox24_TextChanged(object sender, EventArgs e)
    {
        try
        {
            SqlDataReader dr = ob.drrr("select * from register where username='" + TextBox24.Text + "'");
            if (dr.Read())
            {
                dr.Close();
                try
                {
                    
                    DataTable dt = ob.dttt("select * from register where username='" + TextBox24.Text + "'");
                    txtname.Text = dt.Rows[0]["name"].ToString();
                    txtfathusb.Text = dt.Rows[0]["fname"].ToString();
                    Dropupline.Items.Add(dt.Rows[0]["reffid"].ToString());
                    try
                    {
                        Dropgender.ClearSelection(); Dropgender.Items.FindByText(dt.Rows[0]["sex"].ToString()).Selected = true;
                    }
                    catch { }
                    try
                    {
                        Dropstate.ClearSelection(); Dropstate.Items.FindByText(dt.Rows[0]["State"].ToString()).Selected = true;
                    }
                    catch { }
                    try
                    {
                        Dropcity.ClearSelection(); Dropcity.Items.FindByText(dt.Rows[0]["city"].ToString()).Selected = true;
                    }
                    catch { }
                    try
                    {
                        Dropnomrelation.ClearSelection(); Dropnomrelation.Items.FindByText(dt.Rows[0]["relation"].ToString()).Selected = true;
                    }
                    catch { }
                    txtuserid.Text = dt.Rows[0]["username"].ToString();
                    txtadd.Text = dt.Rows[0]["address"].ToString();
                    txtdob.Text = dt.Rows[0]["dob"].ToString().Substring(0,10);
                    txtpincode.Text = dt.Rows[0]["pin"].ToString();
                    txtmob.Text = dt.Rows[0]["mobile"].ToString();
                    txtpan.Text = dt.Rows[0]["pan"].ToString();
                    txtemail.Text = dt.Rows[0]["email"].ToString();
                    txtnominee.Text = dt.Rows[0]["nomineename"].ToString();
                    txtnomage.Text = dt.Rows[0]["nage"].ToString();
                    txtnomdob.Text = dt.Rows[0]["ndob"].ToString().Substring(0,10);

                   
                }
                catch { }
                try
                {
                    DataTable ft1 = ob.dttt("select * from bankdetail where username='"+TextBox24.Text+"'");
                    txtbankname.Text = ft1.Rows[0]["bankname"].ToString();
                    txtaccountno.Text = ft1.Rows[0]["accno"].ToString();
                    txtaccountname.Text = ft1.Rows[0]["holdername"].ToString();
                    txtbranch.Text = ft1.Rows[0]["branchname"].ToString();
                    txtifsccode.Text = ft1.Rows[0]["ifsc"].ToString();
                   
                    
                }
                catch { }

                try
                {
                    DataTable img = ob.dttt("select * from images where username='"+TextBox24.Text+"'");
                    try
                    {
                        Session["image1"] = Image1.ImageUrl = img.Rows[0]["image"].ToString();
                    }
                    catch{}
                     try
                    {
                    Session["image2"] = Image2.ImageUrl = img.Rows[0]["pancard"].ToString();
                    }
                    catch{}
                     try
                    {
                    Session["image3"] = Image3.ImageUrl = img.Rows[0]["passbook"].ToString();
                    }
                     catch { }
                    
                }
                catch { }
               
            }
            else
            {
                dr.Close();
                Response.Write("<script>alert('Invalid UserId')</script>");
            }
        }
        catch { }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {

            string strDate1 = txtdob.Text; //Format – dd/MM/yyyy
            //split string date by separator, here I'm using '/'
            DateTime dte = DateTime.Parse(strDate1);
            string dob = dte.ToString("yyyy-MM-dd");

            string strDate2 = txtnomdob.Text; //Format – dd/MM/yyyy
            //split string date by separator, here I'm using '/'
            dte = DateTime.Parse(strDate2);
            string ndob = dte.ToString("yyyy-MM-dd");

            ob.Execute("update register set  name='"+txtname.Text+"', fname='"+txtfathusb.Text+"', address='"+txtadd.Text+"', city='"+Dropcity.SelectedItem.Text+"', State='"+Dropstate.SelectedItem.Text+"', email='"+txtemail.Text+"', mobile='"+txtmob.Text+"', nomineename='"+txtnominee.Text+"', relation='"+Dropnomrelation.SelectedItem.Text+"', pan='"+txtpan.Text+"', nage='"+txtnomage.Text+"', ndob='"+ndob+"', sex='"+Dropgender.Text+"', pin='"+txtpincode.Text+"', dob='"+dob+"' where username='"+TextBox24.Text+"'");
            ob.Execute("update images set image='"+Session["image1"].ToString()+"',pancard='"+Session["image2"].ToString()+"',passbook='"+Session["image3"].ToString()+"' where username='"+TextBox24.Text+"'");
            try
            {
                SqlDataReader dr = ob.drrr("select username from bankdetail where username='" + TextBox24.Text + "'");
                if (dr.Read())
                {
                    ob.CloseConn();
                    ob.Execute("update bankdetail set accno='" + txtaccountno.Text + "', bankname='" + txtbankname.Text + "', ifsc='" + txtifsccode.Text + "', branchname='" + txtbranch.Text + "', holdername='" + txtaccountname.Text + "' where username='" + TextBox24.Text + "'");

                }
                else
                {
                    ob.CloseConn();
                    ob.Execute("insert into bankdetail (username,accno,bankname,ifsc,branchname,holdername) values ('" + TextBox24.Text + "','" + txtaccountno.Text + "','" + txtbankname.Text + "','" + txtifsccode.Text + "','" + txtbranch.Text + "','" + txtaccountname.Text + "')");

                }






                //   ob.Execute("update bankdetail set accno='" + txtaccountno.Text + "', bankname='" + txtbankname.Text + "', ifsc='" + txtifsccode.Text + "', branchname='" + txtbranch.Text + "', holdername='" + txtaccountname.Text + "' where username='" + Session["newuser"].ToString() + "'");
            }
            catch (Exception hg) { };
            Response.Write("<script>alert('SUCCESSFULLY UPDATE')</script>");
        }
        catch { }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if ((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
        {
            string filePath = FileUpload1.FileName;

            string st = Server.MapPath("~/User/proimage/" + filePath);
            FileInfo file = new FileInfo(st);
            if (file.Exists)
            {
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string strDate = filename; //Format – dd/MM/yyyy
                //split string date by separator, here I'm using '/'
                string[] arrDate = strDate.Split('.');
                //now use array to get specific date object
                string a = arrDate[0].ToString();
                string b = arrDate[1].ToString();
                var newPath = a + DateTime.Now.ToString("yyyymmddMMss") + "." + b;
                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload1.SaveAs(Server.MapPath("~/User/proimage/" + newPath));
                //Open the database connection

                // string ssss = "~/User/proimage" + "/" + filename;
                string ssss1 = "~/User/proimage" + "/" + newPath;
                Session["image1"] = ssss1;
                Image1.ImageUrl = ssss1;
            }
            else
            {

                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);

                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload1.SaveAs(Server.MapPath("~/User/proimage/" + filename));
                //Open the database connection

                string ssss = "~/User/proimage" + "/" + filename;

                Session["image1"] = ssss;
                Image1.ImageUrl = ssss;
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string filePath = FileUpload2.FileName;

        string st = Server.MapPath("~/User/proimage/" + filePath);
        FileInfo file = new FileInfo(st);
        if (file.Exists)
        {
            string filename = Path.GetFileName(FileUpload2.PostedFile.FileName);
            string strDate = filename; //Format – dd/MM/yyyy
            //split string date by separator, here I'm using '/'
            string[] arrDate = strDate.Split('.');
            //now use array to get specific date object
            string a = arrDate[0].ToString();
            string b = arrDate[1].ToString();
            var newPath = a + DateTime.Now.ToString("yyyymmddMMss") + "." + b;
            //  string filename = Path.GetFileName(FileUpload1.FileName);
            //Save images into SlideImages folder
            FileUpload2.SaveAs(Server.MapPath("~/User/proimage/" + newPath));
            //Open the database connection

            // string ssss = "~/User/proimage" + "/" + filename;
            string ssss1 = "~/User/proimage" + "/" + newPath;
            Session["image2"] = ssss1;
            Image2.ImageUrl = ssss1;
        }
        else
        {
            string filename = Path.GetFileName(FileUpload2.PostedFile.FileName);
            //Save images into SlideImages folder
            FileUpload2.SaveAs(Server.MapPath("~/User/proimage/" + filePath));
            //Open the database connection

            string ssss = "~/User/proimage" + "/" + filename;
            Session["image2"] = ssss;
            Image2.ImageUrl = ssss;
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string filePath = FileUpload3.FileName;

        string st = Server.MapPath("~/User/proimage/" + filePath);
        FileInfo file = new FileInfo(st);
        if (file.Exists)
        {
            string filename = Path.GetFileName(FileUpload3.PostedFile.FileName);
            string strDate = filename; //Format – dd/MM/yyyy
            //split string date by separator, here I'm using '/'
            string[] arrDate = strDate.Split('.');
            //now use array to get specific date object
            string a = arrDate[0].ToString();
            string b = arrDate[1].ToString();
            var newPath = a + DateTime.Now.ToString("yyyymmddMMss") + "." + b;
            //  string filename = Path.GetFileName(FileUpload1.FileName);
            //Save images into SlideImages folder
            FileUpload3.SaveAs(Server.MapPath("~/User/proimage/" + newPath));
            //Open the database connection

            // string ssss = "~/User/proimage" + "/" + filename;
            string ssss1 = "~/User/proimage" + "/" + newPath;
            Session["image3"] = ssss1;
            Image3.ImageUrl = ssss1;
        }
        else
        {

            string filename = Path.GetFileName(FileUpload3.PostedFile.FileName);
            //Save images into SlideImages folder
            FileUpload3.SaveAs(Server.MapPath("~/User/proimage/" + filePath));
            //Open the database connection

            string ssss = "~/User/proimage" + "/" + filename;
            Session["image3"] = ssss;
            Image3.ImageUrl = ssss;
        }
    }
    protected void Dropstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = ob.dttt("select distinct districtname  from pincode where statename='" + Dropstate.SelectedItem.Text + "' order by districtname ASC");
            Dropcity.DataSource = dt;
            Dropcity.DataTextField = "districtname";
            Dropcity.DataBind();
            Dropcity.Items.Insert(0, "Select City");
        }
        catch { }
    }
    //protected void txtpan_TextChanged(object sender, EventArgs e)
    //{
    //    if (txtpan.Text != null)
    //    {
    //        try
    //        {
    //            SqlDataReader dr = ob.drrr("select * from register where pan='"+txtpan.Text+"'");
    //            if (dr.Read())
    //            {
    //                dr.Close();
    //                lblpan.Visible = true;
    //                lblpan.Text = "This Pan No Already Register With Another User Id";
    //                txtpan.Text = "";
    //            }
    //            else
    //            {
    //                dr.Close();
    //                if (txtpan.Text.Length < 10)
    //                {
    //                    lblpan.Visible = true;
    //                    lblpan.Text = "Invalid Pan No, Please Enter Correct Pan No.";
    //                    txtpan.Text = "";
    //                }
    //                if (txtpan.Text.Length > 10)
    //                {
    //                    lblpan.Visible = true;
    //                    lblpan.Text = "Invalid Pan No, Please Enter Correct Pan No.";
    //                    txtpan.Text = "";
    //                }
    //                if (txtpan.Text.Length == 10)
    //                {
    //                    lblpan.Visible = false;
    //                }
    //            }
    //        }
    //        catch { }
    //    }
    //}
}