<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clients.aspx.cs" Inherits="ReportsForOZHIdev.Clients" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="LabelStatus" runat="server" Text=""></asp:Label>
    <table>
        <tr>
            <td><asp:Label ID="LabelFirstNationName" runat="server">First Nation:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddFirstNationName" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddClientButton" runat="server" Text="SAVE" OnClick="AddClientButton_Click" CausesValidation="true" />
</asp:Content>
