# 🚀 AkademiQ Portfolio

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![TailwindCSS](https://img.shields.io/badge/Tailwind_CSS-38B2AC?style=for-the-badge&logo=tailwind-css&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Completed-success?style=for-the-badge)

## 📖 Proje Hakkında

**AkademiQ Portfolio**, eski ve statik bir HTML şablonunun (Sility), modern yazılım mimarileri kullanılarak dinamik, yüksek performanslı ve yönetilebilir bir **ASP.NET Core** uygulamasına dönüştürülmüş halidir.

Proje geliştirilirken **"Legacy Code Refactoring"** (Eski kodun iyileştirilmesi) prensipleri uygulanmış; **jQuery, Bootstrap ve ağır kütüphaneler projeden tamamen temizlenerek**, yerlerine modern **Vanilla JavaScript (ES6+)** ve **Tailwind CSS** entegre edilmiştir.

Veritabanı yaklaşımı olarak **DB First** kullanılmış olup, tüm içerik (Hakkımda, Yetenekler, Projeler, İletişim vb.) dinamik olarak MSSQL veritabanından çekilmektedir.

### ✨ Temel Özellikler
* **Modern UI/UX:** Glassmorphism etkili Navbar, Typewriter efektli Hero bölümü ve interaktif kart yapıları.
* **Yüksek Performans:** Gereksiz kütüphanelerin (jQuery, Isotope.js, OwlCarousel) kaldırılmasıyla sayfa yükleme hızında artış.
* **AJAX Form Yönetimi:** İletişim ve Sidebar formlarının sayfa yenilenmeden (Asenkron) sunucuya gönderilmesi.
* **Off-Canvas Sidebar:** CV indirme ve hızlı iletişim için sağdan açılan özel panel.
* **Dinamik Filtreleme:** Projeler bölümünde saf JavaScript ile yazılmış, animasyonlu kategori filtreleme sistemi.
* **Clean Architecture:** HTML (View) ve JavaScript (Logic) kodlarının `PartialView` yapısıyla birbirinden ayrılması (Separation of Concerns).

---

## 🛠️ Kullanılan Teknolojiler

Projede kullanılan teknoloji yığını (Tech Stack) aşağıdaki gibidir:

### Backend
* **Framework:** ASP.NET Core 8.0 MVC
* **Dil:** C#
* **Veritabanı:** MSSQL (SQL Server)
* **ORM:** Entity Framework Core (DB First Yaklaşımı)

### Frontend
* **Tasarım Motoru:** [Tailwind CSS](https://tailwindcss.com/) (Utility-First)
* **Scripting:** Vanilla JavaScript (ES6+) - *jQuery kullanılmamıştır.*
* **İkon Seti:** Bootstrap Icons
* **Font Ailesi:** Plus Jakarta Sans (Google Fonts)
* **Bildirimler:** SweetAlert2

---

## 📸 Ekran Görüntüleri

### 1. Kullanıcı Arayüzü (UI)
Projenin son kullanıcıya görünen modern yüzü.

| Hero & Navbar | Projeler & Filtreleme |
|:---:|:---:|
| ![Hero Bölümü](https://via.placeholder.com/600x300?text=Hero+Bolumu+Resmi+Buraya) | ![Projeler](https://via.placeholder.com/600x300?text=Projeler+Bolumu+Resmi+Buraya) |

| Deneyim (Timeline) | İletişim & Harita |
|:---:|:---:|
| ![Deneyim](https://via.placeholder.com/600x300?text=Deneyim+Resmi+Buraya) | ![İletişim](https://via.placeholder.com/600x300?text=Iletisim+Resmi+Buraya) |

### 2. Admin Paneli
İçeriklerin yönetildiği, Chart.js grafiklerinin bulunduğu yönetim paneli.

![Admin Dashboard](https://via.placeholder.com/800x400?text=Admin+Paneli+Genel+Gorunum)

---

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/kullaniciadiniz/AkademiQ-Portfolio.git](https://github.com/kullaniciadiniz/AkademiQ-Portfolio.git)
    ```

2.  **Veritabanı Bağlantısı:**
    `appsettings.json` dosyasındaki `ConnectionStrings` alanını kendi SQL Server bilgilerinize göre güncelleyin.

3.  **Veritabanını Oluşturun (DB First):**
    Eğer veritabanı yedeği yoksa, Entity Framework kullanarak veritabanını ayağa kaldırabilirsiniz (veya SQL script dosyasını çalıştırın).

4.  **Projeyi Başlatın:**
    Terminalde proje dizinine gelip şu komutu çalıştırın:
    ```bash
    dotnet run
    ```

---

## 📞 İletişim

* **Geliştirici:** Yunus Emre Kaymakcı
* **LinkedIn:** [linkedin.com/in/yunusemre](https://linkedin.com)
* **Email:** yunusemre@example.com
