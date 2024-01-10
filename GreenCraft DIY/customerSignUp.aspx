<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="customerSignUp.aspx.cs" Inherits="GreenCraft_DIY.customerLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 260px;
        }
        .auto-style4 {
            width: 260px;
            text-align: right;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            font-weight: bold;
            text-decoration: underline;
        }
        .auto-style7 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1 class="auto-style5"><span class="auto-style6"><strong>Customer Sign-Up</strong></span><br />
    </h1>
    <p>
    </p>
    <table class="auto-style2">
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbl_FullName" runat="server" AssociatedControlID="tb_FullName" Text="Full Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_FullName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbl_Email" runat="server" AssociatedControlID="tb_Email" Text="Email:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_Email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbl_Password" runat="server" AssociatedControlID="tb_Password" Text="Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbl_ConfirmPassword" runat="server" AssociatedControlID="tb_ConfirmPassword" Text="Confirm Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_ConfirmPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbl_Gender" runat="server" AssociatedControlID="rbl_Gender" Text="Gender:"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="rbl_Gender" runat="server" Width="150px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbl_Phone" runat="server" AssociatedControlID="tb_Phone" Text="Phone Number:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_Phone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbl_DOB" runat="server" AssociatedControlID="tb_DOB" Text="Date of Birth:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_DOB" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbl_Address" runat="server" AssociatedControlID="tb_Address" Text="Address:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_Address" runat="server" Height="100px" Width="500px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p class="auto-style7">
        <asp:Button ID="btn_SignUp" runat="server" Text="Sign-Up" Width="150px" OnClick="btn_SignUp_Click" />
    </p>
    <p>
        &nbsp;</p>
    
</asp:Content>
