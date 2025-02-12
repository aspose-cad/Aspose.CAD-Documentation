---
title: Exportování výkresu DWG/DXF a rozvržení do specifikované velikosti
type: docs
weight: 40
url: /cs/net/export-into-size/
---

## **Exportování modelu a všech rozvržení do velikosti PDF ve formátu A4**

API Aspose.CAD vám umožňuje exportovat všechny listy souboru DWG/DXF do specifikované fyzické velikosti PDF.

Následující ukázkový kód nastavuje velikost objektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) pro dosažení požadované velikosti PDF.
Velikost listu A4 má rozměry 210x297 milimetrů nebo 8.27x11.69 palce a tyto hodnoty jsou použity v kódu.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Vypočítání velikostí pro A4.cs">}}

## **Exportování rozvržení CAD do PDF ve různých velikostech**

Někdy je vyžadováno exportovat rozvržení do své fyzické velikosti. Následující příklad demonstruje export výkresu do vícestránkového PDF, kde každá stránka s obsahem rozvržení
má vlastní fyzickou velikost PDF. Tento příklad využívá vlastnosti [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export do vícestránkového PDF s různými velikostmi stránek.cs">}}
