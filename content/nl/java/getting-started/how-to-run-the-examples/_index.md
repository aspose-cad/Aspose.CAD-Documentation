---
title: Hoe de Voorbeelden te Runnen
type: docs
weight: 70
url: /nl/java/getting-started/how-to-run-the-examples/
---

## **Download van GitHub**

Alle voorbeelden van Aspose.CAD voor Java zijn gehost op [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Je kunt de repository ofwel klonen met je favoriete Github-client of het ZIP-bestand hier downloaden: [hier](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Extraheer de inhoud van het ZIP-bestand naar een map op je computer. Alle voorbeelden zijn te vinden in de **Voorbeelden** map.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figuur: Aspose.CAD Voorbeelden Directories**|

## **Voorbeelden importeren in de IDE**

Het project maakt gebruik van het Maven-buildsysteem. Elke moderne IDE kan het project en zijn afhankelijkheden eenvoudig openen of importeren. Hieronder laten we je zien hoe je populaire IDE's kunt gebruiken om de voorbeelden te bouwen en uit te voeren.

### **IntelliJ IDEA**

Klik op het **Bestand** menu en kies **Openen**. Blader naar de projectmap en selecteer het **pom.xml** bestand.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Figuur: Selecteer Bestand of Map om te Importeren**|
Het opent het project en downloadt automatisch de afhankelijkheden. Vanuit het Project-tabblad, blader naar de voorbeelden in de **src/main/java** map. Om een voorbeeld uit te voeren, klik je met de rechtermuisknop op het bestand en kies je "Run ..", het voorbeeld wordt uitgevoerd en de uitvoer wordt weergegeven in het ingebouwde console-uitvoervenster.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Figuur: Voer Voorbeeld Uit**|

### **Eclipse**

Klik op het **Bestand** menu en kies **Importeren**. Selecteer **Maven** - Bestaande Maven-projecten.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Figuur: Importeren**|
Blader naar de map die je van GitHub hebt gekloond of gedownload en selecteer het **pom.xml** bestand. Het opent het project en downloadt automatisch de afhankelijkheden. Vanuit het Package Explorer-tabblad, blader naar de voorbeelden in de **src/main/java** map. Om een voorbeeld uit te voeren, klik je met de rechtermuisknop op het bestand en kies je **Run As** - **Java-toepassing**, het voorbeeld wordt uitgevoerd en de uitvoer wordt weergegeven in het ingebouwde console-uitvoervenster.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figuur: Voer Voorbeeld Uit**|

### **NetBeans**

Klik op het **Bestand** menu en kies **Open Project**. Blader naar de map die je van GitHub hebt gekloond of gedownload. Het pictogram van de **Voorbeelden** map laat zien dat het een Maven-project is. Selecteer Voorbeelden en open deze.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Figuur: Open Project**|
Het opent het project en downloadt automatisch de afhankelijkheden. Vanuit het Project-tabblad, blader naar de voorbeelden in de **source packages**. Om een voorbeeld uit te voeren, klik je met de rechtermuisknop op het bestand en kies je **Run File**, het voorbeeld wordt uitgevoerd en de uitvoer wordt weergegeven in het ingebouwde console-uitvoervenster.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Figuur: Voer Voorbeeld Uit**|

## **Aspose.CAD Bibliotheek toevoegen aan Maven Lokale Repository**

Wanneer je het **Aspose.CAD Voorbeelden** project in de IDE importeert, downloadt Maven automatisch het aspose.cad JAR-bestand van [Aspose Maven Repository](https://releases.aspose.com/java/repo/). In het geval je geen toegang tot internet hebt, kun je handmatig het JAR-bestand aan je lokale repository toevoegen.

### **mvn install**

Download de [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), extraheer het en kopieer het aspose.cad-version.jar ergens anders heen, bijvoorbeeld naar de C-schijf. Geef de volgende opdracht:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Nu is de **aspose.cad** jar gekopieerd naar je Maven lokale repository.

### **pom.xml**

Na installatie, verklaar gewoon de **aspose.cad** coördinaat in pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Klaar**

Bouw het, nu kan de **aspose.cad** jar worden opgehaald uit je Maven lokale repository.

## **Bijdragen**

Als je een voorbeeld wilt toevoegen of verbeteren, moedigen we je aan om bij te dragen aan het project. Alle voorbeelden en showcase-projecten in deze repository zijn open source en kunnen vrij worden gebruikt in je eigen toepassingen.

Om bij te dragen, kun je de repository forkeren, de broncode bewerken en een Pull Request indienen. We zullen de wijzigingen bekijken en deze in de repository opnemen als ze nuttig worden bevonden.
