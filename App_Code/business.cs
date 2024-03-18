
using System;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
#region Namespace For Database Connection
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
#endregion
public class business
{
	
		 #region Variable For Database Connection
    SqlConnection con;
    SqlDataAdapter da;
    SqlCommand cmd;
    SqlDataReader dr;
    DataSet ds;
    DataTable dt;
    Object ob;
    #endregion

    #region Function For OpenConnection
    public void Openconn()
    {
        try
        {
            if (con == null)
            {
                con = new SqlConnection("Data Source=A2NWPLSK14SQL-v02.shr.prod.iad2.secureserver.net;Initial Catalog= zxeautopool;Persist Security Info=True;User Id= zxeautopool;Password=Zxeautopool@kt@776;Connection Timeout=1000");
              //  con = new SqlConnection("Data Source=DESKTOP-V4UMU2P;Initial Catalog=magicfive;Integrated Security=True; Connection Timeout=1000");
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
        }catch(SqlException jh){};
    }
    #endregion
    #region Function For CloseConnection
    public void CloseConn()
    {
        if (con.State == ConnectionState.Open)
            con.Close();
    }
    #endregion

    #region Funtion For Dataset
    public DataSet dsss(String str)
    {
        ds = new DataSet();
        Openconn();
        da = new SqlDataAdapter(str, con);
        da.Fill(ds);
        CloseConn();
        return ds;
      }
    #endregion

    #region Function For DataTable
    public DataTable dttt(String str)
    {
        dt = new DataTable();
        Openconn();
        da = new SqlDataAdapter(str, con);
        da.Fill(dt);
        CloseConn();
        return dt;
    }
    #endregion

    #region Function For ExecuteNonQuery(insert,delete,update)
   public void Execute(String str)
   {
        Openconn();
        cmd = new SqlCommand(str, con);
        cmd.CommandTimeout = 950;
        cmd.ExecuteNonQuery();
        CloseConn();
    }
    #endregion

    #region Function For ExecuteReader
   public SqlDataReader drrr(String str)
   {
       Openconn();
       cmd = new SqlCommand(str, con);
       dr = cmd.ExecuteReader();
       return dr;
   }
    #endregion

    #region Function For ExecuteScalar
    public object ExecuteScaler(String str)
    {
        Openconn();
        cmd=new SqlCommand(str , con);
        ob=cmd.ExecuteScalar();
        return ob;
    }
    #endregion
	}
