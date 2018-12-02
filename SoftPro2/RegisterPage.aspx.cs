using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   


    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        Guid userFKey;

        MembershipUser mu = Membership.GetUser(CreateUserWizard1.UserName);
        userFKey = (Guid)mu.ProviderUserKey;

        TextBox txtad = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("UserName");
        TextBox txtkimlik = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("txtkimlik");
        TextBox txtsoyad = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("txtsoyad");
        DropDownList ddlcinsiyet = (DropDownList)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("ddlcinsiyet");
        TextBox txtdogumtarihi = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("txtdogumtarihi");
        TextBox txtmail = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Email");
        TextBox txttel = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("txttel");
        TextBox txtsifre = (TextBox)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("Password");

        string tckimlik = txtkimlik.Text;
        string ad = txtad.Text;
        string soyad = txtsoyad.Text;
        string cinsiyet = ddlcinsiyet.SelectedValue;
        string dogtar = txtdogumtarihi.Text;
        string mail = txtmail.Text;
        string tel = txttel.Text;
        string sifre = txtsifre.Text;

        Passenger kisi = new Passenger(tckimlik,ad,soyad,cinsiyet,dogtar,mail,tel,sifre);
        kisi.Registration();
    }
}
