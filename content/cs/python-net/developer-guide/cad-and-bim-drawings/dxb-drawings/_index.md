---
title: Výkresy DXB
type: docs
weight: 90
url: /cs/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Export formátu DXB do PDF**

Aspose.CAD pro Python umožňuje vývojářům exportovat soubor DXB do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup při konverzi DXB na [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor výkresu DXB pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **page_height** a **page_width**.
1. Vytvořte objekt třídy **PdfOptions** a nastavte vlastnost **vector_rasterization_options**.
1. Zavolejte **Image.save** a předejte objekt **PdfOptions** jako druhý parametr.

## Ukázkový kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
