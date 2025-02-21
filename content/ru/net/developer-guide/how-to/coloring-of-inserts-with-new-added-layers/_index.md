---
title: Окрашивание вставок с новыми добавленными слоями
type: docs
weight: 23
url: /ru/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **Как окрашивать вставки с новыми добавленными слоями (CADNET-1146)**

**Проблема:** Как окрашивать вставки с новыми добавленными слоями (CADNET-1146).

**Советы:** Для этого используйте класс CadLayerTable для создания слоя, чтобы добавить новый слой в чертеж, вы также можете использовать CadLayersList для добавления нескольких слоев.

**Пример:**

{{% alert color="primary" %}}

Начальный файл содержит 5 вставок с названиями "1", "2", "3", "4" и "5", и все они находятся в слое по умолчанию 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
