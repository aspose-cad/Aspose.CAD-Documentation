---
title: Rysunki DWG
type: docs
weight: 40
url: /pl/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Eksportowanie rysunków DWG do PDF**

Aspose.CAD dla .NET API może ładować rysunki AutoCAD w formacie [DWG](https://docs.fileformat.com/cad/dwg/) i konwertować je na [PDF](https://docs.fileformat.com/pdf/). Niniejszy temat wyjaśnia użycie API Aspose.CAD, aby osiągnąć konwersję DWG na PDF poprzez proste kroki, jak określono poniżej.

{{% alert color="primary" %}}

API obsługuje następujące wersje DWG AutoCAD:

- Wersja 16.0 wydanie 18 DWG 2004
- Wersja 16.1 DWG 2005
- Wersja 18.0 DWG 2010
- Wersja 19.0 DWG 2013

{{% /alert %}}

### **Format pliku DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) to plik binarny, który zawiera dane wektorowego obrazu oraz metadane. Dane obrazu wektorowego dostarczają aplikacji CAD instrukcje, jak wyświetlać DWG; metadane mogą zawierać różnorodne informacje o pliku, w tym dane specyficzne dla lokalizacji, a także dane klientów. Otwarte specyfikacje formatu pliku DWG można znaleźć [w tym pliku PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Konwersja plików DWG do PDF**

Aby skonwertować [DWG](https://docs.fileformat.com/cad/dwg/) na [PDF](https://docs.fileformat.com/pdf/), wymagane są następujące proste kroki:

1. Załaduj plik DWG do instancji [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
2. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
4. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save), przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr.

Przykład kodu poniżej pokazuje, jak eksportować rysunki DWG do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Tworzenie pojedynczego PDF z różnymi rozmiarami układów**

Aspose.CAD dla .NET pozwala na konwersję pliku DWG do pojedynczego PDF z różnymi rozmiarami układów. Ten proces działa w następujący sposób:

1. Załaduj plik DWG za pomocą fabrycznej metody [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw wysokość i szerokość wynikowej strony.
3. Dodaj wymagane [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) dla obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
4. Utwórz instancję klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
5. Eksportuj obraz do PDF używając metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Przykład kodu poniżej pokazuje, jak utworzyć pojedyncze [PDF](https://docs.fileformat.com/pdf/) z różnymi układami.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Obsługiwane prymitywy AutoCAD**

Poniższe prymitywy AutoCAD są obsługiwane.

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

Ten proces działa w następujący sposób:

1. Załaduj plik DWG za pomocą fabrycznej metody [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw wysokość i szerokość wynikowej strony.
3. Ustaw właściwość [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) dla obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
4. Utwórz instancję klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
5. Eksportuj obraz do PDF używając metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Przykład kodu poniżej pokazuje, jak skonwertować konkretny układ DWG do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Renderowanie dokumentu DWG przez określenie współrzędnych**

Aspose.CAD dla .NET API teraz oferuje funkcję renderowania dokumentów DWG poprzez podanie współrzędnych szerokości i wysokości dokumentu.

Przykład kodu poniżej pokazuje, jak renderować dokument DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Eksportowanie DWG do Raster lub PDF przy użyciu stałego rozmiaru**

Aspose.CAD dla .NET API może ładować rysunki AutoCAD w formacie DWG i konwertować je na PDF lub Raster przy użyciu stałego rozmiaru.

Przykład kodu poniżej pokazuje, jak wdrożyć tę funkcję.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Eksportowanie DWG do PDF/A i PDF/E**

Ten proces działa w następujący sposób:

1. Załaduj plik DWG za pomocą fabrycznej metody [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
3. Utwórz instancję klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
4. Ustaw właściwość zgodności PDF i zapisz ją.
5. Eksportuj obraz do PDF używając metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Przykład kodu poniżej pokazuje, jak skonwertować plik DWG do PDF/A i PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Wsparcie dla zaokrąglonych linii ukrytych podczas eksportowania DWG/DXF do BMP i PDF**

Ten proces działa w następujący sposób:

1. Załaduj plik DWG za pomocą fabrycznej metody [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw wysokość i szerokość wynikowej strony.
3. Utwórz instancję klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
4. Eksportuj obraz do PDF używając metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Przykład kodu poniżej pokazuje, jak wdrożyć tę funkcję.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Wsparcie dla ustawienia obszaru drukowania dla obrazu DWG w wyeksportowanym PDF**

Aspose.CAD dla .NET API może ładować rysunki AutoCAD w formacie DWG i konwertować je na PDF. Niniejszy temat wyjaśnia użycie API Aspose.CAD, aby osiągnąć wsparcie dla ustawienia obszaru drukowania dla obrazu DWG w wyeksportowanym PDF.

Przykład kodu poniżej pokazuje, jak wdrożyć tę funkcję.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Wsparcie dla odczytu metadanych XREF dla pliku DWG**

1. Załaduj plik DWG za pomocą fabrycznej metody [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Przeszukaj każdy obiekt obrazu.
3. Jeśli obiekt to CadUnderlay, wtedy XREF obiekt z metadanymi.

Przykład kodu poniżej pokazuje, jak osiągnąć tę funkcję.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Właściwość [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) jest typu tablica ciągów, więc możesz określić więcej niż jeden układ jednocześnie do możliwej konwersji do formatu PDF. Podczas określania wielu układów dla właściwości [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), uzyskany PDF będzie miał wiele stron, gdzie każda strona reprezentuje indywidualny układ AutoCAD.

### **Wyświetl wszystkie układy**

Możesz wyświetlić wszystkie układy obecne w rysunku AutoCAD używając poniższego fragmentu kodu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Dostęp do flag podkładu dla formatu DWG**

Aspose.CAD dla .NET wdrożyło flagi podkładu dla formatu DWG i pozwala programistom na dostęp do nich. Poniżej znajduje się prosta demonstracja kodu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Wsparcie dla jednostek DWG**

Aspose.CAD dla .NET API może ładować rysunki AutoCAD w formacie DWG i wspierać różne jednostki do pracy.

### **Wsparcie dla jednostki MLeader**

DWG to plik binarny, który zawiera dane wektorowego obrazu i metadane. W pliku DWG znajdują się różne jednostki. Poniższa sekcja opisuje przykład pracy z jednostką MLeader wewnątrz pliku DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Wsparcie dla eksportowania jednostki DWG do obrazu**

DWG to plik binarny, który zawiera dane wektorowego obrazu i metadane. W pliku DWG znajdują się różne jednostki. Poniższa sekcja opisuje przykład eksportowania konkretnej jednostki DWG do obrazu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Wsparcie dla dodawania tekstu w DWG**

Aspose.CAD dla .NET API może ładować rysunki AutoCAD w formacie DWG i wspierać różne jednostki do pracy. DWG to plik binarny, który zawiera dane wektorowego obrazu i metadane. W pliku DWG znajdują się różne jednostki. Poniższa sekcja opisuje, jak możemy dodać tekst wewnątrz pliku DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Wsparcie dla importowania obrazu do pliku DWG**

Aspose.CAD dla .NET API może ładować rysunki AutoCAD w formacie DWG i wspierać różne jednostki do pracy. DWG to plik binarny, który zawiera dane wektorowego obrazu i metadane. W pliku DWG znajdują się różne jednostki. Poniższa sekcja opisuje, jak możemy importować obrazy wewnątrz pliku DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Wsparcie dla siatki w DWG**

Aspose.CAD dla .NET API ma teraz dostęp do jednostek obsługujących siatkę, w tym typy [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) i [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). Poniższy przykład opisuje, jak możemy uzyskać dostęp do typów siatki.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Konwersja rysunków DWG do DXF**

Aspose.CAD oferuje funkcję załadowania pliku DWG AutoCAD i eksportowania go do formatu DXF. Proces konwersji DWG do DXF działa w następujący sposób:

1. Załaduj plik rysunku DWG za pomocą fabrycznej metody [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
2. Eksportuj rysunek DWG do DXF używając metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Przykład kodu poniżej pokazuje, jak skonwertować plik DWG do formatu DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Konwersja rysunków DWG do SVG**

Aspose.CAD dla .NET API może ładować rysunki AutoCAD w formacie DWG i konwertować je na SVG. Ten temat wyjaśnia użycie API Aspose.CAD do osiągnięcia konwersji DWG do formatu SVG poprzez proste kroki, jak określono poniżej.

1. Załaduj plik DWG do instancji [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
2. Utwórz obiekt klasy [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) i ustaw wymagane właściwości.
3. Eksportuj rysunek DWG do SVG używając metody [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Przykład kodu poniżej pokazuje, jak skonwertować plik DWG do formatu SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Ładowanie dużego pliku DWG**

Aspose.CAD dla .NET zapewnia możliwość otwierania bardzo dużych plików DWG przy użyciu klasy [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Teraz możesz łatwo otworzyć duże pliki za pomocą poniższego przykładu kodu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
