---
title: Exportálás DXF formátumba
type: docs
weight: 20
url: /hu/net/developer-guide/how-to/export-file/export-to-dxf/
---

## **Hogyan exportáljunk DXF formátumba**

**Probléma:** Hogyan exportáljunk DXF formátumba.

**Tippek:** Ehhez használhatja a DxfOption-t, mind a bináris, mind a normál fájl mentési lehetőségekben.

**Megjegyzés:** Az egyik érdekes jellemző az, hogy bármely támogatott fájlformátumot elmenthetünk DXF formátumba.
Ez valóban egy nagyszerű funkció, amely számos finomsággal rendelkezik:
DXF/DWG fájlformátumból való mentés - pontosan azokat az entitásokat exportálja, amelyeket a forrás formátum tartalmaz
Más formátumokból történő exportálás - csak vonalak és szöveges entitások exportálására kerül sor.
Ezenkívül támogatjuk az ASCII és bináris DXF fájlformátumokat.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-dxf.cs" >}}
