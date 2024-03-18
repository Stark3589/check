<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="ActiveReport.aspx.cs" Inherits="User_ActiveReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
            <center><h2>Direct Member Report List</h2></center>
       
           <div class="col-md-12" style="overflow:auto">
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
                         <asp:TemplateField HeaderText="User Name">
                            <ItemTemplate>
                                
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("reff") %>'>&quot;&gt;</asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
            <asp:TemplateField HeaderText="Member 1">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# Eval("l") %>'>&quot;&gt;</asp:Label>
                                
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                        <asp:TemplateField HeaderText="Member 2">
                            <ItemTemplate>
                                
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("m") %>'>&quot;&gt;</asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Member 3">
                            <ItemTemplate>
                                <asp:Label ID="Labell" runat="server" Text='<%# Eval("r") %>' >&quot;&gt;</asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                        
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
 </div>
</asp:Content>

