<%@ Page Language="C#" AutoEventWireup="true" CodeFile="printreceipt.aspx.cs" Inherits="User_printreceipt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>window.print()</script>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
        }
        .style4
        {
            height: 23px;
        }
        .style11
        {            font-weight: 700;
        }
        .style12
        {
            height: 23px;
            width: 364px;
        }
        .style13
        {
        }
        .style14
        {
            text-align: left;
        }
        .style17
        {
            height: 23px;
            width: 110px;
            font-weight: bold;
        }
        .style18
        {
            width: 110px;
            font-weight: bold;
        }
        .style19
        {
            height: 23px;
            width: 255px;
            font-weight: bold;
        }
        .style20
        {
            width: 255px;
            font-weight: bold;
        }
        .auto-style1 {
            text-align: center;
            height: 20px;
            font-size: x-large;
            font-weight: bold;
        }
        .auto-style2 {
            width: 438px;
        }
        .auto-style3 {
            width: 192px;
        }
        .auto-style4 {
            width: 219px;
        }
        .auto-style5 {
            font-weight: bold;
        }
        .auto-style6 {
            text-align: right;
            font-weight: bold;
        }
        .auto-style8 {
            width: 99px;
        }
        .auto-style9 {
            font-weight: bold;
            text-align: left;
        }
        .auto-style10 {
            font-weight: 700;
            text-align: left;
        }
        .auto-style11 {
            width: 371px;
            text-align: center;
        }
        .auto-style12 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <table class="style1" >
            <tr>
                <td class="style14" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    Registration Payment Detail</td>
            </tr>
            <tr>
                <td class="style13" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <span style="font-size:smaller;">TIN No. 09807314059</span></td>
                <td class="auto-style12" colspan="2">
                    <span style="font-size:smaller;">STN No. AAFCN0477LSD001</span></td>
            </tr>
            <tr>
                <td class="style14" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;To,</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Name : <asp:Label ID="Label2" runat="server" ></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; C/O Name : <asp:Label ID="Label3" runat="server" ></asp:Label>
                    </td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Address : <asp:Label ID="Label4" runat="server" ></asp:Label></td>
            </tr>
            <tr>
                <td class="style14" colspan="3">
                    <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; Dist-
                    <asp:Label ID="Label7" runat="server" ></asp:Label>
                    , Pin:
                    <asp:Label ID="Label8" runat="server" ></asp:Label>
                    </b>&nbsp;<b><asp:Label ID="Label9" runat="server" ></asp:Label>
                    </b>
                    </td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Mob : <asp:Label ID="Label5" runat="server" ></asp:Label></td>
            </tr>
            
            <tr>
                <td class="style2" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" colspan="3">
                    <div>


                        <asp:Panel ID="Panel1" runat="server">
                            <table class="style1">
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2"><b><u>Payment Details :</u></b></td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2">Agriculture Products Kit :</td>
                                    <td>Rs.
                                        <asp:Label ID="Label11" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2">Distributor Charge :</td>
                                    <td>Rs. 121.00</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2">Courier Charge :</td>
                                    <td>Rs. 50.00</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2">Service Tax :</td>
                                    <td>Rs. 29.00</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2">&nbsp;</td>
                                    <td>--------------------</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2">Net Amount :</td>
                                    <td>Rs.
                                        <asp:Label ID="Label12" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2">&nbsp;</td>
                                    <td>--------------------</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style2" colspan="2">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style4"><strong>User ID : </strong></td>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label6" runat="server" style="font-weight: 700" ></asp:Label>
                                    </td>
                                    <td class="auto-style6">Thanks &amp; Regards,</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style4"><strong>Receipt No. :</strong></td>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label1" runat="server" CssClass="auto-style5" ></asp:Label>
                                    </td>
                                    <td class="auto-style6">Nextrade Sales India Pvt. Ltd.</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style4"><strong>Joining Date :</strong></td>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label10" runat="server" CssClass="auto-style5" ></asp:Label>
                                    </td>
                                    <td class="auto-style6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">&nbsp;</td>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style6">Auth. Sign.</td>
                                </tr>
                            </table>
                        </asp:Panel>


                    </div></td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
