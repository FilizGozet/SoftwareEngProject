using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    //yeni kullanıcı olustur ve kayıt işlemi yapar
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
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
