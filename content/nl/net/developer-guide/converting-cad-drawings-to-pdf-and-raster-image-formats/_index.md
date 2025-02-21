---
title: DWG DXF naar PDF C# | Converteer Auto CAD-bestanden naar PDF JPEG PNG in C# .NET
type: docs
weight: 30
url: /nl/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG naar PDF C#, DXF naar PDF C#, DWF DWT naar PDF C#, converteer AutoCAD, converteer DWG, converteer DWF, converteer DWT, converteer DXF, converteer autocad naar pdf, converteer DWG naar PDF, converteer DWG naar PNG, converteer DWG naar TIFF, converteer DWG naar JPG"
description: Gebruik de C# .NET AutoCAD naar PDF-converter om DWG of DXF naar PDF te converteren in C#. U kunt DWG, DWF, DWT en DXF naar PDF, JPEG, PNG, BMP, GIF en TIFF converteren in C# .NET.
---

## **Converteer DWG of DXF naar PNG JPEG BMP GIF of TIFF in C#**

Aspose.CAD voor .NET kan AutoCAD-tekeningformaten zoals [DXF](https://docs.fileformat.com/cad/dxf/) en [DWG](https://docs.fileformat.com/cad/dwg/) naar [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) en [GIF](https://docs.fileformat.com/image/gif/) converteren. Het heeft een efficiënte en eenvoudige API beschikbaar gesteld om dit doel te bereiken.

U kunt elk ondersteund AutoCAD-tekeningformaat naar rasterafbeeldingsformaten converteren met behulp van de eenvoudige stappen die hieronder zijn uitgelegd.

1. Laad het AutoCAD DWG- of DXF-bestand in de [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) klasse.
1. Maak een instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Stel de grootte van de afbeelding in/wijzig deze met [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) en [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. Maak een instantie van [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. Stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) property in op de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) die in de vorige stap is gemaakt.
1. Sla de AutoCAD-tekening op als PDF met [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) door het bestandspad (of een object van MemoryStream) en de instantie van [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) die in de vorige stap is gemaakt, door te geven.

Hier is de complete broncode.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Standaard rendert de API alleen de "Model" lay-out. U kunt echter ook de lay-outs van uw keuze specificeren tijdens het converteren van CAD-tekeningen naar afbeeldingsformaten.

## **CAD-conversie aanpassen**

De procedures voor CAD naar [PDF](https://docs.fileformat.com/pdf/) en CAD naar rasterafbeeldingsconversie zijn zeer configureerbaar omdat de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse zo is geïmplementeerd dat deze veel optionele functies biedt die, indien geconfigureerd, het renderingsproces kunnen overschrijven volgens de behoeften van de applicatie.

### **CadRasterizationOptions Klasse**

De **CadRasterizationOptions** klasse is algemeen voor alle ondersteunde CAD-formaten zoals DWG en DXF, daarom zijn de informatie die in dit artikel wordt gedeeld geldig voor beide bovengenoemde CAD-formaten.

De meest nuttige **CadRasterizationOptions** klasse-eigenschappen zijn:

|**Eigenschap**|**Standaardwaarde**|**Vereist**|**Beschrijving**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ja|Geeft de paginabreedte op.|
|**PageHeight**|**0**|Ja|Geeft de paginahoogte op.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nee|Geeft op of de tekening automatisch moet worden geschaald. De standaardwaarde verkleint de afbeelding automatisch zodat deze in de canvasgrootte past. Schakel over naar **GrowToFit** modus of gebruik de **None** instelling om automatische schaling uit te schakelen.|
|**BackgroundColor**|**Color.White**|Nee|Geeft de achtergrondkleur van de uitvoerafbeelding op.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nee|Geeft de kleuriseringsmodus van de entiteit op. Geef de **UseObjectColor** optie op om entiteiten met hun native kleur te tekenen, of de **UseDrawColor** optie om de native kleuren te overschrijven.|
|**DrawColor**|**Color.Black**|Nee|Geeft de overschreven kleur van de entiteit op (alleen als **DrawType** is ingesteld op de waarde van de **UseDrawColor** eigenschap).|
|**AutomaticLayoutsScaling**|False|Nee|Geeft op of automatische lay-out schaling moet worden uitgevoerd om te passen bij de Model lay-out.|

### **Instellen van de canvasgrootte en modus**

Exporteren van CAD naar PDF of CAD naar rasterafbeeldingsformaten is geen triviale taak. Aangezien de resulterende PDF of afbeelding vereist dat de canvasgrootte is gedefinieerd, moeten we de uitvoerdimensies voor de PDF-pagina specificeren om de tekening correct weer te geven. Stel expliciet de **CadRasterizationOptions.PageWidth** en **CadRasterizationOptions.PageHeight** eigenschappen in, anders kunt u een **ImageSaveException** krijgen.

Daarnaast kunt u dimensieschaalopties opgeven. De schaalopties worden ingesteld met de **CadRasterizationOptions.ScaleMethod** eigenschap. Gebruik deze optie om de afbeeldingsdimensies automatisch aan te passen aan de **CadRasterizationOptions.PageWidth** en **CadRasterizationOptions.PageHeight** waarden. Standaard is de **CadRasterizationOptions.ScaleMethod** ingesteld op **ScaleType.ShrinkToFit** modus. Deze eigenschap definieert het volgende gedrag:

- Als de dimensies van de CAD-tekening groter zijn dan de resulterende canvasgrootte, worden de dimensies van de tekening verkleind om in de resulterende canvas te passen terwijl de beeldverhouding behouden blijft.
- Als de dimensies van de CAD-tekening kleiner zijn dan de resulterende canvasgrootte, stel dan de **CadRasterizationOptions.ScaleMethod** eigenschap in op **ScaleType.GrowToFit** om de tekening groter te maken zodat deze in de PDF-canvas past terwijl de beeldverhouding behouden blijft.
- Of schakel automatische schaling uit met de optie **ScaleType.None**.

Het onderstaande codevoorbeeld toont de optie voor automatische schaling in gebruik.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Instellen van achtergrond- en tekenkleuren**

Standaard is het kleurenpalet voor de resulterende canvas ingesteld op het gemeenschappelijke documentenschema. Dit betekent dat alle entiteiten binnen de CAD-tekening worden getekend met een zwarte kleurpen op een effen witte achtergrond. Deze instellingen kunnen worden gewijzigd met **CadRasterizationOptions.BackgroundColor** en **CadRasterizationOptions.DrawColor** eigenschappen. Het wijzigen van de **CadRasterizationOptions.DrawColor** eigenschap vereist ook dat de **CadRasterizationOptions.DrawType** eigenschap wordt ingesteld om gebruik te maken van de te gebruiken tekenkleur. De **CadRasterizationOptions.DrawType** eigenschap bepaalt of CAD-entiteiten hun kleuren behouden of worden geconverteerd naar aangepaste kleuren. Om de kleuren van entiteiten te behouden, stelt u de **CadRasterizationOptions.DrawType** in als **CadDrawTypeMode.UseObjectColor**, anders specificeert u de waarde **CadDrawTypeMode.UseDrawColor**.

Het onderstaande codevoorbeeld laat zien hoe verschillende kleureigenschappen gebruiken.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Instellen van automatische lay-outschaling**

De meeste CAD-tekeningen hebben meer dan één lay-out die in één bestand is opgeslagen, en elke lay-out kan verschillende afmetingen hebben. Bij het weergeven van dergelijke CAD-tekeningen naar PDF kan elke pagina van de PDF een andere schaal hebben, afhankelijk van de lay-outgrootte. Om de weergave homogeen te maken, hebben de Aspose.CAD API's de **CadRasterizationOptions.AutomaticLayoutsScaling** eigenschap beschikbaar gesteld. De standaardwaarde is **false**, maar wanneer deze **true** is, probeert de API een overeenkomstige schaal voor elke afzonderlijke lay-out te zoeken en deze op een overeenkomstige manier weer te geven door een automatische hervergroting uit te voeren, afhankelijk van de paginagrootte.

Hier is hoe de **CadRasterizationOptions.AutomaticLayoutsScaling** eigenschap samenwerkt met de **CadRasterizationOptions.ScaleMethod** eigenschap.

1. Als **ScaleMethod** is ingesteld op **ScaleType.ShrinkToFit** of **ScaleType.GrowToFit** met **AutomaticLayoutsScaling** ingesteld op false, worden alle lay-outs (inclusief het Model) verwerkt volgens de eerste optie.
1. Als **ScaleMethod** is ingesteld op **ScaleType.ShrinkToFit** of **ScaleType.GrowToFit** met **AutomaticLayoutsScaling** ingesteld op true, worden alle lay-outs (behalve Model) verwerkt op basis van hun grootte, terwijl het Model wordt verwerkt volgens de eerste optie.
1. Als **ScaleMethod** is ingesteld op **ScaleType.None** met **AutomaticLayoutsScaling** ingesteld op true of false, wordt er geen schaling uitgevoerd.

Het onderstaande codevoorbeeld laat zien hoe u de automatische lay-outschaling voor CAD naar PDF-conversie kunt instellen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Converteer AutoCAD DXF of DWG-lay-outs naar PNG of andere afbeeldingsformaten in C#**

Aspose.CAD voor .NET API kan CAD-lay-outs van ondersteunde formats zoals DXF en DWG converteren naar PNG BMP TIFF JPEG en GIF. De API biedt ook ondersteuning voor het weergeven van de specifieke lay-outs van een CAD-tekening naar verschillende PSD-lagen.

Hier is hoe je hetzelfde kunt bereiken in de volgende eenvoudige stappen.

- Laad het AutoCAD DWG- of DXF-bestand met de **Image** klasse.
- Stel de breedte en hoogte van de afbeelding in/wijzig deze.
- Stel de gewenste lay-outnaam(en) in met behulp van de CadRasterizationOptions.Layouts eigenschap.
- Maak een instantie van **ImageOptionsBase** en stel de **VectorRasterizationOptions** eigenschap in op de instantie van **CadRasterizationOptions** die in de vorige stap is gemaakt.
- Sla de CAD-lay-out op als TIFF of afbeelding.

Hier is de complete broncode.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

De eigenschap **CadRasterizationOptions.Layouts** is van het type string-array zodat u meerdere lay-outs tegelijk kunt opgeven voor mogelijke conversie naar afbeeldingsformaten. Bij het opgeven van meerdere lay-outs voor de **CadRasterizationOptions.Layouts** eigenschap, zou de resulterende TIFF-afbeelding meerdere pagina's hebben, de GIF-afbeelding zou meerdere frames hebben en het [PSD](https://docs.fileformat.com/image/psd/) formaat zou meerdere lagen hebben, waarbij elke pagina/frame/layer een individuele AutoCAD-lay-out vertegenwoordigt. In het geval dat een ander afbeeldingsformaat zoals PNG, BMP, JPEG is geselecteerd om het resultaat op te slaan, zal de API alleen de standaardlay-out weergeven; dat is "Model".

{{% /alert %}}

## **Tracking inschakelen voor het CAD-renderingsproces**

Aspose.CAD heeft een reeks klassen en ondersteunende enumeratief velden geïntroduceerd om te helpen bij het volgen van het CAD-renderingsproces. Met deze wijzigingen kan de conversie van CAD naar PDF nu als volgt worden bereikt terwijl de tracking wordt ingeschakeld.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Tracking van het CAD-renderingsproces kan de volgende mogelijke problemen detecteren.

1. Ontbrekende of beschadigde headerinformatie.
1. Ontbrekende lay-outinformatie.
1. Ontbrekende blokentiteiten.
1. Ontbrekende dimensiestijlen.
1. Ontbrekende stijlen.

## **Vervangen van lettertypen tijdens het converteren van CAD-tekeningen**

Het is heel goed mogelijk dat een bepaalde CAD-tekening een specifiek lettertype gebruikt dat niet beschikbaar is op de machine waar de conversie van CAD naar PDF of CAD naar rasterafbeelding plaatsvindt. In dergelijke situaties zal de Aspose.CAD API een passende uitzondering activeren om de ontbrekende lettertypen te benadrukken en het conversieproces te stopzetten omdat de API deze lettertypen nodig heeft om de inhoud correct weer te geven op de resulterende PDF of afbeeldingen.

De Aspose.CAD API biedt een eenvoudige manier om het mechanisme te gebruiken om de vereiste lettertypen te vervangen door de beschikbare lettertypen. De **CadImage.Styles** eigenschap retourneert een instantie van **CadStylesDictionary** die op zijn beurt de **CadStyleTableObject** voor elke stijl in de CAD-tekening bevat, terwijl de **CadStyleTableObject.PrimaryFontName** kan worden gebruikt om de beschikbare letternaam op te geven.

Het volgende codevoorbeeld demonstreert het gebruik van Aspose.CAD voor .NET API om het lettertype van alle stijlen in een CAD-tekening te wijzigen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Het is ook mogelijk om het lettertype van slechts één bepaalde stijl te wijzigen door deze via de stijlnaam te benaderen. Het volgende codevoorbeeld demonstreert het gebruik van deze benadering.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Converteren van CAD-lagen naar rasterafbeeldingsformaten**

Aspose.CAD voor .NET API heeft een efficiënte en gebruiksvriendelijke manier beschikbaar gesteld om de naam van de vereiste CAD-laag op te geven en deze naar rasterafbeeldingsformaten te renderen. Hier is hoe u hetzelfde kunt bereiken in 5 eenvoudige stappen zoals hieronder weergegeven.

1. Laad het CAD-bestand in een instantie van **Image** met behulp van de fabrieksmethode **Load**.
1. Maak een instantie van **CadRasterizationOptions** en stel de verplichte eigenschappen in zoals **PageWidth** en **PageHeight**.
1. Voeg de gewenste laagnaam toe met behulp van de **CadRasterizationOptions.Layers.Add** methode.
1. Maak een instantie van **ImageOptionsBase** en stel de **VectorRasterizationOptions** eigenschap in op de instantie van **CadRasterizationOptions** die in de vorige stap is gemaakt.
1. Roep de **Image.Save** methode aan door het bestandspad (of een object van MemoryStream) en de instantie van **ImageOptionsBase** die in de vorige stap is gemaakt, door te geven.

Hier is de complete broncode.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Converteer alle CAD-lagen naar afzonderlijke afbeeldingen**

U kunt alle lagen van een CAD-tekening ophalen met behulp van de **CadImage.Layers** en elke laag naar een afzonderlijke afbeelding renderen, zoals hieronder getoond.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Converteren van DWF CAD-lagen naar rasterafbeeldingsformaten**

Aspose.CAD voor .NET API heeft een efficiënte en gebruiksvriendelijke manier beschikbaar gesteld om de naam van de vereiste CAD-laag op te geven en deze naar rasterafbeeldingsformaten te renderen. Hier is hoe u hetzelfde kunt bereiken in 5 eenvoudige stappen zoals hieronder weergegeven.

1. Laad het DWF CAD-bestand in een instantie van **Image** met behulp van de fabrieksmethode **Load**.
1. Maak een instantie van **CadRasterizationOptions** en stel de verplichte eigenschappen in zoals **PageWidth** en **PageHeight**.
1. Voeg de gewenste laagnaam toe met behulp van de **CadRasterizationOptions.Layers.Add** methode.
1. Maak een instantie van **ImageOptionsBase** en stel de **VectorRasterizationOptions** eigenschap in op de instantie van **CadRasterizationOptions** die in de vorige stap is gemaakt.
1. Roep de **Image.Save** methode aan door het bestandspad (of een object van MemoryStream) en de instantie van **ImageOptionsBase** die in de vorige stap is gemaakt, door te geven.

Hier is de complete broncode.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD voor .NET schrijft direct informatie over de API en het versienummer in uitvoerdocumenten. Bijvoorbeeld, bij het renderen van Document naar PDF, vult Aspose.CAD voor .NET het Applicatieveld in met de waarde 'Aspose.CAD' en het PDF Producer-veld met een waarde, bijvoorbeeld 'Aspose.CAD v 17.10'.

Houd er rekening mee dat u Aspose.CAD voor .NET niet kunt instrueren om deze informatie uit uitvoerdocumenten te wijzigen of te verwijderen.
