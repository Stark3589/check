<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="topup.aspx.cs" Inherits="User_autopool" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <script type = "text/javascript">
         function DisableButton() {
             document.getElementById("<%=Button1.ClientID %>").disabled = true;
         }
         window.onbeforeunload = DisableButton;
</script>
         
    <div class="col-md-6">
            <!-- general form elements -->
            <div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">Activate Now</h3>
              </div>
              <!-- /.card-header -->  
              <!-- form start -->
             
                <div class="card-body">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Enter Uername</label>
                    <div class="input-group input-group-sm" ">
                    <asp:TextBox ID="txtunameid" CssClass="form-control" Width="200px" Height="37px" placeholder="Enter User Name" runat="server"></asp:TextBox>
                    <span class="input-group-append">
                        <asp:Button ID="Button3" runat="server" Text="Search" OnClick="Button3_Click" CssClass="btn btn-info btn-flat" />
                    </span>
                </div>
                  </div>
                  <div class="form-group">
                    <label for="exampleInputPassword1">Name</label>
                    <asp:TextBox ID="txtname" runat="server"  CssClass="form-control" ReadOnly="true" ></asp:TextBox>
                  </div>
                       <div class="form-group">
            <label for="exampleInputPassword1">Available Amount</label>
           
                 <asp:TextBox ID="TextBox1" CssClass="form-control" Font-Bold="true" runat="server" ReadOnly="true"></asp:TextBox>
               
             </div>
                      <div class="form-group">
            <label for="exampleInputPassword1">Activate Id</label>
                          <asp:DropDownList ID="ddlpackage" CssClass="form-control" runat="server">
                              <asp:ListItem Selected="True">
                                  Select Amount($)
                              </asp:ListItem>
                              <asp:ListItem>100</asp:ListItem>
                               <asp:ListItem>200</asp:ListItem>
                               <asp:ListItem>500</asp:ListItem>
                               <asp:ListItem>1000</asp:ListItem>
                               <asp:ListItem>2000</asp:ListItem>
                               <asp:ListItem>5000</asp:ListItem>
                               <asp:ListItem>10000</asp:ListItem>
                               <asp:ListItem>25000</asp:ListItem>
                          </asp:DropDownList>
           
                
               
           
        </div>
                 
                </div>
                <!-- /.card-body -->

                <div class="card-footer">
                  <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Active Now" OnClientClick="this.disabled='true'; this.value='Please wait...';" UseSubmitBehavior="False" CssClass=" btn btn-dark"  />
                         <asp:Label ID="Label2" runat="server" Visible="false"></asp:Label>
                </div>
             
            </div>
        </div>
  

</asp:Content>

