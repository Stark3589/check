<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="inactivemember.aspx.cs" Inherits="inactivemember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-3">
        </div>
        <div class="col-lg-6">
            <h2>
        <center>    <asp:Label ID="lblsts" runat="server" Text="Inactive Member"></asp:Label></center>
                </h2>
        </div>
        <div class="col-lg-3">
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
        <div class="col-lg-4">
            <div class="form-group row last">
                <label class="col-md-4">Enter Username</label>
                <div class="col-md-8">
                <asp:TextBox ID="txtuname" CssClass="form-control"  runat="server"></asp:TextBox>
            </div>
                </div>
        </div>
         <div class="col-lg-4">
                 <div class="form-group row last">
                <label class="col-md-4">Enter Name</label>
                <div class="col-md-8">
                <asp:TextBox ID="txtname" CssClass="form-control"  runat="server"></asp:TextBox>
            </div>
                     </div>
        </div>
        <div class="col-lg-4">
              <div class="form-group row last">
                <label class="col-md-4">Click Here..</label>
                <div class="col-md-8">
                <asp:Button ID="Button1" CssClass="form-control btn-success" OnClick="Button1_Click" runat="server" Text="Search" />
            </div>
                  </div>
        </div>
       
    </div>
        </div>
    <div class="row" style="overflow:auto;margin-left:1px;margin-right:10px">
        <div class="col-md-12">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                Width="100%" CellPadding="4"
                OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
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
                    <asp:BoundField DataField="name" HeaderText="User Name" />
                    <asp:BoundField DataField="username" HeaderText="User ID" />
                   
                    <asp:BoundField DataField="sponser" HeaderText="Sponser ID" />


                   
                    <asp:TemplateField HeaderText="Activate">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButtonN" runat="server" CommandArgument='<%#Eval("username") %>' CommandName="Cancel">View</asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
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
</asp:Content>

