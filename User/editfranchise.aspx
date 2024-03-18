<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="editfranchise.aspx.cs" Inherits="User_editfranchise" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="row">
    <div class="col-md-12">
      <CENTER> <h3>EDIT FRANCHISE</h3></CENTER> 

        <br />
         <div class="row">
            <div class="col-md-12">
                <div class="form-group row last">
                  
                    <div class="col-md-9">
                        <div class="form-group row last">
                            <label class="col-md-3">ENTER USERNAME</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control">
                                    
                                </asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="form-group row last">
                            <label class="col-md-3"></label>
                            <div class="col-md-9">
                                <asp:Button ID="btnn" runat="server" Text="SEARCH" OnClick="btn_Click1" CssClass="form-control btn btn-success"></asp:Button>
                            </div>
                        </div>
                    </div>
               </div>
                </div>
        </div>
        <asp:Panel ID="pnl1" runat="server" Visible="false">
        <div class="row">
            <div class="col-md-12">
                <div class="form-group row last">
                  
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3">Franchise</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="txtfran" runat="server" CssClass="form-control">
                                    
                                </asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3">Name</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="txtname" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
           <div class="row">
            <div class="col-md-12">
                <div class="form-group row last">
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3">Username</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="txtusername" ReadOnly="true" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3">Password</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="txtpass" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
           <div class="row">
            <div class="col-md-12">
                <div class="form-group row last">
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3">Mobile No</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="txtmob" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3">Aadhar No</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="txtadhr" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group row last">
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3">Branch</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="txtbranch" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    </div>
                </div>
            </div>
           <div class="row">
            <div class="col-md-12">
                <div class="form-group row last">
                      <div class="col-md-3"></div>
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3"></label>
                            <div class="col-md-9">
                               <asp:Button ID="btn" runat="server" Text="UPDATE" OnClick="btn_Click" CssClass="form-control btn btn-success" />
                            </div>
                        </div>
                    </div>
                   
                </div>
            </div>
        </div>
             </asp:Panel>

            
    </div>
       
        </div>
</asp:Content>

