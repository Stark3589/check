<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="rptsponserincome.aspx.cs" Inherits="User_Default7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span class="text-bold text-danger"><h1>Sponser Income List</h1></span>
    <div class="container">
        <section>
<div class="row">
    <div class="col-md-12">
        <div class="col-md-8">
            <div class="form-group row last">
                <label class="col-md-3">Enter User Id</label>
                <div class="col-md-9">
                     <asp:TextBox ID="txtuid" runat="server" CssClass="form-control" required=""></asp:TextBox></div>
                </div>
            
        </div>
        <div class="col-md-4">
             <div class="form-group row last">
                <label class="col-md-3"></label>
                 <div class="col-lg-7">
                     <asp:Button ID="btnsearch" runat="server" CssClass="form-control btn btn-success" Text="Search" OnClick="btnsearch_Click"></asp:Button></div>
        </div>
    </div>
        </div>
    </div>
   
            <div class="row">
                
            </div>
        </section>
         <div class="row">
                <div class="col-lg-12"></div>
             <asp:Repeater ID="Repeater1" runat="server">
                 <HeaderTemplate>
                     <table class="table table-bordered table-hover table-responsive">
                 <tr>
                     <th>#</th>
                     <th>UserId</th>
                     <th>Income</th>
                     <th>Date</th>
                     <th>Status</th>
                 </tr>
                 </HeaderTemplate>
                 <ItemTemplate>
                     <tr>
                     <td>  <%#Container.ItemIndex+1 %>   </td>
                     <td><%# Eval("username") %></td>
                       <td><%# Eval("lvlincome") %></td>
                       <td><%# Eval("date") %></td>
                         <td><%# Eval("status") %></td>
                 </tr>
                 </ItemTemplate>
                 <FooterTemplate>
                     </table>
                 </FooterTemplate>
             </asp:Repeater>
             
                 
             
            </div>
    </div>
</asp:Content>

