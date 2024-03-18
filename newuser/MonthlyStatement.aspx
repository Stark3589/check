<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="MonthlyStatement.aspx.cs" Inherits="newuser_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
   
    <center><h4><asp:Label ID="Label2" runat="server" ></asp:Label></h4></center>
    <hr />
   
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1"
                    Width="100%">
                    <Columns>
                    <asp:TemplateField HeaderText="Sr. No">  
        <ItemTemplate>
             <%#Container.DataItemIndex+1 %>
        </ItemTemplate>
    </asp:TemplateField>
                        <asp:BoundField DataField="username" HeaderText="User ID" />
                        <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("date", "{0:dd/MM/yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="credit" HeaderText="Income" />
                        
                    </Columns>
                </asp:GridView>
      
           
</asp:Content>

