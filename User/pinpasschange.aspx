<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="pinpasschange.aspx.cs" Inherits="User_pinpasschane" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td style="width: 492px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;<center><h3>Pin Password Change</h3></center></td>
        </tr>
        <tr>
            <td style="width: 492px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 492px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 492px">Old Password</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"
                     TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 492px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 492px">New Password</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" 
                     TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 492px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 492px">Confirm Password</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"
                    TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 492px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 492px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="#0033CC" ForeColor="#99CCFF" 
                    onclick="Button1_Click" Text="Update" />
            </td>
        </tr>
        <tr>
            <td style="width: 492px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

