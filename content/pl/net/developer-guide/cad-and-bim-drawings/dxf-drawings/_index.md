---
title: Rysunki DXF
type: docs
weight: 60
url: /pl/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Eksportowanie rysunków DXF do PDF**

Aspose.CAD zapewnia funkcję ładowania bytów rysunków AutoCAD DXF i renderowania ich jako całości do formatu PDF. Podejście konwersji DXF na PDF działa w następujący sposób:

1. Załaduj plik rysunku DXF używając metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) i [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr.

Przykład kodu poniżej pokazuje, jak skonwertować plik, używając domyślnych ustawień.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Obsługiwane formaty**

W tej chwili w pełni obsługujemy formaty plików AutoCAD DXF 2010. Poprzednie wersje DXF nie gwarantują 100% poprawności. Planujemy w przyszłości dodać więcej formatów i funkcji w kolejnych wersjach Aspose.CAD.

### **Obsługiwane byty**

Obecnie obsługujemy wszystkie powszechne byty 2D oraz ich podstawowe domyślne parametry, które są następujące:

1. Wymiar z wyrównaniem
1. Wymiar kątowy
1. Łuk
1. Atrybut
1. Odniesienie do bloku
1. Okrąg
1. Wymiar średnicy
1. Elipsa
1. Wypełnienie
1. Linia
1. Tekst wielowierszowy
1. Wymiar ordynat
1. Punkt
1. Linia łamana
1. Wymiar promieniowy
1. Promień
1. Wymiar obrotowy
1. Tabela
1. Tekst
1. Linia X

{{% alert color="primary" %}}

Jeśli podczas analizy napotkamy jakiś byt lub właściwość, której nie obsługujemy, byt lub właściwość zostanie cicho zignorowany.

{{% /alert %}}

### **Zarządzanie pamięcią**

Właściwość [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) klasy [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) może być używana do kontrolowania ponownej alokacji pamięci. Ponowna alokacja najprawdopodobniej wystąpi dla prealokowanych pamięci podręcznych. Może to się zdarzyć, gdy system ustali, że przydzielona przestrzeń nie będzie wystarczająca.

- Jeśli [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) jest ustawiona na wartość domyślną, **False**, przestrzeń jest ponownie alokowana na tym samym nośniku.
- Gdy jest ustawiona na **True**, ponowna alokacja nie może przekroczyć maksymalnej określonej przestrzeni. W tym przypadku istniejąca przydzielona pamięć podręczna (która wymaga ponownej alokacji) jest zwalniana, a rozszerzona przestrzeń jest przydzielana na dysku.

## **Eksportowanie konkretnej warstwy rysunków DXF do PDF**

To podejście działa w następujący sposób:

1. Otwórz plik rysunku DXF, używając metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Utwórz instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i określ właściwości [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) i [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Dodaj warstwy do obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Utwórz instancję [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Wywołaj metodę [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) i przekaż obiekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr.

Przykład kodu poniżej pokazuje, jak skonwertować konkretna warstwę DXF do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Renderowanie plików PDF jako część rysunków DXF**

To podejście działa w następujący sposób:

1. Załaduj plik rysunku DXF, używając metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i załaduj pliki PDF.
1. Ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) i [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) i zapisz plik.

Przykład kodu poniżej pokazuje, jak renderować pliki PDF jako część rysunków DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Eksport wbudowanego podkładu DGN dla formatu DXF**

Aspose.CAD zapewnia funkcję ładowania plików AutoCAD DXF i eksportowania wbudowanego podkładu DGN dla formatu DXF.

Przykład kodu poniżej pokazuje, jak osiągnąć określone wymagania.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Wsparcie dla zapisywania plików DXF**

Aspose.CAD zapewnia funkcję ładowania plików AutoCAD DXF, wprowadzania w nich zmian i ponownego zapisywania ich jako pliki DXF.

Przykład kodu poniżej pokazuje, jak osiągnąć określone wymagania.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Eksport DXF do WMF**

To podejście działa w następujący sposób:

1. Załaduj plik rysunku DXF, używając metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i załaduj pliki PDF.
1. Ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) i [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) i zapisz plik.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Eksportowanie konkretnego układu DXF do PDF**

To podejście działa w następujący sposób:

1. Otwórz plik rysunku DXF, używając metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Utwórz instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i określ właściwości [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) i [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Określ nazwę(y) żądanego układu za pomocą właściwości [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Utwórz instancję [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Eksportuj rysunek do PDF, wywołując metodę [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) i przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr.

Przykład kodu poniżej pokazuje, jak skonwertować konkretna układ DXF do PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

Właściwość [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) jest typu tablica stringów, więc można określić więcej niż jeden układ jednocześnie do możliwej konwersji na format PDF. Gdy określa się wiele układów dla właściwości [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), utworzony plik PDF będzie miał wiele stron, gdzie każda strona przedstawia indywidualny układ AutoCAD.

{{% /alert %}}

## **Wsparcie dla przycinania bloków**

Aspose.CAD zapewnia funkcję przycinania bloków. Podejście przycinania bloków działa w następujący sposób:

1. Załaduj plik rysunku DXF, używając metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i załaduj pliki PDF.
1. Ustaw żądane właściwości [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Wywołaj [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) jako drugi parametr i zapisz plik.

Przykład kodu poniżej pokazuje, jak działa przycinanie bloków.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Eksportowanie obrazów do DXF**

Korzystając z Aspose.CAD, możesz eksportować obrazy do formatu DXF. Korzystając z tego podejścia, możesz wykonać następujące czynności:

1. Ustaw nową czcionkę
1. Ukryj byty
1. Zaktualizuj tekst

Poniższy fragment kodu pokazuje, jak wykonać wymienione powyżej działania.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Eksportowanie konkretnej warstwy rysunków DXF do obrazu**

To podejście działa w następujący sposób:

1. Otwórz plik rysunku DXF, używając metody fabrycznej [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Utwórz instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i określ właściwości [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) i [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Dodaj warstwy do obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Utwórz instancję [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Eksportuj rysunek do PDF, używając metody [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Przykład kodu poniżej pokazuje, jak skonwertować konkretną warstwę DXF do obrazu.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
