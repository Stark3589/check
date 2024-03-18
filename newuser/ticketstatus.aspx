<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="ticketstatus.aspx.cs" Inherits="newuser_ticketstatus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <style>
        hr
        {
    margin-top: 2px;
    margin-bottom: 2px;
    border: 0;
    border-top: 1px solid #fff;
        }
    </style>
    <div class="container">
 
 
       <asp:Repeater ID="Repeater1" runat="server">
           <ItemTemplate>
                <div class="row" style="margin-top:5px;" >
               <div class="col-md-1"></div>
    <div class="col-md-10" style="border-left: 8px solid blue; background-color:#d6f0f9;  padding-top:16px; padding-left:5px; padding-bottom:15px;">
        <asp:Label ID="Label2" runat="server" Text='<%#Bind("id")%>' Visible="false"></asp:Label>
        <div class="col-md-112"> 
            
            <div class="col-md-12">
                 <asp:Label ID="Label7" Font-Bold="true" runat="server" Text='<%#Bind("sub")%>'></asp:Label><hr />
             <asp:Label ID="Label1" runat="server" Text='<%#Bind("msg")%>'></asp:Label><br />
              
            <b>Status :</b> <asp:Label ID="Label5" runat="server" Text='<%#Bind("status")%>'></asp:Label>  &nbsp;&nbsp;&nbsp; <b>Date :</b> <asp:Label ID="Label6" runat="server" Text='<%#Bind("dates", "{0:dd/MM/yyyy}")%>'></asp:Label>

                <hr />
            <span style="color:red;"> Comment By : <asp:Label ID="Label3" runat="server" Text='<%#Bind("sender")%>'></asp:Label><asp:Label ID="Label4" runat="server" Text='<%#Bind("receiver")%>'></asp:Label></span><br />
            </div>
            
            </div>
            
        
  
    </div>
                     
                    </div>
           
    </ItemTemplate>
       </asp:Repeater>
        <div class="row"  >
            <div class="col-md-1"></div>
            <div class="col-md-10" style="margin-top:20px; margin-bottom:20px; border:1px solid; padding:10px;">
                Comment on Ticket ID : <asp:Label ID="Label3" runat="server" ></asp:Label><hr />
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" TextMode="MultiLine" Height="200px"></asp:TextBox>
                <hr />
                <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="form-control btn-success" OnClick="Button1_Click" Width="100px" />
            </div>
            </div>
    
  </div>
</asp:Content>

