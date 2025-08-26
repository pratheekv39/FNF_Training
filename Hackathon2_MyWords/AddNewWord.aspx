<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewWord.aspx.cs" Inherits="Hackathon2_MyWords.AddNewWord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h2>Add New Word and Meaning</h2>

            <asp:Label ID="lblWordLabel" runat="server" Text="Word:" />
            <br />
            <asp:TextBox ID="txtNewWord" runat="server" Width="300px" />
            <br /><br />

            <asp:Label ID="lblMeaningLabel" runat="server" Text="Meaning:" />
            <br />
            <asp:TextBox ID="txtMeaning" runat="server" Width="300px" />
            <br /><br />

            <asp:Button ID="btnAddWord" runat="server" Text="Add Word" OnClick="btnAddWord_Click" />
            <br /><br />

            <asp:Label ID="lblStatus" runat="server" ForeColor="Green" />
            <br /><br />

            <a href="SearchWord.aspx">Back to Search</a>
        </div>
    </form>

</body>
</html>



