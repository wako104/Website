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
    <p class ="login">
        Log in
    </p>

    <div class ="boxes">  
        Username:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Password:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>

</asp:Content>
