---
title: Jak uruchomić przykłady
type: docs
weight: 70
url: /pl/java/getting-started/how-to-run-the-examples/
---

## **Pobierz z GitHub**

Wszystkie przykłady Aspose.CAD dla Java są hostowane na [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Możesz sklonować repozytorium za pomocą swojego ulubionego klienta Github lub pobrać plik ZIP [stąd](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Rozpakuj zawartość pliku ZIP do dowolnego folderu na swoim komputerze. Wszystkie przykłady znajdują się w folderze **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Rysunek: Katalog Przykładów Aspose.CAD**|

## **Importuj przykłady do IDE**

Projekt korzysta z systemu budowania Maven. Każde nowoczesne IDE może łatwo otworzyć lub zaimportować projekt oraz jego zależności. Poniżej pokazujemy, jak używać popularnych IDE do budowy i uruchamiania przykładów.

### **IntelliJ IDEA**

Kliknij na menu **File** i wybierz **Open**. Przejdź do folderu projektu i wybierz plik **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Rysunek: Wybierz plik lub katalog do importu**|
Otworzy to projekt i automatycznie pobierze zależności. Z zakładki Projekt przeglądaj przykłady w folderze **src/main/java**. Aby uruchomić przykład, kliknij prawym przyciskiem myszy na plik i wybierz "Run ..", przykład zostanie wykonany, a wynik zostanie wyświetlony w wbudowanym oknie konsoli.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Rysunek: Uruchom przykład**|

### **Eclipse**

Kliknij na menu **File** i wybierz **Import**. Wybierz **Maven** - Istniejące projekty Maven.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Rysunek: Importuj**|
Przejdź do folderu, który sklonowałeś lub pobrałeś z GitHub i wybierz plik **pom.xml**. Otworzy to projekt i automatycznie pobierze zależności. Z zakładki Package Explorer przeglądaj przykłady w folderze **src/main/java**. Aby uruchomić przykład, kliknij prawym przyciskiem myszy na plik i wybierz **Run As** - **Java Application**, przykład zostanie wykonany, a wynik zostanie wyświetlony w wbudowanym oknie konsoli.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Rysunek: Uruchom przykład**|

### **NetBeans**

Kliknij na menu **File** i wybierz **Open Project**. Przejdź do folderu, który sklonowałeś lub pobrałeś z GitHub. Ikona folderu **Examples** pokaże, że jest to projekt Maven. Wybierz Examples i otwórz go.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Rysunek: Otwórz projekt**|
Otworzy to projekt i automatycznie pobierze zależności. Z zakładki Projects przeglądaj przykłady w **source packages**. Aby uruchomić przykład, kliknij prawym przyciskiem myszy na plik i wybierz **Run File**, przykład zostanie wykonany, a wynik zostanie wyświetlony w wbudowanym oknie konsoli.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Rysunek: Uruchom przykład**|

## **Dodawanie biblioteki Aspose.CAD do lokalnego repozytorium Maven**

Gdy importujesz projekt **Aspose.CAD Examples** do IDE, Maven automatycznie pobiera plik JAR aspose.cad z [Aspose Maven Repository](https://releases.aspose.com/java/repo/). W przypadku braku dostępu do internetu, możesz ręcznie dodać plik JAR do swojego lokalnego repozytorium.

### **mvn install**

Pobierz [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), rozpakuj go i skopiuj plik aspose.cad-version.jar gdzie indziej, na przykład, na dysk C. Wydaj następujące polecenie:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Teraz plik **aspose.cad** jar został skopiowany do twojego lokalnego repozytorium Maven.

### **pom.xml**

Po zainstalowaniu, po prostu zadeklaruj koordynaty **aspose.cad** w pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Zrobione**

Zbuduj, teraz plik **aspose.cad** jar jest dostępny w twoim lokalnym repozytorium Maven.

## **Współpraca**

Jeśli chcesz dodać lub poprawić przykład, zachęcamy cię do wniesienia wkładu do projektu. Wszystkie przykłady i projekty pokazowe w tym repozytorium są open source i mogą być swobodnie używane w twoich aplikacjach.

Aby przyczynić się, możesz forkować repozytorium, edytować kod źródłowy i złożyć Pull Request. Przejrzymy zmiany i włączymy je do repozytorium, jeśli uznamy je za pomocne.
