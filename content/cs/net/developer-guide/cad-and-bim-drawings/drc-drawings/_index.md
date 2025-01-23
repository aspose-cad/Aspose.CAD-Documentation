---
title: Výkresy DRC
type: docs
weight: 15
url: /cs/net/drc-drawings/
---

## **Exportování výkresů DRC do formátu PDF**

Aspose.CAD poskytuje funkci pro načítání entit kreslených v programu AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) a jejich vykreslení jako celého výkresu do formátu [PDF](https://docs.fileformat.com/pdf/). Přístup k převodu z [DRC](https://docs.fileformat.com/3d/drc/) do [PDF](https://docs.fileformat.com/pdf/) funguje následovně:

1. Načtěte soubor s výkresem [DRC](https://docs.fileformat.com/3d/drc/) pomocí tovární metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) při předání objektu [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako druhý parametr.

### Ukázkový kód

Následující ukázkový kód ukazuje, jak převést soubor s výchozími nastaveními.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
