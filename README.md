🏋️‍♂️ Kong GYM - Üye Takip Sistemi
Geliştirici: İsmail Hakkı Ulumenderez
Proje Türü: C# Windows Forms Uygulaması

🎯 Proje Amacı
Kong GYM, spor salonuna kayıt olan kullanıcıların kişisel bilgilerini (isim, yaş, boy, kilo vb.) sisteme kaydedebildiği; bu verilerin veritabanında saklandığı ve yönetici (admin) paneli aracılığıyla görüntülenip, düzenlenip, silinebileceği bir üye takip sistemidir.

⚙️ Çalışma Yapısı
Kullanıcılar ilk olarak "Kayıt Ol" ekranı üzerinden sisteme giriş yapar.

Giriş sonrası kullanıcı; yaş, boy, kilo gibi bilgileri girerek kayıt olur.

Tüm veriler SQL Server üzerinde tutulan bir veritabanına kaydedilir.

Admin paneli üzerinden:

Üyeler listelenir

Bilgiler düzenlenir veya silinir

Yeni üyeler eklenebilir

🖥️ Kullanılan Teknolojiler
C# (.NET Framework)

Windows Forms

SQL Server (veritabanı bağlantısı için SqlConnection)

Visual Studio IDE

📌 Özellikler
Giriş ve kayıt ekranları

Yetkili admin girişi

Kullanıcı bilgilerinin veri tabanına güvenli şekilde kaydı

CRUD işlemleri (Create, Read, Update, Delete)

Görsel arayüz ile kullanıcı dostu deneyim

📷 Örnek Ekran Görüntüsü

📝 Kurulum ve Kullanım
bash
Kopyala
Düzenle
1. Projeyi klonlayın veya indirin
2. Visual Studio ile açın
3. SQL Server üzerinde "KongGYM" adında bir veritabanı oluşturun
4. `SqlConnection` bağlantı cümlesini kendi veritabanınıza göre güncelleyin
5. Derleyin ve çalıştırın
