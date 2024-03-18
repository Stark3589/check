<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="DirectList11.aspx.cs" Inherits="User_Directlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td colspan="2"><center><h3>Sponser List</h3></center>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4"  Width="100%" ForeColor="#333333" OnRowDataBound="GridView1_RowDataBound" 
                   >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Sr.No.">
                            <ItemTemplate>
             <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date &amp; Time">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# Eval("dateofjoin", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("rtime") %>'>&quot;&gt;</asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:BoundField DataField="username" HeaderText="User ID" SortExpression="username" />
                        <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                        <asp:BoundField DataField="mobile" HeaderText="Mobile" 
                            SortExpression="mobile" />
                        <asp:BoundField DataField="sponser" HeaderText="Sponser" SortExpression="sponser" />
                        <asp:BoundField DataField="status" HeaderText="Status" SortExpression="sponser" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
               
               
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

