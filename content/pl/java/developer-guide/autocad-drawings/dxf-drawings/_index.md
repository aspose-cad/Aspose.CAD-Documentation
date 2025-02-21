---
title: Rysunki DXF
type: docs
weight: 60
url: /pl/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Eksportowanie rysunków DXF do PDF**

Aspose.CAD oferuje funkcję ładowania encji rysunków DXF AutoCAD i renderowania ich jako całego rysunku w formacie PDF. Proces konwersji DXF do PDF działa w następujący sposób:

1. Załaduj plik rysunku DXF za pomocą metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) oraz [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
3. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
4. Wywołaj Image.Save, przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) jako drugi parametr.

Poniższy przykład kodu pokazuje, jak konwertować plik za pomocą domyślnych ustawień.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Obsługiwane formaty**

W chwili obecnej w pełni obsługujemy formaty plików DXF AutoCAD 2010. Poprzednie wersje DXF nie są gwarantowane jako 100% poprawne. Planujemy włączyć więcej formatów i funkcji w przyszłych wersjach Aspose.CAD.

### **Obsługiwane encje**

W chwili obecnej obsługujemy wszystkie powszechne encje 2D oraz ich podstawowe domyślne parametry, jak poniżej:

1. Wymiar wyrównany
2. Wymiar kąta
3. Łuk
4. Atrybut
5. Odniesienie do bloku
6. Koło
7. Wymiar średnicy
8. Elipsa
9. Wzór
10. Linia
11. Tekst wielowierszowy
12. Wymiar współrzędny
13. Punkt
14. Polilinia
15. Wymiar promieniowy
16. Promień
17. Wymiar obrotowy
18. Tabela
19. Tekst
20. Linia odniesienia

{{% alert color="primary" %}}

Jeśli podczas analizowania napotkamy jakąś encję lub właściwość, którą nie obsługujemy, encja lub właściwość ta zostanie cicho zignorowana.

{{% /alert %}}

### **Zarządzanie pamięcią**

Właściwość [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) może być używana do kontrolowania ponownej alokacji pamięci. Ponowna alokacja najprawdopodobniej wystąpi dla wcześniej alokowanych pamięci. Może się to zdarzyć, gdy system ustali, że przydzielona przestrzeń nie będzie wystarczająca.

- Jeśli [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) jest ustawione na wartość domyślną, **False**, przestrzeń jest ponownie alokowana do tego samego medium.
- Gdy jest ustawione na **True**, ponowna alokacja nie może przekroczyć maksymalnej określonej przestrzeni. W takim przypadku istniejąca alokowana pamięć (która wymaga ponownej alokacji) jest zwalniana, a powiększona przestrzeń jest alokowana na dysku.

## **Eksportowanie konkretnej warstwy rysunków DXF do PDF**

To podejście działa w następujący sposób:

1. Otwórz plik rysunku DXF za pomocą metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Utwórz instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i określ właściwości [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) oraz [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
3. Dodaj warstwy do obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
4. Utwórz instancję [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
5. Eksportuj rysunek do PDF za pomocą metody [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Poniższy przykład kodu pokazuje, jak przekonwertować konkretną warstwę DXF na PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Eksportowanie konkretnej warstwy rysunków DXF do obrazu**

To podejście działa w następujący sposób:

1. Otwórz plik rysunku DXF za pomocą metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Utwórz instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i określ właściwości [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) oraz [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
3. Dodaj warstwy do obiektu [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
4. Utwórz instancję [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
5. Eksportuj rysunek do PDF za pomocą metody [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Poniższy przykład kodu pokazuje, jak przekonwertować konkretną warstwę DXF na obraz.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Renderowanie plików PDF jako część rysunków DXF**

To podejście działa w następujący sposób:

1. Załaduj plik rysunku DXF za pomocą metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i załaduj pliki PDF.
3. Ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) oraz [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-).
4. Wywołaj [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) i zapisz plik.

Poniższy przykład kodu pokazuje, jak renderować pliki PDF jako część rysunków DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Eksport DXF do WMF**

To podejście działa w następujący sposób:

1. Załaduj plik rysunku DXF za pomocą metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i załaduj pliki PDF.
3. Ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) oraz [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
4. Wywołaj [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) i zapisz plik.

Poniższy przykład kodu pokazuje, jak eksportować DXF do WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Wsparcie dla zapisywania plików DXF**

Aspose.CAD oferuje funkcję ładowania plików DXF AutoCAD, wprowadzania zmian i ponownego zapisywania ich jako plik DXF. Poniższy przykład kodu pokazuje, jak osiągnąć określone wymagania.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Eksportowanie osadzonego podkładu DGN dla formatu DXF**

Aspose.CAD oferuje funkcję ładowania plików DXF AutoCAD oraz eksportu osadzonego podkładu DGN dla formatu DXF.

Poniższy przykład kodu pokazuje, jak osiągnąć określone wymagania.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Eksportowanie konkretnego układu DXF do PDF**

To podejście działa w następujący sposób:

1. Otwórz plik rysunku DXF za pomocą metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Utwórz instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i określ właściwości [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) oraz [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
3. Określ żądane nazwy układów przy użyciu właściwości [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
4. Utwórz instancję [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) i ustaw jej właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
5. Eksportuj rysunek do PDF za pomocą metody [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Poniższy przykład kodu pokazuje, jak przekonwertować konkretny układ DXF na PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Właściwość [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) jest typu tablicy stringów, więc możesz określić więcej niż jeden układ jednocześnie do możliwej konwersji do formatu PDF. Przy określaniu wielu układów dla właściwości [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) wynikowy PDF będzie miał wiele stron, gdzie każda strona reprezentuje pojedynczy układ AutoCAD.

{{% /alert %}}

## **Dostęp do obiektów ATTRIB i MTEXT**

To podejście działa w następujący sposób:

1. Otwórz plik rysunku DXF za pomocą metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Uzyskaj dostęp do encji w pliku CAD.
3. Sprawdź encje [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) oraz [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
4. Dodaj do tymczasowej listy w celu dalszego przetwarzania.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Dekompresja obiektów wstawiania CAD**

To podejście działa w następujący sposób:

1. Otwórz plik **DXF** za pomocą metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Uzyskaj dostęp do encji w pliku CAD.
3. Sprawdź encje [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
4. Sprawdź listę typów [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
5. Przetwórz encje.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Wsparcie dla przycinania bloków**

Aspose.CAD oferuje funkcję przycinania bloków. Podejście przycinania bloków działa w następujący sposób:

1. Załaduj plik rysunku DXF za pomocą metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
2. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i załaduj pliki PDF.
3. Ustaw żądane właściwości [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
4. Wywołaj [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) jako drugi parametr i zapisz plik.

Poniższy przykład kodu pokazuje, jak działa przycinanie bloków.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Eksport obrazów do DXF**

Dzięki Aspose.CAD możesz eksportować obrazy do formatu DXF. Przy użyciu tego podejścia możesz wykonać następujące czynności:

1. Ustawić nową czcionkę
2. Ukryć encje
3. Zaktualizować tekst

Poniższy fragment kodu pokazuje, jak wykonać wymienione powyżej akcje.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
