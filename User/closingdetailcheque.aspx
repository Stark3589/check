<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="closingdetailcheque.aspx.cs" Inherits="User_closingdetailcheque" %>

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
                <h2>Closing Detail</h2>
                <p style="font-size: x-large; color: #006600;">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
&nbsp; To&nbsp;
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </p></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
               <center> <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
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
                       <asp:BoundField DataField="monthly" HeaderText="Month No." >
                       <ItemStyle HorizontalAlign="Center" />
                       </asp:BoundField>
                       <asp:TemplateField HeaderText="View Details">
                                        
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("id") %>' CommandName="VIEW" >View</asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>
                   </Columns>
                </asp:GridView></center>
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
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"  OnRowCommand="GridView2_RowCommand"
                    Visible="False" Width="100%" OnRowDataBound="GridView2_RowDataBound1" >
                    <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
               
            </asp:TemplateField>
                        <asp:BoundField DataField="username" HeaderText="Distributor ID" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        
                        
                       <asp:BoundField DataField="name" HeaderText="Name" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                       <%-- <asp:BoundField DataField="mobile" HeaderText="Mobile" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>--%>

                        <asp:BoundField DataField="purchase" HeaderText="Direct Purchase Income" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sponser" HeaderText="Direct Sponser Income" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nextclub" HeaderText="Bonus Income" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="total_amount" HeaderText="Total Amount" />
                        <asp:BoundField DataField="tds" HeaderText="TDS" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="admincharge" HeaderText="Admin Charge" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="payble_amount" HeaderText="Payable Amount" >
                         <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                         <asp:TemplateField HeaderText="Payment Details">
                                        
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("username") %>' CommandName="VIEW" ForeColor="Red">Payment Details</asp:LinkButton>
                            </ItemTemplate>

                             <ItemStyle HorizontalAlign="Center" />

                        </asp:TemplateField>
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
            <td colspan="2">
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False"
                    Visible="False" Width="100%" OnRowCommand="GridView3_RowCommand" >
                    <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
               
            </asp:TemplateField>
                        <asp:BoundField DataField="username" HeaderText="Distributor ID" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="name" HeaderText="Name" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="mobile" HeaderText="Mobile" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="purchase" HeaderText="Direct Purchase Income" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sponser" HeaderText="Direct Sponser Income" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nextclub" HeaderText="Next Club Income" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tds" HeaderText="TDS" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="adm" HeaderText="Admin Charge" >
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="payable" HeaderText="Payable Amount" >
                         <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                         <asp:BoundField DataField="bank" HeaderText="Bank Name" >
                         <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cheque" HeaderText="Cheque No." >
                         <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Issue Date">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("cdate", "{0:dd/MM/yyyy}") %>'>"></asp:Label>
                            </ItemTemplate>
                                                         <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Payment Details">
                                        
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("username") %>' CommandName="VIEW" ForeColor="#00CC00">Update</asp:LinkButton>
                            </ItemTemplate>

                             <ItemStyle HorizontalAlign="Center" />

                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
               
            </td>
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

