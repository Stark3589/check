<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="transferamount.aspx.cs" Inherits="User_transferamount" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" tagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">
                <center> <asp:GridView ID="gvrclo" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" Width="75%">
                   <Columns>
                   <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
               
            </asp:TemplateField>
                       <asp:TemplateField HeaderText="Date From">

                            <ItemTemplate>

                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("datefrom", "{0:dd/MM/yyyy}") %>'>"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date To">

                            <ItemTemplate>

                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("dateto", "{0:dd/MM/yyyy}") %>'>"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                      
                       
                        <asp:TemplateField HeaderText="View Details">
                                        
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("id") %>' CommandName="hello" >View</asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>
                   </Columns>
                </asp:GridView></center></td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-right">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-right">
               
                <asp:Button ID="print" runat="server" Text="Print Report" Width="250px" OnClick="print_Click" Visible="false" CssClass="form-control btn btn-success" />
            </td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" class="text-center">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" Width="100%">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>

                         <asp:TemplateField HeaderText="Select Data">  
                    
                    <ItemTemplate>  
                        <asp:CheckBox ID="CheckBox1" runat="server" />  
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
            </td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Transfer"  Visible="false"/>
            </td>
        </tr>
    </table>
</asp:Content>

