<%@ Page Language="C#" EnableViewStateMac="false" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sign Up Form</title>
    <meta name="description" content="Custom Login Form Styling with CSS3" />
    <meta name="keywords" content="css3, login, form, custom, input, submit, button, html5, placeholder" />
    <meta name="author" content="Codrops" />
    <link rel="shortcut icon" href="../favicon.ico">
    <link rel="stylesheet" type="text/css" href="register/css/style.css" />

   <link
      href="https://fonts.googleapis.com/css2?family=Poppins:wght@200;300;400;500;600;700;800&display=swap"
      rel="stylesheet"
    />
     <style>
			
            body { 
  background: url(register/register_bg.jpg) no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
		</style>
    <script type="text/javascript">
        function DisableButton() {
            document.getElementById("<%=Button1.ClientID %>").disabled = true;
        }
        window.onbeforeunload = DisableButton;
    </script>
    <style type="text/css">
        .modalBackground {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
        }

        .modalPopup {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 300px;
            height: 140px;
        }

        .ddlist {
            font-family: 'Lato', Calibri, Arial, sans-serif;
            font-size: 13px;
            font-weight: 400;
            display: block;
            width: 100%;
            padding: 5px;
            margin-bottom: 5px;
            border: 3px solid #ebe6e2;
            border-radius: 5px;
            -webkit-transition: all 0.3s ease-out;
            -moz-transition: all 0.3s ease-out;
            -ms-transition: all 0.3s ease-out;
            -o-transition: all 0.3s ease-out;
            transition: all 0.3s ease-out;
        }
        .bodycolor {
            background:linear-gradient(to right, #ccfff8 0%, #e9ffcc 100%);
            background-size:100%;
        }
    </style>

</head>
<body >


   <div class="container" style="margin-top:20px;">
       
       <div class="title">SIGN UP</div>
  <form action="#" method="post" runat="server">
    <div class="user-details">
         <div class="input-box">
        <span class="details">SPONSOR ID  &nbsp;|&nbsp;<asp:Label ID="Label1" runat="server" ForeColor="red" Font-Bold="true"></asp:Label></span>
        <asp:TextBox ID="txtsponser" runat="server" required="" class="form-control" Style="padding-left: 10px;" AutoPostBack="true" OnTextChanged="txtsponser_TextChanged" placeholder="Sponser Id"></asp:TextBox>

      </div>

                  
        <div class="input-box">
        <span class="details">USER ID</span>
      <asp:TextBox ID="TextBox2" runat="server" class="form-control" Style="padding-left: 10px;" placeholder="User ID" required></asp:TextBox>
      </div>
        <div class="input-box">
        <span class="details">NAME</span>
         <asp:TextBox ID="TextBox3" runat="server" class="form-control" Style="padding-left: 10px;" required></asp:TextBox>
      </div>
       
        <asp:TextBox ID="TextBox8" runat="server" class="form-control"  Style="padding-left: 10px;" Visible="false"></asp:TextBox>

     
       
          <div class="input-box">
        <span class="details">EMAIL ID</span>
        <asp:TextBox ID="TextBox5" runat="server" class="form-control"  Style="padding-left: 10px;" required></asp:TextBox>

      </div>
         <div class="input-box">
        <span class="details">PASSWORD</span>
        <asp:TextBox ID="TextBox4" runat="server" class="form-control"  Style="padding-left: 10px;" TextMode="Password" required></asp:TextBox>

      </div>
         <div class="input-box">
        <span class="details">CONFIRM PASSWORD</span>
        <asp:TextBox ID="TextBox21" runat="server" class="form-control"  Style="padding-left: 10px;" TextMode="Password" required></asp:TextBox>
             
      </div>
         
     <div class="input-box" style="display:none;">
        <span class="details">COUNTRY</span>
            <asp:DropDownList ID="Drpstate" runat="server"  class="form-control" Height="33px" Width="100%">
                  <asp:ListItem Selected="True">SELECT COUNTRY</asp:ListItem>    
                         
           <asp:ListItem>Afghanistan</asp:ListItem>    
<asp:ListItem>Albania</asp:ListItem>    
<asp:ListItem>Algeria</asp:ListItem>    
<asp:ListItem>Andorra</asp:ListItem>    
<asp:ListItem>Angola</asp:ListItem>    
<asp:ListItem>Antigua and Barbuda</asp:ListItem>    
<asp:ListItem>Argentina</asp:ListItem>    
<asp:ListItem>Armenia</asp:ListItem>    
<asp:ListItem>Australia</asp:ListItem>    
<asp:ListItem>Austria</asp:ListItem>    
<asp:ListItem>Azerbaijan</asp:ListItem>    
<asp:ListItem>Bahamas</asp:ListItem>    
<asp:ListItem>Bahrain</asp:ListItem>    
<asp:ListItem>Bangladesh</asp:ListItem>    
<asp:ListItem>Barbados</asp:ListItem>    
<asp:ListItem>Belarus</asp:ListItem>    
<asp:ListItem>Belgium</asp:ListItem>    
<asp:ListItem>Belize</asp:ListItem>    
<asp:ListItem>Benin</asp:ListItem>    
<asp:ListItem>Bhutan</asp:ListItem>    
<asp:ListItem>Bolivia</asp:ListItem>    
<asp:ListItem>Bosnia and Herzegovina</asp:ListItem>    
<asp:ListItem>Botswana</asp:ListItem>    
<asp:ListItem>Brazil</asp:ListItem>    
<asp:ListItem>Brunei</asp:ListItem>    
<asp:ListItem>Bulgaria</asp:ListItem>    
<asp:ListItem>Burkina Faso</asp:ListItem>    
<asp:ListItem>Burundi</asp:ListItem>    
<asp:ListItem>Cabo Verde</asp:ListItem>    
<asp:ListItem>Cambodia</asp:ListItem>    
<asp:ListItem>Cameroon</asp:ListItem>    
<asp:ListItem>Canada</asp:ListItem>    
<asp:ListItem>Central African Republic</asp:ListItem>    
<asp:ListItem>Chad</asp:ListItem>    
<asp:ListItem>Chile</asp:ListItem>    
<asp:ListItem>China</asp:ListItem>    
<asp:ListItem>Colombia</asp:ListItem>    
<asp:ListItem>Comoros</asp:ListItem>    
<asp:ListItem>Congo (Congo-Brazzaville)</asp:ListItem>    
<asp:ListItem>Costa Rica</asp:ListItem>    
<asp:ListItem>Croatia</asp:ListItem>    
<asp:ListItem>Cuba</asp:ListItem>    
<asp:ListItem>Cyprus</asp:ListItem>    
<asp:ListItem>Czechia (Czech Republic)</asp:ListItem>    
<asp:ListItem>Democratic Republic of the Congo</asp:ListItem>    
<asp:ListItem>Denmark</asp:ListItem>    
<asp:ListItem>Djibouti</asp:ListItem>    
<asp:ListItem>Dominica</asp:ListItem>    
<asp:ListItem>Dominican Republic</asp:ListItem>    
<asp:ListItem>Ecuador</asp:ListItem>    
<asp:ListItem>Egypt</asp:ListItem>    
<asp:ListItem>El Salvador</asp:ListItem>    
<asp:ListItem>Equatorial Guinea</asp:ListItem>    
<asp:ListItem>Eritrea</asp:ListItem>    
<asp:ListItem>Estonia</asp:ListItem>    
<asp:ListItem>Eswatini (fmr. "Swaziland")</asp:ListItem>
<asp:ListItem>Ethiopia</asp:ListItem>    
<asp:ListItem>Fiji</asp:ListItem>    
<asp:ListItem>Finland</asp:ListItem>    
<asp:ListItem>France</asp:ListItem>    
<asp:ListItem>Gabon</asp:ListItem>    
<asp:ListItem>Gambia</asp:ListItem>    
<asp:ListItem>Georgia</asp:ListItem>    
<asp:ListItem>Germany</asp:ListItem>    
<asp:ListItem>Ghana</asp:ListItem>    
<asp:ListItem>Greece</asp:ListItem>    
<asp:ListItem>Grenada</asp:ListItem>    
<asp:ListItem>Guatemala</asp:ListItem>    
<asp:ListItem>Guinea</asp:ListItem>    
<asp:ListItem>Guinea-Bissau</asp:ListItem>    
<asp:ListItem>Guyana</asp:ListItem>    
<asp:ListItem>Haiti</asp:ListItem>    
<asp:ListItem>Holy See</asp:ListItem>    
<asp:ListItem>Honduras</asp:ListItem>    
<asp:ListItem>Hungary</asp:ListItem>    
<asp:ListItem>Iceland</asp:ListItem>    
<asp:ListItem>India</asp:ListItem>    
<asp:ListItem>Indonesia</asp:ListItem>    
<asp:ListItem>Iran</asp:ListItem>    
<asp:ListItem>Iraq</asp:ListItem>    
<asp:ListItem>Ireland</asp:ListItem>    
<asp:ListItem>Israel</asp:ListItem>    
<asp:ListItem>Italy</asp:ListItem>    
<asp:ListItem>Jamaica</asp:ListItem>    
<asp:ListItem>Japan</asp:ListItem>    
<asp:ListItem>Jordan</asp:ListItem>    
<asp:ListItem>Kazakhstan</asp:ListItem>    
<asp:ListItem>Kenya</asp:ListItem>    
<asp:ListItem>Kiribati</asp:ListItem>    
<asp:ListItem>Kuwait</asp:ListItem>    
<asp:ListItem>Kyrgyzstan</asp:ListItem>    
<asp:ListItem>Laos</asp:ListItem>    
<asp:ListItem>Latvia</asp:ListItem>    
<asp:ListItem>Lebanon</asp:ListItem>    
<asp:ListItem>Lesotho</asp:ListItem>    
<asp:ListItem>Liberia</asp:ListItem>    
<asp:ListItem>Libya</asp:ListItem>    
<asp:ListItem>Liechtenstein</asp:ListItem>    
<asp:ListItem>Lithuania</asp:ListItem>    
<asp:ListItem>Luxembourg</asp:ListItem>    
<asp:ListItem>Madagascar</asp:ListItem>    
<asp:ListItem>Malawi</asp:ListItem>    
<asp:ListItem>Malaysia</asp:ListItem>    
<asp:ListItem>Maldives</asp:ListItem>    
<asp:ListItem>Mali</asp:ListItem>    
<asp:ListItem>Malta</asp:ListItem>    
<asp:ListItem>Marshall Islands</asp:ListItem>    
<asp:ListItem>Mauritania</asp:ListItem>    
<asp:ListItem>Mauritius</asp:ListItem>    
<asp:ListItem>Mexico</asp:ListItem>    
<asp:ListItem>Micronesia</asp:ListItem>    
<asp:ListItem>Moldova</asp:ListItem>    
<asp:ListItem>Monaco</asp:ListItem>    
<asp:ListItem>Mongolia</asp:ListItem>    
<asp:ListItem>Montenegro</asp:ListItem>    
<asp:ListItem>Morocco</asp:ListItem>    
<asp:ListItem>Mozambique</asp:ListItem>    
<asp:ListItem>Myanmar (formerly Burma)</asp:ListItem>    
<asp:ListItem>Namibia</asp:ListItem>    
<asp:ListItem>Nauru</asp:ListItem>    
<asp:ListItem>Nepal</asp:ListItem>    
<asp:ListItem>Netherlands</asp:ListItem>    
<asp:ListItem>New Zealand</asp:ListItem>    
<asp:ListItem>Nicaragua</asp:ListItem>    
<asp:ListItem>Niger</asp:ListItem>    
<asp:ListItem>Nigeria</asp:ListItem>    
<asp:ListItem>North Korea</asp:ListItem>    
<asp:ListItem>North Macedonia</asp:ListItem>    
<asp:ListItem>Norway</asp:ListItem>    
<asp:ListItem>Oman</asp:ListItem>    
<asp:ListItem>Pakistan</asp:ListItem>    
<asp:ListItem>Palau</asp:ListItem>    
<asp:ListItem>Palestine State</asp:ListItem>    
<asp:ListItem>Panama</asp:ListItem>    
<asp:ListItem>Papua New Guinea</asp:ListItem>    
<asp:ListItem>Paraguay</asp:ListItem>    
<asp:ListItem>Peru</asp:ListItem>    
<asp:ListItem>Philippines</asp:ListItem>    
<asp:ListItem>Poland</asp:ListItem>    
<asp:ListItem>Portugal</asp:ListItem>    
<asp:ListItem>Qatar</asp:ListItem>    
<asp:ListItem>Romania</asp:ListItem>    
<asp:ListItem>Russia</asp:ListItem>    
<asp:ListItem>Rwanda</asp:ListItem>    
<asp:ListItem>Saint Kitts and Nevis</asp:ListItem>    
<asp:ListItem>Saint Lucia</asp:ListItem>    
<asp:ListItem>Saint Vincent and the Grenadines</asp:ListItem>   
<asp:ListItem>Samoa</asp:ListItem>    
<asp:ListItem>San Marino</asp:ListItem>    
<asp:ListItem>Sao Tome and Principe</asp:ListItem>    
<asp:ListItem>Saudi Arabia</asp:ListItem>    
<asp:ListItem>Senegal</asp:ListItem>    
<asp:ListItem>Serbia</asp:ListItem>    
<asp:ListItem>Seychelles</asp:ListItem>    
<asp:ListItem>Sierra Leone</asp:ListItem>    
<asp:ListItem>Singapore</asp:ListItem>    
<asp:ListItem>Slovakia</asp:ListItem>    
<asp:ListItem>Slovenia</asp:ListItem>    
<asp:ListItem>Solomon Islands</asp:ListItem>    
<asp:ListItem>Somalia</asp:ListItem>    
<asp:ListItem>South Africa</asp:ListItem>    
<asp:ListItem>South Korea</asp:ListItem>    
<asp:ListItem>South Sudan</asp:ListItem>    
<asp:ListItem>Spain</asp:ListItem>    
<asp:ListItem>Sri Lanka</asp:ListItem>    
<asp:ListItem>Sudan</asp:ListItem>    
<asp:ListItem>Suriname</asp:ListItem>    
<asp:ListItem>Sweden</asp:ListItem>    
<asp:ListItem>Switzerland</asp:ListItem>    
<asp:ListItem>Syria</asp:ListItem>    
<asp:ListItem>Tajikistan</asp:ListItem>    
<asp:ListItem>Tanzania</asp:ListItem>    
<asp:ListItem>Thailand</asp:ListItem>    
<asp:ListItem>Timor-Leste</asp:ListItem>    
<asp:ListItem>Togo</asp:ListItem>    
<asp:ListItem>Tonga</asp:ListItem>    
<asp:ListItem>Trinidad and Tobago</asp:ListItem>    
<asp:ListItem>Tunisia</asp:ListItem>    
<asp:ListItem>Turkey</asp:ListItem>    
<asp:ListItem>Turkmenistan</asp:ListItem>    
<asp:ListItem>Tuvalu</asp:ListItem>    
<asp:ListItem>Uganda</asp:ListItem>    
<asp:ListItem>Ukraine</asp:ListItem>    
<asp:ListItem>United Arab Emirates</asp:ListItem>    
<asp:ListItem>United Kingdom</asp:ListItem>    
<asp:ListItem>United States of America</asp:ListItem>    
<asp:ListItem>Uruguay</asp:ListItem>    
<asp:ListItem>Uzbekistan</asp:ListItem>    
<asp:ListItem>Vanuatu</asp:ListItem>    
<asp:ListItem>Venezuela</asp:ListItem>    
<asp:ListItem>Vietnam</asp:ListItem>    
<asp:ListItem>Yemen</asp:ListItem>    
<asp:ListItem>Zambia</asp:ListItem>    
<asp:ListItem>Zimbabwe</asp:ListItem>    

           
            </asp:DropDownList>
       
             
      </div>
      
        </div>
              
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control"  Visible="false" Style="padding-left: 10px;" ></asp:TextBox>
                <%-- <asp:TextBox ID="TextBox21" runat="server"  class="form-control" Visible="false"  Style="padding-left: 10px;"></asp:TextBox>--%>
              
                 
                            <div class="button">
                            <asp:Button ID="Button1" runat="server"  OnClientClick="return CheckDouble();"  BackColor="#009933" BorderStyle="None" ForeColor="White"   Text="Sign up" OnClick="Button5_Click" Width="100px"  />
                               
 <a href="login.aspx" style="background-color: orangered; color: white; padding: 12px 25px; width: 50%; border-radius:6px;">Login</a>
                            </div>
                <br />

       <asp:Label ID="password" runat="server" Visible="false"></asp:Label><asp:Label ID="txnpassword" runat="server" Visible="false"></asp:Label>
            </form>
         
       
    </div>
    <!-- jQuery if needed -->
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $(".showpassword").each(function (index, input) {
                var $input = $(input);
                $("<p class='opt'/>").append(
                    $("<input type='checkbox' class='showpasswordcheckbox' id='showPassword' />").click(function () {
                        var change = $(this).is(":checked") ? "text" : "password";
                        var rep = $("<input placeholder='Password' type='" + change + "' />")
                            .attr("id", $input.attr("id"))
                            .attr("name", $input.attr("name"))
                            .attr('class', $input.attr('class'))
                            .val($input.val())
                            .insertBefore($input);
                        $input.remove();
                        $input = rep;
                    })
                ).append($("<label for='showPassword'/>").text("Show password")).insertAfter($input.parent());
            });

            $('#showPassword').click(function () {
                if ($("#showPassword").is(":checked")) {
                    $('.icon-lock').addClass('icon-unlock');
                    $('.icon-unlock').removeClass('icon-lock');
                } else {
                    $('.icon-unlock').addClass('icon-lock');
                    $('.icon-lock').removeClass('icon-unlock');
                }
            });
        });
    </script>
    <div>
    </div>



</body>
</html>
