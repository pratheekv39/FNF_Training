<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Validation_And_Password_Encryption_DB_Assignment.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" /><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" /><br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnRegister" runat="server" Text="New User? Register Here" OnClick="btnRegister_Click" />
    </form>
</body>
</html>
