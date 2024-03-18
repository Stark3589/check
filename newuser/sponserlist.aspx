<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="sponserlist.aspx.cs" Inherits="newuser_sponserlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    
        <center><h4>Sponser Team List</h4></center>
        <hr />
      
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="100px" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                
                
            </asp:DropDownList>  <hr />
            <asp:GridView ID="GridView2" runat="server" OnPageIndexChanging="GridView2_PageIndexChanging" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1"
                Width="100%" OnRowDataBound="GridView2_RowDataBound">
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

                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("rtime") %>'>&quot;&gt;</asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="username" HeaderText="Sponser In Down" />


                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="sponser" HeaderText="Sponser Id" />
                    <asp:BoundField HeaderText="Sponser Name" />
                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:Button ID="Button3" runat="server" Text='<%# Eval("status") %>' BorderStyle="None" />
                           

                        </ItemTemplate>
                    </asp:TemplateField>



                </Columns>
            </asp:GridView>
       
</asp:Content>

