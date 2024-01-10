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
    <asp:GridView ID="gvPayment" runat="server" DataKeyNames="Payment_Id" AutoGenerateColumns="False" CssClass="auto-style3" Width="800px" OnSelectedIndexChanged="gvPayment_SelectedIndexChanged" OnRowEditing="gvPayment_RowEditing" OnRowUpdating="gvPayment_RowUpdating" OnRowCancelingEdit="gvPayment_RowCancelingEdit" OnRowDeleting="gvPayment_RowDeleting">
        <Columns>
            <asp:BoundField DataField="Payment_Id" HeaderText="Payment Ref" />
            <asp:BoundField DataField="Amount" HeaderText="Amount($)" />
            <asp:BoundField DataField="CardNumber" HeaderText="Card Number" />
            <asp:TemplateField HeaderText="Card Type">
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlcard_type" runat="server" DataSourceID="SqlDataSource3" DataTextField="CardType" DataValueField="CardType" SelectedValue='<%# Bind("CardType") %>'>
                        <asp:ListItem>Master</asp:ListItem>
                        <asp:ListItem>Visa</asp:ListItem>
                        <asp:ListItem>America Express</asp:ListItem>
                    </asp:DropDownList>
                    
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:GreenCraft %>" SelectCommand="SELECT [CardType] FROM [CardType_Unique]">
                    </asp:SqlDataSource>
               
                    <br />
      
               
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("CardType") %>'></asp:Label>
                    <asp:DropDownList ID="ddlcard_type" runat="server" ></asp:DropDownList>

                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ExpiryDate" HeaderText="Expiry Date" />
            <asp:BoundField DataField="CardHolderName" HeaderText="Name" />
            <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:BoundField DataField="CVV" HeaderText="CVV" />
            <asp:CommandField ShowEditButton="True" EditText="Update" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="lbDelete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this payment?');"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
   
</asp:Content>
