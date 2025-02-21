---
title: Exportera DWG/DXF-ritningar och layouter i specificerad storlek
type: docs
weight: 40
url: /sv/net/developer-guide/export-into-size/
---

## **Exportera modell och alla layouter till A4 PDF-storlek**

Aspose.CAD API gör det möjligt att exportera alla blad av DWG/DXF-filen till specificerad fysisk PDF-storlek.

Följande exempelkod ställer in storleken på [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) objektet för att uppnå önskad PDF-storlek. 
Storleken på A4-papper är 210x297 millimeter eller 8.27x11.69 tum och dessa värden används i koden.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Exportera CAD-layouter till PDF i olika storlekar**

Ibland krävs det att exportera layouten till sin fysiska storlek. Exemplet nedan visar export av ritningen till multipages PDF där varje sida med layoutinnehåll 
har sin egen fysiska PDF-storlek. Detta exempel använder [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/) 
egenskap.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
