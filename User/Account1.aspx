<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="Account1.aspx.cs" Inherits="User_account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- jQuery 3 -->
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
   
        <section class="content">
        
            <div class="alert alert-danger alert-dismissible" id="danger"  runat="server"  visible="false">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                <h4><i class="icon fa fa-ban"></i> Alert!</h4>
            <asp:Label ID="lbdanger" runat="server" Text="There is  some thing wrong........."></asp:Label> 
              </div>
      <div class="row">
        <div class="col-xs-12">
     <div class="box">
            <div class="box-header">
              <h1 class="box-title">Check User Account Statement</h1>
                <h4>
         <asp:DropDownList ID="drptype" runat="server" Width="140px" Height="26px">
              <%--<asp:ListItem Selected="True">ALL</asp:ListItem>
             <asp:ListItem>DIRECT ROYALTY INCOME</asp:ListItem>
              <asp:ListItem>LEVEL INCOME</asp:ListItem>
             <asp:ListItem>MATCHING BONUS INCOME</asp:ListItem>
              <asp:ListItem>REWARD INCOME</asp:ListItem>
             <asp:ListItem>CORE COMMITTEE INCOME</asp:ListItem>
             <asp:ListItem>CORE COMMITTEE BONUS</asp:ListItem>
              <asp:ListItem>PERFORMANCE BONUS</asp:ListItem>
             <asp:ListItem>SECTION BONUS</asp:ListItem>
              <asp:ListItem>REWARDS INCOME</asp:ListItem>
             <asp:ListItem>ADS INCOME</asp:ListItem>
             <asp:ListItem>SHOPPING INCOME</asp:ListItem>
             <asp:ListItem>FRANCHISE INCOME</asp:ListItem>--%>
             <asp:ListItem>LEVEL INCOME</asp:ListItem>
                    </asp:DropDownList>

                </h4>
                <h4>
                    <asp:TextBox ID="TextBox1" placeholder="From Date" type="date" runat="server"></asp:TextBox>
                </h4>
                <h4>
                    <asp:TextBox ID="TextBox2" placeholder="To Date" type="date" runat="server"></asp:TextBox>
                </h4>
                <h4>

         <asp:Button ID="Button1" runat="server" Text="SEARCH" Height="29px" OnClick="Button1_Click" />
                </h4>
            </div>
            <!-- /.box-header -->
            <div class="box-body" style="overflow:auto;">
               <!---  <div class="input-group input-group-sm" style="margin-bottom:30px;">
           <asp:TextBox ID="txtsearch" CssClass="form-control" runat="server" placeholder="Enter UserName"></asp:TextBox>
               
                    <span class="input-group-btn">
          <asp:Button ID="btnsearch" runat="server" Text="Go!"  OnClick="btnsearch_Click" CssClass="btn btn-info btn-flat btn-lg"  />
                    
                    </span>
              </div>--->
                <table id="example1" class="table table-bordered table-striped table-hover " style="overflow-x:auto;width:100%">
                <thead>
                <tr>
                    <th >SrNo</th>
                  <th>UserName</th>
                  <th>Date</th>
                  <th>Particular</th>
                    <th>Total</th>
                    <th>Tds</th>
                    <th>Admin</th>
                 <th>Credit</th>
                    <th>Debit</th>
                  
                  
                </tr>
                </thead>
                <tbody>
<asp:Repeater ID="Repeater1" runat="server" >
   
    <ItemTemplate>
        <tr>
            <td> <%# Container.ItemIndex+1 %></td>
             <td> <%#Eval("username") %></td>
            <td><%#DataBinder.Eval(Container.DataItem, "date", "{0:dd/MM/yyyy}")%></td>
             <td> <%#Eval("Remark") %></td>
              <td><%#Eval("total") %></td>
            <td><%#Eval("tds") %></td>
               <td><%#Eval("admin") %></td>
               <td> <%#Eval("Debit") %></td>
             <td> <%#Eval("Credit") %></td>
        </tr>
    </ItemTemplate>

</asp:Repeater>
         </tbody>
                <tfoot>
                <tr>
                       <th >#</th>
                 <th ></th>
                  <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                  <th>Total</th>
                  <th> <asp:Label ID="lbcredit" runat="server" Text=""></asp:Label>
    </th>
                               <th><asp:Label ID="lbdebit" runat="server" Text=""></asp:Label>
   </th>
                    
                  
                  
                </tr>
                    <tr><th ></th>
                        <th ></th>
                        <th ></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th >Grand Total</th>
                        <th ><asp:Label ID="Label1" runat="server" Text=""></asp:Label></th>
                        <th ></th>
                    </tr>
                </tfoot>
              </table>  
                
            
               
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
    <!-- /.content -->

    

<!-- page script -->
      
</asp:Content>


