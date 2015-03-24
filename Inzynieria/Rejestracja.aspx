<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Rejestracja.aspx.cs" Inherits="Rejestracja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>REJESTRACJA</h2>
    <asp:Label ID="lblBlad" runat="server" Text="" Visible="False" ForeColor="Red"></asp:Label>
    <br />
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>Login: </asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="tbLogin" Text=""></asp:TextBox></asp:TableCell>
            <asp:TableCell> <asp:RequiredFieldValidator ID="LoginValidator" runat="server" ErrorMessage="Pole wymagane!" ControlToValidate="tbLogin"></asp:RequiredFieldValidator></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Hasło: </asp:TableCell>
            <asp:TableCell><asp:TextBox ID="tbPass" runat="server" TextMode="Password" Text=""></asp:TextBox></asp:TableCell>
            <asp:TableCell><asp:RequiredFieldValidator ID="PassValidator" runat="server" ErrorMessage="Pole wymagane!" ControlToValidate="tbPass"></asp:RequiredFieldValidator></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Imie: </asp:TableCell>
            <asp:TableCell><asp:TextBox ID="tbImie" runat="server" Text=""></asp:TextBox></asp:TableCell>
            <asp:TableCell> <asp:RequiredFieldValidator ID="ImieValidator" runat="server" ErrorMessage="Pole wymagane!" ControlToValidate="tbImie"></asp:RequiredFieldValidator></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Nazwisko: </asp:TableCell>
            <asp:TableCell><asp:TextBox ID="TbNazwisko" runat="server" Text=""></asp:TextBox></asp:TableCell>
            <asp:TableCell> <asp:RequiredFieldValidator ID="NazwiskoValidator" runat="server" ErrorMessage="Pole wymagane!" ControlToValidate="TbNazwisko"></asp:RequiredFieldValidator></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
<asp:Button ID="bRejestruj" runat="server" Text="Rejestracja" OnClick="bRejestruj_Click" />
</asp:Content>