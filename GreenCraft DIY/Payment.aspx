<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="GreenCraft_DIY.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <script src="https://code.jquery.com/jquery-3.6.4.min.js" integrity="sha256-oP6HI/t1Ee1zRW31PtI9Gi4aH6pAmdX6WOBl5NJ2dI=" crossorigin="anonymous"></script>


    <h1>Payment</h1>
     <b>Payment card type:</b>
    <asp:DropDownList ID="ddlCardType" runat="server" AutoPostBack="True" Font-Size="Medium" Width="168px">
        <asp:ListItem>Visa</asp:ListItem>
        <asp:ListItem>Mastercard</asp:ListItem>
        <asp:ListItem>America Express</asp:ListItem>
    </asp:DropDownList>

    <br />
    <br />
    Full Name:
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <br />
    Credit Card Number:
    <asp:TextBox ID="txtcardnumber" runat="server" style="font-size: small"></asp:TextBox>
    <asp:RequiredFieldValidator ID="vldcard" runat="server" ControlToValidate="txtcardnumber" ErrorMessage="Please enter your card number." style="font-size: small" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <br />
    Expiry date:
    <asp:TextBox ID="txtExpiry" runat="server" style="font-size: small"></asp:TextBox>
     <br />
    <br />
    CVV:
    <asp:TextBox ID="txtCVV" runat="server"></asp:TextBox>
    <br />
    <br />
    Total amount: <asp:Label ID="lblamount" runat="server"></asp:Label><br />
    <asp:Label ID="lblpayment_date" runat="server"></asp:Label>
    <br />
    <asp:Label ID="lblStatus" runat="server"></asp:Label>
    <br />
    <asp:Button ID="btnSumbit" runat="server" Text="Submit" OnClick="btnSumbit_Click" />
     <br />
</asp:Content>
