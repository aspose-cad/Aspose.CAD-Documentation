---
title: Controleer of extern gerefereerde afbeeldingen bestaan en vervang referenties
type: docs
weight: 22
url: /nl/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Hoe hyperlinks op objecten te bewerken**

**Probleem:** Hoe te controleren of extern gerefereerde afbeeldingen bestaan en referenties te vervangen (CADNET-8088).

**Tips:** Hiervoor moet je een entiteit van het type CadObjectTypeName.IMAGEDEF uit de tekenentiteiten halen en CadRasterImageDef gebruiken om te controleren.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
