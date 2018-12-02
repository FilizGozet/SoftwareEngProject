﻿using System;
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



    protected void btn_Click(object sender, EventArgs e)
    {
        if (Membership.ValidateUser(txtKimlikNo.Text, txtSifre.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(txtKimlikNo.Text, true);
        }
        else
        {
            lbhata.Text = "T.C. kimlik numaranız ya da parolanız yanlış.Lütfen tekrar deneyin!";
        }
    }
}
