<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="CHECKPINAVAILAIBILITY.aspx.cs" Inherits="User_CHECKPINAVAILAIBILITY" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
    <div class="col-md-12" style="text-align:center">
        <h1>CHECK PIN AVAILABILITY</h1>
    </div>
        </div>
    <br />
    <div class="row">
<div class="col-md-12">
    <div class="col-md-3"></div>
    <div class="col-md-2">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl" runat="server"  Text="SELECT PIN"></asp:Label>
    </div>
    <div class="col-md-3">
    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" Height="30px" Width="224px">
    <asp:ListItem Selected="True">Select</asp:ListItem>
         <asp:ListItem Value="500">500</asp:ListItem>
   
</asp:DropDownList>
        </div>
    <div class="col-md-3">
<asp:Button ID="Button2" runat="server" Height="30px" CssClass="form-control btn btn-info" OnClick="Button2_Click" Text="Search" Width="90px" />
    </div>
    <div class="col-md-1"></div>
    </div>
        </div>
        <br />
    <br />
    <br />
    <br />
   <div style="text-align:center;margin-left:100px">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" OnRowDataBound="GridView1_RowDataBound" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="80%">
                    <Columns>
                       <asp:BoundField DataField="holder" HeaderText="Holder" />
                        <asp:BoundField DataField="total" HeaderText="Total" />
                        <asp:BoundField HeaderText="Available" />
                        <asp:BoundField headertext="used" />
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
        </div>
      
</asp:Content>

