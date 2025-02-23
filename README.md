# Budzet_domowy
Praca zaliczeniowa na Ćwiczenia z Projektowania Obiektowego

![image](https://github.com/user-attachments/assets/2a468caf-8424-4847-9477-3c817fac814e)

##Instrukcja pobrania:
![image](https://github.com/user-attachments/assets/73181cd6-f535-4da7-9113-f97e4935ad36)
Należy pobrać spakowany plik Budzet.domowy.-.aplikacja.rar znaleziony w sekcji releases opisany jako V1.0.
Po pobraniu należy wypakować pliki do wybranego przez siebie folderu i uruchomić plik BudzetDomowyApp.exe
Plik excel jest tworzony w głównym folderze aplikacji, opisany jako budzet.

1.1. Cel aplikacji: Zarządzanie budżetem domowym.
Funkcjonalności:
- Dodawanie, edycja i usuwanie transakcji.
- Przeglądanie historii transakcji.
- Import i Eksport danych do tabeli w pliku Excel.
  
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
