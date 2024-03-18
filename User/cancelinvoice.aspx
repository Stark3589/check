<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="cancelinvoice.aspx.cs" Inherits="User_cancelinvoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="row">
        <div class="col-md-12">
    <center><h3>INVOICE CANCEL</h3></center>
            <br />

    <div class="row">
        <div class="col-md-12">
            <div class="form-group row last">
            <div class="col-md-5">
                <div class="form-group row last">
                    <label class="col-md-5">ENTER FRANCHISE ID</label>
                    <div class="col-md-7">
                        <asp:TextBox ID="txtfid" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-md-5">
                <div class="form-group row last" >
                    <label class="col-md-4">SELECT DATE</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="date1" runat="server" type="date" CssClass="form-control"></asp:TextBox>
                    </div>
                      <div class="col-md-4">
                        <asp:TextBox ID="date2" runat="server" type="date" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group row last" >
                    <label class="col-md-3"></label>
                    <div class="col-md-9">
                        <asp:Button ID="BTN" runat="server" Text="SUBMIT" CssClass="form-control btn btn-success" OnClick="BTN_Click" />
    </div>
                </div>
            </div>
        </div>
            </div>
    </div>

      <div class="row" style="margin-top:50px;width:100%">
                  <div class="col-md-12" style="overflow:auto;">
                      <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">

                         <HeaderTemplate>
                              <table class="table table-bordered table-hover table-responsive">
                          <tr><th>SR.NO</th>
                              <th>NAME</th>
                              <th>CUST_id</th>
                              <th>PRODUCT CODE</th>
                              <th>PRODUCT NAME</th>
                              
                              <th>QUANTITY</th>
                              
                              
                            
                              <th>INVOICE NO</th>
                              <th>FINAL PAYMENT</th>

                              <th>ACTION</th>
                          </tr>


                         </HeaderTemplate>
                          <ItemTemplate>
                              <tr>
                              <td><%# Container.ItemIndex+1 %></td>
                                 <td> <asp:Label ID="Label2" runat="server" Text='<%#Eval("name") %>'></asp:Label></td>
                                   <td> <asp:Label ID="Label3" runat="server" Text='<%#Eval("cust_id") %>'></asp:Label></td>
                                  <td>
                                      <asp:Label ID="lblcode" runat="server" Text='<%#Eval("p_code") %>'></asp:Label></td>
                                     <td> <asp:Label ID="lbname" runat="server" Text='<%#Eval("productname") %>'></asp:Label></td>
                                  <td>  <asp:Label ID="Label1" runat="server" Text='<%#Eval("quantity") %>'></asp:Label></td>
                                    
                                 
                                  
                                  <td>  <asp:Label ID="Label9" runat="server" Text='<%#Eval("invoice_no") %>'></asp:Label></td>
                                <td>  <asp:Label ID="Label8" runat="server" Text='<%#Eval("Total") %>'></asp:Label></td>
                  
                                  <td> <asp:Button ID="Button2" runat="server" Text="Cancel" CommandArgument='<%#Eval("invoice_no") %>' CommandName="del" CssClass="btn btn-block btn-danger" /></td>
                          
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

