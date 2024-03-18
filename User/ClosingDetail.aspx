<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="ClosingDetail.aspx.cs" Inherits="User_ClosingDetail" %>

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
                <h2>Closing Detail</h2></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
               <center> <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
                   <Columns>
                       
                       <asp:TemplateField HeaderText="Select Record">  
                   
                    <ItemTemplate>  
                        <asp:CheckBox ID="CheckBox1" runat="server" />  
                    </ItemTemplate>  
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
               
            </asp:TemplateField>
                       <asp:TemplateField HeaderText="Date From">

                            <ItemTemplate>

                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("date1", "{0:dd/MM/yyyy}") %>'>"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date To">

                            <ItemTemplate>

                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("date2", "{0:dd/MM/yyyy}") %>'>"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                      
                     
                   </Columns>
                </asp:GridView>
                   <br />
                   <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Record" />
                </center>
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
                <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" Width="100%">
                    <AlternatingRowStyle BackColor="White" />
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

