<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="PRICEMASTER.aspx.cs" Inherits="User_PRICEMASTER" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="box-body">
             
              <div class="alert alert-info alert-dismissible" id="info" runat="server"  visible="false">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-info"></i> Alert!</h4>
               <asp:Label ID="lbinfo" runat="server" Text="Already Inserted........."></asp:Label>  
             
              </div>
            
            </div>
    <!-----Alert End----->
    <div class="row">
        <!-- left column -->
        <div class="col-md-12">
          <!-- general form elements -->
          <div class="box box-primary">
            <div class="box-header with-border">
              <h1 class="box-title">Price Master....</h1>
            </div>
            <!-- /.box-header -->

              <div class="box-body" style="border:2px solid green;">
                  <div class="row">
                                         <div class="col-md-2"> &nbsp;            
</div></div>
            <div class="row">

                <div class="col-md-1"></div>
                    <div class="col-md-2"> 
               <label class="control-label" for="inputSuccess"> Product code</label>
                 <asp:TextBox ID="txtcode" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>
                <div class="col-md-2"> 
               <label class="control-label" for="inputSuccess"> Product Name</label>
                 <asp:TextBox ID="txtp_name" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>
                   <div class="col-md-2">               
          
                  <label class="control-label" for="inputSuccess"> Quantity</label>
                   <asp:DropDownList ID="drpquantity" runat="server"  class="form-control">
                       <asp:ListItem>1</asp:ListItem>
                   </asp:DropDownList>              
                </div>
               <div class="col-md-2"> 
                 <label class="control-label" for="inputSuccess"> Mrp</label>
                   <asp:TextBox ID="txtmrp" runat="server" type="number" Text="0" class="form-control"></asp:TextBox> 
                                   
                  

                        </div>
                       
               
                 
                 
              </div>
                  <br />
                  <div class="row">
                        <div class="col-md-1"></div>
               

                 <div class="col-md-2"> 
                 <label class="control-label" for="inputSuccess"> GST</label>
                   <asp:TextBox ID="TextBox1" runat="server" type="number" Text="0" class="form-control"></asp:TextBox> 
                                   
                  

                        </div>
                 <div class="col-md-2"> 
                 <label class="control-label" for="inputSuccess"> CGST</label>
                   <asp:TextBox ID="TextBox2" runat="server" type="number" Text="0" OnTextChanged="TextBox2_TextChanged" AutoPostBack="true" class="form-control"></asp:TextBox> 
                                   
                  

                        </div>
                       <div class="col-md-2"> 
                 <label class="control-label" for="inputSuccess"> IGST</label>
                   <asp:TextBox ID="TextBox3" runat="server" type="number" Text="0" class="form-control"></asp:TextBox> 
                                   
                  

                        </div>
                       <div class="col-md-2"> 
                 <label class="control-label" for="inputSuccess"> Total</label>
                   <asp:TextBox ID="txttotal" runat="server" type="number" Text="0" class="form-control"></asp:TextBox> 
                                   
                  

                        </div>
                      </div>
                   <div class="col-md-12">
                       <div class="col-md-3"></div> 
                       <div class="col-md-6"> 
                       <label class="control-label" for="inputSuccess"></label>
             <asp:Button ID="bntsubmit" runat="server" Text="Save" class="form-control btn btn-success" OnClick="bntsubmit_Click" />
        </div>    </div>           <asp:Label ID="lbl" runat="server" Visible="false"></asp:Label>
                      
              </div>
           
         
          <!-- /.box -->
              <div class="row" style="margin-top:50px;width:100%">
                  <div class="col-md-12" style="overflow:auto;">
                      <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">

                         <HeaderTemplate>
                              <table class="table table-bordered table-hover table-responsive">
                          <tr><th>SR.NO</th>
                              <th>PRODUCT CODE</th>
                              <th>PRODUCT NAME</th>
                              
                              <th>QUANTITY</th>
                              <th>MRP</th>
                             
                           
                                <th>GST</th>
                                <th>CGST</th>
                              <th>RATE</th>
                              <th>ACTION</th>
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
                                  
                                  <td>  <asp:Label ID="Label5" runat="server" Text='<%#Eval("GST") %>'></asp:Label></td>
                                  <td>  <asp:Label ID="Label7" runat="server" Text='<%#Eval("CGST") %>'></asp:Label></td>
                                <td>  <asp:Label ID="Label8" runat="server" Text='<%#Eval("Total") %>'></asp:Label></td>
                                 <td> <asp:Button ID="Button1" runat="server" CommandArgument='<%#Eval("id")%>' CommandName="Update" Text="Update" CssClass="btn btn-block btn-warning" /></td>
                                  <td> <asp:Button ID="Button2" runat="server" Text="Delete" CommandArgument='<%#Eval("id") %>' CommandName="del" CssClass="btn btn-block btn-danger" /></td>
                          
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

