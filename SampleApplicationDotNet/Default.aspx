<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="True"
    CodeBehind="Default.aspx.cs" Inherits="SampleApplicationDotNet.Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <asp:scriptmanager ID="Scriptmanager1" runat="server"></asp:scriptmanager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
            <asp:Panel ID="Credentials" runat="server" class="accountInfo">
                <fieldset class="login">
                    <legend>Account Information</legend>
                    <p>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserNameBox">Username:</asp:Label>
                        <asp:TextBox ID="UserNameBox" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserNameBox" 
                             CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="PasswordBox">Password:</asp:Label>
                        <asp:TextBox ID="PasswordBox" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="PasswordBox" 
                             CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="EnterpriseLabel" runat="server" AssociatedControlID="EnterpriseBox">Enterprise Guid:</asp:Label>
                        <asp:TextBox ID="EnterpriseBox" runat="server" CssClass="textEntry" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="EnterpriseBox" 
                             CssClass="failureNotification" ErrorMessage="Enterprise is required." ToolTip="Enterprise is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                </fieldset>
                <p class="submitButton">
                    <asp:Button ID="LoginButton" runat="server" OnClick="LoginUser_Authenticate" Text="Log In" 
                        ValidationGroup="LoginUserValidationGroup"/>
                </p>
            </asp:Panel>
            <asp:Panel ID="SiteSelector" runat="server" class="accountInfo" Visible="False">
                <fieldset class="login">
                    <legend>Available Sites</legend>
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                </fieldset>
            </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>

