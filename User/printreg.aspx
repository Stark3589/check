<%@ Page Language="C#" AutoEventWireup="true" CodeFile="printreg.aspx.cs" Inherits="User_printreg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            height: 20px;
            width: 163px;
        }
        .auto-style8 {
            height: 20px;
            width: 113px;
            text-align: left;
        }
        .auto-style10 {
            width: 113px;
            text-align: left;
        }
        .auto-style13 {
            width: 163px;
            text-align: left;
        }
        .auto-style19 {
            width: 254px;
            text-align: left;
        }
        .auto-style20 {
            width: 113px;
            text-align: left;
        }
        .auto-style21 {
            height: 20px;
            width: 254px;
            text-align: left;
        }
        .auto-style22 {
            width: 191px;
            height: 27px;
        }
        .auto-style23 {
            width: 254px;
            text-align: left;
            height: 27px;
        }
        .auto-style24 {
        }
        .auto-style25 {
            height: 20px;
            width: 191px;
        }
        .auto-style26 {
            width: 163px;
            text-align: left;
            height: 39px;
        }
        .auto-style27 {
            width: 113px;
            text-align: left;
            height: 39px;
        }
        .auto-style28 {
            width: 191px;
            height: 39px;
        }
        .auto-style29 {
            width: 254px;
            text-align: left;
            height: 39px;
        }
        .auto-style30 {
            width: 191px;
            height: 30px;
        }
        .auto-style31 {
            height: 30px;
            width: 254px;
            text-align: left;
        }
        .auto-style32 {
            height: 30px;
            width: 163px;
        }
        .auto-style33 {
            height: 30px;
            width: 113px;
            text-align: left;
        }
        .auto-style34 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="border-style: groove; border-width: thin; height: 981px;" >
        <tr>
            <td colspan="4"><center>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="New Registration Form"></asp:Label>
                </center></td>
        </tr>
        <tr>
            <td colspan="4" style=" border: thin groove #000000; height:2px; background-color:black;"></td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" colspan="2">&nbsp;</td>
            <td class="auto-style13" style="border: thin groove #000000">
                <asp:Label ID="Label39" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Registration Date" style="text-align: right"></asp:Label>
            </td>
            <td class="auto-style10" style="border: thin groove #000000">
                
                <asp:Label ID="Label42" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <%--<tr>
        
            <td colspan="4" style="border: thin groove #000000"><div style="width:100%; height:2px; background-color:black;"> </div>
               </td>
            
        </tr>--%>
        <tr>
            <td colspan="4" style="border: thin groove #000000; text-align: center">
                &nbsp;<asp:Label ID="Label41" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Personal Details" style="font-size: large;" ></asp:Label>
            </td>
        </tr>
       <%-- <tr>
            <td colspan="4" style="border: thin groove #000000"><div style="width:100%; height:2px; background-color:black;"> </div></td>
        </tr>--%>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="User Name"></asp:Label>
            </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label43" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style1" valign="top" colspan="2" rowspan="4" style="border: thin groove #000000">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Image ID="Image1" runat="server" Height="113px" Width="107px" BorderWidth="2px" />
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24"><asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" Text="Father / Husband Name"></asp:Label> </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label44" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24"><asp:Label ID="Label33" runat="server" Font-Bold="True" Font-Size="Medium" Text="Address"></asp:Label> </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label45" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style22"><asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" Text="Sex"></asp:Label> </td>
            <td class="auto-style23" style="border: thin groove #000000">
                
                <asp:Label ID="Label46" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style28"><asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="DOB"></asp:Label> </td>
            <td class="auto-style29" style="border: thin groove #000000">
                
                <asp:Label ID="Label47" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style26" style="border: thin groove #000000">
                <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Medium" Text="Mobile"></asp:Label> </td>
            <td class="auto-style27" style="border: thin groove #000000">
                
                <asp:Label ID="Label51" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24"><asp:Label ID="Label10" runat="server" Font-Bold="True" 
                    Font-Size="Medium" Text="State"></asp:Label> </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label48" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style13" style="border: thin groove #000000"><asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="Medium" Text="Pan No"></asp:Label> </td>
            <td class="auto-style20" style="border: thin groove #000000">
                
                <asp:Label ID="Label52" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24"><asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Medium" Text="Pin Code"></asp:Label> </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label49" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style13" style="border: thin groove #000000"><asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="Medium" Text="E-Mail"></asp:Label> </td>
            <td class="auto-style20" style="border: thin groove #000000">
                
                <asp:Label ID="Label53" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24"><asp:Label ID="Label12" runat="server" Font-Bold="True" 
                    Font-Size="Medium" Text="City"></asp:Label> </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label50" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style13" style="border: thin groove #000000">&nbsp;</td>
            <td class="auto-style20" style="border: thin groove #000000">&nbsp;</td>
        </tr>
       <%-- <tr>
            <td colspan="4" style="border: thin groove #000000"><div style="width:100%; height:2px; background-color:black;"> </div></td>
        </tr>--%>
        <tr>
            <td colspan="2" style="border: thin groove #000000">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label40" runat="server" Font-Bold="True" Font-Size="Large" 
                    Text="Registration Details" ></asp:Label>
            </td>
            <td colspan="2" style="border: thin groove #000000">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="Large" Text="Nominee Details" ></asp:Label></td>
        </tr>
        <%--<tr>
            <td colspan="4" style="border: thin groove #000000"><div style="width:100%; height:2px; background-color:black;"> </div></td>
        </tr>--%>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Up-Line ID"></asp:Label>
            </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label54" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style13" style="border: thin groove #000000"><asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="Medium" Text="Nominee Name"></asp:Label> </td>
            <td class="auto-style20" style="border: thin groove #000000">
                
                <asp:Label ID="Label58" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24"><asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" Text="User ID"></asp:Label> </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label55" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style13" style="border: thin groove #000000"><asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="Medium" Text="Relation With Nominee"></asp:Label> </td>
            <td class="auto-style20" style="border: thin groove #000000">
                
                <asp:Label ID="Label59" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24"><asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="Medium" Text="Sponser ID"></asp:Label> </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label56" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style13" style="border: thin groove #000000"><asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="Medium" Text="Age"></asp:Label> </td>
            <td class="auto-style20" style="border: thin groove #000000">
                
                <asp:Label ID="Label60" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style30"><asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="Medium" Text="Side"></asp:Label> </td>
            <td class="auto-style31" style="border: thin groove #000000">
                
                <asp:Label ID="Label57" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style32" style="border: thin groove #000000"><asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="Medium" Text="DOB Of Nominee"></asp:Label> </td>
            <td class="auto-style33" style="border: thin groove #000000">
                
                <asp:Label ID="Label61" runat="server" Font-Bold="True" Font-Size="Medium" style="text-align: right" ></asp:Label> 
                
            </td>
        </tr>
        <%--<tr>
            <td colspan="4" style="border: thin groove #000000"><div style="width:100%; height:2px; background-color:black;"> </div></td>
        </tr>--%>
        <tr>
            <td colspan="4" style="border: thin groove #000000"><center> <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Large" Text="Bank Account Details" ></asp:Label></center></td>
        </tr>
        <%--<tr>
            <td colspan="4" style="border: thin groove #000000">
                <div style="width:100%; height:2px; background-color:black;"> </div></td>
        </tr>--%>
        <tr>
            <td class="auto-style25" style="border: thin groove #000000">
                <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Name Of Bank"></asp:Label>
            </td>
            <td class="auto-style21" style="border: thin groove #000000">
                
                <asp:Label ID="Label62" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style2" style="border: thin groove #000000">
                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Name As the Bank A/C"></asp:Label>
            </td>
            <td class="auto-style8" style="border: thin groove #000000">
                
                <asp:Label ID="Label65" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24"><asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Size="Medium" Text="Bank A/C No"></asp:Label> </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label63" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style13" style="border: thin groove #000000"><asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Size="Medium" Text="Location Of Branch"></asp:Label> </td>
            <td class="auto-style20" style="border: thin groove #000000">
                
                <asp:Label ID="Label66" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
        </tr>
        <tr>
            <td style="border: thin groove #000000;" class="auto-style24"><asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Size="Medium" Text="IFSC"></asp:Label> </td>
            <td class="auto-style19" style="border: thin groove #000000">
                
                <asp:Label ID="Label64" runat="server" Font-Bold="True" Font-Size="Medium" ></asp:Label> 
                
            </td>
            <td class="auto-style13" style="border: thin groove #000000">&nbsp;</td>
            <td class="auto-style10" style="border: thin groove #000000">&nbsp;</td>
        </tr>
        <tr>
            <td style="border: thin groove #000000; text-align: right;" class="auto-style24" colspan="4"><strong><span class="auto-style34">Sign. </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp; </strong> </td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
