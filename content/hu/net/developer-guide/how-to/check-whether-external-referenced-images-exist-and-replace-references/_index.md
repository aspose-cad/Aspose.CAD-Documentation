---
title: Ellenőrizze, hogy a külső hivatkozású képek léteznek-e, és cserélje ki a hivatkozásokat
type: docs
weight: 22
url: /hu/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Hogyan szerkesszük a hivatkozásokat az objektumokon**

**Probléma:** Hogyan ellenőrizzük, hogy a külső hivatkozású képek léteznek-e, és cseréljük ki a hivatkozásokat (CADNET-8088).

**Tippek:** Ehhez szerezzünk egy CadObjectTypeName.IMAGEDEF típusú entitást a rajzi entitásokból, és használjuk a CadRasterImageDef-ot az ellenőrzéshez.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
