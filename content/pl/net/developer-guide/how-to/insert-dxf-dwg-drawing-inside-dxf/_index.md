---
title: Wstawianie rysunku DXF/DWG wewnątrz DXF
type: docs
weight: 39
url: /pl/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Jak wstawić rysunek DXF/DWG wewnątrz DXF**

**Problem:** Jak wstawić rysunek DXF/DWG wewnątrz DXF.

**Wskazówki:** Aby to zrobić, musisz najpierw utworzyć obiekt CadInsertObject z potrzebnymi wartościami, następnie pobrać wszystkie bloki z CadBlockDictionary, utworzyć nowy blok CadBlockEntity i dodać go do CadBlockDictionary, dodać CadBlockDictionary do BlockEntities rysunku, dodać CadInsertObject do encji rysunku dla tablicy.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
