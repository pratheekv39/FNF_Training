<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchWord.aspx.cs" Inherits="Hackathon2_MyWords.SearchWord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h2>Search Word</h2>

            <asp:TextBox ID="txtWord" runat="server" Width="300px" />
            <br /><br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" Text="Display All Words" OnClick="btnDisplayAll_Click" />
            <br /><br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Blue" />
            <br /><br />

            <asp:GridView ID="gvWords" runat="server" AutoGenerateColumns="False" Visible="false">
                <Columns>
                    <asp:BoundField DataField="Key" HeaderText="Word" />
                    <asp:BoundField DataField="Value" HeaderText="Meaning" />
                </Columns>
            </asp:GridView>

            <br /><br />
            <a href="AddNewWord.aspx">Add a new word with meaning</a>
        </div>
    </form>
</body>
</html>

