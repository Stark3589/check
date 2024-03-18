using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_Default3 : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {



        if (!IsPostBack)
        {
            //Session["ab"] = Session["id"].ToString();
            Session["ab"] = "NSI20170000001";
            show(Session["ab"].ToString());
        }

        popup();
    }
    public string name(string str)
    {



        try
        {
            //DataTable dt = ob.dttt("select name from register where username='" + str + "'");
            //string a = dt.Rows[0][0].ToString();
            string a = "";
            return a;
        }
        catch (Exception) { return null; }
    }
    public void show(string str)
    {
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

        DataTable dt = ob.dttt("select l,r,m from binaryfull where reff='" + str + "'");
        DataTable dtsp = ob.dttt("select l,r,m from sponsercountfull where sponser='" + str + "'");


        try
        {


            Label1.Text = str;
            string n = name(str);
            Label27.Text = n;
            ImageButton1.ImageUrl = "~/photos/G.png";
            Label2.Text = dt.Rows[0][0].ToString();

            if (Label2.Text == "0")
            {

                Label2.Text = "";
                Label4.Text = "";
                Label5.Text = "";
            }
            if (Label2.Text != "0" && Label2.Text != "")
            {
                ImageButton3.ImageUrl = "~/photos/G.png";
                string n2 = name(Label2.Text);
                Label30.Text = n2;
                DataTable dtl2 = ob.dttt("select l,r,m from binaryfull where reff='" + Label2.Text + "'");
                Label5.Text = dtl2.Rows[0][0].ToString();
                Label6.Text = dtl2.Rows[0][1].ToString();

                string n5 = name(Label5.Text);
                Label39.Text = n5;
                if (Label5.Text != "0")
                {
                    ImageButton5.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label5.Text = "";
                }
                string n7 = name(Label6.Text);
                Label45.Text = n7;
                if (Label6.Text != "0")
                {
                    ImageButton8.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label6.Text = "";
                }
            }
        }
        catch (IndexOutOfRangeException mj) { };


        //new khj
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

                DataTable dtl2 = ob.dttt("select l,r,m from binaryfull where reff='" + Label5.Text + "'");
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

                DataTable dtl2 = ob.dttt("select l,r,m from binaryfull where reff='" + Label6.Text + "'");
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
            if (Label4.Text != "0" && Label4.Text != "")
            {
                string n4 = name(Label4.Text);
                Label36.Text = n4;
                ImageButton4.ImageUrl = "~/photos/G.png";
                DataTable dtl2 = ob.dttt("select l,r,m from binaryfull where reff='" + Label4.Text + "'");
                Label7.Text = dtl2.Rows[0][0].ToString();
                Label8.Text = dtl2.Rows[0][1].ToString();

                string n7 = name(Label7.Text);
                Label57.Text = n7;
                if (Label7.Text != "0")
                {
                    ImageButton11.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label7.Text = "";
                }

                string n9 = name(Label8.Text);
                Label63.Text = n9;
                if (Label8.Text != "0")
                {
                    ImageButton9.ImageUrl = "~/photos/G.png";

                }
                else
                {
                    Label8.Text = "";
                }
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

                DataTable dtl2 = ob.dttt("select l,r,m from binaryfull where reff='" + Label7.Text + "'");
                Label79.Text = dtl2.Rows[0][0].ToString();
                Label80.Text = dtl2.Rows[0][1].ToString();

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

                DataTable dtl2 = ob.dttt("select l,r,m from binaryfull where reff='" + Label8.Text + "'");
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

            //    DataTable dtl2 = ob.dttt("select l,r,m from binaryfull where reff='" + Label3.Text + "'");
            //    Label10.Text = dtl2.Rows[0][0].ToString();
            //    Label11.Text = dtl2.Rows[0][2].ToString();
            //    Label12.Text = dtl2.Rows[0][1].ToString();
            //    string n7 = name(Label10.Text);
            //    Label48.Text = n7;
            //    string n8 = name(Label11.Text);
            //    Label51.Text = n8;
            //    string n9 = name(Label12.Text);
            //    Label54.Text = n9;
            //  }

            color();
        }
        catch (Exception) { color(); }



    }
    public void color()
    {
        try
        {


            if (Label1.Text == "" || Label1.Text == "0")
            {
                Label27.ForeColor = System.Drawing.Color.Green;
                ImageButton1.ImageUrl = "~/photos/black.png";
                Label1.Text = "";
            }
            if (Label2.Text == "" || Label2.Text == "0")
            {
                Label30.ForeColor = System.Drawing.Color.Green;
                ImageButton3.ImageUrl = "~/photos/black.png";
                Label2.Text = "";
            }
            if (Label4.Text == "" || Label4.Text == "0")
            {
                Label36.ForeColor = System.Drawing.Color.Green;
                ImageButton4.ImageUrl = "~/photos/black.png";
                Label4.Text = "";
            }
            if (Label5.Text == "" || Label5.Text == "0")
            {
                Label39.ForeColor = System.Drawing.Color.Green;
                ImageButton5.ImageUrl = "~/photos/black.png";
                Label5.Text = "";
            }
            if (Label6.Text == "" || Label6.Text == "0")
            {
                Label45.ForeColor = System.Drawing.Color.Green;
                ImageButton8.ImageUrl = "~/photos/black.png";
                Label6.Text = "";
            }
            if (Label7.Text == "" || Label7.Text == "0")
            {
                Label57.ForeColor = System.Drawing.Color.Green;
                ImageButton11.ImageUrl = "~/photos/black.png";
                Label7.Text = "";
            }
            if (Label8.Text == "" || Label8.Text == "0")
            {
                Label63.ForeColor = System.Drawing.Color.Green;
                ImageButton9.ImageUrl = "~/photos/black.png";
                Label8.Text = "";
            }

            if (Label71.Text == "" || Label71.Text == "0")
            {
                Label72.ForeColor = System.Drawing.Color.Green;
                ImageButton12.ImageUrl = "~/photos/black.png";
                Label71.Text = "";
            }
            if (Label73.Text == "" || Label73.Text == "0")
            {
                Label74.ForeColor = System.Drawing.Color.Green;
                ImageButton13.ImageUrl = "~/photos/black.png";
                Label73.Text = "";
            }
            if (Label75.Text == "" || Label75.Text == "0")
            {
                Label76.ForeColor = System.Drawing.Color.Green;
                ImageButton14.ImageUrl = "~/photos/black.png";
                Label75.Text = "";
            }
            if (Label77.Text == "" || Label77.Text == "0")
            {
                Label78.ForeColor = System.Drawing.Color.Green;
                ImageButton15.ImageUrl = "~/photos/black.png";
                Label77.Text = "";
            }
            if (Label79.Text == "" || Label79.Text == "0")
            {
                Label80.ForeColor = System.Drawing.Color.Green;
                ImageButton16.ImageUrl = "~/photos/black.png";
                Label79.Text = "";
            }
            if (Label81.Text == "" || Label81.Text == "0")
            {
                Label82.ForeColor = System.Drawing.Color.Green;
                ImageButton17.ImageUrl = "~/photos/black.png";
                Label81.Text = "";
            }
            if (Label83.Text == "" || Label83.Text == "0")
            {
                Label84.ForeColor = System.Drawing.Color.Green;
                ImageButton18.ImageUrl = "~/photos/black.png";
                Label83.Text = "";
            }
            if (Label85.Text == "" || Label85.Text == "0")
            {
                Label86.ForeColor = System.Drawing.Color.Green;
                ImageButton19.ImageUrl = "~/photos/black.png";
                Label85.Text = "";
            }
        }
        catch (Exception) { }




    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        show(Label1.Text);
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        show(Label2.Text);
    }
    //protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    //{
    //    show(Label3.Text);
    //}
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        show(Label4.Text);
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        show(Label5.Text);
    }

    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        show(Label6.Text);
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
        show(Label7.Text);
    }

    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        show(Label8.Text);
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            show(Label71.Text);
        }
        catch (Exception) { }
    }
    protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            show(Label73.Text);
        }
        catch (Exception) { }
    }
    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            show(Label75.Text);
        }
        catch (Exception) { }
    }
    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            show(Label77.Text);
        }
        catch (Exception) { }
    }
    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            show(Label79.Text);
        }
        catch (Exception) { }
    }
    protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            show(Label81.Text);
        }
        catch (Exception) { }
    }
    protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            show(Label83.Text);
        }
        catch (Exception) { }
    }
    protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            show(Label85.Text);
        }
        catch (Exception) { }
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
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("clubgeneology.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Geneology.aspx");
    }
    public void popup()
    {
        try
        {
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label1.Text + "'");
            t11.Text = dt.Rows[0][0].ToString();
            t12.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t13.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label1.Text + "'");
            t14.Text = dt.Rows[0][0].ToString();
            t15.Text = dt.Rows[0][1].ToString();

        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label2.Text + "'");
            t21.Text = dt.Rows[0][0].ToString();
            t22.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t23.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label2.Text + "'");
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
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label4.Text + "'");
            t31.Text = dt.Rows[0][0].ToString();
            t32.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t33.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label4.Text + "'");
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


        //4
        try
        {
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label5.Text + "'");
            t41.Text = dt.Rows[0][0].ToString();
            t42.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t43.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label5.Text + "'");
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

        //5

        try
        {
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label6.Text + "'");
            t51.Text = dt.Rows[0][0].ToString();
            t52.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t53.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label6.Text + "'");
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

        //6

        try
        {
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label7.Text + "'");
            t61.Text = dt.Rows[0][0].ToString();
            t62.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t63.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label7.Text + "'");
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
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label8.Text + "'");
            t71.Text = dt.Rows[0][0].ToString();
            t72.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t73.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label8.Text + "'");
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
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label71.Text + "'");
            t81.Text = dt.Rows[0][0].ToString();
            t82.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t83.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label71.Text + "'");
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


        //9
        try
        {
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label73.Text + "'");
            t91.Text = dt.Rows[0][0].ToString();
            t92.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t93.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label73.Text + "'");
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


        //10

        try
        {
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label75.Text + "'");
            t101.Text = dt.Rows[0][0].ToString();
            t102.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t103.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label75.Text + "'");
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
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label77.Text + "'");
            t111.Text = dt.Rows[0][0].ToString();
            t112.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t113.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label77.Text + "'");
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
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label79.Text + "'");
            t121.Text = dt.Rows[0][0].ToString();
            t122.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t123.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label79.Text + "'");
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
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label81.Text + "'");
            t131.Text = dt.Rows[0][0].ToString();
            t132.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t133.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label81.Text + "'");
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

        //14
        try
        {
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label83.Text + "'");
            t141.Text = dt.Rows[0][0].ToString();
            t142.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t143.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label83.Text + "'");
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

        //15

        try
        {
            DataTable dt = ob.dttt("select name,fdate,mobile,ftime from register where username='" + Label85.Text + "'");
            t151.Text = dt.Rows[0][0].ToString();
            t152.Text = (dt.Rows[0][1].ToString()).Substring(0, 10) + " " + dt.Rows[0][3].ToString();
            t153.Text = dt.Rows[0][2].ToString();
        }
        catch (Exception) { }
        try
        {
            DataTable dt = ob.dttt("select leftcount,rightcount  from total_dailycount where username='" + Label85.Text + "'");
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
}