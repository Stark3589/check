<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="idactiveamt.aspx.cs" Inherits="User_idactiveamt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    Width="100%" CellPadding="4" ForeColor="#333333" GridLines="Vertical" 
                   >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
               
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# Eval("dateofjoin", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>
                                
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                         <asp:BoundField DataField="username" HeaderText="User ID" />
                        <asp:BoundField DataField="name" HeaderText="Name" />
                     
                         <asp:BoundField DataField="amount" HeaderText="Activated Amount" />
                      
                       
                      
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

