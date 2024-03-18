<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="User_Default3" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" tagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <cc1:ToolkitScriptManager ID="toolkit1" runat="server"></cc1:ToolkitScriptManager>
    <div>
    <table >
        <thead>
            <tr>
                <th colspan="9" style="background-color:pink;">
                    &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Direct Purchse Tree</asp:LinkButton>       <asp:Label ID="Label3" runat="server" Text="/">      </asp:Label><asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Next Club Tree</asp:LinkButton></th>
            </tr>
             <tr>
                <th colspan="9" style="background-color:pink;">
                    &nbsp;</th>
            </tr>
            
            
            
            
            <tr>
                <th style="width: 170px">
                    &nbsp;</th>
                <th colspan="2">
                    &nbsp;</th>
                <th style="width: 86px">
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th colspan="2">
                    &nbsp;</th>
                <th colspan="3">
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
            </tr>
            
        </thead>
            <tr>
                <th style="width: 170px">
                    &nbsp;</th>
                <th colspan="2">
                    &nbsp;</th>
                <th style="width: 86px">
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th colspan="2">
                    &nbsp;</th>
                <th colspan="3">
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
            </tr>
            <tr>
                <th style="width: 170px">
                    &nbsp;</th>
                <th colspan="2">
                    &nbsp;</th>
                <th style="width: 86px">
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th colspan="2">
                    &nbsp;</th>
                <th colspan="3">
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
                <th>
                    &nbsp;</th>
            </tr>
        <tr>
            <th scope="row" style="width: 170px">
             
                    &nbsp;</th>
            <th scope="row" colspan="9">
             
                    <asp:Label 
                    ID="Label19" runat="server" Font-Bold="True" Font-Names="Monotype Corsiva" 
                    Font-Size="X-Large" ForeColor="#CC0000" Text="Search By Id"></asp:Label>
                    <span class="fa arrow">
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="TextBox1" runat="server" class="form-control1" 
                  placeholder=" Enter User Name" Width="250px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    </span>
        <asp:Button ID="Button2" runat="server" Text="Search" 
                    class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal" 
                    Height="42px" Width="120px" onclick="Button2_Click" />
                 </th>
            <th scope="row">
             
                    &nbsp;</th>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <th scope="row" style="width: 170px">
             
                    &nbsp;</th>
            <th scope="row" colspan="9">
             
                    &nbsp;</th>
            <th scope="row">
             
                    &nbsp;</th>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 170px">
                &nbsp;</td>
            <td style="width: 90px">
                &nbsp;</td>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 86px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td style="width: 62px">
                <center>
                <span class="fa arrow">
                <asp:ImageButton ID="ImageButton1" runat="server" 
                    Height="26px" Width="44px" OnClick="ImageButton1_Click" 
                        ImageUrl="~/photos/Black.png" />
                   
                     <asp:Panel ID="Panel1" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
    <tr><td>Name :</td><td> <asp:Label ID="t11" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t12" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t13" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t14" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t15" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender1" runat="server" TargetControlID="ImageButton1" PopupControlID="Panel1" PopupPosition="right">
        </cc1:hovermenuextender>
                </td>
            </center>
            <td>
                &nbsp;</td>
            <td style="width: 102px">
                &nbsp;</td>
            <td style="width: 33px">
                &nbsp;</td>
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
            <td style="width: 170px">
                &nbsp;</td>
            <td style="width: 90px">
                &nbsp;</td>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 86px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td style="width: 62px">
                <span class="fa arrow">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
                <asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                    </td>
            <td>
                <center>
                <span class="fa arrow">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </center>
            </td>
            <td style="width: 102px">
                &nbsp;</td>
            <td style="width: 33px">
                &nbsp;</td>
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
            <td style="width: 170px">
                &nbsp;</td>
            <td style="width: 90px">
                &nbsp;</td>
            <td colspan="8">
                &nbsp;
                <asp:Image ID="Image2" runat="server" Height="42px" 
                    ImageUrl="~/photos/arrow.jpg" Width="580px" />
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
            <td style="width: 170px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td style="width: 90px">
                &nbsp;</td>
            <td colspan="2">
                <span class="fa arrow">
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton3_Click" />
                     <asp:Panel ID="Panel2" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
    <tr><td>Name :</td><td> <asp:Label ID="t21" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t22" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t23" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t24" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t25" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender2" runat="server" TargetControlID="ImageButton3" PopupControlID="Panel2" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
&nbsp;<asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td style="width: 62px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td>
                <span class="fa arrow">
                <br />
                <br />
&nbsp;</td>
            <td colspan="5">
                <span class="fa arrow">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton4_Click" />
                     <asp:Panel ID="Panel3" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
    <tr><td>Name :</td><td> <asp:Label ID="t31" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t32" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t33" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t34" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t35" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender3" runat="server" TargetControlID="ImageButton4" PopupControlID="Panel3" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
            &nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Label ID="Label36" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 170px">
                &nbsp;</td>
            <td colspan="3">
                &nbsp;&nbsp;
                <asp:Image ID="Image3" runat="server" Height="39px" 
                    ImageUrl="~/photos/arrow.jpg" Width="210px" />
            </td>
            <td>
                &nbsp;</td>
            <td colspan="2">
                &nbsp;&nbsp;&nbsp;
                </td>
            <td colspan="5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Image ID="Image5" runat="server" Height="36px" 
                    ImageUrl="~/photos/arrow.jpg" Width="210px" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 170px">
                &nbsp;</td>
            <td style="width: 90px">
                <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton5_Click" />
                  <asp:Panel ID="Panel4" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
     <tr><td>Name :</td><td> <asp:Label ID="t41" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t42" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t43" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t44" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t45" runat="server" Text="XXXX"></asp:Label></td></tr>
  
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender4" runat="server" TargetControlID="ImageButton5" PopupControlID="Panel4" PopupPosition="top">
        </cc1:hovermenuextender>
                
                <br />
                <span class="fa arrow">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
&nbsp;<asp:Label ID="Label39" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td style="width: 69px">
                <span class="fa arrow">
                <br />
                <br />
                </td>
            <td style="width: 86px">
                <span class="fa arrow">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton8_Click" />
                      <asp:Panel ID="Panel5" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
     <tr><td>Name :</td><td> <asp:Label ID="t51" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t52" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t53" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t54" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t55" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender5" runat="server" TargetControlID="ImageButton8" PopupControlID="Panel5" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
&nbsp;<asp:Label ID="Label45" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td style="width: 62px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td>
                <span class="fa arrow">
                <br />
                <br />
&nbsp;</td>
            <td style="width: 102px">
                <span class="fa arrow">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton11_Click" />
                     <asp:Panel ID="Panel14" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
       <tr><td>Name :</td><td> <asp:Label ID="t61" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t62" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t63" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t64" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t65" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender14" runat="server" TargetControlID="ImageButton11" PopupControlID="Panel14" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
&nbsp;<asp:Label ID="Label57" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td style="width: 33px">
                &nbsp;</td>
            <td>
                <span class="fa arrow">
                <br />
                <br />
&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <span class="fa arrow">
                &nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton9_Click" />
                     <asp:Panel ID="Panel15" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
      <tr><td>Name :</td><td> <asp:Label ID="t71" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t72" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t73" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t74" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t75" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender15" runat="server" TargetControlID="ImageButton9" PopupControlID="Panel15" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
            &nbsp;<asp:Label ID="Label63" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 170px">
                &nbsp;</td>
            <td style="width: 90px">
                &nbsp;</td>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 86px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 102px">
                &nbsp;</td>
            <td style="width: 33px">
                &nbsp;</td>
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
            <td colspan="3">
                &nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image6" runat="server" Height="39px" 
                    ImageUrl="~/photos/arrow.jpg" Width="180px" />
            </td>
            <td colspan="4">
                <asp:Image ID="Image7" runat="server" Height="39px" 
                    ImageUrl="~/photos/arrow.jpg" Width="180px" />
            </td>
            <td colspan="3">
                <asp:Image ID="Image8" runat="server" Height="39px" 
                    ImageUrl="~/photos/arrow.jpg" Width="180px" />
            </td>
            <td>
                &nbsp;</td>
            <td colspan="3">
                <asp:Image ID="Image9" runat="server" Height="39px" 
                    ImageUrl="~/photos/arrow.jpg" Width="180px" />
            </td>
        </tr>
        <tr>
            <td style="width: 170px">
                <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton12_Click" />
                  <asp:Panel ID="Panel6" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
       <tr><td>Name :</td><td> <asp:Label ID="t81" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t82" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t83" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t84" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t85" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender6" runat="server" TargetControlID="ImageButton12" PopupControlID="Panel6" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                <br />
                <span class="fa arrow">
                <asp:Label ID="Label71" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
                <asp:Label ID="Label72" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td colspan="2">
                <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton13_Click" />
                  <asp:Panel ID="Panel7" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
      <tr><td>Name :</td><td> <asp:Label ID="t91" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t92" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t93" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t94" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t95" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender7" runat="server" TargetControlID="ImageButton13" PopupControlID="Panel7" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                <br />
                <span class="fa arrow">
                <asp:Label ID="Label73" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
                <asp:Label ID="Label74" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td style="width: 86px">
                <br />
                <asp:ImageButton ID="ImageButton14" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton14_Click" />
                  <asp:Panel ID="Panel8" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
      <tr><td>Name :</td><td> <asp:Label ID="t101" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t102" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t103" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t104" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t105" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender8" runat="server" TargetControlID="ImageButton14" PopupControlID="Panel8" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                <br />
                <span class="fa arrow">
                <asp:Label ID="Label75" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
                <asp:Label ID="Label76" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td>
                &nbsp;</td>
            <td colspan="2">
                &nbsp;<br />
                <asp:ImageButton ID="ImageButton15" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton15_Click" />
                  <asp:Panel ID="Panel9" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
       <tr><td>Name :</td><td> <asp:Label ID="t111" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t112" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t113" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t114" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t115" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender9" runat="server" TargetControlID="ImageButton15" PopupControlID="Panel9" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                <br />
                <span class="fa arrow">
                <asp:Label ID="Label77" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
                <asp:Label ID="Label78" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td style="width: 102px">
                <asp:ImageButton ID="ImageButton16" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton16_Click" />
                 <asp:Panel ID="Panel10" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
       <tr><td>Name :</td><td> <asp:Label ID="t121" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t122" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t123" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t124" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t125" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender10" runat="server" TargetControlID="ImageButton16" PopupControlID="Panel10" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                <br />
                <span class="fa arrow">
                <asp:Label ID="Label79" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
                <asp:Label ID="Label80" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td style="width: 33px">
                &nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButton17" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton17_Click" />
                 <asp:Panel ID="Panel11" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">   
    <tr><td>Name :</td><td> <asp:Label ID="t131" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t132" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t133" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t134" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t135" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender11" runat="server" TargetControlID="ImageButton17" PopupControlID="Panel11" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                <br />
                <span class="fa arrow">
                <asp:Label ID="Label81" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
                <asp:Label ID="Label82" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButton18" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton18_Click" />
                 <asp:Panel ID="Panel12" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
       <tr><td>Name :</td><td> <asp:Label ID="t141" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t142" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t143" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t144" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t145" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender12" runat="server" TargetControlID="ImageButton18" PopupControlID="Panel12" PopupPosition="top">
        </cc1:hovermenuextender>
                <br />
                <br />
                <span class="fa arrow">
                <asp:Label ID="Label83" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
                <asp:Label ID="Label84" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButton19" runat="server" ImageUrl="~/photos/Black.png" 
                    Height="26px" Width="44px" OnClick="ImageButton19_Click" />
                 <asp:Panel ID="Panel13" runat="server"  style="visibility:hidden" >
<table  style=" overflow: scroll; clip: rect(5px, 5px, 5px, 5px); border-spacing: 5px; background-color: #C5F1C6; border-radius:15px; width:200px; height:150px">
       <tr><td>Name :</td><td> <asp:Label ID="t151" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Joining Date :</td><td><asp:Label ID="t152" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Mobile :</td><td><asp:Label ID="t153" runat="server" Text="XXXX"></asp:Label></td></tr>
    <tr><td>Left :</td><td><asp:Label ID="t154" runat="server" Text="XXXX"></asp:Label></td></tr>
     <tr><td>Right :</td><td><asp:Label ID="t155" runat="server" Text="XXXX"></asp:Label></td></tr>
</table>
        </asp:Panel>
   
     <cc1:hovermenuextender ID="HoverMenuExtender13" runat="server" TargetControlID="ImageButton19" PopupControlID="Panel13" PopupPosition="left">
        </cc1:hovermenuextender>
                <br />
                <br />
                <span class="fa arrow">
                <asp:Label ID="Label85" runat="server" Font-Bold="True" ForeColor="Red" Text="0" Font-Size="Medium"></asp:Label>
                <br />
                <asp:Label ID="Label86" runat="server" Font-Bold="True" ForeColor="#009933" Font-Size="Medium"></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="width: 170px">
                &nbsp;</td>
            <td style="width: 90px">
                &nbsp;</td>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 86px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 102px">
                &nbsp;</td>
            <td style="width: 33px">
                &nbsp;</td>
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
            <td style="width: 170px">
                &nbsp;</td>
            <td style="width: 90px">
                &nbsp;</td>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 86px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td style="width: 62px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 102px">
                &nbsp;</td>
            <td style="width: 33px">
                &nbsp;</td>
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
    </table>
    </div>
    </form>
</body>
</html>
