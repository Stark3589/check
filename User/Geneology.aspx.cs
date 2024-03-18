using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class nUser_geneology : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {



        if (!IsPostBack)
        {
            ob.Execute("delete from total_active");
            ob.Execute("insert into total_active (username) select reff from binary");
            ob.Execute("update total_active set leftcount='0',rightcount='0'");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 0;
            ob.Execute("exec activ");
            //Session["ab"] = Session["id"].ToString();
            //Session["ab"] = Session["newuser"].ToString();
            Session["ab"] = "NSI100000";
            show(Session["ab"].ToString());
        }


    }
    public string name(string str)
    {



        try
        {
            // DataTable dt = ob.dttt("select name from register where username='" + str + "'");
            //string a = (dt.Rows[0][0].ToString().ToUpper());
            string a = "";
            return a;
        }
        catch (Exception) { return null; }
    }
    public void show(string str)
    {
        if (str == "")
        {
            Response.Redirect("Register.aspx");
        }
        Label2.Text = "";

        Label4.Text = "";
        Label5.Text = "";

        Label6.Text = "";

        Label7.Text = "";

        Label8.Text = "";
        Label30.Text = "";

        Label36.Text = "";
        Label39.Text = "";

        Label45.Text = "";

        Label57.Text = "";

        Label63.Text = "";
        Label71.Text = "";
        Label72.Text = "";
        Label73.Text = "";
        Label74.Text = "";
        Label75.Text = "";
        Label76.Text = "";
        Label77.Text = "";
        Label78.Text = "";
        Label79.Text = "";
        Label80.Text = "";
        Label81.Text = "";
        Label82.Text = "";
        Label83.Text = "";
        Label84.Text = "";
        Label85.Text = "";
        Label86.Text = "";

        DataTable dtdetail = ob.dttt("select reffid,reffname,onside,dateofjoin from register where username='" + str + "'");

        DataTable dt = ob.dttt("select l,r,m from binary where reff='" + str + "'");


        try
        {


            Label1.Text = str;
            string n = name(str);
            Label27.Text = n;

            Label2.Text = dt.Rows[0][0].ToString();

            if (Label2.Text == "0")
            {

                Label2.Text = "";
                Label4.Text = "";
                Label5.Text = "";
            }
            if (Label2.Text != "0")
            {
                string n2 = name(Label2.Text);
                Label30.Text = n2;
                DataTable dtl2 = ob.dttt("select l,r,m from binary where reff='" + Label2.Text + "'");
                Label5.Text = dtl2.Rows[0][0].ToString();
                Label6.Text = dtl2.Rows[0][1].ToString();

                string n5 = name(Label5.Text);
                Label39.Text = n5;

                string n7 = name(Label6.Text);
                Label45.Text = n7;
            }
        }
        catch (IndexOutOfRangeException mj) { };


        try
        {




            if (Label5.Text == "0")
            {

                Label5.Text = "";
                Label71.Text = "";
                Label73.Text = "";
            }
            if (Label5.Text != "0" && Label5.Text != "")
            {

                DataTable dtl2 = ob.dttt("select l,r,m from binary where reff='" + Label5.Text + "'");
                Label71.Text = dtl2.Rows[0][0].ToString();
                Label73.Text = dtl2.Rows[0][1].ToString();

                string n5 = name(Label71.Text);
                Label72.Text = n5;
                if (Label71.Text != "0")
                {
                    ImageButton12.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label71.Text = "";
                }
                string n7 = name(Label73.Text);
                Label74.Text = n7;
                if (Label73.Text != "0")
                {
                    ImageButton13.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label74.Text = "";
                }
            }
        }
        catch (IndexOutOfRangeException mj) { };



        try
        {




            if (Label6.Text == "0")
            {

                Label6.Text = "";
                Label75.Text = "";
                Label77.Text = "";
            }
            if (Label6.Text != "0" && Label6.Text != "")
            {

                DataTable dtl2 = ob.dttt("select l,r,m from binary where reff='" + Label6.Text + "'");
                Label75.Text = dtl2.Rows[0][0].ToString();
                Label77.Text = dtl2.Rows[0][1].ToString();

                string n5 = name(Label75.Text);
                Label76.Text = n5;
                if (Label75.Text != "0")
                {
                    ImageButton14.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label75.Text = "";
                }
                string n7 = name(Label77.Text);
                Label78.Text = n7;
                if (Label77.Text != "0")
                {
                    ImageButton15.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label77.Text = "";
                }
            }
        }
        catch (IndexOutOfRangeException mj) { };

        try
        {

            Label4.Text = dt.Rows[0][1].ToString();

            if (Label4.Text == "0")
            {

                Label4.Text = "";
                Label7.Text = "";
                Label8.Text = "";

            }
            if (Label4.Text != "0")
            {
                string n4 = name(Label4.Text);
                Label36.Text = n4;

                DataTable dtl2 = ob.dttt("select l,r,m from binary where reff='" + Label4.Text + "'");
                Label7.Text = dtl2.Rows[0][0].ToString();
                Label8.Text = dtl2.Rows[0][1].ToString();

                string n7 = name(Label7.Text);
                Label57.Text = n7;

                string n9 = name(Label8.Text);
                Label63.Text = n9;
            }


        }
        catch (Exception) { }

        try
        {




            if (Label7.Text == "0")
            {

                Label7.Text = "";
                Label79.Text = "";
                Label81.Text = "";
            }
            if (Label7.Text != "0" && Label7.Text != "")
            {

                DataTable dtl2 = ob.dttt("select l,r,m from binary where reff='" + Label7.Text + "'");
                Label79.Text = dtl2.Rows[0][0].ToString();
                Label81.Text = dtl2.Rows[0][1].ToString();

                string n5 = name(Label79.Text);
                Label80.Text = n5;
                if (Label79.Text != "0")
                {
                    ImageButton16.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label79.Text = "";
                }
                string n7 = name(Label81.Text);
                Label82.Text = n7;
                if (Label81.Text != "0")
                {
                    ImageButton17.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label82.Text = "";
                }
            }
        }
        catch (IndexOutOfRangeException mj) { };

        try
        {




            if (Label8.Text == "0")
            {

                Label8.Text = "";
                Label83.Text = "";
                Label85.Text = "";
            }
            if (Label8.Text != "0" && Label8.Text != "")
            {

                DataTable dtl2 = ob.dttt("select l,r,m from binary where reff='" + Label8.Text + "'");
                Label83.Text = dtl2.Rows[0][0].ToString();
                Label85.Text = dtl2.Rows[0][1].ToString();

                string n5 = name(Label83.Text);
                Label84.Text = n5;
                if (Label83.Text != "0")
                {
                    ImageButton18.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label83.Text = "";
                }
                string n7 = name(Label85.Text);
                Label86.Text = n7;
                if (Label85.Text != "0")
                {
                    ImageButton19.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label85.Text = "";
                }
            }
        }
        catch (IndexOutOfRangeException mj) { };




        try
        {

            //Label3.Text = dt.Rows[0][2].ToString();

            //if (Label3.Text == "0")
            //{

            //    Label10.Text = "";
            //    Label11.Text = "";
            //    Label12.Text = "";

            //}
            //if (Label3.Text != "0")
            //{
            //    string n4 = name(Label3.Text);
            //    Label33.Text = n4;

            //    DataTable dtl2 = ob.dttt("select l,r,m from binary where reff='" + Label3.Text + "'");
            //    Label10.Text = dtl2.Rows[0][0].ToString();
            //    Label11.Text = dtl2.Rows[0][2].ToString();
            //    Label12.Text = dtl2.Rows[0][1].ToString();
            //    string n7 = name(Label10.Text);
            //    Label48.Text = n7;
            //    string n8 = name(Label11.Text);
            //    Label51.Text = n8;
            //    string n9 = name(Label12.Text);
            //    Label54.Text = n9;
            //}

            color();
            popup();
        }
        catch (Exception) { color(); popup(); }



    }
    public void color()
    {
        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label1.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label27.ForeColor = System.Drawing.Color.Green;
                ImageButton1.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label27.ForeColor = System.Drawing.Color.Green;
                ImageButton1.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { }
        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label2.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label30.ForeColor = System.Drawing.Color.Green;
                ImageButton3.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label30.ForeColor = System.Drawing.Color.Green;
                ImageButton3.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton3.ImageUrl = "~/photos/black.png"; Label2.Text = ""; }
        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label4.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label36.ForeColor = System.Drawing.Color.Green;
                ImageButton4.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label36.ForeColor = System.Drawing.Color.Green;
                ImageButton4.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton4.ImageUrl = "~/photos/black.png"; Label4.Text = ""; }
        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label5.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label39.ForeColor = System.Drawing.Color.Green;
                ImageButton5.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label39.ForeColor = System.Drawing.Color.Green;
                ImageButton5.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton5.ImageUrl = "~/photos/black.png"; Label5.Text = ""; }
        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label6.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label45.ForeColor = System.Drawing.Color.Green;
                ImageButton8.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label45.ForeColor = System.Drawing.Color.Green;
                ImageButton8.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton8.ImageUrl = "~/photos/black.png"; Label6.Text = ""; }
        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label7.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label57.ForeColor = System.Drawing.Color.Green;
                ImageButton11.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label57.ForeColor = System.Drawing.Color.Green;
                ImageButton11.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton11.ImageUrl = "~/photos/black.png"; Label7.Text = ""; }
        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label8.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label63.ForeColor = System.Drawing.Color.Green;
                ImageButton9.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label63.ForeColor = System.Drawing.Color.Green;
                ImageButton9.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton9.ImageUrl = "~/photos/black.png"; Label8.Text = ""; }



        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label71.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label72.ForeColor = System.Drawing.Color.Green;
                ImageButton12.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label72.ForeColor = System.Drawing.Color.Green;
                ImageButton12.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton12.ImageUrl = "~/photos/black.png"; Label71.Text = ""; }

        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label73.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label74.ForeColor = System.Drawing.Color.Green;
                ImageButton13.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label74.ForeColor = System.Drawing.Color.Green;
                ImageButton13.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton13.ImageUrl = "~/photos/black.png"; Label73.Text = ""; }

        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label75.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label76.ForeColor = System.Drawing.Color.Green;
                ImageButton14.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label76.ForeColor = System.Drawing.Color.Green;
                ImageButton14.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton14.ImageUrl = "~/photos/black.png"; Label75.Text = ""; }

        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label77.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label78.ForeColor = System.Drawing.Color.Green;
                ImageButton15.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label78.ForeColor = System.Drawing.Color.Green;
                ImageButton15.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton15.ImageUrl = "~/photos/black.png"; Label77.Text = ""; }

        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label79.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label80.ForeColor = System.Drawing.Color.Green;
                ImageButton16.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label80.ForeColor = System.Drawing.Color.Green;
                ImageButton16.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton16.ImageUrl = "~/photos/black.png"; Label79.Text = ""; }

        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label81.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label82.ForeColor = System.Drawing.Color.Green;
                ImageButton17.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label82.ForeColor = System.Drawing.Color.Green;
                ImageButton17.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton17.ImageUrl = "~/photos/black.png"; Label81.Text = ""; }

        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label83.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label84.ForeColor = System.Drawing.Color.Green;
                ImageButton18.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label84.ForeColor = System.Drawing.Color.Green;
                ImageButton18.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton18.ImageUrl = "~/photos/black.png"; Label83.Text = ""; }

        try
        {

            DataTable dt = ob.dttt("select status from register where username='" + Label85.Text + "'");
            if (dt.Rows[0][0].ToString() == "Active")
            {
                Label86.ForeColor = System.Drawing.Color.Green;
                ImageButton19.ImageUrl = "~/photos/G.png";
            }
            else
            {
                Label86.ForeColor = System.Drawing.Color.Green;
                ImageButton19.ImageUrl = "~/photos/waiting.png";
            }

        }
        catch (Exception) { ImageButton19.ImageUrl = "~/photos/black.png"; Label85.Text = ""; }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            show(Label1.Text);
        }
        catch (Exception) { }
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label1.Text;
            Session["side"] = "left";
            show(Label2.Text);
        }
        catch (Exception)
        {

            Response.Redirect("Register.aspx");
        }
    }
    //protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    //{
    //    show(Label3.Text);
    //}
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label1.Text;
            Session["side"] = "right";
            show(Label4.Text);
        }
        catch (Exception)
        {

            Response.Redirect("Register.aspx");
        }
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label2.Text;
            Session["side"] = "left";
            show(Label5.Text);
        }
        catch (Exception)
        {

            Response.Redirect("Register.aspx");
        }
    }

    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label2.Text;
            Session["side"] = "right";
            show(Label6.Text);
        }
        catch (Exception)
        {

            Response.Redirect("Register.aspx");
        }
    }
    //protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    //{
    //    show(Label10.Text);
    //}
    //protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    //{
    //    show(Label11.Text);
    //}
    //protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    //{
    //    show(Label12.Text);
    //}
    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label4.Text;
            Session["side"] = "left";
            show(Label7.Text);
        }
        catch (Exception)
        {
            Response.Redirect("Register.aspx");
        }
    }

    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label4.Text;
            Session["side"] = "right";
            show(Label8.Text);
        }
        catch (Exception)
        {
            Response.Redirect("Register.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataReader sd = ob.drrr("select * from register where username='" + TextBox1.Text + "'");
        if (sd.Read())
        {
            sd.Close();
            show(TextBox1.Text);
        }
        else
        {
            sd.Close();
            Response.Write("<script>alert('Id Not Found !!')</script>");
        }
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label5.Text;
            Session["side"] = "left";
            show(Label71.Text);
        }
        catch (Exception)
        {
            Response.Redirect("Register.aspx");
        }
    }
    protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label5.Text;
            Session["side"] = "right";
            show(Label73.Text);
        }
        catch (Exception)
        {
            Response.Redirect("Register.aspx");
        }
    }
    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label6.Text;
            Session["side"] = "left";
            show(Label75.Text);
        }
        catch (Exception)
        {
            Response.Redirect("Register.aspx");
        }
    }
    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label6.Text;
            Session["side"] = "right";
            show(Label77.Text);
        }
        catch (Exception) { Response.Redirect("Register.aspx"); }
    }
    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label7.Text;
            Session["side"] = "left";
            show(Label79.Text);
        }
        catch (Exception) { Response.Redirect("Register.aspx"); }
    }
    protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label7.Text;
            Session["side"] = "right";
            show(Label81.Text);
        }
        catch (Exception) { Response.Redirect("Register.aspx"); }
    }
    protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label8.Text;
            Session["side"] = "left";
            show(Label83.Text);
        }
        catch (Exception) { Response.Redirect("Register.aspx"); }
    }
    protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["upline"] = Label8.Text;
            Session["side"] = "right";
            show(Label85.Text);
        }
        catch (Exception) { Response.Redirect("Register.aspx"); }
    }
    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    SqlDataReader sd = ob.drrr("select * from register where username='" + TextBox1.Text + "'");
    //    if (sd.Read())
    //    {
    //        sd.Close();
    //        show(TextBox1.Text);
    //    }
    //    else
    //    {
    //        sd.Close();
    //        Response.Write("<script>alert('Id Not Found !!')</script>");
    //    }
    //}

   
    public void popup()
    {
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label1.Text + "'");
            t11.Text = dt.Rows[0][0].ToString();
            t12.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t13.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label1.Text + "'");
            t14.Text = dt.Rows[0][0].ToString();
            t15.Text = dt.Rows[0][1].ToString();

           
        }
        catch (Exception) { }
         try
            {
             DataTable gg=ob.dttt("select amount from pinmgt where reguser='"+Label1.Text+"'");
             c1.Text = gg.Rows[0][0].ToString();
            }
         catch (Exception jk) { c1.Text = "Not Active"; };
         try
         {
             DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label1.Text + "'");
             d1.Text = dt.Rows[0][0].ToString();
             d2.Text = dt.Rows[0][1].ToString();
         }catch(Exception jh){};
         try
         {
             DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label2.Text + "'");
             d3.Text = dt.Rows[0][0].ToString();
             d4.Text = dt.Rows[0][1].ToString();
         }
         catch (Exception jh) { };

        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label2.Text + "'");
            c2.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c2.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label2.Text + "'");
            t21.Text = dt.Rows[0][0].ToString();
            t22.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t23.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label2.Text + "'");
            t24.Text = dt.Rows[0][0].ToString();
            t25.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t21.Text = "XXXX";
            t22.Text = "XXXX";
            t23.Text = "XXXX";
            t24.Text = "XXXX";
            t25.Text = "XXXX";
        }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label4.Text + "'");
            d5.Text = dt.Rows[0][0].ToString();
            d6.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label4.Text + "'");
            c3.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c3.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label4.Text + "'");
            t31.Text = dt.Rows[0][0].ToString();
            t32.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t33.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label4.Text + "'");
            t34.Text = dt.Rows[0][0].ToString();
            t35.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t31.Text = "XXXX";
            t32.Text = "XXXX";
            t33.Text = "XXXX";
            t34.Text = "XXXX";
            t35.Text = "XXXX";
        }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label5.Text + "'");
            d7.Text = dt.Rows[0][0].ToString();
            d8.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label5.Text + "'");
            c4.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c4.Text = "Not Active"; };
        //4
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label5.Text + "'");
            t41.Text = dt.Rows[0][0].ToString();
            t42.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t43.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label5.Text + "'");
            t44.Text = dt.Rows[0][0].ToString();
            t45.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t41.Text = "XXXX";
            t42.Text = "XXXX";
            t43.Text = "XXXX";
            t44.Text = "XXXX";
            t45.Text = "XXXX";
        }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label6.Text + "'");
            d9.Text = dt.Rows[0][0].ToString();
            d10.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        //5
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label6.Text + "'");
            c5.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c5.Text = "Not Active"; };

        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label6.Text + "'");
            t51.Text = dt.Rows[0][0].ToString();
            t52.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t53.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label6.Text + "'");
            t54.Text = dt.Rows[0][0].ToString();
            t55.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t51.Text = "XXXX";
            t52.Text = "XXXX";
            t53.Text = "XXXX";
            t54.Text = "XXXX";
            t55.Text = "XXXX";
        }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label7.Text + "'");
            d11.Text = dt.Rows[0][0].ToString();
            d12.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        //6
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label7.Text + "'");
            c6.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c6.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label7.Text + "'");
            t61.Text = dt.Rows[0][0].ToString();
            t62.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t63.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label7.Text + "'");
            t64.Text = dt.Rows[0][0].ToString();
            t65.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t61.Text = "XXXX";
            t62.Text = "XXXX";
            t63.Text = "XXXX";
            t64.Text = "XXXX";
            t65.Text = "XXXX";
        }

        //7
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label8.Text + "'");
            d13.Text = dt.Rows[0][0].ToString();
            d14.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
       
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label8.Text + "'");
            c7.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c7.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label8.Text + "'");
            t71.Text = dt.Rows[0][0].ToString();
            t72.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t73.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label8.Text + "'");
            t74.Text = dt.Rows[0][0].ToString();
            t75.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t71.Text = "XXXX";
            t72.Text = "XXXX";
            t73.Text = "XXXX";
            t74.Text = "XXXX";
            t75.Text = "XXXX";
        }
       
        //8
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label71.Text + "'");
            d15.Text = dt.Rows[0][0].ToString();
            d16.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label71.Text + "'");
            c8.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c8.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label71.Text + "'");
            t81.Text = dt.Rows[0][0].ToString();
            t82.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t83.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label71.Text + "'");
            t84.Text = dt.Rows[0][0].ToString();
            t85.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t81.Text = "XXXX";
            t82.Text = "XXXX";
            t83.Text = "XXXX";
            t84.Text = "XXXX";
            t85.Text = "XXXX";
        }

        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label73.Text + "'");
            d17.Text = dt.Rows[0][0].ToString();
            d18.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        //9
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label73.Text + "'");
            c9.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c9.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label73.Text + "'");
            t91.Text = dt.Rows[0][0].ToString();
            t92.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t93.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label73.Text + "'");
            t94.Text = dt.Rows[0][0].ToString();
            t95.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t91.Text = "XXXX";
            t92.Text = "XXXX";
            t93.Text = "XXXX";
            t94.Text = "XXXX";
            t95.Text = "XXXX";
        }

        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label75.Text + "'");
            d19.Text = dt.Rows[0][0].ToString();
            d20.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        //10
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label75.Text + "'");
            c10.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c10.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label75.Text + "'");
            t101.Text = dt.Rows[0][0].ToString();
            t102.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t103.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label75.Text + "'");
            t104.Text = dt.Rows[0][0].ToString();
            t105.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t101.Text = "XXXX";
            t102.Text = "XXXX";
            t103.Text = "XXXX";
            t104.Text = "XXXX";
            t105.Text = "XXXX";
        }
       
        //11
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label77.Text + "'");
            d21.Text = dt.Rows[0][0].ToString();
            d22.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label77.Text + "'");
            c11.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c11.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label77.Text + "'");
            t111.Text = dt.Rows[0][0].ToString();
            t112.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t113.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label77.Text + "'");
            t114.Text = dt.Rows[0][0].ToString();
            t115.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t111.Text = "XXXX";
            t112.Text = "XXXX";
            t113.Text = "XXXX";
            t114.Text = "XXXX";
            t115.Text = "XXXX";
        }
      
        //12
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label79.Text + "'");
            d23.Text = dt.Rows[0][0].ToString();
            d24.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label79.Text + "'");
            c12.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c12.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label79.Text + "'");
            t121.Text = dt.Rows[0][0].ToString();
            t122.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t123.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label79.Text + "'");
            t124.Text = dt.Rows[0][0].ToString();
            t125.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t121.Text = "XXXX";
            t122.Text = "XXXX";
            t123.Text = "XXXX";
            t124.Text = "XXXX";
            t125.Text = "XXXX";
        }
       
        //13
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label81.Text + "'");
            d25.Text = dt.Rows[0][0].ToString();
            d26.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label81.Text + "'");
            c13.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c13.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label81.Text + "'");
            t131.Text = dt.Rows[0][0].ToString();
            t132.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t133.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label81.Text + "'");
            t134.Text = dt.Rows[0][0].ToString();
            t135.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t131.Text = "XXXX";
            t132.Text = "XXXX";
            t133.Text = "XXXX";
            t134.Text = "XXXX";
            t135.Text = "XXXX";
        }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label83.Text + "'");
            d27.Text = dt.Rows[0][0].ToString();
            d28.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        //14
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label83.Text + "'");
            c14.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c14.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label83.Text + "'");
            t141.Text = dt.Rows[0][0].ToString();
            t142.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t143.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label83.Text + "'");
            t144.Text = dt.Rows[0][0].ToString();
            t145.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t141.Text = "XXXX";
            t142.Text = "XXXX";
            t143.Text = "XXXX";
            t144.Text = "XXXX";
            t145.Text = "XXXX";
        }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_active where username='" + Label85.Text + "'");
            d29.Text = dt.Rows[0][0].ToString();
            d30.Text = dt.Rows[0][1].ToString();
        }
        catch (Exception jh) { };
        //15
       
        try
        {
            DataTable gg = ob.dttt("select amount from pinmgt where reguser='" + Label85.Text + "'");
            c15.Text = gg.Rows[0][0].ToString();
        }
        catch (Exception jk) { c15.Text = "Not Active"; };
        try
        {
            DataTable dt = ob.dttt("select name,dateofjoin,mobile,rtime from register where username='" + Label85.Text + "'");
            t151.Text = dt.Rows[0][0].ToString();
            t152.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t153.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_binarycount where username='" + Label85.Text + "'");
            t154.Text = dt.Rows[0][0].ToString();
            t155.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception)
        {
            t151.Text = "XXXX";
            t152.Text = "XXXX";
            t153.Text = "XXXX";
            t154.Text = "XXXX";
            t155.Text = "XXXX";
        }
       

    }
    public void active(string str)
    {
        Session["nuser"] = str;
        try
        {
            ob.Execute("drop table neww1");
        }
        catch { }
        ob.Execute("create table neww1 (agent nvarchar(max)) ");

        DataTable dt4 = ob.dttt("select status from register where  username='" + Session["nuser"].ToString() + "'");
        string stst = dt4.Rows[0][0].ToString();


        ob.Execute("insert into neww1 values('" + Session["newuser"].ToString() + "')");
        for (int i = 0; i > -1; i++)
        {
            try
            {
                DataTable dt = ob.dttt("select agent from neww1 ");
                ob.Execute("insert into neww1 select l from binary where reff='" + dt.Rows[i][0].ToString() + "'");
                ob.Execute("insert into neww1 select r from binary where reff='" + dt.Rows[i][0].ToString() + "'");

            }
            catch (Exception) { i = -2; };
        }
        ob.Execute("delete from neww1 where agent='" + Session["nuser"].ToString() + "'");
        DataTable dt2 = ob.dttt("select count(a.username) from register a join total_binarycount c on a.username=c.username and a.status='Active' join new on neww1.agent=a.username ");
        d1.Text = dt2.Rows[0][0].ToString();
        
        try
        {
            ob.Execute("drop table neww1");
        }
        catch { }
    }
}