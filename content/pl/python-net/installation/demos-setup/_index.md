---
title: Konfiguracja Demos
type: docs
weight: 40
url: /pl/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD dla Pythona zawiera szereg projektów demo, które pomogą Ci zacząć.

Demos dostarczane z Aspose.CAD dla Pythona to standardowe demo Pythona zmodyfikowane w celu zaprezentowania możliwości nowych eksporterów.

{{% /alert %}}

Aby uruchomić demo Aspose.CAD dla Pythona, wykonaj następujące kroki:

1. Pobierz Pythona (np. https://sourceforge.net/projects/python-net/files/archive/). Upewnij się, że pobierasz cały archiwum projektu z kodem źródłowym i demo, a nie tylko pojedynczy plik JAR.
1. Rozpakuj archiwum projektu w wybranej lokalizacji na dysku twardym, na przykład C:\.
1. Skopiuj wszystkie foldery demo z folderu \samples z **aspose-cad-xx.x.zip** do **\InstallDir\demo\samples**, gdzie "\InstallDir" to lokalizacja, w której rozpakowałeś Pythona. Ten krok jest wymagany, ponieważ skrypty budowania demo polegają na strukturze folderów Pythona, w przeciwnym razie będziesz musiał zmodyfikować skrypty budowania.
1. Skopiuj **aspose-cad-pythons-xx.x.jar** z folderu \lib z **aspose-cad-pythons-xx.x.zip** do **\InstallDir\lib**.
1. Przygotuj narzędzie do budowania Ant i menedżera zależności Ivy, zobacz **\InstallDir\readme.txt**.
1. Zmodyfikuj **build.xml** w **\InstallDir\demo\samples**, dodaj aspose-cad-pythons-xx.x.jar do classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Zmień bieżący katalog na **\InstallDir\demo\hsqldb** i uruchom następującą linię poleceń:
   **ant runServer**
1. Zmień bieżący katalog na jeden z demo Aspose.CAD dla Pythona, na przykład **\InstallDir\demo\samples\charts.ai** i uruchom następujące polecenia w linii poleceń:
   **ant test** - aby wygenerować pliki raportów.
1. Otwórz jeden z powstałych dokumentów do podglądu, na przykład **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
