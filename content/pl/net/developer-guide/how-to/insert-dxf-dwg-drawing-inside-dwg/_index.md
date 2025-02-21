---
title: Wstawianie rysunku DXF/DWG wewnątrz DWG
type: docs
weight: 38
url: /pl/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Jak wstawić rysunek DXF/DWG wewnątrz DWG**

**Problem:** Jak wstawić rysunek DXF/DWG wewnątrz DWG.

**Wskazówki:** Aby to zrobić, najpierw utwórz obiekt CadInsertObject z wymaganymi wartościami, następnie pobierz wszystkie bloki w CadBlockDictionary, utwórz nowy blok CadBlockEntity i dodaj go do CadBlockDictionary, dodaj CadBlockDictionary do BlockEntities rysunku, dodaj CadInsertObject do jednostki rysunkowej dla tablicy, utwórz CadBlockTableObject przez odniesienie, a następnie dodaj blok do rysunku.

**Przykład:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
