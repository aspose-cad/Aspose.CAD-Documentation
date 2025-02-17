---
title: Betűtípusok helyettesítése
type: docs
weight: 20
url: /hu/net/developer-guide/how-to/work-with-fonts/substitute-fonts/
---

## **Hogyan lehet helyettesíteni a betűtípusokat**

**Probléma:** Hogyan lehet helyettesíteni a betűtípusokat.

**Tippek:** Ehhez megadhatja azokat a betűtípusokat, amelyeket a rendszer nem telepített.

**Megjegyzés:** Ha olyan betűtípusokat kell használnia, amelyek nincsenek telepítve a rendszerre, megadhatja a hozzájuk vezető elérési utat. Az alábbiakban egy példa a szükséges betűtípusok elérési útjának megadására. Csatoltam azokat az exportálási eredményeket, ahol a szükséges betűtípusok nem voltak használva (ExampleCustomFontNotSet.png) és ahol használták őket (ExampleCustomFontSet.png), a forrást (ExampleCustomFont.dwg) és a szükséges betűtípust (RomanS.ttf).

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "substitute-fonts.cs" >}}
