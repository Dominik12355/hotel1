<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Logowanie.aspx.cs" Inherits="Logowanie" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>LOGOWANIE</h2>
    <br />
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>Login:</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="tbLogin" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Password:</asp:TableCell>
            <asp:TableCell> <asp:TextBox ID="tbPass" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="bLoguj" runat="server" Text="Zaloguj" OnClick="bLoguj_Click" />
</asp:Content>

