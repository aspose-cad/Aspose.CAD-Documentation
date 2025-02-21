---
title: CAD-tekeningen converteren naar PDF en rasterafbeeldingsformaten
type: docs
weight: 30
url: /nl/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD voor Java schrijft direct de informatie over API en versienummer in uitvoerdocumenten. Bijvoorbeeld, bij het renderen van een document naar PDF, vult Aspose.CAD voor Java het Toepassing-veld in met de waarde 'Aspose.CAD' en het PDF Producer-veld met een waarde, bijv. 'Aspose.CAD v 17.9'.

Houd er rekening mee dat je Aspose.CAD voor Java niet kunt instrueren om deze informatie te veranderen of te verwijderen uit uitvoerdocumenten.

{{% /alert %}} 
## **CAD-tekeningen naar rasterafbeeldingsformaten converteren**
Aspose.CAD voor Java is in staat om CAD-tekeningformaten zoals [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) te converteren naar de ondersteunde rasterafbeeldingsformaten zoals [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). De Aspose.CAD API voor Java heeft efficiënte en gebruiksvriendelijke middelen blootgesteld om dit doel te bereiken.
Je kunt elk ondersteund CAD-tekeningformaat naar rasterafbeeldingsformaten converteren met behulp van de eenvoudige stappen die hieronder zijn uitgelegd.

1. Laad het CAD-bestand in een instantie van [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Maak een instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) en stel de vereiste eigenschappen in zoals [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Maak een instantie van **ImageOptionsBase** en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in op de instantie van **CadRasterizationOptions** die in de vorige stap is gemaakt.
1. Roep **Image.save** aan door het bestandspad (of een object van MemoryStream) door te geven, evenals de instantie van [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) die in de vorige stap is gemaakt.

Hier is de complete broncode.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Standaard renderen de API alleen de "Model" lay-out. Je kunt echter ook de lay-outs van jouw keuze specificeren bij het converteren van CAD-tekeningen naar afbeeldingsformaten.
## **CAD-conversie aanpassen**
De procedures voor CAD naar [PDF](https://docs.fileformat.com/pdf/) & CAD naar rasterafbeelding conversies zijn zeer configureerbaar, omdat de [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse is geïmplementeerd op een manier die veel optionele functies biedt die, indien ingesteld, het renderingsproces kunnen overschrijven volgens de behoeften van de applicatie.
### **CadRasterizationOptions Klasse**
De [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse is gemeenschappelijk voor alle ondersteunde CAD-formaten zoals [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/), daarom is de informatie die in dit artikel wordt gedeeld geldig voor beide genoemde CAD-formaten.

De meest nuttige eigenschappen van de **CadRasterizationOptions** klasse zijn:

|**Eigenschap**|**Standaardwaarde**|**Vereist**|**Beschrijving**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ja|Geeft de paginabreedte aan.|
|**PageHeight**|**0**|Ja|Geeft de paginahoogte aan.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nee|Geeft aan of de tekening automatisch geschaald moet worden. De standaardwaarde verkleint de afbeelding automatisch om in de canvasmaat te passen. Schakel over naar de **GrowToFit** modus, of gebruik de **None** instelling om automatische schaling uit te schakelen.|
|**BackgroundColor**|**Color.White**|Nee|Geeft de achtergrondkleur van de uitvoer afbeelding aan.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nee|Geeft de kleuriseringsmodus van de entiteit aan. Specificeren van de **UseObjectColor** optie om entiteiten met hun eigen kleur te tekenen, of de **UseDrawColor** optie om de oorspronkelijke kleuren te overschrijven.|
|**DrawColor**|**Color.Black**|Nee|Geeft de overschreven kleur van de entiteit aan (alleen als **DrawType** is ingesteld op de waarde van de **UseDrawColor** eigenschap).|
|**AutomaticLayoutsScaling**|False|Nee|Geeft aan of automatische lay-out schaling moet worden uitgevoerd om overeen te komen met de Model lay-out.|
### **Canvasgrootte en modus instellen**
Exporteren van CAD naar PDF of CAD naar rasterafbeeldingsformaten is geen triviale taak. Aangezien de resulterende PDF of afbeelding de canvasgrootte moet worden gedefinieerd, moeten we de uitvoerdimensies voor de PDF-pagina opgeven om de tekening correct weer te geven. Stel expliciet de **CadRasterizationOptions.PageWidth** en **CadRasterizationOptions.PageHeight** eigenschappen in, of je kunt een **ImageSaveException** krijgen.

Bovendien kun je dimensionale schaling opties specificeren. De schaalopties worden ingesteld door de **CadRasterizationOptions.ScaleMethod** eigenschap. Gebruik deze optie om de afbeeldingsdimensies automatisch aan te passen volgens de waarden van **CadRasterizationOptions.PageWidth** en **CadRasterizationOptions.PageHeight**. Standaard is **CadRasterizationOptions.ScaleMethod** ingesteld op **ScaleType.ShrinkToFit** modus. Deze eigenschap definieert het volgende gedrag:

- Als de afmetingen van de CAD-tekening groter zijn dan de resulterende canvasgrootte, worden de afmetingen van de tekening verkleind om in de resulterende canvas te passen, waarbij de aspectverhouding behouden blijft.
- Als de afmetingen van de CAD-tekening kleiner zijn dan de resulterende canvasgrootte, stel dan de **CadRasterizationOptions.ScaleMethod** eigenschap in op **ScaleType.GrowToFit** om de grootte van de tekening te vergroten zodat deze in de PDF-canvas past, terwijl de aspectverhouding behouden blijft.
- Of schakel automatische schaling uit met de **ScaleType.None** optie.

Het onderstaande codevoorbeeld toont de automatische schaling optie in gebruik.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Achtergrond- en tekenkleuren instellen**
Standaard is het kleurenpalet voor de resulterende canvas ingesteld op het algemene documentenschema. Dat betekent dat alle entiteiten binnen de CAD-tekening worden getekend met een zwart kleurpen op een effen witte achtergrond. Deze instellingen kunnen worden gewijzigd met de **CadRasterizationOptions.BackgroundColor** en **CadRasterizationOptions.DrawColor** eigenschappen. Het wijzigen van de **CadRasterizationOptions.DrawColor** eigenschap vereist ook het instellen van de **CadRasterizationOptions.DrawType** eigenschap om gebruik te maken van de tekeningkleur die moet worden gebruikt. De **CadRasterizationOptions.DrawType** eigenschap bepaalt of CAD-entiteiten hun kleuren behouden of worden omgezet naar aangepaste kleuren. Om de kleuren van entiteiten te behouden, stel je **CadRasterizationOptions.DrawType** in als **CadDrawTypeMode.UseObjectColor**, anders specificeer je de waarde **CadDrawTypeMode.UseDrawColor**.

Het onderstaande codevoorbeeld toont hoe je verschillende kleur eigenschappen kunt gebruiken.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Automatische lay-out schaling instellen**
De meeste CAD-tekeningen hebben meer dan één lay-out opgeslagen in een enkel bestand, en elke lay-out kan verschillende afmetingen hebben. Bij het renderen van dergelijke CAD-tekeningen naar PDF, kan elke pagina van de PDF verschillende schaling hebben, afhankelijk van de lay-outgrootte. Om het renderingsproces homogeen te maken, hebben de Aspose.CAD APIs de **CadRasterizationOptions.AutomaticLayoutsScaling** eigenschap blootgelegd. De standaardwaarde is **false**, maar wanneer deze waar is, zal de API proberen een overeenkomstige schaal te zoeken voor elke afzonderlijke lay-out en deze op een overeenkomstige manier te tekenen door automatisch te schalen volgens de paginagrootte.

Hier is hoe de **CadRasterizationOptions.AutomaticLayoutsScaling** eigenschap werkt in samenwerking met de **CadRasterizationOptions.ScaleMethod** eigenschap.

1. Als **ScaleMethod** is ingesteld op **ScaleType.ShrinkToFit** of **ScaleType.GrowToFit** met **AutomaticLayoutsScaling** ingesteld op false, dan worden alle lay-outs (inclusief het Model) verwerkt volgens de eerste optie.
1. Als **ScaleMethod** is ingesteld op **ScaleType.ShrinkToFit** of **ScaleType.GrowToFit** met **AutomaticLayoutsScaling** ingesteld op true, dan worden alle lay-outs (behalve Model) verwerkt volgens hun grootte, terwijl het Model zal worden verwerkt volgens de eerste optie.
1. Als **ScaleMethod** is ingesteld op **ScaleType.None** met **AutomaticLayoutsScaling** ingesteld op true of false, dan zal er geen schaling worden uitgevoerd.

Het onderstaande codevoorbeeld toont hoe je de automatische lay-out schaling voor CAD naar PDF conversie kunt instellen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **CAD-lay-outs naar rasterafbeeldingsformaten converteren**
Aspose.CAD voor Java API is in staat om CAD-lay-outs van ondersteunde formaten zoals DXF & DWG naar rasterafbeeldingen zoals PNG, BMP, TIFF, JPEG & GIF te converteren. De API biedt ook ondersteuning om de specifieke lay-outs van een CAD-tekening naar verschillende PSD-lagen te renderen. 
Aspose.CAD voor Java API heeft efficiënte en gebruiksvriendelijke middelen blootgelegd om de lijst van vereiste CAD-lay-outs op te geven en deze naar rasterafbeeldingsformaten te renderen. Hier is hoe je hetzelfde kunt bereiken in 5 eenvoudige stappen, zoals hieronder vermeld.

1. Laad het CAD-bestand in een instantie van **Image** met behulp van de fabrieksmethode **load**.
1. Maak een instantie van **CadRasterizationOptions** en stel de vereiste eigenschappen in zoals **PageWidth** & **PageHeight**.
1. Geef de gewenste lay-outnaam(len) op met behulp van de CadRasterizationOptions.Layouts eigenschap.
1. Maak een instantie van **ImageOptionsBase** en stel de **VectorRasterizationOptions** eigenschap in op de instantie van **CadRasterizationOptions** die in de vorige stap is gemaakt.
1. Roep **Image.Save** aan door het bestandspad (of een object van MemoryStream) door te geven, evenals de instantie van **ImageOptionsBase** die in de vorige stap is gemaakt.

Hier is de complete broncode.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

De eigenschap **CadRasterizationOptions.Layouts** is van het type string-array, zodat je meer dan één lay-out tegelijk kunt specificeren voor mogelijke conversie naar afbeeldingsformaten. Bij het specificeren van meerdere lay-outs voor de **CadRasterizationOptions.Layouts** eigenschap, zou de resulterende TIFF-afbeelding meerdere pagina's hebben, de GIF-afbeelding zou meerdere frames hebben en het PSD-formaat zou meerdere lagen hebben, waarbij elke pagina/frame/layer een individuele AutoCAD-lay-out vertegenwoordigt. In het geval dat een ander afbeeldingsformaat zoals PNG, BMP, JPEG is geselecteerd om het resultaat op te slaan, zal de API alleen de standaardlay-out renderen; dat wil zeggen "Model".

{{% /alert %}} 
## **Tracking inschakelen voor het CAD-renderingsproces**
Aspose.CAD heeft een reeks klassen en ondersteunende enumeratief velden geïntroduceerd om te helpen bij het volgen van het CAD-renderingsproces. Met deze wijzigingen kan de conversie van CAD naar PDF nu als volgt worden bereikt met inschakeling van tracking.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Tracking van het CAD-renderingsproces kan de volgende mogelijke problemen detecteren.

1. Ontbrekende of beschadigde headerinformatie.
1. Ontbrekende lay-outinformatie.
1. Ontbrekende blokentiteiten.
1. Ontbrekende dimensiestijlen.
1. Ontbrekende stijlen.
## **Lettertypen vervangen bij het converteren van CAD-tekeningen**
Het is heel goed mogelijk dat een bepaalde CAD-tekening een specifiek lettertype gebruikt dat niet beschikbaar is op de machine waar de conversie van CAD naar PDF of CAD naar rasterafbeelding plaatsvindt. In dergelijke situaties zal de Aspose.CAD API een geschikte uitzondering activeren om de ontbrekende lettertypen te benadrukken en het conversieproces te stoppen, omdat de API deze lettertypen nodig heeft om de inhoud correct op de resulterende PDF en/of afbeeldingen weer te geven.
De Aspose.CAD API biedt een eenvoudige manier om de vereiste lettertypen te vervangen door de beschikbare lettertypen. De **CadImage.Styles** eigenschap retourneert een instantie van **CadStylesDictionary** die op zijn beurt de **CadStyleTableObject** voor elke stijl in de CAD-tekening bevat, terwijl de **CadStyleTableObject.PrimaryFontName** kan worden gebruikt om de beschikbare lettertype naam op te geven.

Het volgende codevoorbeeld demonstreert het gebruik van Aspose.CAD voor Java API om het lettertype van alle stijlen in een CAD-tekening te wijzigen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Het is ook mogelijk om het lettertype van slechts één bepaalde stijl te wijzigen door deze via de stijlnaam te openen. Het volgende codevoorbeeld demonstreert het gebruik van deze benadering.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **CAD-lagen naar rasterafbeeldingsformaten converteren**
Aspose.CAD voor Java API heeft een efficiënte en gebruiksvriendelijke manier blootgelegd om de naam van de vereiste CAD-laag op te geven en deze naar rasterafbeeldingsformaten te renderen. Hier is hoe je hetzelfde kunt bereiken in 5 eenvoudige stappen, zoals hieronder vermeld.

1. Laad het CAD-bestand in een instantie van **Image** met behulp van de fabrieksmethode **load**.
1. Maak een instantie van **CadRasterizationOptions** en stel de vereiste eigenschappen in zoals **PageWidth** & **PageHeight**.
1. Voeg de gewenste laagnaam toe met behulp van de **CadRasterizationOptions.Layers.add** methode.
1. Maak een instantie van **ImageOptionsBase** en stel de **VectorRasterizationOptions** eigenschap in op de instantie van **CadRasterizationOptions** die in de vorige stap is gemaakt.
1. Roep de **Image.save** methode aan door het bestandspad (of een object van MemoryStream) door te geven, evenals de instantie van **ImageOptionsBase** die in de vorige stap is gemaakt.

Hier is de complete broncode.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Converteer alle CAD-lagen naar afzonderlijke afbeeldingen**
Je kunt alle lagen uit een CAD-tekening ophalen met behulp van de **CadImage.Layers** en elke laag naar een afzonderlijke afbeelding renderen zoals hieronder aangetoond.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **DWF CAD-lagen naar rasterafbeeldingsformaten converteren**
Aspose.CAD voor Java API heeft een efficiënte en gebruiksvriendelijke manier blootgelegd om de naam van de vereiste CAD-laag op te geven en deze naar rasterafbeeldingsformaten te renderen. Hier is hoe je hetzelfde kunt bereiken in 5 eenvoudige stappen, zoals hieronder vermeld.

1. Laad het DWF CAD-bestand in een instantie van **Image** met behulp van de fabrieksmethode **Load**.
1. Maak een instantie van **CadRasterizationOptions** en stel de vereiste eigenschappen in zoals **PageWidth** & **PageHeight**.
1. Voeg de gewenste laagnaam toe met behulp van de **CadRasterizationOptions.Layers.Add** methode.
1. Maak een instantie van **ImageOptionsBase** en stel de **VectorRasterizationOptions** eigenschap in op de instantie van **CadRasterizationOptions** die in de vorige stap is gemaakt.
1. Roep de **Image.Save** methode aan door het bestandspad (of een object van MemoryStream) door te geven, evenals de instantie van **ImageOptionsBase** die in de vorige stap is gemaakt.

Hier is de complete broncode.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
