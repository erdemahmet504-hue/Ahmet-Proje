#  Restoran Menü Sipariş Uygulaması (C# Console App)

Bu proje, C# programlama dili kullanılarak geliştirilmiş, konsol tabanlı interaktif bir restoran menü ve sipariş sistemidir. Kullanıcıların farklı yemek kategorileri arasında gezinmesini ve istedikleri ürünü seçmesini sağlar.

# Projenin Amacı ve Özellikleri

Bu uygulama, temel programlama mantığını (`if-else`, `switch-case` yapıları, kullanıcı girişi alma ve tür dönüşümleri) pekiştirmek amacıyla tasarlanmıştır.

Öne Çıkan Özellikler:
* Geniş Menü Seçeneği:Ana Yemekler, Ara Soğuklar, Ara Sıcaklar, Tatlılar, İçecekler, Çorbalar, Salatalar ve Zeytinyağlılar olmak üzere 8 farklı ana kategori sunar.
* Dinamik Alt Menüler: Kullanıcının seçtiği ana kategoriye göre, o kategoriye ait özel yemek listesi ekrana yazdırılır.
* Etkileşimli Kullanıcı Deneyimi: Kullanıcıdan konsol üzerinden veri alınır (`Console.ReadLine()`) ve sayısal değere dönüştürülerek (`int.Parse()`) işlenir.
* Hata Kontrolü: Ana menüde geçersiz bir numara girildiğinde `switch-case` yapısındaki `default` bloğu sayesinde kullanıcıya "Hatalı Giriş" uyarısı verilir.

# Kullanılan Teknolojiler

* Dil:** C#
* Platform:** .NET Console Application
* Geliştirme Ortamı:** Visual Studio 2022

# Nasıl Çalıştırılır

1. Projeyi bilgisayarınıza klonlayın veya indirin.
2. `Ahmet Proje.sln` dosyasını Visual Studio ile açın.
3. Üst menüden **Start (Başlat)** butonuna tıklayarak veya `F5` tuşuna basarak uygulamayı çalıştırın.
4. Konsol ekranındaki yönergeleri takip ederek sipariş numaranızı girin.

# Kod Yapısından Bir Kesit

Uygulama temel olarak aşağıdaki `switch-case` mantığıyla çalışmaktadır:

```csharp
switch(number) 
{
    case 1:
        Console.WriteLine("1-İskender Kebap");
        // Diğer yemekler...
        Console.Write("Ana Yemek Çeşitlerinden seçiniz = ");
        int çeşit = int.Parse(Console.ReadLine());
        Console.WriteLine("Seçtiginiz yemek= " + çeşit);
        break;
    // Diğer kategoriler (2-8 arası)
    default:
        Console.WriteLine("Hatalı Giriş");
        break;
}
