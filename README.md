# ⌨️ .Net Core 5.0 İle Admin Panelli Dinamik Portfolyo Projeme Hoşgeldiniz.
Eğitmenliğini Murat Yücedağ'ın üstlendiği, Udemy üzerinde eğitimlerini yayınladığı  "Asp.Net Core 5.0 ile Adım Adım Web Geliştirme" eğitim serisini tamamlayarak geliştirmiş olduğum Web projemi sizlere tanıtmak isterim. Bu yolda bana öncü olduğu için kendisine teşekkür ederim.

 # 📖Sizlere  Projemin Genel Amacından Bahsederek Başlamak İsterim;

 ## Bu Proje bir Portfolyo projesidir, kullanıcının akademik bilgilerini paylaştığı bir sayfası olan ayrıca arkaplanda CRUD işlemleri ve yetkilendirilme işlemlerinin yapılacağı bir kısım da bulunur.
 

# 📋 Peki Projede Kullandığım Teknolojiler Neler?

## 🔖 5 Farklı Katmanı Bulunan  N-Katmanlı Mimari İle Başlayalım;
###  🔹 Presentation Layer (Sunum Katmanı) : Kullanıcıya sunulan arayüzü barındırır
###  🔹 Business Logic Layer (İş Mantığı Katmanı) : Uygulamanın kurallarını ve iş mantığını barındırır
###  🔹 Data Access Layer (Veri Erişim Katmanı) : Veri tabanı ile uygulama arasında bağlantı kurmayı sağlayan katmandır
###  🔹 Entity Layer (Varlık Katmanı) : Codefirst yaklaşımını barındıran ve verilen saklandığı bir katmandır.
###  🔹API Katmanı :  İstemci ve sunucu arasında köprü kurarak farklı platformlar arası veri alışverişini sağlar.

## 🔖 UI(Tasarım) Kısmını Oluşturmak İçin : HTML5-CSS3-JavaScript-BootStrap.
## 🔖 Belirli Kurallar İçerisinde CRUD İşlemi Yapmak İçin :  Fluent Validation.
## 🔖 Authentication (Kimlik Doğrulama) Ve Authorization (Yetkilendirme) İçin:  ASP.Net Core Identity.
## 🔖 Veritabanı işlemlerini Daha Hızlı,Güvenli Ve Kolay Yapmak İçin Bir ORM Aracı Olan : Entity Framework Core CodeFirst Ve Onun İçerisinde Bulunan Migration Yapısını.
## 🔖 Hızlı, Güvenli, Modüler Bir Proje Olması İçin : Asp.Net Core MVC.
## 🔖 Web Sayfalarının Yeniden Yüklemeden Direkt Olarak Sunucu İle Haberleşerek CRUD İşlemleri Yapmak İçin : AJAX
## 🔖 API İsteklerini ( GET,POST,PUT,DELETE ) Test Etmek İçin : Swagger Ve Postman
## Kullandım.

# 🗂 Projem 3 Farklı Amaca Hizmete Etmek İçin Bölümlere Ayrılmıştır. Bu Bölümler;
## 🔗 Admin Paneli : Admin Rolüne Sahip Olan Kullanıcının; "Hakkımda","Yeteneklerim","Deneyimlerim" Ve "Hizmetlerim" İçin CRUD İşlemleri Yapabilmesini Amaçlayan Sayfadır.
## 🔗 Kullanıcı Paneli : Kullanıcı Rolüne Sahip Olan Kullanıcıların Hesaplarını Düzenleyip Diğer Kullanıcılar İle Mesajlaşmasını Amaçlayan Sayfadır.
## 🔗 Ana Sayfa : Burada Bana Ait Bilgilerin Yer Aldığı, Herhangi Bir Kullanıcının Herhangi Bir Login İşlemi Yapmadan Bana Ait Bilgileri Görmesini Amaçlayan Bir Sayfadır.

# 🧬Gelelim Tüm Bölümleri Tek Tek İncelemeye

## 📌 AnaSayfanın İlk Bölümü Olan Öne Çıkanlar Sayfası
### 📍 Features Tablosundaki Girilmiş Olan Adım Soyadım,Pozisyonum Ve Sosyal Medya Hesaplarım  Gözükmektedir
![Image Alt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/c744544ebfe5377ffff5adcdbddb85db8455112e/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20165020.png)
## 📌 Hakkımda Bölümü
### 📍 Abouts Tablosundaki Girilmiş Olan  Hakkımda Detayı,Mailim,Telefonum Ve Adresim Gözükmektedir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/c744544ebfe5377ffff5adcdbddb85db8455112e/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20165029.png)
## 📌 Hizmetlerim Bölümü
### 📍 Services Tablosundaki Girilmiş Olan Verebileceğim Hizmetler Gözükmektedir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/c744544ebfe5377ffff5adcdbddb85db8455112e/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20165551.png)
## 📌 Yeteneklerim Bölümü
### 📍 Skills Tablosundaki Girilmiş Olan Yeteneklerim Ve Bu Yeteneklerin Dereceleri Gözükmektedir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/c744544ebfe5377ffff5adcdbddb85db8455112e/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20165601.png)
## 📌 Projelerim Bölümü
### 📍 Portfolios Tablosundaki Girilmiş Olan Ve Linkleri Verilmiş Projelerim İle Ufak Görselleri Gözükmektedir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/c744544ebfe5377ffff5adcdbddb85db8455112e/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20165614.png)
