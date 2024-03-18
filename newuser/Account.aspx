<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="account.aspx.cs" Inherits="User_account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
   
       
             <center> <h4 class="box-title">Check User Account Statement</h4></center>
    <hr />
      <div class="row">
       
            
                <div class="col-3">
                    <div class="form-group ">
                        <label>Select Income Type</label>
                     <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"  Height="34px">
             <asp:ListItem Selected="True">ALL</asp:ListItem>
           
            
             
                           <asp:ListItem>DAILY PROFIT</asp:ListItem>
                           <asp:ListItem >LEVEL INCOME</asp:ListItem>
                        
                        
                        
          
                    </asp:DropDownList>  
                    </div>
                </div>
                <div class="col-3">
                     <div class="form-group">
                         <label>From Date</label>
                           <asp:TextBox ID="TextBox1" placeholder="From Date" Height="37px" CssClass="form-control" type="date" runat="server"></asp:TextBox>
                         </div>

                </div>
          <div class="col-3">
                     <div class="form-group">

                
                <label>To Date</label>
                    <asp:TextBox ID="TextBox2" placeholder="To Date" Height="37px" type="date" CssClass="form-control" runat="server"></asp:TextBox>
              </div>
              </div>
                 <div class="col-2">
                     <div class="form-group" style="margin-top:30px;">
                          
         <asp:Button ID="Button1" runat="server" Text="SEARCH" CssClass="form-control btn-success"  OnClick="Button1_Click" />
               </div>
            </div>
                </div>
            <!-- /.box-header -->
    <hr />
            <div class="box-body" style="overflow:auto;">
              
                <table id="example1" class="table table-bordered table-striped dataTable1" style="overflow-x:auto;width:100%; margin-left:0px;">
                <thead >
                <tr>
                    <th >SrNo</th>
                 
                  <th>Date</th>
                  <th>Particular</th>
                 <th>Credit</th>
                    <th>Debit</th>
                  
                  
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
                    
                  
                  
                </tr>
                    <tr><th ></th>
                       
                        <th ></th>
                        <th >Grand Total</th>
                        <th colspan="2"  ><asp:Label ID="Label1" runat="server" Text=""></asp:Label>&nbsp;$</th>
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


