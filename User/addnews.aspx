<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="addnews.aspx.cs" Inherits="Admin_addnews"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        table tr td {
            font-size:22px;
        }
    </style>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div style="border:solid 1px; padding:20px; margin-top:10px; " >
                    Add News
                    <hr />
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="100%" Height="200px" placeholder="News"></asp:TextBox>
                    <asp:FileUpload ID="FileUpload1"  CssClass="form-control mt-3 mb-3" runat="server" />
                    <asp:Button ID="Button1" runat="server"  CssClass="btn btn-success pull-right" Text="Add News" OnClick="Button1_Click" /><br /><br /><br />
                </div>
            </div>
             <div class="col-md-5">
 <div style=" margin-top:10px; " >
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered" OnRowCommand="GridView1_RowCommand" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnPageIndexChanging="GridView1_PageIndexChanging" Width="100%"
                EmptyDataText="YOU HAVE NO NEWS " AllowPaging="True" Font-Size="Small">
                <Columns>
                   
                   
                     <asp:BoundField DataField="id" HeaderText="ID" SortExpression="name" />
                    <asp:BoundField DataField="news" HeaderText="News" SortExpression="name" />
                   <asp:TemplateField>
                      <ItemTemplate>
                          <asp:Image ID="Image1" runat="server" Width="150" Height="100" ImageUrl='<%#Eval("news2")%>'/>   
                      </ItemTemplate>
                   </asp:TemplateField>
                   
                    
                      <asp:TemplateField HeaderText="Activate">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButtonN" runat="server" CommandArgument='<%#Eval("id") %>' CommandName="api"><%#Eval("status") %></asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
                <RowStyle  />
            </asp:GridView>
     </div>
            </div>
        </div>
    </div>
  
</asp:Content>

