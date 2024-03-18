<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="withdrawrequest.aspx.cs" Inherits="User_withdrawrequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <div >
    <div class="row" >

          <div class="col-lg-12">
       
       
            <center>
            <h4>
            <asp:Label ID="lblsts" runat="server" Text="Withdrawal Request"></asp:Label>
            </h4></center>
        
      </div>
    </div>
  <hr style="margin-left:0px; " />
  
    <div class="row" >
       
       
        <hr />
        <div class="col-12" style="overflow: auto;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1" OnRowCommand="GridView1_RowCommand" OnPageIndexChanging="GridView1_PageIndexChanging"  OnRowDataBound="GridView1_RowDataBound" Width="100%"
                EmptyDataText="YOU HAVE NO REQUEST OF WITHDRAWAL " AllowPaging="True">
                <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server"
                                Text='<%# Eval("dates", "{0:f}") %>'>&quot;&gt;</asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                    <asp:BoundField DataField="username" HeaderText="User ID" SortExpression="name" />
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                   
                    <asp:BoundField DataField="accno" HeaderText="Wallet Address" SortExpression="direct" />
                 
                    <asp:BoundField DataField="amount" HeaderText="Payable" SortExpression="mob" />
                     <asp:BoundField DataField="txnid" HeaderText="Txn. ID" SortExpression="mob" />
                   
                    
                     <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                           <%-- <asp:Button ID="Button3" runat="server" CommandName="api" CommandArgument='<%#Eval("id") %>' Text="API Pay" BackColor="#00cc66" ForeColor="White" BorderStyle="None" />--%>
                           <asp:Button ID="Button4" runat="server" CommandName="reject" CommandArgument='<%#Eval("id") %>' Text="Reject" BorderStyle="None" BackColor="#ff6640" ForeColor="White" />
                           <asp:Button ID="Button5" runat="server" CommandName="manual" CommandArgument='<%#Eval("id") %>' Text="Manual" BorderStyle="None" BackColor="#00cc66" ForeColor="White" />
                           

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <RowStyle  />
            </asp:GridView>
        </div>
    </div>
        </div>
</asp:Content>

