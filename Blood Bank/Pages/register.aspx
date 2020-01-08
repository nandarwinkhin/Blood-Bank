<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="register.aspx.cs" Inherits="Blood_Bank.Pages.register" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
     <h2>Register on Blood Bank</h2>
    <asp:CheckBox ID="chkavailable" runat="server" Text="Set available in donor list"></asp:CheckBox>
    <table style="width:500px auto; vertical-align:middle;">
        <tr>
            <td class="auto-style3"> 
                <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
             </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtRname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRName" ErrorMessage="* Required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
               
            </td>
            </tr>
        <tr>
            <td>
                 <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label>
             </td>
            <td class="auto-style1">
                 <asp:RadioButtonList ID="rblRgender" runat="server" Width="170px" RepeatDirection="Horizontal" RepeatLayout="Flow">
                     <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                     <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                 </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="rblRgender" ErrorMessage="* Required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="lblgroup" runat="server" Text="Blood Group"></asp:Label>

            </td>
            <td class="auto-style1">

                <asp:DropDownList ID="ddlRgroup" runat="server">
                    <asp:ListItem Text="O-" Value="1"></asp:ListItem>
                    <asp:ListItem Text="O+" Value="2"></asp:ListItem>
                    <asp:ListItem Text="A-" Value="3"></asp:ListItem>
                    <asp:ListItem Text="A+" Value="4"></asp:ListItem>
                    <asp:ListItem Text="B-" Value="5"></asp:ListItem>
                    <asp:ListItem Text="B+" Value="6"></asp:ListItem>
                    <asp:ListItem Text="AB-" Value="7"></asp:ListItem>
                    <asp:ListItem Text="AB+" Value="8"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlRgroup" ErrorMessage="* Required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td class="auto-style2">

                <asp:Label ID="Label1" runat="server" Text="Date of Birth"></asp:Label>

            </td>
            <td class="auto-style2">
                 <asp:TextBox ID="txtRDob" runat="server" Enabled="false"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtRDob" ErrorMessage="* Required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator><br />

                Month:<asp:DropDownList id="drpCalMonth" Runat="Server" OnSelectedIndexChanged="Set_Calendar" AutoPostBack="true"></asp:DropDownList>
                Year:<asp:DropDownList id="drpCalYear" Runat="Server" OnSelectedIndexChanged="Set_Calendar" AutoPostBack="true"></asp:DropDownList>
                <asp:Calendar ID="CalendarDOB" runat="server" OnSelectionChanged="CalendarDOB_SelectionChanged" SelectionMode="DayWeekMonth" ></asp:Calendar>
            </td>
               


        </tr>
        <tr>
            <td>

                <asp:Label ID="Label2" runat="server" Text="Last Blood Donation Date"></asp:Label>

            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtRlastbdd" runat="server" Enabled="false"></asp:TextBox>
                <br />

                Month:<asp:DropDownList id="DropDownList3" Runat="Server" OnSelectedIndexChanged="Set_Calendar2" AutoPostBack="true"></asp:DropDownList>
                Year:<asp:DropDownList id="DropDownList4" Runat="Server" OnSelectedIndexChanged="Set_Calendar2" AutoPostBack="true"></asp:DropDownList>
                 <asp:Calendar ID="CalendarLastbdd" runat="server" SelectionMode="DayWeekMonth" OnSelectionChanged="CalendarLastbdd_SelectionChanged"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Which hospitals you can go(for blood donation) anytime?"></asp:Label>
            </td>
            <td>
                <div style="text-align:left">
                    <asp:CheckBox ID="hospital1" runat="server" Text="Monywa General Hospital"></asp:CheckBox><br />
                    <asp:CheckBox ID="hospital2" runat="server" Text="Shwe Taw Win Hospital"></asp:CheckBox><br />
                    <asp:CheckBox ID="hospital3" runat="server" Text="Metta Oo Hospital"></asp:CheckBox><br />
                    <asp:CheckBox ID="hospital4" runat="server" Text="Zar Ni Htun Hospital"></asp:CheckBox><br />
                    <asp:CheckBox ID="hospital5" runat="server" Text="So Pyay Hospital"></asp:CheckBox><br />
                    <asp:CheckBox ID="hospital6" runat="server" Text="Phyusin Myintta Hospital"></asp:CheckBox><br />
                    <asp:CheckBox ID="hospital7" runat="server" Text="Ka Yu Nar Myint Moh"></asp:CheckBox><br />
                    <asp:CheckBox ID="hospital8" runat="server" Text="200Bedded Women and Children Hospital Monywa"></asp:CheckBox>     
                </div>
               
            </td>
        </tr>
        <tr>
            <td>
                
                <asp:Label ID="Label3" runat="server" Text="Your body weight is above 40kg or 100lb?"></asp:Label>
                
            </td>
            <td class="auto-style1">

                <asp:RadioButtonList ID="rblRweight" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <asp:ListItem Text="YES" Value="Yes"></asp:ListItem>
                    <asp:ListItem Text="NO" Value="No"></asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="rblRweight" ErrorMessage="* Required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>
                <asp:label runat="server" text="Email"></asp:label>
            </td>
            <td class="auto-style1">
                <asp:textbox ID="txtRemial" runat="server" TextMode="Email"></asp:textbox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtRemial" ErrorMessage="* Required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:label runat="server" text="Phone number" ></asp:label>
               
            </td>
            <td class="auto-style1">
                <asp:textbox ID="txtRphone" runat="server" TextMode="Phone"></asp:textbox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtRphone" ErrorMessage="* Required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>

            </td>
            <td class="auto-style1">

                <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtpass" ErrorMessage="* Required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>

            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="button"/>
    </center>
</asp:Content>
    
