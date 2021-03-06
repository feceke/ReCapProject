﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";        
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string CarDeleted = "Araba silindi.";       
        public static string CarUpdated = "Araba kaydı güncellendi.";       
        public static string CarsListed = "Arabalar Listelendi.";
        public static string MaintenanceTime = "Sistem Bakımda.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri bilgisi güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CompanyNameInvalid = "Şirket ismi geçersiz.";
        public static string CustomersListed = "Arabalar Listelendi.";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandNameInvalid = "Marka ismi geçersiz.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka kaydı güncellendi.";
        public static string BrandsListed = "Markalar Listelendi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorUpdated = "Renk bilgisi güncellendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorNameInvalid = "Renk ismi geçersiz.";
        public static string ColorsListed = "Renkler Listelendi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı kaydı güncellendi.";
        public static string UsersListed = "Kullanıcılar Listelendi.";

        public static string RentalAdded = "Araç Kiralama işlemi kaydedildi.";
        public static string RentalDeleted = "Kiralama silindi.";
        public static string RentalUpdated = "Kiralama kaydı güncellendi.";
        public static string NoRental = "Bu araç şu an kiralanamaz.";
        public static string RentalListed = "Kiralamalar listelendi.";

        public static string CarCountOfBrandError ="Bir markada 10'dan fazla araç bulunamaz";
        public static string CarNameAlreadyExists = "Araba ismi zaten var";
        
        public static string CarImageAdded ="Araba resmi eklendi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageLimitExceded = "En fazla 5 adet araba resmi ekleyebilirsiniz";

        public static string AuthorizationDenied ="Yetkiniz Yok";
        public static string UserRegistered ="Kullanıcı Kaydedildi";
        public static string UserNotFound ="Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin ="Giriş Başarılı";
        public static string UserAlreadyExists ="Bu epostaya kayıtlı başka bir kullanıcı hesabı var";
        public static string AccessTokenCreated ="Token oluşturuldu"; 
    }
}
