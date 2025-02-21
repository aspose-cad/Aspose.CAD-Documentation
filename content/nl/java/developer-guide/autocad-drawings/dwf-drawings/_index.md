---
title: DWF Tekeningen
type: docs
weight: 20
url: /nl/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **DWF Tekeningen Exporteren naar PDF**

Aspose.CAD voor Java API kan AutoCAD tekeningen in DWF-indeling laden en converteren naar PDF. Dit onderwerp legt het gebruik van de Aspose.CAD API uit om de conversie van DWF naar PDF-indeling te bereiken via eenvoudige stappen zoals hieronder beschreven.

### **DWF Bestanden naar PDF Converteren**

De volgende eenvoudige stappen zijn vereist om DWF naar PDF te converteren.

1. Laad het DWF-bestand in een instantie van [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en stel de [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) eigenschappen in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Roep [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) aan terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) als het tweede parameter doorgeeft.

De onderstaande codevoorbeeld laat zien hoe je DWF tekeningen naar PDF kunt exporteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Ondersteuning van Lagen in DWF**

Aspose.CAD biedt de mogelijkheid om AutoCAD DWF-tekeningseenheden te laden en deze als een volledige tekening naar JPG-indeling te renderen.

1. Laad het DWF-tekeningbestand met de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse.
1. Voeg gewenste lagen toe.
1. Roep [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) aan terwijl je een object van [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) als het tweede parameter doorgeeft.

De onderstaande codevoorbeeld laat zien hoe je een bestand kunt converteren met de standaardinstellingen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
