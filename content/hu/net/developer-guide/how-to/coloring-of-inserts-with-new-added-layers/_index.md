---
title: A beillesztések színezése az újonnan hozzáadott rétegekkel
type: docs
weight: 23
url: /hu/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Hogyan színezze a beillesztéseket az újonnan hozzáadott rétegekkel (CADNET-1146)**

**Probléma:** Hogyan színezze a beillesztéseket az újonnan hozzáadott rétegekkel (CADNET-1146).

**Tippek:** Ehhez használja a CadLayerTable osztályt egy réteg létrehozásához, hogy új réteget adhasson hozzá a rajzhoz, a CadLayersList is használható több réteg hozzáadásához.

**Példa:**

{{% alert color="primary" %}}

A kezdeti fájl 5 beillesztést tartalmaz "1", "2", "3", "4" és "5" nevekkel, és mindegyik az alapértelmezett 0 rétegben található.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
