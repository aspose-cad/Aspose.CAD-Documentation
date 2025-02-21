---
title: DXF Tekeningen
type: docs
weight: 60
url: /nl/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **DXF Tekeningen naar PDF Exporteren**

Aspose.CAD biedt de functie om AutoCAD DXF-tekeningen te laden en deze als een geheel in PDF-indeling weer te geven. De aanpak voor het converteren van DXF naar PDF werkt als volgt:

1. Laad het DXF-tekenbestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) eigenschappen in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) eigenschap in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als tweede parameter doorgeeft.

Het onderstaande codevoorbeeld toont hoe je een bestand kunt converteren met de standaardinstellingen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Ondersteunde Indelingen**

Op dit moment ondersteunen we volledig de AutoCAD DXF 2010-bestandsindelingen. De vorige DXF-versies zijn niet gegarandeerd voor 100% geldig. We zijn van plan om meer indelingen en functies op te nemen in toekomstige versies van Aspose.CAD.

### **Ondersteunde Entiteiten**

Op dit moment ondersteunen we alle wijdverspreide 2D-entiteiten en hun basisstandaardparameters als volgt:

1. Uitgelijnde Afmeting
1. Hoekafmeting
1. Boog
1. Attribuut
1. Blokverwijzing
1. Cirkel
1. Diameterafmeting
1. Ellips
1. Hatch
1. Lijn
1. Meerdere regels tekst
1. Ordinaatafmeting
1. Punt
1. Polyline
1. Radiale Afmeting
1. Straal
1. Geroteerde Afmeting
1. Tabel
1. Tekst
1. Xline

{{% alert color="primary" %}}

Als we tijdens het parseren een entiteit of eigenschap tegenkomen die we niet ondersteunen, wordt de entiteit of eigenschap stilletjes genegeerd.

{{% /alert %}}

### **Geheugenbeheer**

De eigenschap [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) van de [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) klasse kan worden gebruikt om de geheugenherallocatie te beheersen. Herallocatie zal zeer waarschijnlijk plaatsvinden voor voorgeallocatie caches. Dit kan gebeuren wanneer het systeem erachter komt dat de toegewezen ruimte niet voldoende zal zijn.

- Als [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) is ingesteld op de standaardwaarde, **False**, wordt de ruimte opnieuw toegewezen aan hetzelfde medium.
- Wanneer ingesteld op **True**, kan herallocatie de maximaal gespecificeerde ruimte niet overschrijden. In dit geval wordt de bestaande toegewezen in-memory cache (die herallocatie vereist) vrijgegeven en wordt extra ruimte op de schijf toegewezen.

## **Specifieke Laag van DXF Tekeningen naar PDF Exporteren**

Deze aanpak werkt als volgt:

1. Open een DXF-tekening bestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrieksmethode.
1. Maak een instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) en geef de [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) eigenschappen op.
1. Voeg lagen toe aan het object van [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Maak een instantie van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) eigenschap in.
1. Roep de [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode aan en geef het object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) door als tweede parameter.

Het onderstaande codevoorbeeld toont hoe je een specifieke laag van DXF naar PDF kunt converteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **PDF-bestanden weergeven als onderdeel van DXF-tekeningen**

Deze aanpak werkt als volgt:

1. Laad het DXF-tekenbestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en laad PDF-bestanden.
1. Stel de [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) eigenschappen in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan en sla het bestand op.

Het onderstaande codevoorbeeld toont hoe je PDF-bestanden kunt weergeven als onderdeel van DXF-tekeningen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Ingebedde DGN-onderlagen voor DXF-indeling exporteren**

Aspose.CAD biedt de functie om AutoCAD DXF-bestanden te laden en ingebedde DGN-onderlagen voor DXF-indeling te exporteren.

Het onderstaande codevoorbeeld toont hoe je aan de gespecificeerde vereisten kunt voldoen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Ondersteuning voor het Opslaan van DXF-bestanden**

Aspose.CAD biedt de functie om AutoCAD DXF-bestanden te laden, wijzigingen aan te brengen en deze opnieuw op te slaan als een DXF-bestand.

Het onderstaande codevoorbeeld toont hoe je aan de gespecificeerde vereisten kunt voldoen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **DXF naar WMF Exporteren**

Deze aanpak werkt als volgt:

1. Laad het DXF-tekenbestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en laad PDF-bestanden.
1. Stel de [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) eigenschappen in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan en sla het bestand op.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Specifieke DXF Lay-out naar PDF Exporteren**

Deze aanpak werkt als volgt:

1. Open een DXF-tekening bestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrieksmethode.
1. Maak een instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) en geef de [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) eigenschappen op.
1. Geef de gewenste lay-outnaam(en) op met de [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) eigenschap.
1. Maak een instantie van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) eigenschap in.
1. Exporteer de tekening naar PDF door de [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode aan te roepen en het object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als tweede parameter door te geven.

Het onderstaande codevoorbeeld toont hoe je een specifieke lay-out van DXF naar PDF kunt converteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

De eigenschap [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) is van het type string-array, dus je kunt meer dan één lay-out tegelijk opgeven voor mogelijke conversie naar PDF-indeling. Bij het opgeven van meerdere lay-outs voor de [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) eigenschap, zou de resulterende PDF meerdere pagina's hebben, waarbij elke pagina een individuele AutoCAD lay-out vertegenwoordigt.

{{% /alert %}}

## **Ondersteuning van Blokafkapping**

Aspose.CAD biedt de functie van Blokafkapping. De aanpak voor Blokafkapping werkt als volgt:

1. Laad het DXF-tekenbestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en laad PDF-bestanden.
1. Stel de gewenste eigenschappen van [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als tweede parameter doorgeeft en sla het bestand op.

Het onderstaande codevoorbeeld toont hoe Blokafkapping werkt.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Afbeeldingen naar DXF Exporteren**

Met Aspose.CAD kun je afbeeldingen naar het DXF-formaat exporteren. Met deze aanpak kun je de volgende acties uitvoeren:

1. Nieuwe lettertype instellen
1. Entiteiten verbergen
1. Tekst bijwerken

Het onderstaande codefragment toont je hoe je de bovenstaande acties kunt uitvoeren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Specifieke Laag van DXF Tekeningen naar Afbeelding Exporteren**

Deze aanpak werkt als volgt:

1. Open een DXF-tekening bestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrieksmethode.
1. Maak een instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) en geef de [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) en [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) eigenschappen op.
1. Voeg lagen toe aan het object van [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Maak een instantie van [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) eigenschap in.
1. Exporteer de tekening naar PDF met behulp van de [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode.

Het onderstaande codevoorbeeld toont hoe je een specifieke laag van DXF naar Afbeelding kunt converteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
