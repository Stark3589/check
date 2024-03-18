<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="Reg.aspx.cs" Inherits="User_Reg" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <script type = "text/javascript">
          function ValidateCheckBox(sender, args) {
              if (document.getElementById("<%=CheckBox1.ClientID %>").checked == true) {
                 args.IsValid = true;
             } else {
                 args.IsValid = false;
             }
         }
    </script>
        <script src="register/js/modernizr.custom.63321.js"></script>
        <!--[if lte IE 7]><style>.main{display:none;} .support-note .note-ie{display:block;}</style><![endif]-->
		<style>
			body {
				background: #e1c192 url(register/images/wood_pattern.jpg);
			}
		</style>
    <script type = "text/javascript">
        function DisableButton() {
            document.getElementById("<%=bntpersonal.ClientID %>").disabled = true;
        }
        window.onbeforeunload = DisableButton;
</script>
     <style type="text/css">
        .modalBackground
        {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
        }
        .modalPopup
        {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 300px;
            height: 140px;
        }
    </style>
       
		<center><h4>Add Member</h4></center>
			<!-- Codrops top bar -->
            <hr />
           
			
			 <div class="row">
      
            <div class="col-md-4">	
                 <div class="input_field">			
                  
					
						<label for="login"><i class="icon-user"></i>Sponser ID  <span style="color:#277d04">&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lbsponsername" runat="server"></asp:Label></label>
						  <asp:TextBox ID="Drpsopnser" CssClass="form-control" OnTextChanged="Drpsopnser_TextChanged" AutoPostBack="true"  runat="server" placeholder="Sponser"></asp:TextBox>
                     
						 
         </div>
            </div>


                


                      <div class="col-md-4">	
                 <div class="input_field">	<label for="login"><i class="icon-user"></i>Select Side</label>   <asp:Table runat="server" Width="80%"><asp:TableRow><asp:TableCell><asp:RadioButton ID="rbntleft" runat="server" Text="Left" ForeColor="Red"   GroupName="a" /></asp:TableCell><asp:TableCell><asp:RadioButton ID="rdbntright" ForeColor="Red" runat="server" Text="Right"   GroupName="a" /> </asp:TableCell></asp:TableRow></asp:Table>
                     </div></div>
                        <asp:Label ID="lbmsg" runat="server" Text="" ForeColor="#ff0000" Font-Bold="true"></asp:Label>
						
                        <asp:Label ID="txtpassword" runat="server" Visible="false"></asp:Label>
                
					
                 <div class="col-md-2">	
                 <div class="input_field">
						 
						 <asp:Button ID="Search"  runat="server"  Text="Search" CssClass="form-control btn-success"  OnClientClick="script:return valid();" OnClick="Search_Click"/>
					</div></div>



                 </div>
    <div class="row">
        <div class="col-md-12">
        <hr />
            </div>
        </div>
     <div class="row">

                <div class="col-md-4">	
                 <div class="input_field">			<asp:TextBox ID="TextBox1" CssClass="form-control" Visible="false"  ReadOnly="true" runat="server"></asp:TextBox>
                  
					
						<label for="login"><i class="icon-user"></i>Upline ID  <span style="color:#277d04">&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label5" runat="server"></asp:Label></label>
						  <asp:TextBox ID="txtupline" CssClass="form-control"  OnTextChanged="txtupline_TextChanged" AutoPostBack="true"   runat="server"></asp:TextBox>
                     
						
         </div>
            </div>
               
       
         <div class="col-md-4">		
                       <label for="login"><i class="icon-user"></i>UserName</label>
						<asp:TextBox ID="txtuid" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                        
					</div>
          <div class="col-md-4">		
                       <label for="login"><i class="icon-user"></i>Password</label>
						 <asp:TextBox ID="password" CssClass="form-control" runat="server" ></asp:TextBox>
					</div>
         <div class="col-md-4">		
                       <label for="login"><i class="icon-user"></i>Txn. Password</label>
						 <asp:TextBox ID="txn" CssClass="form-control"  runat="server" ></asp:TextBox>
					</div>
         </div>
          <div class="row">
        <div class="col-md-12">
        <hr />
            </div>
        </div>
     <div class="row">
         

					<div class="col-md-4">		
                       <label for="login"><i class="icon-user"></i>Name</label>
						 <asp:TextBox ID="txtuname" CssClass="form-control"   runat="server"></asp:TextBox>
                        
					</div>
 
               
					
					 <div class="col-md-4">	
                 <div class="input_field">
						<label for="login"><i class="icon-phone"></i>Mobile No</label>
						   <asp:TextBox ID="txtmobile"  CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"  
ControlToValidate="txtmobile" ErrorMessage="*"  
ValidationExpression="[0-9]{10}" ForeColor="Red"></asp:RegularExpressionValidator>  
                     </div>
                         </div>
					 <%--<div class="col-md-4">	
                 <div class="input_field">
						<label for="login"><i class="icon-phone"></i>PAN No</label>--%>
						   <asp:TextBox ID="panno" CssClass="form-control" runat="server" Visible="false"></asp:TextBox>
                       <%--</div></div>--%>

					 <div class="col-md-4">	
                 <div class="input_field">
						<label for="login"><i class="icon-envelope"></i>Email ID</label>
						 <asp:TextBox ID="txtemail"  CssClass="form-control" runat="server" ></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtemail"
    ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
    Display = "Dynamic" ErrorMessage = "Invalid EMail ID"/>
					</div></div>
          
                              </div>
          <div class="row">
        <div class="col-md-12">
        <hr />
            </div>
        </div>
     <div class="row">

                   <%-- <p >
						<label for="date"><i class="icon-calendar"></i>Date Of Joining</label>
						<asp:TextBox ID="txtdoj" CssClass="form-control" type="date" runat="server"></asp:TextBox>
                       
					</p>--%>
                   
					
						
						
                       
					
					
					<div class="col-md-4">	
                 <div class="input_field">
                        <asp:Label ID="Label3" runat="server" Width="100%" Text="I Agree with All Terms & Conditions *" ForeColor="Black"></asp:Label>
                          <asp:CheckBox ID="CheckBox1" Width="100%" runat="server" Text="Terms & Condition" ForeColor="Red" />
                        <%--<asp:Label ID="lbltrans" runat="server" Width="100%" Text="Any dispute will be the jurisdiction or settlement of Bareilly *" ForeColor="Red"></asp:Label>--%>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Required" ClientValidationFunction = "ValidateCheckBox"></asp:CustomValidator><br />
					</div>
                        </div>
           
                       
					
              
						
						
					<br />
					<div class="col-md-2">	
                 <div class="input_field">
						 
						 <asp:Button ID="bntpersonal"   runat="server" Text="Sign Up" Visible="false" CssClass="form-control btn-success"  OnClientClick="script:return valid();" OnClick="bntpersonal_Click"/>
					</div></div></div>
                      <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager> 
<asp:Button ID="btnShow" runat="server" style="display:none"   />

<!-- ModalPopupExtender -->
<cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panel1" TargetControlID="btnShow"
    CancelControlID="btnClose" BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center" style = "display:none">
    <b>Registration Successfull.</b><br />
    <b>Username : <asp:Label ID="Label1" runat="server" ></asp:Label></b> <br />
   <b> Your Password : <asp:Label ID="Label2" runat="server" ></asp:Label></b> <br />
     <b> Txn. Password : <asp:Label ID="Label4" runat="server" ></asp:Label></b> <br /><br />
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Button1_Click">Thanks</asp:LinkButton>
   
    <asp:Button ID="btnClose" runat="server" Text="Close" style="display:none"  />
</asp:Panel>
				
			</section>
			
        </div>
		<!-- jQuery if needed -->
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
		<script type="text/javascript">
		    $(function () {
		        $(".showpassword").each(function (index, input) {
		            var $input = $(input);
		            $("<p class='opt'/>").append(
			            $("<input type='checkbox' class='showpasswordcheckbox' id='showPassword' />").click(function () {
			                var change = $(this).is(":checked") ? "text" : "password";
			                var rep = $("<input placeholder='Password' type='" + change + "' />")
			                    .attr("id", $input.attr("id"))
			                    .attr("name", $input.attr("name"))
			                    .attr('class', $input.attr('class'))
			                    .val($input.val())
			                    .insertBefore($input);
			                $input.remove();
			                $input = rep;
			            })
			        ).append($("<label for='showPassword'/>").text("Show password")).insertAfter($input.parent());
		        });

		        $('#showPassword').click(function () {
		            if ($("#showPassword").is(":checked")) {
		                $('.icon-lock').addClass('icon-unlock');
		                $('.icon-unlock').removeClass('icon-lock');
		            } else {
		                $('.icon-unlock').addClass('icon-lock');
		                $('.icon-lock').removeClass('icon-unlock');
		            }
		        });
		    });
		</script>

</asp:Content>


