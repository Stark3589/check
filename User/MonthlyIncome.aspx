<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="MonthlyIncome.aspx.cs" Inherits="User_MonthlyIncome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table class="nav-justified">
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
            <td colspan="2">
                Data Without Zero Amount</td>
        </tr>
        <tr>
            <td colspan="2">
                <div style="overflow:auto;max-height:450px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    Width="100%" EmptyDataText="No Record Found">
                    <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
            </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("date", "{0:dd/MM/yyyy}") %>'>"></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="name" HeaderText="Name" 
                            SortExpression="name" />
                            <asp:BoundField DataField="username" HeaderText="User ID" 
                            SortExpression="username" />
                            <asp:BoundField DataField="mobile" HeaderText="Mobile" 
                            SortExpression="mobile" />
                        <asp:BoundField DataField="fix" HeaderText="Turnover Income" 
                            SortExpression="purchase" />
                        <asp:BoundField DataField="repurchase" HeaderText="Repurchase Income" 
                            SortExpression="nextclub" />
                        <asp:BoundField DataField="reward" HeaderText="Reward Income" 
                            SortExpression="sponser" />
                            <asp:BoundField DataField="total" HeaderText="Total Income" 
                            SortExpression="total" />
                    </Columns>
                </asp:GridView>
                    </div>
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
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                Data With Zero Amount</td>
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
            <td colspan="2">
                <div  style="overflow:auto;max-height:450px">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    Width="100%" EmptyDataText="No Record Found">
                    <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
            </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("date", "{0:dd/MM/yyyy}") %>'>"></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="name" HeaderText="Name" 
                            SortExpression="name" />
                            <asp:BoundField DataField="username" HeaderText="User ID" 
                            SortExpression="username" />
                            <asp:BoundField DataField="mobile" HeaderText="Mobile" 
                            SortExpression="mobile" />
                        <asp:BoundField DataField="fix" HeaderText="Turnover Income" 
                            SortExpression="purchase" />
                        <asp:BoundField DataField="repurchase" HeaderText="Repurchase Income" 
                            SortExpression="nextclub" />
                        <asp:BoundField DataField="reward" HeaderText="Reward Income" 
                            SortExpression="sponser" />
                            <asp:BoundField DataField="total" HeaderText="Total Income" 
                            SortExpression="total" />
                    </Columns>
                </asp:GridView>
                    </div>
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

