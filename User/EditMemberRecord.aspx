<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="EditMemberRecord.aspx.cs" Inherits="User_memberedit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <center><h3> EDIT MEMBER RECORD</h3></center>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <div style="width:100%; height:2px; background-color:Red;"> </div>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;&nbsp;Select Member ID</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="SUBMIT" />
            </td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                MOBILE NO EDIT</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;<div style="width:100%; height:2px; background-color:Red;"> </div></td>
        </tr>
        <tr>
            <td style="width: 506px">
                Enter Mobile No</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                    Text="Update Mobile No" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div style="width:100%; height:2px; background-color:Red;"> </div>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                ADDRESS UPDATE</td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <div style="width:100%; height:2px; background-color:Red;"> </div>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                Select State</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
         <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                Select City</td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
         <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                Enter Pin Code</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 506px">
                Enter Address</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button2" runat="server" Text="UPDATE ADDRESS" 
                    onclick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
             <div style="width:100%; height:2px; background-color:Red;"> </div>   &nbsp;</td>
        </tr>
         <tr>
            <td colspan="2">
                UPDATE BANK DETAILS</td>
        </tr>
         <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
         <tr>
            <td colspan="2">
                <div style="width:100%; height:2px; background-color:Red;"> </div>&nbsp;</td>
        </tr>
         <tr>
            <td colspan="2">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="4" DataKeyNames="int" DataSourceID="SqlDataSource2" Width="70%">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:BoundField DataField="int" HeaderText="int" SortExpression="int" 
                            InsertVisible="False" ReadOnly="True" Visible="False" />
                        <asp:BoundField DataField="username" HeaderText="Member Id" 
                            SortExpression="username" Visible="False" />
                        <asp:BoundField DataField="accno" HeaderText="A/C No" SortExpression="accno" />
                        <asp:BoundField DataField="bankname" HeaderText="Bank Name" 
                            SortExpression="bankname" />
                        <asp:BoundField DataField="ifsc" HeaderText="IFSC" 
                            SortExpression="ifsc" />
                        <asp:BoundField DataField="branchname" HeaderText="Branch Address" 
                            SortExpression="branchname" />
                        <asp:BoundField DataField="holdername" HeaderText="A/C Holder Name" 
                            SortExpression="holdername" />
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
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ccmbConnectionString %>" 
                    DeleteCommand="DELETE FROM [bankdetail] WHERE [int] = @int" 
                    InsertCommand="INSERT INTO [bankdetail] ([username], [accno], [bankname], [ifsc], [branchname], [holdername]) VALUES (@username, @accno, @bankname, @ifsc, @branchname, @holdername)" 
                    SelectCommand="SELECT * FROM [bankdetail] WHERE ([username] = @username)" 
                    
                    UpdateCommand="UPDATE [bankdetail] SET [username] = @username, [accno] = @accno, [bankname] = @bankname, [ifsc] = @ifsc, [branchname] = @branchname, [holdername] = @holdername WHERE [int] = @int">
                    <DeleteParameters>
                        <asp:Parameter Name="int" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="username" Type="String" />
                        <asp:Parameter Name="accno" Type="String" />
                        <asp:Parameter Name="bankname" Type="String" />
                        <asp:Parameter Name="ifsc" Type="String" />
                        <asp:Parameter Name="branchname" Type="String" />
                        <asp:Parameter Name="holdername" Type="String" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="username" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="username" Type="String" />
                        <asp:Parameter Name="accno" Type="String" />
                        <asp:Parameter Name="bankname" Type="String" />
                        <asp:Parameter Name="ifsc" Type="String" />
                        <asp:Parameter Name="branchname" Type="String" />
                        <asp:Parameter Name="holdername" Type="String" />
                        <asp:Parameter Name="int" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
             </td>
        </tr>
         <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
         <tr>
            <td style="width: 506px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

