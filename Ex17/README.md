# Zad 17. REST API part 2

Waszym zadaniem jest Rozszerzenie API o zarządzanie danymi sprzedaży w zakresie danego produktu.

Encja Sale (sprzedaż) posiada następujące właściwości:
- ID (typ int): identyfikator rekordu
- CreatedAt (typ datetime): data utworzenia wpisu o sprzedaży
- Quantity (typ decimal): ilość sprzedanego produktu we wskazanej dacie (CreatedAt)
- Unit (typ string): jednostka sprzedaży np. item (sztuka), kg (kilogram) itp. 

a) API powinno pozwolić na:
- pobranie listy danych sprzedaży powiązanych z danym produktem
- dodanie nowego wpisu o sprzedaży dla danego produktu
- usunięcia wpisu o sprzedaży dla danego produktu
- aktualizację wpisu o sprzedaży dla danego produktu

b) Przy dodawaniu lub aktualizacji wpisu o sprzedaży wszystkie właściwości muszą być wymagane w wysyłanym żądaniu 

c) API musi być zabezpieczone przez API Key. Klucz musi znajdować się w konfiguracji.

d) API musi posiadać dokumentację online w standardzie Open API (Swagger)

# Dla przypomnienia forma oddania zadania
Zadanie powinno być oddane w formie commitów na oddzielnym branchu o nazwie w konwecji `nrzadania_ImięNazwisko` (np: `17_PatrykSzwermer`)

Powodzenia :) 

# :clock3: Termin
## 06.12.2020, godz 24:00 
