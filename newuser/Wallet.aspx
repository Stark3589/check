<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="Wallet.aspx.cs" Inherits="wallet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type = "text/javascript">
        function DisableButton() {
            document.getElementById("<%=Button2.ClientID %>").disabled = true;
        }
        window.onbeforeunload = DisableButton;
</script>
    <center><h4>Fund Transfer</h4></center>
    <hr />
    <div class="form_wrapper">
  <div class="form_container">
    <div class="title_container">
          <div class="row">
        <div class="col-md-12">
            <div class="col-md-4">
                <div class="form=-group row last">
                    <label class="col-md-12">My Available Balance($)</label>
                    <div class="col-md-12">
                        <asp:Label ID="Label1" runat="server" CssClass="form-control"></asp:Label>
               
                    </div>
                </div>
            </div>
          
       
            <div class="col-md-4" style="margin-top:10px;">
                   <div class="input-group input-group-sm" ">
                    <asp:TextBox ID="TextBox1" CssClass="form-control" Width="200px" Height="37px" placeholder="Enter User Name" runat="server"></asp:TextBox>
                    <span class="input-group-append">
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="Button1_Click" CssClass="btn btn-info btn-flat" />
                    </span>
                </div>
            </div>
            
          
      
            <div class="col-md-4">
                <div class="form=-group row last">
                    <label class="col-md-6">NAME</label>
                    <div class="col-md-12">
                       <asp:TextBox ID="TextBox3" runat="server"  CssClass="form-control" ReadOnly="true" ></asp:TextBox>
                   
               
                    </div>
                </div>
            </div>
          
        </div>
    </div>
   <%-- <div class="row">
        <div class="col-md-12">
            <div class="col-md-6">
                <div class="form=-group row last">
                    <label class="col-md-6">LIFELINE BOX</label>
                    <div class="col-md-12">
                       <asp:TextBox ID="TextBox4" runat="server"   CssClass="form-control" ReadOnly="true" ></asp:TextBox>
                   
               
                    </div>
                </div>
            </div>
          
        </div>
    </div>--%>
      <div class="row">
        <div class="col-md-12">
            <div class="col-md-4">
                <div class="form=-group row last">
                    <label class="col-md-6">HOW MUCH TRANSFER</label>
                    <div class="col-md-12">
                       <asp:TextBox ID="TextBox5" runat="server"   CssClass="form-control" AutoPostBack="true" OnTextChanged="TextBox5_TextChanged" required Text="0" min="0" ></asp:TextBox>
                   
               
                    </div>
                </div>
            </div>
          
       
            <div class="col-md-4">
                <div class="form=-group row last">
                    <label class="col-md-6">TXN. PASSWORD</label>
                    <div class="col-md-12">
                       <asp:TextBox ID="TextBox2" runat="server"   CssClass="form-control" TextMode="Password"    ></asp:TextBox>
                   
               
                    </div>
                </div>
            </div>
          
       
       
            
             <div class="col-md-4">
                <div class="form=-group row last">
                   
                     <div class="col-md-5" style="margin-top:25px;">
                          <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Transfer Fund" CssClass="form-control btn btn-dark"  />
                         <asp:Label ID="Label2" runat="server" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
                 </div></div></div>
   
</asp:Content>


