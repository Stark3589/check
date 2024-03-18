<%@ Page Language="C#" AutoEventWireup="true" CodeFile="billprint.aspx.cs" Inherits="User_billprint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        window.print();
    </script>
   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 
        {
            width: 208px;
        }
        .auto-style4 
        {
            width: 405px;
        }
        .auto-style5 
        {
            width: 180px;
        }
        .auto-style6 
        {
            text-align: left;
        }
        .auto-style8 
        {
            text-align: center;
            width: 193px;
            height: 36px;
        }
        .auto-style9 {
            text-align: center;
            width: 78px;
        }
        .auto-style13 {
            text-align: center;
            width: 67px;
            height: 36px;
        }
        .auto-style15 {
            text-align: center;
            font-weight: bold;
        }
        .auto-style16 {
            font-weight: bold;
        }
        .auto-style17 {
            width: 418px;
            height: 23px;
        }
        .auto-style19 {
            width: 418px;
        }
        .auto-style20 {
            height: 20px;
            width: 418px;
        }
        .auto-style21 {
            text-align: right;
            height: 18px;
        }
        .auto-style22 {
            font-size: xx-large;
            }
        .auto-style23 {
            text-align: left;
            height: 18px;
            width: 418px;
        }
        .auto-style24 {
            text-decoration: underline;
        }
        .auto-style25 {
            text-align: left;
            width: 193px;
        }
        .auto-style26 {
            text-align: right;
        }
        .auto-style28 {
            text-align: right;
            width: 67px;
        }
        .auto-style30 {
            text-align: center;
            height: 36px;
        }
        .auto-style31 {
            text-align: center;
            width: 78px;
            height: 36px;
        }
        .auto-style35 {
            text-align: left;
            font-weight: bold;
        }
        .auto-style36 {
            font-size: medium;
        }
    </style>
   
</head>
<body>
    <form id="form1" runat="server">
    <center><div>
     <div class="zw-paragraph" data-width="624" data-textformat="{&quot;size&quot;:12}">
<br/> 
            <br/>            

            <table class="nav-justified" style="text-align: left; width: 641px;">
                <tr>
                    <td ><img src="../images/logo1.png" style="width: 178px; height: 75px" />&nbsp;<strong><span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style22"> <span class="auto-style24">INVOICE</span></span></span></strong></td>
                </tr>
                </table>
        
   
        
            <table class="nav-justified" style="text-align: left; width: 641px;">
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">To,</td>
                    <td style="width: 321px">From:</td>
                </tr>
                </table>
        
   
        
         <table class="nav-justified" style="text-align: left; width: 641px;">
                <tr>
                    
                    <td class="auto-style19">
                    <b>Name : 
                    <asp:Label ID="Label1" runat="server" ></asp:Label></b>
                    </b>
                    </td>
                    <td style="width: 321px"> &nbsp;<strong>Mahi Bio</strong></td>
        
   
        
                </tr>
                <tr>
                    
                    <td class="auto-style20">
                    <b>C/O Name :
                    <asp:Label ID="Label2" runat="server" ></asp:Label></b>
        
                    </td>
                    <td style="height: 20px; width: 321px;"><span style="font-size:12.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;;mso-ascii-theme-font:minor-latin;mso-fareast-font-family:
Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-theme-font:minor-latin;
mso-bidi-theme-font:minor-latin;mso-ansi-language:EN-US;mso-fareast-language:
EN-US;mso-bidi-language:AR-SA">BAREILLY – 243001, U.P. (INDIA)</span></td>
        
  
        
                </tr>
                <tr>
                    
                    <td class="auto-style19"><strong>Address : 
                    <asp:Label ID="Label3" runat="server" ></asp:Label>
                        </strong></td>
                    <td style="width: 321px"> <strong></strong></td>
        
    
        
                </tr>
                <tr>
                    
                    <td class="auto-style20"><strong>Dist-
                    <asp:Label ID="Label12" runat="server" ></asp:Label>
                        , Pin :
                    <asp:Label ID="Label5" runat="server" ></asp:Label>
                        </strong>&nbsp;<strong><asp:Label ID="Label4" runat="server" ></asp:Label>
                        </strong></td>
                    <td style="width: 321px"> Invoice No: <asp:Label ID="Label6" runat="server" CssClass="auto-style16"></asp:Label></td>
        
    
        
                </tr>
                <tr>
                    <td class="auto-style17">
                    <b>Mob : 
                    <asp:Label ID="Label13" runat="server" ></asp:Label>
                    </b>
                    </td>
                    <td style="width: 321px"> Invoice date <asp:Label ID="Label7" runat="server" CssClass="auto-style16"></asp:Label></td>
                </tr>
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td style="width: 321px">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td style="width: 321px"> &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td style="width: 321px"> &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Panel ID="Panel1" runat="server">
                            <table class="auto-style1" style="border: thin groove #000000">
                                <tr>
                                    <td class="auto-style30" style="border: thin groove #000000"><strong>SN</strong></td>
                                    <td class="auto-style8" style="border: thin groove #000000"><span class="zw-portion" data-text-len="11" style="font-weight: bold;">Description</span><span class="EOP EOP-readonly">&nbsp;</span></td>
                                    <td class="auto-style31" style="border: thin groove #000000"><span class="zw-portion" data-text-len="2" style="font-weight: bold;">Qty</span></td>
                                    <td class="auto-style13" style="border: thin groove #000000"><span class="zw-portion" data-text-len="5" style="font-weight: bold;">Disc%</span></td>
                                    <td class="auto-style30" style="border: thin groove #000000"><span class="zw-portion" data-text-len="11" style="font-weight: bold;">Net&nbsp;Amount</span></td>
                                </tr>
                                <tr>
                                    <td class="auto-style15" style="border: thin groove #000000">1</td>
                                    <td class="auto-style25" style="border: thin groove #000000"><span class="auto-style1" data-text-len="8" style="">Anti Radiation Chip</span></td>
                                    <td class="auto-style9" style="border: thin groove #000000">1</td>
                                    <td class="auto-style28" style="border: thin groove #000000"><span class="auto-style1" data-text-len="5" style="">0.00%</span><span class="auto-style1">&nbsp;</span></td>
                                    <td class="auto-style26" style="border: thin groove #000000">616.00</td>
                                </tr>
                                <tr>
                                    <td class="auto-style35" colspan="4" style="border: thin groove #000000"><span class="zw-portion" data-text-len="10" style="font-weight: bold;">SUB&nbsp;TOTAL:</span><span class="EOP EOP-readonly">&nbsp;</span></td>
                                    <td class="auto-style26" style="border: thin groove #000000"><span class="zw-portion" data-text-len="2" style="">616</span><span class="EOP EOP-readonly">&nbsp;</span></td>
                                </tr>
                                <tr>
                                    <td class="auto-style6" colspan="4" style="border: thin groove #000000"><span class="zw-portion" data-text-len="8" style="font-weight: bold;">GST 5%:</span></td>
                                    <td class="auto-style26" style="border: thin groove #000000">33<span class="EOP EOP-readonly">&nbsp;</span></td>
                                </tr>
                                <tr>
                                    <td class="auto-style6" colspan="4" style="border: thin groove #000000"><span class="zw-portion" data-text-len="12" style="font-weight: bold; font-size: 12pt;">GRAND&nbsp;TOTAL:</span></td>
                                    <td class="auto-style26" style="border: thin groove #000000"><span class="zw-portion" data-text-len="4" style="font-weight: bold; font-size: 12pt;">649</span><span class="EOP EOP-readonly">&nbsp;INR</span></td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: left;" class="auto-style19"><span class="zw-portion" data-text-len="7" style="font-weight: bold; font-size: 13pt;"><span class="zw-portion" data-text-len="20" style="font-size: 12pt;">(Applicant&nbsp;Sign.)</span></span><span class="zw-portion" data-text-len="30" style="font-weight: bold; font-size: 13pt; text-align: left;">
                    </span></td>
                    <td style="text-align: right;"><span class="zw-portion" data-text-len="1" style="font-size: 12pt;">(</span><span class="zw-portion" data-text-len="20" style="font-size: 12pt;">Authorized&nbsp;Signatory</span><span class="zw-portion" data-text-len="1" style="font-size: 12pt;">)</span></td>
                </tr>
                <tr>
                    <td class="auto-style23"><span class="EOP EOP-readonly"> <asp:Label ID="Label10" runat="server" style="color: #000000; font-weight: 700; text-align: left;"></asp:Label>
                    </span></td>
                    <td class="auto-style21"><span class="auto-style36" data-text-len="30" style="font-weight: bold; text-align: left;">Mahi Bio.</span></td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
            </table>
        
   
        
        </div>
    </div>
        </center>
    </form>
</body>
</html>
