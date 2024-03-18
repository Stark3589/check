using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TripleITTransaction;
public partial class User_KYCStatus : System.Web.UI.Page
{
    clsList objlist = new clsList();
    clsAMD objamd = new clsAMD();
    BussinessLayer ob = new BussinessLayer();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            loadrequestlist();
        }
    }
    private void loadrequestlist()
    {
        try
        {

            DataTable dt = objlist.ListDOC(0, drpreq.SelectedValue, DateTime.Now, DateTime.Now, "S");
            if (dt.Rows.Count > 0)
            {

                reploadimg.DataSource = dt;
                reploadimg.DataBind();
            }
            else
            {
                sccess.Visible = false;
                danger.Visible = false;
                warning.Visible = true;
                lbwarning.Text = "Oppss No Data Found......!";
                reploadimg.DataSource = dt;
                reploadimg.DataBind();
            }


        }
        catch (Exception ex)
        {

            Response.Redirect("../error.aspx?error=" + ex.Message);

        }
    }

    protected void repUserList_ItemCommand(object source, RepeaterCommandEventArgs e)
 {
        try
        {

            if (e.CommandName == "Request")
            {
                Label lbuname = e.Item.FindControl("lbaid") as Label;
                DropDownList drplsit = e.Item.FindControl("drpstatus") as DropDownList;
                int id = Convert.ToInt32(lbuname.Text);
                
                int a = objamd.DOCupload(id, "", "", "", drplsit.SelectedValue,"", DateTime.Now, "U");

                if (a == 1)
                {
                    warning.Visible = false;
                    sccess.Visible = false;
                    danger.Visible = false;
                    sccess.Visible = true;
                    //approvedaccout(lbuname.Text);
                    loadrequestlist();

                }
                else if (a == -1)

                {
                    sccess.Visible = false;
                    danger.Visible = false;
                    warning.Visible = true;

                }
                else if (a == 0)
                {
                    sccess.Visible = false;
                    warning.Visible = false;
                    danger.Visible = true;
                }

               

            }
        }
        catch (Exception ex)
        {
            Response.Redirect("error.aspx?error=" + ex);


        }
    }

    //private void approvedaccout(string id)
    //{
    //    try
    //    {
    //        //DataTable dt = ob.dttt("select UserName,DocName,DocStatus from TblKYC UserName'" + id + "'");
    //        //Label lbuname = e.Item.FindControl("lbaid") as Label;
    //        //string username = lbuname.Text;
    //        DataTable dtid = ob.dttt("select UserName,DocName,DocStatus from TblKYC where Kid='" + id + "'");
    //        if (dtid.Rows.Count > 0)
    //        {
    //            string username = dtid.Rows[0]["UserName"].ToString();


    //            DataTable dt = ob.dttt("select UserName,DocName,DocStatus from TblKYC where username='" + username + "'");
    //            if (dt.Rows.Count > 0)
    //            {

    //                int aflag = 0, pflag = 0, oflag = 0;
    //                for (int i = 0; i < dt.Rows.Count; i++)
    //                {

    //                    string name = dt.Rows[i]["UserName"].ToString();
    //                    string docname = dt.Rows[i]["DocName"].ToString();
    //                    string docstatus = dt.Rows[i]["DocStatus"].ToString();
    //                    if (docname == "AdharCard" && docstatus == "Approved")
    //                    {
    //                        aflag = 1;


    //                    }
    //                    else if (docname == "Pancard" && docstatus == "Approved")
    //                    {
    //                        pflag = 1;


    //                    }
    //                    else if (docname == "Bank_Passbook" && docstatus == "Approved")
    //                    {
    //                        oflag = 1;


    //                    }
    //                    if (aflag == 1 && pflag == 1 && oflag == 1)
    //                    {
    //                        ob.Execute("update register set status='Active' where username='" + username + "'");

    //                    }
    //                }

    //            }
    //        }
    //        else
    //        { }



    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}


    protected void drpreq_TextChanged(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            loadrequestlist();
        }
    }

}