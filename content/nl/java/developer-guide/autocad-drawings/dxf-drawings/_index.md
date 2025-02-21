---
title: DXF Tekeningen
type: docs
weight: 60
url: /nl/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Exporteren van DXF Tekeningen naar PDF**

Aspose.CAD biedt de functie om AutoCAD DXF-tekenentiteiten te laden en deze als een geheel tekening naar PDF-indeling te renderen. De DXF naar PDF conversieaanpak werkt als volgt:

1. Laad DXF-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriquemethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en stel de [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) eigenschappen in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Roep Image.Save aan terwijl je een object van de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) als tweede parameter doorgeeft.

De onderstaande codevoorbeeld toont hoe je een bestand kunt converteren met standaardinstellingen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Ondersteunde Indelingen**

Op dit moment ondersteunen we volledig AutoCAD DXF 2010-bestandsindelingen. De vorige DXF-versies kunnen niet gegarandeerd 100% geldig zijn. We zijn van plan om meer indelingen en functies toe te voegen in toekomstige versies van Aspose.CAD.

### **Ondersteunde Entiteiten**

Op dit moment ondersteunen we alle wijdverspreide 2D-entiteiten en hun basisstandaardparameters als volgt:

1. Uitgelijnde Dimensie
1. Hoekdimensie
1. Boog
1. Attribuut
1. Blokverwijzing
1. Cirkel
1. Diameter Dimensie
1. Ellips
1. Hatch
1. Lijn
1. Meerdere tekst
1. Ordinate Dimensie
1. Punt
1. Polyline
1. Radiale Dimensie
1. Straal
1. Rotatie Dimensie
1. Tabel
1. Tekst
1. Xline

{{% alert color="primary" %}}

Als we tijdens het parseren een entiteit of eigenschap tegenkomen die we niet ondersteunen, wordt de entiteit of eigenschap stilzwijgend genegeerd.

{{% /alert %}}

### **Geheugenbeheer**

De eigenschap [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) kan worden gebruikt om de geheugenherallocatie te controleren. Herallocatie zal waarschijnlijk optreden voor vooraf toegewezen caches. Het kan gebeuren wanneer het systeem vaststelt dat de toegewezen ruimte niet voldoende zal zijn.

- Als [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) is ingesteld op de standaardwaarde, **False**, wordt de ruimte opnieuw toegewezen aan hetzelfde medium.
- Wanneer ingesteld op **True**, kan herallocatie de maximaal opgegeven ruimte niet overschrijden. In dit geval wordt de al toegewezen cache in het geheugen (die herallocatie vereist) vrijgegeven en wordt er aanvullende ruimte op schijf toegewezen.

## **Exporteren van een Specifieke Laag van DXF Tekeningen naar PDF**

Deze aanpak werkt als volgt:

1. Open een DXF-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriquemethode.
1. Maak een instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) en geef de [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) eigenschappen op.
1. Voeg lagen toe aan het object van [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Maak een instantie van [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Exporteer de tekening naar PDF met de [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode.

De onderstaande code voorbeeld toont hoe je een specifieke laag van DXF naar PDF kunt converteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Exporteren van een Specifieke Laag van DXF Tekeningen naar Afbeelding**

Deze aanpak werkt als volgt:

1. Open een DXF-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriquemethode.
1. Maak een instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) en geef de [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) eigenschappen op.
1. Voeg lagen toe aan het object van [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Maak een instantie van [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) & stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Exporteer de tekening naar JPEG met de [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode.

De onderstaande codevoorbeeld toont hoe je een specifieke laag van DXF naar Afbeelding kunt converteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **PDF-bestanden renderen als onderdeel van DXF tekeningen**

Deze aanpak werkt als volgt:

1. Laad een DXF-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriquemethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en laad PDF-bestanden.
1. Stel de [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) eigenschappen in.
1. Roep [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) aan en sla het bestand op.

De onderstaande codevoorbeeld toont hoe je PDF-bestanden als onderdeel van DXF-tekeningen kunt weergeven.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Export DXF naar WMF**

Deze aanpak werkt als volgt:

1. Laad een DXF-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriquemethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en laad PDF-bestanden.
1. Stel de [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) eigenschappen in.
1. Roep [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) aan en sla het bestand op.

De onderstaande codevoorbeeld toont hoe je DXF naar WMF kunt exporteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Ondersteuning voor het Opslaan van DXF-bestanden**

Aspose.CAD biedt de functie om AutoCAD DXF-bestanden te laden en wijzigingen aan te brengen en deze opnieuw op te slaan als een DXF-bestand. De onderstaande codevoorbeeld toont hoe je gespecificeerde vereisten kunt behalen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Exporteren van ingesloten DGN onderlaag voor DXF-indeling**

Aspose.CAD biedt de functie om AutoCAD DXF-bestanden te laden en ingesloten DGN-onderlaag voor DXF-indeling te exporteren.

De onderstaande codevoorbeeld toont hoe je gespecificeerde vereisten kunt behalen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Exporteren van een Specifieke DXF-indeling naar PDF**

Deze aanpak werkt als volgt:

1. Open een DXF-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriquemethode.
1. Maak een instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) en specificeer de [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) eigenschappen.
1. Geef de gewenste layouter naam(en) op met behulp van de [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) eigenschap.
1. Maak een instantie van [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Exporteer de tekening naar PDF met de [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode.

De onderstaande codevoorbeeld toont hoe je een specifieke lay-out van DXF naar PDF kunt converteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

De eigenschap [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) is van het type string-array, dus je kunt meer dan één lay-out tegelijk opgeven voor mogelijke conversie naar PDF-indeling. Bij het opgeven van meerdere lay-outs voor de [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) eigenschap zou de resulterende PDF meerdere pagina's bevatten, waarbij elke pagina een individuele AutoCAD-lay-out vertegenwoordigt.

{{% /alert %}}

## **Toegang tot ATTRIB en MTEXT-objecten**

Deze aanpak werkt als volgt:

1. Open een DXF-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriquemethode.
1. Toegang tot de entiteiten binnen het CAD-bestand.
1. Controleer op [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) en [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) entiteiten.
1. Voeg toe aan een tijdelijke lijst voor verdere verwerking

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Decomponeren van CAD Invoegen Objecten**

Deze aanpak werkt als volgt:

1. Open een **DXF**-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriquemethode.
1. Toegang tot de entiteiten binnen het CAD-bestand.
1. Controleer op [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) entiteiten.
1. Controleer de lijst van [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) types.
1. Verwerk de entiteiten.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Ondersteuning voor Blokafsnijding**

Aspose.CAD biedt de functie voor Blokafsnijding. De aanpak voor Blokafsnijding werkt als volgt:

1. Laad een DXF-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriquemethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en laad PDF-bestanden.
1. Stel de gewenste eigenschappen van [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) in.
1. Roep [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) aan terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) als tweede parameter doorgeeft en sla het bestand op.

De onderstaande codevoorbeeld toont hoe Blokafsnijding werkt.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Afbeeldingen Exporteren naar DXF**

Met Aspose.CAD kun je afbeeldingen exporteren naar het DXF-formaat. Met deze aanpak kun je de volgende acties uitvoeren:

1. Nieuwe lettertype instellen
1. Entiteiten verbergen
1. Tekst bijwerken

De onderstaande codevoorbeeld toont hoe je de hierboven genoemde acties kunt uitvoeren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
