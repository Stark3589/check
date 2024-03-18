<%@ Page EnableEventValidation="true" MaintainScrollPositionOnPostback="true" Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="Homefrn.aspx.cs" Inherits="Admin_homefrn" %>

<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
      <section class="content-header" style="background-color: rgba(0, 0, 0, 0.5);  padding-bottom: 10px; color: #fff;">
                    <h1>Dashboard
                    </h1>
                   
                </section>
   
    <style type="text/css">
        .modalBackground {
            background-color: Gray;
            filter: alpha(opacity=30);
            opacity: 0.8;
            z-index: 10000;
            padding-top: -25px;
        }

        .mpadd {
            padding-bottom: 20px;
        }

        .color1 {
            background-color: #4158D0;
            border: none;
            border-radius:10px;
        }

        .color2 {
            background-color: #FBAB7E;
            border: none;
             border-radius:10px;
        }

        .color3 {
            background-color: #3EECAC;
            border: none;
             border-radius:10px;
        }

        .color4 {
            background: rgb(34,193,195);
            border: none;
             border-radius:10px;
        }

        .color5 {
            background-color: #FF3CAC;
            border: none;
             border-radius:10px;
        }

        .color6 {
            background: #300fb5;
            border: none;
             border-radius:10px;
        }

        .color7 {
            background: #993300;
            border: none;
             border-radius:10px;
        }

        .color8 {
            background: #3333cc;
            border: none;
             border-radius:10px;
        }

        .color9 {
            background: #990099;
            border: none;
             border-radius:10px;
        }

        .color10 {
            background: #99cc00;
            border: none;
             border-radius:10px;
        }

        .color11 {
            background: #993366;
            border: none;
             border-radius:10px;
        }

        .color12 {
            background: #3366cc;
            border: none;
             border-radius:10px;
        }

        .color13 {
            background: #9966ff;
            border: none;
             border-radius:10px;
        }

        .color14 {
            background: #993300;
            border: none;
             border-radius:10px;
        }
    </style>

    <section class="content">
        
        
           <div class="row">
            
            <div class="col-lg-12 col-xs-12 mpadd">
                   <ajax:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </ajax:ToolkitScriptManager>
               
        
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="row">
                    
                    <!-- ./col -->

                     <div class="col-lg-3 ">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-light-blue color3">
                                <div class="inner">
                                    <h5>Total Id</h5>
                                    <h3>
                                        <asp:Label ID="Label5" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa fa-users" aria-hidden="true"></i>

                                </div>

                            </div>
                        </a>
                    </div>
                    <!-- ./col -->
                   
                     <div class="col-lg-3 " style="display:none">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-yellow color6">
                                <div class="inner">
                                    <h5>Total Not Active</h5>
                                    <h3>
                                        <asp:Label ID="Label2" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa fa-users" aria-hidden="true"></i>

                                </div>

                            </div>
                        </a>
                    </div>

                    <div class="col-lg-3 ">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-light-blue color3">
                                <div class="inner">
                                    <h5>Total Business</h5>
                                    <h3>
                                        <asp:Label ID="Label4" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa fa-dollar-sign" aria-hidden="true"></i>

                                </div>

                            </div>
                        </a>
                    </div>

                    <div class="col-lg-3 ">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-yellow color4">
                                <div class="inner">
                                    <h5>Total Withdrawal</h5>
                                    <h3>
                                        <asp:Label ID="Label11" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa fa-dollar-sign" aria-hidden="true"></i>

                                </div>

                            </div>
                        </a>
                    </div>
                    <!-- ./col -->
                   

                    <div class="col-lg-3 " style="display:none">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-green color6">
                                <div class="inner">
                                    <h5>Today Registration</h5>
                                    <h3>
                                        <asp:Label ID="lbl_team" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa fa-user"></i>
                                </div>
                            </div>
                        </a>
                    </div>
                     <div class="col-lg-3 ">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-yellow color3">
                                <div class="inner">
                                    <h5>Today Business</h5>
                                    <h3>
                                        <asp:Label ID="Label12" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa fa-dollar-sign"></i>
                                </div>
                            </div>
                        </a>
                    </div>
                     <div class="col-lg-3 " style="display:none;">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-orange color13">
                                <div class="inner">
                                    <h5>Booster ID Business</h5>
                                    <h3>
                                        <asp:Label ID="Label13" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa fa-users"></i>
                                </div>
                            </div>
                        </a>
                    </div>
                    <!-- ./col -->

                    <!-- ./col -->
                    
                     <div class="col-lg-3 ">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-purple color6">
                                <div class="inner">
                                    <h5>Admin Transfer</h5>
                                    <h3>
                                        <asp:Label ID="Label3" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa fa-dollar-sign"></i>
                                </div>
                            </div>
                        </a>
                    </div>
                   
                    <div class="col-lg-3 ">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-pink color10">
                                <div class="inner">
                                    <h5>Total Fund </h5>
                                    <h3>
                                        <asp:Label ID="Label8" runat="server" Text="0"></asp:Label></h3>
                                </div>
                               <div class="icon">
                                  <i class="fa fa-dollar-sign"></i>
                                </div>
                            </div>
                        </a>
                    </div>
                     <div class="col-lg-3 " style="display:none">
                        <a href="#">
                            <!-- small box -->
                            <div class="small-box bg-blue color13">
                                <div class="inner">
                                    <h5>Total Income</h5>
                                    <h3>
                                        <asp:Label ID="join_date" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa fa-dollar-sign"></i>
                                </div>
                            </div>
                        </a>
                    </div>
                    <!--<div   style="background-color:rgba(0, 0, 0, .5); padding:15px 0 15px 10px; margin-bottom:10px; font-size:18px color:#fff; border:1px solid #FF0000; margin-left:-15px;">Business Details</div> -->




                    <%--                    <div class="col-lg-4 col-xs-6">
                        <a href="#">
                            <div class="small-box bg-orange color10">
                                <!-- small box -->

                                <div class="inner">
                                    <h3>Level Achieved </h3>
                                    <h3>
                                        <asp:Label ID="lvl" runat="server" Text="0"></asp:Label></h3>
                                </div>
                                <div class="icon">
                                    <i class="fa  fa-user"></i>
                                </div>
                            </div>
                        </a>
                    </div>--%>
                    <!-- ./col -->

                    <!-- ./col -->
                    <%--  <div class="col-lg-3 col-xs-6">
            <a href="#">
          <!-- small box -->
          <div class="small-box bg-lime">
            <div class="inner">
              <h3>Current Level</h3>
                <h3>
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></h3>
            </div>
            <div class="icon">
             
            </div>
          </div>
                </a>
        </div>--%>

                    <%--    <div class="col-lg-3 col-xs-6">
            <a href="#">
          <!-- small box -->
          <div class="small-box bg-lime">
            <div class="inner">
              <h3>My Joining Level</h3>
                <h3>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></h3>
            </div>
            <div class="icon">
             
            </div>
          </div>
                </a>
        </div>--%>
                </div>
                <!-- ./col -->
            </div>
            <div class="col-lg-3">
                <%--<div class="box box-primary">
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

               
                <!-- /end -->




            </div>

        </div>

        <!-- /.row (main row) -->

    </section>




    
<!-- partial -->
  
</asp:Content>

