---
title: Jak uruchomić przykłady
type: docs
weight: 70
url: /pl/net/showcases/how-to-run-the-examples/
---

## **Wymagania sprzętowe**

Upewnij się, że spełniasz następujące wymagania przed pobraniem i uruchomieniem przykładów.

1. Visual Studio 2010 lub wyższy
1. Zainstalowany Menedżer pakietów NuGet w Visual Studio. Upewnij się, że najnowsza wersja API NuGet jest zainstalowana w Visual Studio. Po szczegóły dotyczące instalacji menedżera pakietów NuGet proszę sprawdzić https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. Przejdź do Narzędzia->Opcje->Menedżer pakietów NuGet->Źródła pakietów i upewnij się, że opcja **nuget.org** jest zaznaczona
1. Przykładowy projekt korzysta z funkcji automatycznego przywracania pakietów NuGet, dlatego powinieneś mieć aktywne połączenie z Internetem. Jeśli nie masz aktywnego połączenia z Internetem na maszynie, na której mają być uruchomione przykłady, sprawdź [Instalacja](/pl/cad/net/installation/) aby dodać odwołanie do Aspose.CAD.dll w projekcie przykładów.

## **Pobierz z GitHub**

Wszystkie przykłady Aspose.CAD dla .NET są hostowane na [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Możesz albo sklonować repozytorium za pomocą ulubionego klienta GitHub, albo pobrać plik ZIP [stąd](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Wypakuj zawartość pliku ZIP do dowolnego folderu na swoim komputerze. Wszystkie przykłady znajdują się w folderze **Examples**.
- Istnieje plik rozwiązań Visual Studio dla C#.
- Projekty zostały utworzone w Visual Studio 2013, ale pliki rozwiązań są zgodne z Visual Studio 2010 SP1 i wyższymi.
- Otwórz plik rozwiązań w Visual Studio i zbuduj projekt.
- Przy pierwszym uruchomieniu zależności zostaną automatycznie pobrane za pośrednictwem NuGet.
- Folder **Data** w głównym folderze **Examples** zawiera pliki wejściowe, które są używane przez przykłady CSharp. Ważne jest, abyś pobrał folder **Data** wraz z projektem przykładów.
- Otwórz plik RunExamples.cs, wszystkie przykłady są wywoływane stąd.
- Odkomentuj przykłady, które chcesz uruchomić w projekcie.

Jeśli masz jakiekolwiek problemy z konfiguracją lub uruchomieniem przykładów, nie wahaj się skontaktować z nami za pośrednictwem naszych forów.

## **Wnieś wkład**

Jeśli chcesz dodać lub poprawić przykład, zachęcamy do przyczynienia się do projektu. Wszystkie przykłady i projekty showcase w tym repozytorium są open source i mogą być swobodnie używane w twoich własnych aplikacjach.

Aby wnieść wkład, możesz forknąć repozytorium, edytować kod źródłowy i stworzyć pull request. Przejrzymy zmiany i dodamy je do repozytorium, jeśli uznamy, że są pomocne.
