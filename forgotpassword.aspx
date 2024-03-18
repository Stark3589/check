<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forgotpassword.aspx.cs" Inherits="forgotpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forget Password ?</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<meta name="keywords" content="Ribbon Login Form Responsive Templates, Iphone Compatible Templates, Smartphone Compatible Templates, Ipad Compatible Templates, Flat Responsive Templates"/>
<link href="Login_css/style.css" rel='stylesheet' type='text/css' />
<!--webfonts-->
 <link href="https://fonts.googleapis.com/css?family=Asap" rel="stylesheet"><link rel="stylesheet" href="./style.css">
    <style>
			
            body { 
  background: url(register/register_bg.jpg) no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
		</style>
</head>

<body>
    
    <form id="form1" runat="server" class="login">
        
        
                     <asp:Label ID="Label2" runat="server" ForeColor="#000000"  Font-Size="x-Large" Text="Forget Your Password"></asp:Label>
                <asp:TextBox ID="txtusername" runat="server" ForeColor="black" class="text"  onKeyUp="valid(this,'quotes')" placeholder="Username" onFocus="this.value = '';" onBlur="if (this.value == '') {this.value = 'Username';}"></asp:TextBox>
	 <asp:TextBox ID="txtmobile" runat="server" ForeColor="black" class="text"  onKeyUp="valid(this,'quotes')" placeholder="Email ID" onFocus="this.value = '';" onBlur="if (this.value == '') {this.value = 'Emaild ID';}"></asp:TextBox>
	
        	<div class="clear"> </div>
		<div class="btn">
                 <asp:Button ID="Button1" runat="server" style="border:1px solid #069ad6;background-color:#069ad6; border-radius:5px;padding:5px;font-size:18px;font-family: 'Yaldevi', sans-serif;"   ForeColor="White" Text="Send" OnClick="Button1_Click" />
			 <asp:Button ID="Button4" runat="server"  style="border:1px solid #069ad6;background-color:#069ad6;border-radius:5px;padding:5px;font-size:18px;font-family: 'Yaldevi', sans-serif;"    OnClick="Button2_Click"  ForeColor="White" Text="Sign in" />
            </div>
                
               
  
    </form>
              
</body>
</html>
