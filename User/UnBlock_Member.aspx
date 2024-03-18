<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UnBlock_Member.aspx.cs" Inherits="User_UnBlock_Member" %>--%>

<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="UnBlock_Member.aspx.cs" Inherits="User_UnBlock_Member" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


       <center> <h2> MEMBER UNBLOCK PANEL</h2></center>

  <%--  <form id="form1" runat="server">
   --%>
     <div class="row">
        <div class="col-md-12">
            <div class="col-md-7">
                <div class="form group row last">
                    <label class="col-md-3">ENTER USERNAME</label>
                    <div class="col-md-9"><asp:TextBox ID="txtuname" runat="server" CssClass="form-control"></asp:TextBox></div>
                </div>
            </div>
            <div class="col-md-5">
                <label class="col-md-3"></label>
                <div class="col-md-9"><asp:Button ID="search" runat="server" Height="30px" OnClick="search_Click" Text="Search" CssClass="form-control btn btn-success" /></div>
            </div>
        </div>
    </div>

    <br />
          <div class="row">
    <div class="col-md-12" style="margin-left:5px;margin-right:20px;overflow:auto">
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4"  Width="90%" OnRowCommand="GridView2_RowCommand">
                    <Columns>
                    <asp:TemplateField HeaderText="Sr.No.">
        <ItemTemplate>
             <%#Container.DataItemIndex+1 %>
        </ItemTemplate>
    </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" 
                                    Text='<%# Eval("dateofjoin", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                      <%--  <asp:TemplateField HeaderText="Time">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%# Eval("rtime") %>'>&quot;&gt;</asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:BoundField DataField="username" HeaderText="User ID" 
                            SortExpression="username" />
                        <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                        <asp:BoundField DataField="mobile" HeaderText="Mobile" 
                            SortExpression="mobile" />
                        
                        <asp:BoundField DataField="address" HeaderText="Address" 
                            SortExpression="address" />
                         <asp:BoundField DataField="status" HeaderText="Status" 
                            SortExpression="status" />
                     <%--    <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton2" Text="Block User" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" />
            </ItemTemplate>
                              </asp:TemplateField>--%>
                        <asp:TemplateField>
                             <ItemTemplate>
               <asp:LinkButton ID="unblock" Text="Unblock User" runat="server" CommandName="view" CommandArgument="<%# Container.DataItemIndex %>"></asp:LinkButton>
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
        </div>
  
<%--    </form>--%>
</asp:Content>
