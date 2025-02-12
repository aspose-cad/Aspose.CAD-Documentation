---
title: Kresby FBX
type: docs
weight: 70
url: /cs/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exportování formátu FBX do PDF**

Aspose.CAD pro .NET umožňuje vývojářům exportovat soubor [FBX](https://docs.fileformat.com/3d/fbx/) do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup k převodu [FBX](https://docs.fileformat.com/3d/fbx/) na [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor kresby [FBX](https://docs.fileformat.com/3d/fbx/) pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) a jako druhý parametr předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions).

## Ukázkový kód

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
