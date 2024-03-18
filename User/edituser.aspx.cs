using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Admin_edituser : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    PINCODE pin = new PINCODE();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
             //   showsamename();
                //DataTable dt = pin.dttt("select distinct statename from pincode order by statename asc");
                //Drpstate.DataSource = dt;
                //Drpstate.DataTextField = "statename";
                //Drpstate.DataBind();
                //DataTable dt1 = pin.dttt("select distinct districtname from pincode where statename='" + Drpstate.SelectedItem.Text + "' ");
                //Drpcity.DataSource = dt1;
                //Drpcity.DataTextField = "districtname";
                //Drpcity.DataBind();
                //Drpcity.Items.Insert(0, "Select City");
                //SearchDetail();
                try
                {

                    DataTable dt = ob.dttt("select distinct statename from pincode order by statename asc");
                    DropDownList2.DataSource = dt;
                    DropDownList2.DataTextField = "statename";
                    DropDownList2.DataBind();

                }
                catch (Exception ex) { }
            }
        }
        catch (Exception ex)
        { }
        //if (!IsPostBack)
        //{
        //    if (Request.QueryString["usr"] != null)
        //    {
        //        txtusersearch.Text = Request.QueryString["usr"].ToString();
        //        SearchDetail();
        //    }
        //}
    }
    void SearchDetail(string memdetail)
    {


        DataTable dt = ob.dttt("select * from register where username='" + memdetail.Trim() + "' or mobile='" + memdetail.Trim() + "' or name='" + memdetail.Trim() + "'");
        if (dt.Rows.Count > 0)
        {
            

            try
            {
                txtuid.Text = dt.Rows[0]["username"].ToString();
            }
            catch { }
            try
            {
                txtuname.Text = dt.Rows[0]["name"].ToString();
            }
            catch { }
            try
            {
                txtaccountholder.Text = dt.Rows[0]["name"].ToString();
            }
            catch (Exception ex)
            {
            }
            try
            {
                adhar.Text = dt.Rows[0]["aadhar"].ToString();
            }
            catch { }
            try
            {
                pan.Text = dt.Rows[0]["pan"].ToString();
            }
            catch { }
            try
            {
                txtstatus.Text = dt.Rows[0]["fname"].ToString();
            }
            catch { }
            try
            {
                dob.Text = Convert.ToDateTime(dt.Rows[0]["dob"]).ToString("dd-MM-yyyy");
            }
            catch { }
            try
            {
                DropDownList1.Text = dt.Rows[0]["sex"].ToString();
                DropDownList2.Text = dt.Rows[0]["state"].ToString();
                try
                {

                    DataTable dtt = ob.dttt("select distinct districtname from pincode where statename='" + DropDownList2.SelectedItem.Text + "' order by districtname asc");
                    DropDownList3.DataSource = dtt;
                    DropDownList3.DataTextField = "districtname";
                    DropDownList3.DataBind();

                }
                catch (Exception ex) { }
                DropDownList3.Text = dt.Rows[0]["city"].ToString();

            }
            catch { }
            //try
            //{
            //    txtfname.Text = dt.Rows[0]["fname"].ToString();
            //}
            //catch { }
           
            try
            {
                txtjoiningdate.Text = DateTime.Parse(dt.Rows[0]["dateofjoin"].ToString()).ToString("yyyy-MM-dd");
            }
            catch { }
            try
            {
                txtmobile.Text = dt.Rows[0]["mobile"].ToString();
            }
            catch { }


            try
            {
                txtupline.Text = dt.Rows[0]["reffname"].ToString();
            }
            catch { }




            try
            {
                txtstatus.Text = dt.Rows[0]["status"].ToString();
            }
            catch { }
            //try
            //{
            //    txtpancard.Text = dt.Rows[0]["pan"].ToString();
            //}
            //catch { }
            //try
            //{
            //    //txtcity.Text = dt.Rows[0]["city"].ToString();
            //    txtstate.Text = dt.Rows[0]["State"].ToString();

            //}
            //catch { }
            //try
            //{
            //    //txtstate.Text = dt.Rows[0]["state"].ToString();

            //    txtcity.Text = dt.Rows[0]["city"].ToString();

            //}
            //catch { }
            try
            {
                TextBox1.Text = dt.Rows[0]["email"].ToString();
            }
            catch { }


            ////try
            ////{
            ////    txtaddress.Text = dt.Rows[0]["address"].ToString();
            ////}
            ////catch { }
            ////try
            ////{
            ////    txtpincode.Text = dt.Rows[0]["pin"].ToString();
            ////}
            ////catch { }
            try
            {
                txtnomrelation.SelectedItem.Text = dt.Rows[0]["relation"].ToString();
            }
            catch { }


          
            //try
            //{
            //    txtDOB.Text = dt.Rows[0]["dob"].ToString();
            //}
            //catch { }
            //try
            //{
            //    Drpsex.Items.Insert(0, new ListItem(dt.Rows[0]["sex"].ToString(), "0"));
            //}
            //catch { }
            //try
            //{
            //    txtemail.Text = dt.Rows[0]["email"].ToString();
            //}
            //catch { }
            //try
            //{
            //    txtside.Text = dt.Rows[0]["onside"].ToString();
            //}
            //catch { }
            //try
            //{
            //    txtaadhar.Text = dt.Rows[0]["aadhar"].ToString();
            //}
            //catch { }

        }
        showsamename();

        DataTable dt1 = ob.dttt("select * from bankdetail where username='" + memdetail.Trim() + "'");
        if (dt1.Rows.Count > 0)
        {
            try
            {
                txtbank.Text = dt1.Rows[0]["bankname"].ToString();
            }
            catch { }
            try
            {
                txtaccount.Text = dt1.Rows[0]["accno"].ToString();
            }
            catch { }
            try
            {
                txtifsc.Text = dt1.Rows[0]["ifsc"].ToString();
            }
            catch { }
            try
            {
                txtbranch.Text = dt1.Rows[0]["branchname"].ToString();
            }
            catch { }
            try
            {
                drptype.SelectedItem.Text = dt1.Rows[0]["acctype"].ToString();
            }
            catch { }
            try
            {
                txtaccountholder.Text = dt1.Rows[0]["holdername"].ToString();
            }
            catch { }
            try
            {
                paytm.Text = dt1.Rows[0]["GOOGLEPAY"].ToString();
            }
            catch { }
            try
            {
                tez.Text = dt1.Rows[0]["PHONEPAY"].ToString();
            }
            catch { }
             try
            {
          drptype.SelectedItem.Text=dt1.Rows[0]["accounttype"].ToString();
            }
             catch { }
        }



        DataTable dt2 = ob.dttt("select sponser from sponser where username='" + memdetail.Trim() + "'");
        if (dt2.Rows.Count > 0)
        {
            try
            {
                txtsponser.Text = dt2.Rows[0]["sponser"].ToString();
                lbsponser.Text = txtsponser.Text;
            }
            catch { }
        }
        else
        {
            // txtsearchuname.Text = "";
        }
    }

   
    //protected void DrpState_TextChanged(object sender, EventArgs e)
    //{


    //    DataTable dt1 = pin.dttt("select distinct districtname from pincode where statename='" + Drpstate.SelectedItem.Text + "' ");
    //    Drpcity.DataSource = dt1;
    //    Drpcity.DataTextField = "districtname";
    //    Drpcity.DataBind();
    //    Drpcity.Items.Insert(0, "Select City");



    //}
    protected void bntpersonal_Click(object sender, EventArgs e)
    {
        try
        {
            //string doj = "1990-02-02";
            //if (txtDOB.Text.Length > 0)
            //{
            //    doj = Convert.ToDateTime(txtDOB.Text).ToString("yyyy-MM-dd");
            //}
            ob.Execute("update register set name='" + txtuname.Text + "' , mobile='" + txtmobile.Text + "',email='" + TextBox1.Text + "' where username='" + txtuid.Text + "'");
            //SqlDataReader drr = ob.drrr("select accno from bankdetail where username='" + txtuid.Text + "' and accno is null");
            //if (drr.Read())
            //{
            //    ob.CloseConn();

            string query = "select * from bankdetail where username='" + txtuid.Text + "'";
            DataTable dty = ob.dttt(query);
            if (dty.Rows.Count > 0)
            {

                ob.Execute("update bankdetail set accno='" + txtaccount.Text + "' where username='" + txtuid.Text + "'");
            }
            else
            {
                string sql = "insert into bankdetail(accno,username)values('" + txtaccount.Text + "','" + txtuid.Text + "')";
                ob.Execute(sql);
            }
           // ob.Execute("update sponser set sponser='" + txtsponser.Text + "' where username='" + txtuid.Text + "'");
            //}
            //else
            //{
            //    ob.CloseConn();
            //}
            Response.Write("<script>alert('Updated Successfully')</script>");
        }
        catch (Exception)
        { Response.Write("<script>alert('Something Is Wrong !!!!!!')</script>"); }
    }
    protected void btnsearch_Click1(object sender, EventArgs e)
    {
        SearchDetail(txtsearchuname.Text);
    }
    protected void Drpstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt1 = pin.dttt("select distinct districtname from pincode where statename='" + DropDownList2.SelectedItem.Text + "' ");
        DropDownList3.DataSource = dt1;
        DropDownList3.DataTextField = "districtname";
        DropDownList3.DataBind();
        DropDownList3.Items.Insert(0, "Select City");
    }
    protected void txtsponser_TextChanged(object sender, EventArgs e)
    {
        try
        {
            lbsponsername.Text = "";
            if (txtsponser.Text.Length > 0)
            {
                DataTable dt2 = ob.dttt("select name,username from register  where username='" + txtsponser.Text + "'");
                if (dt2.Rows.Count > 0)
                {
                    lbsponsername.Text = dt2.Rows[0]["name"].ToString();
                }
                else
                {
                    txtsponser.Text = lbsponser.Text;
                    lbsponsername.Text = "You Entered Wrong Sponser ID";


                }
            }
            else
            {
                txtsponser.Text = lbsponser.Text;
                // txtsponser.Text = "";
                // lbsponsername.Text = "You Entered Wrong Sponser ID";


            }

        }
        catch (Exception ex)
        {
            // txtsponser.Text = "";
            //  lbsponsername.Text = "You Entered Wrong Sponser ID";
        }
    }


    private void showsamename()
    {
       

    }


   
  
    protected void gvCustomers_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
         
            //Fetch value of Country
            string username =Convert.ToString(e.CommandArgument);
            SearchDetail(username);
           
        }
    }
}