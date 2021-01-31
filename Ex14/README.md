# Zad 14. Loggery

Waszym zadaniem jest utworzenie aplikacji ASP.NET Core, najlepiej API, ze skonfigurowanym logowaniem:

1. zapisywanie logów na minimalnym poziomie Information do pliku (można użyć serilog lub innego providera, np. NLog, Log4Net)
2. zapisywanie logów na poziomie Debug do konsoli -z użyciem logowania wbudowanego NET Core.
3. konfiguracja logów powinna być zamieszczona w pliku appsettings.json (lub innym jesli wymaga tego biblioteka) -zarówno dla logów NetCore jak i dla 3rd party providera (np Serilog)

4. Zaloguj z odpowiednim Twoim zdaniem poziomem informacji:
- Start aplikacji
- Wywołanie metody kontrolera api
- Błąd wewnątrz powyżej metody (można np wymusić Exception i go przechwycić)

Przydatne linki:
- https://wakeupandcode.com/logging-in-asp-net-core-3-1/#config
- https://github.com/serilog/serilog/wiki/Configuration-Basics
- https://github.com/serilog/serilog-settings-configuration
- https://github.com/nlog/nlog/wiki/Configuration-file

# Dla przypomnienia forma oddania zadania
Zadanie powinno być oddane w formie commitów na oddzielnym branchu o nazwie w konwecji `nrzadania_ImięNazwisko` (np: `14_PatrykSzwermer`)

Powodzenia :) 

# :clock3: Termin
## 01.11.2020, godz 24:00 
