---
title: Výkresy STP
type: docs
weight: 160
url: /cs/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Exportování formátu STP do PDF**

Aspose.CAD pro Python umožňuje vývojářům exportovat soubor [STP](https://docs.fileformat.com/3d/stp/) do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup k převodu [STP](https://docs.fileformat.com/3d/stp/) na [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor kresby [STP](https://docs.fileformat.com/3d/stp/) pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **page_height** a **page_width**.
1. Vytvořte objekt třídy **PdfOptions** a nastavte vlastnost **vector_rasterization_options**.
1. Zavolejte funkci **Image.save** a předejte objekt **PdfOptions** jako druhý parametr.

## Ukázkový kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
