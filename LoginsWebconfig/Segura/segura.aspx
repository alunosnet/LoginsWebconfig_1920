<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="segura.aspx.cs" Inherits="LoginsWebconfig.Segura.segura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Página segura.</h1>
            <asp:Button runat="server" Text="Logout" ID="bt" OnClick="bt_Click" />
        </div>
    </form>
</body>
</html>
