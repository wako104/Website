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
        <asp:TextBox ID="Fname" runat="server" OnTextChanged="Fname_TextChanged" Width="160px"></asp:TextBox>
        <br />
        <asp:TextBox ID="Lname" runat="server" OnTextChanged="Lname_TextChanged" Width="160px"></asp:TextBox>
        <br />
        <asp:TextBox ID="Username" runat="server" OnTextChanged="Username_TextChanged" Width="160px"></asp:TextBox>
        <br />
        <asp:TextBox ID="Email" runat="server" OnTextChanged="Email_TextChanged" Width="160px"></asp:TextBox>
        <br />
        <asp:TextBox ID="Password" runat="server" OnTextChanged="Password_TextChanged" Width="160px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" />
        <br />

        <br />
        Already have an account?
        <a href="Log in.aspx">Log in</a>
    </div>
    </div>
</asp:Content>
