using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class Register
{
    private string kimlikNo;
    private string ad;
    private string soyad;
    private string cinsiyet;
    private string dogumtarihi;
    private string email;
    private string telNo;
    private string sifre;

    public Register() { }

    public Register(string kimlikNo, string ad, string soyad, string cinsiyet, string dogumtarihi, string email, string telNo, string sifre)
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

    //aldığı kisi bilgilerini üst sınıfa atar ve database'e kaydeder
    public bool CreateNewReg()
    {
        string conString = ConfigurationManager.ConnectionStrings["baglantim"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(conString);

        try
        {
            string query = "INSERT INTO Passenger(KimlikNo, Ad, Soyad, Cinsiyet, DogumTarihi, Email, TelefonNo, Sifre) VALUES(@KimlikNo, @Ad, @Soyad, @Cinsiyet, @DogumTarihi, @Email, @TelefonNo, @Sifre)";
            using (SqlCommand cmd = new SqlCommand(query, baglanti))
            {
                baglanti.Open();
                cmd.Parameters.Add("@KimlikNo", SqlDbType.NVarChar, 15).Value = kimlikNo;
                cmd.Parameters.Add("@Ad", SqlDbType.NVarChar, 50).Value = ad;
                cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar, 50).Value = soyad;
                cmd.Parameters.Add("@Cinsiyet", SqlDbType.NVarChar, 10).Value = cinsiyet;
                cmd.Parameters.Add("@DogumTarihi", SqlDbType.NVarChar, 10).Value = dogumtarihi;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 70).Value = email;
                cmd.Parameters.Add("@TelefonNo", SqlDbType.NVarChar, 15).Value = telNo;
                cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar, 10).Value = sifre;

                cmd.ExecuteNonQuery();
                return true;
            }
        }
        catch (Exception hata)
        {
            return false;
        }
        finally
        {
            baglanti.Close();
        }
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

   


    

