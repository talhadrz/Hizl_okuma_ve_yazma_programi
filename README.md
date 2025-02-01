# Burası Giriş Sayfası

 ![image](https://github.com/user-attachments/assets/c28d2515-a100-4fa8-bcaa-af9d15ee6013)

## Özellikleri
 1. (gir buttonu) kullanıcı ismini kontrol ediyor eğer veri tabanında kayıtlıysa şifresine bakıyor oda doğruysa girme işlemini tamamlıyor.
 2. (sil buttonu) aynı şekilde kullanıcı adını kontrol edip şifreyi kontrol ediyor eğer veriler doğruysa kontrol amaçlı bir meşaj ile silinmesini istendiğini tekrar kontrol ediyor ve oda onaylanırsa veri'yi siliyor.
 3. (güncelle buttonu) aynı şekilde ad ve sifreyi kontrol ediyor ve doğrulanırsa güncelleme sayfasını açıp ad ve şifresini oraya aktarıyor.
 4. (kayıt ol buttonu) yeni bir kişi eklemek için kayıt formunu açıyor.
 5. (form load) veri tabanındaki isimnleri isim combobox aracına ekliyor.

 # Burası Kayıt ve Güncelle Sayfası

![image](https://github.com/user-attachments/assets/25f1bfd0-6f28-4a6c-b039-545e0d8e3473)

## Özellikler

  ## 1. bu sayfa iki amaçta kullanılıyor bir yeni kişi kaydetme iki kayıtlı veriyi güncelleme.
    1.1 (kişi ekleme) form text "Kayıt Formu" ve button text "Kaydet" diye değişiyor.
    1.2 (veri güncelle) form text "Güncelleme Formu" ve button text "Güncelle".
 ## 2. (button özellikleri) bir kaydet iki güncelle.
    2.1 (kayıt) önce isim verisini kontrol ediyor aynısı varsa izin vermiyor ve şifresini 4 karakterden az olmasını kontrol ediyor ve tabiki ad ve şifre kısmını doldurup doldurulmadığını kontrol ediyor ve doğrulanırsa yeni kişi kaydını yapıyor.
    2.2 (güncelle) adı ve şifrreyi kontrol ediyor boş olup olmadığını şifrenin uzunluğunu 4 karakterden az olup olmadığını kontrol ediyor ve bir hata oluşmaz ise güncelleme işlemini yapıyor.
     
 # Burası Kelime Yazma Sayfası

 ![image](https://github.com/user-attachments/assets/e4ecd787-d62b-459c-b276-77fc7d136210)

## Özellikler

## (Form Load) giriş sayfası girme işlemini yaparken ad verisini bu formun içindeki ad değişkenine atıyor ve formn ilk açılırken bu ad verisini kullanarak veri tabanından kaç kelime yazdığını alıp "Tüm yazılan kelime sayısı" labeline yazdı
## (button click) veri tabanından 5 farklı kelime kategorisini tutan tablolardan rasrtgele bir tablo ve o tablodanda yine rastgele bir kelime tutup textbox text kısmına kelimenin uzunluğuna göre yazıp siliyor
## (textBox KeyDown) enter tuşuna basılıp basılmadığını kontrol ediyor basılırsa textbox text kısmındaki yazılan veriyi önceki yazıp silinen veriyle uyuşuyormu kontrol ederek eğer uyuşuyor ise yenikelime seçip gösterip siliyor yada yanlış yazılmış ise silip doğrusunu yazıp siliyor 
## (geiri buttonu) giriş sayfasını açıyor
## (çıkış buttonu) proğramı kapatıyor
