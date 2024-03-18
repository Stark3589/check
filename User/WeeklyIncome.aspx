<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="WeeklyIncome.aspx.cs" Inherits="User_WeeklyIncome" %>

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
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="true" 
                    Width="100%" CellPadding="4" ForeColor="#333333">
                    <AlternatingRowStyle BackColor="White" />
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
                         <asp:BoundField DataField="username" HeaderText="User ID" 
                            SortExpression="purchase" />
                        <asp:BoundField DataField="purchase" HeaderText="Direct Purchase Income" 
                            SortExpression="purchase" />
                        <asp:BoundField DataField="nextclub" HeaderText="Bonus Income" 
                            SortExpression="nextclub" />
                        <asp:BoundField DataField="sponser" HeaderText="Direct Sponser Income" 
                            SortExpression="sponser" />
                            <asp:BoundField DataField="total" HeaderText="Total Income" 
                            SortExpression="total" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
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
            <td colspan="2">
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

