---
title: Výkresy DWF
type: docs
weight: 20
url: /cs/vykresy-dwf/
---

## **Exportování výkresů DWF do PDF**

API Aspose.CAD pro jazyk Java umožňuje načíst výkresy AutoCADu ve formátu DWF a převést je do formátu PDF. Toto téma vysvětluje použití API Aspose.CAD k dosažení konverze ze formátu DWF do PDF prostřednictvím jednoduchých kroků, jak je stanoveno níže.

### **Konverze souborů DWF do PDF**

Následující jednoduché kroky jsou vyžadovány k převedení formátu DWF do PDF.

1. Načtěte soubor DWF do instance [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Zavolejte [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) a předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) jako druhý parametr.

Následující ukázkový kód ukazuje, jak exportovat výkresy DWF do PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Podpora vrstev v souborech DWF**

Aspose.CAD poskytuje funkci načítání entit výkresu AutoCAD DWF a renderování jako celý výkres ve formátu JPG.

1. Načtěte soubor výkresu DWF pomocí základní metody továrny [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Přidejte požadované vrstvy.
1. Zavolejte [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) a předejte objekt [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) jako druhý parametr.

Následující ukázkový kód ukazuje, jak převést soubor s výchozími nastaveními.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
