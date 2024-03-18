<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="fsalerpt.aspx.cs" Inherits="User_fsalerpt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

       <CENTER> <h3>FRANCHISE SALE REPORT</h3></CENTER>
    <br />
    <div class="row">
     <div class="col-md-12">
            
                <div class="col-md-5">
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

               <div class="col-md-3">
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
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" CellPadding="4" GridLines="Horizontal" Width="90%">
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
                        
                        <asp:BoundField DataField="date" HeaderText="DATE" DataFormatString="{0:d}" />
                         <asp:BoundField DataField="invoice_no" HeaderText="INVOICE NO" />
                       
                    
                         
                      
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
               
</asp:Content>

