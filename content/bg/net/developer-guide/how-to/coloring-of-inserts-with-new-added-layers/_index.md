---
title: Оцветяване на вмъквания с нови добавени слоеве
type: docs
weight: 23
url: /bg/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Как се оцветяват вмъкванията с нови добавени слоеве (CADNET-1146)**

**Проблем:** Как се оцветяват вмъкванията с нови добавени слоеве (CADNET-1146).

**Съвети:** За да постигнете това, използвайте класа CadLayerTable, за да създадете слой, който може да бъде добавен към чертежа. Също така може да използвате CadLayersList, за да добавите множество слоеве.

**Пример:**

{{% alert color="primary" %}}

Началният файл съдържа 5 вмъквания с имена "1", "2", "3", "4" и "5", които са всички на стандартния слой 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
