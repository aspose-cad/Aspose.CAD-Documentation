---
title: Licencjonowanie
type: docs
weight: 50
url: /pl/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Możesz pobrać wersję próbną **Aspose.CAD** dla Javy z [strony pobierania](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). Wersja próbna oferuje dokładnie te same możliwości co licencjonowana wersja produktu. Ponadto, wersja próbna staje się licencjonowana, gdy zakupisz licencję i dodasz kilka linii kodu, aby zastosować licencję.

Kiedy będziesz zadowolony ze swojej oceny **Aspose.CAD**, możesz [zakupić licencję](https://purchase.aspose.com/buy) na stronie Aspose. Zapoznaj się z różnymi dostępnymi typami subskrypcyjnymi. Jeśli masz jakiekolwiek pytania, nie wahaj się skontaktować z zespołem sprzedaży Aspose.

Każda licencja Aspose obejmuje roczną subskrypcję na darmowe aktualizacje do wszelkich nowych wersji lub poprawek, które wyjdą w tym czasie. Wsparcie techniczne jest darmowe i nielimitowane oraz dostępne zarówno dla użytkowników licencjonowanych, jak i próbnych.

{{% /alert %}}

Jeśli chcesz przetestować **Aspose.CAD** bez ograniczeń wersji próbnej, poproś o 30-dniową tymczasową licencję. Więcej informacji znajdziesz w [Jak uzyskać tymczasową licencję?](https://purchase.aspose.com/temporary-license).

## **Ustawienie licencji**

Licencja to plik XML w formacie zwykłego tekstu, który zawiera szczegóły, takie jak nazwa produktu, liczba deweloperów, którym została przyznana licencja, data wygaśnięcia subskrypcji i tak dalej. Plik jest podpisany cyfrowo, więc nie modyfikuj pliku; nawet niezamierzone dodanie dodatkowego znaku nowej linii do pliku spowoduje jego unieważnienie.

Musisz ustawić licencję przed wykonaniem jakichkolwiek operacji na plikach AutoCAD. Licencję należy ustawić tylko raz na aplikację lub proces.

Licencja może być ładowana ze strumienia lub pliku w następujących lokalizacjach:

1. Wyraźna ścieżka.
1. Folder, który zawiera Aspose.CAD.jar.

Użyj metody License.setLicense(), aby licencjonować komponent. Często najłatwiejszym sposobem na ustawienie licencji jest umieszczenie pliku licencji w tym samym folderze co Aspose.CAD.jar i wskazanie tylko nazwy pliku bez ścieżki, jak pokazano w następującym przykładzie:

### **Przykład 1**

W tym przykładzie **Aspose.CAD** spróbuje znaleźć plik licencji w folderze, który zawiera JAR-y twojej aplikacji.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Przykład 2**

Inicjalizuje licencję ze strumienia.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Weryfikacja licencji**

Możliwe jest zweryfikowanie, czy licencja została poprawnie ustawiona, czy nie. Klasa License ma pole isLicensed, które zwróci true, jeśli licencja została poprawnie ustawiona.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Licencja została ustawiona!");

}

{{< /highlight >}}
