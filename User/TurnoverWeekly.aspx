<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="TurnoverWeekly.aspx.cs" Inherits="User_TurnOverWeekly" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td style="width: 594px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2"><center><h3>Weekly Turn Over</h3></center>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">Total Registration&nbsp; :
                <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
            </td>
            <td>Week&#39;s Registration&nbsp; :
                <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 594px"><center><h4>Week&#39;s Income</h4>
                </center>
                &nbsp;</td>
            <td><center><h4>Week&#39;s Expenses</h4></center>
&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">Registration Income&nbsp; :
                <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
            </td>
            <td>TDS Collected :
                <asp:Label ID="Label10" runat="server" Text="0"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 594px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">Distributer Charge :
                <asp:Label ID="Label5" runat="server" Text="0"></asp:Label>
            </td>
            <td>Admin Fee Collected :
                <asp:Label ID="Label11" runat="server" Text="0"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 594px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">Courier Charge :
                <asp:Label ID="Label6" runat="server" Text="0"></asp:Label>
            </td>
            <td>Paid To Distributor :
                <asp:Label ID="Label12" runat="server" Text="0"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 594px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">Service Tax Charge :
                <asp:Label ID="Label7" runat="server" Text="0"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">&nbsp;</td>
            <td>Company Net Profit :
                <asp:Label ID="Label13" runat="server" Text="0"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 594px">Paid To Transyamuna Fertilizers :
                <asp:Label ID="Label8" runat="server" Text="0"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">Credit Income :
                <asp:Label ID="Label9" runat="server" Text="0"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 594px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

