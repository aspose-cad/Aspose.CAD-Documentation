---
title: Eksportowanie formatu DGN AutoCAD
type: docs
weight: 50
url: /pl/net/developer-guide/exporting-dgn-autocad/
---

## **Eksportowanie formatu DGN AutoCAD do PDF**

Aspose.CAD dla API .NET wprowadziło funkcjonalność ładowania pliku DGN AutoCAD i konwersji go do formatu PDF. Klasa [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) służy temu celowi.

Musisz załadować istniejący plik DGN jako [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw różne właściwości. Utwórz instancję klasy [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) i przekaż instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Teraz wywołaj metodę [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) instancji klasy [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Przykładowy kod

Poniżej znajduje się demonstracja kodu do konwersji/eksportu [DGN](https://docs.fileformat.com/cad/dgn/) do formatu [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Eksportowanie formatu DGN AutoCAD do formatu obrazu rastrowego**

Aspose.CAD dla API .NET wprowadziło funkcjonalność ładowania pliku DGN AutoCAD i konwersji go do obrazu rastrowego. Klasa [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) służy temu celowi.

Musisz załadować istniejący plik DGN jako [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) i ustaw różne właściwości. Utwórz instancję klasy [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) i przekaż instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Teraz wywołaj metodę [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) instancji klasy [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Przykładowy kod

Poniżej znajduje się demonstracja kodu do konwersji/eksportu [DGN](https://docs.fileformat.com/cad/dgn/) do obrazu [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Wsparcie dla 3D w DGN v7**

Aspose.CAD dla API .NET wprowadziło funkcjonalność ładowania pliku [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD i wsparcia dla obiektów 3D w DGN v7. Klasa [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) służy temu celowi. Każdy obraz [DGN](https://docs.fileformat.com/cad/dgn/) wspiera 9 predefiniowanych widoków. Jest to numerowane od 1 do 9. Jeśli widok nie jest zdefiniowany podczas eksportu, dla wielostronnych formatów wyjściowych (jak PDF) wszystkie widoki będą eksportowane, każdy na osobnej stronie. Obiekty 3D wspierane są w formacie pliku DGN, tak samo jak 2D. W tym celu używane jest [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions), TypeOfEntities nie jest już używane w formacie DGN (zarówno 2D, jak i 3D wspierane jednocześnie).

### Przykładowy kod

Poniżej znajduje się przykładowy kod do przeglądania wspieranych elementów DGN.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
