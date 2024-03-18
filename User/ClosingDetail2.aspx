<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="ClosingDetail2.aspx.cs" Inherits="User_CD2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <center> <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="70%" OnRowCommand="GridView1_RowCommand">
                   <Columns>
                   <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
               
            </asp:TemplateField>
                       <asp:TemplateField HeaderText="Closing Date">

                            <ItemTemplate>

                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("datefrom", "{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                       
                      
                       <asp:TemplateField HeaderText="View Details">
                                        
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("datefrom", "{0:dd/MM/yyyy}") %>' CommandName="VIEW" >View</asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>
                       
                   </Columns>
                </asp:GridView>
               
    </center>
</asp:Content>

