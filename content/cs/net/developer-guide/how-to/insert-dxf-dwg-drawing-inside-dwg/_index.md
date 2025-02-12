---
title: Vložení výkresu DXF/DWG do souboru DWG
type: docs
weight: 38
url: /cs/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Jak vložit výkres DXF/DWG do souboru DWG**

**Problém:** Jak vložit výkres DXF/DWG do souboru DWG.

**Tipy:** Abyste toho dosáhli, nejprve vytvořte CadInsertObject s potřebnými hodnotami, poté získáme všechny bloky v CadBlockDictionary, vytvořte nový blok CadBlockEntity a přidejte ho do CadBlockDictionary, přidejte CadBlockDictionary do BlockEntities výkresu, přidejte CadInsertObject do entit výkresu pro pole, vytvořte CadBlockTableObject podle reference a pak přidejte blok do výkresu.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "vlozeni-vykresu-dxf-dwg-do-dwg.cs" >}}
