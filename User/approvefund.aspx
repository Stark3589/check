<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="approvefund.aspx.cs" Inherits="User_approvefund" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
 
   
    <section style="margin-top: 20px;  background-color: white">
       
           
        
         
      
        <div class="row">
        <div class="col-md-12">
            
             <div class="col-md-12">
                <div class="form=-group row last">
                    <label class="col-md-12"></label>
                     <div class="col-md-12" >


                         <div >
                         <asp:GridView ID="gvDetails"  DataKeyNames="id" class="table table-bordered table-striped dataTable1" AutoGenerateColumns="false" CellPadding="5"  runat="server" Visible="False" >
<Columns>
<asp:TemplateField>
<ItemTemplate>
  

<asp:CheckBox ID="chkSelect" runat="server" />
</ItemTemplate>
</asp:TemplateField>  
     <asp:BoundField HeaderText="Id" DataField="id"  />
    <asp:BoundField DataField="username" HeaderText="USERNAME" />
     <asp:BoundField DataField="name" HeaderText="NAME" />
     <asp:BoundField DataField="amount" HeaderText="AMOUNT" />
     <asp:BoundField DataField="trans_id" HeaderText="HASH ID" />
     <asp:BoundField DataField="date" HeaderText="DATE" DataFormatString="{0:d}" />
       <asp:TemplateField HeaderText="Screen Shot">   
                      
                   <ItemTemplate>   
                     <a href='<%#Eval("slip")%>' target="_blank">  <asp:Image ID="Image1" runat="server" Width="150" Height="100" ImageUrl='<%#Eval("slip")%>'/> </a>  
                      
                   </ItemTemplate>   
               </asp:TemplateField>  

    </Columns>

<%--<Columns>
<asp:TemplateField>
<ItemTemplate>
<asp:CheckBox ID="chkSelect" runat="server" />
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField HeaderText="Id" DataField="id" />
<asp:BoundField HeaderText="UserName" DataField="username" />
<asp:BoundField HeaderText="Name" DataField="name" />
   
<asp:BoundField HeaderText="Product" DataField="product" />
    <asp:BoundField HeaderText="Shipping Address" DataField="address" />
<asp:BoundField HeaderText="Quantity" DataField="qty" />


<asp:BoundField HeaderText="Status" DataField="status" />
   
</Columns>--%>
<HeaderStyle  />
</asp:GridView></div>
                <br />
                <asp:Button ID="btnProcess" Text="Approve" Width="80px" CssClass="form-control btn btn-success" runat="server" Visible="false"
Font-Bold="true" onclick="btnProcess_Click" />
                         <asp:Button ID="Button2" Text="Reject" Width="80px" CssClass="form-control btn btn-danger" runat="server" Visible="false"
Font-Bold="true" onclick="Button2_Click" /> <br />
                         </div>
                    </div></div></div></div>

        
        
    </section>
</asp:Content>

