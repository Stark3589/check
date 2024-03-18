using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Diagnostics;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.IO;
using System.Xml;
using System.Net;
using TripleITTransaction;
/// <summary>
/// Summary description for clsmail
/// </summary>
public class clsmail
{
    public clsmail()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string sendpass(string Username, string pass, string to)
    {
        try
        {  // Gmail Address Sender where you send the mail
            string SenderAddress = "subaround@gmail.com";
            // any address Reciver where the email will be sending
            string toAddress = to;
            //Password of your gmail address
            const string SenderPassword = "Target@123";
            // Passing the values and make a email formate to display


            MailMessage theTestMail = new MailMessage(SenderAddress, toAddress);
            theTestMail.Body = "Dear " + Username + ".<br />Your Password :-"+pass+"<br/>";
            theTestMail.Body += "<br/><br/><br/><br/><br/>Thanks and regards <br/>subaround.com";
            theTestMail.IsBodyHtml = true;
            theTestMail.Priority = MailPriority.High;
            theTestMail.Subject = "No need to rply   " + DateTime.Now;


            SmtpClient theTest = new System.Net.Mail.SmtpClient();
            theTest.Port = 587;
            theTest.Host = "smtp.gmail.com";
            theTest.UseDefaultCredentials = false;
            theTest.EnableSsl = true;
            theTest.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            System.Net.NetworkCredential theCredential = new System.Net.NetworkCredential(SenderAddress, SenderPassword);
            theTest.Credentials = theCredential;
            theTest.Timeout = 20000;
            theTest.Send(theTestMail);
            string s = "yes";
            return s;
        }
        catch(Exception ex)
        {
            string s = ex.Message;
            return s;
        }
    }
}