<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebAppDemo.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Welcome to the demo site.</p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Log in.aspx">Log in</asp:LinkButton>
    &nbsp;or
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Sign Up.aspx" OnClick="LinkButton2_Click">Sign Up</asp:LinkButton>
    </p>
    <p>
        &nbsp;</p>
    </asp:Content>
