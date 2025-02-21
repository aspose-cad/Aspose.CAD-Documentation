---
title: Het exporteren van DWG/DXF-tekeningen en indelingen naar een specifieke grootte
type: docs
weight: 40
url: /nl/net/developer-guide/export-into-size/
---

## **Exporteer model en alle indelingen naar A4 PDF-grootte**

Aspose.CAD API stelt u in staat om alle bladen van het DWG/DXF-bestand naar een specifieke fysieke PDF-grootte te exporteren. 

De volgende voorbeeldcode stelt de grootte van het [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) object in om de gewenste PDF-grootte te bereiken.
De grootte van een A4-papierblad is 210x297 millimeter of 8,27x11,69 inch en deze waarden worden in de code gebruikt.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Exporteer CAD-indelingen naar PDF in verschillende formaten**

Soms is het nodig om een indeling naar zijn fysieke grootte te exporteren. Het onderstaande voorbeeld demonstreert de export van de tekening naar een meerpagina-PDF waar elke pagina met indelingsinhoud
zijn eigen fysieke PDF-grootte heeft. Dit voorbeeld gebruikt de [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/)
eigenschap.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
