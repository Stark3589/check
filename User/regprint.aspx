<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="regprint.aspx.cs" Inherits="User_regprint" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td style="width: 442px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="height: 33px">
                <h2>Print Registration Details</h2>
            </td>
        </tr>
        <tr>
            <td style="height: 24px; width: 442px"></td>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td style="width: 442px">Enter User Id</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 442px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 21px; width: 442px;"></td>
            <td style="height: 21px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            </td>
        </tr>
        <tr>
            <td style="width: 442px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 442px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

