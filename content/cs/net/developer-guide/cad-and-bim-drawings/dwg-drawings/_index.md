---
title: Výkresy DWG
type: docs
weight: 40
url: /cs/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Export výkresů DWG do formátu PDF**

API Aspose.CAD pro .NET umí načíst výkresy AutoCADu ve formátu [DWG](https://docs.fileformat.com/cad/dwg/) a převést je do formátu [PDF](https://docs.fileformat.com/pdf/). Téma tohoto článku vysvětluje použití API Aspose.CAD k dosažení konverze DWG do formátu PDF pomocí jednoduchých kroků, jak je popsáno níže.

{{% alert color="primary" %}}
API podporuje následující revize AutoCAD DWG:

- verze DWG 2004, vydání 16.0, revize 18
- verze DWG 2005, vydání 16.1
- verze DWG 2010, vydání 18.0
- verze DWG 2013, vydání 19.0
{{% /alert %}}

### **Formát souboru DWG**

[Soubor DWG](https://docs.fileformat.com/cad/dwg/) je binární soubor obsahující data vektorového obrazu a metadata. Data vektorového obrazu poskytují instrukce pro aplikaci CAD, jak zobrazit DWG; metadata mohou obsahovat různé informace o souboru, včetně dat specifických pro lokalitu a také data klienta. Otevřené specifikace formátu souboru DWG lze nalézt [v této PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf).

### **Konverze souborů DWG do PDF**

K převedení souboru [DWG](https://docs.fileformat.com/cad/dwg/) do [PDF](https://docs.fileformat.com/pdf/) je zapotřebí následujících jednoduchých kroků.

1. Načtěte DWG soubor do instance [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Vytvořte objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte vlastnosti [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) a [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Vytvořte objekt třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Zavolejte metodu [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) a jako druhý parametr předejte objekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions).

Následující kódový vzorek ukazuje, jak exportovat výkresy DWG do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Vytvoření jediného PDF s různými velikostmi rozložení**

Aspose.CAD pro .NET umožňuje konverzi souboru DWG do jediného PDF s různými velikostmi rozložení. Tento přístup funguje následovně:

1. Načtěte soubor DWG pomocí metody výroby [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte výslednou výšku a šířku stránky.
1. Přidejte požadované [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) pro objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportujte obrázek do PDF pomocí metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Následující kódový vzorek ukazuje, jak vytvořit jediné [PDF](https://docs.fileformat.com/pdf/) s různými rozloženími.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Podporované základní prvky AutoCADu**

Následující základní prvky AutoCADu jsou podporovány:

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
- DIMENSE LINEAR
- DIMENSE ALIGNED
- DIMENSE ANG 3Pt
- DIMENSE ANG 2Ln
- DIMENSE RADIUS
- DIMENSE DIAMETER
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

## **Export konkrétního rozložení DWG do PDF**

Tento přístup funguje následovně:

1. Načtěte soubor DWG pomocí metody výroby [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte výslednou výšku a šířku stránky.
1. Nastavte vlastnost [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) pro objekt třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportujte obrázek do PDF pomocí metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Následující kódový vzorek ukazuje, jak konvertovat konkrétní rozložení DWG do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Zobrazování dokumentu DWG stanovením souřadnic**

API Aspose.CAD pro .NET nyní umožňuje zobrazit dokumenty DWG poskytnutím souřadnic šířky a výšky dokumentu.

Následující kódový vzorek ukazuje, jak zobrazit dokument DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Exportování DWG do rastrového obrazu nebo PDF s pevnou velikostí**

API Aspose.CAD pro .NET umí načíst výkresy AutoCADu ve formátu DWG a převést je do formátu PDF nebo rastrového obrazu s pevnou velikostí.

Následující kódový vzorek ukazuje, jak implementovat tuto funkci.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Exportování DWG do PDF/A a PDF/E**

Tento přístup funguje následovně:

1. Načtěte soubor DWG pomocí metody výroby [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Vytvořte instanci třídy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Nastavte vlastnost souladu s PDF a uložte ji.
1. Exportujte obrázek do PDF pomocí metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Následující kódový vzorek ukazuje, jak převést soubor DWG do PDF/A a PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Podpora zaoblených skrytých linií při exportu DWG/DXF do formátu BMP a PDF**

Tento přístup funguje následovně:

1. Načtěte soubor DWG pomocí metody výroby [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Vytvořte instanci třídy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a nastavte výslednou výšku a šířku stránky.
1. Vytvořte instanci [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) a nastavte vlastnost [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportujte obrázek do PDF pomocí metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Následující kódový vzorek ukazuje, jak implementovat tuto funkci.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Podpora nastavení oblasti tisku pro obrázek DWG v exportovaném PDF**

API Aspose.CAD pro .NET umí načíst výkresy AutoCADu ve formátu DWG a převést je do formátu PDF. Toto téma vysvětluje použití API Aspose.CAD k dosažení podpory pro nastavení oblasti tisku pro obrázek DWG v exportovaném PDF.

Následující kódový vzorek ukazuje, jak implementovat tuto funkci.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Podpora pro čtení metadat XREF pro soubor DWG**

1. Načtěte soubor DWG pomocí metody výroby [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Projděte každou entitu obrázku.
1. Pokud je daná entita CadUnderlay, pak XREF entita s metadaty.

Následující kódový vzorek ukazuje, jak dosáhnout této funkce.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Vlastnost [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) je typu pole řetězců, takže můžete najednou specifikovat více rozložení pro možnou konverzi do formátu PDF. Při specifikaci více rozložení pro vlastnost [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) bude výsledné PDF obsahovat více stránek, kde každá stránka představuje individuální rozložení AutoCADu.

### **Výčet všech rozložení**

Můžete vypsat všechna rozložení v souboru AutoCADu pomocí následujícího kódu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Přístup k vlajkám podložek pro formát DWG**

Aspose.CAD pro .NET implementoval vlajky podložek pro formát DWG a umožňuje vývojářům k nim přistupovat. Níže je jednoduchá ukázka kódu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Podpora pro entity DWG**

Aspose.CAD pro .NET API umí načíst výkresy AutoCADu ve formátu DWG a podporovat různé entity pro práci s nimi.

### **Podpora pro entitu MLeader**

DWG je binární soubor obsahující data vektorového obrazu a metadata. V souboru DWG existují různé entity. Následující sekce popisuje příklad práce s entitou MLeader uvnitř souboru DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Podpora pro export entity DWG do obrázku**

DWG je binární soubor obsahující