<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="FundReport.aspx.cs" Inherits="newuser_FundReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <!-- jQuery 3 -->

   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
        <center><h4>Fund Report</h4></center>
    <hr />
           
     
                <div class="row">
                    
                        <div class="col-3">
                   <asp:TextBox ID="txtsearch" ReadOnly="true" CssClass="form-control" runat="server" placeholder="Enter UserName"></asp:TextBox>
                        </div>
                        <div class="col-3">
                                     
         <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
             <asp:ListItem Selected="True">ALL</asp:ListItem>
              <asp:ListItem Value="INVESTED" >INVESTMENT</asp:ListItem>
            <asp:ListItem Value="AMOUNT TRANSFER TO" >TRANSFER</asp:ListItem>
            <asp:ListItem Value="AMOUNT TRANSFER FROM" >RECEIVED</asp:ListItem>
           
            
           
                    </asp:DropDownList>
                        </div>
                        <div class="col-3">
                             <asp:TextBox ID="TextBox1"  placeholder="From Date" type="date" Height="37px" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>

                          <div class="col-3">
                                 <asp:TextBox ID="TextBox2" placeholder="To Date"  Height="37px" type="date" CssClass="form-control" runat="server"></asp:TextBox>
                              </div>
                   
                </div>
                 
           
        

                
           
           
            <!-- /.box-header -->
            
                <div class="row">
                    <div class="col-2" style="margin-top:10px; margin-bottom:10px;">
                     <asp:Button ID="btnsearch" runat="server" Text="Search"  OnClick="btnsearch_Click" CssClass="form-control btn-success" Width="100px"  />
                   </div>
                  
              </div>
                <div style="overflow:auto;">
                <table id="example1" class="table table-bordered table-striped dataTable1" style="overflow-x:auto; width:100%">
                <thead>
                <tr>
                    <th>SrNo</th>
                
                  <th>Date</th>
                  <th>Particular</th>
                 <th>Credit</th>
                    <th>Debit</th>
                      <th>Active/Boost ID</th>
                  
                  
                </tr>
                </thead>
                <tbody>
<asp:Repeater ID="Repeater1" runat="server" >
   
    <ItemTemplate>
        <tr>
            <td> <%# Container.ItemIndex+1 %></td>
           
            <td><%#DataBinder.Eval(Container.DataItem, "date", "{0:dd/MM/yyyy}")%></td>
             <td> <%#Eval("Remark") %></td>
               <td> <%#Eval("Debit") %></td>
             <td> <%#Eval("Credit") %></td>
              <td> <%#Eval("U_id") %></td>
        </tr>
    </ItemTemplate>

</asp:Repeater>
         </tbody>
                <tfoot>
                <tr>
                       <th >#</th>
                
                    <th></th>
                  <th>Total</th>
                  <th> <asp:Label ID="lbcredit" runat="server" Text=""></asp:Label>
    </th>
                               <th><asp:Label ID="lbdebit" runat="server" Text=""></asp:Label>
   </th>
                    
                  
                  <th></th>
                </tr>
                    <tr><th ></th>
                       
                        <th></th>
                        <th >Grand Total</th>
                        <th ><asp:Label ID="Label1" runat="server" Text=""></asp:Label></th>
                        <th ></th>
                         <th ></th>
                    </tr>
                </tfoot>
              </table>  
                
            </div>
               
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
