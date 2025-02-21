---
title: Kontrollera om externa refererade bilder finns och ersätt referenser
type: docs
weight: 22
url: /sv/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Hur man redigerar hyperlänkar på objekt**

**Problem:** Hur man kontrollerar om externa refererade bilder finns och ersätter referenser (CADNET-8088).

**Tips:** För att göra detta, hämta en enhet av typen CadObjectTypeName.IMAGEDEF från ritningsenheterna och använd CadRasterImageDef för att kontrollera.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
