using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TripleITTransaction;
using TripleITConnection;
using System.Data;

public partial class Admin_category : System.Web.UI.Page
{
    clsConnection objcon = new clsConnection();
    clsAMD objamd = new clsAMD();
    clsList objlist = new clsList();
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindata();
           
          
        }

    }

   
    protected void bntsubmit_Click(object sender, EventArgs e)
    {
        try
        {

            DateTime utcTime = DateTime.UtcNow;
            //current Time
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime timenow = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
            //string doj=timenow.
            DateTime datenow1 = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
            string datenow = datenow1.ToString("yyyy/MM/dd");


           
           
                if (bntsubmit.Text == "Save")
                {
                       string queryy = "select * from productcategory where category='" + txtcategory.Text + "'";
                      DataTable dtu = ob.dttt(queryy);
                       if (dtu.Rows.Count > 0)
                       {
                           txtcategory.Text = "";
                      Response.Write("<script>alert('THIS CATEGORY IS ALREADY INSERTED')</script>");
                      }
              else
              {
                  string query = "insert into productcategory(category,date)values('" + txtcategory.Text + "','" + datenow + "')";
                  ob.Execute(query);
                  txtcategory.Text = "";
                  Response.Write("<script>alert('INSERTED SUCCESSFULLY')</script>");
                  bindata();
              }
                }

                if (bntsubmit.Text == "Update")
                {
                    string sql = "update productcategory set category='" + txtcategory.Text + "' where category='" + lbl.Text + "'";
                    ob.Execute(sql);
                    txtcategory.Text = "";
                    Response.Write("<script>alert('UPDATED SUCCESSFULLY')</script>");
                    bindata();
                }
            


        }
        catch (Exception ex)
        {
        }
    }

    private void bindata()
    {
        try
        {
            string query = "select * from productcategory ";
            DataTable dty = ob.dttt(query);
            Repeater1.DataSource = dty;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        { }

    }
    
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Update")
        {
            string idd = e.CommandArgument.ToString();


            string query = "select category from productcategory where category='" + idd + "'";
            DataTable dt = ob.dttt(query);
            if (dt.Rows.Count > 0)
            {
                string aaa = dt.Rows[0]["category"].ToString();
                txtcategory.Text = aaa;
                bntsubmit.Text = "Update";
            }
            lbl.Text = txtcategory.Text;

        }
        if (e.CommandName == "DEL")
        {
            string idd = e.CommandArgument.ToString();

            string query = "delete from productcategory where category='" + idd + "'";
            ob.Execute(query);
            Response.Write("<script>alert('DELETED SUCCESSFULLY')</script>");
            bindata();
        }
    }
}