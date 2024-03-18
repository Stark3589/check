<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="unusedpin.aspx.cs" Inherits="User_unusedpin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        table {
            background-color: transparent;
            margin-left: initial;
        }
    </style>


    <div class="container padd">
        <div class="row">
            <div class="col-md-8">
                <center><h3>Un-Used Pin List</h3></center>
            </div>
            <div class="col-md-8">
                <center>
                    <div style="overflow-x:scroll;">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="100%">
                    <Columns>
                    <asp:TemplateField HeaderText="Sr.No.">
        <ItemTemplate>
             <%#Container.DataItemIndex+1 %>
        </ItemTemplate>
    </asp:TemplateField>
                   
                        <asp:BoundField DataField="holder" HeaderText="Username" />
                        <asp:BoundField DataField="amt" HeaderText="RP" />
                        <asp:BoundField DataField="pin" HeaderText="Pin" />
                   <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# Eval("createdate", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>
                                
                            </ItemTemplate>
                        </asp:TemplateField>
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
                        </div>
                  </center>
            </div>
        </div>
    </div>
</asp:Content>

