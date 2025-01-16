---
title: Kresby COLLADA
type: docs
weight: 20
url: /cs/python-net/collada-drawings/
---

## **Exportování formátu COLLADA do PDF**

Aspose.CAD pro Python umožňuje vývojářům exportovat soubor [COLLADA](https://docs.fileformat.com/3d/dae/) do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup k převodu [COLLADA](https://docs.fileformat.com/3d/dae/) na [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor s kresbami [COLLADA](https://docs.fileformat.com/3d/dae/) pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **page_height** a **page_width**.
1. Vytvořte objekt třídy **PdfOptions** a nastavte vlastnost **vector_rasterization_options**.
1. Zavolejte **Image.save** a jako druhý parametr předejte objekt **PdfOptions**.

## Ukázkový kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
