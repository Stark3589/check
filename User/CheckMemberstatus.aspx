<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="CheckMemberstatus.aspx.cs" Inherits="User_status" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td colspan="2">
               <center><h3>Check Member Status</h3></center></td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                 <div style="width:100%; height:2px; background-color:Red;"> </div>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 507px">
                Select Type Of Member</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Select Member Type</asp:ListItem>
                    <asp:ListItem Value="active">Verified</asp:ListItem>
                    <asp:ListItem Value="Not active">Not Verified</asp:ListItem>
                    <asp:ListItem>Rejected</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="SEARCH MEMBERS" />
            </td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="4" DataSourceID="SqlDataSource1" 
                    EmptyDataText="NO MEMBER DATA FOUND" Width="90%">
                    <Columns>
                        <asp:BoundField DataField="name" HeaderText="Member Name" 
                            SortExpression="name" />
                        <asp:BoundField DataField="username" HeaderText="Member ID" 
                            SortExpression="username" />
                        <asp:BoundField DataField="password" HeaderText="Password" 
                            SortExpression="password" />
                        <asp:BoundField DataField="fname" HeaderText="Father Name" 
                            SortExpression="fname" />
                        <asp:BoundField DataField="onside" HeaderText="Side" SortExpression="onside" />
                        <asp:BoundField DataField="dateofjoin" HeaderText="Joining date" 
                            SortExpression="dateofjoin" />
                        <asp:BoundField DataField="mobile" HeaderText="Mobile No" 
                            SortExpression="mobile" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ccmbConnectionString %>" 
                    SelectCommand="SELECT [name], [username], [password], [fname], [onside], [dateofjoin], [mobile], [status] FROM [register] WHERE ([status] = @status)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="status" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 507px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

