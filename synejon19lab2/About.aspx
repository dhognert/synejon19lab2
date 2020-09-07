<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="synejon19lab2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>


    <asp:TextBox ID="txtAbout" runat="server" />
    <asp:RequiredFieldValidator ID="reqAbout" runat="server" ControlToValidate="txtAbout" ErrorMessage="*" Display="Dynamic" />
    <asp:RegularExpressionValidator ID="regAbout" runat="server" ControlToValidate="txtAbout" ErrorMessage="Email required" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
    <br /><br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
</asp:Content>
