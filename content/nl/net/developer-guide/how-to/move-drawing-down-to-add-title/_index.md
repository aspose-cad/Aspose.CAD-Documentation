---
title: Teken naar beneden verplaatsen om titel toe te voegen
type: docs
weight: 40
url: /nl/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Hoe teken naar beneden verplaatsen om titel toe te voegen**

**Probleem:** Hoe teken naar beneden verplaatsen om titel toe te voegen (CADNET-980).

**Tips:** Om dit te doen, maak een CadText-object aan met parameters, voeg deze blok toe aan de tekening, werk vervolgens de tekening bij met de nieuwe afmetingen met UpdateSize, voeg een polyline toe die een kader rond de tekening vormt, voeg de polyline toe aan BlockEntities["*Model_Space"] en werk opnieuw bij met UpdateSize.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
