---
title: Kresby DWG
type: docs
weight: 70
url: /cs/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Exportování kreseb DWG do formátu PDF**

Aspose.CAD pro Python API dokáže načíst výkresy AutoCADu ve formátu [DWG](https://docs.fileformat.com/cad/dwg/) a převést je do formátu [PDF](https://docs.fileformat.com/pdf/). Téma vysvětluje použití Aspose.CAD API k dosažení konverze z DWG do formátu PDF pomocí jednoduchých kroků, jak je popsáno dále.

{{% alert color="primary" %}}
API podporuje následující revize AutoCAD DWG:
- DWG 2004 verze 16.0 vydání 18
- DWG 2005 verze 16.1
- DWG 2010 verze 18.0
- DWG 2013 verze 19.0
{{% /alert %}}

### **Formát souboru DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) je binární soubor obsahující vektorová data obrázků a metadata. Data vektorového obrázku poskytují instrukce aplikaci CAD o zobrazení DWG; metadata mohou obsahovat různé informace o souboru, včetně dat specifických pro umístění a také klienta. Specifikace formátu souboru DWG naleznete [v tomto PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Převod souborů DWG do PDF**

Pro konverzi [DWG](https://docs.fileformat.com/cad/dwg/) do [PDF](https://docs.fileformat.com/pdf/) jsou vyžadovány následující jednoduché kroky:

1. Načtěte soubor DWG do instance **Image**.
1. Vytvořte objekt třídy **CadRasterizationOptions** a nastavte vlastnosti **page_height** a **page_width**.
1. Vytvořte objekt třídy **PdfOptions** a nastavte vlastnost **VectorRasterizationOptions**.
1. Zavolejte **Image.save** a předejte objekt **PdfOptions** jako druhý parametr.

V následujícím kódu je ukázáno, jak exportovat kresby DWG do PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **Podporované primitiva AutoCADu**

JSou podporována následující primitiva AutoCADu:

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
- DIMENZE ORDINÁTU
- DIMENZE LINEÁRNÍ
- DIMENZE ZALIGNOVANÉ
- DIMENZE ANG 3Pt
- DIMENZE ANG 2Ln
- DIMENZE RADIUS
- DIMENZE PRŮMĚRU
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYL
- DIMSTYLE
- LTYPE
- MLINESTYLE
- VVRSTVA
- VIEWPORT
- ROZLOŽENÍ

## **Exportování konkrétního rozvržení DWG do PDF**

Tento přístup funguje následovně:

1. Načtěte soubor DWG pomocí tovární metody **Aspose.CAD.Image.load**.
1. Vytvořte instanci třídy **CadRasterizationOptions** a nastavte výslednou výšku a šířku stránky.
1. Nastavte vlastnost **Layouts** pro objekt **CadRasterizationOptions**.
1. Vytvořte instanci třídy **PdfOptions** a nastavte její vlastnost **VectorRasterizationOptions**.
1. Exportujte obrázek do PDF pomocí metody **Image.save()**.

V následujícím kódu je ukázáno, jak konvertovat konkrétní rozvržení DWG do PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **Exportování DWG do PDF/A a PDF/E**

Tento přístup funguje následovně:

1. Načtěte soubor DWG pomocí tovární metody **Image.load**.
1. Vytvořte instanci třídy **CadRasterizationOptions**.
1. Vytvořte instanci třídy **PdfOptions** a nastavte její vlastnost **VectorRasterizationOptions**.
1. Nastavte vlastnost shody s formátem PDF a uložte ji.
1. Exportujte obrázek do PDF pomocí metody **Image.save()**.

V následujícím kódu je ukázáno, jak konvertovat soubor DWG do formátu PDF/A a PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Převod kreseb DWG do DXF**

Aspose.CAD nabízí možnost načíst soubor AutoCAD DWG a exportovat ho do formátu DXF. Postup konverze z DWG do DXF je následující:

1. Načtěte soubor kresby DWG pomocí metody **Image.load**.
1. Exportujte kresbu DWG do formátu DXF pomocí metody **Image.save()**.

V následujícím kódu je ukázáno, jak konvertovat soubor DWG do formátu DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Převod kreseb DWG do SVG**

Aspose.CAD pro Python API dokáže načíst kresby AutoCADu ve formátu DWG a převést je do formátu SVG. Téma vysvětluje použití Aspose.CAD API k dosažení konverze z DWG do formátu SVG pomocí jednoduchých kroků, jak je popsáno níže.

1. Načtěte soubor DWG do instance **Image**.
1. Vytvořte objekt třídy **SvgOptions** a nastavte požadované vlastnosti.
1. Exportujte kresbu DWG do formátu SVG pomocí metody **Image.save()**.

V následujícím kódu je ukázáno, jak konvertovat soubor DWG do formátu SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
