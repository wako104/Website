<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Log in.aspx.cs" Inherits="WebAppDemo.Log_in" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class ="center">
    <div class ="boxes">
        Log in<br />
        <br />
        Username:&nbsp; <asp:TextBox ID="username" runat="server" OnTextChanged="username_TextChanged"></asp:TextBox>
        <br />
        Password: &nbsp;
        <asp:TextBox ID="password" runat="server" OnTextChanged="password_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" />
        <br />
        <br />
        New user?
        <a href="Sign Up.aspx">Sign Up</a>
    </div>
    </div>

</asp:Content>
