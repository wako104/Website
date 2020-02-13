<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sign Up.aspx.cs" Inherits="WebAppDemo.Sign_Up" %>
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
        Sign Up<br />
        <br />
        &nbsp;
        First Name: <asp:TextBox ID="Fname" runat="server" OnTextChanged="Fname_TextChanged" Width="160px"></asp:TextBox>
        <br />
        &nbsp;Username:&nbsp; <asp:TextBox ID="username" runat="server" OnTextChanged="username_TextChanged" Width="160px"></asp:TextBox>
        <br />
        Password:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="password" runat="server" OnTextChanged="password_TextChanged" Width="160px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" />
        <br />

        <br />
        Already have an account?
        <a href="Log in.aspx">Log in</a>
    </div>
    </div>
</asp:Content>
