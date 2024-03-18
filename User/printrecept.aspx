<%@ Page Language="C#" AutoEventWireup="true" CodeFile="printrecept.aspx.cs" Inherits="User_printrecept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>window.print();
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 69%;
        }
        .auto-style2 {
            width: 43%;
        }
        .auto-style4 {
            width: 410px;
        }
        .auto-style6 {
            width: 388px;
        }
        .auto-style7 {
            width: 400px;
        }
        .auto-style8 {
            width: 137px;
        }
        .auto-style9 {
            width: 574px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
          <div style="border-style: solid; border-color: inherit; border-width: 1px">
  
   
     <table border="1">
        <tr>
            <td></td>
            <td>
                GSTIN: <asp:Label ID="Label8" runat="server" Text="09AA1CM6782E123" Font-Bold="true" Font-Size="Large"></asp:Label>
                <%--<asp:Label ID="gstin" runat="server"></asp:Label>--%>
     
            </td>
            <td>&nbsp;</td>
        </tr>
         
         <tr>
             <td>&nbsp;</td>
             <td>
                <h4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MAHI BIOTECH LTD.&nbsp;<center></center></h4>
                 
             </td>
             <td>
                 <asp:Label ID="lbl1" runat="server" Text="PreAuthicated By For Mahi Biotech Ltd."></asp:Label></td>
             </tr>
       
               
              
           <tr>
             <td><asp:Label ID="Label9" Text="Branch Address:" Font-Bold="true" runat="server"></asp:Label></td>
             <td><asp:Label ID="add" Text="1st Floor,Serv UP Grameen Bank,Opp,
                 Sai Hospital, Gandhi Ground,Budaun 243601 (UP)." runat="server"></asp:Label></td>
             <td class="auto-style8">
               
             </td>
            
             </tr>
         </table>
           <hr/>
              <table border="1" >
             <tr>
                 <td><asp:Label ID="Label7" Text="INVOICE NO:" Font-Bold="true" runat="server"></asp:Label></td>
                 <td class="auto-style9"><asp:Label ID="Label10" Font-Bold="true" runat="server"></asp:Label></td>
                 <td><asp:Label ID="date" runat="server" Text="DATE:"></asp:Label></td>
             </tr>
              </table>
             <table>
                  <tr>
                    <td style="text-align: center" colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">PARTY DETAILS: 
                        <asp:Label ID="lblm" runat="server" style="font-size:medium; font-weight: 500"></asp:Label>
                         <asp:Label ID="Label6" runat="server" Visible="false" style="font-size:medium; font-weight: 500"></asp:Label>
                    </td>
                    <td class="auto-style2">INVOICE :<asp:Label ID="lbln" runat="server" style="font-size: small; font-weight: 500"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">ADDRESS: 
                        <asp:Label ID="lblf" runat="server" style="font-size: small; font-weight: 500"></asp:Label>
                    </td> 
                    <td class="auto-style2">DATE-<asp:Label ID="lbldate" runat="server" style="font-size: medium; font-weight: 500"></asp:Label></td>    
                </tr>
                <tr>
                    <td class="auto-style1">PAN NO :-<asp:Label ID="lbladd" runat="server" style="font-size: small; font-weight: 500"></asp:Label>
                    </td>
                    </tr>
          <tr>
                    <td class="auto-style1">
                        MOBILENO: <asp:Label ID="lblno" runat="server" style="font-size: small; font-weight: 500"></asp:Label>
                    </td>
                    <td class="auto-style2">PLACE OF SUPPLY:-<asp:Label ID="supply" runat="server" style="font-size: small; font-weight: 500"></asp:Label>
                    </td>
                </tr>
                 </table>
    <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="false" ShowFooter="true" Width="90%">
        <Columns>
            <asp:TemplateField HeaderText="SL.NO">
                <ItemTemplate>
                    <%#Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DATAFIELD="productname" HeaderText="DESCRIPTION OF GOODS" ItemStyle-HorizontalAlign="Center" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="productcode" headertext="PRODUCT CODE" ItemStyle-HorizontalAlign="Center" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="quantity" HeaderText="QUANTITY" ItemStyle-HorizontalAlign="Center" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="amount" HeaderText="MRP" ItemStyle-HorizontalAlign="Center" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="totalamt" HeaderText="NET AMOUNT" ItemStyle-HorizontalAlign="Center" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            </Columns>

    </asp:GridView>
       
              <div class="col-md-2" style="text-align:center; margin-left: 300px;border:1px">
              <asp:Label id="labl" runat="server" text="ADD GST  @  5.00% :"></asp:Label>
        &nbsp;&nbsp  <asp:Label id="Label4"  runat="server"  Visible="false"></asp:Label>
                  </div>
              <hr style="width: 935px" />
                  <div class="col-md-2" style="text-align:center; margin-left: 300px;border:1px">
              <asp:Label id="Label1" runat="server" text="ADD SGST  @  5.00% :"></asp:Label>
                    &nbsp;&nbsp  <asp:Label id="Label5"  runat="server" Text="" Visible="false"></asp:Label>
                  </div>
                <hr />
                 <div class="col-md-2" style="text-align:center; margin-left: 300px;border:1px">
              <asp:Label id="Label2" runat="server" text="GRAND TOTAL : RS"></asp:Label>
                    
                     &nbsp;&nbsp;<asp:Label id="Label3"  runat="server" Text="Rs." Visible="false"></asp:Label>
                      
                  </div>

        <hr />
              <asp:Label ID="words" runat="server"></asp:Label>
                 <br />
             <hr />   
              <table border="1" >
          <tr>
            
              <th style="text-align:left" class="auto-style6">TERMS & CONDITIONS</th>
              <th style="text-align:center" class="auto-style7">RECEIVER SIGNATURE</th>
              <th class="auto-style4">COMPANY NAME</th>
            
              </tr>
                  <tr>
                   <th style="text-align:left" class="auto-style6">E.&O.E</th>  
                  </tr>
                  <tr>
            <td class="auto-style6">
                1-Goods once sold will not be taken<br />
                    back if damaged or tampered.
              <br />
                
             2-Interest will be charged if the payment <br />
                is not made in stipulated time.
                      </td>
                 
                  <td class="auto-style7"></td>
                      <td class="auto-style4">
                         
                         <asp:Label id="lbsoftname12"  runat="server"></asp:Label>
                          <br />
                          <br />
                          <br />
                          <br />
                          <br />
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AUTHORISED SIGNATURE</td>
                  
                       </tr>
              </table>
    
              </div>
    </form>
</body>
</html>
