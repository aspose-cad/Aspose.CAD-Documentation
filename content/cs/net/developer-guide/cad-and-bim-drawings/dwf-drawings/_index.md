---
title: Výkresy DWF
type: docs
weight: 20
url: /cs/net/dwf-drawings/
---

## **Exportování výkresů DWF do PDF**

Aspose.CAD poskytuje funkci načítání entit výkresů AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) a jejich zobrazování jako celého výkresu ve formátu [PDF](https://docs.fileformat.com/pdf/). Přístup k převodu z [DWF](https://docs.fileformat.com/cad/dwf/) do [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor s výkresem [DWF](https://docs.fileformat.com/cad/dwf/) pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) s předáním objektu [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako druhý parametr.

### Ukázkový kód

Následující ukázkový kód ukazuje, jak převést soubor s výkresem s výchozími nastaveními.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Extrakce vrstev z výkresu DWF**

Aspose.CAD poskytuje funkci načítání entit výkresů AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) a jejich zobrazování jako celého výkresu ve formátu [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Načtěte soubor s výkresem [DWF](https://docs.fileformat.com/cad/dwf/) pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte objekt třídy [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Extrahujte názvy vrstev pomocí objektu [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) s předáním objektu [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) jako druhý parametr.

### Ukázkový kód

Následující ukázkový kód ukazuje, jak převést soubor s výkresem s výchozími nastaveními.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Podpora vrstev v DWF**

Aspose.CAD poskytuje funkci načítání entit výkresů AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) a jejich zobrazování jako celého výkresu ve formátu [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Načtěte soubor s výkresem [DWF](https://docs.fileformat.com/cad/dwf/) pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Přidejte požadované vrstvy.
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) s předáním objektu [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) jako druhý parametr.

### Ukázkový kód

Následující ukázkový kód ukazuje, jak převést soubor s výkresem s výchozími nastaveními.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Exportování výkresů DWF do BMP**

Aspose.CAD poskytuje funkci načítání entit výkresů AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) a jejich zobrazování jako celého výkresu ve formátu [BMP](https://docs.fileformat.com/image/bmp/). Přístup k převodu z [DWF](https://docs.fileformat.com/cad/dwf/) do [BMP](https://docs.fileformat.com/image/bmp/) funguje následovně:

1. Načtěte soubor s výkresem [DWF](https://docs.fileformat.com/cad/dwf/) pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Vytvořte objekt třídy [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) s předáním objektu [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) jako druhý parametr.

### Ukázkový kód

Následující ukázkový kód ukazuje, jak převést soubor [DWF](https://docs.fileformat.com/cad/dwf/) do [BMP](https://docs.fileformat.com/image/bmp/) s výchozími nastaveními.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
