# Zad 10. Testy jednostkowe

Wasze zadanie polega na dodaniu testów do kodu z `Receipt.cs`. Kod to uproszczony model rachunku jaki możemy dostać z kasy sklepowej. Jego głównym celem jest umożliwienie użytkownikowi dodawnie kolejnych produktów (RecordLine) oraz ew. wprowadzenie poprawki, czyli cofnięcie ostatniej operacji (ReverseLastLine). Klasa potrafi dodatkowo wyliczyć kwotę pieniędzy za wszystkie dodane produkty. Przykładowo:

Gdy dodamy jedno opakowanie jajek za 3 USD i 4 jabłka za 2 USD każde, zapłacić musimy 11 USD (1 x 3 USD + 4 x 2 USD = 11 USD).
```
            var receipt = new Receipt();
            receipt.RecordLine(title: "eggs", numberOfItems: 1, priceInUSD: 3);
            receipt.RecordLine(title: "apples", numberOfItems: 4, priceInUSD: 2);
            var totalCost = receipt.CalculateTotalCost();
```
Gdy jednak cofniemy ostatnią pozycję, ponieważ dodana została przez pomyłkę, to całość kosztować nas będzie tyle co jedno opakowanie jajek czyli 3 USD.
```
            var receipt = new Receipt();

            receipt.RecordLine(title: "eggs", numberOfItems: 1, priceInUSD: 3);

            receipt.RecordLine(title: "apples", numberOfItems: 4, priceInUSD: 2);

            receipt.ReverseLastLine();

            var totalCost = receipt.CalculateTotalCost();
```
Waszym zadaniem jest odpowiednie przetestowanie kodu poprzez napisanie testów jednostkowych. 
Postarajcie się napisać tyle testów, żeby mieć pewność, że kod działa tak jak powinien i nie ma za dużo bug'ów ;). 
Pamiętajcie o odpowiednim nazewnictwie, dobrych praktykach (np. test testuje tylko jedną rzecz) i możliwościach jakie oferuje xUnit (np. data driven tests) i Fluent Assertions (wygodne assertowanie). 
Ważne jest także przetestowanie warunków granicznych czy 'bad path' (np. sytuacji kiedy oczekujemy, że rzucony zostanie exception).

Całość oddajecie w formie 2 powiązanych projektów (kod produkcyjny + testy).

# Dla przypomnienia forma oddania zadania
Zadanie powinno być oddane w formie commitów na oddzielnym branchu o nazwie w konwecji `nrzadania_ImięNazwisko` (np: `10_PatrykSzwermer`)

Powodzenia :) 

# :clock3: Termin
## 29.09.2020, godz 24:00 
