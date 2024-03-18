<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="payoutfuldetail.aspx.cs" Inherits="User_payoutfuldetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   
    <div class="row">
  <CENTER> <h3> DETAIL</h3></CENTER>
    <div class="col-md-12" style="margin-left:50px">
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="82%">
                    <Columns> 
                        <asp:TemplateField>                                <HeaderTemplate >
                                    <asp:CheckBox ID="Chkall" runat="server" Text="ALL"  AutoPostBack="true" OnCheckedChanged="Chkall_CheckedChanged" />
                                      </HeaderTemplate>
<ItemTemplate>
<asp:CheckBox ID="chkSelect" runat="server" />
    
</ItemTemplate>
</asp:TemplateField>
                     
                       <asp:BoundField DataField="username" HeaderText="Username" />
                        <asp:BoundField DataField="name" HeaderText="Name" />
                           <asp:BoundField HeaderText="Total" DataField="Amount" />
                      <%--    <asp:BoundField HeaderText="TDS" />
                           <asp:BoundField HeaderText="Admin" />--%>
                        <%--<asp:BoundField DataField="ifsc" headertext="IFSC" />
                         <asp:BoundField DataField="accno" headertext="Accountno" />
                         <asp:BoundField DataField="bankname" headertext="BankName" />--%>
                        <asp:TemplateField>
                        <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("Rid") %>' CommandName="hello" >TRANSFER</asp:LinkButton>
                            </ItemTemplate>
                            </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            <br />
        
            <center> 
               <asp:Button ID="btnProcess" Text="TRANSFER AMOUNT" CssClass="form-control btn btn-info" runat="server" 
Font-Bold="true" OnClick="btnProcess_Click" Width="289px" /></center>
           
        <br />
        </div>  
         </div>
               
</asp:Content>

