<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/User/MasterPage.master" CodeFile="DailyReport1.aspx.cs" Inherits="newuser_DailyReport1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div>
      
                <center><h2>Downline List</h2></center>
          <div class="row">
        <div class="col-md-12" style="overflow:auto">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowDataBound="GridView2_RowDataBound" ShowFooter="true"
                Width="90%" CellPadding="4" ForeColor="#333333" GridLines="Both">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server"
                                Text='<%# Eval("dateofjoin", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Time">
                        <ItemTemplate>

                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("rtime") %>'>&quot;&gt;</asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="username" HeaderText="Downline" />


                    <asp:BoundField DataField="name" HeaderText="Downline Name" />
                     <asp:BoundField DataField="status" HeaderText="Status" />

                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
    </div>
              </div>
        </div>
</asp:Content>


