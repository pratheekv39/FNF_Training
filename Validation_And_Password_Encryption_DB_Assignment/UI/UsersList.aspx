<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="Validation_And_Password_Encryption_DB_Assignment.UI.UsersList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Users List</title>
</head>
<body>
    <form runat="server">
        <asp:Repeater ID="rptUsers" runat="server">
            <ItemTemplate>
                <div style="border:1px solid #ccc; padding:10px; margin:10px;">
                    <strong>Username:</strong> <%# Eval("Username") %><br />
                    <strong>Email:</strong> <%# Eval("Email") %>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </form>

</body>
</html>
