<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="autopool.aspx.cs" Inherits="User_autopool" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <script type = "text/javascript">
         function DisableButton() {
             document.getElementById("<%=Button1.ClientID %>").disabled = true;
        }
        window.onbeforeunload = DisableButton;
</script>
         <span class="text text-bold text-primary">
        <h3>Investment in Autopol Now</h3>
    </span>
    <div id="Addmissiondetail" style="border: 2px solid black"></div>
    <div class="container" style="background-color: white; width: 90%;">
       <br />
        <hr />
        <div class="form-group row">
            <label class="col col-lg-3">Username</label>
            <div class="col-lg-6">
                <asp:TextBox ID="txtunameid" placeholder="Username" CssClass="form-control" required   runat="server"></asp:TextBox>
            </div>
            <div class="col-lg-3">
               <asp:Button ID="Button3" runat="server" onclick="Button3_Click" CssClass="form-control btn btn-success" Width="100%" Text="Search" />
            </div>
        </div>
        
        <div class="form-group row">
            <label class=" col col-lg-3">Name</label>
            <div class="col-lg-9">
                <asp:TextBox ID="txtname" placeholder="Name" CssClass="form-control" Font-Bold="true" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
        </div>

         <div class="form-group row">
            <label class=" col col-lg-3">Available Amount</label>
            <div class="col-lg-9">
                 <asp:TextBox ID="TextBox1" CssClass="form-control" Font-Bold="true" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
             </div>

        <div class="form-group row">
            <label class=" col col-lg-3">Invest Amount For Autopool</label>
            <div class="col-lg-9">
                <asp:DropDownList ID="DropDownList1" runat="server"  CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
                    <asp:ListItem Selected="True">SELECT PACKAGE FOR AUTOPOOL</asp:ListItem>
                    <asp:ListItem Value="600" >600</asp:ListItem>
                   


                </asp:DropDownList>
               
            </div>
        </div>
     
        
        <div class="form-group row">
            <div class="col-lg-3"></div>
            <div class="col-lg-9">
              <asp:Button ID="Button1" runat="server" onclick="Button1_Click" CssClass="form-control btn btn-success" Text="Active Now" />
        &nbsp;<asp:Button ID="Button2" Visible="false" runat="server" OnClick="Button2_Click" Text="Re-Print Welcome Letter" />
            </div>
        </div>
        <br />
    </div>

</asp:Content>

