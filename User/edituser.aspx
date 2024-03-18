<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="edituser.aspx.cs" Inherits="Admin_edituser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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

        .lnkbtn {
            background: green;
            color: white;
            padding: 3px 14px;
            border: 2px solid black;
        }

        .gvclass tr td {
            padding: 8px 22px;
        }

        .gvclass tr th {
            padding: 0px 8px;
            text-align: center;
            background: #f16253;
            color: white;
            font-size: 16px;
        }
    </style>
  

    <div style="background-color: white">
       <center><h4>Update Profile</h4></center>
        <hr />
        <div class="row">
<div class="col-md-4">
            <center>  
           
                              <div class="input-group input-group-sm"  >
                    <asp:TextBox ID="txtsearchuname" CssClass="form-control" Width="200px" Height="38px" placeholder="Enter User Name" runat="server"></asp:TextBox>
                    <span class="input-group-append">
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click1" CssClass="btn btn-info btn-flat" />
                    </span>
                </div>
                



           
                </center></div>
            </div>
           
       <hr />
        <div class="row>">
          
        <span class="text text-bold text-primary">
            <h3>Personal Detail</h3>
        </span>
        <div id="personalid11" style="border: 2px solid black"></div>
        <div class="row">
            <div class="col-md-12">


                <div class="box-body">

                    <div class="row">
                        <div class="col-lg-3">
                            <div class="form-group">


                                <label>Name</label>
                                <asp:TextBox ID="txtuname" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                     

                 

                         <div class="col-lg-3" >
                            <div class="form-group">


                                <label>Email ID</label>
                                <asp:TextBox ID="TextBox1" CssClass="form-control"  runat="server"></asp:TextBox>
                            </div>
                        </div>
                         <div class="col-lg-3" style="display:none;">
                            <div class="form-group">


                                <label>Date Of Birth (dd-mm-yyyy)</label>
                               
                               <asp:TextBox ID="dob" CssClass="form-control"  Width="100%"  runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-lg-3" style="display:none;">>
                            <div class="form-group">


                                <label>Gender</label>
                                <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                    <asp:ListItem Selected="True" >Select Gender</asp:ListItem>
                                    <asp:ListItem>Male</asp:ListItem>
                                     <asp:ListItem>Female</asp:ListItem>

                                </asp:DropDownList>
                               
                            </div>
                        </div>
                        <div class="col-lg-3" style="display:none;">>
                            <div class="form-group">


                                <label>Address</label>
                                <asp:TextBox ID="TextBox2" CssClass="form-control"  runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-lg-3" style="display:none;">>
                            <div class="form-group">


                                <label>State</label>
                                <asp:DropDownList ID="DropDownList2" OnSelectedIndexChanged="Drpstate_SelectedIndexChanged" AutoPostBack="true" runat="server" CssClass="form-control">
                           
                        </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-lg-3" style="display:none;">>
                            <div class="form-group">


                                <label>City</label>
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control">
                           
                        </asp:DropDownList>
                            </div>
                        </div>
                         <div class="col-lg-3" style="display:none;">>
                            <div class="form-group">


                                <label>Aadhar Card</label>
                                <asp:TextBox ID="adhar" CssClass="form-control"  runat="server"></asp:TextBox>
                            </div>
                        </div>
                         <div class="col-lg-3" style="display:none;">>
                            <div class="form-group">


                                <label>Pan Card</label>
                                <asp:TextBox ID="pan" CssClass="form-control"  runat="server"></asp:TextBox>
                            </div>
                        </div>



                        <div class="col-lg-3" style="display:none;">>
                            <div class="form-group">


                                <label>Mobile</label>
                                <asp:TextBox ID="txtmobile" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-lg-3">
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
                        <div class="col-lg-3">
                            <div class="form-group">

                                <label>User ID</label>
                                <asp:TextBox ID="txtuid" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                            </div>
                        </div>



                        <div class="col-lg-3">
                            <div class="form-group">
                                <label>Sponser Id</label>
                                <asp:TextBox ID="txtsponser" CssClass="form-control" ReadOnly="true" runat="server" OnTextChanged="txtsponser_TextChanged" AutoPostBack="true"></asp:TextBox>
                                <label>
                                    <asp:Label ID="lbsponsername" runat="server" Visible="false"></asp:Label></label>
                                <asp:Label ID="lbsponser" runat="server" Visible="false"></asp:Label>
                            </div>
                        </div>
                    
                        <div class="col-lg-3" style="display:none;">
                            <div class="form-group">

                                <label>UpLine</label>
                                <asp:TextBox ID="txtupline" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                <asp:Label ID="lbupline" runat="server" Visible="false"></asp:Label>
                            </div>
                        </div>


                        <%--  <div class="col-lg-4">
              <div class="form-group">                 
                <label>Side</label>
                  <asp:TextBox ID="txtside" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                  <asp:Label ID="lbmsg" runat="server" Text=""></asp:Label>
              
              </div></div>--%>
                        <div class="col-lg-3">
                            <div class="form-group">

                                <label>Date of Joining</label>
                                <asp:TextBox ID="txtjoiningdate" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <!----Bank Detail---->
                    <span class="text text-bold text-primary">
                        <h3>Wallet  Detail(USDT(BEP20))</h3>
                    </span>
                    <div id="personalid" style="border: 2px solid black"></div>
                    <div class="row" style="display:none;">>

                        <div class="col-lg-4">
                            <div class="form-group">
                                <label>Bank Name</label>
                                <asp:TextBox ID="txtbank" CssClass="form-control" runat="server"></asp:TextBox>

                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="form-group">
                                <label>Branch Name</label>
                                <asp:TextBox ID="txtbranch" CssClass="form-control" runat="server"></asp:TextBox>

                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="form-group">

                                <label>Account Type</label>
                                <asp:DropDownList ID="drptype" runat="server" CssClass="form-control">
                                    <asp:ListItem>Select Type</asp:ListItem>
                                    <asp:ListItem>Saving</asp:ListItem>
                                    <asp:ListItem>Current</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="row" style="display:none;">>

                        <div class="col-lg-4">
                            <div class="form-group">

                              
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="form-group">

                                <label>Account Holder Name</label>
                                <asp:TextBox ID="txtaccountholder" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="form-group">
                                <label>IFSC Code</label>
                                <asp:TextBox ID="txtifsc" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                     <div class="row" >

                        <div class="col-lg-4">
                            <div class="form-group">

                                <label>Wallet Address </label>
                                <asp:TextBox ID="txtaccount" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                         </div>
                   
                
                    <div class="row" style="display:none;">
                        <div class="col-lg-3">
                            <label>Nominee Name</label>
                            <asp:TextBox ID="txtnomname" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-3">
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
                        </div>
                        <div class="col-lg-3">
                            <label>Google Pay</label>
                            <asp:TextBox ID="paytm" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-3">
                            <label>Phonepay</label>
                            <asp:TextBox ID="tez" CssClass="form-control" runat="server"></asp:TextBox>
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
                        
                        <div class="col-lg-2">
                            <asp:Button ID="bntpersonal" runat="server" Text="Update Record" CssClass="btn btn-block btn-danger" OnClick="bntpersonal_Click" />
                        </div>
                        <div class="col-lg-4">

                            <asp:GridView ID="GridView1" runat="server" Width="434px" Visible="false"></asp:GridView>
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
   </div>
</asp:Content>

