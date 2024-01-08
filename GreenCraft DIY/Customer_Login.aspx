<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Customer_Login.aspx.cs" Inherits="GreenCraft_DIY.Customer_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Customer sign-up</h1>
    <br />
    Full Name:
    <asp:TextBox ID="cust_Name" runat="server"></asp:TextBox>
    <br />
    Password:
    <asp:TextBox ID="cust_Password" runat="server"></asp:TextBox>
    <br />
    Confirm Password:
    <asp:TextBox ID="cust_cPassword" runat="server"></asp:TextBox>
    <br />
    Email:
    <asp:TextBox ID="cust_Email" runat="server"></asp:TextBox>
    <br />
    Phone Number:
    <asp:TextBox ID="cust_PhoneNo" runat="server"></asp:TextBox>
    <br />
    Gender:
    <asp:DropDownList ID="ddl_Gender" runat="server">
        <asp:ListItem>Gender (default)</asp:ListItem>
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:DropDownList>
    <br />
    Birthday:
    <asp:Calendar ID="cust_Birthday" runat="server"></asp:Calendar>
    <br />
    Address:
    <asp:TextBox ID="cust_Address" runat="server" Height="60px" Width="640px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_SignUp" runat="server" Text="Sign Up" />
</asp:Content>
