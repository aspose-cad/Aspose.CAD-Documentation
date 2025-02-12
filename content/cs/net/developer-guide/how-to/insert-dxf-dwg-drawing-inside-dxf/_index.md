---
title: Vložení kresby DXF/DWG do souboru DXF
type: docs
weight: 39
url: /cs/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Jak vložit kresbu DXF/DWG do souboru DXF**

**Problém:** Jak vložit kresbu DXF/DWG do souboru DXF.

**Tipy:** Abyste tohoto dosáhli, musíte nejprve vytvořit objekt CadInsertObject s potřebnými hodnotami, poté získat všechny bloky v CadBlockDictionary, vytvořit nový blok CadBlockEntity a přidat ho do CadBlockDictionary, přidat CadBlockDictionary do BlockEntities výkresu, přidat CadInsertObject do entit výkresu pro pole.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
