<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="manageticket.aspx.cs" Inherits="newuser_incc_ledger" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>

    table
    {
        margin-left:0px;
    }
 td {
  text-align: left;
  padding: 8px;
}

tr:nth-child(even){background-color: #f2f2f2}


</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="background-color: white; width: 90%;">
       <br />
        <center><h4>Manage Ticket</h4></center>
        <hr />
        <div class="row">

            <div class="col-md-12" style=" padding:10px; margin:10px; border:1px solid;">
        <div class="form-group row">
            <label class="col col-md-2">Ticket ID</label>
            <div class="col-md-4">
                <asp:TextBox ID="TextBox2" placeholder="Ticket ID" CssClass="form-control"    runat="server"></asp:TextBox>
            </div>
           <div class="col-md-2">
                <asp:Button ID="Button1" runat="server" CssClass="form-control btn-primary"  Text="Search" />
            </div>
        </div>
                 <hr style="Width:95%;" />
                 <div class="form-group row" style="padding-left:5%;">
           
         
                    

     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered" OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowCommand"  Width="95%"
                EmptyDataText="YOU HAVE NO ANY COMPLAINT " AllowPaging="True">
                <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ticket Id">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Select" CommandArgument='<%# Container.DataItemIndex %>' Text='<%# Eval("ticketid") %>'><%# Eval("ticketid") %></asp:LinkButton>
                           
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                    <asp:BoundField DataField="sub" HeaderText="Subject" SortExpression="Subject" />
                    <asp:TemplateField HeaderText="Message">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("msg") %>'></asp:Label>
                            
                        </ItemTemplate>
                    </asp:TemplateField>
                  <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("dates", "{0:f}") %>'>&quot;&gt;</asp:Label>

                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:Button ID="Button3" runat="server" BorderStyle="None" Text='<%# Eval("status") %>' />
                           

                        </ItemTemplate>
                    </asp:TemplateField>
                   
                    
                </Columns>
                <RowStyle  />
            </asp:GridView>
   
    </div>
           
       

        </div>
    </div>
        </div>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/jquery.magnific-popup.min.js'></script><script  src="zoom/script.js"></script>

</asp:Content>



