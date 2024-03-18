<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/User/MasterPage.master" CodeFile="product.aspx.cs" Inherits="Admin_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .GridViewEditRow input[type=text] {width:100px;} /* size textboxes */
.GridViewEditRow select {width:100px;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>Manage Products</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Visible="False">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Product Code</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Price</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>

              <tr>
                <td>Quantity</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Discount</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Detail </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
          <%--  <tr>
                <td>Detail 2</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Detail 3</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Detail 4</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>--%>
            <tr>
                <td>product Image </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
         <%--   <tr>
                <td>product Image 2</td>
                <td>
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                </td>
            </tr>
            <tr>
                <td>product Image 3</td>
                <td>
                    <asp:FileUpload ID="FileUpload3" runat="server" />
                </td>
            </tr>--%>
           
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="Maroon" BorderColor="Maroon" BorderStyle="Double" Font-Bold="True" ForeColor="White" Height="36px" Text="Add" Width="110px" OnClick="Button1_Click" />
&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" Width="100%" Font-Bold="False" Font-Names="Arial Unicode MS">
                        <Columns>
                            <asp:BoundField DataField="ProductName" ItemStyle-HorizontalAlign="Center" HeaderText="ProductName" SortExpression="ProductName" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="ProductCode" ItemStyle-HorizontalAlign="Center" HeaderText="ProductCode" SortExpression="ProductCode" >
                            
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            
                            <asp:BoundField DataField="Qty" ItemStyle-HorizontalAlign="Center" HeaderText="Qty" SortExpression="Qty" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                         <asp:BoundField DataField="MRP" ItemStyle-HorizontalAlign="Center" HeaderText="MRP" SortExpression="MRP" >
                         
                            
                              
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                               <asp:BoundField DataField="discount" ItemStyle-HorizontalAlign="Center" HeaderText="Discount" SortExpression="Discount" >
                         
                            
                              
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                         
                            
                              
                            <asp:BoundField DataField="detail" ItemStyle-HorizontalAlign="Center" HeaderText="detail" SortExpression="detail" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                               <asp:TemplateField HeaderText="Product Image" ItemStyle-HorizontalAlign="Center"><ItemTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("imgurl") %>' Width="100px" Height="100px" /></ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>
                            
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            
                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" Visible="false" SortExpression="id" />
                        </Columns>
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <EditRowStyle CssClass="GridViewEditRow" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <SortedAscendingCellStyle BackColor="#FEFCEB" />
                        <SortedAscendingHeaderStyle BackColor="#AF0101" />
                        <SortedDescendingCellStyle BackColor="#F6F0C0" />
                        <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:reshamConnectionString %>" DeleteCommand="DELETE FROM [product] WHERE [id] = @id" InsertCommand="INSERT INTO [product] ([ProductName], [ProductCode], [Qty], [MRP], [imgurl], [detail],[discount]) VALUES (@ProductName, @ProductCode, @Qty, @MRP, @imgurl, @detail,@discount)" SelectCommand="SELECT * FROM [product]" UpdateCommand="UPDATE [product] SET [ProductName] = @ProductName, [ProductCode] = @ProductCode, [Qty] = @Qty, [MRP] = @MRP, [imgurl] = @imgurl, [detail] = @detail,[discount]=@discount WHERE [id] = @id">
                        <DeleteParameters>
                            <asp:Parameter Name="id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="ProductName" Type="String" />
                            <asp:Parameter Name="ProductCode" Type="String" />
                            <asp:Parameter Name="Qty" Type="String" />
                            <asp:Parameter Name="MRP" Type="String" />
                            <asp:Parameter Name="imgurl" Type="String" />
                            <asp:Parameter Name="detail" Type="String" />
                              <asp:Parameter Name="discount" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="ProductName" Type="String" />
                            <asp:Parameter Name="ProductCode" Type="String" />
                            <asp:Parameter Name="Qty" Type="String" />
                            <asp:Parameter Name="MRP" Type="String" />
                            <asp:Parameter Name="imgurl" Type="String" />
                            <asp:Parameter Name="detail" Type="String" />
                            <asp:Parameter Name="id" Type="Int32" />
                             <asp:Parameter Name="discount" Type="String" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    
    </div>
   </asp:Content>