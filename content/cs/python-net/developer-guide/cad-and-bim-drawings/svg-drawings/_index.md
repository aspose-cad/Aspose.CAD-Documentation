---
title: Kresby SVG
type: docs
weight: 170
url: /cs/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Exportování formátu SVG do formátu PDF**

Aspose.CAD pro Python umožňuje vývojářům exportovat soubor [SVG](https://docs.fileformat.com/page-description-language/svg/) do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup ke konverzi [SVG](https://docs.fileformat.com/page-description-language/svg/) na [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor s kresbou v SVG pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **page_height** a **page_width**.
1. Vytvořte objekt třídy **PdfOptions** a nastavte vlastnost **VectorRasterizationOptions**.
1. Zavolejte **Image.save** a předejte jako druhý parametr objekt **PdfOptions**.

## Ukázkový kód

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
