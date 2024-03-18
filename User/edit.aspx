<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="table-responsive">
      <table class="table table-bordered">
        <thead>
          <tr>
            <th>&nbsp;</th>
            <th colspan="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
                    <center> <asp:Label 
                    ID="Label19" runat="server" Font-Bold="True"  
                    Font-Size="X-Large" ForeColor="Purple" Text="Edit Profile " Font-Underline="True"></asp:Label></center>
              </th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <th>&nbsp;</th>
            <th colspan="4">&nbsp;</th>
          </tr>
          <tr>
            <th scope="row" colspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
                    <asp:Label 
                    ID="Label20" runat="server" Font-Bold="True"  
                    Font-Size="X-Large" ForeColor="Purple" Text="Enter User Id"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="TextBox1" runat="server" class="form-control1" 
                   Width="250px" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 </th>
          </tr>
          <tr>
            <th scope="row">&nbsp;</th>
            <td>&nbsp;</td>
            <td colspan="3">&nbsp;</td>
          </tr>
          <tr>
            <th scope="row">&nbsp;</th>
            <td><asp:Label 
                    ID="Label21" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="Name"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox2" runat="server" class="form-control1" 
                   Width="250px" required></asp:TextBox>
                    </td>
            <td><asp:Label 
                    ID="Label23" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="Address"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox6" runat="server" class="form-control1" 
                   Width="250px" TextMode="MultiLine" required></asp:TextBox>
                    </td>
          </tr>
          <tr>
            <th scope="row">&nbsp;</th>
            <td>
                <asp:Label 
                    ID="Label29" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="City"></asp:Label></td>
            <td>
                
              <asp:TextBox ID="TextBox10" runat="server" class="form-control1" 
                   Width="250px" required></asp:TextBox>
                    </td>
            <td>
                <asp:Label 
                    ID="Label30" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="State"></asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownList2" class="form-control1"  runat="server">
               
                  <asp:ListItem value="1">Delhi</asp:ListItem>
	<asp:ListItem value="2">Haryana</asp:ListItem>
	<asp:ListItem value="3">Punjab</asp:ListItem>
	<asp:ListItem value="4">Chandigarh</asp:ListItem>
	<asp:ListItem value="5">Rajasthan</asp:ListItem>
	<asp:ListItem value="6">Uttar Pradesh</asp:ListItem>
	<asp:ListItem value="7">Uttarakhand</asp:ListItem>
	<asp:ListItem value="8">Jharkhand</asp:ListItem>
	<asp:ListItem value="9">Himachal Pradesh</asp:ListItem>
	<asp:ListItem value="10">Bihar</asp:ListItem>
	<asp:ListItem value="11">Maharashtra</asp:ListItem>
	<asp:ListItem value="12">Madhya Pradesh</asp:ListItem>
	<asp:ListItem value="13">Karnataka</asp:ListItem>
	<asp:ListItem value="14">Arunachal Pradesh</asp:ListItem>
	<asp:ListItem value="15">Goa</asp:ListItem>
	<asp:ListItem value="16">Jammu And kashmir</asp:ListItem>
	<asp:ListItem value="17">Lakshadweep</asp:ListItem>
	<asp:ListItem value="18">Meghalaya</asp:ListItem>
	<asp:ListItem value="19">Nagaland</asp:ListItem>
	<asp:ListItem value="20">Tripura</asp:ListItem>
	<asp:ListItem value="21">Tamil Nadu</asp:ListItem>
	<asp:ListItem value="22">Andhra Pradesh</asp:ListItem>
	<asp:ListItem value="23">Assam</asp:ListItem>
	<asp:ListItem value="24">Dadra And nagar haveli</asp:ListItem>
	<asp:ListItem value="25">Gujarat</asp:ListItem>
	<asp:ListItem value="26">Kerala</asp:ListItem>
	<asp:ListItem value="27">Andaman And nicobar islands</asp:ListItem>
	<asp:ListItem value="28">Daman And diu</asp:ListItem>
	<asp:ListItem value="29">Manipur</asp:ListItem>
	<asp:ListItem value="30">Sikkim</asp:ListItem>
	<asp:ListItem value="31">Mizoram</asp:ListItem>
	<asp:ListItem value="32">Telangana</asp:ListItem>
	<asp:ListItem value="33">West Bengal</asp:ListItem>
	<asp:ListItem value="34">Orissa</asp:ListItem>
	<asp:ListItem value="35">Chhattisgarh</asp:ListItem>
	<asp:ListItem value="36">Puducherry</asp:ListItem>
              </asp:DropDownList>
              </td>
          </tr>
          <tr>
            <th scope="row">&nbsp;</th>
            <td><asp:Label 
                    ID="Label22" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="Father Name"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox3" runat="server" class="form-control1" 
                   Width="250px" required></asp:TextBox>
                    </td>
            <td><asp:Label 
                    ID="Label24" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="Mobile No"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox7" runat="server" class="form-control1" 
                   Width="250px" required></asp:TextBox>
                    </td>
          </tr>
          <tr>
            <th scope="row">&nbsp;</th>
            <td><asp:Label 
                    ID="Label25" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="Bank Name"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox4" runat="server" class="form-control1" 
                   Width="250px"></asp:TextBox>
                    </td>
            <td><asp:Label 
                    ID="Label26" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="Account No"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox8" runat="server" class="form-control1" 
                   Width="250px"></asp:TextBox>
                    </td>
          </tr>
          <tr>
            <th scope="row">&nbsp;</th>
            <td><asp:Label 
                    ID="Label27" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="IFSC"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox5" runat="server" class="form-control1" 
                   Width="250px"></asp:TextBox>
                    </td>
            <td><asp:Label 
                    ID="Label28" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="Pan No"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox9" runat="server" class="form-control1" 
                   Width="250px"></asp:TextBox>
                    </td>
          </tr>
          <tr>
            <th scope="row">&nbsp;</th>
            <td>
                <asp:Label 
                    ID="Label31" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="Nominee Name"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox11" runat="server" class="form-control1" 
                   Width="250px"></asp:TextBox>
                    </td>
            <td>
                <asp:Label 
                    ID="Label32" runat="server" Font-Bold="True"  
                    Font-Size="Medium" ForeColor="Purple" Text="Relation"></asp:Label></td>
            <td>
              <asp:TextBox ID="TextBox12" runat="server" class="form-control1" 
                   Width="250px"></asp:TextBox>
                    </td>
          </tr>
          <tr>
            <th scope="row">&nbsp;</th>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="UPDATE" 
                    
                    Height="42px" Width="120px" onclick="Button3_Click" />
                 </td>
          </tr>
        </tbody>
      </table>
    </div>
</asp:Content>

