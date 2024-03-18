<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="ticketstatus.aspx.cs" Inherits="newuser_ticketstatus" %>

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
        table
        {
            margin-left:0px;
        }
          @media (min-width: 1200px) {
            .container {
                width: 100%;
            }
        }
    </style>
    <div class="container">
 
 
      
        <div class="row" style="border:1px solid; border-color:lightgray;  margin:2%; padding:10px;"  >
            <div class="col-md-12">
                <div style=" padding:10px;">
            
               <asp:Repeater ID="Repeater1" runat="server">
           <ItemTemplate>
               <div class="col-md-12" style="border:1px solid;  border-color:lightgray; padding:10px; border-radius:5px;">
                   <div class="col-md-6"><i class="fa fa-user"></i> <asp:Label ID="Label9" runat="server" Text='<%#Bind("name")%>' ></asp:Label><br />
                      &nbsp;&nbsp;&nbsp; <asp:Label ID="Label4" runat="server" Text='<%#Bind("sender")%>' ForeColor="Red"></asp:Label><asp:Label ID="Label8" runat="server" ForeColor="Red" Text='<%#Bind("receiver")%>'></asp:Label>   
                   </div>
                   <div class="col-md-6" style="text-align-last:right;">
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("dates", "{0:f}") %>'>&quot;&gt;</asp:Label>
                   </div>
                 
                   <div class="col-md-12">
              <div style="height:20px;"></div>
      
       
            <asp:Label ID="Label7" Font-Bold="true" runat="server" Text='<%#Bind("sub")%>'></asp:Label><br />
              <asp:Label ID="Label1" runat="server" Text='<%#Bind("msg")%>'></asp:Label>
                  
            

               <div style="height:10px;"></div>
                   <asp:Image ID="Image1" runat="server" ImageUrl='<%#Bind("docfile")%>' /><br />  <div style="height:20px;"></div>
              <b>Date :</b> <asp:Label ID="Label6" runat="server" Text='<%#Bind("dates", "{0:f}")%>'></asp:Label> &nbsp;&nbsp; <b>Status :</b> <asp:Label ID="Label5" runat="server" Text='<%#Bind("status")%>'></asp:Label>
               </div>
            
            
        
  </div>
           <div class="col-md-12">
                <br />
                <hr />
            </div>    
 
           
    </ItemTemplate>
       </asp:Repeater>

                <hr style="background-color:black;" />
               &nbsp;<asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" runat="server">Reply</asp:LinkButton> <asp:Label ID="Label3" runat="server" Visible="false" ></asp:Label><hr />
                    <asp:Panel ID="Panel1" runat="server" Visible="false">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px" required></asp:TextBox>
                <hr />
                
                 <div class="col-md-2"><asp:DropDownList ID="DropDownList1" CssClass="form-control" Width="120px" runat="server">
                    <asp:ListItem Selected="True">STATUS</asp:ListItem>
                    <asp:ListItem>OPEN</asp:ListItem>
                    <asp:ListItem>CLOSE</asp:ListItem>
                </asp:DropDownList></div>
               
            <div class="col-md-2"> <asp:Button ID="Button1" runat="server" Text="Reply" CssClass="form-control btn-success" OnClick="Button1_Click" Width="100px" /></div>
                        
                        </asp:Panel>
                        </div></div>
          
       
             </div>
    </div>
    
 
</asp:Content>

