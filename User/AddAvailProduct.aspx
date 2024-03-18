<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="AddAvailProduct.aspx.cs" Inherits="User_AddAvailProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <span class="text text-bold text-primary">
        <h3>Add Admin's Available Product</h3>
    </span>
     
    <div id="Addmissiondetail" style="border: 2px solid black"></div>
    <div class="container" style="background-color: white; width: 56%;">
       <br />
   <h3>STOCK</h3>
        <hr />
        <div class="form-group row last">
            <label class="col col-lg-3">Select Product</label>
            <div class="col-lg-9">
                <asp:DropDownList ID="drpproduct"  CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <label class=" col col-lg-3">Select Quantity</label>
            <div class="col-lg-9">
                <asp:DropDownList ID="drpqty"  CssClass="form-control" Font-Bold="true" runat="server"></asp:DropDownList>
            </div>
        </div>


        <div class="form-group row">
            <label class=" col col-lg-3"> Enter Unit</label>
            <div class="col-lg-9">
                <asp:TextBox ID="txtbox1"  CssClass="form-control" Font-Bold="true" runat="server"></asp:TextBox>
            </div>
        </div>
        
        


        <div class="form-group row">
            <div class="col-lg-3"></div>
            <div class="col-lg-9">
               <asp:Button ID="btnsubmit" runat="server" class="btn btn-outline-primary btn-block " BackColor="#000099" Font-Bold="true" ForeColor="White" UseSubmitBehavior="false" OnClientClick="this.disabled='true'; this.value='Submit In...'" Text="SUBMIT" OnClick="btnsubmit_Click" />
            </div>
        </div>
        <br />
    </div>
    

</asp:Content>


