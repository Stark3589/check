using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class User_franchise_addfranchise : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            genratepassword();
            loaduserid();
            date.Text = System.DateTime.UtcNow.ToString("yyyy-MM-dd");
        }
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            if (drpfran.SelectedItem.Text != "SELECT FRANCHISE")
            {
                SqlDataReader da = ob.drrr("select username from franchisereg where username='" + txtusername.Text + "'");
                if (da.Read())
                {
                    da.Close();
                    Response.Write("<script>alert('Username Already Exists...')</script>");
                }

                else
                {
                    da.Close();

                    string query = "insert into franchisereg (package,username,name,password,mobile,adharno,branch,dateofjoin,status)values('" + drpfran.SelectedItem.Text + "','" + txtusername.Text + "','" + txtname.Text + "','" + txtpass.Text + "','" + txtmob.Text + "','" + txtadhr.Text + "','" + txtbranch.Text + "','" + date.Text + "','Open')";
                    ob.Execute(query);

                    try
                    {
                        int codde = Convert.ToInt32(code1) + 1;
                        ob.Execute("update tle_cd_dy set fcode='" + codde.ToString() + "'");
                    }
                    catch (Exception ex) { }
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('INSERTED SUCCESSFULLY');window.location='addfranchise.aspx';", true);
                }
            }
            else
            {
                Response.Write("<script>alert('Firstly Select the Franchise')</script>");
            }
           
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Something Went Wrong')</script>");
        }
  
    }
    private void genratepassword()
    {
        try
        {


            var chars = "0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int ik = 0; ik < stringChars.Length; ik++)
            {
                stringChars[ik] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            string capta = Convert.ToString(finalString);
          //  pass = capta;
            txtpass.Text = capta;

        }
        catch (Exception ex) { }
    }
 static   string code1 = "";
    private void loaduserid()
    {

         string invoice = "";
         try
         {
             string str = "select fcode from tle_cd_dy ";
             DataTable dt1 = ob.dttt(str);
             if (dt1.Rows.Count > 0)
             {
                  code1 = dt1.Rows[0]["fcode"].ToString();

                 int aco = Convert.ToInt32(code1.Length.ToString());
                 //if (aco == 1)
                 //{
                     invoice = "MB" + "2020" + code1;
                 //}
                 //if (aco == 2)
                 //{
                 //    invoice = "GSF" + "2020" + code1;
                 //}
                 //if (aco == 3)
                 //{
                 //    invoice = "GSF" + "2020" + code1;
                 //}
                 //if (aco == 4)
                 //{
                 //    invoice = "GSF" + "2020" + code1;
                 //}
                 txtusername.Text = invoice;
             }
         }
         catch (Exception ex) { }


       
    }

}