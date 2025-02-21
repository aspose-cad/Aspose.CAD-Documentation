---
title: Rysunki DXF
type: docs
weight: 10
url: /pl/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Eksportowanie rysunków DXF do PDF**

Aspose.CAD oferuje funkcję ładowania obiektów rysunków DXF z AutoCAD i renderowania ich jako całego rysunku do formatu PDF. Podejście konwersji DXF do PDF działa w następujący sposób:

1. Załaduj plik rysunku DXF używając metody fabrycznej **Image.load**.
1. Utwórz obiekt klasy **CadRasterizationOptions** i ustaw właściwości **page_height** i **page_width**.
1. Utwórz obiekt klasy **PdfOptions** i ustaw właściwość **VectorRasterizationOptions**.
1. Wywołaj **Image.save**, przekazując obiekt **PdfOptions** jako drugi parametr.

Poniższy przykład kodu pokazuje, jak przekonwertować plik przy użyciu ustawień domyślnych.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Obsługiwane formaty**

Obecnie w pełni obsługujemy formaty plików AutoCAD DXF 2010. Poprzednie wersje DXF nie są gwarantowane jako 100% poprawne. Planujemy w przyszłych wersjach Aspose.CAD wprowadzić więcej formatów i funkcji.

### **Obsługiwane encje**

Obecnie wspieramy wszystkie powszechne encje 2D oraz ich podstawowe domyślne parametry, które są następujące:

1. Wymiar wyrównany
1. Wymiar kątowy
1. Łuk
1. Atrybut
1. Odniesienie bloku
1. Koło
1. Wymiar średnicy
1. Elipsa
1. Wzór
1. Linia
1. Tekst wieloliniowy
1. Wymiar współrzędny
1. Punkt
1. Linia łamana
1. Wymiar radialny
1. Promień
1. Wymiar obrotowy
1. Tabela
1. Tekst
1. Linia X

{{% alert color="primary" %}}

Jeśli podczas analizy napotkamy encję lub właściwość, której nie obsługujemy, encja lub właściwość będą ignorowane bez ostrzeżenia.

{{% /alert %}}

## **Eksportowanie osnowy DGN osadzonej w formacie DXF**

Aspose.CAD oferuje funkcję ładowania plików DXF z AutoCAD i eksportowania osnowy DGN osadzonej w formacie DXF.

Poniższy przykład kodu pokazuje, jak osiągnąć określone wymagania.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Wsparcie dla zapisywania plików DXF**

Aspose.CAD oferuje funkcję ładowania plików DXF z AutoCAD, wprowadzania w nich zmian i ponownego zapisywania ich jako plik DXF.

Poniższy przykład kodu pokazuje, jak osiągnąć określone wymagania.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Eksport DXF do WMF**

To podejście działa w następujący sposób:

1. Załaduj plik rysunku DXF używając metody fabrycznej **Image.load**.
1. Utwórz obiekt klasy **CadRasterizationOptions** i załaduj pliki PDF.
1. Ustaw właściwości **page_height** i **page_width**.
1. Wywołaj **Image.save** i zapisz plik.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
