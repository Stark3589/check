<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="companyprofit.aspx.cs" Inherits="User_companyprofit" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td>Select Date From</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <ajax:CalendarExtender ID="CalendarExtender3" TargetControlID="TextBox1" Format="yyyy-MM-dd" runat="server">
                </ajax:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td>Select Date To</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <ajax:CalendarExtender ID="CalendarExtender1" TargetControlID="TextBox2" Format="yyyy-MM-dd" runat="server">
                </ajax:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Show" OnClick="Button1_Click" Width="97px" />
                <br />
            </td>
        </tr>
        <tr>
            <td><b>Total Pay Amount</b></td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td><b>Total Collected Amount</b></td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td><b>Final Amount</b></td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

