<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="admstockrpt.aspx.cs" Inherits="User_admstockrpt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-md-12">
    <center>    <h3>ADMIN STOCK REPORT</h3></center>
    <br />
    <div class="row">
        <div class="col-md-12">
            <div class="form group row last">
                <div class="col-md-8">
                    <div class="form group row last">
                        <label class="col-md-4">SELECT PRODUCT NAME</label>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drpname" runat="server" CssClass="form-control" OnSelectedIndexChanged="drpname_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtcode" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="form group row last">
                    <label class="col-md-3"></label>
                    <div class="col-md-9">
                        <asp:Button ID="btn" runat="server" Text="SUBMIT" OnClick="btn_Click" CssClass="form-control btn btn-success" />
                    </div>
                        </div>
                </div>
            </div>
        </div>
    </div>
<br />
            <br />
           
     
         <div style="width:91%; margin-right:50px;overflow:auto">
             <div class="row">     
                      <asp:Repeater ID="Repeater1" runat="server">

                         <HeaderTemplate>
                              <table class="table table-bordered table-hover table-responsive">
                          <tr><th>SR.NO</th>
                              <th>PRODUCT CODE</th>
                              <th>PRODUCT NAME</th>
                              
                              <th>QUANTITY</th>
                              <th>MRP</th>
                              <th>TOTAL</th>
                            <th>BP</th>
                              <th>RP</th>
                                <th>GST</th>
                                <th>CGST</th>
                              <th>RATE</th>
                              
                          </tr>


                         </HeaderTemplate>
                          <ItemTemplate>
                              <tr>
                              <td><%# Container.ItemIndex+1 %></td>
                                  <td>
                                      <asp:Label ID="lblcode" runat="server" Text='<%#Eval("p_code") %>'></asp:Label></td>
                                     <td> <asp:Label ID="lbname" runat="server" Text='<%#Eval("productname") %>'></asp:Label></td>
                                  <td>  <asp:Label ID="Label1" runat="server" Text='<%#Eval("quantity") %>'></asp:Label></td>
                                     <td>  <asp:Label ID="Label6" runat="server" Text='<%#Eval("mrp") %>'></asp:Label></td>
                                  <td>  <asp:Label ID="Label2" runat="server" Text='<%#Eval("DP") %>'></asp:Label></td>
                                 
                                   <td>  <asp:Label ID="Label3" runat="server" Text='<%#Eval("BP") %>'></asp:Label></td>
                                   <td>  <asp:Label ID="Label4" runat="server" Text='<%#Eval("RP") %>'></asp:Label></td>
                                  <td>  <asp:Label ID="Label5" runat="server" Text='<%#Eval("GST") %>'></asp:Label></td>
                                  <td>  <asp:Label ID="Label7" runat="server" Text='<%#Eval("CGST") %>'></asp:Label></td>
                                <td>  <asp:Label ID="Label8" runat="server" Text='<%#Eval("Total") %>'></asp:Label></td>
                                
                              </tr>
                            
                          </ItemTemplate>
                          <FooterTemplate>
                               </table>
                          </FooterTemplate>
                      </asp:Repeater>
                     
                   </div>       
                     
              
              </div>
        </div>
        </div>
</asp:Content>

