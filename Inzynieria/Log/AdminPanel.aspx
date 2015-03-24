<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminPanel.aspx.cs" Inherits="Log_AdminPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Witaj Adminie!<br />
        <div>
            <asp:Button ID="Dodaj_uzytkownika" runat="server" Text="Dodaj użytkownika" style="margin: 2px 2px 2px 2px; " OnClick="Dodaj_uzytkownika_Click"/>
            <asp:Button ID="Zmien_uprwanienia" runat="server" Text="Zmień uprawnienia" style="margin:2px 2px 2px 2px; " OnClick="Zmien_uprwanienia_Click"/> 
            <asp:Button ID="Dodaj_usługę" runat="server" Text="Dodaj usługę" Style="margin:2px 2px 2px 2px" OnClick="Dodaj_usługę_Click" />
            <asp:Button ID="Dodaj_pokoj" runat="server" Text="Dodaj pokoj" Style="margin:2px 2px 2px 2px;" OnClick="Dodaj_pokoj_Click" />
        </div>
        <asp:Label ID="lblwynik" runat="server" Text="" Visible="false"></asp:Label>
        <br />
        <div>
        <asp:Panel ID="PanelUzyt" runat="server" Visible="False">
            <asp:table runat="server">
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="tblogin" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="tbpass" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label3" runat="server" Text="Label3"></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="tbgroup" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label4" runat="server" Text="Label4"></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="tbfname" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label5" runat="server" Text="Label5"></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="tblname" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:ListBox ID="ListaUslug" runat="server" Visible="false"></asp:ListBox></asp:TableCell>
                </asp:TableRow>
            </asp:table>
        </asp:Panel>
            <asp:Button ID="bZatwierdz" runat="server" Text="Zatwierdź" Style="margin: 2px 2px 2px 2px;" OnClick="bZatwierdz_Click" Visible="False"/>
        </div>
    </div>
    </form>
    <asp:Label ID="Wybor" runat="server" Text="" Visible="false"></asp:Label>
</body>
</html>
