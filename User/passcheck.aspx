<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="passcheck.aspx.cs" Inherits="User_passckr" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <style>
        table
        {
            margin-left:0px;
        }
    </style>
    <center><h4>PASSWORD OF USER</h4></center>
       <hr />
 <div class="row">
           
            <div class="col-md-12" style="overflow:auto">
                <asp:GridView ID="GridView1" runat="server" UseAccessibleHeader="true" OnRowDataBound="GridView1_RowDataBound" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1"  Width="100%" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                    <asp:TemplateField HeaderText="Sr.No.">
        <ItemTemplate>
             <%#Container.DataItemIndex+1 %>
        </ItemTemplate>
    </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# Eval("dateofjoin", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Time">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("rtime") %>'>&quot;&gt;</asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                        <asp:BoundField DataField="mobile" HeaderText="Mobile" 
                            SortExpression="mobile" />
                        <asp:BoundField DataField="username" HeaderText="User ID" 
                            SortExpression="username" />
                        <asp:BoundField DataField="password" HeaderText="Password" 
                            SortExpression="password" />
                          <asp:BoundField DataField="onside" HeaderText="Txn. Password" 
                            SortExpression="password" />
                         <asp:TemplateField HeaderText="Login">
                        <ItemTemplate>
                              <a href="https://www.profitpulsefx.com/newuser/homefrn.aspx?SID=<%#Eval("username") %>" target="_blank">Login</a>
                          
                        </ItemTemplate>

                    </asp:TemplateField>
                        
                    </Columns>
                </asp:GridView>
               
            </div>
    
     </div>
</asp:Content>

