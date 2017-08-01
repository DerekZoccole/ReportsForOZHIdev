<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ReportsForOZHIdev.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Administration</h1>
    <hr />
    <h3>User List</h3>
    <asp:GridView ID="UsersGridView" runat="server" PageSize="25" AutoGenerateColumns="false" ShowFooter="true" GridLines="Vertical" CellPadding="4" ItemType="ReportsForOZHIdev.Models.User" SelectMethod="GetUserList" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="../Account/Manage.aspx">
                        <img src="../Images/pencil.svg" width="25" height="25" style="border:solid"  />
                    </a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="Username" HeaderText="Username" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="PasswordHash" HeaderText="Password Hash" />
        </Columns>
    </asp:GridView>
</asp:Content>
