<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="MonthlyStatement.aspx.cs" Inherits="newuser_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        table {
    background-color: transparent;
    margin-left: 0px;
}
    </style>
    <div style="overflow-x:scroll">
    <table class="nav-justified">
        
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  Width="100%" class="table table-bordered table-striped dataTable1">
                    <Columns>
                    <asp:TemplateField HeaderText="Sr.No.">
        <ItemTemplate>
             <%#Container.DataItemIndex+1 %>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Payment Date">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("date", "{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="username" HeaderText="User ID" />
                        <asp:BoundField DataField="name" HeaderText="Name" />
                        
                        <asp:BoundField DataField="mobile" HeaderText="Mobile" />
                        <asp:BoundField DataField="total" HeaderText="Income" />
                        <asp:BoundField DataField="mop" HeaderText="Mode Of Payment" />
                        <asp:BoundField DataField="chqno" HeaderText="Cheque No" />
                        <asp:BoundField DataField="bankname" HeaderText="Bank Name" />
                        <asp:BoundField DataField="branch" HeaderText="Branch" />
                          <asp:TemplateField HeaderText="Cheque Date">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("chequedate", "{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
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
        </div>
</asp:Content>

