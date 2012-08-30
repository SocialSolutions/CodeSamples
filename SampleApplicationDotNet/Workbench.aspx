<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Workbench.aspx.cs" Inherits="SampleApplicationDotNet.Workbench" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/Workbench.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
<asp:scriptmanager ID="Scriptmanager1" runat="server"></asp:scriptmanager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>

    <div class="page">
        <div>
            <fieldset>
                <legend>Site Details</legend>
                    <asp:Label ID="Label3" runat="server" Text="Name: " Font-Bold="True"></asp:Label>
                    <asp:Label ID="SiteNameLabel" runat="server" Text="Label"></asp:Label>
                    <asp:Label ID="Label5" runat="server" Text="Disabled: " Font-Bold="True"></asp:Label>
                    <asp:Label ID="DisabledLabel" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Address: "></asp:Label>
                <asp:Label ID="AddressLabel" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="PhoneLabel" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="ZipLabel" runat="server" Text="Label"></asp:Label>
            </fieldset>
        </div>
        <div>
            <fieldset>
                <legend>Search For Participants</legend>
                    <asp:Label runat="server" ID="testlabel">Select a Program:</asp:Label>
                    <asp:DropDownList ID="ProgramDropList" runat="server">
                    </asp:DropDownList>
                    <asp:Label runat="server" ID="Label1">Enter Search Value:</asp:Label>
                    <asp:TextBox ID="SearchText" runat="server" 
                        ontextchanged="SearchText_TextChanged" Width="282px"></asp:TextBox>
                        <p></p>
                <asp:Label ID="Label2" runat="server">Search Results:</asp:Label>
                 <p>
                <asp:ListBox ID="SearchResults" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="SearchResults_SelectedIndexChanged" Width="276px">
                </asp:ListBox>
                </p>
            </fieldset>
        </div>
        <div>
            <asp:Panel ID="ClientPanel" runat="server">
                <fieldset>
                    <legend>Participant Details</legend>
                    <asp:Panel ID="Panel1" runat="server">
                        <asp:Label ID="Label6" runat="server" Text="Name: " Font-Bold="True"></asp:Label>
                        <asp:Label ID="PartNameLabel" runat="server" Text=""></asp:Label>
                        <asp:Label ID="Label8" runat="server" Text="ID: " Font-Bold="True"></asp:Label>
                        <asp:Label ID="PartIdLabel" runat="server" Text=""></asp:Label>
                        <asp:Label ID="Label7" runat="server" Text="Address: " Font-Bold="True"></asp:Label>
                        <asp:Label ID="PartAddrLabel" runat="server" Text=""></asp:Label>
                        <asp:Label ID="Label9" runat="server" Text="Gender: " Font-Bold="True"></asp:Label>
                        <asp:Label ID="PartGenderLabel" runat="server" Text=""></asp:Label>
                    </asp:Panel>
                </fieldset>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server">
            </asp:Panel>
        </div>
    </div>

    </ContentTemplate>
</asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
