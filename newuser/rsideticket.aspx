<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="rsideticket.aspx.cs" ValidateRequest="false" Inherits="newuser_rsideticket" %>
<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <script type="text/javascript">
        function validate() {
            var doc = document.getElementById('Richtextbox');
            if (doc.value.length == 0) {
                alert('Please Enter data in Richtextbox');
                return false;
            }
        }
        </script>
    <style>
        table
        {
            margin-left:0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="background-color: white; width: 90%;">
       <br />
        <center><h4>Raise Ticket</h4></center>
        <hr />
        <div class="row"><div class="col-md-12" style=" padding-left:30px; padding-right:30px;">
        <div class="col-md-6">
            <label class="col col-md-12">Ticket ID</label>
            <div class="col-md-12">
                <asp:TextBox ID="txtunameid" placeholder="Ticket ID" CssClass="form-control" ReadOnly="true"   runat="server"></asp:TextBox>
            </div></div>
            <div class="col-md-6">
            <label class="col col-md-12">User Name</label>
            
            <div class="col-md-12">
                <asp:TextBox ID="TextBox2" CssClass="form-control" ReadOnly="true"   runat="server"></asp:TextBox>
            </div></div>
           
       
        <div class="col-md-12">
            <label class=" col-md-12">Subject</label>
            <div class="col-md-12">
                <asp:TextBox ID="txtname" placeholder="Subject" CssClass="form-control" Font-Bold="true" runat="server" ></asp:TextBox>
            </div>
        </div>

         <div class="col-md-12">
            <label class="col-md-12">Message</label>
            <div class="col-md-12">
                <%--  <FTB:FreeTextBox ID="Richtextbox" Height="200px" Width="100%" DesignModeCss="form-control" runat="server" BackColor="#ebecef">  
                            </FTB:FreeTextBox>  --%>
                <asp:TextBox ID="msg" runat="server" TextMode="MultiLine" Height="200px" Width="100%" ></asp:TextBox>
                
                </div>
             </div>

        <div class="col-md-12">
            <label class=" col-md-12">Upload Screen Shot</label>
            <div class="col-md-12">
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control"  />
               
               
            </div>
        </div>
    
        
        <div class="col-md-12">
            
            <div class="col-md-12">
                <br />
              <asp:Button ID="Button1" runat="server"  CssClass="form-control btn btn-success" Width="100px" OnClick="Button1_Click1" Text="Raise Ticket" />
<br />
                <br /><br />
            </div>
        </div>
        <br />
            </div>

           <%-- <div class="col-md-5" style=" padding:10px; margin:10px;">
        <div class="form-group row">
            <label class="col col-md-12">Ticket Search</label>
            <div class="col-md-12">
                <asp:TextBox ID="TextBox2" placeholder="Ticket ID" CssClass="form-control"    runat="server"></asp:TextBox>
            </div>
           
        </div>
                 <div class="form-group row">
           
          <div class="col-md-12">
              <asp:Button ID="Button2" runat="server" Width="100px" CssClass="form-control btn btn-success" Text="Search" />
       
            </div>
                     <hr />
<div class="form-group row">
     <asp:Repeater ID="Repeater1" runat="server">
           <ItemTemplate>
                <div class="row" >
               <div class="col-md-1"></div>
    <div class="col-md-10" style="border-left: 8px solid blue; background-color:lightblue;  padding-top:16px; padding-left:5px; padding-bottom:15px;">
        <asp:Label ID="Label2" runat="server" Text='<%#Bind("id")%>' Visible="false"></asp:Label>
        <div class="col-md-9"> 
            <div class="col-md-12"><b>Ticket ID:    <asp:Label ID="Label3" runat="server" Text='<%#Bind("ticketid")%>'></asp:Label></b></div>
            <div class="col-md-12">
             <asp:Label ID="Label1" runat="server" Text='<%#Bind("sub")%>'></asp:Label></div>

        </div>
        <div class="col-md-3"> <asp:Button ID="Button1" Class="form-control btn-primary"   Width="80%" BorderStyle="None"  runat="server" OnClick="Button1_Click" Text="View"  /></div>
  
    </div>
                     
                    </div>
              <p></p>
    </ItemTemplate>
       </asp:Repeater>
    </div>
           
        </div>

        </div>--%>
    </div>
        </div>
</asp:Content>

