---
title: Färbung von Einfügungen mit neu hinzugefügten Ebenen
type: docs
weight: 23
url: /de/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Wie man Einfügungen mit neu hinzugefügten Ebenen färbt (CADNET-1146)**

**Problem:** Wie man Einfügungen mit neu hinzugefügten Ebenen färbt (CADNET-1146).

**Tipps:** Verwenden Sie dazu die Klasse CadLayerTable, um eine Ebene zu erstellen, um eine neue Ebene zur Zeichnung hinzufügen zu können. Sie können auch CadLayersList verwenden, um mehrere Ebenen hinzuzufügen.

**Beispiel:**

{{% alert color="primary" %}}

Die ursprüngliche Datei enthält 5 Einfügungen mit den Namen "1", "2", "3", "4" und "5", und alle befinden sich in der Standardebene 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
