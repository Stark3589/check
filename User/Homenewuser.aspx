<%@ Page EnableEventValidation="true" Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="Homenewuser.aspx.cs" Inherits="Admin_homenewuser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <section class="content">
      <!-- Small boxes (Stat box) -->
      <div class="row">
	  <div class="col-lg-9">
	  <div class="row">
        <div class="col-lg-3 col-xs-6">
          <!-- small box -->
          <div class="small-box bg-aqua">
            <div class="inner">
              <h3>Today Joining</h3>

            </div>
            <div class="icon">
              <i class="ion ion-stats-bars"></i>
            </div>
          
          </div>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <a href="edit.aspx">
          <!-- small box -->
          <div class="small-box bg-green">
            <div class="inner">
             <h3> Edit Member</h3>
                
            </div>
            <div class="icon">
              <i class="fa fa-pencil-square-o"></i>
            </div>
            </div>
          </a>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <a href="Geneology.aspx">
          <!-- small box -->
          <div class="small-box bg-yellow">
            <div class="inner">
              <h3>Pool Achievers</h3>

            </div>
            <div class="icon">
              <i class="fa fa-users"></i>
            </div>
          </div>
                </a>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <a href="topperformer.aspx">
          <!-- small box -->
          <div class="small-box bg-red">
            <div class="inner">
              <h3>Direct List</h3>

            </div>
            <div class="icon">
              <i class="fa fa-file-text-o"></i>
            </div>
          </div>
                </a>
        </div>
		</div>
		<div class="row">
        <div class="col-lg-3 col-xs-6">
            <a href="closing.aspx">
          <!-- small box -->
          <div class="small-box bg-light-blue">
            <div class="inner">
              <h3>Closing</h3>

            </div>
            <div class="icon">
              <i class="fa fa-user"></i>
            </div>
          
          </div>
                </a>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <a href="bonusgeneology.aspx">
          <!-- small box -->
          <div class="small-box bg-navy">
            <div class="inner">
              <h3>Downline</h3>

            </div>
            <div class="icon">
              <i class="fa fa-picture-o"></i>
            </div>
            </div>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <a href="smallregister.aspx">
          <!-- small box -->
          <div class="small-box bg-lime">
            <div class="inner">
              <h3>New Joining</h3>

            </div>
            <div class="icon">
              <i class="fa fa-hand-o-right"></i>
            </div>
          </div>
                </a>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <a href="password.aspx">
          <!-- small box -->
          <div class="small-box bg-orange">
            <div class="inner">
              <h3>Pin Generate</h3>

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
        <!-- ./col -->
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
              <marquee direction="up" scrollamount="3" height="200" behavior="scroll" onMouseOver="this.stop()" onMouseOut="this.start()">Welcome to SMART TRADING COMPANY </marquee>
            </div>
			</li>
            </ul>
          </div>
          <!-- /end -->
		  
		  
		  
		  
		  </div>
		  
      </div>
      
      <!-- /.row (main row) -->

    </section>

    </asp:Content>

