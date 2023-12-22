<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateManagementDemo.aspx.cs" Inherits="Question4validation.StateManagementDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>State Management Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>User Preferences</h2>
            <label for="txtUsername">Username:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />

            <label for="ddlTheme">Preferred Theme:</label>
            <asp:DropDownList ID="ddlTheme" runat="server">
                <asp:ListItem Text="Light" Value="light" />
                <asp:ListItem Text="Dark" Value="dark" />
            </asp:DropDownList>
            <br />

            <asp:Button ID="btnSavePreferences" runat="server" Text="Save Preferences" OnClick="btnSavePreferences_Click" />
            <asp:Button ID="btnClearSession" runat="server" Text="Clear Session" OnClick="btnClearSession_Click" />
        </div>

        <div>
            <h2>View State Information</h2>
            <asp:Label ID="lblViewStateInfo" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
