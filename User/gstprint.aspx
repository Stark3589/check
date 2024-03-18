<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gstprint.aspx.cs" Inherits="User_gstprint" %>

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
       <div class="box-success box-primary">
                  <div class="row" style="margin-top:50px;">
                  <div class="col-lg-12" style="overflow:auto;">
                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="True" OnRowDataBound="GridView1_RowDataBound" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="90%">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                            <asp:BoundField DataField="username" HeaderText="Userid" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                         <asp:BoundField DataField="name" HeaderText="Name" ItemStyle-HorizontalAlign="Center"  >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                        <asp:BoundField DataField="address" HeaderText="Address" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                        <asp:BoundField DataField="invoice_no" HeaderText="Invoice No" ItemStyle-HorizontalAlign="Center"  >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                         <asp:BoundField DataField="dateofjoin" HeaderText="Date" DataFormatString="{0:d}" ItemStyle-HorizontalAlign="Center"  >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                         <asp:BoundField HeaderText="Amount" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                       <asp:BoundField HeaderText="CGST" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                     <asp:BoundField HeaderText="SGST" ItemStyle-HorizontalAlign="Center" >

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                        <asp:BoundField HeaderText="IGST" ItemStyle-HorizontalAlign="Center" > 

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                        </asp:BoundField>
                          <asp:BoundField HeaderText="GST" ItemStyle-HorizontalAlign="Center"  >
                         
                      

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                         
                      

                        </asp:BoundField>
                         
                      
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
              </div>        
                       
                    </div>
            </div>
          
    </form>
</body>
</html>
