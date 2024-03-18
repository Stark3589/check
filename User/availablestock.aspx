<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="availablestock.aspx.cs" Inherits="User_availablestock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .txtset {
            margin: 10px 10px;
            width: 100%;
        }

        .padd {
            padding-top: 10px;
            padding-bottom: 10px;
        }

        .btnset {
            background: green;
            color: white;
            font-size: 22px;
            border: navajowhite;
            width: 20%;
        }
    </style>
    <div >
          <center><h4>Daily Amount Management</h4></center>
                <hr />
        <div class="row">
           
              
                 <div class="col-2"> Date</div>
                <div class="col-3">
                    <asp:TextBox ID="TextBox3" runat="server" type="date" CssClass="form-control" Height="33px" required  OnTextChanged="TextBox3_TextChanged" AutoPostBack="true" ></asp:TextBox></div>

           
                
               
              
                
                <div class="col-2">Amount</div>
                <div class="col-3 ">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" ></asp:TextBox></div>
               

            
               
                
                  <div class="col-1">
             <asp:Button ID="Button1" runat="server" CssClass="form-control btn-success" OnClick="Button1_Click"
                    Text="Add" /></div>
            
            </div>
        
        <hr />
      
          

                 <div  style="overflow:auto;margin-left:0px;margin-right:0px">
        <div class="col-12">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1"
                Width="100%" CellPadding="4" OnRowCancelingEdit="GridView1_RowCancelingEdit"
                OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" >
                <Columns>
                    <asp:TemplateField HeaderText="Sr. No">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Schedule Date">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server"
                                Text='<%# Eval("dates", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>

                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server"
                                Text='<%# Eval("currdate", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>

                        </ItemTemplate>
                    </asp:TemplateField>
                   
                    <asp:BoundField DataField="amount" HeaderText="Amount" />
                 
                   
                    <asp:TemplateField HeaderText="Activate">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButtonN" runat="server" CommandArgument='<%#Eval("id") %>' CommandName="Cancel">Delete</asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle  />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
        </div>
                </div></div>

        </div>

  


</asp:Content>
