<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="WeeklyBonus.aspx.cs" Inherits="newuser_WBonus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <center> <h4>Withdrawal Report</h4></center>
    <hr />
    <div style="overflow-x: scroll; width:100%; height:100%"
     <asp:Panel ID="Panel2" runat="server">
                    <asp:GridView ID="gvDetails" DataKeyNames="id" AutoGenerateColumns="False" CellPadding="5" runat="server" Visible="False" Width="90%" class="table table-bordered table-striped dataTable1">
                        <Columns>
                            <asp:BoundField HeaderText="Id" DataField="id" />
                           
                            <asp:BoundField HeaderText="UserName" DataField="username" />
                            <asp:BoundField HeaderText="Name" DataField="name" />
                            <asp:TemplateField HeaderText="Withdrawal Date">
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("dates","{0:dd/MM/yyyy}") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Withdrawal Amount" DataField="amount" />
                            
                             <asp:BoundField HeaderText="Txn Charge" DataField="admin" />
                         
                             <asp:BoundField HeaderText="Transfer In" DataField="remarks" />
                            
                            <asp:BoundField HeaderText="Status" DataField="status" />
                            <asp:TemplateField HeaderText="Update Date">
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("sdate","{0:dd/MM/yyyy}") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                           
                        </Columns>
                        <HeaderStyle BackColor="#df5015" Font-Bold="true" ForeColor="White" />
                    </asp:GridView>
                </asp:Panel>
         </div>
</asp:Content>

