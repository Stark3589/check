<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="KYCStatus.aspx.cs" Inherits="User_KYCStatus" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- REQUIRED JS SCRIPTS -->
      <script src="../bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- DataTables -->
<script src="../../bower_components/datatables.net/js/jquery.dataTables.min.js"></script>
<script src="../../bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"></script>
<!-- SlimScroll -->
<script src="../../bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
<!-- FastClick -->
<script src="../../bower_components/fastclick/lib/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="../../dist/js/demo.js"></script>
     <!------Msgbox End---->
     <div class="box-body">
              <div class="alert alert-danger alert-dismissible" id="danger"  runat="server"  visible="false">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-ban"></i> Alert!</h4>
            <asp:Label ID="lbdanger" runat="server" Text="There is  some thing wrong........."></asp:Label> 
              </div>
              <div class="alert alert-info alert-dismissible" id="info" runat="server"  visible="false">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-info"></i> Alert!</h4>
               <asp:Label ID="lbinfo" runat="server" Text="ere is  some thing wrong........."></asp:Label>  
             
              </div>
              <div class="alert alert-warning alert-dismissible" id="warning" runat="server"  visible="false">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-warning"></i> Alert!</h4>
               <asp:Label ID="lbwarning" runat="server" Text=" Try Again............"></asp:Label> 
            
              </div>
              <div class="alert alert-success alert-dismissible" id="sccess" runat="server"  visible="false">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-check"></i> Alert!</h4>
                  <asp:Label ID="lbsuccess" runat="server" Text="Successfully updated................"></asp:Label>  
              </div>
            </div>
    <!-----Alert End----->
    
<div class="row">
        <!-- left column -->
        <div class="col-md-12">
          <!-- general form elements -->
          <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title">KYC Document Status</h3>
            </div>
            <!-- /.box-header -->
               
              <div class="box-body">
                   <div class="col-md-12">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i> Select List Type........</label>
                   <asp:DropDownList ID="drpreq" runat="server" AutoPostBack="true" class="form-control" OnTextChanged="drpreq_TextChanged" >          
                 <asp:ListItem value="Pending">Select</asp:ListItem>
                 <asp:ListItem value="Pending">Pending</asp:ListItem>
                 <asp:ListItem Value="Approved">Approved</asp:ListItem>                 
                   <asp:ListItem Value="Reject">Reject</asp:ListItem>              
             
                  </asp:DropDownList>
                            </div>
                </div>
              
           
                           
              </div></div>
           
          </div>
          <!-- /.box -->
            </div>
        <div class="row">
            <div class="col-md-12">

                 <div class="box-body" style="overflow:auto;">
<asp:Repeater ID="reploadimg" runat="server" OnItemCommand="repUserList_ItemCommand">
    <HeaderTemplate>
           <table id="example1" class="table table-bordered table-striped">
                <thead>
                      <tr>
                 <th>S.No</th>
        <th>UserName</th>
           <th>Name</th>
        <th>Document</th>
             <th>View</th>
            <th>Date</th>
           <th>Status</th>
          <th>Action</th>
                </tr>
                </thead>
                <tbody>
    </HeaderTemplate>
    <ItemTemplate>
        
              <tr>
    
     <td><asp:Label ID="lbaid" runat="server" Text='<%#Eval("Kid") %>'></asp:Label></td>
        <td><asp:Label ID="lbCName" runat="server" Text='<%#Eval("UserName") %>'></asp:Label></td> 
     <td><asp:Label ID="Label2" runat="server" Text='<%#Eval("DocName") %>'></asp:Label></td> 
     <td><img src='<%#Eval("DocLink") %>' height="50px;" width="100px;"></td> 
       <td><a href='<%#Eval("DocLink") %>' target="_blank">View</a></td>
          <td><asp:Label ID="Label1" runat="server" Text='<%#Eval("DOU", "{0:MM/dd/yy}") %>'></asp:Label></td>    
          
            
          <td>
                <asp:DropDownList ID="drpstatus" runat="server" CssClass="form-control">
           
            <asp:ListItem>Pending</asp:ListItem>
                 <asp:ListItem>Approved</asp:ListItem>               
              <asp:ListItem>Reject</asp:ListItem>
             
        </asp:DropDownList>
             </td>

   
    <td><asp:Button ID="bntsubcrive" runat="server" Text="Action"  class="btn btn-block btn-danger" CommandArgument='<%#Eval("Kid") %>'  CommandName="Request"/></td>
      </tr>

    </ItemTemplate>
    <FooterTemplate>
          </tbody>
               
              </table>

    </FooterTemplate>
</asp:Repeater> 
            </div>
            <!-- /.box-body -->
            </div>

        </div>
       
</asp:Content>

