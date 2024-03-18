<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="requestfund.aspx.cs" Inherits="newuser_requestfund" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <h4><center>Request Fund</center></h4>
    <hr />
    <br />
    <script>
        function myFunction() {
            /* Get the text field */
            var copyText = document.getElementById("myInput");

            /* Select the text field */
            copyText.select();
            copyText.setSelectionRange(0, 99999); /* For mobile devices */

            /* Copy the text inside the text field */
            navigator.clipboard.writeText(copyText.value);

            /* Alert the copied text */
            //alert("Copied the text: " + copyText.value);
        }
</script>
     <script>
         function myFunction1() {
             /* Get the text field */
             var copyText = document.getElementById("myInput1");

             /* Select the text field */
             copyText.select();
             copyText.setSelectionRange(0, 99999); /* For mobile devices */

             /* Copy the text inside the text field */
             navigator.clipboard.writeText(copyText.value);

             /* Alert the copied text */
             //alert("Copied the text: " + copyText.value);
         }
</script>
    <div class="row">
        <div class="col-md-6">
              <div class="col-md-12">
                  <div class="input-group input-group-sm"  >
                      <asp:Label ID="myInput" runat="server" class="form-control" Visible="false"></asp:Label>
                  
                  
               
                </div>
                  </div>
            <div class="col-md-12">
                <div class="form=-group row last">
           
                     <div class="col-md-9">
                         <asp:Image ID="Image1" runat="server" class="form-control" Width="100%" Height="300" Visible="false" />
                    </div>
                    </div></div>

        </div>

                   <div class="col-md-6" style="display:none;">
              <div class="col-md-12">
                <div class="form=-group row last">
           <label class="col-md-12">COMPANY BANK NAME</label> 
                     <div class="col-md-9">
                         <asp:Label ID="Label1" runat="server" CssClass="form-control"></asp:Label>
                    </div>
                    </div></div>
            <div class="col-md-12">
                <div class="form=-group row last">
           <label class="col-md-12">BRANCH</label> 
                     <div class="col-md-9">
                         <asp:Label ID="Label2" runat="server" CssClass="form-control"></asp:Label>
                    </div>
                    </div></div>
            <div class="col-md-12">
                <div class="form=-group row last">
           <label class="col-md-12">IFSC </label> 
                     <div class="col-md-9">
                         <asp:Label ID="Label3" runat="server" CssClass="form-control"></asp:Label>
                    </div>
                    </div></div>
            <div class="col-md-12">
                <div class="form=-group row last">
           <label class="col-md-12">ACCOUNT NO</label> 
                     <div class="col-md-9">
                         <asp:Label ID="Label4" runat="server" CssClass="form-control"></asp:Label>
                    </div>
                    </div></div>
            <div class="col-md-12">
                <div class="form=-group row last">
           <label class="col-md-12">UPI ID</label> 
                     <div class="col-md-9">
                         <asp:Label ID="Label5" runat="server" CssClass="form-control"></asp:Label>
                    </div>
                    </div></div>
        </div>

    
        <div class="col-md-6">
            <div class="col-md-12">
                <div class="form=-group row last">
                    <label class="col-md-6">USERNAME</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="txtid" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
             <div class="col-md-12">
                <div class="form=-group row last">
                    <label class="col-md-6">DATE</label>
                     <div class="col-md-9">
                        <asp:TextBox ID="txtdate" type="date" runat="server" Height="33px"  CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
       
            <div class="col-md-12">
                <div class="form=-group row last">
                    <label class="col-md-6">SELECT AMOUNT</label>
                    <div class="col-md-9">
                         <asp:TextBox ID="reqfund" type="number" runat="server" min="5" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
             <div class="col-md-12">
                <div class="form=-group row last">
                    <label class="col-md-6">ENTER HASH ID</label>
                     <div class="col-md-9">
                        <asp:TextBox ID="txttranid" runat="server" CssClass="form-control" ></asp:TextBox>
                        
                    </div>
                </div>
            </div>
             <div class="col-md-12">
                <div class="form=-group row last">
                    <label class="col-md-6">UPOLOAD SCREEN SHOT</label>
                     <div class="col-md-9">
                         <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                      
                        
                    </div>
                </div>
            </div>
            <div class="col-md-12">
                <div class="form=-group row last">
                   
                     <div class="col-md-9" style="margin-top:20px;">
                  <asp:Button ID="btn" runat="server" Text="SUBMIT" Width="100px" OnClick="btn_Click" CssClass="form-control btn btn-dark" />
                    </div>
                </div>
            </div>
        </div>
    </div>
      <div class="row">
        <div class="col-md-12">
            <div class="col-md-3">
            
            </div>
             
        </div>
    </div>
    
</asp:Content>

