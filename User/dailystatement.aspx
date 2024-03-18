<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="dailystatement.aspx.cs" Inherits="User_dailystatement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    Width="100%" CellPadding="4" 
                    onrowcommand="GridView2_RowCommand" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowCancelingEdit="GridView2_RowCancelingEdit">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
               
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# Eval("username") %>'>&quot;&gt;</asp:Label>
                                
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                        <asp:TemplateField HeaderText="Statement">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButtonN" runat="server" CommandArgument='<%#Eval("username") %>' CommandName="Cancel" >View</asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" ShowHeaderWhenEmpty="true" Width="100%">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("date", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="username" HeaderText="User ID" SortExpression="purchase" />
            <asp:BoundField DataField="purchase" HeaderText="Direct Purchase Income" SortExpression="purchase" />
            <asp:BoundField DataField="nextclub" HeaderText="Bonus Income" SortExpression="nextclub" />
            <asp:BoundField DataField="sponser" HeaderText="Direct Sponser Income" SortExpression="sponser" />
            <asp:BoundField DataField="total" HeaderText="Total Income" SortExpression="total" />
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
</asp:Content>

