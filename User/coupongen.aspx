<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="coupongen.aspx.cs" Inherits="User_coupongen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified" style="width: 833px">
        <tr>
            <td colspan="6"><center><h3>Coupon Generator</h3></center></td>
            
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">Enter Id</td>
            <td colspan="3" style="width: 417px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
                <asp:Button ID="Button1" runat="server" CssClass="btn-primary" OnClick="Button1_Click" Text="Find" />
&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" CssClass="btn-primary" OnClick="Button2_Click" Text="Generate" />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#FF3399" Text="no-code"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 416px">&nbsp;</td>
            <td style="width: 416px">
                <asp:Label ID="Label4" runat="server" style="color: #3333CC" Text="1000"></asp:Label>
            </td>
            <td style="width: 416px">&nbsp;</td>
            <td style="width: 417px">
                <asp:Label ID="Label5" runat="server" style="color: #3333CC" Text="500"></asp:Label>
            </td>
            <td style="width: 417px">&nbsp;</td>
            <td style="width: 417px">
                <asp:Label ID="Label6" runat="server" style="color: #3333CC" Text="100"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 416px">&nbsp;</td>
            <td style="width: 416px">
                <asp:TextBox type="number" ID="TextBox2" runat="server" BackColor="#66FFFF">0</asp:TextBox>
            </td>
            <td style="width: 416px">&nbsp;</td>
            <td style="width: 417px">
                <asp:TextBox type="number"  ID="TextBox3" runat="server" BackColor="#66FFFF">0</asp:TextBox>
            </td>
            <td style="width: 417px">&nbsp;</td>
            <td style="width: 417px">
                <asp:TextBox type="number"  ID="TextBox4" runat="server" BackColor="#66FFFF">0</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">
                <asp:Button ID="Button3" runat="server" CssClass="btn-primary focus" OnClick="Button3_Click" Text="Continue" />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="width: 416px">&nbsp;</td>
            <td colspan="3" style="width: 417px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

