<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="addcategory.aspx.cs" Inherits="Admin_category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <!------Msgbox End---->
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
              <h1 class="box-title">Add Category Here....</h1>
            </div>
            <!-- /.box-header -->

              <div class="box-body" style="border:2px solid green;">
                  <div class="row">
                                         <div class="col-md-2"> &nbsp;            
</div></div>
            <div class="row">
                                         <div class="col-md-2"> &nbsp;            
</div>
                   <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>ENTER CATEGORY</label>
                   <asp:TextBox ID="txtcategory"  runat="server"  class="form-control" placeholder="Enter Unit"></asp:TextBox>
                                      
                
                </div>
                </div></div>
                 
              <div class="row">
                                         <div class="col-md-2"> &nbsp;       
</div>
                   <div class="col-md-6">   
             <asp:Button ID="bntsubmit" runat="server" Text="Save" class="btn btn-primary" OnClick="bntsubmit_Click" />
                           <asp:Label ID="lbl" runat="server" Visible="false"></asp:Label>
              </div></div>
           
          </div>
          <!-- /.box -->
              <div class="row" style="margin-top:50px;">
                  <div class="col-lg-offset-2 col-lg-6" style="overflow:auto;">
                      <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">

                         <HeaderTemplate>
                              <table class="table table-bordered table-hover table-responsive">
                          <tr><th>#</th>
                              <th>Category</th>
                              <th>Date</th>
                              <th>Update</th>
                              <th>Delete</th>
                          </tr>


                         </HeaderTemplate>
                          <ItemTemplate>
                              <tr>
                              <td><%# Container.ItemIndex+1 %></td>
                                  <td>
                                      <asp:Label ID="lbname" runat="server" Text='<%#Eval("category") %>'></asp:Label></td>
                                  <td><%#DataBinder.Eval(Container.DataItem, "Date","{0:d}")%></td>
                                  <td> <asp:Button ID="Button1" runat="server" CommandArgument='<%#Eval("category")%>' CommandName="Update" Text="Update" CssClass="btn btn-block btn-warning" /></td>
                                  <td> <asp:Button ID="Button2" runat="server" Text="Delete" CommandArgument='<%#Eval("category") %>' CommandName="DEL" CssClass="btn btn-block btn-danger" /></td>
                          
                              </tr>
                            
                          </ItemTemplate>
                          <FooterTemplate>
                               </table>
                          </FooterTemplate>
                      </asp:Repeater>
                       <asp:HiddenField ID="hndlid" runat="server"  />
                          
                     
                  </div>
              </div>
            </div>

        </div>
        </div>
</asp:Content>

