<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="WeeklyStatement.aspx.cs" Inherits="User_WeeklyStatement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table class="nav-justified">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <center><h2>Daily Statement</h2></center></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    Width="100%">
                    <Columns>
                    <asp:TemplateField>
        <ItemTemplate>
             <%#Container.DataItemIndex+1 %>
        </ItemTemplate>
    </asp:TemplateField>
                        <asp:BoundField DataField="username" HeaderText="User ID" />
                        <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("date", "{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="purchase" HeaderText="Direct Purchase Income" />
                        <asp:BoundField DataField="nextclub" HeaderText="Bonus Income" />
                        <asp:BoundField DataField="sponser" HeaderText="Direct Sponser Income" />
                        <asp:BoundField DataField="repurchase" HeaderText="Repurchase Income" />
                        <asp:BoundField DataField="reward" HeaderText="Reward Income" />
                        <asp:BoundField DataField="fix" HeaderText="Turnover Income" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <strong>Total Purchase Income</strong></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Total Bonus In</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

