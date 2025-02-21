---
title: Не экспортировать скрытый слой и слои по имени
type: docs
weight: 26
url: /ru/net/developer-guide/how-to/do-not-export-hidden-layer-and-layers-by-name/
---

## **Как не экспортировать скрытый слой и слои по имени**

**Проблема:** Как не экспортировать скрытый слой и слои по имени.

**Советы:** Для этого вам необходимо создать массив слоев, которые не называются "LayerToHide", и добавить их в rasterizationOptions.Layers.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "do-not-export-hidden-layer-and-layers-by-name.cs" >}}
