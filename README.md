# ⌨️ .Net Core 5.0 İle Admin Panelli Dinamik Portfolyo Projeme Hoşgeldiniz.
Eğitmenliğini Murat Yücedağ'ın üstlendiği, Udemy üzerinde eğitimlerini yayınladığı  "Asp.Net Core 5.0 ile Adım Adım Web Geliştirme" eğitim serisini tamamlayarak geliştirmiş olduğum Web projemi sizlere tanıtmak isterim. Bu yolda bana öncü olduğu için kendisine teşekkür ederim.

 # 📖Sizlere  Projemin Genel Amacından Bahsederek Başlamak İsterim;

 ## Bu Proje bir Portfolyo projesidir, kullanıcının akademik bilgilerini paylaştığı bir sayfası olan ayrıca arkaplanda CRUD işlemleri ve yetkilendirilme işlemlerinin yapılacağı bir kısım da bulunur.
 

# 📋 Peki Projede Kullandığım Teknolojiler Neler?

## 🔖 Yazdığım Kodun Düzenli Ve Kontrol Edilebilmesi İçin Kullandığım Ve 5 Farklı Katmanı Bulunan  N-Katmanlı Mimari İle Başlayalım;
###  🔹 Presentation Layer (Sunum Katmanı) : Kullanıcıya sunulan arayüzü barındırır
###  🔹 Business Logic Layer (İş Mantığı Katmanı) : Uygulamanın kurallarını ve iş mantığını barındırır
###  🔹 Data Access Layer (Veri Erişim Katmanı) : Veri tabanı ile uygulama arasında bağlantı kurmayı sağlayan katmandır
###  🔹 Entity Layer (Varlık Katmanı) : Codefirst yaklaşımını barındıran ve verilen saklandığı bir katmandır.
###  🔹API Katmanı :  İstemci ve sunucu arasında köprü kurarak farklı platformlar arası veri alışverişini sağlar.

## 🔖 UI(Tasarım) Kısmını Oluşturmak İçin : HTML5-CSS3-JavaScript-BootStrap.
## 🔖 Belirli Kurallar İçerisinde CRUD İşlemi Yapmak İçin :  Fluent Validation.
## 🔖 Authentication (Kimlik Doğrulama) Ve Authorization (Yetkilendirme) Rolleme Ve İzinler İçin:  ASP.Net Core Identity.
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
## 📌 Deneyimlerim Bölümü 
### 📍Experiences Tablosundaki Girilmiş Olan Deneyim Bilgilerim Gözükmektedir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/7e54f3f509d9be05463b32762b37c7481dbb3e91/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20165619.png)
## 📌 Referanslarım Bölümü
### 📍 Testimonials Tablosundaki Girilmiş Olan Referans Bilgilerim Gözükmektedir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/7e54f3f509d9be05463b32762b37c7481dbb3e91/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20165623.png)
## 📌 Benimle İletişime Geç Bölümü
### 📍 Kullanıcıların Tarafıma Ulaşmak İçin Görüntülediği Bilgilere Ve Mesaj Gönderebilecekleri Bir Alana Sahiplik Yapar
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/7e54f3f509d9be05463b32762b37c7481dbb3e91/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20165629.png)

# 🙍‍♂️ Kullanıcı Paneli

## 📌 Login Paneli
### Kullanıcının Giriş Yapması İçin Yönlendirildiği Paneldir. Eğer Giriş Yapmadan Diğer Panellere Erişmeye Çalışırsa Sürekli Login Paneline Yönlendirilecektir. Eğer Daha Önceden Oluşturmuş Olduğu Bir Hesabı Yok İse "Kayıt Ol" Bölümünden Kayıt Ol Sayfasına Yönlendirilebilir.Eğer Kullanıcı Giriş Yaparken Bilgilerini 5 Defa Yanlış Girerse Belirli Bir Süre Giriş Denemesi Yapamaz. Eğer Giriş Başarılı Olursa İlgili Sayfaya Yönlendirilir, Yönlendirilme Sonrasında 100 Dakikalık Bir Süresi Bulunur(Değiştirilebilir). Bu Süre Sonra Oturum Kapanarak Login Sayfasına Tekrar Yönlendirilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/7e54f3f509d9be05463b32762b37c7481dbb3e91/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163413.png)
## 📌 Register Paneli 
### Kullanıcı Bu Bölümde Kendine Ait Bilgileri Girerek Bir Hesap Oluşturabilir Fakat Hiçbir Kısmı Boş Bırakamaz.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/7e54f3f509d9be05463b32762b37c7481dbb3e91/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163652.png)
## 📌 Profil Paneli 
### Giriş Başarı İle Sağlanırsa Kullanıcıyı Profil Paneli Karşılar. Kullanıcı Burada Bilgilerini Güncelleyebilir,Sol Tarafta,Kullanıcının Aralarında Gezinebileceği Bir Panel Bulunmaktadır.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/ec4e38e7ba69fc03b197051dc04d87829fbd474c/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163822.png)
## 📌Dashboard Paneli 
### OpenWeatherMap Üzerinden Anlık Olarak Hava Durumu API'sini Çekerek Ülke Ve İl Bilgisi İle Birlikte Her Gün Otomatik Güncellenen Dinamik Bir Hava Durumu Paneli, Giriş Yapan Kullanıcıya Gelen Mesaj Sayısı,Toplam Kullanıcı Sayısı,Kullanıcının Girmiş Olduğu Toplam Yetenek Sayısı Ve Duyuru Sayısı Gibi İstatistiksel Veriler Bu Panelde Kullanıcı Tarafından Görüntülenir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/62988546244cec9ff604f78c73ddc373809a446e/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-23%20021540.png)
## 📌Gelen Kutusu Paneli 
### Diğer Kullanıcılar Tarafından, Login İşlemi Yapmış Olan Kullanıcıya Gönderilen Mesajları Burada Görüntüleyebilir. Mesaj Detayları İle Mesajın Detayını Görüntüleyebilir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/62988546244cec9ff604f78c73ddc373809a446e/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163830.png)
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/62988546244cec9ff604f78c73ddc373809a446e/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163931.png)
## 📌Gönderilen Mesaj Paneli 
### Login İşlemi Yapmış Olan Kullanıcının Diğer Kullanıcılara Gönderdiği Mesajları Burada Görüntüleyebilir. Mesaj Detayları İle Mesajın Detayını Görüntüleyebilir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/9559d2e3c2493cbea8955cb53e8aa4eb8c4c6a6f/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163839.png)
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/9559d2e3c2493cbea8955cb53e8aa4eb8c4c6a6f/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163925.png)
## 📌Yeni Mesaj Paneli
### Kullanıcı Diğer Kullanıcılara Mesaj Gönderme İşlemini Burada Gerçekleştirir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/9559d2e3c2493cbea8955cb53e8aa4eb8c4c6a6f/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163901.png)
## 📌Duyurular Paneli
### Yayınlanmış Olan Duyuruları Görüntüleyebilir Ve "Detaylar" Butonu İle Duyuru Detaylarını Görüntüleyebilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/9559d2e3c2493cbea8955cb53e8aa4eb8c4c6a6f/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163910.png)
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/9559d2e3c2493cbea8955cb53e8aa4eb8c4c6a6f/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20163918.png)


# 👨🏻‍💻 Admin Paneli

## 📌 Dashboard Paneli
### Admin Burada "Bütçe Geçmişi, Yetenek Sayısı,Okunmamış Mesaj Sayısı,Proje Sayısı, Eklenen 5 Adet Proje (Proje Durumları Ve Tarihleri İle Birlikte),Eklenen Projeleri,Var İse Mesajları,Proje Görsellerinin Olduğu Bir Slider'ı,ToDoList İle Eklenen Bilgileri,Ziyaret Edilen Ülkeleri Ve Ufak Bir Dünya Haritasını Görüntüleyebilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/9559d2e3c2493cbea8955cb53e8aa4eb8c4c6a6f/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164248.png)
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/9559d2e3c2493cbea8955cb53e8aa4eb8c4c6a6f/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164300.png)
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/9559d2e3c2493cbea8955cb53e8aa4eb8c4c6a6f/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164309.png)
### Üst Tarafta Bulunan "Çan" İkonuna Tıklayarak  Bildirimleri Görüntüleyebilir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/9559d2e3c2493cbea8955cb53e8aa4eb8c4c6a6f/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164320.png)
### Üst Tarafta Bulunan "Mesaj" İkonuna Tıklayarak  Tarafına Gönderilmiş Mesajları Görüntüleyebilir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/2f59a9e48c84aa742a3ccdb2075c7f9ed8a8a382/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164326.png)
## 📌 Anasayfadaki Bilgi Paneli
### Admin Anasayfada Bulunan "Öne Çıkanlar" Sayfasındaki Verileri Görüntüleyebilir, Dilerse Günceller.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/7099ec0d45128c07c89ebc456af7f4b884f75ea9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164839.png)
## 📌 Yetenekler Paneli
### Admin Anasayfada Bulunan "Yeteneklerim" Sayfasındaki Verileri Görüntüleyebilir. Dilerse Bu Bilgileri Siler Ve Günceller
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/2f59a9e48c84aa742a3ccdb2075c7f9ed8a8a382/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164400.png)
### Güncelleme Bölümüne Eklenen Verinin ID'sine Göre "Başlık" Ve "Değer" Bilgileri Otomatik Olarak Gelir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/2f59a9e48c84aa742a3ccdb2075c7f9ed8a8a382/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164412.png)
### Yeni Bir Yetenek Eklemek İsterse, Yeni Yetenek Ekle Butonuna Tıklayarak İlgili Panele Yönlenerek Ekleme İşlemi Gerçekleştirir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/2f59a9e48c84aa742a3ccdb2075c7f9ed8a8a382/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164419.png)

## 📌 Deneyimler Paneli
### Admin Anasayfada Bulunan "Deneyimlerim" Sayfasındaki Verileri Görüntüleyebilir. Dilerse Bu Bilgileri Siler Ve Günceller
### Yeni Bir Deneyim Eklemek İsterse, Yeni  Deneyim Butonuna Tıklayarak İlgili Panele Yönlenerek Ekleme İşlemi Gerçekleştirir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164445.png)
### Güncelleme Bölümüne Eklenen Verinin ID'sine Göre "Başlık" , "Tarih","Görsel URL" Ve "Açıklama" Bilgileri Otomatik Olarak Gelir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164451.png)
## Yeni Bir Deneyim Eklemek İsterse,Yeni Deneyim Ekle Butonuna Tıklayarak İlgili Panele Yönlenerek Ekleme İşlemi Gerçekleştirir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164741.png)
## 📌 Sosyal Medya Paneli
### Admin Anasayfada Bulunan "Öne Çıkanlar" Sayfasındaki Sosyal Medya Verilerini Görüntüleyip, Dilerse Ekleme-Silme-Güncelleme İşlemi Yapabilir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164728.png)
### Güncelleme Bölümüne Eklenen Verinin ID'sine Göre "Başlık" , "Tarih" Ve "Görsel URL" Bilgileri Otomatik Olarak Gelir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164734.png)
### Yeni Bir Sosyal Medya Eklemek İsterse, Yeni Sosyal Medya Ekle Butonuna Tıklayarak İlgili Panele Yönlenerek Ekleme İşlemi Gerçekleştirir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164458.png)
## 📌 Hizmetler Paneli
### Admin Anasayfada Bulunan "Hizmetlerim" Sayfasındaki Verileri Görüntüleyebilir. Dilerse Bu Bilgileri Siler Ve Günceller
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164515.png)
### Güncelleme Bölümüne Eklenen Verinin ID'sine Göre "Başlık" Ve "Görsel Yolu" Bilgileri Otomatik Olarak Gelir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164521.png)
### Yeni Bir Hizmet Eklemek İsterse, Yeni Hizmet Ekle Butonuna Tıklayarak İlgili Panele Yönlenerek Ekleme İşlemi Gerçekleştirir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164530.png)

## 📌 Hakkımda Paneli
### Admin Anasayfada Bulunan "Hakkımda" Sayfasındaki Verileri Görüntüleyerek Güncelleyebilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164540.png)
## 📌 Projelerim Paneli
### Admin Anasayfada Bulunan "Portfolyom" Sayfasındaki Verileri Görüntüleyebilir, Dilerse Silme Ve Güncellem Yapabilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164547.png)
### Güncelleme Bölümüne Eklenen Verinin ID'sine Göre "Proje Başlığı" , "Görsel1",  " Görsel2"," ProjeUrl","Fiyat","Tamamlanma Oranı","Platform" Bilgileri Otomatik Olarak Gelir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164601.png)
### Yeni Bir Proje Eklemek İsterse, Yeni Hizmet Ekle Butonuna Tıklayarak İlgili Panele Yönlenerek Ekleme İşlemi Gerçekleştirir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164615.png)

## 📌 Yazar-Admin Gelen Mesaj Paneli
### Admin Kendisine Gelen Mesajları Burada Görüntüleyebilir, Mesajın Detaylarını Görüp Dilerse Silebilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164648.png)
### "Mesajı Gör" Diyerek Mesaj Detaylarını Görüntüleyebilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164654.png)

## 📌 Alt İletişim Düzenleme Paneli
### Admin Kendisine Ait İletişim Bilgilerini Buradan Düzenleyebilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164719.png)

## 📌 Deneyimler Paneline Tekrar Gelelim Fakat Bu Sefer Devreye AJAX Giriyor Olacak
### Admin, AJAX Kullanarak Tüm Verileri Listeler,Kaydeder,ID İle Getirir,Siler Ve Günceller.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/09ce22f880a542b9be0cc98c20db176d42d2a575/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164810.png)
## 📌 Referans Paneli
### Admin, Sahip Olduğu Referans Bilgilerini Burada Görüntüleyip Detaylarına Gidip Burada Güncelleme İşlemi Yapabilir Veya Detaylar Kısmına Hiç Gitmeden Silebilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/7099ec0d45128c07c89ebc456af7f4b884f75ea9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164823.png)
### Güncelleme Bölümüne Eklenen Verinin ID'sine Göre "Ad Soyad" , "Şirket",  " Yorum"," ImageUrl","Fiyat","Ünvan" Bilgileri Otomatik Olarak Gelir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/7099ec0d45128c07c89ebc456af7f4b884f75ea9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20164829.png)
### Yeni Bir Referans Eklemek İsterse, Yeni Referans Ekle Butonuna Tıklayarak İlgili Panele Yönlenerek Ekleme İşlemi Gerçekleştirir
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/7099ec0d45128c07c89ebc456af7f4b884f75ea9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-22%20025618.png)


# 🚨 Peki Olası Bir Hata Durumunda Kullanıcıları Karşılayacak Herhangi Bir Sayfa Yok Mu? Tabi ki Var!

## 🏷️ 404 Sayfası
### Kullanıcı Eğer Mevcutta Olmayan Bir Sayfaya Ulaşmaya Çalışırsa Bu Sayfa İle Karşılaşır. "Anasayfaya Dön" Diyerek Anasayfaya Yönlendirilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/79497326dcf4ca41fb76df7a9bbc47cf0231b495/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20170243.png)
## 🏷️ 401 Sayfası
### Kullanıcı Eğer Erişim İzni Olmayan Bir Sayfaya Erişmeye Çalışırsa Bu Sayfa İle Karşılaşır."Anasayfaya Dön" Diyerek Anasayfaya Yönlendirilir.
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/79497326dcf4ca41fb76df7a9bbc47cf0231b495/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20170248.png)




# 🧩 Projeden Bağımsız Fakat Bilgilendirici Olan API Bölümü
## Swagger İle API'ye İstek Atıp;

### Get-Post İşlemi İle Eklem-Listeleme İsteğinin Kontrolü
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/79497326dcf4ca41fb76df7a9bbc47cf0231b495/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20132722.png)
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/79497326dcf4ca41fb76df7a9bbc47cf0231b495/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20132853.png)
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/79497326dcf4ca41fb76df7a9bbc47cf0231b495/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20132902.png)
### Put İşlemi İle Güncelleme İsteğinin Kontrolü
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/79497326dcf4ca41fb76df7a9bbc47cf0231b495/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20133527.png)
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/79497326dcf4ca41fb76df7a9bbc47cf0231b495/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20133600.png)
### Delete İşlemi İle Silme İsteğinin Kontrolü
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/79497326dcf4ca41fb76df7a9bbc47cf0231b495/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20133229.png)
![ImageAlt](https://github.com/SemihSanli/Core_5.0_Portfolio/blob/79497326dcf4ca41fb76df7a9bbc47cf0231b495/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-03-21%20133238.png)







# 💰 Son Olarak Projenin Bana Kazandırdığı Çok Şey Oldu Bunlar,

 ## ⭐ Validation Kontrollerini Pekiştirmemi.
 ## ⭐ N-Katmanlı Mimari Yapısını Pekiştirmemi.
 ## ⭐ Route Mantığı.
 ## ⭐ PartialView İle Daha  Temiz Kod Düzeni.
 ## ⭐ Entity FrameWork Core CodeFirst Yaklaşımı .
 ## ⭐ Asp.Net Core MVC Yapısı.
 ## ⭐ Authentication , Authorization Rolleme Ve İzinler Yapısını Kullanmamı Sağlayan ASP.Net Core Identity.
 ## ⭐ AJAX Kullanımı.
 ## ⭐ API'ye İstek Gönderimi Ve Swagger-Postman İle Kontrolü
## Gibi Daha Nice Bilgileri Haneme Katmış Bulunmaktayım.
