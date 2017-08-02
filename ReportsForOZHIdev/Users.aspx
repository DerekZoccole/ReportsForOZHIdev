<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="ReportsForOZHIdev.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="UserDetail" runat="server" ItemType="ReportsForOZHIdev.Models.User" SelectMethod="GetUser" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.FirstName %> <%#:Item.LastName %>'s Account Settings</h1>
            </div>
            <br />
            <table>
                <div class="col-md-12 col-sm-12 col-xs-12">
                    <div class="box">
                        <div class="form">
                            <div class="form-title">Email</div>
                            <asp:TextBox ID="EmailTextBox" runat="server" Text="<%#:Item.Email %>"></asp:TextBox>
                        </div>
                        <div class="form">
                            <div class="form-title">First Name</div>
                            <asp:TextBox ID="FirstNameTextBox" runat="server" Text="<%#Item.FirstName %>"></asp:TextBox>
                        </div>
                        <div class="form">
                            <div class="form-title">Last Name</div>
                            <asp:TextBox ID="LastNameTextBox" runat="server" Text="<%#:Item.LastName %>"></asp:TextBox>
                        </div>
                        <div class="form">
                            <div class="form-title">Company</div>
                            <asp:TextBox ID="CompanyTextBox" runat="server" Text="<%#:Item.Company %>"></asp:TextBox>
                        </div>
                        <div class="form">
                            <asp:Label runat="server" AssociatedControlID="password" CssClass="col-md-2 control-label">Password</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox runat="server" ID="password" TextMode="Password" CssClass="form-control" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="password" CssClass="text-danger" ErrorMessage="The password field is required." Display="Dynamic" ValidationGroup="SetPassword" />
                                <asp:ModelErrorMessage runat="server" ModelStateKey="NewPassword" AssociatedControlID="password" CssClass="text-danger" SetFocusOnError="true" />
                            </div>
                        </div>
                        <div class="form">
                            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm Password</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="confirmPassword" runat="server" TextMode="Password" CssClass="form-control" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="confirmPassword" CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password is required." ValidationGroup="SetPassword" />
                                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="confirmPassword" CssClass="text-danger" Display="Dynamic" ErrorMessage="The passwords do not match." ValidationGrou="SetPassword" />
                            </div>
                        </div>
                    </div>
                </div>
                <div>
                    <asp:Button ID="SubmitButton" runat="server" Width="58.922" Height="19" Text="Submit" OnClick="SubmitButton_Click" />
                    <asp:Button ID="CancelButton" runat="server" Width="58.922" Height="19" Text="Cancel" OnClick="CancelButton_Click" />
                </div>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
