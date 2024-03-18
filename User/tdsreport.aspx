<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="tdsreport.aspx.cs" Inherits="User_tdsreport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
     <div class="row">
        <!-- left column -->
        <div class="col-md-12">
          <!-- general form elements -->
          <div class="box box-primary">
            <div class="box-header with-border">
              <h1 class="box-title">TDS Sheet</h1>
            </div>

              <div class="row">
                   <div class="col-lg-6">Enter User ID</div>
                  <div class="col-lg-2">Enter From Date</div>
                  <div class="col-lg-2">Enter To Date</div>
                  <div class="col-lg-2"></div>
                  </div>
               <div class="row">
                   <div class="col-lg-6">
                       <div class="input-group input-group-sm" style="margin-bottom:10px;"> 
                <asp:TextBox ID="txtusername" runat="server"  CssClass=" form-control" placeholder="Enter User Name"></asp:TextBox>
                    <span class="input-group-btn">                    
<asp:Button ID="btnsearch" runat="server" Text="Go!" OnClick="btnsearch_Click"  CssClass="btn btn-info btn-flat btn-lg"  />
                </span>
              </div>
                   </div>
                   <div class="col-lg-2">
                       <div class="input-group input-group-sm" style="margin-bottom:10px;"> 
                <asp:TextBox ID="txtfrom" runat="server"  CssClass=" form-control" type="Date" placeholder="Enter From Date"></asp:TextBox>
                    <span class="input-group-btn">                    
                </span>
              </div>
                   </div>
                   <div class="col-lg-2">
                       <div class="input-group input-group-sm" style="margin-bottom:10px;"> 
                <asp:TextBox ID="txtto" runat="server"  CssClass=" form-control" type="Date" placeholder="Enter To Date"></asp:TextBox>
                    <span class="input-group-btn">                    
                </span>
              </div>
                   </div>
                   <div class="col-lg-2">
                       <div class="input-group input-group-sm" style="margin-bottom:10px;"> 
                    <span class="input-group-btn">                    
<asp:Button ID="Button3" runat="server" Text="Go!" OnClick="Button3_Click"  CssClass="btn btn-info btn-flat btn-lg"  />
                </span>
              </div>
                   </div>
                   </div>
              <div class="row">
        <div class="col-lg-12">
             <div class="row">
        <div class="col-lg-12">&nbsp;</div>
                </div>
          
            <div class="box-success box-primary">
                  <div class="row" style="margin-top:50px;">
                  <div class="col-lg-12" style="overflow:auto;">
                      <table class="table table-bordered table-responsive table-hover" style="width:90%" >
        <thead>
                     
                          <tr><th>#</th>
                              <th>User Name</th>
                              <th>Name</th>
                              <%--<th>Holder Name</th>
                              <th>Bank Name</th>
                              <th>Branch Name</th>
                              <th>A/C No</th>
                              <th>IFSC</th>--%>
                              <th>Amount</th>
                              <th>Admin Charge</th>
                              <th>TDS</th>
                            
                              <th>Final Amount</th>
                              <th>Date</th>
                              <th>PAN</th>
                              <%--<th>Mobile</th>
                              <th>Remark</th>--%>
                          </tr>
        </thead>
    <tbody>
             <asp:Repeater ID="Repeater1" runat="server">

                          <ItemTemplate>
             <tr>
                              <td><%# Container.ItemIndex+1 %></td>
                                  <td>
                                      <asp:Label ID="lbusername" ForeColor="#00cc00" runat="server" Text='<%#Eval("Username") %>'></asp:Label></td>
                                  <td><asp:Label ID="Label8" ForeColor="#00cc00" runat="server" Text='<%#Eval("name") %>'></asp:Label></td>
                 <%--<td><asp:Label ID="Label1" ForeColor="#ff0000" runat="server" Text='<%#Eval("holdername") %>'></asp:Label></td>
                 <td><asp:Label ID="Label9" ForeColor="#ff0000" runat="server" Text='<%#Eval("bankname") %>'></asp:Label></td>
                 <td><asp:Label ID="Label10" ForeColor="#ff0000" runat="server" Text='<%#Eval("branchname") %>'></asp:Label></td>
                 <td><asp:Label ID="Label11" ForeColor="#ff0000" runat="server" Text='<%#Eval("accno") %>'></asp:Label></td>
                 <td><asp:Label ID="Label12" ForeColor="#ff0000" runat="server" Text='<%#Eval("ifsc") %>'></asp:Label></td>--%>
                                  <td><asp:Label ID="Label4" runat="server" Text='<%#Eval("total") %>'></asp:Label></td>
                                  <td><asp:Label ID="Label5" runat="server" Text='<%#Eval("admin") %>'></asp:Label></td>
                                  <td><asp:Label ID="lbname" runat="server" ForeColor="#ff0000" Text='<%#Eval("TDS") %>'></asp:Label></td>
                 
                                  <td><asp:Label ID="Label6" runat="server" ForeColor="#990099" Text='<%#Eval("credit") %>'></asp:Label></td>
                                  <td><%#DataBinder.Eval(Container.DataItem, "date","{0:dd/MM/yyyy}")%></td>
                                  <td><asp:Label ID="Label2" runat="server" ForeColor="#0033cc" Text='<%#Eval("pan") %>'></asp:Label></td>
                                  <%--<td><asp:Label ID="Label3" runat="server" Text='<%#Eval("mobile") %>'></asp:Label></td>
                                  <td><asp:Label ID="Label7" runat="server" Text='<%#Eval("status") %>'></asp:Label></td>--%>
                                  
                              </tr>
                            
                            </ItemTemplate>
            </asp:Repeater>
            </tbody>
     <tfoot>
                <tr>
                       <th >#</th>
                 <th ></th>
                    <%--<th ></th>
                    <th ></th>
                    <th ></th>
                    <th ></th>
                    <th ></th>--%>
                    

                    
                 <%-- <th>Total</th>--%>
                 <%-- <th> <asp:Label ID="lbdebit" runat="server" Text="" ForeColor="#ff0000" Font-Bold="true" Font-Size="Larger"></asp:Label></th>
                               <th><asp:Label ID="lbAdminCharge" runat="server" Text="" ForeColor="#ff0000" Font-Bold="true" Font-Size="Larger"></asp:Label></th>
                    <th><asp:Label ID="lbTDS" runat="server" Text="" ForeColor="#ff0000" Font-Bold="true" Font-Size="Larger"></asp:Label></th>
                    <th><asp:Label ID="lbemi" runat="server" Text="" ForeColor="#ff0000" Font-Bold="true" Font-Size="Larger"></asp:Label></th>
                    <th><asp:Label ID="lbPayOut" runat="server" Text="" ForeColor="#ff0000" Font-Bold="true" Font-Size="Larger"></asp:Label></th>
                    <th></th>--%>
                  <th></th>
<th></th>
                  <%--<th></th>
                    <th ></th>--%>
                </tr>
                </tfoot>
 </table>
                          
                     
                  </div>
              </div>        
                       
                    </div>
            </div>
                </div>
            </div>
            </div>
        </div>
</asp:Content>

