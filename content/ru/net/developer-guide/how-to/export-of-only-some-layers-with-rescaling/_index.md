---
title: Экспорт только некоторых слоев с изменением масштаба
type: docs
weight: 31
url: /ru/net/developer-guide/how-to/export-of-only-some-layers-with-rescaling/
---

## **Экспорт только некоторых слоев с изменением масштаба (CADNET-559)**

**Проблема:** Как экспортировать только некоторые слои с изменением масштаба (CADNET-559).

**Советы:** Чтобы это сделать, выберите необходимые слои, добавьте их в массив CadBaseEntity, затем назначьте их чертежным сущностям и выполните UpdateSize.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-of-only-some-layers-with-rescaling.cs" >}}
