<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="franchisesalerpt.aspx.cs" Inherits="User_franchisesalerpt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <CENTER> <h3>DISTRIBUTOR SALE REPORT</h3></CENTER>
    <br />
    <div class="row">
     <div class="col-md-12">
            
                <div class="col-md-6">
                    <div class="form group row last">
                    <label class="col-md-3">SELECT DATE</label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txt" type="date" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-5">
                              <asp:TextBox ID="txt2" type="date" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                        </div>
                    </div>
           <div class="col-md-4">
             <div class="form-group row last">
                
                     <label class="col-md-5">ENTER USERNAME</label>
                  <div class="col-md-7">
                      <asp:DropDownList ID="txtusernme" runat="server" CssClass="form-control"></asp:DropDownList>
                 </div>
             </div>
         </div>
               <div class="col-md-2">
                    <div class="form group row last">
                <div class="col-md-6">
                    <asp:Button ID="Button1" runat="server" Text="Show" OnClick="Button1_Click" CssClass="form-control btn btn-success" />
                </div>

                       
                         </div>
            </div>
        </div>
        </div>
   
    <br />
    <div style="margin-left:50px">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  CellPadding="4" Width="90%">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
   			           
                       <asp:BoundField DataField="fran_id" HeaderText="FRANCHISE ID" />
                        <asp:BoundField DataField="cust_id" HeaderText="USERID" />
                         <asp:BoundField DataField="p_code" HeaderText="PRODUCT CODE" />
                        <asp:BoundField DataField="quantity" HeaderText="PRODUCT QUANTITY" />
                       <%-- <asp:BoundField DataField="unit" HeaderText="PRODUCT UNIT" />--%>
                         <asp:BoundField DataField="total" HeaderText="TOTAL" />
                        <asp:BoundField DataField="dp" HeaderText="DP" />
                        <asp:BoundField DataField="bp" HeaderText="BP" />
                        <asp:BoundField DataField="rp" HeaderText="RP" />
                         <asp:BoundField DataField="status" HeaderText="STATUS" />
                       
                    
                         
                      
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
    </div>
               
              
</asp:Content>

