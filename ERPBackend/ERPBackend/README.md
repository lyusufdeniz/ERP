# Clean Architecture
## Projede kullanılan kütüphaneler
- **EntityFrameworkCore**
- **EntityFrameworkCore.Identity**
- **MediatR**
- **AutoMapper**
- **FluentValidation**
- **TS.Result**
- **TS.EntityFrameworkCore.GenericRepository**

Proje başlangıçta MSSQL ile ayarlandı. MSSQL ile devam etmek istiyorsanız `appsetting.json` dosyasında ConnectionStrings kısmını kendinize göre düzenleyin



Eğer Database değiştirmek istiyorsanız kurulu NuGet package'ini Infrastructure katmanında değiştirip connection bilgisini değiştirmelisiniz.

Login metodu ve User classı projede mevcut.
Proje çalıştığında otomatik bir admin(pw 1) kullanıcısı oluşturur





