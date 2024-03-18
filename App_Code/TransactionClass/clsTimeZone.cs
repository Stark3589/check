using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsTimeZone
/// </summary>
public class clsTimeZone
{
    public clsTimeZone()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DateTime returnDateTimeServerMachTime()
    {
        string time = DateTime.Now.AddHours(12.50).ToString();
        DateTime Servertime = Convert.ToDateTime(time);
        return Servertime;

    }
    public string  returnStringServerMachTime()
    {
        string time = DateTime.Now.AddHours(12.50).ToString("yyyy/MM/dd");      
        return time;

    }
    private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");


    public DateTime utc()
    {
        DateTime indiantime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);


        return indiantime;
    }
}