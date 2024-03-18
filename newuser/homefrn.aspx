<%@ Page Title="" Language="C#" MasterPageFile="~/newuser/masterfrn_new.master" AutoEventWireup="true" CodeFile="homefrn.aspx.cs" Inherits="newuser_homefrn_new" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="ajax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
     <div class="flex justify-between flex-wrap items-center mb-6">
                  <h4 class="font-medium lg:text-2xl text-xl capitalize text-slate-900 inline-block ltr:pr-4 rtl:pl-4 mb-4 sm:mb-0 flex space-x-3 rtl:space-x-reverse">Dashboard</h4>
                  <div class="flex sm:space-x-4 space-x-2 sm:justify-end items-center rtl:space-x-reverse">
                    <button class="btn leading-0 inline-flex justify-center bg-white text-slate-700 dark:bg-slate-800 dark:text-slate-300 !font-normal">
                      <span class="flex items-center">
                        <iconify-icon class="text-xl ltr:mr-2 rtl:ml-2 font-light" icon="heroicons-outline:user"></iconify-icon>
                        <span>
                            <asp:Label ID="Label1" runat="server" Text="Active"></asp:Label></span>
                      </span>
                    </button>
                    <button class="btn leading-0 inline-flex justify-center bg-white text-slate-700 dark:bg-slate-800 dark:text-slate-300 !font-normal">
                      <span class="flex items-center">
                        <iconify-icon class="text-xl ltr:mr-2 rtl:ml-2 font-light" icon="heroicons-outline:user"></iconify-icon>
                        <span> <asp:Label ID="Label2" runat="server" Text="Not Active"></asp:Label></span>
                      </span>
                    </button>
                      <asp:Button ID="Button1" Visible="false" runat="server" Text=" Pending Boosting " BackColor="Red" OnClick="Button1_Click1" ForeColor="White" />
                  </div>
                </div>
  <marquee direction="left" scrollamount="10" scrolldelay="300"><b style="color:red;">Latest News:- </b> <asp:Label ID="news" runat="server" ></asp:Label></marquee>

      <marquee direction="left" scrollamount="10" scrolldelay="300"><b style="color:red;"></b> <asp:Label ID="Label6" runat="server" Visible="false" ></asp:Label></marquee>
    <div   >
        Referral Link
                   <input type="text" value="https://www.profitpulsefx.com/register.aspx?SID=<%=Session["newuser"].ToString() %>" id="myInput" style="height:38px;"  class="form-control">
                    <span class="input-group-append">
                        <button onclick="myFunction()" class="btn btn-info btn-flat">Copy Referral Link</button>

                    </span>
                </div>
    <br />
                <div class="grid grid-cols-12 gap-5 mb-5">
                  <div class="2xl:col-span-3 lg:col-span-4 col-span-12" height="130px">
                    <div class="bg-no-repeat bg-cover bg-center p-4 rounded-[6px] relative" style="background-image: url(assets/images/all-img/widget-bg-1.png)">
                      <div class="max-w-[180px]">
                        <div class="text-xl font-medium text-slate-900 mb-2">
                         Hurry Up! <br />Active Your Id
                        </div>
                        <p class="text-sm text-slate-800">
                          To get wonderfull income
                        </p>
                      </div>
                      <div class="absolute top-1/2 -translate-y-1/2 ltr:right-6 rtl:left-6 mt-2 h-12 w-12 bg-white rounded-full text-xs font-medium
                            flex flex-col items-center justify-center">
                        Now
                      </div>
                    </div>
                  </div>
                  <div class="2xl:col-span-9 lg:col-span-8 col-span-12">
                    <div class="p-4 card">
                      <div class="grid md:grid-cols-3 col-span-1 gap-4">

                        <!-- BEGIN: Group Chart2 -->


                        <div class="py-[18px] px-3 rounded-[6px] bg-[#E5F9FF] dark:bg-slate-900	 " onClick="window.open('account.aspx');">
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-usd fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                Wallet
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                  <asp:Label ID="Label4" runat="server" ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>
						
						

                        <div class="py-[18px] px-4 rounded-[6px] bg-[#FFEDE5] dark:bg-slate-900	 ">
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-usd fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                Withdrawal
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                  <asp:Label ID="Label3" runat="server" ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>

                        <div class="py-[18px] px-4 rounded-[6px] bg-[#EAE5FF] dark:bg-slate-900	 " onClick="window.open('account.aspx');">
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-usd fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                Daily Profit
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                 <asp:Label ID="lbl_team" runat="server" ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>

                        <!-- END: Group Chart2 -->
                      </div>
                    </div>
                  </div>
                </div>
				<div class="grid grid-cols-12 ">
                  
                  <div class="2xl:col-span-12 lg:col-span-12 col-span-12">
                    <div class="p-3 card">
                      <div class="grid md:grid-cols-4 col-span-1 gap-3">

                        <!-- BEGIN: Group Chart2 -->


                        <div class="py-[18px] px-3 rounded-[6px] bg-[#E5F9FF] dark:bg-slate-900	 " onClick="window.open('account.aspx');">
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-usd fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                Level Income
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                  <asp:Label ID="lbl_levelbonus" runat="server" ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>
						
						
						

                       

                           <div class="py-[18px] px-3 rounded-[6px] bg-[#FFEDE5] dark:bg-slate-900	 " onClick="window.open('account.aspx');">
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-usd fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                Total Income
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                <asp:Label ID="lbl_totalincome" runat="server" ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>

                        <div class="py-[18px] px-3 rounded-[6px] bg-[#EAE5FF] dark:bg-slate-900	 " >
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-usd fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                Available Fund
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                <asp:Label ID="lbl_availablefund" runat="server" ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>

                           <div class="py-[18px] px-3 rounded-[6px] bg-[#FFEDE5] dark:bg-slate-900	 " >
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                My Reward Rank
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                <asp:Label ID="lbl_starincome" runat="server" ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>
                            <div class="py-[18px] px-3 rounded-[6px] bg-[#FFEDE5] dark:bg-slate-900	 " >
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                My Package
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                <asp:Label ID="Label7" runat="server" ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>

                        <!-- END: Group Chart2 -->
                      </div>
                    </div>
                  </div>
                </div>
				
				
				<div class="grid grid-cols-12 ">
                  
                  <div class="2xl:col-span-12 lg:col-span-12 col-span-12">
                    <div class="p-3 card">
                      <div class="grid md:grid-cols-4 col-span-1 gap-3">

                        <!-- BEGIN: Group Chart2 -->


                        <div class="py-[18px] px-3 rounded-[6px] bg-[#E5F9FF] dark:bg-slate-900	 ">
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-calendar fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                Joining Date
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                            <asp:Label ID="join_date" runat="server"   ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>
                           <div class="py-[18px] px-3 rounded-[6px] bg-[#E5F9FF] dark:bg-slate-900	 ">
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-calendar fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                Activation Date
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                            <asp:Label ID="Label5" runat="server" ></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>
						 <div class="py-[18px] px-3 rounded-[6px] bg-[#E5F9FF] dark:bg-slate-900	 ">
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-users fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                My Team
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                  <asp:Label ID="lbl_myteam" runat="server"></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>
						
						

                        <div class="py-[18px] px-3 rounded-[6px] bg-[#FFEDE5] dark:bg-slate-900	 ">
                          <div class="flex items-center space-x-6 rtl:space-x-reverse">
                            <div class="flex-none">
                               <i class="fa fa-users fa-2x" aria-hidden="true"></i>
                            </div>
                            <div class="flex-1">
                              <div class="text-slate-800 dark:text-slate-300 text-sm mb-1 font-medium">
                                My Directs
                              </div>
                              <div class="text-slate-900 dark:text-white text-lg font-medium">
                                <asp:Label ID="lbl_mydirect" runat="server"></asp:Label>
                              </div>
                            </div>
                          </div>
                        </div>
                          
                          

                      

                        <!-- END: Group Chart2 -->
                      </div>
                        
                    </div>
                  </div>
                </div>
                 <script>
                     function myFunction() {
                         /* Get the text field */
                         var copyText = document.getElementById("myInput");

                         /* Select the text field */
                         copyText.select();
                         copyText.setSelectionRange(0, 99999); /* For mobile devices */

                         /* Copy the text inside the text field */
                         navigator.clipboard.writeText(copyText.value);

                         /* Alert the copied text */
                         //alert("Copied the text: " + copyText.value);
                     }
</script>
    

    
     
</asp:Content>

