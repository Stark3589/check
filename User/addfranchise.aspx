<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="addfranchise.aspx.cs" Inherits="User_franchise_addfranchise" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <script>
         function NumberOnly() {
             var AsciiValue = event.keyCode
             if ((AsciiValue >= 48 && AsciiValue <= 57) || (AsciiValue == 8 || AsciiValue == 127))
                 event.returnValue = true;
             else
                 event.returnValue = false;


         }
    </script>
    <div class="row">
    <div class="col-md-12">
      <CENTER> <h3>FRANCHISE REGISTERATION</h3></CENTER> 

        <br />
        <div class="row">
            <div class="col-md-12">
                <div class="form-group row last">
                  
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3">Franchise</label>
                            <div class="col-md-9">
                                <asp:DropDownList ID="drpfran" runat="server" CssClass="form-control">
                                    <asp:ListItem>SELECT FRANCHISE</asp:ListItem>
                                     <asp:ListItem>PAY OUT</asp:ListItem>
                                     <asp:ListItem>TOUR</asp:ListItem>
                                     <asp:ListItem>HOUSE FOUND</asp:ListItem>
                                   
                                   <%-- <asp:ListItem>20</asp:ListItem>--%>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group row last">
                            <label class="col-md-3">Name</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="txtname" required="" runat="server" CssClass="form-control"></asp:TextBox>
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
                                <asp:TextBox ID="txtpass" ReadOnly="true" runat="server" CssClass="form-control"></asp:TextBox>
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
                                <asp:TextBox ID="txtmob"  required="" MaxLength="10" onkeypress="return NumberOnly()"   runat="server" CssClass="form-control"></asp:TextBox>
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
                                <asp:TextBox ID="txtbranch" required="" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group row last">
                        <label class="col-md-3">Date</label>
                            <div class="col-md-9">
                                <asp:TextBox ID="date" type="date" runat="server" CssClass="form-control"></asp:TextBox>
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
                               <asp:Button ID="btn" runat="server" Text="SUBMIT" OnClick="btn_Click" CssClass="form-control btn btn-success" />
                            </div>
                        </div>
                    </div>
                   
                </div>
            </div>
        </div>
    </div>
        </div>
</asp:Content>

