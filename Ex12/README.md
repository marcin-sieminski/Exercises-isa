# Zad 12. SQL

## Baza danych

Zaprojektuj bazę danych dla salonów fryzjerskich i obsługi rezerwacji.
Baza powinna zawierać co najmniej następujące tabele (kolumny zaproponujcie sami ! ):

1. Studio - informacja o konkretnym salonie (nazwa, adres, itp.)
2. Employee - pracownik salonu (fryzjer/barber) - przypisany do salonu (studio)
3. Treatment - rodzaj usługi (strzyzenie meskie, damskie, broda, itp.; cena)
4. Visit - rezerwacja wizyty do konkretnego fryzjera na konkretną datę i godzinę
Dodatkowe tabele wedle uznania.

Narysuj diagram ERD na podstawie informacji zawartych w poniższym tutorialu:
https://www.lucidchart.com/pages/er-diagrams 
Jest kilka mozliwych notacji, ale polecam użyć: "Crow’s Foot/Martin/Information Engineering style" (czyli takie „kurze łapki” jak na przykładowym diagramie) - oczywiscie mozna uzyc do tego właśnie lucidcharta lub ewentualnie diagrams.net
 
`Przykładowy diagram dołączony jako oddzielny plik na repo. Z jakiegoś powodu nie mogłem go wkleić bezpośrednio do readme...`
 
## SQL
 
1. Napisz skrypty tworzące bazę danych i tabelę zgodnie z zaprojektowanym diagramem (podobnie jak nasz pierwszy skrypt z zajęć) - tabele mogą być wyklikane w "designerze" w SSMS a następnie można z nich wygenerować skrypt - ale pamiętaj aby usunąć niepotrzebne instrukcje typu: 

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Pamiętaj o użyciu instrukcji 
USE <Database_Name>
GO
Aby tabele nie utworzyły się w bazie systemowej master ! 
Do zdefiniowania kluczy obcych wzoruj się na skrypcie z zajęć. 

2. Napisz skrypt 
z danymi początkowymi (tzw. seed data), który wykona po kilknaście insertów do każdej z tabel, aby następnie móc na tej bazie wykonać zapytania.

3. Napisz następujące zapytania:
a) Wyświetl ile pracowników ma każdy salon
b) Wyświetl ile godzin w miesiącu przepracował każdy pracownik (ile faktycznie wykonał usług)
c) Wyświetl ile razy wykonane zostały poszczególne usługi
d) Wyświetl ile poszczególne salony zarobiły na różnych usługach
e) Wyświetl jakie usługi nie zostały wykonane ani razu
f) Wyświetl w jakich godzinach jest najwięcej rezerwacji

Każde dodatkowe zapytanie mile widziane!

# :clock3: Termin
## 25.10.2020, godz 15:00 
