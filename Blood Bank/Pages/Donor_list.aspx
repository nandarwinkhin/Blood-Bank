<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Donor_list.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="Blood_Bank.Pages.Donor_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>Donor List</h2>
        <form>
            
            <asp:GridView ID="GridView1" runat="server" BorderWidth="1px" CellPadding="4" >
            </asp:GridView>
        </form>
        
     </center>
</asp:Content>