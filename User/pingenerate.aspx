<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="pingenerate.aspx.cs" Inherits="User_pin" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row" style="margin-top:30px;">
                 <div class="col-lg-8">
        <div class="col-lg-12"><center><h3>Generate Pins</h3></center></div>
  
    <div class="row" style="margin-top:30px; margin-left:30px;">
        
        <div class="col-lg-3">Enter No Of Pins</div>
        <div class="col-lg-6">
            
            <asp:TextBox ID="TextBox1" runat="server" MaxLength="3" CssClass="form-control"></asp:TextBox></div>
        <div class="col-lg-3"></div>
    </div>
            <div class="row" style="margin-top:30px; margin-left:30px;">
        <div class="col-lg-3">Select</div>
        <div class="col-lg-6">
            
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                    <asp:ListItem Selected="True">Select</asp:ListItem>
                   <asp:ListItem Value="500">500</asp:ListItem>
                    
                    
                
            </asp:DropDownList>
            </div>
        <div class="col-lg-3"></div>
                </div>
    
            <div class="row" style="margin-top:30px; margin-left:30px;">
        <div class="col-lg-3"></div>
        <div class="col-lg-6">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Generate" CssClass="btn btn-block btn-info" /></div>
        <div class="col-lg-3"></div>
    </div>
            <div class="row" style="margin-top:30px; margin-left:30px;">
        <div class="col-lg-3"></div>
        <div class="col-lg-6">
            </div>
        <div class="col-lg-3"></div>
    </div>
         
            <div class="row" style="margin-top:30px; overflow:auto;">
        <div class="col-lg-12"><asp:GridView ID="GridView1" Visible="false" runat="server" AutoGenerateColumns="False" 
                     Width="100%" BackColor="White" 
                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:BoundField DataField="username" HeaderText="User Name" 
                            SortExpression="username" />
                        <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                        <asp:BoundField DataField="pin" HeaderText="Pin" SortExpression="pin" />
                        <asp:BoundField DataField="amount" HeaderText="Amount" 
                            SortExpression="amount" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView></div>
    </div>
</div>
            </ContentTemplate>
        <Triggers>

             <asp:PostBackTrigger ControlID="Button1" />
        </Triggers>
        </asp:UpdatePanel>
</asp:Content>

