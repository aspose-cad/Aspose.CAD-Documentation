---
title: Výkresy DWG
type: docs
weight: 40
url: /cs/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Export DWG Výkresů do PDF**

Aspose.CAD for Java API dokáže načíst výkresy v formátu DWG z programu AutoCAD a převést je do formátu PDF. Toto téma vysvětluje použití Aspose.CAD API k dosažení konverze z DWG do formátu PDF prostřednictvím jednoduchých kroků, jak jsou definovány níže.

{{% alert color="primary" %}}
API podporuje následující revize AutoCAD DWG:
- DWG 2004 verze 16.0 vydání 18
- DWG 2005 verze 16.1
- DWG 2010 verze 18.0
- DWG 2013 verze 19.0
{{% /alert %}}

### **Formát souborů DWG**

DWG je binární soubor obsahující vektorová data obrázků a metadata. Vektorová data obrázků poskytují instrukce CAD aplikaci o tom, jak zobrazit DWG; metadata mohou obsahovat různé informace o souboru, včetně dat specifických pro umístění a také klienta. Otevřené specifikace formátu souborů DWG lze najít [v tomto PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf).

### **Konverze souborů DWG do PDF**

Následující jednoduché kroky jsou vyžadovány k převedení DWG do PDF.

1. Načtěte soubor DWG do instance [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Zavolejte metodu [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) a předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) jako druhý parametr.

Následující ukázkový kód ukazuje, jak exportovat výkresy DWG do PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Vytvoření jednoho PDF s různými velikostmi rozvržení**

Aspose.CAD for Java vám umožňuje převést soubor DWG na jediné PDF s různými velikostmi rozvržení. Tento přístup funguje následovně:

1. Načtěte soubor DWG pomocí tovární metody [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte výsledné výšky a šířky stránky.
1. Přidejte požadované [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) pro objekt [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) a nastavte jeho vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportujte obrázek do PDF pomocí metody [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Následující ukázkový kód ukazuje, jak vytvořit jedno PDF s různými rozvrženími.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Export DWG do PDF/A a PDF/E**

Následující jednoduché kroky jsou vyžadovány k převedení DWG do PDF.

1. Načtěte soubor DWG do instance [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) a [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Zavolejte metodu [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) a předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) jako druhý parametr.

Následující ukázkový kód ukazuje, jak exportovat výkresy DWG do PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Podporované základny Autocad Primitives**

Následující základny Autocad jsou podporovány.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Export konkrétního rozvržení DWG do PDF**

Tento postup funguje následujícím způsobem:

1. Načtěte soubor DWG pomocí tovární metody [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte výsledné výšky a šířky stránky.
1. Nastavte vlastnost [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) pro objekt [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) a nastavte jeho vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportujte obrázek do PDF pomocí metody [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Následující ukázkový kód ukazuje, jak konvertovat konkrétní rozvržení DWG do PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Export DWG do Rastrového obrázku nebo PDF pomocí pevné velikosti**

Aspose.CAD for Java API dokáže načíst výkresy v formátu DWG z programu AutoCAD a převést je do formátu PDF nebo Raster pomocí pevné velikosti.

Následující ukázkový kód ukazuje, jak implementovat tuto funkci.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Podpora zaoblených skrytých linií při exportu DWG/DXF do BMP a PDF**

Tento postup funguje následovně:

1. Načtěte soubor DWG pomocí metody [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) a nastavte výsledné výšky a šířky stránky.
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) a nastavte jeho vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportujte obrázek do PDF pomocí metody [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Následující ukázkový kód ukazuje, jak implementovat tuto funkci.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Podpora pro nastavení oblasti tisku pro obrázek DWG ve vyexportovaném PDF**

Aspose.CAD for Java API dokáže načíst výkresy v formátu DWG z programu AutoCAD a převést je do formátu PDF. Toto téma popisuje použití Aspose.CAD API k dosažení podpory pro nastavení oblasti tisku obrázku DWG ve vyexportovaném PDF.

Následující ukázkový kód ukazuje, jak implementovat tuto funkci.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Podpora pro čtení metadat XREF pro soubor DWG**

1. Načtěte soubor DWG pomocí metody [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Projděte každý entitní obrázek.
1. Pokud je entita [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay), pak entita XREF s metadaty.

Následující ukázkový kód ukazuje, jak dosáhnout této funkce.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Dokument DWG stanovující souřadnice**

Aspose.CAD for Java API nyní poskytuje funkci pro zobrazování dokumentů DWG poskytnutím souřadnic šířky a výšky dokumentu.

Následující ukázka kódu ukazuje, jak zobrazit dokument DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

Vlastnost [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) je polem řetězců, takže můžete specifikovat více než jedno rozvržení současně pro možnou konverzi do formátu PDF. Při specifikování několika rozvržení pro vlastnost [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), výsledné PDF bude mít několik stránek, kde každá stránka reprezentuje jednotlivé rozvržení AutoCadu.

### **Výčet všech rozvržení**

Můžete vypsat všechny rozvržení přítomné v kresbě programu AutoCAD pomocí následujícího kódu.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Získání hodnoty atributu bloku externí reference**

Aspose.CAD for Java API vám umožňuje získat externí reference atributu bloku. Aspose.CAD API vystavuje vlastnost [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) k získání externí reference atributu bloku v kolekci [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

Následující kód ukazuje, jak získat externí reference atributu bloku.