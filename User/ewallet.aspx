<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="ewallet.aspx.cs" Inherits="User_ewallet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="row">
        <div class="col-md-12">
        <center><h4>E-Wallet Report</h4></center>
        <hr />
        <br />
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
                   
                    <asp:BoundField DataField="mobile" HeaderText="Fund Wallet" />



                </Columns>
            </asp:GridView>
        </div>
            </div>
    </div>
</asp:Content>

