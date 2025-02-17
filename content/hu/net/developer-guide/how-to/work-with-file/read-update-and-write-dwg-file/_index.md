---
title: DWG fájl olvasása, frissítése és írása
type: docs
weight: 11
url: /hu/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Hogyan olvassunk, frissítsünk és írjunk DWG fájlokat**

**Probléma:** Hogyan olvassunk, frissítsünk és írjunk DWG fájlokat.

**Tippek:** Ehhez a fájlt a load módszer segítségével le lehet tölteni, meg lehet szerezni a szükséges entitásokat, és változásokat lehet végrehajtani rajtuk, mint például a kezdő- és végpontok vagy a vonalak vastagságának megváltoztatása.

**Megjegyzés:** Ez a kódrészlet bemutat egy példát a dwg fájl olvasására, az objektumok (vonalak, körök, szöveges értékek) pozícióinak megváltoztatására (a támogatott olvasási/írási funkciókkal rendelkező további objektumok és értékeik változásait is hozzáadhatja), majd egy új fájlba mentésére. Így egy új fájlt megnyithat az AutoCAD-ban, és láthatja a megváltozott értékű objektumokat.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
