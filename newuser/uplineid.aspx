<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" EnableViewStateMac="false"  enableEventValidation="false" AutoEventWireup="true" CodeFile="uplineid.aspx.cs" Inherits="newUser_uplineid" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        table {
    background-color: transparent;
     margin-left: initial; 
}
    </style>
    <div class="row">
       <div class="col-md-12">
    <center><strong><h4>Booster Report</h4></strong></center>
           </div></div>
    <hr />
    <div class="row">
       <div class="col-md-1">
        </div>
        <div class="col-md-10" style="overflow-x:scroll;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" class="table table-bordered table-striped dataTable1" Width="100%" OnRowDataBound="GridView1_RowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                       
                      

                        <asp:BoundField DataField="lvl" HeaderText="Total Booster ID" />
                           <asp:BoundField DataField="amount" HeaderText="Self Boosting" />
                       
                         <asp:BoundField HeaderText="Date" DataField="dates" DataFormatString="{0:d}" />
                        
                         
                        

                         <asp:BoundField HeaderText="Status" DataField="lvl" />

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
         <div class="col-md-1">
        </div>
        
    </div>
      
  
                
            <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
            <asp:Label ID="Label2" runat="server" Visible="false"></asp:Label>
        <asp:Label ID="Label3" runat="server" Visible="false"></asp:Label>
                <center>
                </center>
          
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: large;
            color: #FF3300;
        }
    </style>
</asp:Content>


