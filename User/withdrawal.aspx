<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="withdrawal.aspx.cs" Inherits="Admin_withdrawal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <center><h4>Withdrawal Report</h4></center>
    <hr />
       
          <center>
          <div class="ScrollStyle" >
           <asp:GridView ID="gvDetails"  DataKeyNames="id" AutoGenerateColumns="false" CellPadding="5"   class="table table-bordered table-striped dataTable1" runat="server" Visible="False" Width="100%">
<Columns>
   <asp:TemplateField HeaderText="Sr. No">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
   
    <asp:BoundField DataField="username" HeaderText="USERNAME" />
     <asp:BoundField DataField="name" HeaderText="NAME" />
     <asp:BoundField DataField="amount" HeaderText="AMOUNT" />
     <asp:BoundField DataField="dates" HeaderText="DATE" DataFormatString="{0:f}" />
     <asp:BoundField DataField="admin" HeaderText="ADMIN" />
      <asp:BoundField DataField="remarks" HeaderText="MODE" />
     <asp:BoundField DataField="accno" HeaderText="ACCOUNT NO" />
     <asp:BoundField DataField="ifsc" HeaderText="IFSC" />
     <asp:BoundField DataField="status" HeaderText="Status" />
     

    </Columns>


<HeaderStyle BackColor="#df5015" Font-Bold="true" ForeColor="White" />
</asp:GridView>
                <br />
               
          </div>


     

</asp:Content>

