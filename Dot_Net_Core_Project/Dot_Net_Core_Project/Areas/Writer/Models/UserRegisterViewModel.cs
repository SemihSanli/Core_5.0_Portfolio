﻿using System.ComponentModel.DataAnnotations;

namespace Dot_Net_Core_Project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Resminizi Ekleyin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil. Kontrol Ediniz !!!!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }
    }
}
