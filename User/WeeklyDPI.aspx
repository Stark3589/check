<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="WeeklyDPI.aspx.cs" Inherits="User_WDPI" %>

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
                <center><h2>Weekly Direct Purchase Income</h2></center></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Enter Distributor ID</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" required></asp:TextBox>
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
                <asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />
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
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns>
                <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
               
                    <HeaderStyle ForeColor="#339933" HorizontalAlign="Center" />
                    <ItemStyle BackColor="#339933" ForeColor="White" HorizontalAlign="Center" />
               
            </asp:TemplateField>
            <asp:BoundField DataField="username" HeaderText="Distributor ID">
                            <HeaderStyle ForeColor="#339933" HorizontalAlign="Center" />
                            <ItemStyle BackColor="#339933" ForeColor="White" HorizontalAlign="Center" />
                            </asp:BoundField>
            <asp:TemplateField HeaderText="Date">

                            <ItemTemplate>

                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("date", "{0:dd/MM/yyyy}") %>'>"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle ForeColor="#339933" HorizontalAlign="Center" />
                            <ItemStyle BackColor="#339933" ForeColor="White" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="purchase" HeaderText="Direct Purchase Income">
                            <HeaderStyle ForeColor="#339933" HorizontalAlign="Center" />
                            <ItemStyle BackColor="#339933" ForeColor="White" HorizontalAlign="Center" />
                            </asp:BoundField>
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

