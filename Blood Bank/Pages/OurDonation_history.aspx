<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OurDonation_history.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="Blood_Bank.Pages.OurDonation_history" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <form id="form1">
            <asp:GridView ID="gridHistory" runat="server" BorderWidth="1px" CellPadding="4"></asp:GridView>
        </form>
    </center>
 </asp:Content>   