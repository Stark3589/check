<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="bill.aspx.cs" Inherits="User_bill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="zw-contentpane selectableSection" style="margin-left: 1in; margin-right: 1in; margin-top: 0px; position: relative; height: 862px;">
        <div>
            <h1><center>Invoice</center></h1>

        <br />
            <table class="nav-justified" style="width: 641px">
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 320px">Enter Customer Id</td>
                    <td style="width: 321px">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 320px">&nbsp;</td>
                    <td style="width: 321px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 320px">&nbsp;</td>
                    <td style="width: 321px">
                        <asp:Button ID="Button1" runat="server" CssClass="btn-primary active" OnClick="Button1_Click" Text="find" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 320px">&nbsp;</td>
                    <td style="width: 321px">&nbsp;</td>
                </tr>
            </table>

        </div>
        <div class="zw-endnotecontainer" style="display: none;">
            <div class="endnotestyl"></div>
            <div></div>
        </div>
    </div>
        
    </span>
        
</asp:Content>

