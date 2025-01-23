---
title: 3D kresby
type: docs
weight: 70
url: /cs/net/3ds-kresby/
---

## **Exportování formátu 3DS do PDF**

Aspose.CAD pro .NET umožňuje vývojářům exportovat soubor [3DS](https://docs.fileformat.com/3d/3ds/) do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup k převodu [3DS](https://docs.fileformat.com/3d/3ds/) do [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor kresby [3DS](https://docs.fileformat.com/3d/3ds/) pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) a předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako druhý parametr.

## Ukázkový kód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
