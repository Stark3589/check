<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="adminfund.aspx.cs" Inherits="User_adminfund" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <CENTER> <h3>FUND COLLECTION</h3></CENTER>
    <div class="row">
     <div class="col-md-12">
            
                <div class="col-md-8">
                    <div class="form group row last">
                    <label class="col-md-3">SELECT DATE</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txt" type="date" runat="server" Width="150px" Height="35px"></asp:TextBox>
                    </div>
                    <div class="col-md-5">
                              <asp:TextBox ID="txt2" type="date" runat="server" Width="150px" Height="35px"></asp:TextBox>
                    </div>
                        </div>
                    </div>
               <div class="col-md-4">
                    <div class="form group row last">
                <div class="col-md-6">
                    <asp:Button ID="Button1" runat="server" Text="Show" OnClick="Button1_Click" CssClass="form-control btn btn-success" />
                </div>

                        <div class="col-md-6">
                            <asp:Button ID="btn" runat="server" Text="Print" OnClick="btn_Click" CssClass="form-control btn btn-success" />
                        </div>
                         </div>
            </div>
        </div>
        </div>
   
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="true" BackColor="White" OnRowDataBound="GridView1_RowDataBound" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="90%">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                        <asp:BoundField DataField="username" HeaderText="USERID" />
                         <asp:BoundField DataField="name" HeaderText="USERNAME" />
                        <asp:BoundField DataField="dateofjoin" HeaderText="DATE" DataFormatString="{0:d}" />
                       
                       <asp:BoundField HeaderText="FUND AMT 2%" />
                     <asp:BoundField HeaderText="FUND AMT 3%" />
                          <asp:BoundField HeaderText="REMAINING" />
                         
                      
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

