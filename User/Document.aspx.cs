using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class User_Document : System.Web.UI.Page
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
        }
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = ob.dttt("select image,sign,thumb,idproof,addproof,passbook,pancard from images where username='" + DropDownList1.SelectedItem.Text + "'");
            Image1.ImageUrl = dt.Rows[0][0].ToString();
            Image2.ImageUrl = dt.Rows[0][3].ToString();
            Image3.ImageUrl = dt.Rows[0][4].ToString();
            Image4.ImageUrl = dt.Rows[0][5].ToString();
            Image5.ImageUrl = dt.Rows[0][6].ToString();
            Image6.ImageUrl = dt.Rows[0][2].ToString();
            Image7.ImageUrl = dt.Rows[0][1].ToString();
            Panel1.Visible = true;
        }
        catch (Exception) { }
    }
    protected void Button1_Click(object sender, EventArgs e)
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
                try
                {
                    // string ssss = "~/User/proimage" + "/" + filename;
                    string ssss1 = "~/User/proimage" + "/" + newPath;
                    Session["image1"] = ssss1;
                    ob.Execute("update images set image='" + ssss1 + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image1.ImageUrl = ssss1;
                }
                catch (Exception) { }
            }
            else
            {

                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);

                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload1.SaveAs(Server.MapPath("~/User/proimage/" + filename));
                //Open the database connection
                try
                {
                    string ssss = "~/User/proimage" + "/" + filename;

                    Session["image1"] = ssss;
                    ob.Execute("update images set image='" + ssss + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image1.ImageUrl = ssss;
                }
                catch (Exception) { }
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if ((FileUpload2.PostedFile != null) && (FileUpload2.PostedFile.ContentLength > 0))
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
                try
                {
                    // string ssss = "~/User/proimage" + "/" + filename;
                    string ssss1 = "~/User/proimage" + "/" + newPath;
                    Session["image1"] = ssss1;
                    ob.Execute("update images set idproof='" + ssss1 + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image2.ImageUrl = ssss1;
                }
                catch (Exception) { }
            }
            else
            {

                string filename = Path.GetFileName(FileUpload2.PostedFile.FileName);

                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload2.SaveAs(Server.MapPath("~/User/proimage/" + filename));
                //Open the database connection
                try
                {
                    string ssss = "~/User/proimage" + "/" + filename;

                    Session["image1"] = ssss;
                    ob.Execute("update images set idproof='" + ssss + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image2.ImageUrl = ssss;
                }
                catch (Exception) { }
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if ((FileUpload3.PostedFile != null) && (FileUpload3.PostedFile.ContentLength > 0))
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
                try
                {
                    // string ssss = "~/User/proimage" + "/" + filename;
                    string ssss1 = "~/User/proimage" + "/" + newPath;
                    Session["image1"] = ssss1;
                    ob.Execute("update images set addproof='" + ssss1 + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image3.ImageUrl = ssss1;
                }
                catch (Exception) { }
            }
            else
            {

                string filename = Path.GetFileName(FileUpload3.PostedFile.FileName);

                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload3.SaveAs(Server.MapPath("~/User/proimage/" + filename));
                //Open the database connection
                try
                {
                    string ssss = "~/User/proimage" + "/" + filename;

                    Session["image1"] = ssss;
                    ob.Execute("update images set addproof='" + ssss + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image3.ImageUrl = ssss;
                }
                catch (Exception) { }
            }
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if ((FileUpload4.PostedFile != null) && (FileUpload4.PostedFile.ContentLength > 0))
        {
            string filePath = FileUpload4.FileName;

            string st = Server.MapPath("~/User/proimage/" + filePath);
            FileInfo file = new FileInfo(st);
            if (file.Exists)
            {
                string filename = Path.GetFileName(FileUpload4.PostedFile.FileName);
                string strDate = filename; //Format – dd/MM/yyyy
                //split string date by separator, here I'm using '/'
                string[] arrDate = strDate.Split('.');
                //now use array to get specific date object
                string a = arrDate[0].ToString();
                string b = arrDate[1].ToString();
                var newPath = a + DateTime.Now.ToString("yyyymmddMMss") + "." + b;
                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload4.SaveAs(Server.MapPath("~/User/proimage/" + newPath));
                //Open the database connection
                try
                {
                    // string ssss = "~/User/proimage" + "/" + filename;
                    string ssss1 = "~/User/proimage" + "/" + newPath;
                    Session["image1"] = ssss1;
                    ob.Execute("update images set passbook='" + ssss1 + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image4.ImageUrl = ssss1;
                }
                catch (Exception) { }
            }
            else
            {

                string filename = Path.GetFileName(FileUpload4.PostedFile.FileName);

                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload4.SaveAs(Server.MapPath("~/User/proimage/" + filename));
                //Open the database connection
                try
                {
                    string ssss = "~/User/proimage" + "/" + filename;

                    Session["image1"] = ssss;
                    ob.Execute("update images set passbook='" + ssss + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image4.ImageUrl = ssss;
                }
                catch (Exception) { }
            }
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        if ((FileUpload5.PostedFile != null) && (FileUpload5.PostedFile.ContentLength > 0))
        {
            string filePath = FileUpload5.FileName;

            string st = Server.MapPath("~/User/proimage/" + filePath);
            FileInfo file = new FileInfo(st);
            if (file.Exists)
            {
                string filename = Path.GetFileName(FileUpload5.PostedFile.FileName);
                string strDate = filename; //Format – dd/MM/yyyy
                //split string date by separator, here I'm using '/'
                string[] arrDate = strDate.Split('.');
                //now use array to get specific date object
                string a = arrDate[0].ToString();
                string b = arrDate[1].ToString();
                var newPath = a + DateTime.Now.ToString("yyyymmddMMss") + "." + b;
                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload5.SaveAs(Server.MapPath("~/User/proimage/" + newPath));
                //Open the database connection
                try
                {
                    // string ssss = "~/User/proimage" + "/" + filename;
                    string ssss1 = "~/User/proimage" + "/" + newPath;
                    Session["image1"] = ssss1;
                    ob.Execute("update images set pancard='" + ssss1 + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image5.ImageUrl = ssss1;
                }
                catch (Exception) { }
            }
            else
            {

                string filename = Path.GetFileName(FileUpload5.PostedFile.FileName);

                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload5.SaveAs(Server.MapPath("~/User/proimage/" + filename));
                //Open the database connection
                try
                {
                    string ssss = "~/User/proimage" + "/" + filename;

                    Session["image1"] = ssss;
                    ob.Execute("update images set pancard='" + ssss + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image5.ImageUrl = ssss;
                }
                catch (Exception) { }
            }
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        if ((FileUpload6.PostedFile != null) && (FileUpload6.PostedFile.ContentLength > 0))
        {
            string filePath = FileUpload6.FileName;

            string st = Server.MapPath("~/User/proimage/" + filePath);
            FileInfo file = new FileInfo(st);
            if (file.Exists)
            {
                string filename = Path.GetFileName(FileUpload6.PostedFile.FileName);
                string strDate = filename; //Format – dd/MM/yyyy
                //split string date by separator, here I'm using '/'
                string[] arrDate = strDate.Split('.');
                //now use array to get specific date object
                string a = arrDate[0].ToString();
                string b = arrDate[1].ToString();
                var newPath = a + DateTime.Now.ToString("yyyymmddMMss") + "." + b;
                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload6.SaveAs(Server.MapPath("~/User/proimage/" + newPath));
                //Open the database connection
                try
                {
                    // string ssss = "~/User/proimage" + "/" + filename;
                    string ssss1 = "~/User/proimage" + "/" + newPath;
                    Session["image1"] = ssss1;
                    ob.Execute("update images set thumb='" + ssss1 + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image6.ImageUrl = ssss1;
                }
                catch (Exception) { }
            }
            else
            {

                string filename = Path.GetFileName(FileUpload6.PostedFile.FileName);

                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload6.SaveAs(Server.MapPath("~/User/proimage/" + filename));
                //Open the database connection
                try
                {
                    string ssss = "~/User/proimage" + "/" + filename;

                    Session["image1"] = ssss;
                    ob.Execute("update images set thumb='" + ssss + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image6.ImageUrl = ssss;
                }
                catch (Exception) { }
            }
        }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        if ((FileUpload7.PostedFile != null) && (FileUpload7.PostedFile.ContentLength > 0))
        {
            string filePath = FileUpload7.FileName;

            string st = Server.MapPath("~/User/proimage/" + filePath);
            FileInfo file = new FileInfo(st);
            if (file.Exists)
            {
                string filename = Path.GetFileName(FileUpload7.PostedFile.FileName);
                string strDate = filename; //Format – dd/MM/yyyy
                //split string date by separator, here I'm using '/'
                string[] arrDate = strDate.Split('.');
                //now use array to get specific date object
                string a = arrDate[0].ToString();
                string b = arrDate[1].ToString();
                var newPath = a + DateTime.Now.ToString("yyyymmddMMss") + "." + b;
                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload7.SaveAs(Server.MapPath("~/User/proimage/" + newPath));
                //Open the database connection
                try
                {
                    // string ssss = "~/User/proimage" + "/" + filename;
                    string ssss1 = "~/User/proimage" + "/" + newPath;
                    Session["image1"] = ssss1;
                    ob.Execute("update images set sign='" + ssss1 + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image7.ImageUrl = ssss1;
                }
                catch (Exception) { }
            }
            else
            {

                string filename = Path.GetFileName(FileUpload7.PostedFile.FileName);

                //  string filename = Path.GetFileName(FileUpload1.FileName);
                //Save images into SlideImages folder
                FileUpload7.SaveAs(Server.MapPath("~/User/proimage/" + filename));
                //Open the database connection
                try
                {
                    string ssss = "~/User/proimage" + "/" + filename;

                    Session["image1"] = ssss;
                    ob.Execute("update images set sign='" + ssss + "' where username='" + DropDownList1.SelectedItem.Text + "'");
                    Image7.ImageUrl = ssss;
                }
                catch (Exception) { }
            }
        }
    }
}