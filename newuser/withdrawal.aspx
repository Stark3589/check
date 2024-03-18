<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="withdrawal.aspx.cs" Inherits="Admin_withdrawal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type = "text/javascript">
        function DisableButton() {
            document.getElementById("<%=Button2.ClientID %>").disabled = true;
        }
        window.onbeforeunload = DisableButton;
</script>
    

      <div class="col-md-6">
            <!-- general form elements -->
            <div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">Withdrawal Request</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
             
                <div class="card-body">
                    <%-- <div class="form-group">
                    <label for="exampleInputEmail1">Select Income</label>
                         <asp:DropDownList ID="drp_income" runat="server" CssClass="form-control">
                             <asp:ListItem Selected="True">SELECT INCOME</asp:ListItem>
                             <asp:ListItem>BOOSTER INCOME</asp:ListItem>
                             <asp:ListItem>OTHER INCOME</asp:ListItem>
                         </asp:DropDownList>
                      
               
                    
                </div>--%>
                <div class="form-group">
                    <label for="exampleInputEmail1">AVAILABLE BALANCE ($)</label>
                    
                        <asp:Label ID="Label1" runat="server" CssClass="form-control"></asp:Label>
               
                    
                </div>
          
          
      
           
                <div class="form-group">
                    <label for="exampleInputEmail1">ENTER AMOUNT</label>
                   

                       <asp:TextBox ID="TextBox1" runat="server"  CssClass="form-control" ReadOnly="false"   type="number" min="5" ></asp:TextBox>

                       
                        
                    </div>
                
          
          
       
            
                <div class="form-group">
                    <label for="exampleInputEmail1">SELECT</label>
                  
                      <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" OnSelectedIndexChanged="TextBox1_TextChanged1" AutoPostBack="true" >
                            <asp:ListItem Selected="True">Select Transfer Mode</asp:ListItem>
                            <asp:ListItem>Transfer in Wallet Address</asp:ListItem>
                           <asp:ListItem>Transfer in Fund Wallet</asp:ListItem>
                             
                        </asp:DropDownList>
                   
               
                   
                </div>
           
          
       
           
                <div class="form-group">
                    <label for="exampleInputEmail1">TXN. CHARGE</label>
                    
                       <asp:TextBox ID="TextBox2" runat="server"   CssClass="form-control" ReadOnly="true" ></asp:TextBox>
                   
               
                   
                </div>
            
    
            
                <div class="form-group">
                    <label for="exampleInputEmail1">FINAL AMOUNT</label>
                    
                       <asp:TextBox ID="TextBox5" runat="server"   CssClass="form-control" ReadOnly="true" ></asp:TextBox>
                   
               
                    
                </div>
           
          
       
           
              
           </div>
          
        
            
            <div class="card-footer">
                          <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" CssClass="form-control btn" style="  background:#043927;color:#fff" Width="100px"  />
                         <asp:Label ID="Label2" runat="server" Visible="false"></asp:Label>
                    </div>
                </div>
    
            </div>
                    
   
</asp:Content>

