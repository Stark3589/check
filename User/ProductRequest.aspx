<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="ProductRequest.aspx.cs" Inherits="User_ProductRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div class="row">
        <div class="col-md-12">
     <div class="row">
            <div class="col-lg-4">
            </div>
            <div class="col-lg-6">
                <h2>
                    <asp:Label ID="lblsts" runat="server" Text="PRODUCT REQUEST"></asp:Label>
                    </h2>
            </div>
            <div class="col-lg-2">
            </div>
        </div>
            <br />
             <asp:Label ID="lbidd" runat="server" visible="false"  ></asp:Label>
        <div class="row">
            <div class="col-lg-4">
                <div class="form-group row-last">

                   
                    <label class="col-md-4">Enter Dates</label>
          <div class="col-md-8">         <asp:TextBox ID="txtdate1" type="date" CssClass="form-control"  runat="server"></asp:TextBox></div> 
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group row-last">
                  <%--  <label class="col-md-4">Enter Name</label>--%>
         <div class="col-md-8">           <asp:TextBox ID="txtdate2" type="date" CssClass="form-control"  runat="server"></asp:TextBox></div>
                   
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group row-last">
<%-- <label class="col-md-4">Click Here..</label>--%>
               <div class="col-md-8">      <asp:Button ID="btnsearch" CssClass="form-control btn-success" OnClick="btnsearch_Click" runat="server" Text="Search" /></div>
                </div>
            </div>
        </div>
            <br />
                <div class="row">
            <div class="col-md-10" style="overflow:auto;margin-left:15px;margin-right:20px">
                <div class="form-group row-last">
            <center>   
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="100%" OnRowCommand="GridView2_RowCommand"
                    BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                            <ItemTemplate>
                                <%-- <asp:CheckBox ID="CheckBox1" runat="server" /> --%>
                                <%# Container.DataItemIndex + 1 %>
                            </ItemTemplate>

                        </asp:TemplateField >
                        <%-- <asp:BoundField DataField="id" HeaderText="id"   />--%>
                        <asp:TemplateField Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lbid" runat="server"  Text='<%#Eval("invoice_no") %>'  ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField DataField="fran_id" HeaderText="Franchise ID" />
                        <asp:BoundField DataField="name" HeaderText="Franchise Name" />
                          
                         <asp:BoundField DataField="date" HeaderText="Date" DataFormatString="{0:d}" />
                          <asp:TemplateField HeaderText="Action">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton2" Text="VIEW INVOICE" runat="server" CommandName="view" CommandArgument='<%#Eval("invoice_no") %>' />
            </ItemTemplate>
                              </asp:TemplateField>
                               <asp:TemplateField>
                             <ItemTemplate>
               <asp:LinkButton ID="btn" Text="EDIT" runat="server" CommandName="add" CommandArgument='<%#Eval("invoice_no") %>'></asp:LinkButton>
                             </ItemTemplate>
                                   </asp:TemplateField>
                        <asp:TemplateField>
                             <ItemTemplate>
               <asp:LinkButton ID="btn2" Text="APPROVE" runat="server" CommandName="select" CommandArgument='<%#Eval("invoice_no") %>'></asp:LinkButton>
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
                </center>
            </div>
             </div>
       </div>

            <br />
            <br />
         <div class="row">
            <div class="col-md-10" style="overflow:auto;margin-left:15px;margin-right:20px">
                <div class="form-group row-last">
            <center>   
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%"
                    BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr. No">
                            <ItemTemplate>
                                 <asp:CheckBox ID="CheckBox1" runat="server" /> 
                                <%# Container.DataItemIndex + 1 %>
                            </ItemTemplate>

                        </asp:TemplateField >
                        <%-- <asp:BoundField DataField="id" HeaderText="id"   />--%>
                        <asp:TemplateField Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lbid" runat="server"  Text='<%#Eval("id") %>'  ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField DataField="fran_id" HeaderText="Franchise ID" />
                        <asp:BoundField DataField="name" HeaderText="Franchise Name" />
                           <asp:BoundField DataField="P_code" HeaderText="Pro code"  />
                           <asp:BoundField DataField="P_name" HeaderText="name" />
                        <asp:BoundField DataField="qty" HeaderText="Quantity" />
                        <asp:BoundField DataField="total_amt" HeaderText="Amount" />
                         <asp:BoundField DataField="date" HeaderText="Date" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="status" HeaderText="Status" />
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
                </center>
            </div>
             </div>
       </div>



            <div class="row">
  <div class="form-group row-last">
       <div class="col-lg-3"></div>
       <div class="col-lg-3"> <asp:Button ID="btn_cancel" Visible="false" runat="server" Text="Request Cancel" OnClick="btn_cancel_Click" CssClass="form-control btn-success" />
       </div>
       <div class="col-lg-3">
      <asp:Button ID="btn_approve" runat="server" Visible="false" Text="Request Approve" OnClick="btn_approve_Click" CssClass="form-control btn-success" />
           </div>
       <div class="col-lg-3"></div>
  </div>
            </div>
            </div>
            <br />
            <br />
            </div>
        </div>
</asp:Content>

