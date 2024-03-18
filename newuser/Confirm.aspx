<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="Confirm.aspx.cs" Inherits="User_Confirm" %>

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
        <h3>Invest Now</h3>
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
            <label class=" col col-lg-3">Invest Amount</label>
            <div class="col-lg-9">
                <asp:DropDownList ID="DropDownList1" runat="server"  CssClass="form-control">
                    <asp:ListItem Selected="True">SELECT PACKAGE</asp:ListItem>
                    <asp:ListItem Value="500" >500</asp:ListItem>
                   


                </asp:DropDownList>
               
            </div>
        </div>
        <div class="form-group row">
           
            <div class="col-lg-6">
                Wallet Amount :<asp:Label ID="Label1" runat="server" ></asp:Label>
            </div>
             <div class="col-lg-6">
                Gift Wallet Amount :<asp:Label ID="Label2" runat="server" ></asp:Label>
            </div>
        </div>
        
        <div class="form-group row">
            <div class="col-lg-3"></div>
            <div class="col-lg-9">
              <asp:Button ID="Button1" runat="server" onclick="Button1_Click" CssClass="form-control btn btn-success" Text="Invest Now" />
        &nbsp;<asp:Button ID="Button2" Visible="false" runat="server" OnClick="Button2_Click" Text="Re-Print Welcome Letter" />
            </div>
        </div>
        <br />
    </div>





    <table style="width: 100%">
    <tr>
        <td>
            </td>
        <td>
          <%--  <asp:Label ID="Label2" runat="server" style="font-weight: 700" Visible=""></asp:Label>--%>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            </td>
        <td>
           
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <%--<asp:TextBox ID="TextBox2" runat="server" required="" ReadOnly="true" Visible="false"></asp:TextBox>--%>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Label ID="lblsponser" runat="server" Visible="false"></asp:Label> </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>



