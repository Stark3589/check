<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="printform.aspx.cs" Inherits="User_printform" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table class="nav-justified">
        <tr>
            <td style="height: 24px; width: 442px">&nbsp;</td>
            <td style="height: 24px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 24px; " colspan="2">Print Registration Details</td>
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
        <tr>
            <td style="width: 442px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 442px">&nbsp;</td>
            <td>&nbsp;</td>
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

