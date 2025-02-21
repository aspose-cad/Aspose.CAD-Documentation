---
title: Licencjonowanie
type: docs
weight: 50
url: /pl/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Gdy już będziesz zadowolony z oceny Aspose.CAD dla .NET, kup licencję na stronie Aspose: [Portal Zakupu](https://purchase.aspose.com/buy). Zapoznaj się z różnymi dostępnymi typami licencji. Jeśli masz pytania, [skontaktuj się z zespołem sprzedaży Aspose](https://about.aspose.com/contact), a chętnie ci pomogą.

Każda licencja Aspose obejmuje roczną subskrypcję na darmowe aktualizacje do wszelkich nowych wersji lub poprawek, które zostaną wydane w tym czasie. Oferujemy darmową i nieograniczoną pomoc techniczną zarówno dla użytkowników posiadających licencje, jak i dla użytkowników oceniających.

Licencja jest prostym plikiem XML, który zawiera szczegóły takie jak nazwa produktu, liczba licencjonowanych programistów, data wygaśnięcia subskrypcji itd. Plik jest podpisany cyfrowo, więc nie modyfikuj pliku: nawet dodanie dodatkowego znaku nowej linii do pliku unieważnia go.

{{% /alert %}}

## **Kiedy zastosować licencję**

Przestrzegaj tych prostych zasad:

- Licencję należy ustawić tylko raz na każdy obszar aplikacji.
- Musisz ustawić licencję przed użyciem jakichkolwiek innych klas Aspose.CAD.
- Wywoływanie SetLicense wielokrotnie nie jest szkodliwe, ale marnuje czas procesora.
- Jeśli rozwijasz aplikację Windows Forms lub aplikację konsolową, wywołaj SetLicense w kodzie uruchamiającym, przed użyciem klas Aspose.CAD.
- Tworząc aplikację ASP.NET, wywołaj SetLicense z pliku Global.asax.cs (Global.asax.vb) w chronionej metodzie Application_Start. Jest wywoływana raz, gdy aplikacja się uruchamia.
- Nie wywołuj SetLicense wewnątrz metod Page_Load, ponieważ oznacza to, że licencja będzie ładowana za każdym razem, gdy ładowana jest strona internetowa.
- Jeśli rozwijasz bibliotekę klas, wywołujesz SetLicense z konstruktorów statycznych klasy, która używa Aspose.CAD. Konstruktor statyczny wykonuje się zanim instancja twojej klasy zostanie utworzona, upewniając się, że licencja Aspose.CAD jest poprawnie ustawiona.

## **Zastosowanie licencji przy użyciu pliku lub obiektu strumienia**

Użyj metody **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)**, aby licencjonować komponent. Najłatwiej jest ustawić licencję, umieszczając plik licencji w tym samym folderze co Aspose.CAD.dll i określając nazwę pliku, bez ścieżki, jak pokazano poniżej.

### **Ładowanie licencji z pliku**

Ten fragment kodu inicjalizuje licencję przechowywaną w pliku lub w zasobach osadzonych.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Ładowanie licencji z obiektu strumienia**

Ten fragment kodu inicjalizuje licencję ze strumienia.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
