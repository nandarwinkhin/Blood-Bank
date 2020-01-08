<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="your_account.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="Blood_Bank.Pages.your_account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            height: 220px;
        }
        .auto-style3 {
            height: 29px;
        }
        .auto-style4 {
            width: 140px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
     <h2>Your account</h2>
        <asp:Label ID="lblsafeToDonate" runat="server" Text=" "></asp:Label><br /><br />
        <asp:CheckBox ID="chkavailable" runat="server" Text="Set available in donor list"></asp:CheckBox><br />

        <asp:Label ID="lbl_test" runat="server" Text=" "></asp:Label>
    <table style="width:500px auto; vertical-align:middle;">
        <tr>
            <td class="auto-style3"> 
                <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
             </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtRname" runat="server" ></asp:TextBox>
                
               
            </td>
            </tr>
        <tr>
            <td>
                 <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label>
             </td>
            <td class="auto-style1">
                 
                 <asp:RadioButtonList ID="rblRgender" runat="server" Width="170px" RepeatDirection="Horizontal" RepeatLayout="Flow" >
                     <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                     <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                 </asp:RadioButtonList>
                
            </td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="lblgroup" runat="server" Text="Blood Group"></asp:Label>

            </td>
            <td class="auto-style1">
               <asp:TextBox ID="txtBloodGroup" runat="server" ></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="auto-style2">

                <asp:Label ID="Label1" runat="server" Text="Date of Birth"></asp:Label>

            </td>
            <td class="auto-style2">
                 <asp:TextBox ID="txtRDob" runat="server" Enabled="false" ></asp:TextBox><br />

                Month:<asp:DropDownList id="drpCalMonth" Runat="Server" OnSelectedIndexChanged="Set_Calendar" AutoPostBack="true"></asp:DropDownList>
                Year:<asp:DropDownList id="drpCalYear" Runat="Server" OnSelectedIndexChanged="Set_Calendar" AutoPostBack="true"></asp:DropDownList>
                <asp:Calendar ID="CalendarDOB" runat="server" SelectionMode="DayWeekMonth" OnSelectionChanged="CalendarDOB_SelectionChanged" ></asp:Calendar>
            </td>
               


        </tr>
        <%--<tr>
            <td>

                <asp:Label ID="Label2" runat="server" Text="Last Blood Donation Date"></asp:Label>

            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtRlastbdd" runat="server" Enabled="false" ></asp:TextBox>
                
                 <asp:Calendar ID="CalendarLastbdd" runat="server" SelectionMode="DayWeekMonth"></asp:Calendar>
            </td>
        </tr>--%>
        
        <tr>
            <td>
                
                <asp:Label ID="Label3" runat="server" Text="Your body weight is above 40kg or 100lb?"></asp:Label>
                
            </td>
            <td class="auto-style1">

                <asp:RadioButtonList ID="rblRweight" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" >
                    <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                    <asp:ListItem Text="No" Value="No"></asp:ListItem>
                </asp:RadioButtonList>
                

            </td>
        </tr>
        <tr>
            <td>
                <asp:label ID="Label5" runat="server" text="Email"></asp:label>
            </td>
            <td class="auto-style1">
                <asp:textbox ID="txtRemial" runat="server" TextMode="Email"></asp:textbox>
                 
            </td>
        </tr>
        <tr>
            <td>
                <asp:label ID="Label6" runat="server" text="Phone number" ></asp:label>
               
            </td>
            <td class="auto-style1">
                <asp:textbox ID="txtRphone" runat="server" TextMode="Phone"></asp:textbox>
                 
            </td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="Label7" runat="server" Text="Password"></asp:Label>

            </td>
            <td class="auto-style1">

                <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
                 

            </td>
        </tr>
    </table>
        <br /><br />
        <%--<asp:CheckBox ID="donated" runat="server" Text="I have donated blood" OnCheckedChanged="donated_CheckedChanged" />--%>
        
        
        
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" CssClass="button" /><br />
        <asp:Label ID="lblUpdateInfo" runat="server" Visible="false"></asp:Label>
        <br />
        <br />
        <br />
        <h3>After eyery blood donation,please update following information.</h3>
        <asp:Panel ID="donated_panel" runat="server">
            
         <table id="donated_table">
             <tr>
                 <td class="auto-style4">

                    <asp:Label ID="Label4" runat="server" Text="Last blood donation Date"></asp:Label>
                
                </td>
                <td>
                    <asp:TextBox ID="txtdate" runat="server"></asp:TextBox><br />

                    Month:<asp:DropDownList id="DropDownList3" Runat="Server" OnSelectedIndexChanged="Set_Calendar2" AutoPostBack="true"></asp:DropDownList>
                    Year:<asp:DropDownList id="DropDownList4" Runat="Server" OnSelectedIndexChanged="Set_Calendar2" AutoPostBack="true"></asp:DropDownList>
                    <asp:Calendar ID="donated_date" runat="server" OnSelectionChanged="donated_date_SelectionChanged1"></asp:Calendar>
                </td>

            </tr>
             <tr>
                 <td class="auto-style4">

                    <asp:Label ID="Label8" runat="server" Text="Hospital"></asp:Label>
                </td>
                 <td>
                   <asp:DropDownList ID="donated_hospital" runat="server">
                    <asp:ListItem Text="Monywa General Hospital" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Shwe Taw Win Hospital" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Metta Oo Hospital" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Zar Ni Htun Hospital" Value="4"></asp:ListItem>
                    <asp:ListItem Text="So Pyay Hospital" Value="5"></asp:ListItem>
                    <asp:ListItem Text="Phyusin Myintta Hospital" Value="6"></asp:ListItem>
                    <asp:ListItem Text="Ka Yu Nar Myint Moh" Value="7"></asp:ListItem>
                    <asp:ListItem Text="200Bedded Women and Children Hospital Monywa" Value="8"></asp:ListItem>
                    </asp:DropDownList>     
                 </td>
             </tr>
             </table>  
            <asp:Button ID="donated_button" runat="server" Text="Confirm" CssClass="button" OnClick="donated_button_Click"></asp:Button><br /> 
            <asp:Label ID="lblUpdateLastbdd" runat="server" Text="Label" Visible="false"></asp:Label>
        </asp:Panel>
    </center>
</asp:Content>
