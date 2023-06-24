using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarNameInValid = "Eklenecek arabanın açıklaması 2 veya daha fazla karakter içermelidir";
        public static string CarAdded = "Araba bilgileri eklendi";
        public static string CarUpdated = "Araba bilgileri güncellendi";
        public static string CarDeleted = "Araba bilgileri silindi";
        public static string CarListed = "Araba bilgileri listelendi";
        public static string MaintenanceTime = "Sistem bakımda";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka silindi";
        public static string BrandListed = "Markalar listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk silindi";
        public static string ColorListed = "Renkler listelendi";

        public static string RentalAdded = "Kiralık araba  eklendi";

        public static string UserAdded = "Kullanıcı bilgileri eklendi";
        public static string UserDeleted = "Kullanıcı bilgileri silindi";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi";
        public static string UserListed = "Kullanıcı bilgileri listelendi";

        public static string CustomerAdded = "Müşteri bilgileri eklendi";
        public static string CustomerDeleted = "Müşteri bilgileri silindi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi";
        public static string CustomerListed = "Müşteri bilgileri listelendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordIsIncorrect = "Şifre hatalı";
        public static string SystemLoginSuccessfull = "Sisteme giriş başarılı";
        public static string UserAlreadyExists= "Bu kullanıcı zaten mevcut";
        public static string UserRegisteredSuccessfully= "Kullanıcı başarıyla kaydedildi";
        public static string AcccessTokenSuccessfullyCreated= "Access Token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
