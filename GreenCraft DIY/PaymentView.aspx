<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PaymentView.aspx.cs" Inherits="GreenCraft_DIY.PaymentView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style3 {
            margin-right: 104px;
            margin-top: 12px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvPayment" runat="server" DataKeyNames="Payment_Id" AutoGenerateColumns="False" CssClass="auto-style3" Width="515px" OnSelectedIndexChanged="gvPayment_SelectedIndexChanged" OnRowEditing="gvPayment_RowEditing" OnRowUpdating="gvPayment_RowUpdating">
        <Columns>
            <asp:BoundField DataField="Payment_Id" HeaderText="Payment Ref" />
            <asp:BoundField DataField="Amount" HeaderText="Amount($)" />
            <asp:BoundField DataField="CardNumber" HeaderText="Card Number" />
            <asp:TemplateField HeaderText="Card Type">
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlcard_type" runat="server" DataSourceID="SqlDataSource3" DataTextField="CardType" DataValueField="CardType">
                    </asp:DropDownList>
                    <asp:SqlDataSource runat="server"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                    <br />
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:GreenCraft %>" SelectCommand="SELECT DISTINCT [CardType] FROM [Payments]"></asp:SqlDataSource>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("CardType") %>'></asp:Label>
                    <asp:DropDownList ID="ddlcard_type" runat="server"></asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ExpiryDate" HeaderText="Expiry Date" />
            <asp:BoundField DataField="CardHolderName" HeaderText="Name" />
            <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:BoundField DataField="CVV" HeaderText="CVV" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" EditText="Update" />
        </Columns>
    </asp:GridView>
   
</asp:Content>
