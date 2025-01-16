---
title: Ověřte, zda existují externě odkazované obrázky a nahraďte odkazy
type: docs
weight: 22
url: /cs/net/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Jak upravit hyperodkazy na objekty**

**Problém:** Jak ověřit, zda existují externě odkazované obrázky a nahradit odkazy (CADNET-8088).

**Tipy:** Pro provedení této akce získejte entitu typu CadObjectTypeName.IMAGEDEF z entit v kresbě a použijte CadRasterImageDef k ověření.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
