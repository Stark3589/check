<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_login.aspx.cs" Inherits="Admin_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta charset="utf-8">
	<title>  Log In</title>

	 <meta name="viewport" content="width=device-width, initial-scale=1">
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<meta name="keywords" content="Ribbon Login Form Responsive Templates, Iphone Compatible Templates, Smartphone Compatible Templates, Ipad Compatible Templates, Flat Responsive Templates"/>
<link href="Login_css/style.css" rel='stylesheet' type='text/css' />
<!--webfonts-->
 <link href="https://fonts.googleapis.com/css?family=Asap" rel="stylesheet"><link rel="stylesheet" href="./style.css">
    <link rel="stylesheet" type="text/css" href="main.css">
    
      <style>
			
            body { 
  background: url(register/register_bg.jpg) no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
		</style>
   <%--  <script type="text/javascript">
         function preventBack() { window.history.forward(); }
         setTimeout("preventBack()", 0);
         window.onunload = function () { null };
    </script>--%>
    
</head>
    <%-- When use login protection the use jabascript.js and in textbox onKeyUp="valid(this,'quotes')" --%>

    <body>
        
       
		<form runat="server" class="login" >
            <center> <img src="logo.png" width="40%" /></center>
            <asp:TextBox ID="TextBox1" runat="server" ForeColor="black" class="text"  onKeyUp="valid(this,'quotes')" placeholder="Username" onFocus="this.value = '';" onBlur="if (this.value == '') {this.value = 'Username';}"></asp:TextBox>
			  <asp:TextBox ID="TextBox2" runat="server" placeholder="Password" CssClass="input100" TextMode="Password"  onKeyUp="valid(this,'quotes')"></asp:TextBox>
		
            
            
            		
		<%--<div class="remember">
			
			<h4 style="color:white;font-weight:600">Forgot your password?<a href="#" >Click here.</a></h4> 
		</div>--%>
		<div class="clear"> </div>
		<div class="btn">
            <a href="forgotpassword.aspx" style="color:black;">Forget Password</a>
             <asp:Button ID="Button3" runat="server" style="border:1px solid #069ad6;background-color:#069ad6; border-radius:5px;padding:5px;font-size:18px;font-family: 'Yaldevi', sans-serif;"   ForeColor="White" Text="Login" onclick="Button1_Click" />
			 <asp:Button ID="Button4" runat="server"  style="border:1px solid #069ad6;background-color:#069ad6;border-radius:5px;padding:5px;font-size:18px;font-family: 'Yaldevi', sans-serif;"    OnClick="Button2_Click"  ForeColor="White" Text="Sign Up" />
             <asp:Button ID="Button1" runat="server"  style="border:1px solid #069ad6;background-color:orangered;border-radius:5px;padding:5px;font-size:18px;font-family: 'Yaldevi', sans-serif;"    OnClick="Button1_Click1"  ForeColor="White" Text="Home" />
            

		</div>
		<div class="clear"> </div>
            </form>

  
  
  

        
</body>
</html>
