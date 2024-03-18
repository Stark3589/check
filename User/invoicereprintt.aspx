<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="invoicereprintt.aspx.cs" Inherits="User_invoicereprintt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <CENTER> <h3>REPRINT INVOICE</h3></CENTER>
    <div class="row">
        <div class="col-md-12">
            <div class="col-md-9">
                <div class="form-group row last"> 
            <label class="col-md-3">SELECT DATES</label>
            <div class="col-md-4">
                <asp:TextBox ID="date1" runat="server" type="date" CssClass="form-control"></asp:TextBox>
            </div>
             <div class="col-md-4">
                <asp:TextBox ID="date2" runat="server" type="date" CssClass="form-control"></asp:TextBox>
            </div>
                    </div>
                </div>
            <div class="col-md-3">
                <div class="form-group row last">
                    <asp:Button ID="btn" runat="server" Text="SUBMIT" OnClick="btn_Click" CssClass="form-control btn btn-success" />
                </div>
            </div>
        </div>
    </div>
    <asp:Label ID="lblinvoice" runat="server" Visible="false"></asp:Label>

     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" OnRowCommand="GridView1_RowCommand" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="90%">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                        <asp:BoundField DataField="username" HeaderText="USERID" />
                         <asp:BoundField DataField="name" HeaderText="USERNAME" />
                        <asp:BoundField DataField="dateofjoin" HeaderText="DATE" DataFormatString="{0:d}" />
                       
                       <asp:BoundField DataField="address" HeaderText="ADDRESS" />
                     <asp:BoundField DataField="mobile" HeaderText="MOBILE NO" />
                    
                         <asp:TemplateField>
                             <ItemTemplate>
                                 <asp:Button ID="reprintbtn" runat="server" BackColor="YellowGreen" ForeColor="white" CssClass="form-control" Text="REPRINT" CommandName="view" CommandArgument='<%#Eval("username") %>' />
                             </ItemTemplate>
                         </asp:TemplateField>
                      
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
    
</asp:Content>

