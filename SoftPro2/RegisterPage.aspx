<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="dvUpdate" style="left: 35%; float: none; top: 1%; position: fixed; border: solid; padding: 50px 50px 50px 50px">
            <asp:Label ID="lblkimlik" runat="server" Text="Tc Kimlik"></asp:Label><br />
            <asp:TextBox ID="txtkimlik" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvkimlik" runat="server" ControlToValidate="txtkimlik" ValidationExpression="^[a-zA-Z'.]{3,25}$" ErrorMessage="*T.C. Kimlik Numarası Gereklidir." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator><br />

            <asp:Label ID="lblad" runat="server" Text="Ad"></asp:Label><br />
            <asp:TextBox ID="txtad" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvad" runat="server" ControlToValidate="txtad" ValidationExpression="^[a-zA-Z'.]{3,25}$" ErrorMessage="*Ad Gereklidir." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator><br />


            <asp:Label ID="lblsoyad" runat="server" Text="Soyad"></asp:Label><br />
            <asp:TextBox ID="txtsoyad" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvsoyad" runat="server" ControlToValidate="txtsoyad" ErrorMessage="*Soyad Gereklidir." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator><br />


            <asp:Label ID="lblcinsiyet" runat="server" Text="Cinsiyet"></asp:Label><br />
            <asp:DropDownList ID="ddlcinsiyet" runat="server">
                <asp:ListItem>Kadın</asp:ListItem>
                <asp:ListItem>Erkek</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />

            <asp:Label ID="lbldogum" runat="server" Text="Doğum"></asp:Label><br />
            <asp:TextBox ID="txtdogumtarihi" runat="server"></asp:TextBox><br />
            <br />

            <asp:Label ID="lblmail" runat="server" Text="Mail"></asp:Label><br />
            <asp:TextBox ID="txtmail" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvmail" runat="server" ControlToValidate="txtmail" ErrorMessage="*Eposta Gereklidir." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revemail" runat="server" ControlToValidate="txtmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Geçerli bir eposta adresi giriniz." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator><br />

            <asp:Label ID="lbltel" runat="server" Text="Telefon"></asp:Label><br />
            <asp:TextBox ID="txttel" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvtel" runat="server" ControlToValidate="txttel" ErrorMessage="*Telefon Gereklidir." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
<%--            <asp:RegularExpressionValidator ID="revtel" runat="server" ControlToValidate="txttel" ValidationExpression="/^(\+[0-9]{0,3})*( ([0-9]{0,3})){3}$/" ErrorMessage="Geçerli bir telefon numarası giriniz." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator><br />--%>

            <asp:Label ID="lblsifre" runat="server" Text="Şifre"></asp:Label><br />
            <asp:TextBox ID="txtsifre" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvsifre" runat="server" ControlToValidate="txtsifre" ErrorMessage="*Şifre Gereklidir." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revsifre" runat="server" ControlToValidate="txtsifre" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{4,6})$" ErrorMessage="En az 4, en fazla 6 karakter ve an az bir sayı olmalı." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
            <br />
            <br />

            <asp:Button ID="btnsubmit" Class="but" runat="server" Text="Üyeliği Gerçekleştir" OnClick="btnsubmit_Click" /><br />
        </div>
    </form>

</body>
</html>
