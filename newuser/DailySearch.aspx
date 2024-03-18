<%@ Page Language="C#"   MasterPageFile="~/newuser/masterfrn.master"  AutoEventWireup   ="true" CodeFile="DailySearch.aspx.cs" Inherits="newuser_DailySearch" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><h4>Fund Report</h4></center>
    <hr />

     <div>
   

         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1"
                    Width="100%" 
                    >
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
               
            </asp:TemplateField>
                         <asp:BoundField HeaderText="Amount" DataField="amount" />
                         <asp:BoundField HeaderText="Transaction ID" DataField="trans_id" />

                         <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# Eval("date", "{0:dd/MM/yyyy}") %>'>&quot;&gt;</asp:Label>
                                
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Fund Status" DataField="status" />
                        
                        
                    </Columns>
                </asp:GridView>
         </div>
</asp:Content>
