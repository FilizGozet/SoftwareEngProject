<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="dvUpdate" style="left: 35%; float: none; top: 30%; position: fixed; border: solid; padding: 50px 50px 50px 50px">
            <asp:Label ID="lblKimlikNo" runat="server" Text="T.C. Kimlik No"></asp:Label><br />
            <asp:TextBox ID="txtKimlikNo" runat="server" autocomplete="off"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvad" runat="server" ControlToValidate="txtKimlikNo" Display="Dynamic" ErrorMessage="T.C. Kimlik gereklidir." ForeColor="Black" ToolTip="*"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="lblsifre" runat="server" Text="Şifre"></asp:Label><br />
            <asp:TextBox ID="txtSifre" runat="server" autocomplete="off" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvpass" runat="server" ControlToValidate="txtSifre" Display="Dynamic" ErrorMessage="Şifre gereklidir." ForeColor="Black" ToolTip="*"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btn" runat="server" Text="Giriş" OnClick="btn_Click" />
            <asp:Label ID="lbhata" runat="server"></asp:Label>
        </div>
        <p>
        </p>
    </form>
</body>
</html>
