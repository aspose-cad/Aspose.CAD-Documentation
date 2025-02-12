---
title: Exportování výkresů DWG/DXF a rozvržení do určené velikosti
type: docs
weight: 40
url: /cs/java/export-into-size/
---

## **Export Modelu a všech rozvržení do velikosti A4 PDF**

API Aspose.CAD vám umožňuje exportovat všechny listy souboru DWG/DXF do specifikované fyzické velikosti PDF.
Následující ukázkový kód nastavuje velikost objektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) pro dosažení požadované velikosti PDF.
Velikost listu papíru A4 je 210x297 milimetrů nebo 8,27x11,69 palců a tyto hodnoty jsou použity v kódu.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Export CAD Rozvržení do PDF v různých velikostech**

Někdy je zapotřebí exportovat rozvržení do své fyzické velikosti. Následující příklad demonstruje export výkresu do vícestránkového PDF, kde každá stránka s obsahem rozvržení
má svou vlastní fyzickou velikost PDF. Tento příklad využívá vlastnost [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--).


{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
