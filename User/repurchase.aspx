<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="repurchase.aspx.cs" Inherits="User_repurchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


             
     
            <center><h4>Account Detail  </h4></center>
        
    <hr />
    <div class="row">
        
             <div class="col-md-3" style="display:none;">
                <div class="form-group row last">
                    <label class="col-md-12">Bank Name</label>
                    <div class="col-md-12">
                         <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div> 
            </div>
            <div class="col-md-3" style="display:none;">
                <div class="form-group row last">
                    <label class="col-md-12">Branch</label>
                    <div class="col-md-12">
                         <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div> 
            </div>
            <div class="col-md-3" style="display:none;">
                <div class="form-group row last">
                    <label class="col-md-12">IFSC</label>
                    <div class="col-md-12">
                         <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div> 
            </div>
            <div class="col-md-3" style="display:none;">
                <div class="form-group row last">
                    <label class="col-md-12">Account NO</label>
                    <div class="col-md-12">
                         <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div> 
            </div>
            <div class="col-md-3">
                <div class="form-group row last">
                    <label class="col-md-12">Wallet Address</label>
                    <div class="col-md-12">
                         <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div> 
            </div>
         <div class="col-md-3">
                <div class="form-group row last">
                    <label class="col-md-12">QR</label>
                    <div class="col-md-12">
                     
                     
                         <asp:FileUpload ID="FileUpload1"  CssClass="form-control" runat="server" />
                    </div>
                </div> 
            </div>
           
        <div class="col-md-3">
                <div class="form-group row last">
                    <label class="col-md-12"></label>
                    <div class="col-md-6" style="margin-top:20px;">
                         <asp:Button ID="Button2" runat="server" CssClass="form-control btn btn-success" Text="Submit" OnClick="Button2_Click" />
                    </div>
                </div> 
            </div>

    </div>
           
    
  
</asp:Content>

