<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintClosing.aspx.cs" Inherits="User_PrintClosing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
        }
        .style4
        {
            width: 365px;
        }
        </style>
        <script>window.print()</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    To,&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Date :
                    <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    , C/O
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Dist-
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    , Pin Code :
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                &nbsp;(<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    )</td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Mobile Number :
                    <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    <center><b>SUBJECT:</b> Payment Advice</center></td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    Dear&nbsp;<asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                    ,</td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    CONGRATULATIONS !!!! You have been got eligible for the&nbsp;Facilitation Fees. 
                    Details are below :</td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="LabelMW" runat="server" Text="Monthly"></asp:Label>
&nbsp;: 
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                &nbsp;-
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                &nbsp;</td>
                <td>
                    Distributor ID :
                    <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    Name :
                    <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                   <b><u> Payment Details :</u></b></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    Facilitation Fees :
                </td>
                <td>
                    Rs.
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                  <b>  Deductions :</b></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    TDS (10%) :
                </td>
                <td>
                    Rs.
                    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Admin Charge(5%) :</td>
                <td>
                    Rs.
                    <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    --------------------</td>
            </tr>
            <tr>
                <td class="style4">
                    Net Amount :
                </td>
                <td>
                    Rs. 
                    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    ---------------------</td>
            </tr>
            <tr>
                <td class="style4">
                    Cheque No. :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    Bank Name :
                    <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    This is only a computer generated payment advice statement , 
                    Hence no signature required.</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
