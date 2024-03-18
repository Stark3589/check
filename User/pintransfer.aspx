<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="pintransfer.aspx.cs" Inherits="User_pintransfer1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
    <tr>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>Enter Username</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td>&nbsp;</td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td>Name</td>
        <td>
            <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
        </td>
    </tr>
        <tr>
        <td>&nbsp;</td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td>Pin Amount</td>
        <td>
                <asp:DropDownList ID="DropDownList2" runat="server" Width="160px">
                    <asp:ListItem Selected="True">Select</asp:ListItem>
                      
                    <asp:ListItem Value="500">500</asp:ListItem>
                    
                
                
                </asp:DropDownList>
            </td>
    </tr>
        <tr>
        <td>&nbsp;</td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td>Transfer Pin</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td>&nbsp;</td>
        <td>
                &nbsp;</td>
    </tr>
   
    <tr>
        <td class="auto-style1"></td>
        <td class="auto-style1">
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Franchise" Visible="false" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Transfer" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

