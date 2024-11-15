Yapılacaklar.
MSSQL migration --> Discount.Context notlara bak.

MongoDb integration emin degilim kontrol et.

Docker masaüstü kurulumu yapılacak.(Account gerekli olabilir -- free)

Portainer yapılacak gpt son chatlerdeki komutlarla cmd üzerinden hallet  https://medium.com/devopsturkiye/docker-ile-portainer-kurulumu-ve-portainera-h%C4%B1zl%C4%B1-bak%C4%B1%C5%9F-2fdcf2b31deb
veya videodakini kullan

DBeaver indirilecek Free(Bu veri tabanı yönetim merkezi appi) eklenen dbsinin portu pc de olmalı    bazı db paketlerini dbeavera yüklemek gerekebilir

ECommerce.Order.Persistence.Context deki db serverına docker içindeki sqli baglıcaz connection stringi localhost,1440 sql portu olucak sonrada migration adımları uygulancak 
DBeaver dan kontrol et sonrada aslında DBeaver kullanmaya gerek yok normal management studiodan da portainer içindeki sqle localhost,1440 ile erişebilirsin

identity server yüklenicek cmd ye dotnet new install identityserver4.templates   komutunu yaz dene

ben projenin en üst dizinine gidicem orada yeni bir identityserver dosyası oluşturucam. 
sonra onun içine girip adresini kopyala cmd ye cd adres i ac sonrada o adreste dotnet new is4aspid --name ECommerce.IdentityServer ı calıstır ardından n bas

