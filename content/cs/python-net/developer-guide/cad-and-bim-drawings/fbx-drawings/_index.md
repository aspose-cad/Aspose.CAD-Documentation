---
title: Kresby FBX
type: docs
weight: 110
url: /cs/python-net/fbx-drawings/
---

## **Exportování formátu FBX do PDF**

Aspose.CAD pro Python umožňuje vývojářům exportovat soubor [FBX](https://docs.fileformat.com/3d/fbx/) do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup k převodu [FBX](https://docs.fileformat.com/3d/fbx/) na [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor s kresbou [FBX](https://docs.fileformat.com/3d/fbx/) pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **PageHeight** a **PageWidth**.
1. Vytvořte objekt třídy **PdfOptions** a nastavte vlastnost **vector_rasterization_options**.
1. Zavolejte metodu **Image.save** a předejte objekt **PdfOptions** jako druhý parametr.

## Ukázkový kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
