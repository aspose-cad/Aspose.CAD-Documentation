---
title: Kresby COLLADA
type: docs
weight: 70
url: /cs/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Export formátu COLLADA do formátu PDF**

Aspose.CAD pro .NET umožňuje vývojářům exportovat soubor [COLLADA](https://docs.fileformat.com/3d/dae/) do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup ke konverzi z [COLLADA](https://docs.fileformat.com/3d/dae/) do [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor kresby [COLLADA](https://docs.fileformat.com/3d/dae/) pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) a jako druhý parametr předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions).

## Ukázkový kód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
