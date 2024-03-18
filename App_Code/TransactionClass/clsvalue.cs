using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsvalue
/// </summary>
public class clsvalue
{
    public clsvalue()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
      public class Chanel
    {
        public int sid { get; set; }
        public string ChanelName { get; set; }
        public string Link { get; set; }

    }
    public class Subcribechanel
    { 
        public int sid { get; set; }
        public string CChanelName { get; set; }
        public string CLink { get; set; }
    }

public class UnSubcribechanel
{
   
    public string ChanelName { get; set; }
    public string CLink { get; set; }
}
public class Coin
{
    public string sid { get; set; }
    public string ChanelName { get; set; }
    public string Link { get; set; }
    public string coinno { get; set; }
}
public class follow
{
    public string sid { get; set; }
    public string ChanelName { get; set; }
    public string Date { get; set; }
    
}
public class following
{
    public string sid { get; set; }
    public string ChanelName { get; set; }
    public string Date { get; set; }

}
public class traffic
{
    public string  Total { get; set; }
    public string ChanelName { get; set; }
    public string Link { get; set; }

}
public class NotLive
{
    public string LId { get; set; }
    public string CName { get; set; }
    public string DOS { get; set; }
    public string UserName { get; set; }
    public string Sid{ get; set; }
}
public class clsaccount
{
    public string username { get; set; }
    public string date { get; set; }
    public string debit { get; set; }
    public string credit { get; set; }
    public int tdebit { get; set; }
    public int tcredit { get; set; }
    public string remark { get; set; }
    public string tds { get; set; }
    public string admin { get; set; }
    public string total { get; set; }
}
public class clsTotalBinary
{
    public string username { get; set; }
    public string leftcount { get; set; }
    public string rightcount { get; set; }

}
public class clsnewTotalBinary
{
    public string username { get; set; }
    public string leftcount { get; set; }
    public string rightcount { get; set; }

}
public class clsBinary
{
    public string username { get; set; }
    public string left { get; set; }
    public string right { get; set; }
    public string count { get; set; }

}

