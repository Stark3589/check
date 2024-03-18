<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="DirectList.aspx.cs" Inherits="User_Directlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>


 td {
  text-align: left;
  padding: 8px;
}

tr:nth-child(even){background-color: #f2f2f2}


</style>
    
    <div class="row" style="overflow: auto;">
        
        <div class="col-md-12">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1"  OnRowDataBound="GridView1_RowDataBound" OnPageIndexChanging="GridView1_PageIndexChanging" Width="100%"
                EmptyDataText="YOU HAVE NO DIRECT SPONSER " >
                <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
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
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("rtime", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="username" HeaderText="User ID" SortExpression="name" />
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                    <asp:BoundField DataField="sponser" HeaderText="Sponser ID" SortExpression="direct" />
                   
                   
                    
                     <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:Button ID="Button3" runat="server" Text='<%# Eval("status") %>' BorderStyle="None" />
                           

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <RowStyle  />
            </asp:GridView>
        </div>
    </div>
</asp:Content>

