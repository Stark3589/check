<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="User_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td rowspan="8">
                <asp:Image ID="Image1" runat="server" Height="125px" Width="100px" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                User Status</td>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Size="Larger" ForeColor="#339933"></asp:Label>
            </td>
            <td>
                Payment Date</td>
            <td>
                <asp:Label ID="Label19" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                User ID</td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
            <td>
                Amount</td>
            <td>
                <asp:Label ID="Label20" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Name</td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
            <td>
                D.A.Form No.</td>
            <td>
                <asp:Label ID="Label21" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Email ID</td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
            <td>
                Distributor Card No.</td>
            <td>
                <asp:Label ID="Label22" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                </td>
            <td style="height: 20px">
                Mobile No.</td>
            <td style="height: 20px">
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                Remark</td>
            <td style="height: 20px">
                <asp:Label ID="Label23" runat="server" Text="Member Status Approved"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Gender</td>
            <td>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Print Welcome Letter" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Address</td>
            <td>
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                D.A.Form No.</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Parent ID</td>
            <td>
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                Distributor Card No.</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Parent Name</td>
            <td>
                <asp:Label ID="Label10" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" ForeColor="Red" OnClick="Button2_Click" Text="Change" />
&nbsp;
                <asp:Button ID="Button3" runat="server" ForeColor="Red" OnClick="Button3_Click" Text="Update " />
            </td>
        </tr>
        <tr>
            <td style="height: 20px">
            </td>
            <td style="height: 20px">
                Sponser Direct</td>
            <td style="height: 20px">
                <asp:Label ID="Label11" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                Sponser Email</td>
            <td style="height: 20px">
                <asp:Label ID="Label12" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                Account Holder Name</td>
            <td style="height: 20px">
                <asp:Label ID="Label13" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                Bank Name</td>
            <td style="height: 20px">
                <asp:Label ID="Label14" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                Branch Name</td>
            <td style="height: 20px">
                <asp:Label ID="Label15" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                IFSC</td>
            <td style="height: 20px">
                <asp:Label ID="Label16" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                Account Number</td>
            <td style="height: 20px">
                <asp:Label ID="Label17" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                Check Number</td>
            <td style="height: 20px">
                <asp:Label ID="Label18" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>

