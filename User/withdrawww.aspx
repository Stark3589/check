<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="withdrawww.aspx.cs" Inherits="User_withdrawww" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .Background {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
        }

        .Popup {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            padding-right: 10px;
            width: 500px;
            /*height: 400px;*/
        }

        .lbl {
            font-size: 16px;
            font-style: italic;
            font-weight: bold;
        }

        table {
            background-color: transparent;
            margin-left: 0px;
        }

            table tr td {
                padding: 5px;
            }

            table tr th {
                padding: 5px;
            }

        .gdset {
            height: 50%;
        }
    </style>
    <script type="text/javascript">
        function PrintPanel() {
            var panel = document.getElementById("<%=Panl1.ClientID %>");
            var printWindow = window.open('', '', 'height=500,width=800');
            printWindow.document.write('<html><head><title></title>');
            printWindow.document.write('</head><body >');
            printWindow.document.write(panel.innerHTML);
            printWindow.document.write('</body></html>');
            printWindow.document.close();
            setTimeout(function () {
                printWindow.print();
            }, 500);
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="row">
        <center>   <h1>TRANSFER AMOUNT</h1></center>
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
        <div class="col-md-12" style="margin-left: 50px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="82%">
                <Columns>
                    <%--  <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:CheckBox ID="Chkall" runat="server" Text="ALL" AutoPostBack="true" OnCheckedChanged="Chkall_CheckedChanged" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkSelect" runat="server" />

                        </ItemTemplate>
                    </asp:TemplateField>--%>

                    <asp:BoundField DataField="username" HeaderText="Username" />
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="mobile" HeaderText="Mobile No." />
                    <asp:BoundField HeaderText="Total Amount" DataField="Total" />

                    <%--    <asp:BoundField HeaderText="TDS" />
                           <asp:BoundField HeaderText="Admin" />--%>
                    <%--<asp:BoundField DataField="ifsc" headertext="IFSC" />
                         <asp:BoundField DataField="accno" headertext="Accountno" />
                         <asp:BoundField DataField="bankname" headertext="BankName" />--%>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Container.DataItemIndex + 1%>' CommandName="hello">TRANSFER</asp:LinkButton>
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

        </div>


        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:LinkButton ID="LinkButton2" runat="server"></asp:LinkButton>
        <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="LinkButton2"
            CancelControlID="Button2" BackgroundCssClass="Background">
        </cc1:ModalPopupExtender>
        <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" Height="100%" Style="display: none">



            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" CssClass="lbl" Text="Username"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="true" Font-Size="14px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" CssClass="lbl" Text="Total Amount"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true" Font-Size="14px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" CssClass="lbl" Text="Mode of Payment"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Cash</asp:ListItem>
                            <asp:ListItem>Cheque</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" CssClass="lbl" Text="Bank Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Font-Size="14px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" CssClass="lbl" Text="Branch Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Font-Size="14px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" CssClass="lbl" Text="Cheque No."></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Font-Size="14px"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" CssClass="lbl" Text="Cheque Date"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox6" type="date" runat="server" Font-Size="14px"></asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Button ID="btnPrint" runat="server" Text="Save" OnClick="btnPrint_Click1" />
                    </td>

                </tr>

            </table>
            <asp:Label ID="Label10" runat="server" ForeColor="Red"></asp:Label>
            <asp:GridView ID="GridView2" ShowHeaderWhenEmpty="true" AutoGenerateColumns="false" Width="100%" runat="server">
                <Columns>
                    <asp:BoundField DataField="incomeby" HeaderText="Income By" />
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="lvlincome" HeaderText="Level Income" />
                    <asp:BoundField DataField="directincome" HeaderText="Direct Income" />
                    <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>

                            <asp:Label ID="Label9" runat="server" Text='<%# Eval("date", "{0:dd/MM/yyyy}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
                <EmptyDataTemplate>No Record Available</EmptyDataTemplate>
            </asp:GridView>
            <asp:Button ID="Button2" runat="server" Text="Close" />
            <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="Blue" OnClientClick="return PrintPanel();">Print</asp:LinkButton>
           
            
             <asp:LinkButton ID="LinkButton4" OnClientClick="SetTarget();"  runat="server" OnClick="LinkButton4_Click">Cheque Print</asp:LinkButton>
        <script type="text/javascript">
            function SetTarget() {
                document.forms[0].target = "_blank";
            }
</script>
        
        </asp:Panel>
    </div>
</asp:Content>

