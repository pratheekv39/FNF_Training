<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Validation_And_Password_Encryption_DB_Assignment.UI.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" /><br />
        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" /><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" /><br />
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    </form>
</body>
</html>
