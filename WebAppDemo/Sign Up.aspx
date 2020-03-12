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
        <asp:TextBox ID="FnameTb" runat="server" Width="150px" Height="30px" Font-Italic="False" Font-Names="Century Gothic" Font-Overline="False" Font-Size="Small" OnTextChanged="FnameTb_TextChanged" placeholder="First Name" CssClass="padding"></asp:TextBox>
        &nbsp;
        <asp:TextBox ID="LnameTb" runat="server" Width="150px" Height="30px" Font-Names="Century Gothic" Font-Size="Small" placeholder="Last Name" CssClass="padding"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="UsernameTb" runat="server" Width="313px" Height="30px" placeholder="Username" CssClass="padding" Font-Names="Century Gothic"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="EmailTb" runat="server" Width="313px" Height="30px" placeholder="Email" CssClass="padding" Font-Names="Century Gothic"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="PasswordTb" runat="server" Width="313px" Height="30px" TextMode="Password" placeholder="Password" CssClass="padding" Font-Names="Century Gothic"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" CausesValidation="False" CssClass="button" Font-Bold="True" Font-Names="Century Gothic" />
        <br />
        <br />
        Already have an account?
        <a href="Log in.aspx">Log in</a>
    </div>
    </div>
</asp:Content>
