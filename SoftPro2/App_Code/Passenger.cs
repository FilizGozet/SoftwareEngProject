using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Passenger
{
    private string kimlikNo;
    private string ad;
    private string soyad;
    private string cinsiyet;
    private string dogumtarihi;
    private string email;
    private string telNo;
    private string sifre;

    public Passenger(){ }

    public Passenger(string kimlikNo, string ad, string soyad, string cinsiyet, string dogumtarihi, string email, string telNo, string sifre)
    {
        this.kimlikNo = kimlikNo;
        this.ad = ad;
        this.soyad = soyad;
        this.cinsiyet = cinsiyet;
        this.dogumtarihi = dogumtarihi;
        this.email = email;
        this.telNo = telNo;
        this.sifre = sifre;
    }

    public void Registration()
    {
        Register kayıtolustur = new Register(kimlikNo, ad, soyad, cinsiyet, dogumtarihi, email, telNo, sifre);
        kayıtolustur.CreateNewReg();
    }
    

    public void setKimlikNo(string kimlikNo) { this.kimlikNo = kimlikNo; }
    public string getKimlikNo() { return kimlikNo; }

    public void setAd(string ad) { this.ad = ad; }
    public string getAd() { return ad; }

    public void setSoyad(string soyad) { this.soyad = soyad; }
    public string getSoyad() { return soyad; }

    public void setCinsiyet(string cinsiyet) { this.cinsiyet = cinsiyet; }
    public string getCinsiyet() { return cinsiyet; }

    public void setDogumTarihi(string dogumtarihi) { this.dogumtarihi = dogumtarihi; }
    public string getDogumTarihi() { return dogumtarihi; }

    public void setEmail(string email) { this.email = email; }
    public string getEmail() { return email; }

    public void setTelNo(string telNo) { this.telNo = telNo; }
    public string getTelNo() { return telNo; }

    public void setSifre(string sifre) { this.sifre = sifre; }
    public string getSifre() { return sifre; }



}