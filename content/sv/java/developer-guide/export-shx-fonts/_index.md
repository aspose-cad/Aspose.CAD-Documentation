---
title: Exportera SHX-teckensnitt
type: docs
weight: 40
url: /sv/java/developer-guide/export-shx-fonts/
---

## **Exportera SHX-teckensnitt för DXF/DWG-ritningar**

Vissa ritningar kan innehålla teckensnitt i det speciella SHX-formatet, som lagrar symboler av teckensnittet i form av former. 
Detta format kräver en extra inläsningsprocedur för varje teckensnitt som används i ritningen. 
Apose.CAD kan exportera ritningar med text skriven i SHX och har olika alternativ för att göra detta. 
Det enklaste sättet att göra det är att använda [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) 
egenskapen av objektet [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Varje SHX-teckensnitt kommer med rätt kodsida kopplad till det. Dessa associationer är kända och delvis inbäddade i Aspose.CAD för kända SHX-teckensnitt. 
I fall av att ett anpassat SHX-teckensnitt används är det möjligt att använda **setShxCodePages**-egenskapen och ange sökväg till SHX-filen och motsvarande kodsida.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
