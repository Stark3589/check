using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using TripleITConnection;


public partial class Admin_edituser : System.Web.UI.Page
{
    clsConnection objcon = new clsConnection();
    BussinessLayer ob = new BussinessLayer();
    PINCODE pin = new PINCODE();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {

                txtsearchuname.Text = Session["newuser"].ToString();
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
                SearchDetail();
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
    void SearchDetail()
    {
        DataTable dt = ob.dttt("select * from register where username='" + txtsearchuname.Text.Trim() + "'");
        if (dt.Rows.Count > 0)
        {

            try
            {
                txtuid.Text = dt.Rows[0]["username"].ToString();
            }
            catch { }
            //try
            //{
            //    paytm.Text = dt.Rows[0]["paytm"].ToString();
            //}
            //catch { }
            //try
            //{
            //    tez.Text = dt.Rows[0]["tez"].ToString();
            //}
            //catch { }
            try
            {
                txtuname.Text = dt.Rows[0]["name"].ToString();
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
                txtmobile.Text = dt.Rows[0]["email"].ToString();
            }
            catch { }
            try
            {
                txtmobile_no.Text = dt.Rows[0]["mobile"].ToString();
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
                txtnomname.Text = dt.Rows[0]["nomineename"].ToString();
            }
            catch { }


            //try
            //{
            //    txtaddress.Text = dt.Rows[0]["address"].ToString();
            //}
            //catch { }
            //try
            //{
            //    txtpincode.Text = dt.Rows[0]["pin"].ToString();
            //}
            //catch { }
            try
            {
                txtnomrelation.SelectedItem.Text = dt.Rows[0]["relation"].ToString();
            }
            catch { }


            try
            {
                txtpass.Text =DecodeFrom64( dt.Rows[0]["password"].ToString());
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
               
            //   // Drpsex.SelectedItem.Text = dt.Rows[0]["sex"].ToString();
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
        //DataTable dt1 = ob.dttt("select * from bankdetail where username='" + txtsearchuname.Text.Trim() + "'");
        //     if (dt1.Rows.Count > 0)
        //     {
        //         try
        //         {
        //             txtbank.Text = dt1.Rows[0]["bankname"].ToString();
        //         }
        //         catch { }
        //         try
        //         {
        //             txtaccount.Text = dt1.Rows[0]["accno"].ToString();
        //         }
        //         catch { }
        //         try
        //         {
        //             txtifsc.Text = dt1.Rows[0]["ifsc"].ToString();
        //         }
        //         catch { }
        //         try
        //         {
        //             txtbranch.Text = dt1.Rows[0]["branchname"].ToString();
        //         }
        //         catch { }
        //         try
        //         {
        //             drptype.SelectedItem.Text = dt1.Rows[0]["acctype"].ToString();
        //         }
        //         catch { }
        //         try
        //         {
        //             txtaccountholder.Text = dt1.Rows[0]["holdername"].ToString();
        //         }
        //         catch { }
        //     }
             DataTable dt2 = ob.dttt("select sponser from sponser where username='" + txtsearchuname.Text.Trim() + "'");
             if (dt2.Rows.Count > 0)
             {
                 try
                 {
                     txtsponser.Text = dt2.Rows[0]["sponser"].ToString();
                 }
                 catch { }
             }
             else
             {
                 txtsearchuname.Text = "";
             }
    }


    public string DecodeFrom64(string encodedData)
    {
        System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
        System.Text.Decoder utf8Decode = encoder.GetDecoder();
        byte[] todecode_byte = Convert.FromBase64String(encodedData);
        int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
        char[] decoded_char = new char[charCount];
        utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
        string result = new String(decoded_char);
        return result;
    }
    protected void bntpersonal_Click(object sender, EventArgs e)
    {
        try
        {
            //string sql112 = "select * from bankdetail where username='" + txtuid.Text + "' and ptotal='1'";
            //DataTable dt12 = ob.dttt(sql112);
            //if (dt12.Rows.Count == 0)
            //{
                //string doj = "1990-02-02";
                //if (txtDOB.Text.Length > 0)
                //{
                //    doj = Convert.ToDateTime(txtDOB.Text).ToString("yyyy-MM-dd");
                //}
                //if (txtstatus.Text == "Active")
                //{
                ob.Execute("update register set nomineename='" + txtnomname.Text + "',relation='" + txtnomrelation.SelectedItem.Text + "',email='"+txtmobile.Text+"',mobile='"+txtmobile_no.Text+"'  where username='" + txtuid.Text + "'");
                Response.Write("<script>alert('Updated Successfully')</script>");    
            }
                //else
                //{
                //    ob.Execute("update register set  dob='" + doj + "', fname='" + txtfname.Text + "', address='" + dropidproof.SelectedItem.Text + "',mobile='" + txtmobile.Text + "',pan='" + txtpancard.Text + "',nomineename='" + txtnomname.Text + "',relation='" + txtnomrelation.SelectedItem.Text+ "', pin='" + txtpincode.Text + "' , email='" + txtemail.Text + "' , sex='" + Drpsex.SelectedItem.Text + "', aadhar='" + DropDownList1.SelectedItem.Text + "',name='" + txtuname.Text + "' where username='" + txtuid.Text + "'");
                //}
                //string sql12 = "insert into tblbankupdate (username,total,ptotal) values ('" + txtuid.Text + "','0','1')";
                //int c = objcon.ExecuteSqlQuery(sql12);
                //SqlDataReader drr = ob.drrr("select accno from bankdetail where username='"+txtuid.Text+"' and accno is null");
                //if (drr.Read())
                //{
                //    ob.CloseConn();
                //    ob.Execute("update bankdetail set accno='" + txtaccount.Text + "',bankname='" + txtbank.Text + "', ifsc='" + txtifsc.Text + "',branchname='" + txtbranch.Text + "',acctype='" + drptype.SelectedItem.Text + "',holdername='" + txtaccountholder.Text + "' where username='" + txtuid.Text + "'");
                //}
                //else
                //{
                //    ob.CloseConn();
                //}
            //    if (c > 0)
            //    {
            //        Response.Write("<script>alert('Updated Successfully')</script>");
            //    }
            //}
            //else
            //{
            //    Response.Write("<script>alert('You Already Updated Profile 1 Time')</script>");
            //}
        
        catch (Exception)
        {
            Response.Write("<script>alert('Something Is Wrong !!!!!!')</script>");
        }
    }
  
    //protected void Drpstate_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    DataTable dt1 = pin.dttt("select distinct districtname from pincode where statename='" + Drpstate.SelectedItem.Text + "' ");
    //    Drpcity.DataSource = dt1;
    //    Drpcity.DataTextField = "districtname";
    //    Drpcity.DataBind();
    //    Drpcity.Items.Insert(0, "Select City");
    //}
}