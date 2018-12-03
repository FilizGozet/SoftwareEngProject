using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void LoginButton_Click(object sender, EventArgs e)
    {
        TextBox ad = (TextBox)Login1.FindControl("UserName");
        TextBox sifre = (TextBox)Login1.FindControl("Password");
        Literal hata = (Literal)Login1.FindControl("FailureText");


        if (Membership.ValidateUser(ad.Text, sifre.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(ad.Text, true);
            hata.Text = "OLDU";
        }
        else
        {
            hata.Text = "T.C. kimlik numaranız ya da parolanız yanlış.Lütfen tekrar deneyin!";

        }
    }
}
