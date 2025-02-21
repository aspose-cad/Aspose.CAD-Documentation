---
title: Проверьте, существуют ли внешние изображения с ссылками и замените ссылки
type: docs
weight: 22
url: /ru/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Как редактировать гиперссылки на объекты**

**Проблема:** Как проверить, существуют ли внешние изображения с ссылками, и заменить ссылки (CADNET-8088).

**Советы:** Для этого получите сущность типа CadObjectTypeName.IMAGEDEF из объектов чертежа и используйте CadRasterImageDef для проверки.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
