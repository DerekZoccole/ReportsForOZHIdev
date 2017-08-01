<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ReportsForOZHIdev.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Administration</h1>
    <hr />
    <h3>User List</h3>
    <asp:GridView ID="UsersGridView" runat="server" PageSize="25" AutoGenerateColumns="false" ShowFooter="true" GridLines="Vertical" CellPadding="4" ItemType="ReportsForOZHIdev.Models.ApplicationDbContext" SelectMethod="GetUserList" CssClass="table table-striped table-bordered">
        <Columns>
        </Columns>

    </asp:GridView>
</asp:Content>
