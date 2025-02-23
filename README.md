# Budzet_domowy
Praca zaliczeniowa na Ćwiczenia z Projektowania Obiektowego

![image](https://github.com/user-attachments/assets/56519a68-efcc-404b-98de-04ba2a03da12)


1.1. Cel aplikacji: Zarządzanie budżetem domowym.
Funkcjonalności:
- Dodawanie, edycja i usuwanie transakcji.
- Przeglądanie historii transakcji.
- Eksport danych do pliku Excel (najlepiej w tabeli).
- Planowanie comiesięcznych wydatków stałych.
  
1.2. Dane potrzebne dla każdej transakcji:
- Data transakcji.
- Kwota transakcji.
- Nazwa i krótki opis transakcji.
- Kategoria transakcji (jedzenie, transport, mieszkanie, czas wolny).
- Typ transakcji: przychód, wydatek.
  
1.3. Wstępny podział na klasy (obiekty):
- Klasa [Transakcja]:
Opis - Klasa bazowa, która zawiera wspólne właściwości transakcji (1.2.).
- Klasy dziedziczące: [Przychod] i [Wydatek]:
Opis - Specjalizacje transakcji. Mogą dziedziczyć właściwości z klasy [Transakcja], mogą też dodawać własne elementy.
- Klasa [Budzet]:
Opis - Zarządza listą transakcji. Ma pozwalać na dodawanie, usuwanie i modyfikowanie transakcji oraz na generowanie raportów (np. obliczanie sumy przychodów, wydatków, bilansu).
- Klasa [ExcelTabela]:
Opis - Odpowiedzialna za zapis danych do pliku excel. Użyć interfejs, np. IExporter, który zadeklaruje metodę eksportu, a [ExcelTabela] zaimplementuje ten interfejs. Chciałbym, żeby też pozwalał na odczytywanie danych z tabeli pliku excel na początku działania aplikacji.
