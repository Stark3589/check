<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="Wallet.aspx.cs" Inherits="wallet" %>

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
                <h3 class="card-title">Fund Transfer/Debit</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
             
                <div class="card-body">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Enter Uername</label>
                    <div class="input-group input-group-sm" ">
                    <asp:TextBox ID="TextBox1" CssClass="form-control" Width="200px" Height="37px" placeholder="Enter User Name" runat="server"></asp:TextBox>
                    <span class="input-group-append">
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="Button1_Click" CssClass="btn btn-info btn-flat" />
                    </span>
                </div>
                  </div>
                  <div class="form-group">
                    <label for="exampleInputPassword1">Name</label>
                    <asp:TextBox ID="TextBox3" runat="server"  CssClass="form-control" ReadOnly="true" ></asp:TextBox>
                  </div>
                     <div class="form-group">
                    <label for="exampleInputPassword1">Available Fund</label>
                    <asp:TextBox ID="TextBox2" runat="server"  CssClass="form-control" ReadOnly="true" ></asp:TextBox>
                  </div>
                    <div class="form-group">
                    <label for="exampleInputPassword1">Transfer/Debit Amount</label>
                  <asp:TextBox ID="TextBox5" runat="server"   CssClass="form-control" AutoPostBack="true" OnTextChanged="TextBox5_TextChanged" required Text="0" min="0" ></asp:TextBox>
                   </div>
                 
                </div>
                <!-- /.card-body -->

                <div class="card-footer">
                  <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Transfer Fund" CssClass=" btn btn-success"  />
                         <asp:Label ID="Label2" runat="server" Visible="false"></asp:Label>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Debit Fund" CssClass=" btn btn-danger"  />
                         
                </div>
             
            </div>
        </div>
   
</asp:Content>


