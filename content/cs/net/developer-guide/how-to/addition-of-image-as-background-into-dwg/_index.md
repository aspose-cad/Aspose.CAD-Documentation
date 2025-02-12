---
title: Přidání obrázku jako pozadí do DWG
type: docs
weight: 15
url: /cs/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## Jak přidat obrázek jako pozadí do DWG

**Problém:** Jak přidat obrázek jako pozadí do DWG.

**Tipy:** Abyste tohle mohli udělat, vytvořte objekt CadRasterImageDef pro obrázek pozadí, vytvořte objekt CadRasterImage pro vložení pozadí do výkresu, přidejte objekt CadRasterImage do objektů výkresu, vytvořte objekt CadBaseObject a přidejte ho do cadImage.Objects, zpracujte všechno pomocí CadBlockTableObject.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "pridani-obrazku-jako-pozadi-do-dwg.cs" >}}
