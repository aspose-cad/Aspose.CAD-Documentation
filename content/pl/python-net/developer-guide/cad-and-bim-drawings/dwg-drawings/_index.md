---
title: Rysunki DWG
type: docs
weight: 70
url: /pl/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Eksportowanie rysunków DWG do PDF**

Aspose.CAD dla API Python może ładować rysunki AutoCAD w formacie [DWG](https://docs.fileformat.com/cad/dwg/) i konwertować je na [PDF](https://docs.fileformat.com/pdf/). Ten temat wyjaśnia użycie API Aspose.CAD do osiągnięcia konwersji DWG na format PDF w prostych krokach, jak określono poniżej.

{{% alert color="primary" %}}

API obsługuje następujące wersje AutoCAD DWG:

- DWG 2004 wersja 16.0 wydanie 18
- DWG 2005 wersja 16.1
- DWG 2010 wersja 18.0
- DWG 2013 wersja 19.0

{{% /alert %}}

### **Format Pliku DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) to plik binarny, który zawiera dane obrazu wektorowego i metadane. Dane obrazu wektorowego dostarczają instrukcje dla aplikacji CAD dotyczące tego, jak wyświetlić DWG; metadane mogą zawierać różnorodne informacje o pliku, w tym dane specyficzne dla lokalizacji oraz dane klienta. Otwarte specyfikacje formatu pliku DWG można znaleźć [w tym PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Konwertowanie plików DWG do PDF**

Aby przekonwertować [DWG](https://docs.fileformat.com/cad/dwg/) na [PDF](https://docs.fileformat.com/pdf/), wymagane są następujące proste kroki.

1. Załaduj plik DWG do instancji **Image**.
1. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **page_height** i **page_width**.
1. Utwórz obiekt klasy **PdfOptions** i ustaw właściwość **VectorRasterizationOptions**.
1. Wywołaj **Image.save**, przekazując obiekt **PdfOptions** jako drugi parametr.

Przykład kodu poniżej pokazuje, jak eksportować rysunki DWG do PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **Obsługiwane prymitywy AutoCAD**

Obsługiwane są następujące prymitywy AutoCAD.

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

## **Eksportowanie konkretnego układu DWG do PDF**

Podejście to działa w następujący sposób:

1. Załaduj plik DWG przy użyciu fabrycznej metody **Aspose.CAD.Image.load**.
1. Utwórz instancję klasy **CadRasterizationOptions** i ustaw wysokość oraz szerokość wynikowej strony.
1. Ustaw właściwość **Layouts** dla obiektu **CadRasterizationOptions**.
1. Utwórz instancję klasy **PdfOptions** i ustaw właściwość **VectorRasterizationOptions**.
1. Eksportuj obraz do PDF przy użyciu metody **Image.save()**.

Przykład kodu poniżej pokazuje, jak przekonwertować konkretny układ DWG na PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **Eksportowanie DWG do PDF/A i PDF/E**

Podejście to działa w następujący sposób:

1. Załaduj plik DWG przy użyciu fabrycznej metody **Image.load**.
1. Utwórz instancję klasy **CadRasterizationOptions**.
1. Utwórz instancję klasy **PdfOptions** i ustaw jej właściwość **VectorRasterizationOptions**.
1. Ustaw właściwość zgodności PDF i zapisz ją.
1. Eksportuj obraz do PDF przy użyciu metody **Image.save()**.

Przykład kodu poniżej pokazuje, jak przekonwertować plik DWG na PDF/A i PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Konwertowanie rysunków DWG do DXF**

Aspose.CAD zapewnia funkcję ładowania pliku DWG AutoCAD i eksportowania go do formatu DXF. Podejście konwersji DWG do DXF działa w następujący sposób:

1. Załaduj plik rysunku DWG przy użyciu fabrycznej metody **Image.load**.
1. Eksportuj rysunek DWG do DXF przy użyciu metody **Image.save()**.

Przykład kodu poniżej pokazuje, jak przekonwertować plik DWG na format DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Konwertowanie rysunków DWG do SVG**

Aspose.CAD dla API Python może ładować rysunki AutoCAD w formacie DWG i konwertować je na SVG. Ten temat wyjaśnia użycie API Aspose.CAD do osiągnięcia konwersji DWG na format SVG w prostych krokach, jak określono poniżej.

1. Załaduj plik DWG do instancji **Image**.
1. Utwórz obiekt klasy **SvgOptions** i ustaw wymagane właściwości.
1. Eksportuj rysunek DWG do SVG przy użyciu metody **Image.save()**.

Przykład kodu poniżej pokazuje, jak przekonwertować plik DWG na format SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
