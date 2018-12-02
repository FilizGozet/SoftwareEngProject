<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" OnCreatedUser="CreateUserWizard1_CreatedUser">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td align="center" colspan="2">Yeni Hesabınız için Kaydolun</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="lblkimlik" runat="server" Text="Tc Kimlik:"></asp:Label><br />
                                </td>
                                <td>
                                    <asp:TextBox ID="txtkimlik" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvkimlik" runat="server" ControlToValidate="txtkimlik" ValidationExpression="^[a-zA-Z'.]{3,25}$" Display="Dynamic">*</asp:RequiredFieldValidator><br />
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="UserNameLabel" runat="server" Text="Ad:" AssociatedControlID="UserName"></asp:Label><br />
                                </td>
                                <td>
                                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvad" runat="server" ControlToValidate="UserName" ValidationExpression="^[a-zA-Z'.]{3,25}$" Display="Dynamic">*</asp:RequiredFieldValidator><br />
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="lblsoyad" runat="server" Text="Soyad:"></asp:Label><br />
                                </td>
                                <td>
                                    <asp:TextBox ID="txtsoyad" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvsoyad" runat="server" ControlToValidate="txtsoyad" Display="Dynamic">*</asp:RequiredFieldValidator><br />
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="lblcinsiyet" runat="server" Text="Cinsiyet:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlcinsiyet" runat="server">
                                        <asp:ListItem>Kadın</asp:ListItem>
                                        <asp:ListItem>Erkek</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="lbldogum" runat="server" Text="Doğum:"></asp:Label><br />
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdogumtarihi" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="EmailLabel" runat="server" Text="Mail:" AssociatedControlID="Email"></asp:Label><br />
                                </td>
                                <td>
                                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvmail" runat="server" ControlToValidate="Email" Display="Dynamic">*</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revemail" runat="server" ControlToValidate="Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Geçerli bir eposta adresi giriniz." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator><br />
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="lbltel" runat="server" Text="Telefon:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txttel" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvtel" runat="server" ControlToValidate="txttel" Display="Dynamic">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="PasswordLabel" runat="server" Text="Şifre" AssociatedControlID="Password"></asp:Label><br />
                                </td>
                                <td>
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvsifre" runat="server" ControlToValidate="Password" Display="Dynamic">*</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revsifre" runat="server" ControlToValidate="Password" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{4,6})$" ErrorMessage="En az 4, en fazla 6 karakter ve an az bir sayı olmalı." Font-Size="X-Small" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" style="color: Red;">
                                    <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>

    </form>

</body>
</html>
