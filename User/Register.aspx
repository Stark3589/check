<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="registeration1" ValidateRequest="false" %>

<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="ajax" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
       <script type = "text/javascript">
           function DisableButton() {
               document.getElementById("<%=Button5.ClientID %>").disabled = true;
        }
        window.onbeforeunload = DisableButton;
</script>
    <ajax:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajax:ToolkitScriptManager>


    <h3 style="text-align:center">ADD NEW MEMBER</h3>
    <div class="row">
        <div class="col-md-12">
            <div class="col-md-6">
                <div class="form-group row last">
                   <asp:Label ID="Label39" runat="server" Font-Bold="True" Font-Size="Medium"
                                Text="Registration Date" Visible="False"></asp:Label>
                    <div class="col-md-9">
<asp:TextBox ID="TextBox22" runat="server" Visible="False"></asp:TextBox>
                            <ajax:CalendarExtender ID="CalendarExtender3" TargetControlID="TextBox22" Format="dd/MM/yyyy" runat="server">
                            </ajax:CalendarExtender>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3"></label>
                    <div class="col-md-9">

                    </div>
                </div>
            </div>
        </div>
    </div>
  
    <div class="row">
        <div class="col-md-12">
               <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3">Sponser Id</label>
                    <div class="col-md-9">
                         <asp:TextBox ID="txtsponser" CssClass="form-control" runat="server" required="" placeholder="Sponser Id" AutoPostBack="true" OnTextChanged="txtsponser_TextChanged"></asp:TextBox>
                    <asp:Label ID="lbsponser" runat="server" Style="font-weight: 700; color: #FF0000; font-size: medium" Text=""></asp:Label>
                         </div>
                </div>
            </div>
     

            <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3">User ID</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
    </div>
      <div class="row">
        <div class="col-md-12">
                   <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3">USER NAME</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Enter UserName"
                                required=""></asp:TextBox>
                    </div>
                </div>
            </div>
       <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3">Mobile</label>
                    <div class="col-md-9">
 <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox8" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>

           <asp:TextBox ID="TextBox21" Visible="false" runat="server" CssClass="form-control" ></asp:TextBox>
            <asp:TextBox ID="txt_pin"  runat="server"  CssClass="form-control" placeholder="Enter Txn Password" Visible="false" TextMode="Password"
                                required=""></asp:TextBox>
            
            </div>
            </div>
           
     
     
      
    <%--  <div class="row">
        <div class="col-md-12">
           
            <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3"></label>
                    <div class="col-md-9">

                    </div>
                </div>
            </div>
        </div>
    </div>--%>
      <%--<div class="row">
        <div class="col-md-12">
            <div class="col-md-6">
                <div class="form-group row last">
                      <label class="col-md-3">Payment Mode</label>
                    <div class="col-md-9">
                        <asp:DropDownList ID="drpmode" CssClass="form-control" runat="server">
                            <asp:ListItem>Cash</asp:ListItem>
                             <asp:ListItem>Cheque</asp:ListItem>
                             <asp:ListItem>Net Banking</asp:ListItem>
                                <asp:ListItem>Google Pay</asp:ListItem>
                               <asp:ListItem>Phone Pay</asp:ListItem>
                               <asp:ListItem>Paytm</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group row last">
                 
                     <label class="col-md-3">Your Pin</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="TextBox23" ReadOnly="true" runat="server" AutoPostBack="true" CssClass="form-control" OnTextChanged="TextBox23_TextChanged"></asp:TextBox>
                    <asp:Label ID="lblpinmsg" runat="server" CssClass="auto-style1"></asp:Label>
                          </div>
                </div>
            </div>
        </div>
    </div>--%>
      <div class="row">
        <div class="col-md-12">
            <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3"></label>
                    <div class="col-md-9">
                          <asp:Button ID="Button5" runat="server" UseSubmitBehavior="False" CssClass="form-control btn btn-block btn-danger" OnClick="Button5_Click"  Text="SUBMIT" />
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3"></label>
                    <div class="col-md-9">

                    </div>
                </div>
            </div>
        </div>
    </div>
      <div class="row">
        <div class="col-md-12">
            <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3"></label>
                    <div class="col-md-9">

                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group row last">
                    <label class="col-md-3"></label>
                    <div class="col-md-9">

                    </div>
                </div>
            </div>
        </div>
    </div>
    

</asp:Content>

