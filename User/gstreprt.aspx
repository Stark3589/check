<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="gstreprt.aspx.cs" Inherits="User_gstreprt" %>

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
           <center>   <h1 class="box-title">GST REPORT</h1></center>
            </div>

            <br />
               <div class="row">
              
                   
                     <div class="col=md-12">
                         <div class="col-md-8">
                             <div class="form-group row last">
                                 <label class="col-md-4">SELECT DATE</label>
                                 <div class="col-md-4">
                      <asp:TextBox ID="txtfrom" runat="server"  CssClass=" form-control" type="Date"></asp:TextBox>
                                 </div>
                                 <div class="col-md-4">
                           <asp:TextBox ID="txtto" runat="server"  CssClass=" form-control" type="Date"></asp:TextBox>
                       </div>
                     </div>
                            
                         
                      
                      
                         </div>
             
                    <div class="col-md-2">
                  <div class="form-group row last">
                      <label class="col-md-3"></label>
                      <div class="col-md-9">                                     
                <asp:Button ID="Button3" runat="server" Text="Go!" OnClick="Button3_Click"  CssClass="form-control btn btn-success"  />
               
              </div>
                   </div>
                   </div>
                   <div class="col-md-2">
                  <div class="form-group row last">
                      <label class="col-md-3"></label>
                      <div class="col-md-9"> 

            <asp:Button ID="btnprnt" runat="server" Text="PRINT" OnClick="btnprnt_Click" CssClass="form-control btn btn-success" />
        </div>
                </div>
                      </div>
                        </div>
                   </div>
          
            <div class="box-success box-primary">
                  <div class="row">
                  <div class="col-lg-12" style="overflow:auto;">
                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="True" OnRowDataBound="GridView1_RowDataBound" BackColor="White" Width="90%" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
               <AlternatingRowStyle BackColor="powderblue" />
                               <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="username" HeaderText="Userid" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                         <asp:BoundField DataField="name" HeaderText="Name" ItemStyle-HorizontalAlign="Center"  >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                        <asp:BoundField DataField="address" HeaderText="Address" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                        <asp:BoundField DataField="invoice_no" HeaderText="Invoice No" ItemStyle-HorizontalAlign="Center"  >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                         <asp:BoundField DataField="dateofjoin" HeaderText="Date" DataFormatString="{0:d}" ItemStyle-HorizontalAlign="Center"  >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                         <asp:BoundField HeaderText="Amount" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                       <asp:BoundField HeaderText="CGST" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                     <asp:BoundField HeaderText="SGST" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                        <asp:BoundField HeaderText="IGST" ItemStyle-HorizontalAlign="Center" > 

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                          <asp:BoundField HeaderText="GST" ItemStyle-HorizontalAlign="Center"  >
                         
                      

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                         
                      

                        </asp:BoundField>
                         
                      
                    </Columns>
                          <HeaderStyle 
                BackColor="silver" Font-Italic="false"  ForeColor="Snow" />
               
                   <%-- <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                          <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />--%>
                </asp:GridView>
    
                          
                     
                  </div>
              </div>        
                       
                    </div>
            </div>
                </div>
            </div>
            </div>
        </div>
</asp:Content>

