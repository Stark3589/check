<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="DailyReport2.aspx.cs" Inherits="User_DailyReport2" %>

 

 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <%--  <script type = "text/javascript">
         function DisableButton() {
             document.getElementById("<%=Button1.ClientID %>").disabled = true;
         }
         window.onbeforeunload = DisableButton;
</script>--%>

    <section style="margin-top: 20px;  background-color: white">
         <div class="row">
        <div class="col-md-12">
            
             <div class="col-md-9">
                <div class="form=-group row last">
                    <label class="col-md-3">ENTER USERNAME</label>
                     <div class="col-md-6">
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <div class="col-md-3">
                    <asp:Button ID="Button3" CssClass="form-control btn btn-success" runat="server" Text="Search" OnClick="Button3_Click" />
                </div>
                </div>
            </div>
        </div>
    </div>
         <div class="row">
        <div class="col-md-12">
            
             <div class="col-md-9">
                <div class="form=-group row last">
                    <label class="col-md-3">NAME</label>
                     <div class="col-md-9">
                        <asp:TextBox ID="TextBox2" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                    </div>
                     
                </div>
            </div>
        </div>
    </div>
        <div class="row">
        <div class="col-md-12">
            <div class="col-md-3">
            
            </div>
             <div class="col-md-12">
                <div class="form=-group row last">
                    <label class="col-md-12"></label>
                     <div class="col-md-12">
                    <asp:Button ID="Button1" CssClass="form-control btn btn-success" runat="server" Text="Add Username In Royalty" OnClick="Button1_Click" />
                </div>
                    </div></div></div></div>

        <div class="row">
        <div class="col-md-12">
            
             <div class="col-md-12">
                <div class="form=-group row last">
                    <label class="col-md-12"></label>
                     <div class="col-md-12" >


                         <div style="margin-left:5%; ">

                         <asp:GridView ID="gvDetails"  DataKeyNames="id" AutoGenerateColumns="false" CellPadding="5"  runat="server"  Width="90%">
<Columns>
<asp:TemplateField>
<ItemTemplate>
  

<asp:CheckBox ID="chkSelect" runat="server" />
</ItemTemplate>
</asp:TemplateField>  
     <asp:BoundField HeaderText="Id" DataField="id"  />
    <asp:BoundField DataField="username" HeaderText="USERNAME" />
     <asp:BoundField DataField="name" HeaderText="NAME" />
     
    

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
<HeaderStyle BackColor="#df5015" Font-Bold="true" ForeColor="White" />
</asp:GridView></div>
                <br />
                <asp:Button ID="btnProcess" Text="Delete ID" CssClass="form-control btn btn-danger" runat="server"
Font-Bold="true" onclick="btnProcess_Click" />
                        
                         </div>
                    </div></div></div></div>

        
        
    </section>


</asp:Content>



