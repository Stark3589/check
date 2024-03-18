<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="edituser.aspx.cs" Inherits="Admin_edituser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- jQuery 3 -->
    <script src="../bower_components/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap 3.3.7 -->
    <script src="../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- DataTables -->
    <script src="../../bower_components/datatables.net/js/jquery.dataTables.min.js"></script>
    <script src="../../bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"></script>
    <!-- SlimScroll -->
    <script src="../../bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
    <!-- FastClick -->
    <script src="../../bower_components/fastclick/lib/fastclick.js"></script>
    <!-- AdminLTE App -->
    <script src="../../dist/js/adminlte.min.js"></script>
    <!-- AdminLTE for demo purposes -->
    <script src="../../dist/js/demo.js"></script>
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
        #graybackground-div {
            position: absolute;
            top: 0px;
            left: 0px;
            overflow: hidden;
            width: 100%;
            height: 100%;
            background-color: #808080;
            opacity: 0.5;
            filter: alpha(opacity=50);
            z-index: 10;
            display: none;
        }

        #message-div {
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
            text-align: center;
            color: #FFFFFF;
            font-size: 18px;
            z-index: 20;
            display: none;
        }

            #message-div div {
                padding: 70px;
            }
    </style>
    <link href="Stylesss.css" rel="stylesheet" type="text/css" />

    <div style="background-color: white; padding:20px;">
        <div class="row>">
            <div class="col-lg-12">
                <div class="input-group input-group-sm" style="margin-bottom: 30px; margin-top: 30px;">
                    <asp:TextBox ID="txtsearchuname" CssClass="form-control" placeholder="Enter User Name" Visible="false" runat="server"></asp:TextBox>
                    <span class="input-group-btn">
                        <asp:Button ID="btnsearch" runat="server" Text="Go!" Visible="false" CssClass="btn btn-info btn-flat btn-lg" />
                    </span>
                </div>



            </div>

        </div>
        <span class="text text-bold text-primary">
            <h3>Personal Detail</h3>
        </span>
        <div id="personalid11" style="border: 2px solid black"></div>
        <div class="row">
            <div class="col-md-12">


                <div class="box-body">

                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">


                                <label>Name</label>
                                <asp:TextBox ID="txtuname" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                            </div>
                        </div>

                           <div class="col-lg-6">
                            <div class="form-group">

                                <label>Password</label>
                                <asp:TextBox ID="txtpass" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                        
                        <%--   <div class="col-lg-4">
              <div class="form-group">
                 
                <label>Father Name</label>
            <asp:TextBox ID="txtfname" CssClass="form-control" runat="server"></asp:TextBox>
              </div>
                 </div>--%>

                        <%-- <div class="col-lg-4">
             <div class="form-group">
                 
                <label>Enter Date Of Birth </label>
            <asp:TextBox ID="txtDOB"  type="date" CssClass="form-control"  runat="server"></asp:TextBox>
             </div>
                 </div>--%>
                    </div>
                    <%--<div class="row">
                 <div class="col-lg-4">
                     <div class="form-group">
                            
                <label>Sex</label>
                  <asp:DropDownList ID="Drpsex" runat="server" class="form-control" >
                      <asp:ListItem>Male</asp:ListItem>
                       <asp:ListItem>Female</asp:ListItem>
                       <asp:ListItem>Transgender </asp:ListItem>
                  </asp:DropDownList>
              </div>
                     </div>
                  <div class="col-lg-4">
                      <div class="form-group">
              
                 
                <label>Enter Address</label>
          <asp:TextBox ID="txtaddress" CssClass="form-control" runat="server"></asp:TextBox>
              </div>
                      </div>
                  <div class="col-lg-4">
                      <div class="form-group">
             
                 
                <label>PinCode</label>
            <asp:TextBox ID="txtpincode" CssClass="form-control" runat="server"></asp:TextBox>
              </div>
                      </div>
              </div>--%>
                    


                    <div class="row">

                        <div class="col-lg-6">
                            <div class="form-group">


                                <label>Email Id</label>
                                <asp:TextBox ID="txtmobile" CssClass="form-control" runat="server" ></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-lg-6">
                            <div class="form-group">

                                <label>Mobile Number</label>
                                <asp:TextBox ID="txtmobile_no" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <%--  <div class="col-lg-4">
                        <div class="form-group">
              
                 
                <label>Enter Aadhar</label>
           <asp:TextBox ID="txtaadhar" CssClass="form-control" runat="server"></asp:TextBox>
              </div>
                        </div>--%>
                        <div class="col-lg-6">
                            <div class="form-group">


                                <label>Status</label>
                                <asp:TextBox ID="txtstatus" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <!---Addmisiion detail-->
                    <span class="text text-bold text-primary">
                        <h3>Admission Detail</h3>
                    </span>
                    <div id="Addmissiondetail" style="border: 2px solid black"></div>

                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">

                                <label>User ID</label>
                                <asp:TextBox ID="txtuid" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                            </div>
                        </div>



                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Sponser Id</label>
                                <asp:TextBox ID="txtsponser" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
                                <label>
                                    <asp:Label ID="lbsponsername" runat="server" Visible="false"></asp:Label></label>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">

                                <label>Parental ID</label>
                                <asp:TextBox ID="txtupline" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                <asp:Label ID="lbupline" runat="server" Visible="false"></asp:Label>
                            </div>
                        </div>


                        <%-- <div class="col-lg-4">
              <div class="form-group">                 
                <label>Side</label>
                  <asp:TextBox ID="txtside" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                  <asp:Label ID="lbmsg" runat="server" Text=""></asp:Label>
              
              </div></div>--%>
                        <div class="col-lg-6">
                            <div class="form-group">

                                <label>Date of Joining</label>
                                <asp:TextBox ID="txtjoiningdate" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <!----Bank Detail---->
                    <%--<span class="text text-bold text-primary"><h3>Bank  Detail</h3></span>
        <div id="personalid"  style="border:2px solid black"></div>
             <div class="row">
             
             <div class="col-lg-4">
              <div class="form-group">
                  <label>Bank Name</label>
            <asp:TextBox ID="txtbank" CssClass="form-control" runat="server"></asp:TextBox>
             
              </div></div>
             <div class="col-lg-4">
              <div class="form-group">
                 <label>Branch Name</label>
            <asp:TextBox ID="txtbranch" CssClass="form-control" runat="server"></asp:TextBox> 
              
              </div></div>             
             <div class="col-lg-4">
              <div class="form-group">
                 
                <label>Account Type</label>
            <asp:DropDownList ID="drptype" runat="server"  CssClass="form-control">
                    <asp:ListItem>Select Type</asp:ListItem>
                     <asp:ListItem>Saving</asp:ListItem>
                     <asp:ListItem>Current</asp:ListItem>
                </asp:DropDownList>
              </div></div>
              </div>
             <div class="row">
             
             <div class="col-lg-4">
              <div class="form-group">
                 
                <label>Account Number </label>
            <asp:TextBox ID="txtaccount" CssClass="form-control" runat="server"></asp:TextBox>
              </div></div>
             <div class="col-lg-4">
              <div class="form-group">
                 
             <label>Account Holder Name</label>
            <asp:TextBox ID="txtaccountholder" CssClass="form-control" runat="server"></asp:TextBox>
              </div></div>
             <div class="col-lg-4">
              <div class="form-group">                 
                <label>IFSC Code</label>
                   <asp:TextBox ID="txtifsc" CssClass="form-control" runat="server"></asp:TextBox>
              </div></div>
              </div>--%>
                    
                    <div class="row" style="display:none;">
                        <div class="col-lg-6">
                            <label>Nominee Name</label>
                            <asp:TextBox ID="txtnomname" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-6">
                            <label>Relation with Nominee</label>
                            <asp:DropDownList ID="txtnomrelation" CssClass="form-control" runat="server">
                                <asp:ListItem>SELECT</asp:ListItem>
                                <asp:ListItem>FATHER</asp:ListItem>
                                <asp:ListItem>MOTHER</asp:ListItem>
                                <asp:ListItem>HUSBAND</asp:ListItem>
                                <asp:ListItem>WIFE</asp:ListItem>
                                <asp:ListItem>DAUGHTER</asp:ListItem>
                                <asp:ListItem>SON</asp:ListItem>
                                <asp:ListItem>UNCLE</asp:ListItem>
                            </asp:DropDownList>
                            <div class="row">
                            </div>
                            <%--<span class="text text-bold text-primary"><h3>Payment App Detail</h3></span>
        <div id="Nominee0"  style="border:2px solid black"></div>
             <div class="row">
                 <div class="col-lg-6">
                     <label>Paytm ID</label>
                     <asp:TextBox ID="paytm" CssClass="form-control" runat="server"></asp:TextBox>
                 </div>
                  <div class="col-lg-6">
                       <label>Google Tez App</label>
                     <asp:TextBox ID="tez" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>
             </div>--%>
                            <%--  <div class="row>">
             <div class="col-lg-3">
              <div class="form-group">
                 
                <label>Profile Image</label>
                  <asp:FileUpload ID="FileUpload1" CssClass="form-control filename" runat="server" /><br />
                     <asp:Button ID="bntuploadProfile" runat="server" Text="Upload" CssClass="btn btn-block btn-success"/>
                <h4>  <asp:Label ID="lbprofile" CssClass=" label-info form-control" Text=""  runat="server"></asp:Label></h4>
              </div></div>
             <div class="col-lg-3">
              <div class="form-group">
                 
                <label>Signature Image</label>
                  <asp:FileUpload ID="FileUpload2" CssClass="form-control filename" runat="server" /><br />
                     <asp:Button ID="bntuploadSing" runat="server" Text="Upload" CssClass="btn btn-block btn-success"   OnClick="bntuploadSing_Click" />
                  <h4>  <asp:Label ID="lbsign" CssClass=" label-info form-control" Text=""  runat="server"></asp:Label></h4>
              </div></div>
             <div class="col-lg-3">
              <div class="form-group">
                 
                <label>PanCard Upload </label>
             <asp:FileUpload ID="FileUpload3" CssClass="form-control filename" runat="server" /><br />
                     <asp:Button ID="bntuploadthumb" runat="server" Text="Upload" CssClass="btn btn-block  btn-success"  OnClick="bntuploadthumb_Click" />
                    <h4>  <asp:Label ID="lbthumb" CssClass=" label-info form-control" Text=""  runat="server"></asp:Label></h4>
              </div></div>
             
           
              </div>--%>

                            <div class="clearfix"></div>
                        </div>
                    </div>
                    <%--  <div class="row>">
             <div class="col-lg-3">
              <div class="form-group">
                 
                <label>Profile Image</label>
                  <asp:FileUpload ID="FileUpload1" CssClass="form-control filename" runat="server" /><br />
                     <asp:Button ID="bntuploadProfile" runat="server" Text="Upload" CssClass="btn btn-block btn-success"/>
                <h4>  <asp:Label ID="lbprofile" CssClass=" label-info form-control" Text=""  runat="server"></asp:Label></h4>
              </div></div>
             <div class="col-lg-3">
              <div class="form-group">
                 
                <label>Signature Image</label>
                  <asp:FileUpload ID="FileUpload2" CssClass="form-control filename" runat="server" /><br />
                     <asp:Button ID="bntuploadSing" runat="server" Text="Upload" CssClass="btn btn-block btn-success"   OnClick="bntuploadSing_Click" />
                  <h4>  <asp:Label ID="lbsign" CssClass=" label-info form-control" Text=""  runat="server"></asp:Label></h4>
              </div></div>
             <div class="col-lg-3">
              <div class="form-group">
                 
                <label>PanCard Upload </label>
             <asp:FileUpload ID="FileUpload3" CssClass="form-control filename" runat="server" /><br />
                     <asp:Button ID="bntuploadthumb" runat="server" Text="Upload" CssClass="btn btn-block  btn-success"  OnClick="bntuploadthumb_Click" />
                    <h4>  <asp:Label ID="lbthumb" CssClass=" label-info form-control" Text=""  runat="server"></asp:Label></h4>
              </div></div>
             
           
              </div>--%>

                    <div class="clearfix"></div>
                    <div class="row" style="margin-top: 20px; margin-bottom: 50px;">
                        <div class="col-lg-4">

                            <asp:GridView ID="GridView1" runat="server" Width="434px" Visible="false"></asp:GridView>
                        </div>
                        <div class="col-lg-4">
                            <asp:Button ID="bntpersonal" runat="server" Text="Update Record" CssClass="btn btn-block btn-danger" OnClick="bntpersonal_Click" />
                        </div>
                    </div>

                </div>
            </div>
        </div>



        <!-- /.row -->
        <!----wait images--->


        <div id="graybackground-div">
        </div>
        <div id="message-div">
            <div>Processing data, please wait...</div>
        </div>
    </div>
    <%-- <!-- REQUIRED JS SCRIPTS -->
      <script src="../bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- DataTables -->
<script src="../../bower_components/datatables.net/js/jquery.dataTables.min.js"></script>
<script src="../../bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"></script>
<!-- SlimScroll -->
<script src="../../bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
<!-- FastClick -->
<script src="../../bower_components/fastclick/lib/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="../../dist/js/demo.js"></script>
     <div class="row">
        <!-- left column -->
        <div class="col-md-12">
          <!-- general form elements -->
          <div class="box box-primary">
            <div class="box-header with-border">
              <h1 class="box-title"> Your Profile Here....</h1>
            </div>
              
         
         
            <!-- /.box-header -->

              <div class="box-body">
                   <div class="row" style="margin-bottom:20px;">
                    <div class="col-md-6"> <div class="form-group   has-error" >
                  
                   <asp:TextBox ID="txtusersearch" runat="server"  class="form-control" placeholder="Enter UserName for Search" ></asp:TextBox>              
                  
                </div> </div>
                   <div class="col-md-3">               
                   
                  <asp:Button ID="btnsearch" runat="server" Font-Size="Large" Text="Search" CssClass=" btn btn-block btn-danger"  OnClick="btnsearch_Click"/>              
                
                
                </div></div>
                  <div class="clearfix"></div>
                   
                   
                  <div class="row">
                    <div class="col-md-6"> <div class="form-group has-success" >
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i> UserName</label>
                   <asp:TextBox ID="txtuname" runat="server"  class="form-control"   ReadOnly="true" ></asp:TextBox>              
                  
                </div> </div>
                   <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Password</label>
                   <asp:TextBox ID="txtpass" runat="server"  class="form-control" ReadOnly="true" ></asp:TextBox>              
                
                </div>
                </div></div>

            <div class="row">
                                         <div class="col-md-6"> 
                                             <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Father Name</label>
                   <asp:TextBox ID="txtfname" runat="server"  class="form-control" ></asp:TextBox>              
                  
                </div>            
</div>
                   <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i> Name</label>
                   <asp:TextBox ID="txtname" runat="server"  class="form-control"  ></asp:TextBox>              

                </div>
                </div></div>
                  <div class="row">
                                         <div class="col-md-6"> 
                                             <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Status</label>
                     <asp:TextBox ID="txtstatus" class="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                                                       
</div>
                   <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Referral Name</label>
                     <asp:TextBox ID="txtreff" class="form-control" runat="server" ReadOnly="true" ></asp:TextBox>
                </div>
                </div></div>
                   <div class="row">
                                       
                         <div class="col-md-6"> 
                                             <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>State</label>
                   <asp:DropDownList ID="drpState" runat="server" class="form-control text-success" AutoPostBack="true" OnTextChanged="drpState_TextChanged">
                     <asp:ListItem></asp:ListItem>
                </asp:DropDownList>                </div>        
</div>
                        
                
                        <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>City</label>
                     <asp:DropDownList ID="drpCity" runat="server" class="form-control text-success">
                     <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                </div>
                </div>
                       
                   </div>
                  <div class="row">
                                         <div class="col-md-6">
                                             <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Address</label>
                     <asp:TextBox ID="txtaddress" class="form-control" runat="server"   ></asp:TextBox>
                </div>            
</div>
                   <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Pincode</label>
                     <asp:TextBox ID="txtpin" class="form-control" runat="server"   ></asp:TextBox>
                </div>
                </div></div>
             
                  <div class="row">
                                         <div class="col-md-6">
                                             <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Mobile No</label>
                     <asp:TextBox ID="txtmob" class="form-control" runat="server"   ></asp:TextBox>
                </div>            
</div>
                   <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Bank Name</label>
                     <asp:TextBox ID="txtBankName" class="form-control" runat="server"   ></asp:TextBox>
                </div>
                </div></div>
                  <div class="row">
                                         <div class="col-md-6">
                                             <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Account No</label>
                     <asp:TextBox ID="txtaccount" class="form-control" runat="server"   ></asp:TextBox>
                </div>            
</div>
                   <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Date of Joining</label>
                     <asp:TextBox ID="txtjoining" class="form-control" runat="server" ReadOnly="true" ></asp:TextBox>
                </div>
                </div></div>
                    <div class="row">
                                         <div class="col-md-6">
                                             <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Pan No</label>
                     <asp:TextBox ID="txtPan" class="form-control" runat="server"   ></asp:TextBox>
                </div>            
</div>
                   <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>IFSC</label>
                     <asp:TextBox ID="txtIFSC" class="form-control" runat="server"   ></asp:TextBox>
                </div>
                </div></div>
                    <div class="row">
                                         <div class="col-md-6">
                                             <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Nominee Name</label>
                     <asp:TextBox ID="txtnominee" class="form-control" runat="server"   ></asp:TextBox>
                </div>            
</div>
                   <div class="col-md-6">               
                    <div class="form-group has-success">
                  <label class="control-label" for="inputSuccess"><i class="fa fa-check"></i>Reletion</label>
                     <asp:TextBox ID="txtreletion" class="form-control" runat="server"   ></asp:TextBox>
                </div>
                </div></div>

                      
                   <div class="row" style="margin-top:20px;">
                                         <div class="col-lg-offset-4 col-lg-4">
                                            
                    <asp:Button ID="update" runat="server" Font-Size="Large" Text="Update" CssClass="btn btn-block btn-success"  OnClick="update_Click1"/>
                                                 
                
</div>
                   </div>
           
          </div>
          <!-- /.box --> </div>
             </div></div>--%>
</asp:Content>

