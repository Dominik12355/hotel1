<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="AddRoom.aspx.cs" Inherits="Log_AddRoom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListBox ID="ListBox1" runat="server" DataSourceID="Obsluga" DataTextField="Nr_pokoju" DataValueField="Nr_pokoju"></asp:ListBox>
    <asp:LinqDataSource ID="Obsluga" runat="server" ContextTypeName="ObslugaDataContext" EntityTypeName="" Select="new (Nr_pokoju, Rodzaj)" TableName="Pokojes" OrderBy="Id">
    </asp:LinqDataSource>
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
</asp:Content>

