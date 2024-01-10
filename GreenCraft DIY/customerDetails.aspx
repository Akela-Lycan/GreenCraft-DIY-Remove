<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="customerDetails.aspx.cs" Inherits="GreenCraft_DIY.customerDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            width: 299px;
        }
        .auto-style5 {
            width: 299px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="auto-style3"><strong>customer details</strong><br />
    </h1>
    <p>
        &nbsp;</p>
    <table class="auto-style2">
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lbl_CustID" runat="server" Text="Customer ID:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_CustID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lbl_FullName" runat="server" Text="Full Name:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelFullName" runat="server" Text="[Full_Name]"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lbl_Email" runat="server" Text="Email:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelEmail" runat="server" Text="[Email]"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lbl_Gender" runat="server" Text="Gender"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelGender" runat="server" Text="[Gender]"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lbl_Phone" runat="server" Text="Phone Number:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelPhone" runat="server" Text="[Phone Number]"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lbl_DOB" runat="server" Text="Date of Birth:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelDOB" runat="server" Text="[Date of Birth]"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lbl_Address" runat="server" Text="Address:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelAddress" runat="server" Text="[Address]"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
</asp:Content>
