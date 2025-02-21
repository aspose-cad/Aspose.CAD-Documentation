---
title: Eksportowanie formatu DGN AutoCAD
type: docs
weight: 50
url: /pl/python-net/developer-guide/exporting-dgn-autocad/
---

## **Eksportowanie formatu DGN AutoCAD do PDF**

Aspose.CAD dla Python API wprowadziło funkcjonalność ładowania pliku DGN AutoCAD i konwertowania go do formatu PDF. Klasa **CadImage** służy temu celowi.

Musisz załadować istniejący plik DGN jako **CadImage**. Utwórz instancję klasy **CadRasterizationOptions** i ustaw różne właściwości. Utwórz instancję klasy **PdfOptions** i przekaż instancję **CadRasterizationOptions**. Następnie wywołaj metodę **save** instancji klasy **CadImage**.

### Przykładowy kod

Poniżej znajduje się demonstracja kodu do konwersji/eksportu [DGN](https://docs.fileformat.com/cad/dgn/) do formatu [PDF](https://docs.fileformat.com/pdf/).


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Eksportowanie formatu DGN AutoCAD do formatu obrazu rasterowego**

Aspose.CAD dla Python API wprowadziło funkcjonalność ładowania pliku DGN AutoCAD i konwertowania go do obrazu rasterowego. Klasa **CadImage** służy temu celowi.

Musisz załadować istniejący plik DGN jako **CadImage**. Utwórz instancję klasy **CadRasterizationOptions** i ustaw różne właściwości. Utwórz instancję klasy **JpegOptions** i przekaż instancję **CadRasterizationOptions**. Następnie wywołaj metodę **save** instancji klasy **CadImage**.

### Przykładowy kod

Poniżej znajduje się demonstracja kodu do konwersji/eksportu [DGN](https://docs.fileformat.com/cad/dgn/) do obrazu [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Wsparcie dla bytów 3D w DGN v7**

Aspose.CAD dla Python API wprowadziło funkcjonalność ładowania pliku [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD i wsparcie bytów 3D dla DGN v7. Klasa **CadImage** służy temu celowi. Każdy obraz [DGN](https://docs.fileformat.com/cad/dgn/) wspiera 9 zdefiniowanych widoków. Jest on enumerowany od 1 do 9. Jeśli widok nie jest zdefiniowany podczas eksportu, dla formatów wyjściowych z wieloma stronami (takich jak PDF) wszystkie widoki będą eksportowane, każdy na osobnej stronie. Byty 3D są wspierane w formacie pliku DGN, a także 2D. Do tego celu używa się **VectorRasterizationOptions**, a TypeOfEntities nie jest już używane dla formatu DGN (oba 2D i 3D są wspierane jednocześnie).

### Przykładowy kod

Poniżej znajduje się przykładowy kod do przeglądania wspieranych elementów DGN.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
