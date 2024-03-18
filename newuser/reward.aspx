<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="reward.aspx.cs" Inherits="newuser_reward" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-md-12">
        <center><h4>Reward Report</h4></center>
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
                   
                   
                   <asp:BoundField DataField="lvl" HeaderText="Level" />
                 
                   <asp:BoundField DataField="business" HeaderText="Req. Team" />
                    <asp:BoundField DataField="business" HeaderText="My Team" />
                    <asp:BoundField DataField="reward" HeaderText="Reward" />
                    <asp:BoundField DataField="tour" HeaderText="Tour" />
                    <asp:BoundField DataField="rwd_rank" HeaderText="Status" />
                    


                </Columns>
            </asp:GridView>
        </div>
            </div>
    </div>
</asp:Content>

