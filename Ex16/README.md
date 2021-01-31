# Zad 16. REST API part 1

Waszym zadaniem jest stworzenie prostej aplikacji typu API, reprezentującej zarządzanie produktami w sklepie, która wystawi następujące endpoint'y:

1. Utworzenie nowego produktu. Model produktu powinien zawierać: ID (tworzone po stronie API, nie powinno być przekazywane w DTO!), Name, Price, Type (Enum z wartościami Food, Drink, Other)
2. Aktualizacja już istniejącego produktu. Jeśli takowy nie istnieje, endpoint powinien zwracać 500'kę.
3. Odczytanie wszystkich produktów.
4. Odczytanie konkretnego produktu po ID.
5. Usunięcie produktu na bazie ID.
6. Użyjcie automappera w celu przemapowania DTO na model produktu w miejscach, gdzie jest to potrzebne.


Nie musicie implementować warstwy bazy danych, produkty mogą być przechowywane w prostej, statycznej liście. Pamiętajcie, aby wykonać komunikację porządnie, wykorzystując DTO'sy, oraz odpowiednie metody HTTP. Polecam testować postmanem, za jego pomocą również będę testował działanie waszych programów.

# Dla przypomnienia forma oddania zadania
Zadanie powinno być oddane w formie commitów na oddzielnym branchu o nazwie w konwecji `nrzadania_ImięNazwisko` (np: `16_PatrykSzwermer`)

Powodzenia :) 

# :clock3: Termin
## 21.11.2020, godz 15:00 
