---
title: Kresby DXB
type: docs
weight: 70
url: /cs/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Exportování formátu DXB do PDF**

Aspose.CAD pro .NET umožňuje vývojářům exportovat soubor DXB do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup k převodu DXB na [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor s kresbou DXB pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/metody/2).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/vlastnosti/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/vlastnosti/pagewidth).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/metody/save/index) a předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako druhý parametr.

## Ukázkový kód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
