# Zad 6. Struktury danych i operacje na plikach

Napisz program, który wykona następujace kroki:

1. Utworz liste Zadań do zrobienia (Assignment), minimum 10 elementów - wygenerowanych losowo lub utworzonych ręcznie. Klasa "Assignment" powinna zawierać co najmniej 3 pola, w tym na pewno nazwa i data utworzenia danego zadania w czasie uniwersalnym (UTC).
2. Zapisz listę do pliku tekstowego używając serializatora Xml (klasa XmlSerializer - na podstawie przykładu z kodu który pobieżnie pokazany został na zajęciach). Plik powinien zostać zapisany na dysku C w katalogu "Temp\homework\datastructures\assignments.xml". Jeżeli którykolwiek katalog nie istnieje należy go utworzyć (za pomocą jednej z metod statycznej klasy Directory lub za pomocą klasy "DirectoryInfo".
3. Lista elementów powinna zostać wczytana z powrotem ale tym razem do Kolejki (Queue<Assignment>) - w tym celu należy użyć metody Deserialize ale już na nowym serializatorze.
4. Każdy z elementów kolejki powinien zostać przetworzony (kolejka powinna być na końcu pusta). Przetworzenie elementu powinno wyświetlić jego nazwę oraz informację ile czasu minęło od utworzenia zadania do jego przetworzenia (w milisekundach) oraz o której godzinie czasu polskiego zadanie zostało utworzone.
5. Po przetworzeniu wszystkich elementów użytkownik powinien zobaczyć komunikat mówiący o tym, że kolejka jest pusta i program się zakonczył.
  
# Dla przypomnienia forma oddania zadania
Zadanie powinno być oddane w formie commitów na oddzielnym branchu o nazwie w konwecji `nrzadania_ImięNazwisko` (np: `6_PatrykSzwermer`)

Powodzenia :) 

# :clock3: Termin
## 30.08.2020, godz 15:00 

