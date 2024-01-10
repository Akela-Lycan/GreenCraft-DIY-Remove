<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="customerLogin.aspx.cs" Inherits="GreenCraft_DIY.customerLogin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            text-decoration: underline;
        }
        .auto-style5 {
            width: 300px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="auto-style3"><strong><span class="auto-style4">Customer Login</span></strong><br />
    </h1>
    <p>
    </p>
    <table class="auto-style2">
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lbl_Email" runat="server" Text="Email:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_Email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lbl_Password" runat="server" Text="Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_Password" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p class="auto-style3">
        <asp:Button ID="btn_Login" runat="server" OnClick="btn_Login_Click" Text="Login" Width="100px" />
    </p>
    <p>
    </p>
</asp:Content>
