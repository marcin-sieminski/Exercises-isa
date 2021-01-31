# Zad 13. EFC

Waszym zadaniem jest utworzenie działającej solucji implementującej użycie bazy danych z wykorzystaniem Entity Framework Core.
Kroki do wykonania:
1. Utworzyć projekt MVC, dodać do niego Entity Framework Core.
2. Poprawnie skonfigurować Entity Framework Core tak, żeby działał z lokalną bazą danych.
3. Utworzyć 3 tabele w bazie danych bazując na klasach:
Teacher <--< Uczeń <---< Ocena   (`<---<` - relacja jeden do wielu). Każda z tabeli powinna mieć conajmniej 2-3 properties'y, najlepiej różnego typu. Możecie sami wymyślić jakie :)
4. Dodać logikę, która przy pierwszym starcie aplikacji wygeneruję kilku nauczycieli (może być 3)
5. Dodać bardzo prosty interfejs, który pozwoli na utworzenie nowego ucznia z możliwością wybrania mu nauczyciela, oraz dodawanie oceny dla wybranego ucznia.
6. (Opcjonalne) Dodać warstwę reposytorium do komunikacji z bazą danych. (Polecam przynajmniej zapoznać się z tematem i spróbować! Przykład implementacji możecie znaleźć np. tutaj: https://codewithshadman.com/repository-pattern-csharp/)

# Dla przypomnienia forma oddania zadania
Zadanie powinno być oddane w formie commitów na oddzielnym branchu o nazwie w konwecji `nrzadania_ImięNazwisko` (np: `13_PatrykSzwermer`)

Powodzenia :) 

# :clock3: Termin
## 25.10.2020, godz 24:00 
