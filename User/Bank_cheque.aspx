<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bank_cheque.aspx.cs" Inherits="Bank_cheque" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .backimage {
            background-image: url(images/Originals/cheque.jpg);
            background-size: 100% 100%;
            height: 400px;
            width: 100%;
        }

        .pdname {
            padding-top: 30px;
            padding-left: 78px;
        }

        table tr td {
            font-size: 18px;
            font-weight: 800;
            text-transform: uppercase;
        }

        .pdrupees {
            padding-top: 14px;
            padding-left: 140px;
        }

        .pdamount {
            padding-top: 1px;
            padding-left: 617px;
            text-align: center;
        }

        .pddate {
            padding-right: 130px;
            padding-top: 31px;
            text-align: right;
        }
    </style>
     <script>window.print()
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="backimage">
            <table style="width: 100%">
                <tr>
                    <td class="pddate"><asp:Label ID="lbl_date" runat="server" ></asp:Label></td>
                </tr>
                <tr>
                    <td class="pdname">
                        <asp:Label ID="lbl_name" runat="server" ></asp:Label></td>
                </tr>
                <tr>
                    <td class="pdrupees">
                        <asp:Label ID="lbl_amountwords" runat="server" ></asp:Label></td>
                </tr>
                <tr>
                    <td class="pdamount">
                        <asp:Label ID="lbl_amount" runat="server" ></asp:Label></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
