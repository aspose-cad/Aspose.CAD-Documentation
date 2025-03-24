---
title: Instalacja
type: docs
weight: 30
url: /pl/net/getting-started/installation/
---

## **Instalacja Aspose.CAD dla .NET za pomocą NuGet**

NuGet to najprostszy sposób na pobranie i zainstalowanie API Aspose dla .NET. Otwórz Microsoft Visual Studio i menedżera pakietów NuGet. Wyszukaj "aspose", aby znaleźć żądane API Aspose. Kliknij "Zainstaluj", wybrane API zostanie pobrane i dodane do twojego projektu.

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **Dodawanie odniesienia do Aspose.CAD z projektu .NET**

Wykonaj następujące kroki (zakładając, że używasz Microsoft Visual Studio):

1. W **Eksploratorze rozwiązań**, rozwiń węzeł projektu, do którego chcesz dodać odwołanie.
1. Kliknij prawym przyciskiem myszy węzeł **Odniesienia** dla projektu i wybierz **Dodaj odwołanie** z menu kontekstowego.
1. W oknie dialogowym **Dodaj odwołanie** przeglądaj do lokalizacji pliku DLL.
1. Wybierz plik DLL *Aspose.CAD* i kliknij przycisk **OK**.
1. Odwołanie *Aspose.CAD* pojawi się pod węzłem **Odniesienia** twojego projektu.

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **Zainstaluj lub zaktualizuj Aspose.CAD za pomocą konsoli menedżera pakietów**

Możesz wykonać poniższe kroki, aby dodać odniesienie do [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) za pomocą konsoli menedżera pakietów:

1. Otwórz swoje rozwiązanie/projekt w Visual Studio.
1. Wybierz Narzędzia -> Menedżer pakietów bibliotek -> Konsola menedżera pakietów z menu, aby otworzyć konsolę menedżera pakietów.

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

Wpisz polecenie “**Install-Package Aspose.CAD**” i naciśnij enter, aby zainstalować najnowszą pełną wersję w swojej aplikacji. Alternatywnie możesz dodać sufiks "**-prerelease**" do polecenia, aby wskazać, że ma być zainstalowana najnowsza wersja, w tym poprawki.

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

Zobaczysz, że wskazówka "Pobieranie Aspose.CAD..." pojawia się w dolnym lewym rogu okna, co wskazuje, że proces pobierania przebiega.

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

Po pobraniu zobaczysz następujące komunikaty potwierdzające. Jeśli nie jesteś zaznajomiony z [EULA Aspose](https://about.aspose.com/legal/eula), to dobrze jest przeczytać licencję podaną w URL.

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

Teraz powinieneś znaleźć, że Aspose.CAD został pomyślnie dodany i dodany do twojej aplikacji.

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

W konsoli menedżera pakietów możesz również użyć polecenia “**Update-Package Aspose.CAD**” i nacisnąć enter, aby sprawdzić aktualizacje dla pakietu Aspose.CAD i zainstalować je, jeśli są dostępne. Możesz również dodać sufiks "-prerelease", aby zaktualizować najnowszą wersję.

## **Uwagi przy uruchamianiu na wspólnym środowisku serwera**

Wszystkie komponenty Aspose .NET zaleca się uruchamiać z pełnymi uprawnieniami. Wynika to z faktu, że komponenty Aspose .NET czasami muszą uzyskać dostęp do ustawień rejestru i plików znajdujących się w innych lokalizacjach niż wirtualny katalog, np. do odczytu czcionek itd. Ponadto komponenty Aspose.NET bazują na podstawowych klasach systemu .NET, z których niektóre również wymagają pełnych uprawnień, aby działać w niektórych przypadkach.

Dostawcy usług internetowych, którzy hostują wiele aplikacji z różnych firm, w większości przypadków egzekwują poziom zabezpieczeń Medium Trust. W przypadku .NET 2.0, taki poziom zabezpieczeń może nałożyć następujące ograniczenia, które mogą wpłynąć na zdolność Aspose.CAD do poprawnego działania.

- **RegistryPermission** jest niedostępne. Oznacza to, że nie możesz uzyskać dostępu do rejestru, co jest wymagane do enumerowania zainstalowanych czcionek podczas renderowania dokumentów.
- **FileIOPermission** jest ograniczone. Oznacza to, że możesz uzyskać dostęp tylko do plików w hierarchii katalogów wirtualnych aplikacji. To potencjalnie oznacza, że czcionki mogą nie być odczytywane podczas eksportu.

Z tych powodów, o których mowa powyżej, zaleca się uruchamianie Aspose.CAD z pełnymi uprawnieniami. Możesz zauważyć, że niektóre funkcje biblioteki będą działać podczas wykonywania różnych zadań w Medium Trust, podczas gdy inne nie będą (na przykład renderowanie), co może być spowodowane wywołaniami do przetwarzania obrazów GDI+.

## **Wymagania systemowe**

### **Systemy operacyjne**

Aspose.CAD dla .NET obsługuje każdy 32-bitowy lub 64-bitowy system operacyjny, na którym zainstalowany jest framework .NET lub Mono, w tym, ale nie ograniczając się do:

- Microsoft Windows desktop (XP, Vista, 7, 8, 10) i systemy operacyjne serwerowe (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS i inne)
- Mac OS X

### **Frameworki**

Aspose.CAD dla .NET obsługuje:

- Wersje .NET Framework od 2.0 do 4.5, w tym wersje Client Profile
- .NET Core
- Mono 2.6.7 lub nowsze

### **Środowiska programistyczne**

Możesz używać Aspose.CAD dla .NET do tworzenia aplikacji w dowolnym środowisku programistycznym, które obsługuje platformę .NET, ale następujące środowiska są wyraźnie wspierane:

- Microsoft Visual Studio 2010 lub nowsze
- MonoDevelop 2.4 i nowsze
