<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="showlevel.aspx.cs" Inherits="User_showlevel" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row" style="overflow: auto;">
       
        <div class="col-md-12">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1"  OnPageIndexChanging="GridView1_PageIndexChanging" Width="100%"
                EmptyDataText="YOU HAVE NO BOOSTER MEMBER " >
                <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                  
                    <asp:BoundField DataField="username" HeaderText="User ID" SortExpression="name" />
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                    <asp:BoundField DataField="lvl" HeaderText="Boost ID" SortExpression="direct" />
                    <asp:BoundField DataField="amount" HeaderText="Self Boost" SortExpression="mob" />
                   
                  
                </Columns>
                <RowStyle  />
            </asp:GridView>
        </div>
    </div>
</asp:Content>



