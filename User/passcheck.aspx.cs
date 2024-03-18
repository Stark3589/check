using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class User_passckr : System.Web.UI.Page
{
    BussinessLayer ob = new BussinessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = ob.dttt("SELECT [dateofjoin], [rtime], [name], [mobile], [username], [password],[onside] FROM [register]");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }catch(Exception kj){};
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "Cancel")
        {
           

         
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //If Salary is less than 10000 than set the row Background Color to Cyan  
            try
            {
                e.Row.Cells[6].Text = DecodeFrom64(e.Row.Cells[6].Text);
            }
            catch (Exception jh) { e.Row.Cells[6].Text = ""; };
             try
            {
            e.Row.Cells[7].Text = DecodeFrom64(e.Row.Cells[7].Text);
            }
             catch (Exception jh) { e.Row.Cells[7].Text = ""; };
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
}