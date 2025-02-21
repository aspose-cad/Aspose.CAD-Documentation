---
title: Färgning av insättningar med nya tillagda lager
type: docs
weight: 23
url: /sv/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Hur man färgar insättningar med nya tillagda lager (CADNET-1146)**

**Problem:** Hur man färgar insättningar med nya tillagda lager (CADNET-1146).

**Tips:** För att göra detta, använd CadLayerTable-klassen för att skapa ett lager för att kunna lägga till ett nytt lager i ritningen, du kan också använda CadLayersList för att lägga till flera lager.

**Exempel:**

{{% alert color="primary" %}}

Den ursprungliga filen innehåller 5 insättningar med namnen "1", "2", "3", "4" och "5" och alla är i standardlager 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
