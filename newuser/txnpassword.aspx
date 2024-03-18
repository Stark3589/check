<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="txnpassword.aspx.cs" Inherits="newuser_txnpassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
                <center><h4 >Update Transaction Password</h4></center>
    <hr />
  <div class="row">
       
          
             <div class="col-4">
                <div class="form-group row last">
                <label class="col-md-4"> New Password</label>
          <div class="col-md-8">
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
        </div>
                    </div>
                </div>
            
             
            <div class="col-4">
                <div class="form-group row last">
                <label class="col-md-4">   Confirm</label>
           <div class="col-md-8">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Confirm Password Wrong." ControlToCompare="TextBox2" ControlToValidate="TextBox3"></asp:CompareValidator>
           </div>
                    </div>
                </div>
               <div class="col-2">
               
                <asp:Button ID="Button1" runat="server" CssClass="form-control btn btn-success"  
                    onclick="Button1_Click" Text="Update"  />
           
                </div>
            </div>
                  
            
            
           
                  <h2>  <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label></h2>
</asp:Content>

