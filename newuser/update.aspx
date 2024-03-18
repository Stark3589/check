<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="User_update" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" tagPrefix="ajax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <ajax:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajax:ToolkitScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div align="center">
    <table style="border: 2px solid #FF0000; padding-left: 50px;" >
        <tr>
            <td colspan="4"><center>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="ADD NEW MEMBER"></asp:Label>
                </center></td>
        </tr>
        <tr>
            <td colspan="4" style=" height:2px; background-color:Red;"></td>
        </tr>
        
        <tr>
            <td colspan="4"><center>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </center></td>
        </tr>
        <tr>
            <td style="width: 163px">
                &nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">
                <asp:Label ID="Label39" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Registration Date" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox22" runat="server" Visible="False"></asp:TextBox>
                 <ajax:CalendarExtender ID="CalendarExtender3" TargetControlID="TextBox22" Format="dd/MM/yyyy" runat="server">
                    </ajax:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 163px">
            </td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">
                
            </td>
            <td>
               
            </td>
        </tr>
        <tr>   <td colspan="4"><div style="width:100%; height:2px; background-color:Red;"> </div>
               </td>
        </tr>
        <tr>
            <td colspan="2"><center style="width: 249px"><asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Personal Details" ></asp:Label> </center></td>
            <td colspan="2"><center> <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Your Registration ID Details" ></asp:Label></center></td>
        </tr>
        <tr>
        
            <td colspan="4"><div style="width:100%; height:2px; background-color:Red;"> </div>
               </td>
            
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">
                &nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="User Name"></asp:Label>
            </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtname" runat="server" placeholder="Enter UserName" ReadOnly="true"
                    required=""></asp:TextBox>
            </td>
            <td style="width: 177px">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Up-Line ID"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="Dropupline" runat="server" 
                  Width="200px" Enabled="false" >
                    
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>
                <asp:Label ID="Label34" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" Text="Father / Husband Name"></asp:Label> </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtfathusb" runat="server" placeholder="Husband / Father Name"></asp:TextBox>
            </td>
            <td style="width: 177px"><asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" Text="User ID"></asp:Label> </td>
            <td>
                <asp:TextBox ID="txtuserid" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label33" runat="server" Font-Bold="True" Font-Size="Medium" Text="Address"></asp:Label> </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtadd" runat="server" TextMode="MultiLine" Width="191px"></asp:TextBox>
            </td>
            <td style="width: 177px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" Text="Sex"></asp:Label> </td>
            <td style="width: 309px">
                <asp:DropDownList ID="Dropgender" runat="server" Width="200px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Transgender</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 177px">&nbsp;</td>
            <td>
                
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="DOB"></asp:Label> </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtdob" runat="server" placeholder="Select DOB"></asp:TextBox>
                  <ajax:CalendarExtender ID="CalendarExtender2" TargetControlID="txtdob" Format="dd/MM/yyyy" runat="server">
                    </ajax:CalendarExtender>
            </td>
            <td style="width: 177px">
                <asp:Label ID="Label35" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Password" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtpass" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
            <td style="width: 163px">
                <asp:Label ID="Label42" runat="server" Font-Bold="True" Font-Size="Medium" Text="Pin Code"></asp:Label>
            </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtpincode" runat="server" MaxLength="6"></asp:TextBox>
            </td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
            </ContentTemplate>
            </asp:UpdatePanel>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td colspan="2"><center> <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="Large" Text="Nominee Details" Font-Underline="True"></asp:Label></center></td>
        </tr>
        <tr>
            <td style="width: 163px">
                <asp:Label ID="Label41" runat="server" Font-Bold="True" Font-Size="Medium" Text="State"></asp:Label>
            </td>
            <td style="width: 309px">
                <asp:DropDownList ID="Dropstate" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Dropstate_SelectedIndexChanged" Width="200px">
                </asp:DropDownList>
            </td>
            <td colspan="2"><div style="width:100%; height:2px; background-color:Red;"> </div></td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px"><asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="Medium" Text="Nominee Name"></asp:Label> </td>
            <td>
                <asp:TextBox ID="txtnominee" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label12" runat="server" Font-Bold="True" 
                    Font-Size="Medium" Text="City"></asp:Label> </td>
            <td style="width: 309px">
                <asp:DropDownList ID="Dropcity" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px"><asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="Medium" Text="Relation With Nominee"></asp:Label> </td>
            <td>
                <asp:DropDownList ID="Dropnomrelation" runat="server" Height="34px" Width="123px">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Husband</asp:ListItem>
                    <asp:ListItem>Wife</asp:ListItem>
                    <asp:ListItem>Father</asp:ListItem>
                    <asp:ListItem>Mother</asp:ListItem>
                    <asp:ListItem>Son</asp:ListItem>
                    <asp:ListItem>Daughter</asp:ListItem>
                    <asp:ListItem>Brother</asp:ListItem>
                    <asp:ListItem>Sister</asp:ListItem>
                    <asp:ListItem>Grand Father</asp:ListItem>
                    <asp:ListItem>Grand Mother</asp:ListItem>
                    <asp:ListItem>Cousin</asp:ListItem>
                    <asp:ListItem>Nephew</asp:ListItem>
                    <asp:ListItem>Niece</asp:ListItem>
                    <asp:ListItem>Uncle</asp:ListItem>
                    <asp:ListItem>Aunt</asp:ListItem>
                    <asp:ListItem>Father-in-Law</asp:ListItem>
                    <asp:ListItem>Mother-in-Law</asp:ListItem>
                    <asp:ListItem>Brother-in-Law</asp:ListItem>
                    <asp:ListItem>Sister-in-Law</asp:ListItem>
                        <asp:ListItem>Grand Son</asp:ListItem>
                        <asp:ListItem>Grand Daughter</asp:ListItem>
                        <asp:ListItem>Daughter In Law</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Medium" Text="Mobile"></asp:Label> </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtmob" runat="server" ReadOnly="true"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="txtmob" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px; height: 20px"></td>
            <td style="width: 309px; height: 20px"></td>
            <td style="width: 177px"><asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="Medium" Text="DOB Of Nominee"></asp:Label> </td>
            <td>
                <asp:TextBox ID="txtnomdob" runat="server" placeholder="Select DOB Of Nominee"></asp:TextBox>
                  <ajax:CalendarExtender ID="CalendarExtender1" TargetControlID="txtnomdob" Format="dd/MM/yyyy" runat="server">
                    </ajax:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="Medium" Text="Pan No"></asp:Label> </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtpan" runat="server"></asp:TextBox>
            </td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">
                <asp:Label ID="lblpan" runat="server" style="color: #FF0000; font-weight: 700"></asp:Label>
            </td>
            
            <td style="width: 177px; height: 20px"><asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="Medium" Text="Age"></asp:Label> </td>
            <td style="height: 20px">
                <asp:TextBox ID="txtnomage" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="Medium" Text="E-Mail"></asp:Label> </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4"><div style="width:100%; height:2px; background-color:Red;"> </div></td>
        </tr>
        <tr>
            <td colspan="4"><center> <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Large" Text="Bank Account Details" Font-Underline="false"></asp:Label></center></td>
        </tr>
       
        <tr>
            <td colspan="4"><div style="width:100%; height:2px; background-color:Red;"> </div></td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">
                &nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">
                <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Name Of Bank"></asp:Label>
            </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtbankname" runat="server"></asp:TextBox>
            </td>
            <td style="width: 177px">
                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Name As the Bank A/C"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtaccountname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Size="Medium" Text="Bank A/C No"></asp:Label> </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtaccountno" runat="server"></asp:TextBox>
            </td>
            <td style="width: 177px"><asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Size="Medium" Text="Location Of Branch"></asp:Label> </td>
            <td>
                <asp:TextBox ID="txtbranch" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Size="Medium" Text="IFSC"></asp:Label> </td>
            <td style="width: 309px">
                <asp:TextBox ID="txtifsccode" runat="server"></asp:TextBox>
            </td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
 <tr>
            <td colspan="4"><div style="width:100%; height:2px; background-color:Red;"> </div></td>
        </tr>
        <tr>
            <td colspan="4"><center> <asp:Label ID="Label29" runat="server" Font-Bold="True" Font-Size="Large" Text="Upload Images" Font-Underline="false"></asp:Label></center></td>
        </tr>
       
        <tr>
            <td colspan="4"><div style="width:100%; height:2px; background-color:Red;"> </div></td>
        </tr>
        <tr>
            <td style="width: 163px; height: 22px">&nbsp;</td>
            <td style="width: 309px; height: 22px">
                &nbsp;</td>
            <td style="width: 177px; height: 22px">
                &nbsp;</td>
            <td style="height: 22px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px; height: 22px">
                <asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Upload Image Of User"></asp:Label>
            </td>
            <td style="width: 309px; height: 22px">
                <asp:Image ID="Image1" runat="server" Height="127px" Width="126px" />
            </td>
            <td style="width: 177px; height: 22px">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="215px" />
            </td>
            <td style="height: 22px">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click"  Text="Upload" />
            </td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label31" runat="server" Font-Bold="True" Font-Size="Medium" Text="KYC(Pan Card/Aadhar Card/Voter ID)"></asp:Label> </td>
            <td style="width: 309px">
                <asp:Image ID="Image2" runat="server" Height="120px" Width="200px" />
            </td>
            <td style="width: 177px">
                <asp:FileUpload ID="FileUpload2" runat="server" Width="215px" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Upload" />
            </td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px"><asp:Label ID="Label32" runat="server" Font-Bold="True" Font-Size="Medium" Text="PassBook/Cancel Cheque"></asp:Label> </td>
            <td style="width: 309px">
                <asp:Image ID="Image3" runat="server" Height="120px" Width="200px" />
            </td>
            <td style="width: 177px">
                <asp:FileUpload ID="FileUpload3" runat="server" Width="215px" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server"  OnClick="Button4_Click" Text="Upload" />
            </td>
        </tr>
         <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td colspan="4"><div style="width:100%; height:2px; background-color:Red;"> </div></td>
        </tr>
        <tr>
            <td colspan="4">
                <center>
                    <asp:Label ID="Label36" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="False" Text="Update Detail"></asp:Label>
                </center>
            </td>
        </tr>
      
        <tr>
            <td colspan="4">
                <div style="width:100%; height:2px; background-color:Red;"> </div></td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
       
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4"><center> 
                <asp:Button ID="Button5" runat="server" Text="UPDATE" OnClick="Button5_Click" />
                &nbsp;&nbsp;&nbsp;
               
                
                </center></td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 309px">&nbsp;</td>
            <td style="width: 177px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table></div>
     </ContentTemplate>
        <Triggers>
                    <asp:PostBackTrigger ControlID="Button2" />
            <asp:PostBackTrigger ControlID="Button3" />
            <asp:PostBackTrigger ControlID="Button4" />
             <asp:PostBackTrigger ControlID="Button5" />
           
                    </Triggers>
   </asp:UpdatePanel>
</asp:Content>

