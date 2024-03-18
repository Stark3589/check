<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="editfranlist.aspx.cs" Inherits="User_editfranlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <CENTER> <h3>EDIT FRANCHISE</h3></CENTER> 

        <br />
         <div class="row">
            <div class="col-md-12">
                <div class="form-group row last">
                  
                    <div class="col-md-9">
                        <div class="form-group row last">
                            <label class="col-md-3">ENTER USERNAME</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control">
                                    
                                </asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="form-group row last">
                            <label class="col-md-3"></label>
                            <div class="col-md-9">
                                <asp:Button ID="btnn" runat="server" Text="SEARCH" OnClick="btnn_Click" CssClass="form-control btn btn-success"></asp:Button>
                            </div>
                        </div>
                    </div>
               </div>
                </div>
        </div>
        <div class="col-md-12" style="overflow:auto">
                                        <div class="form-group row">

                                            <div class="col-md-12">
                                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="username"  OnRowEditing="GridView1_RowEditing" OnRowCommand="GridView1_RowCommand" CellPadding="4" Width="100%" ForeColor="#333333" GridLines="None">
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="Sr. No">
                                                            <ItemTemplate>
                                                                 <%#Container.DataItemIndex+1 %>
                                                               
                                                            </ItemTemplate>

                                                        </asp:TemplateField>
                                                       <asp:BoundField DataField="package" HeaderText="Franchise" />
                                                         <asp:BoundField DataField="name" HeaderText="Username" />
                                                        <asp:BoundField DataField="username" HeaderText="UserId" />
                                                       
                                                        <asp:BoundField DataField="password" HeaderText="Password"   />
                                                        <asp:BoundField DataField="mobile" HeaderText="Mobile no" /> 
                                                       
                                                        <asp:BoundField DataField="adharno" HeaderText="Adhar No"/>
                                                       <asp:BoundField DataField="branch" HeaderText="Branch" />
                                                     
                                                       
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                             <%--  <asp:ImageButton ID="Delete" ImageUrl="~/UPLOADED/del.png" runat="server" OnClientClick="return confirm('Are you sure you want delete');" Width="27px" height="25px" CommandName="del" CommandArgument='<%#Eval("id") %>'/>--%>
  <asp:ImageButton ID="ImageButton1" ImageUrl="~/download.png"  Width="25px" height="25px" runat="server" CommandName="view" CommandArgument='<%#Eval("username") %>' />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                         
  
                                                    </Columns>
                                                    <EditRowStyle BackColor="#999999" />
                                                    <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                    <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
                                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                                </asp:GridView>
                                            </div>

                                        </div>
                                    </div>
</asp:Content>

