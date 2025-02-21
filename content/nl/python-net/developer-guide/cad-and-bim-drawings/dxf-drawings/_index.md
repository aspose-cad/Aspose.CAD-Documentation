---
title: DXF Tekeningen
type: docs
weight: 10
url: /nl/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exporteren van DXF Tekeningen naar PDF**

Aspose.CAD biedt de functie om AutoCAD DXF-tekeningentiteiten te laden en deze als een gehele tekening naar PDF-indformat te renderen. De aanpak voor DXF naar PDF-conversie werkt als volgt:

1. Laad het DXF-tekeningbestand met behulp van de **Image.load** fabrieksmethode.
1. Maak een object van de **CadRasterizationOptions** klasse en stel de **page_height** & **page_width** eigenschappen in.
1. Maak een object van de **PdfOptions** klasse en stel de **VectorRasterizationOptions** eigenschap in.
1. Roep **Image.save** aan en geef een object van **PdfOptions** door als het tweede parameter.

Het onderstaande codevoorbeeld laat zien hoe je een bestand kunt converteren met de standaardinstellingen.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Ondersteunde Indformaten**

Op dit moment ondersteunen we volledig AutoCAD DXF 2010-bestandsformaten. De eerdere DXF-versies zijn niet gegarandeerd 100% valide. We zijn van plan om in de toekomst meer formaten en functies op te nemen in toekomstige versies van Aspose.CAD.

### **Ondersteunde Entiteiten**

Op dit moment ondersteunen we alle wijdverspreide 2D-entiteiten en hun basis standaardparameters als volgt:

1. Aligned Dimension
1. Angular Dimension
1. Arc
1. Attribute
1. Block Reference
1. Circle
1. Diameter Dimension
1. Ellipse
1. Hatch
1. Line
1. Multiline Text
1. Ordinate Dimension
1. Point
1. Polyline
1. Radial Dimension
1. Ray
1. Rotated Dimension
1. Table
1. Text
1. Xline

{{% alert color="primary" %}}

Als we tijdens het parseren een entiteit of eigenschap tegenkomen die we niet ondersteunen, zal de entiteit of eigenschap stilletjes worden genegeerd.

{{% /alert %}}

## **Exporteren van ingebedde DGN-ondergrond voor DXF-indformat**

Aspose.CAD biedt de functie om AutoCAD DXF-bestanden te laden en ingebedde DGN-ondergrond voor DXF-indformat te exporteren.

Het onderstaande codevoorbeeld laat zien hoe de gespecificeerde vereisten kunnen worden bereikt.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Ondersteuning voor het Opslaan van DXF Bestanden**

Aspose.CAD biedt de functie om AutoCAD DXF-bestanden te laden, wijzigingen aan te brengen en ze opnieuw op te slaan als een DXF-bestand.

Het onderstaande codevoorbeeld laat zien hoe de gespecificeerde vereisten kunnen worden bereikt.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Exporteren van DXF naar WMF**

Deze aanpak werkt als volgt:

1. Laad het DXF-tekeningbestand met behulp van de **Image.load** fabrieksmethode.
1. Maak een object van de **CadRasterizationOptions** klasse en laad PDF-bestanden.
1. Stel de **page_height** & **page_width** eigenschappen in.
1. Roep **Image.save** aan en sla het bestand op.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
