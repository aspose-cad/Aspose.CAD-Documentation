---
title: Výkresy DRC
type: docs
weight: 40
url: /cs/python-net/drc-drawings/
---

## **Exportování formátu DRC do PDF**

Aspose.CAD pro Python umožňuje vývojářům exportovat soubor [DRC](https://docs.fileformat.com/3d/drc/) do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup k převodu [DRC](https://docs.fileformat.com/3d/drc/) na [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor s kresbou DRC pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **page_height** a **page_width**.
1. Vytvořte objekt třídy **PdfOptions** a nastavte vlastnost **VectorRasterizationOptions**.
1. Zavolejte metodu **Image.save** a předejte jako druhý parametr objekt **PdfOptions**.

## Vzorový kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
