<%@ Page EnableEventValidation="true" Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Admin_home" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" tagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   

   <style type="text/css">
.modalBackground
{
background-color: Gray;
filter: alpha(opacity=30);
opacity: 0.8;
z-index: 10000;
padding-top:-25px;
}

</style>
    <style>
        .color1 {
            background-color: #4158D0;
            background-image: linear-gradient(43deg, #4158D0 0%, #C850C0 46%, #FFCC70 100%);
            border: none;
            border-radius: 10px;
        }

        .color2 {
            background-color: #FBAB7E;
            background-image: linear-gradient(62deg, #FBAB7E 0%, #F7CE68 100%);
            border: none;
            border-radius: 10px;
        }

        .color3 {
            background-color: #3EECAC;
            background-image: linear-gradient(19deg, #3EECAC 0%, #EE74E1 100%);
            border: none;
            border-radius: 10px;
        }

        .color4 {
            background: rgb(34,193,195);
            background: linear-gradient(0deg, rgba(34,193,195,1) 0%, rgba(253,187,45,1) 100%);
            border: none;
            border-radius: 10px;
        }

        .color5 {
            background-color: #FF3CAC;
            background-image: linear-gradient(225deg, #FF3CAC 0%, #784BA0 50%, #2B86C5 100%);
            border: none;
            border-radius: 10px;
        }

        .color6 {
            background:linear-gradient(to right, #300fb5 0%, #e4b03c 100%);
            border: none;
            border-radius: 10px;
        }

        .color7 {
            background: linear-gradient(to right, #0099cc 0%, #cccc00 100%);
            border: none;
            border-radius: 10px;
        }

        .color8 {
            background: linear-gradient(to right, #cc3300 0%, #3333cc 100%);
            border: none;
            border-radius: 10px;
           
        }

        .color9 {
            background: linear-gradient(to right, #339966 0%, #990099 100%);
            border: none;
            border-radius: 10px;
        }

        .color10 {
            background: linear-gradient(to right, #999966 0%, #99cc00 100%);
            border: none;
            border-radius: 10px;
        }

        .color11 {
            background: linear-gradient(to right, #339966 0%, #993366 100%);
            border: none;
            border-radius: 10px;
        }

        .color12 {
            background: linear-gradient(to right, #990099 0%, #3366cc 100%);
            border: none;
            border-radius: 10px;
        }

        .color13 {
            background: linear-gradient(to right, #00cc66 0%, #9966ff 100%);
            border: none;
            border-radius: 10px;
        }

    </style>
   <section class="content">
       <link rel="stylesheet" href="main.css">
      <!-- Small boxes (Stat box) -->
      <div class="row">
	  <div class="col-lg-9">
	  <div class="row">
        <div class="col-lg-4 col-xs-6">
          <!-- small box -->
          <div class="small-box bg-aqua color1">
            <div class="inner">
                <h3>My Team</h3>
              <h3>Total ID's&nbsp;-&nbsp; <asp:Label ID="Label1" runat="server" Text="0"></asp:Label></h2></h3>

            </div>
            <div class="icon">
              <h2>
                 
            </div>
          
          </div>
        </div>
        <!-- ./col -->
        <div class="col-lg-4 col-xs-6">
            <a href="edituser.aspx">
          <!-- small box -->
          <div class="small-box bg-green color3">
            <div class="inner">
             <h3> Edit Member</h3>
              <div style="padding-top:30px;"></div>
            </div>
            <div class="icon">
              <i class="fa fa-pencil-square-o"></i>
            </div>
            </div>
          </a>
        </div>
        <!-- ./col -->
        <div class="col-lg-4 col-xs-6">
            <a href="pintransfer.aspx">
          <!-- small box -->
          <div class="small-box bg-yellow color11">
            <div class="inner">
              <h3>Pin Transfer</h3>
                    <div style="padding-top:30px;"></div>
            </div>
            <div class="icon">
              <i class="fa fa-users"></i>
            </div>
          </div>
                </a>
        </div>
        <!-- ./col -->
        <div class="col-lg-4 col-xs-6">
            <a href="ActiveReport.aspx">
          <!-- small box -->
          <div class="small-box bg-red color4">
            <div class="inner">
              <h3>Direct List</h3>
                 <div style="padding-top:30px;"></div>
            </div>
            <div class="icon">
              <i class="fa fa-file-text-o"></i>
            </div>
          </div>
                </a>
        </div>
		
	
        <div class="col-lg-4 col-xs-6">
            <a href="account.aspx">
          <!-- small box -->
          <div class="small-box bg-light-blue color5">
            <div class="inner">
              <h3>Total Income</h3>
                <div style="padding-top:30px;"></div>
             <%--   <h3><asp:Label ID="lbl" runat="server"></asp:Label></h3>--%>
            </div>
            <div class="icon">
              <i class="fa fa-user"></i>
            </div>
          
          </div>
                </a>
        </div>
        <!-- ./col -->
        
        <!-- ./col -->
        <div class="col-lg-4 col-xs-6">
            <a href="Register.aspx">
          <!-- small box -->
          <div class="small-box bg-lime color7">
            <div class="inner">
              <h3>New Joining</h3>
                <div style="padding-top:30px;"></div>
            </div>
            <div class="icon">
              <i class="fa fa-hand-o-right"></i>
            </div>
          </div>
                </a>
        </div>
        <!-- ./col -->
        <div class="col-lg-4 col-xs-6">
            <a href="password.aspx">
          <!-- small box -->
          <div class="small-box bg-orange color9">
            <div class="inner">
              <h3>Pin Generate</h3>
                <div style="padding-top:30px;"></div>
            </div>
            <div class="icon">
              <i class="fa fa-lock"></i>
            </div>
          </div>
		  </a>
        </div><!--<div   style="background-color:rgba(0, 0, 0, .5); padding:15px 0 15px 10px; margin-bottom:10px; font-size:18px color:#fff; border:1px solid #FF0000; margin-left:-15px;">Business Details</div> -->
		
		<div class="row" style="padding-left:15px;">
		<div class="col-lg-12"><%--<div   style="background-color:rgba(0, 0, 0, .5); padding:15px 0 15px 10px; margin-bottom:10px; font-size:24px color:#fff; border:1px solid #FF0000; margin-left:-15px; color:#fff;">Business Details</div>--%></div>
		<%--<div class="col-lg-6"> <div class="box box-primary" style="background-color:rgba(255, 255, 255, .3)">
           
             <div class="box-header">

              <h3 class="box-title">Profile Status</h3>

             
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <ul class="todo-list">
                <li>
                 
               
                  <span class="text">Last Login :</span>
                  <!-- Emphasis label -->
                  <small class="label label-danger">05/07/2017</small>
                  <!-- General tools such as edit or delete-->
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                    
                  <span class="text">Joinging Date :</span>
                  <small class="label label-info"><i class="fa fa-clock-o"></i> 02/01/2015</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                     
                  <span class="text">Join As :</span>
                  <small class="label label-warning"> Rs. 250000/-</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                    
                  <span class="text">Activate Date : </span>
                  <small class="label label-success">20/10/2015</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                  <span class="text">Status :</span>
                  <small class="label label-primary">Active</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                
              </ul>
            </div>
            
          </div>
          <!-- /end --></div>--%>
		  <%--<div class="col-lg-6">
		 <div class="box box-primary" style="background-color:rgba(255, 255, 255, .3)">
            <div class="box-header">

              <h3 class="box-title">Profile Status</h3>

             
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <ul class="todo-list">
                <li>
                 
               
                  <span class="text">Last Login :</span>
                  <!-- Emphasis label -->
                  <small class="label label-danger">05/07/2017</small>
                  <!-- General tools such as edit or delete-->
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                    
                  <span class="text">Joinging Date :</span>
                  <small class="label label-info"><i class="fa fa-clock-o"></i> 02/01/2015</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                     
                  <span class="text">Join As :</span>
                  <small class="label label-warning"> Rs. 250000/-</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                    
                  <span class="text">Activate Date : </span>
                  <small class="label label-success">20/10/2015</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                  <span class="text">Status :</span>
                  <small class="label label-primary">Active</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                
              </ul>
            </div>
            
          </div>
		  </div>--%>
		</div>
		</div>
        </div>
          
          <div class="col-lg-3"> <%--<div class="box box-primary">
            <div class="box-header">

              <h3 class="box-title">Profile Status</h3>

             
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <ul class="todo-list">
                <li>
                 
               
                  <span class="text">Last Login :</span>
                  <!-- Emphasis label -->
                  <small class="label label-danger">05/07/2017</small>
                  <!-- General tools such as edit or delete-->
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                    
                  <span class="text">Joinging Date :</span>
                  <small class="label label-info"><i class="fa fa-clock-o"></i> 02/01/2015</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                     
                  <span class="text">Join As :</span>
                  <small class="label label-warning"> Rs. 250000/-</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                    
                  <span class="text">Activate Date : </span>
                  <small class="label label-success">20/10/2015</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                <li>
                  <span class="text">Status :</span>
                  <small class="label label-primary">Active</small>
                  <div class="tools">
                    <i class="fa fa-edit"></i>
                    <i class="fa fa-trash-o"></i>
                  </div>
                </li>
                
              </ul>
            </div>
            
          </div>--%>
          <!-- /end -->
		  
		   <div class="box box-primary">
            <div class="box-header">

              <h3 class="box-title">Member News</h3>

             
            </div>
			 <ul class="todo-list">
			 <li>
            <!-- /.box-header -->
            <div class="box-body">
              <marquee direction="up" scrollamount="3" height="200" behavior="scroll" onMouseOver="this.stop()" onMouseOut="this.start()">
                  
                    <asp:Label ID="Label6" runat="server" ></asp:Label></marquee>
            </div>
			</li>
            </ul>
          </div>
          <!-- /end -->
		  
		  
		  
		  
		  </div>
		  
      </div>
      
      <!-- /.row (main row) -->

    </section>

    <ajax:toolkitscriptmanager ID="ToolkitScriptManager1" runat="server">
</ajax:toolkitscriptmanager>
    <asp:Button ID="btnShowPopup" runat="server" style="display:none" />
<ajax:modalpopupextender ID="ModalPopupExtender1" runat="server" TargetControlID="btnShowPopup" PopupControlID="pnlpopup" 
 BackgroundCssClass="modalBackground">
</ajax:modalpopupextender>
<asp:Panel ID="pnlpopup" BorderColor="White" style="border-color:white; border-width:10px; border-radius:10px; display:none;" runat="server" BackColor="White" Height="500px" Width="400px"  >
    <div ><img src="abcd.jpg" style="border-color:white; border-width:10px; border-radius:10px;" width="400px" height="500px" /></div>
<asp:Button ID="btnUpdate" CommandName="Update" runat="server" Text="Update" Visible="false" />
<%--<asp:Button ID="btnCancel" runat="server" Text="Cancel"  />--%>
   <center> <asp:LinkButton ID="btnCancel" OnClick="btnCancel_Click" ForeColor="red" Font-Size="Large" runat="server">Continue...</asp:LinkButton></center>
</asp:Panel>

    <asp:Button ID="btnshowpp" runat="server" style="display:none" />
<ajax:modalpopupextender ID="ModalPopupExtender2" runat="server" TargetControlID="btnshowpp" PopupControlID="Panel1" 
CancelControlID="LinkButton1" BackgroundCssClass="modalBackground">
</ajax:modalpopupextender>
<asp:Panel ID="Panel1" BorderColor="White" style="border-color:white; border-width:10px; border-radius:10px; display:none;" runat="server" BackColor="White" Height="200px" Width="400px" >
    <div style="width:400px;height:500px;padding-left:10px;padding-right:10px;text-align:justify;">
        <br />
        <p id="Label2" runat="server" Font-Bold="True" Font-Size="Small" style="width:350px"></p>
        <center><asp:LinkButton ID="LinkButton1" ForeColor="Red" Font-Size="Large" runat="server">Continue...</asp:LinkButton></center>
    </div>
    
<asp:Button ID="Button2" CommandName="Update" runat="server" Text="Update" Visible="false" />
<%--<asp:Button ID="btnCancel" runat="server" Text="Cancel"  />--%>
    
</asp:Panel>
  <%--  <div id="boxes">
  <div style="top: 199.5px; left: 551.5px; display: none;" id="dialog" class="window"> Welcome To Magic Five !
    <div id="lorem">
      <p><img src="abcd.jpg" width="100%" height="480" /></p>
    </div>
    <div id="popupfoot"> <a href="#" class="close agree">Continue...</a> </div>
  </div>
  <div style="width: 1478px; font-size: 32pt; color:white; height: 602px; display: none; opacity: 0.8;" id="mask"></div>
</div>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.js"></script> 
<script src="main.js"></script>
<script type="text/javascript">

    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-36251023-1']);
    _gaq.push(['_setDomainName', 'jqueryscript.net']);
    _gaq.push(['_trackPageview']);

    (function () {
        var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
        ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
    })();

</script>--%>


    </asp:Content>

