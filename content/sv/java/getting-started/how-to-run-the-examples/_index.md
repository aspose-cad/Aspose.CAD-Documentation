---
title: Hur man kör exemplen
type: docs
weight: 70
url: /sv/java/getting-started/how-to-run-the-examples/
---

## **Ladda ner från GitHub**

Alla exempel på Aspose.CAD för Java finns på [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Du kan antingen klona det här förrådet med hjälp av din favorits Github-klient eller ladda ner ZIP-filen från [här](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Extrahera innehållet i ZIP-filen till en mapp på din dator. Alla exempel ligger i mappen **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Bild: Aspose.CAD Exempel Katalog**|

## **Importera exempel till IDE:n**

Projektet använder Maven-byggsystem. Vilken modern IDE som helst kan enkelt öppna eller importera projektet och dess beroenden. Nedan visar vi hur man använder populära IDE:er för att bygga och köra exemplen.

### **IntelliJ IDEA**

Klicka på menyn **File** och välj **Open**. Bläddra till projektmappen och välj **pom.xml**-filen.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Bild: Välj fil eller mapp att importera**|
Det öppnar projektet och laddar automatiskt ner beroendena. Från fliken Projekt, bläddra till exemplen i mappen **src/main/java**. För att köra ett exempel, högerklicka bara på filen och välj "Run ..", exemplet kommer att köras och resultatet kommer att visas i den inbyggda konsolutskriftens fönster.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Bild: Kör exempel**|

### **Eclipse**

Klicka på menyn **File** och välj **Import**. Välj **Maven** - Befintliga Maven-projekt.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Bild: Importera**|
Bläddra till mappen som du klonade eller laddade ner från GitHub och välj **pom.xml**-filen. Det öppnar projektet och laddar automatiskt ner beroendena. Från fliken Package Explorer, bläddra till exemplen i mappen **src/main/java**. För att köra ett exempel, högerklicka bara på filen och välj **Run As** - **Java Application**, exemplet kommer att köras och resultatet kommer att visas i den inbyggda konsolutskriftens fönster.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Bild: Kör exempel**|

### **NetBeans**

Klicka på menyn **File** och välj **Open Project**. Bläddra till mappen som du klonade eller laddade ner från GitHub. Ikonen för **Examples**-mappen kommer att visa att det är ett Maven-projekt. Välj Examples och öppna det.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Bild: Öppna projekt**|
Det öppnar projektet och laddar automatiskt ner beroendena. Från fliken Projects, bläddra till exemplen i **source packages**. För att köra ett exempel, högerklicka bara på filen och välj **Run File**, exemplet kommer att köras och resultatet kommer att visas i den inbyggda konsolutskriftens fönster.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Bild: Kör exempel**|

## **Lägga till Aspose.CAD-biblioteket i Maven-lokala bibliotek**

När du importerar **Aspose.CAD Examples**-projektet till IDE:n, laddar Maven automatiskt ner aspose.cad JAR-filen från [Aspose Maven Repository](https://releases.aspose.com/java/repo/). Om du inte har internetåtkomst kan du manuellt lägga till JAR-filen i ditt lokala bibliotek.

### **mvn install**

Ladda ner [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), extrahera det och kopiera aspose.cad-version.jar till en annan plats, till exempel C:-. Kör följande kommando:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Nu har **aspose.cad**-jarfilen kopierats till ditt lokala Maven-bibliotek.

### **pom.xml**

Efter installationen, deklarera bara **aspose.cad**-koordinaten i pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Färdigt**

Bygg det, nu kan **aspose.cad**-jarfilen hämtas från ditt lokala Maven-bibliotek.

## **Bidra**

Om du vill lägga till eller förbättra ett exempel, uppmuntrar vi dig att bidra till projektet. Alla exempel och demonstreringsprojekt i detta förråd är öppen källkod och kan fritt användas i dina egna applikationer.

För att bidra kan du forka förrådet, redigera källkoden och skicka en Pull Request. Vi kommer att granska ändringar och inkludera dem i förrådet om de anses vara hjälpsamma.
