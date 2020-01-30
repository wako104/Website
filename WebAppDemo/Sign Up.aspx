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
    <p class="signup">
        Sign Up</p>
    <div class="boxes">
    <p>
        First Name:&nbsp;
        <asp:TextBox ID="fname" runat="server" OnTextChanged="fname_TextChanged"></asp:TextBox>
    </p>
    <p>
        Last Name:&nbsp;
        <asp:TextBox ID="lname" runat="server"></asp:TextBox>
    </p>
    <p>
        Username:&nbsp;&nbsp;
        <asp:TextBox ID="uname" runat="server"></asp:TextBox>
    </p>
    <p>
        Password:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="pword" runat="server"></asp:TextBox>
    </p>
        </div>
</asp:Content>
