<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="fundwallet.aspx.cs" Inherits="User_fundwallet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <div class="row">
        
        <div class="col-md-12" style="overflow: auto">
            
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1"
                Width="100%" OnRowDataBound="GridView2_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>

                    </asp:TemplateField>
                   
                   
                    <asp:BoundField DataField="username" HeaderText="Username" />


                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="mobile" HeaderText="Mobile NO" />
                   
                    <asp:BoundField DataField="mobile" HeaderText="Total Wallet" />
                      <asp:BoundField DataField="mobile" HeaderText="E Wallet" />
                      <asp:BoundField DataField="mobile" HeaderText="Total Withdrawal" />



                </Columns>
            </asp:GridView>
        </div>
            </div>
   
</asp:Content>

