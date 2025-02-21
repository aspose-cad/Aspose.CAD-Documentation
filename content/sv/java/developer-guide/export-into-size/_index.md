---
title: Exportera DWG/DXF-ritningar och layouter till specificerad storlek
type: docs
weight: 40
url: /sv/java/developer-guide/export-into-size/
---

## **Exportera modell och alla layouter till A4 PDF-storlek**

Aspose.CAD API gör att du kan exportera alla ark i DWG/DXF-filen till angiven fysisk PDF-storlek. 
Följande exempel kod ställer in storleken på [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) objektet för att uppnå önskad PDF-storlek. 
Storleken på A4-pappersark är 210x297 millimeter eller 8.27x11.69 tum och dessa värden används i koden.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Exportera CAD-layouter till PDF i olika storlekar**

Ibland är det nödvändigt att exportera layouten till sin fysiska storlek. Exemplet nedan demonstrerar export av ritningen till en fler-sidig PDF där varje sida med layoutinnehåll har sin egen fysiska PDF-storlek. Detta exempel använder [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) egenskap.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
