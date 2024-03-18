<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="blockfranchise.aspx.cs" Inherits="User_blockfranchise" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
   <center> <h2>BLOCK/UNBLOCK FRANCHISE</h2></center>
    <br />
    <div class="row">
        <div class="col-md-12">
            <div class="col-md-7">
                <div class="form group row last">
                    <label class="col-md-3">ENTER USERNAME</label>
                    <div class="col-md-9"><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>
                </div>
            </div>
            <div class="col-md-5">
                <label class="col-md-3"></label>
                <div class="col-md-9"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" CssClass="form-control btn btn-success" /></div>
            </div>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-12">
            <div class="col-md-7">
                <div class="form group row last">
                   <label class="col-md-3">SELECT TYPE</label>

        <div class="col-md-9"><asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
    <asp:ListItem Selected="True">Search User...</asp:ListItem>
    <asp:ListItem>All</asp:ListItem>
    <asp:ListItem>Block</asp:ListItem>
    <asp:ListItem>Un Block</asp:ListItem>
</asp:DropDownList>
            </div>
                    </div>
                </div>
             <div class="col-md-5">
                <label class="col-md-3"></label>
                 <div class="col-md-9">
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" CssClass="form-control btn btn-success"  Text="Search" /></div>
                 </div>
            </div>
        </div>
<br />
    <div class="col-md-12" style="margin-left:5px;margin-right:20px;overflow:auto">
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4"  Width="90%" OnRowCommand="GridView2_RowCommand">
                    <Columns>
                    <asp:TemplateField HeaderText="Sr.No.">
        <ItemTemplate>
             <%#Container.DataItemIndex+1 %>
        </ItemTemplate>
    </asp:TemplateField>
                      
                      <asp:BoundField DataField="package" HeaderText="Package" />
            
                        <asp:BoundField DataField="username" HeaderText="User ID" 
                            SortExpression="username" />
                         <asp:BoundField DataField="password" HeaderText="Password" 
                            SortExpression="password" />
                        <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                        <asp:BoundField DataField="mobile" HeaderText="Mobile" 
                            SortExpression="mobile" />
                        <asp:BoundField DataField="adharno" HeaderText="Adhar No" />
                          
                        <asp:BoundField DataField="dateofjoin" HeaderText="Date"  DataFormatString="{0:d}"/>      
                         <asp:BoundField DataField="branch" HeaderText="Branch" />
                         <asp:BoundField DataField="status" HeaderText="Status" />
                          
                         <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton2" Text="Block User" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" />
            </ItemTemplate>
                              </asp:TemplateField>
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
</asp:Content>

