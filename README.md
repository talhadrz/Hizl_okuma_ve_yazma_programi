# Proje Adı

Bu proje, kullanıcı girişi, kayıt, güncelleme ve kelime yazma gibi çeşitli özellikleri içeren bir uygulamadır.

## Giriş Sayfası

![Giriş Sayfası](https://github.com/user-attachments/assets/c28d2515-a100-4fa8-bcaa-af9d15ee6013)

### Özellikler

1. **Giriş Butonu**: 
   - Kullanıcı adını kontrol eder. Eğer veritabanında kayıtlıysa, şifresini doğrular ve giriş işlemini tamamlar.
   
2. **Sil Butonu**: 
   - Kullanıcı adını ve şifresini kontrol eder. Eğer doğrulanırsa, kullanıcıyı silmek için onay ister ve onay alındıktan sonra kullanıcıyı siler.
   
3. **Güncelle Butonu**: 
   - Kullanıcı adını ve şifresini kontrol eder. Doğrulanırsa, güncelleme sayfasını açar ve kullanıcı bilgilerini bu sayfaya aktarır.
   
4. **Kayıt Ol Butonu**: 
   - Yeni bir kullanıcı eklemek için kayıt formunu açar.
   
5. **Form Load**: 
   - Veritabanındaki isimleri, isim combobox'ına ekler.

## Kayıt ve Güncelleme Sayfası

![Kayıt ve Güncelleme Sayfası](https://github.com/user-attachments/assets/25f1bfd0-6f28-4a6c-b039-545e0d8e3473)

### Özellikler

1. **Sayfa İki Amaçla Kullanılır**:
   - **Yeni Kişi Kaydetme**: Form başlığı "Kayıt Formu" ve buton metni "Kaydet" olarak değişir.
   - **Kayıtlı Veriyi Güncelleme**: Form başlığı "Güncelleme Formu" ve buton metni "Güncelle" olarak değişir.

2. **Buton Özellikleri**:
   - **Kaydet Butonu**:
     - İsim verisini kontrol eder. Aynı isimde bir kayıt varsa izin vermez.
     - Şifrenin 4 karakterden az olmamasını kontrol eder.
     - Ad ve şifre alanlarının doldurulup doldurulmadığını kontrol eder.
     - Doğrulanırsa yeni kullanıcı kaydını yapar.
   - **Güncelle Butonu**:
     - Ad ve şifre alanlarının boş olup olmadığını kontrol eder.
     - Şifrenin 4 karakterden az olmamasını kontrol eder.
     - Hata yoksa güncelleme işlemini gerçekleştirir.

## Kelime Yazma Sayfası

![Kelime Yazma Sayfası](https://github.com/user-attachments/assets/e4ecd787-d62b-459c-b276-77fc7d136210)

### Özellikler

1. **Form Load**:
   - Giriş sayfasındaki kullanıcı adını bu formun içindeki ad değişkenine atar.
   - Form ilk açıldığında, veritabanından kullanıcının yazdığı kelime sayısını alır ve "Tüm yazılan kelime sayısı" label'ine yazar.

2. **Buton Tıklama**:
   - Veritabanındaki 5 farklı kelime kategorisinden rastgele bir tablo seçer ve o tablodan rastgele bir kelime alır.
   - Seçilen kelimeyi textbox'ta gösterir ve ardından siler.

3. **TextBox KeyDown**:
   - Enter tuşuna basılıp basılmadığını kontrol eder.
   - Eğer basılırsa, textbox'ta yazılan metni önceki kelimeyle karşılaştırır.
   - Eğer doğru yazılmışsa, yeni bir kelime seçer ve gösterir.
   - Yanlış yazılmışsa, doğrusunu gösterir ve siler.

4. **Giriş Butonu**:
   - Giriş sayfasını açar.

5. **Çıkış Butonu**:
   - Programı kapatır.

## Proje Özeti

Bu proje, kullanıcıların güvenli bir şekilde giriş yapabileceği, kayıt olabileceği, bilgilerini güncelleyebileceği ve kelime yazma pratiği yapabileceği bir uygulamadır. Temel özellikleri şunlardır:

- **Kullanıcı Girişi**: Kullanıcı adı ve şifre doğrulaması ile güvenli giriş.
- **Kullanıcı Yönetimi**: Yeni kullanıcı kaydı, mevcut kullanıcı bilgilerini güncelleme ve kullanıcı silme.
- **Kelime Yazma Pratiği**: Rastgele kelimelerle yazma pratiği yapma ve doğru yazım kontrolü.

Bu uygulama, kullanıcıların hem kişisel bilgilerini yönetebileceği hem de eğlenceli bir şekilde yazma becerilerini geliştirebileceği bir platform sunar.
