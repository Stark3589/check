﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using TripleITConnection;
using System.Configuration;

public partial class login : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    clsConnection objcon = new clsConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                SqlConnection con = new SqlConnection(ob.ConnectString);
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[daily_roi]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception jh)
            { }
           
        }

    }
    public static string EncodePasswordToBase64(string password)
    {
        try
        {
            byte[] encData_byte = new byte[password.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
            string encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;
        }
        catch (Exception ex)
        {
            throw new Exception("Error in base64Encode" + ex.Message);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string password=EncodePasswordToBase64(TextBox2.Text);
        
           // password='" + password + "' and
           
            SqlDataReader dr = ob.drrr("select * from register where password='" + password + "' and  username='" + TextBox1.Text + "'  and bub!='B'");
            if (dr.Read())
            {

                dr.Close();
              
               
                Session["newuser"] =  TextBox1.Text;
                Response.Redirect("~/newuser/homefrn.aspx");

            }
            else
            {
                dr.Close();


                Response.Write("<script>alert('Invalid Username or Password Or ID may be blocked')</script>");
            }

        



    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("register.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("index.html");
    }
}