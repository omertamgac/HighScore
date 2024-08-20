# HighScore

**HighScore**; oyun meraklılarına, oyunlar hakkında detaylı bilgi ve kullanıcı tabanlı değerlendirmeler sunan kapsamlı bir platformdur. Bu proje, oyunların hangi platformlara ne zaman çıktığı, hangi kategorilere dahil oldukları, oyunun konusu ve trailer videosu gibi geniş bir yelpazede bilgiler sunarak, kullanıcıların oyunlar hakkında bilinçli kararlar almasına yardımcı olmayı amaçlamaktadır. Kullanıcılar, bu platformda oyunları puanlayabilir ve yorum yapabilirler.

## Proje Hakkında

### Amaç

HighScore, oyun severlerin bir araya gelip oyunlar hakkında düşüncelerini paylaşabilecekleri, oyunların çeşitli özellikleri hakkında bilgi edinebilecekleri ve topluluk tabanlı puanlama sistemi sayesinde oyunların kalitesi hakkında fikir sahibi olabilecekleri bir ortam yaratmayı amaçlar. Platform, kullanıcıların oyunlar hakkında objektif değerlendirmeler yapmalarını teşvik ederken, oyunların içerikleri ve özellikleri hakkında detaylı bilgi sunarak oyuncuların bilinçli tercihler yapmasını sağlar.

### Özellikler

#### Oyun Bilgileri
HighScore, kullanıcılarına oyunlar hakkında aşağıdaki bilgileri sunar:
- **Platform Bilgileri:** Oyunların hangi platformlara çıktığını veya çıkacağını gösterir.
- **Çıkış Tarihleri:** Oyunların piyasaya çıkış tarihlerini içerir.
- **Kategoriler:** Oyunların ait olduğu kategori veya türleri listeler.
- **Oyun Konusu:** Oyunların hikayesi veya oynanış teması hakkında bilgiler sağlar.
- **Trailer Videosu:** Oyunların tanıtım videolarını sunarak, kullanıcıların oyun hakkında görsel bir fikir sahibi olmasını sağlar.

#### Puanlama ve Yorum Sistemi
HighScore, kullanıcılarına oyunları puanlama ve yorum yapma imkanı tanır:
- **Puanlama:** Kullanıcılar, oyunlara 100 üzerinden puan vererek, oyunların topluluk tarafından genel olarak nasıl değerlendirildiğini görme imkanı bulur.
- **Yorumlar:** Kullanıcılar, oyunlar hakkında detaylı yorumlar yapabilir ve bu yorumları düzenleyebilir veya silebilirler. Yorumlar, diğer kullanıcılar tarafından görülebilir ve değerlendirilir.

#### Yönetim Paneli (Admin Özellikleri)
HighScore, yönetici (Admin) kullanıcılarına geniş yetkiler sunar:
- **Oyun Yönetimi:** Admin kullanıcılar, platforma yeni oyunlar ekleyebilir, mevcut oyunları düzenleyebilir ve gerektiğinde silebilir.
- **Kullanıcı Yönetimi:** Adminler, kurallara uymayan kullanıcıları banlayabilir, silebilir veya yeni kullanıcılar ekleyebilir. Ayrıca, kullanıcılar için yeni roller oluşturabilir ve bu rolleri atayabilir.
- **Yorum Yönetimi:** Adminler, kurallara uygun olmayan veya topluluk standartlarına aykırı olan yorumları platformdan kaldırabilir.

#### Kullanıcı Rolleri
HighScore'da iki ana kullanıcı rolü bulunmaktadır:
- **Standart Kullanıcılar (User):** Oyunları inceleyebilir, oyunlar hakkında yorum yapabilir ve puan verebilirler. Ayrıca, yaptıkları yorumları düzenleyebilir veya silebilirler.
- **Yönetici Kullanıcılar (Admin):** Daha geniş yetkilere sahip olup, platformdaki içerik ve kullanıcı yönetiminden sorumludurlar.

## Kullanılan Teknolojiler

HighScore, modern web geliştirme teknolojilerini kullanarak geliştirilmiştir:
- **Frontend Teknolojileri:**
  - **HTML5:** Web sayfalarının yapısını oluşturmak için.
  - **CSS3:** Sayfaların görsel tasarımını ve stilini belirlemek için.
  - **JavaScript:** Etkileşimli ve dinamik kullanıcı deneyimleri sunmak için.
  - **jQuery:** JavaScript işlemlerini kolaylaştırmak ve AJAX işlemlerini yönetmek için.
  - **Bootstrap 5:** Mobil uyumlu ve modern bir kullanıcı arayüzü oluşturmak için.

- **Backend Teknolojileri:**
  - **ASP.NET Core 8:** Web uygulamasının temel altyapısını sağlamak ve sunucu tarafı işlemleri yönetmek için.
  - **MySQL:** Veritabanı yönetimi ve veri saklama işlemleri için.
  - **ASP.NET Identity:** Kullanıcı kimlik doğrulama ve yetkilendirme işlemleri için.

- **Mimari:** MVC (Model-View-Controller) ve 3 katmanlı mimari kullanılarak, kodun daha yönetilebilir, test edilebilir ve ölçeklenebilir olması sağlanmıştır.

## Kurulum ve Kullanım

HighScore platformunu yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

### 1. Projeyi Klonlama
Öncelikle, projeyi GitHub üzerindeki depodan yerel makinenize klonlayın:
```bash
git clone https://github.com/omertamgac/HighScore.git
```

### 2. Bağımlılıkların Yüklenmesi
Projenin kök dizininde gerekli bağımlılıkları yüklemek için aşağıdaki komutu çalıştırın:
```bash
dotnet restore
```

### 3. Veritabanı Yapılandırması
MySQL veritabanınızı oluşturun ve bağlantı dizesini `appsettings.json` dosyasına ekleyin. Veritabanı migrasyonlarını uygulamak için:
```bash
dotnet ef database update
```

### 4. Uygulamanın Çalıştırılması
Projeyi çalıştırmak için aşağıdaki komutu kullanabilirsiniz:
```bash
dotnet run
```
Bu komut, uygulamayı yerel sunucunuzda başlatacak ve projeyi tarayıcınızda çalıştırabileceksiniz.

## Katkıda Bulunma

HighScore projesine katkıda bulunmak isterseniz, GitHub üzerinde bir `issue` açabilir veya bir `pull request` gönderebilirsiniz. Her türlü geri bildirim ve katkı, projenin gelişmesine yardımcı olacaktır.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Detaylar için `LICENSE` dosyasına göz atabilirsiniz.
