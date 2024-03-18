<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="branchregister.aspx.cs" Inherits="User_branchregister" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2"><strong>Franchise Registeration</strong></td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">Enter User Name</td>
            <td class="text-center">
                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" style="font-weight: 700; color: #006600" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-center">Franchise Name</td>
            <td class="text-center">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">City Name</td>
            <td class="text-center">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: medium;
            color: #FF0000;
        }
        .auto-style2 {
            text-align: center;
            height: 40px;
        }
    </style>
</asp:Content>


