<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AS.WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h3>
    Pocetna stranica
</h3>
    <br />

    <input type="button" value="HTML dugme" />
    <br />
    <br />
    <asp:Button Text="ASP FORMS dugme" 
        runat="server" 
        OnClick="Unnamed_Click" />
    <br />
    <asp:Label 
        runat="server" 
        ID="lblTest">Labela</asp:Label>
</asp:Content>
