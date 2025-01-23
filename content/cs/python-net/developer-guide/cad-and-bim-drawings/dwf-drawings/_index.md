---
title: Výkresy DWF
type: docs
weight: 50
url: /cs/python-net/dwf-drawings/
---

## **Exportování výkresů DWF do formátu PDF**

Aspose.CAD poskytuje funkci načítání entit kreslených v programu AutoCAD ve formátu [DWF](https://docs.fileformat.com/cad/dwf/) a jejich vykreslení jako celého výkresu do formátu [PDF](https://docs.fileformat.com/pdf/). Převod z formátu [DWF](https://docs.fileformat.com/cad/dwf/) ​​do formátu [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor s kresbou ve formátu [DWF](https://docs.fileformat.com/cad/dwf/) pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **page_height** a **page_width**.
1. Vytvořte objekt třídy **PdfOptions** a nastavte vlastnost **vector_rasterization_options**.
1. Zavolejte metodu **Image.save** a předejte objekt **PdfOptions** jako druhý parametr.

### Ukázkový kód

Následující ukázkový kód ukazuje, jak převést soubor s výchozími nastaveními.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Exportování výkresů DWF do formátu BMP**

Aspose.CAD poskytuje funkci načítání entit kreslených v programu AutoCAD ve formátu [DWF](https://docs.fileformat.com/cad/dwf/) a jejich vykreslení jako celého výkresu do formátu [BMP](https://docs.fileformat.com/image/bmp/). Převod z formátu [DWF](https://docs.fileformat.com/cad/dwf/) do formátu [BMP](https://docs.fileformat.com/image/bmp/) funguje následovně:

1. Načtěte soubor s kresbou ve formátu [DWF](https://docs.fileformat.com/cad/dwf/) pomocí tovární metody **Image.load**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **page_height** a **page_width**.
1. Vytvořte objekt třídy **BmpOptions** a nastavte vlastnost **vector_rasterization_options**.
1. Zavolejte metodu **Image.save** a předejte objekt **BmpOptions** jako druhý parametr.

### Ukázkový kód

Následující ukázkový kód ukazuje, jak převést soubor ve formátu [DWF](https://docs.fileformat.com/cad/dwf/) do formátu [BMP](https://docs.fileformat.com/image/bmp/) s výchozími nastaveními.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
