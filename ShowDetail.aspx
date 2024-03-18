<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowDetail.aspx.cs" Inherits="ShowDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="showDetails/style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css">
  	
  <link href="https://fonts.googleapis.com/css?family=Varela+Round&display=swap" rel="stylesheet">
</head>
<body style="background-color:#79edf9b5;">
   
        <div id="wrapper">
		<div class="form-container">
            	
			<img src="register/logo.png" width="80%" />
            <br /><br /><br /><br />
			 <form id="form1" runat="server">
				<div class="input-group">
                    <h3 style="margin-left:20px;">Name : &nbsp;</h3>
                    
				   <h3 style="color:blue;"><asp:Label ID="Label3" runat="server" Text="Labdfgdfhel"></asp:Label></h3> 
					<span class="bar"></span>
				</div>
                 <br />
				<div class="input-group">
                    <h3 style="margin-left:20px;">Username : &nbsp;</h3>
				 <h3 style="color:blue;"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h3>
					<span class="bar"></span>
				</div>
                  <br />
                 <div class="input-group">
                    <h3 style="margin-left:20px;">Password : &nbsp;</h3>
				<h3 style="color:blue;"> <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h3>
					<span class="bar"></span>
				</div>
                 
        		<br>
        		
				<div class="input-group">
					<button>
						<span><a href="login.aspx" style="font-size:23px;"> Login &nbsp;</a></span><i class="fas fa-sign-in-alt" ></i>
					</button>
                    <button>
						<span ><a href="index.html" style="font-size:23px;"> Home &nbsp;</a> </span><i class="fas fa-sign-out-alt" ></i>
					</button>
				</div>
			</form>
			
				

		</div>
	</div>


        
   
</body>
</html>
