<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="Blood_Bank.Pages.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 77px;
        }
        .auto-style2 {
            width: 142px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>Donor Login</h2><a href="login.aspx">login.aspx</a>
        <table style="width:500px">
            <tr>
                <td>

                    <asp:Label ID="Label1" runat="server" Text="Email or Phone"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="txtLphoremail" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>

                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="txtLpass" runat="server" TextMode="Password"></asp:TextBox>

                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="button"/>



        
      
            
        <br />

        <asp:Label ID="lblError" runat="server" Text="" CssClass="err-style1" />

        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Don't have an account?"></asp:Label>
        <asp:Button ID="link_register" runat="server" Text="Register" CssClass="button" OnClick="link_register_Click"></asp:Button>   
    </center>
</asp:Content>