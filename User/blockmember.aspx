<%@ Page Title="" Language="C#"  AutoEventWireup="true" MasterPageFile="~/User/MasterPage.master" CodeFile="blockmember.aspx.cs" Inherits="User_blockmember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
   
<%--</head>

    <body id="page-top">
         <form id="form1" runat="server">
   --%>
    
   
      
           
            <!-- /.card-header -->
            <div style="overflow-x:scroll;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1"
                Width="100%"
                OnRowCommand="GridView1_RowCommand" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDataBound="GridView1_RowDataBound">
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
                    <%--  <asp:TemplateField HeaderText="Time">
                            <ItemTemplate>
                                
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("rtime") %>'>&quot;&gt;</asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                    <asp:BoundField DataField="name" HeaderText="User Name" />
                    <asp:BoundField DataField="username" HeaderText="User ID" />
                    <asp:BoundField DataField="reffid" HeaderText="Upline ID" />
                    <%--       <asp:BoundField DataField="sponser" HeaderText="Sponser ID" />--%>


                    <asp:BoundField DataField="status" HeaderText="Status" />
                    <asp:TemplateField HeaderText="Update Status">

                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                <asp:ListItem Value="0">Select Status</asp:ListItem>
                              
                                <asp:ListItem Value="B">Blocked</asp:ListItem>
                                <asp:ListItem Value="UB">Un-Blocked</asp:ListItem>
                              
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButtonN" runat="server" CommandArgument='<%#Eval("username") %>' CommandName="Cancel">Update</asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
                </div>
               
 <%--<script src="plugins/jquery/jquery.min.js"></script>--%>
   
<!-- Bootstrap 4 -->
   
    </asp:Content>