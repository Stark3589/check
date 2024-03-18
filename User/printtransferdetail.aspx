<%@ Page Language="C#" AutoEventWireup="true" CodeFile="printtransferdetail.aspx.cs" Inherits="User_printtransferdetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>window.print()
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="90%">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                        <asp:BoundField DataField="username" HeaderText="USERID" />
                         <asp:BoundField DataField="name" HeaderText="USERNAME" />

                     
                          <asp:BoundField DataField="total" HeaderText="TOTAL" />
                         <asp:BoundField DataField="date" HeaderText="DATE" DataFormatString="{0:d}" />
                          <asp:BoundField DataField="valu" HeaderText="Transfer Detail" />
                      
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
    
               
    </div>
    </form>
</body>
</html>
