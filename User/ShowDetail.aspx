<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowDetail.aspx.cs" Inherits="ShowDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        * {
            margin: 0;
        }

        body {
            margin: auto;
             background: linear-gradient(to right, #0033cc 0%, #66ff99 100%);
        }

        .divset {
            height: 300px;
            width: 50%;
            margin-top:160px;
            border:1.5px dashed red;
            outline:1px solid black;
            outline-offset:-8px;
            background-image:url(../register/ggg.jpg);
        }
        .pdd {
            padding-bottom:10px;
            padding-top:10px
        }
        .btnback {
                background: #941515;
    color: white;
    font-weight: 700;
    padding: 2px 15px;
    border-color: white;
        }
        .btnsign {
                background-color:green;
    color: white;
    font-weight: 700;
    padding: 2px 15px;
    border-color: white;
        }
        .hedingset {
            font-size:14px;
            font-weight:800;
          
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div class="container">
            <div class="row">
               
                <div class="divset">
                        <div class="col-md-12 pdd">
<img src="../register/logo.png" style="height:90px;width:100%;" />
                            </div>
                    <div class="col-md-5 pdd">
                       <span class="hedingset"> Username</span>
                    </div>
                    <div class="col-md-7 pdd">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </div>
                    <div class="col-md-5 pdd">
                        <span class="hedingset">  Password</span>
                    </div>
                    <div class="col-md-7 pdd">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </div>
                     <div class="col-md-6 pdd">
                         <asp:Button ID="Button1" CssClass="btnback" OnClick="Button1_Click"  runat="server" Text="Login"></asp:Button>
                         </div>
                    
                </div>
               
            </div>
            </div>
            
     
            
            </center>
    </form>
</body>
</html>
