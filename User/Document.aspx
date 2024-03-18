<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="Document.aspx.cs" Inherits="User_Document" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td colspan="3">
                <center><h3>Documents Check</h3></center></td>
        </tr>
        <tr>
            <td>
                Select User ID</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="100px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button8" runat="server" onclick="Button8_Click" Text="Search" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <asp:Panel ID="Panel1" runat="server" Visible="true">
        <tr>
            <td>
                Photo</td>
            <td>
                <asp:Image ID="Image1" runat="server" Height="100px" Width="75px" />
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click"/>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                ID Proof</td>
            <td>
                <asp:Image ID="Image2" runat="server" />
            </td>
            <td>
                <asp:FileUpload ID="FileUpload2" runat="server" />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Upload" onclick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Address Proof</td>
            <td>
                <asp:Image ID="Image3" runat="server" />
            </td>
            <td>
                <asp:FileUpload ID="FileUpload3" runat="server" />
                <br />
                <asp:Button ID="Button3" runat="server" Text="Upload" onclick="Button3_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Passbook</td>
            <td>
                <asp:Image ID="Image4" runat="server" />
            </td>
            <td>
                <asp:FileUpload ID="FileUpload4" runat="server" />
                <br />
                <asp:Button ID="Button4" runat="server" Text="Upload" onclick="Button4_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Pan Card</td>
            <td>
                <asp:Image ID="Image5" runat="server" />
            </td>
            <td>
                <asp:FileUpload ID="FileUpload5" runat="server" />
                <br />
                <asp:Button ID="Button5" runat="server" Text="Upload" onclick="Button5_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Thumb</td>
            <td>
                <asp:Image ID="Image6" runat="server" />
            </td>
            <td>
                <asp:FileUpload ID="FileUpload6" runat="server" />
                <br />
                <asp:Button ID="Button6" runat="server" Text="Upload" onclick="Button6_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Sign</td>
            <td>
                <asp:Image ID="Image7" runat="server" />
            </td>
            <td>
                <asp:FileUpload ID="FileUpload7" runat="server" />
                <br />
                <asp:Button ID="Button7" runat="server" Text="Upload" onclick="Button7_Click" />
            </td>
        </tr></asp:Panel>
        <tr>
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
        </tr>
        <tr>
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
        </tr>
        <tr>
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
        </tr>
    </table>
</asp:Content>

