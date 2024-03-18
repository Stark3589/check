<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- jQuery 3 -->
 <script type="text/javascript">
     function ClientSideClick(myButton) {
         // Client side validation
         if (typeof (Page_ClientValidate) == 'function') {
             if (Page_ClientValidate() == false)
             { return false; }
         }

         //make sure the button is not of type "submit" but "button"
         if (myButton.getAttribute('type') == 'button') {
             // diable the button
             myButton.disabled = true;
             myButton.className = "btn-inactive";
             myButton.value = "processing...";

             //display gray background and message
             document.getElementById("graybackground-div").style.display = "block";
             document.getElementById("message-div").style.display = "block";
         }
         return true;
     }
    </script>
    <style type="text/css">      
       #graybackground-div
       {
           position:absolute;
           top:0px;
           left:0px;
           overflow:hidden;
           width:100%;
           height:100%;
           background-color:#808080;
           opacity:0.5;
           filter:alpha(opacity=50);
           z-index:10;
           display:none;
       }
        #message-div
        {
            position: absolute;
            top: 50%;
            left: 50%;
            margin-left: -250px;
            margin-top: -150px;
            background-color: #0066FF;
            filter: progid:DXImageTransform.Microsoft.Gradient(GradientType=0,StartColorStr='#0066FF',EndColorStr='#CCFFFF');
            width: 500px;
            height: 300px;
            border: 2px solid #FF6600;
            font-family: Arial;
            text-align:center;
            color:#FFFFFF;
            font-size: 18px;
            z-index:20;
            display:none;
        } 
        #message-div div
        {
            padding:70px;
        } 
    </style>
    <link href="Stylesss.css" rel="stylesheet" type="text/css" />
    
    <div style="background-color:white; padding:20px;">
         <div class="row>">
             <div class="col-lg-12">
                <div class="input-group input-group-sm" style="margin-bottom:30px; margin-top:30px;"> 
                <asp:TextBox ID="txtsearchuname" CssClass="form-control" placeholder="Enter User Name" Visible="false"  runat="server"></asp:TextBox>
                    <span class="input-group-btn">                    
<asp:Button ID="btnsearch" runat="server" Text="Go!" Visible="false"   CssClass="btn btn-info btn-flat btn-lg"  />
                </span>
              </div>
                 
              
           
             </div>
             
                      </div>
         <span class="text text-bold text-primary"><h3>Personal Detail</h3></span>
        <div id="personalid11"  style="border:2px solid black"></div>
      <div class="row">
        <div class="col-md-12">
         
                              
              <div class="box-body">
                 <div class="row">
             
             <div class="col-lg-6">
                 <div class="form-group">
                     <label>Name</label>
                 <asp:TextBox ID="txtname" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox> 
                     </div>
             </div>
             <div class="col-lg-6">
              <div class="form-group">
                 <label>User Name</label>
            <asp:TextBox ID="txtuid" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox> 
              
              </div></div>
                     </div>

             
                  <!----Bank Detail---->
                     <span class="text text-bold text-primary"><h3>Wallet  Detail</h3></span>
        <div id="personalid"  style="border:2px solid black"></div>
             <div class="row">
             
             <div class="col-lg-12">
              <div class="form-group">
                  <label>USDT(BEP20) Wallet Address</label>
            <asp:TextBox ID="txtbank" CssClass="form-control" runat="server"></asp:TextBox>
             
              </div></div>
                        
            
              </div>
             
               <div class="clearfix"></div>
             <div class="row" style="margin-top:20px; margin-bottom:50px;">
                 <div class="col-lg-4">

                     <asp:GridView ID="GridView1" runat="server" Width="434px"  Visible="false"></asp:GridView>
                 </div>
                 <div class="col-lg-4">
<%--                     <asp:Button ID="btnopt" runat="server"  class="btn btn-block btn-danger" Visible="false" Text="Verify Update Record" OnClick="btnopt_Click"/>--%>
                     <asp:Button ID="bntpersonal"   runat="server" Text="SUBMIT" CssClass="btn btn-block btn-danger" OnClick="bntpersonal_Click" />
                 </div>
             </div>
      
              </div></div></div>
            
          
    
      <!-- /.row -->
    <!----wait images--->
    
  
    <div id="graybackground-div">	    
	</div>
	<div id="message-div">
	        <div>Processing data, please wait...</div>
	</div>
        </div>
</asp:Content>

