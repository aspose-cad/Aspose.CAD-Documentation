---
title: DWG/DXF-tekening en lay-outs exporteren naar opgegeven grootte
type: docs
weight: 40
url: /nl/java/developer-guide/export-into-size/
---

## **Exporteer model en alle lay-outs naar A4 PDF-grootte**

Aspose.CAD API stelt je in staat om alle bladen van het DWG/DXF-bestand naar een opgegeven fysieke PDF-grootte te exporteren.
De volgende voorbeeldcode stelt de grootte van het [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) object in om de gewenste PDF-grootte te bereiken.
De grootte van een A4-papierblad is 210x297 millimeter of 8,27x11,69 inch en deze waarden worden in de code gebruikt.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Exporteer CAD-lay-outs naar PDF in verschillende grootte**

Soms is het nodig om een lay-out naar zijn fysieke grootte te exporteren. Het onderstaande voorbeeld toont de export van de tekening naar een meerpagina's PDF waarin elke pagina met lay-outinhoud
zijn eigen fysieke PDF-grootte heeft. Dit voorbeeld gebruikt de [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) eigenschap.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
