<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="rewards.aspx.cs" Inherits="User_rewards" %>

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
                         <div class="row">
        <div class="col-md-12">
            
            <div class="col-md-8">
                <div class="form-group row last">
                    <label class="col-md-6"></label>
           <div class="col-md-6">
                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" Visible="False">
                    </asp:DropDownList>
           </div>
                    </div>
                </div>
            </div>
                             </div>

               <div class="row">
        <div class="col-md-12">
            
            <div class="col-md-8">
                <div class="form-group row last">
                    <label class="col-md-6">Detail</label>
           <div class="col-md-6">
               
                    <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
              </div>
                    </div>
                </div>
            </div>
                   </div>
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
                <div class="row">
        <div class="col-md-12">
            
            <div class="col-md-8">
                <div class="form-group row last">
                    <label class="col-md-6"> Product Image</label>
                <div class="col-md-6"> <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" /></div>
                   
                </div>
                </div>
            </div>
                    </div>
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
           
                <div class="row">
        <div class="col-md-12">
            
            <div class="col-md-8">
                <div class="form-group row last">
                    <label class="col-md-6"></label>
             <div class="col-md-6">       <asp:Button ID="Button1" runat="server" BackColor="Maroon" BorderColor="Maroon" BorderStyle="Double" Font-Bold="True" ForeColor="White" CssClass="form-control" Text="Add" OnClick="Button1_Click" />
</div>
                    </div>
                </div>
            </div>
                    </div>
               <div class="col-md-12" style="overflow:auto">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" Width="100%" Font-Bold="False" Font-Names="Arial Unicode MS">
                        <Columns>
                            <asp:BoundField DataField="id" ItemStyle-HorizontalAlign="Center" HeaderText="id" SortExpression="id" InsertVisible="False" ReadOnly="True" >
                            </asp:BoundField>
                            <asp:BoundField DataField="detail" ItemStyle-HorizontalAlign="Center" HeaderText="detail" SortExpression="detail" >
                            
                            </asp:BoundField>
                            
                           <asp:TemplateField HeaderText="Reward" ItemStyle-HorizontalAlign="Center"><ItemTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("imgurl") %>' Width="120px" Height="120px" /></ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:reshamConnectionString %>" DeleteCommand="DELETE FROM [rewards] WHERE [id] = @id" InsertCommand="INSERT INTO [rewards] ([detail], [imgurl]) VALUES (@detail, @imgurl)" SelectCommand="SELECT * FROM [rewards]" UpdateCommand="UPDATE [rewards] SET [detail] = @detail, [imgurl] = @imgurl WHERE [id] = @id">
                        <DeleteParameters>
                            <asp:Parameter Name="id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="detail" Type="String" />
                            <asp:Parameter Name="imgurl" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="detail" Type="String" />
                            <asp:Parameter Name="imgurl" Type="String" />
                            <asp:Parameter Name="id" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
              </div>
</asp:Content>

