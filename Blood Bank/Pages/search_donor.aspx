<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search_donor.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="Blood_Bank.Pages.search_donor" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h2>Search a Donor</h2>
       <div>
        <table style="width:500px">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Blood Group"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlBloodGroup" runat="server">
                        <asp:ListItem Text="O-" Value="1"></asp:ListItem>
                        <asp:ListItem Text="O+" Value="2"></asp:ListItem>
                        <asp:ListItem Text="A-" Value="3"></asp:ListItem>
                        <asp:ListItem Text="A+" Value="4"></asp:ListItem>
                        <asp:ListItem Text="B-" Value="5"></asp:ListItem>
                        <asp:ListItem Text="B+" Value="6"></asp:ListItem>
                        <asp:ListItem Text="AB-" Value="7"></asp:ListItem>
                        <asp:ListItem Text="AB+" Value="8"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Hospital"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlhospital" runat="server">
                        <asp:ListItem Text="Monywa General Hospital" Value="hospital1"></asp:ListItem>
                        <asp:ListItem Text="Shwe Taw Win Hospital" Value="hospital2"></asp:ListItem>
                        <asp:ListItem Text="Metta Oo Hospital" Value="hospital3"></asp:ListItem>
                        <asp:ListItem Text="Zar Ni Htun Hospital" Value="hospital4"></asp:ListItem>
                        <asp:ListItem Text="So Pyay Hospital" Value="hospital5"></asp:ListItem>
                        <asp:ListItem Text="Phyusin Myintta Hospital" Value="hospital6"></asp:ListItem>
                        <asp:ListItem Text="Ka Yu Nar Myint Moh" Value="hospital7"></asp:ListItem>
                        <asp:ListItem Text="200Bedded Women and Children Hospital Monywa" Value="hospital8"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
           <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnSearch_Click"  CssClass="button"/>
     </div>
    </center>

</asp:Content>