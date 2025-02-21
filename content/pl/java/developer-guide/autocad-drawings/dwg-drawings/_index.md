---
title: Rysunki DWG
type: docs
weight: 40
url: /pl/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Eksportowanie rysunków DWG do PDF**

Aspose.CAD dla Java API może ładować rysunki AutoCAD w formacie DWG i konwertować je na PDF. Ten temat wyjaśnia użycie API Aspose.CAD do osiągnięcia konwersji z DWG na format PDF poprzez proste kroki opisane poniżej.

{{% alert color="primary" %}}

API obsługuje następujące wersje DWG AutoCAD:

- DWG 2004 wersja 16.0 wydanie 18
- DWG 2005 wersja 16.1
- DWG 2010 wersja 18.0
- DWG 2013 wersja 19.0

{{% /alert %}}

### **Format pliku DWG**

DWG to plik binarny, który zawiera dane wektorowe obrazu oraz metadane. Dane wektorowe obrazu dostarczają aplikacji CAD instrukcje dotyczące wyświetlania DWG; metadane mogą zawierać różnorodne informacje o pliku, w tym dane specyficzne dla lokalizacji oraz dane klienta. Otwarte specyfikacje dotyczące formatu pliku DWG można znaleźć [w tym PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Konwersja plików DWG do PDF**

Aby przekonwertować DWG na PDF, wymagane są następujące proste kroki.

1. Załaduj plik DWG do instancji [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) oraz [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Wywołaj metodę [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) i przekaż obiekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) jako drugi параметr.

Przykład kodu poniżej pokazuje, jak eksportować rysunki DWG do PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Tworzenie pojedynczego PDF z różnymi rozmiarami układu**

Aspose.CAD dla Java pozwala na konwersję pliku DWG na pojedynczy PDF z różnymi rozmiarami układu. To podejście działa w następujący sposób:

1. Załaduj plik DWG używając fabrycznej metody [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw wysokość oraz szerokość wynikowej strony.
1. Dodaj wymagane [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) do obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Utwórz instancję klasy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Eksportuj obraz do PDF używając metody [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Przykład kodu poniżej pokazuje, jak stworzyć pojedynczy PDF z różnymi układami.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Eksportowanie DWG do PDF/A i PDF/E**

Aby przekonwertować DWG na PDF, wymagane są następujące proste kroki.

1. Załaduj plik DWG do instancji [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw właściwości: [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) i [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Wywołaj metodę [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) i przekaż obiekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) jako drugi parametr.

Przykład kodu poniżej pokazuje, jak eksportować rysunki DWG do PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Obsługiwane prymitywy AutoCAD**

Następujące prymitywy AutoCAD są obsługiwane.

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

To podejście działa w następujący sposób:

1. Załaduj plik DWG używając fabrycznej metody [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw wysokość oraz szerokość wynikowej strony.
1. Ustaw właściwość [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) dla obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Utwórz instancję klasy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Eksportuj obraz do PDF używając metody [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Przykład kodu poniżej pokazuje, jak przekonwertować konkretny układ DWG na PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Eksportowanie DWG do Raster lub PDF przy użyciu stałego rozmiaru**

Aspose.CAD dla Java API może ładować rysunki AutoCAD w formacie DWG i konwertować je na PDF lub Raster przy użyciu stałego rozmiaru.

Przykład kodu poniżej pokazuje, jak zaimplementować tę funkcję.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Wsparcie dla zaokrąglonych linii ukrytych podczas eksportowania DWG/DXF do BMP i PDF**

To podejście działa w następujący sposób:

1. Załaduj plik DWG używając fabrycznej metody [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw wysokość oraz szerokość wynikowej strony.
1. Utwórz instancję klasy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Eksportuj obraz do PDF używając metody [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Przykład kodu poniżej pokazuje, jak zaimplementować tę funkcję.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Wsparcie dla ustawiania obszaru wydruku dla obrazu DWG w wyeksportowanym PDF**

Aspose.CAD dla Java API może ładować rysunki AutoCAD w formacie DWG i konwertować je na PDF. Ten temat wyjaśnia użycie API Aspose.CAD do uzyskania wsparcia dla ustawienia obszaru wydruku dla obrazu DWG w wyeksportowanym PDF.

Przykład kodu poniżej pokazuje, jak zaimplementować tę funkcję.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Wsparcie dla odczytywania metadanych XREF dla pliku DWG**

1. Załaduj plik DWG używając fabrycznej metody [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Przeglądaj każdą jednostkę obrazu.
1. Jeśli jednostka to [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay), to jednostka XREF z metadanymi.

Przykład kodu poniżej pokazuje, jak osiągnąć tę funkcję.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Dokument DWG poprzez określenie współrzędnych**

Aspose.CAD dla Java API teraz udostępnia funkcję renderowania dokumentów DWG poprzez podanie współrzędnych szerokości i wysokości dokumentu.

Przykład kodu poniżej pokazuje, jak renderować dokument DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

Właściwość [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) jest typu tablica stringów, więc możesz ustawić więcej niż jeden układ na raz do możliwej konwersji na format PDF. Podczas określania wielu układów dla właściwości [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), wyjściowy PDF będzie mieć wiele stron, gdzie każda strona przedstawia indywidualny układ AutoCAD.

### **Wylistuj wszystkie układy**

Możesz wylistować wszystkie układy obecne w rysunku AutoCAD, używając następującego fragmentu kodu.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Pobierz wartość atrybutu bloku z odniesienia zewnętrznego**

Aspose.CAD dla Java API pozwala na pobieranie odniesienia zewnętrznego atrybutu bloku. API Aspose.CAD udostępnia właściwość [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) do uzyskania odniesienia zewnętrznego atrybutu bloku w kolekcji [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

Następujący kod demonstruje, jak uzyskać odniesienie zewnętrzne atrybutu bloku.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Wyszukiwanie tekstu w pliku DWG AutoCAD**

Aspose.CAD dla Java API pozwala na wyszukiwanie tekstu w pliku DWG AutoCAD. API Aspose.CAD udostępnia klasę [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText), która reprezentuje encje tekstowe w pliku DWG AutoCAD. Klasa [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) jest również zawarta w API Aspose.CAD, ponieważ niektóre inne encje mogą również zawierać tekst.

Następujący kod demonstruje, jak wyszukiwać tekst w pliku DWG AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Wyszukiwanie tekstu w konkretnym układzie**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Dostęp do flag podkładu dla formatu DWG**

Aspose.CAD dla Java wdrożył flagi podkładu dla formatu DWG i pozwala programistom na dostęp do nich. Oto prosty przykład kodu.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Wsparcie dla encji DWG**

Aspose.CAD dla Java API może ładować rysunki AutoCAD w formacie DWG i wspiera różne encje do pracy z nimi.

### **Wsparcie dla encji MLeader**

DWG to plik binarny, który zawiera dane wektorowe obrazu i metadane. W pliku DWG istnieją różne encje. W tej sekcji opisano przykład pracy z encją MLeader wewnątrz pliku DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Wsparcie dla eksportowania encji DWG do obrazu**

DWG to plik binarny, który zawiera dane wektorowe obrazu i metadane. W pliku DWG istnieją różne encje. W tej sekcji opisano przykład eksportowania konkretnej encji DWG do obrazu.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Wsparcie dla importu obrazu do pliku DWG**

Aspose.CAD dla Java API może ładować rysunki AutoCAD w formacie DWG i wspiera różne encje do pracy z nimi. DWG to plik binarny, który zawiera dane wektorowe obrazu i metadane. W pliku DWG istnieją różne encje. W tej sekcji opisano, jak możemy importować obrazy do pliku DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Wsparcie dla dodawania tekstu w DWG**

Aspose.CAD dla Java API może ładować rysunki AutoCAD w formacie DWG i wspiera różne encje do pracy z nimi. DWG to plik binarny, który zawiera dane wektorowe obrazu i metadane. W pliku DWG istnieją różne encje. W tej sekcji opisano, jak możemy dodać tekst do pliku DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Wsparcie dla siatki w DWG**

Aspose.CAD dla Java API teraz ma dostęp do encji wspierających siatkę, które obejmują typy [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) i [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). Następujący przykład opisuje, jak możemy uzyskać dostęp do typów siatek.

## **Konwersja rysunków DWG do DXF**

Aspose.CAD zapewnia funkcję ładowania pliku DWG AutoCAD i eksportowania go do formatu DXF. Podejście konwersji DWG na DXF działa w następujący sposób:

1. Załaduj plik rysunku DWG używając fabrycznej metody [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Wyeksportuj rysunek DWG do DXF używając metody [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Przykład kodu poniżej pokazuje, jak przekształcić plik DWG na format DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Konwersja rysunków DWG do SVG**

API Aspose.CAD może ładować rysunki AutoCAD w formacie DWG i konwertować je na SVG. Ten temat wyjaśnia użycie API Aspose.CAD do przeprowadzenia konwersji z DWG na format SVG poprzez proste kroki opisane poniżej.

1. Załaduj plik DWG do instancji [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Utwórz obiekt klasy [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) i ustaw wymagane właściwości.
1. Wyeksportuj rysunek DWG do SVG używając metody [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Przykład kodu poniżej pokazuje, jak przekonwertować plik DWG na format SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
