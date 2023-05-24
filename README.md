# E-Gabinet

## Projekt EGabinet przygotowany na potrzebę obsługi przychodni medycznej. 

### Założenia:
* dodawania użytkowników wg. przypisanej roli:
pacjent, pielęgniarka, lekarz.
* dodawanie / usuwanie wizyt w przychodni,
* zmiana danych użytkownika,
* wyświetlanie listy wizyt i użytkowników,
* oddzielne widoki dla poszczególnych ról,
* mikroserwis obsługujący płatności, autoryzacja.

### Technologie:
* ASP.NET CORE MVC
* WEB API
* MICROSERVICES
* JWT
* ASP.NET CORE IDENTITY
* ENTITY FRAMEWORK
* MSSQL
* XUNIT
* MOQ
* SWAGGER 
* BOOSTRAP


### Uruchomienie:
```
git clone [https://github.com/HLyczak/E-gabinet.git](https://github.com/HLyczak/E-Gabinet.git)
cd Egabinet/Egabinet 
dotnet run
wejdź na: https://localhost:7253/
```
Przykładowi użytkownicy:
* pielęgniarka: user5@op.pl hasło: Admin123!
* pacjnet: user1@op.pl hasło: Admin123!
* doktor: user10@op.pl hasło: Admin123!

