---
title: Konfiguracja Demos
type: docs
weight: 40
url: /pl/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD dla JasperReports zawiera szereg projektów demo, które pomogą Ci rozpocząć.

Demos dostarczone z Aspose.CAD dla JasperReports to standardowe demonstracje JasperReports, zmodyfikowane w celu zademonstrowania użycia nowych eksporterów.

{{% /alert %}}

Aby uruchomić demonstracje Aspose.CAD dla JasperReports, wykonaj następujące kroki:

1. Pobierz JasperReports (np. https://sourceforge.net/projects/jasperreports/files/archive/). Upewnij się, że pobierasz cały archiwalny projekt z kodem źródłowym i demo, a nie tylko pojedynczy plik JAR.
1. Rozpakuj archiwalny projekt w dowolnej lokalizacji na dysku twardym, na przykład C:\.
1. Skopiuj wszystkie foldery demo z folderu \samples z **aspose-cad-xx.x.zip** do **\InstallDir\demo\samples**, gdzie "\InstallDir" to miejsce, w którym rozpakowałeś JasperReports. Ten krok jest wymagany, ponieważ skrypty budujące demo opierają się na strukturze folderów JasperReports, w przeciwnym razie będziesz musiał zmodyfikować skrypty budujące.
1. Skopiuj **aspose-cad-jasperreports-xx.x.jar** z folderu \lib z **aspose-cad-jasperreports-xx.x.zip** do **\InstallDir\lib**.
1. Przygotuj narzędzie do budowy Ant i menedżera zależności Ivy, zobacz **\InstallDir\readme.txt**.
1. Zmodyfikuj **build.xml** w **\InstallDir\demo\samples**, dodaj plik aspose-cad-jasperreports-xx.x.jar do classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Zmień bieżący katalog na **\InstallDir\demo\hsqldb** i uruchom następującą linię poleceń:
   **Ant runServer**
1. Zmień bieżący katalog na jeden z demonstracji Aspose.CAD dla JasperReports, na przykład **\InstallDir\demo\samples\charts.ai** i uruchom następujące polecenia w linii poleceń:
   **ant test** - aby wygenerować pliki raportów.
1. Otwórz jeden z powstałych dokumentów, aby go przeglądać, na przykład **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
